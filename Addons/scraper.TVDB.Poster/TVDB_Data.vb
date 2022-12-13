﻿' ################################################################################
' #                             EMBER MEDIA MANAGER                              #
' ################################################################################
' ################################################################################
' # This file is part of Ember Media Manager.                                    #
' #                                                                              #
' # Ember Media Manager is free software: you can redistribute it and/or modify  #
' # it under the terms of the GNU General Public License as published by         #
' # the Free Software Foundation, either version 3 of the License, or            #
' # (at your option) any later version.                                          #
' #                                                                              #
' # Ember Media Manager is distributed in the hope that it will be useful,       #
' # but WITHOUT ANY WARRANTY; without even the implied warranty of               #
' # MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the                #
' # GNU General Public License for more details.                                 #
' #                                                                              #
' # You should have received a copy of the GNU General Public License            #
' # along with Ember Media Manager.  If not, see <http://www.gnu.org/licenses/>. #
' ################################################################################

Imports System.IO
Imports EmberAPI


Public Class TVDB_Data
    Implements Interfaces.ScraperModule_TV

#Region "Fields"

    Public Shared _AssemblyName As String

    Public Shared TVScraper As Scraper
    Public Shared ConfigOptions As New Structures.ScrapeOptions_TV

    Private strPrivateAPIKey As String = String.Empty
    Private _Name As String = "TVDB Data Poster"
    Private _ScraperEnabled As Boolean = False
    Private _setup As frmTVInfoSettingsHolder
    Private _TVDBMirror As String
    Private _APIKey As String
    Private _Lang As String


#End Region 'Fields

#Region "Events"

    Public Event ModuleSettingsChanged() Implements Interfaces.ScraperModule_TV.ModuleSettingsChanged

    Public Event SetupScraperChanged(ByVal name As String, ByVal State As Boolean, ByVal difforder As Integer) Implements Interfaces.ScraperModule_TV.SetupScraperChanged

    Public Event TVScraperEvent(ByVal eType As Enums.ScraperEventType_TV, ByVal iProgress As Integer, ByVal Parameter As Object) Implements Interfaces.ScraperModule_TV.TVScraperEvent

    Public Event SetupNeedsRestart() Implements Interfaces.ScraperModule_TV.SetupNeedsRestart

#End Region 'Events

#Region "Properties"

    Public ReadOnly Property IsBusy() As Boolean Implements Interfaces.ScraperModule_TV.IsBusy
        Get
            Return TVScraper.IsBusy
        End Get
    End Property

    Public ReadOnly Property ModuleName() As String Implements Interfaces.ScraperModule_TV.ModuleName
        Get
            Return _Name
        End Get
    End Property

    Public ReadOnly Property ModuleVersion() As String Implements Interfaces.ScraperModule_TV.ModuleVersion
        Get
            Return FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileVersion.ToString
        End Get
    End Property

    Public Property ScraperEnabled() As Boolean Implements Interfaces.ScraperModule_TV.ScraperEnabled
        Get
            Return _ScraperEnabled
        End Get
        Set(ByVal value As Boolean)
            _ScraperEnabled = value
        End Set
    End Property

#End Region 'Properties

#Region "Methods"

    Public Sub CancelAsync() Implements Interfaces.ScraperModule_TV.CancelAsync
        TVScraper.CancelAsync()
    End Sub

    Public Function ChangeEpisode(ByVal ShowID As Integer, ByVal TVDBID As String, ByVal Lang As String, ByRef epDet As MediaContainers.EpisodeDetails) As Interfaces.ModuleResult Implements Interfaces.ScraperModule_TV.ChangeEpisode
        epDet = TVScraper.ChangeEpisode(ShowID, TVDBID, Lang)
        Return New Interfaces.ModuleResult With {.breakChain = False}
    End Function

    Public Function GetLangs(ByVal sMirror As String, ByRef Langs As clsXMLTVDBLanguages) As Interfaces.ModuleResult Implements Interfaces.ScraperModule_TV.GetLangs
        Langs = TVScraper.GetLangs(sMirror)
        Return New Interfaces.ModuleResult With {.breakChain = True}
    End Function

    Public Function GetSingleImage(ByVal Title As String, ByVal ShowID As Integer, ByVal TVDBID As String, ByVal Type As Enums.ImageType_TV, ByVal Season As Integer, ByVal Episode As Integer, ByVal Lang As String, ByVal Ordering As Enums.Ordering, ByVal CurrentImage As Images, ByRef Image As Images) As Interfaces.ModuleResult Implements Interfaces.ScraperModule_TV.GetSingleImage
        TVScraper.GetSingleImage(Title, ShowID, TVDBID, Type, Season, Episode, Lang, Ordering, CurrentImage, Image)
        Return New Interfaces.ModuleResult With {.breakChain = True}
    End Function

    Public Sub Handler_ScraperEvent(ByVal eType As Enums.ScraperEventType_TV, ByVal iProgress As Integer, ByVal Parameter As Object)
        RaiseEvent TVScraperEvent(eType, iProgress, Parameter)
    End Sub

    Private Sub Handle_SetupNeedsRestart()
        RaiseEvent SetupNeedsRestart()
    End Sub

    Public Sub Init(ByVal sAssemblyName As String) Implements Interfaces.ScraperModule_TV.Init
        _AssemblyName = sAssemblyName
        strPrivateAPIKey = clsAdvancedSettings.GetSetting("TVDBAPIKey", "")
        _APIKey = If(String.IsNullOrEmpty(strPrivateAPIKey), "353783CE455412FD", strPrivateAPIKey)
        _Lang = clsAdvancedSettings.GetSetting("TVDBLanguage", If(Not String.IsNullOrEmpty(Master.eSettings.TVGeneralLanguage), Master.eSettings.TVGeneralLanguage, "en"))
        _TVDBMirror = clsAdvancedSettings.GetSetting("TVDBMirror", "thetvdb.com")
        TVScraper = New Scraper(_APIKey)

        LoadSettings()

        AddHandler TVScraper.ScraperEvent, AddressOf Handler_ScraperEvent
    End Sub

    Public Function InjectSetupScraper() As Containers.SettingsPanel Implements Interfaces.ScraperModule_TV.InjectSetupScraper
        Dim SPanel As New Containers.SettingsPanel
        _setup = New frmTVInfoSettingsHolder
        LoadSettings()
        _setup.txtApiKey.Text = strPrivateAPIKey
        _setup.chkEnabled.Checked = _ScraperEnabled

        If _setup.cbTVScraperLanguage.Items.Count > 0 Then
            _setup.cbTVScraperLanguage.Text = Master.eSettings.TVGeneralLanguages.Language.FirstOrDefault(Function(l) l.abbreviation = _Lang).name
        End If

        _setup.txtTVDBMirror.Text = _TVDBMirror
        _setup.chkScraperShowTitle.Checked = ConfigOptions.bShowTitle
        _setup.chkScraperShowEGU.Checked = ConfigOptions.bShowEpisodeGuide
        _setup.chkScraperShowGenre.Checked = ConfigOptions.bShowGenre
        _setup.chkScraperShowMPAA.Checked = ConfigOptions.bShowMPAA
        _setup.chkScraperShowPlot.Checked = ConfigOptions.bShowPlot
        _setup.chkScraperShowPremiered.Checked = ConfigOptions.bShowPremiered
        _setup.chkScraperShowRating.Checked = ConfigOptions.bShowRating
        _setup.chkScraperShowRuntime.Checked = ConfigOptions.bShowRuntime
        _setup.chkScraperShowStatus.Checked = ConfigOptions.bShowStatus
        _setup.chkScraperShowStudio.Checked = ConfigOptions.bShowStudio
        _setup.chkScraperShowActors.Checked = ConfigOptions.bShowActors
        _setup.chkScraperShowVotes.Checked = ConfigOptions.bShowVotes
        _setup.chkScraperEpTitle.Checked = ConfigOptions.bEpTitle
        _setup.chkScraperEpSeason.Checked = ConfigOptions.bEpSeason
        _setup.chkScraperEpEpisode.Checked = ConfigOptions.bEpEpisode
        _setup.chkScraperEpGuestStars.Checked = ConfigOptions.bEpGuestStars
        _setup.chkScraperEpAired.Checked = ConfigOptions.bEpAired
        _setup.chkScraperEpRating.Checked = ConfigOptions.bEpRating
        _setup.chkScraperEpPlot.Checked = ConfigOptions.bEpPlot
        _setup.chkScraperEpDirector.Checked = ConfigOptions.bEpDirector
        _setup.chkScraperEpCredits.Checked = ConfigOptions.bEpCredits
        _setup.chkScraperEpActors.Checked = ConfigOptions.bEpActors
        _setup.chkScraperEpVotes.Checked = ConfigOptions.bEpVotes

        If Not String.IsNullOrEmpty(strPrivateAPIKey) Then
            _setup.btnUnlockAPI.Text = Master.eLang.GetString(443, "Use embedded API Key")
            _setup.lblEMMAPI.Visible = False
            _setup.txtApiKey.Enabled = True
        End If

        SPanel.Name = String.Concat(Me._Name, "Scraper")
        SPanel.Text = "TVDB"
        SPanel.Prefix = "TVDBMedia_"
        SPanel.Type = Master.eLang.GetString(653, "TV Shows")
        SPanel.ImageIndex = If(Me._ScraperEnabled, 9, 10)
        SPanel.Order = 100
        SPanel.Panel = Me._setup.pnlSettings
        SPanel.Parent = "pnlTVData"
        AddHandler _setup.SetupScraperChanged, AddressOf Handle_SetupScraperChanged
        AddHandler _setup.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged
        AddHandler _setup.SetupNeedsRestart, AddressOf Handle_SetupNeedsRestart
        Return SPanel
    End Function

    Private Sub Handle_ModuleSettingsChanged()
        strPrivateAPIKey = _setup.txtApiKey.Text
        _TVDBMirror = _setup.txtTVDBMirror.Text
        _Lang = Master.eSettings.TVGeneralLanguages.Language.FirstOrDefault(Function(l) l.name = _setup.cbTVScraperLanguage.Text).abbreviation
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub Handle_SetupScraperChanged(ByVal state As Boolean, ByVal difforder As Integer)
        ScraperEnabled = state
        RaiseEvent SetupScraperChanged(String.Concat(Me._Name, "Scraper"), state, difforder)
    End Sub

    Sub LoadSettings()
        ConfigOptions.bEpActors = clsAdvancedSettings.GetBooleanSetting("ScraperEpActors", True)
        ConfigOptions.bEpAired = clsAdvancedSettings.GetBooleanSetting("ScraperEpAired", True)
        ConfigOptions.bEpCredits = clsAdvancedSettings.GetBooleanSetting("ScraperEpCredits", True)
        ConfigOptions.bEpDirector = clsAdvancedSettings.GetBooleanSetting("ScraperEpDirector", True)
        ConfigOptions.bEpEpisode = clsAdvancedSettings.GetBooleanSetting("ScraperEpEpisode", True)
        ConfigOptions.bEpGuestStars = clsAdvancedSettings.GetBooleanSetting("ScraperEpGuestStars", True)
        ConfigOptions.bEpPlot = clsAdvancedSettings.GetBooleanSetting("ScraperEpPlot", True)
        ConfigOptions.bEpRating = clsAdvancedSettings.GetBooleanSetting("ScraperEpRating", True)
        ConfigOptions.bEpSeason = clsAdvancedSettings.GetBooleanSetting("ScraperEpSeason", True)
        ConfigOptions.bEpTitle = clsAdvancedSettings.GetBooleanSetting("ScraperEpTitle", True)
        ConfigOptions.bEpVotes = clsAdvancedSettings.GetBooleanSetting("ScraperEpVotes", True)
        ConfigOptions.bShowActors = clsAdvancedSettings.GetBooleanSetting("ScraperShowActors", True)
        ConfigOptions.bShowEpisodeGuide = clsAdvancedSettings.GetBooleanSetting("ScraperShowEGU", False)
        ConfigOptions.bShowGenre = clsAdvancedSettings.GetBooleanSetting("ScraperShowGenre", True)
        ConfigOptions.bShowMPAA = clsAdvancedSettings.GetBooleanSetting("ScraperShowMPAA", True)
        ConfigOptions.bShowPlot = clsAdvancedSettings.GetBooleanSetting("ScraperShowPlot", True)
        ConfigOptions.bShowPremiered = clsAdvancedSettings.GetBooleanSetting("ScraperShowPremiered", True)
        ConfigOptions.bShowRating = clsAdvancedSettings.GetBooleanSetting("ScraperShowRating", True)
        ConfigOptions.bShowRuntime = clsAdvancedSettings.GetBooleanSetting("ScraperShowRuntime", True)
        ConfigOptions.bShowStatus = clsAdvancedSettings.GetBooleanSetting("ScraperShowStatus", True)
        ConfigOptions.bShowStudio = clsAdvancedSettings.GetBooleanSetting("ScraperShowStudio", True)
        ConfigOptions.bShowTitle = clsAdvancedSettings.GetBooleanSetting("ScraperShowTitle", True)
        ConfigOptions.bShowVotes = clsAdvancedSettings.GetBooleanSetting("ScraperShowVotes", True)
    End Sub

    Public Function SaveImages() As Interfaces.ModuleResult Implements Interfaces.ScraperModule_TV.SaveImages
        TVScraper.SaveImages()
        Return New Interfaces.ModuleResult With {.breakChain = False}
    End Function

    Public Sub SaveSetupScraper(ByVal DoDispose As Boolean) Implements Interfaces.ScraperModule_TV.SaveSetupScraper
        Using settings = New clsAdvancedSettings()
            settings.SetSetting("TVDBAPIKey", strPrivateAPIKey)
            If Not String.IsNullOrEmpty(_Lang) Then
                settings.SetSetting("TVDBLanguage", _Lang)
            Else
                settings.SetSetting("TVDBLanguage", "en")
            End If

            If Not String.IsNullOrEmpty(_TVDBMirror) Then
                settings.SetSetting("TVDBMirror", _TVDBMirror.Replace("http://", String.Empty))
            Else
                settings.SetSetting("TVDBMirror", "thetvdb.com")
            End If
            settings.SetBooleanSetting("ScraperShowTitle", _setup.chkScraperShowTitle.Checked)
            settings.SetBooleanSetting("ScraperShowEGU", _setup.chkScraperShowEGU.Checked)
            settings.SetBooleanSetting("ScraperShowGenre", _setup.chkScraperShowGenre.Checked)
            settings.SetBooleanSetting("ScraperShowMPAA", _setup.chkScraperShowMPAA.Checked)
            settings.SetBooleanSetting("ScraperShowPlot", _setup.chkScraperShowPlot.Checked)
            settings.SetBooleanSetting("ScraperShowPremiered", _setup.chkScraperShowPremiered.Checked)
            settings.SetBooleanSetting("ScraperShowRating", _setup.chkScraperShowRating.Checked)
            settings.SetBooleanSetting("ScraperShowStatus", _setup.chkScraperShowStatus.Checked)
            settings.SetBooleanSetting("ScraperShowStudio", _setup.chkScraperShowStudio.Checked)
            settings.SetBooleanSetting("ScraperShowActors", _setup.chkScraperShowActors.Checked)
            settings.SetBooleanSetting("ScraperShowVotes", _setup.chkScraperShowVotes.Checked)
            settings.SetBooleanSetting("ScraperEpTitle", _setup.chkScraperEpTitle.Checked)
            settings.SetBooleanSetting("ScraperEpSeason", _setup.chkScraperEpSeason.Checked)
            settings.SetBooleanSetting("ScraperEpEpisode", _setup.chkScraperEpEpisode.Checked)
            settings.SetBooleanSetting("ScraperEpAired", _setup.chkScraperEpAired.Checked)
            settings.SetBooleanSetting("ScraperEpRating", _setup.chkScraperEpRating.Checked)
            settings.SetBooleanSetting("ScraperEpPlot", _setup.chkScraperEpPlot.Checked)
            settings.SetBooleanSetting("ScraperEpDirector", _setup.chkScraperEpDirector.Checked)
            settings.SetBooleanSetting("ScraperEpGuestStars", _setup.chkScraperEpGuestStars.Checked)
            settings.SetBooleanSetting("ScraperEpCredits", _setup.chkScraperEpCredits.Checked)
            settings.SetBooleanSetting("ScraperEpActors", _setup.chkScraperEpActors.Checked)
            settings.SetBooleanSetting("ScraperEpVotes", _setup.chkScraperEpVotes.Checked)
        End Using

        If DoDispose Then
            RemoveHandler _setup.SetupScraperChanged, AddressOf Handle_SetupScraperChanged
            RemoveHandler _setup.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged
            _setup.Dispose()
        End If

    End Sub

    Public Function ScrapeEpisode(ByVal ShowID As Integer, ByVal ShowTitle As String, ByVal TVDBID As String, ByVal iEpisode As Integer, ByVal iSeason As Integer, ByVal Aired As String, ByVal Lang As String, ByVal Ordering As Enums.Ordering, ByVal Options As Structures.ScrapeOptions_TV) As Interfaces.ModuleResult Implements Interfaces.ScraperModule_TV.ScrapeEpisode
        LoadSettings()
        Dim filterOptions As Structures.ScrapeOptions_TV = Functions.TVScrapeOptionsAndAlso(Options, ConfigOptions)
        TVScraper.ScrapeEpisode(ShowID, ShowTitle, TVDBID, iEpisode, iSeason, Aired, Lang, Ordering, filterOptions)
        Return New Interfaces.ModuleResult With {.breakChain = False}
    End Function

    Public Function GetSingleEpisode(ByVal ShowID As Integer, ByVal TVDBID As String, ByVal Season As Integer, ByVal Episode As Integer, ByVal Lang As String, ByVal Ordering As Enums.Ordering, ByVal Options As Structures.ScrapeOptions_TV, ByRef epDetails As MediaContainers.EpisodeDetails) As Interfaces.ModuleResult Implements Interfaces.ScraperModule_TV.GetSingleEpisode
        epDetails = TVScraper.GetSingleEpisode(ShowID, TVDBID, Season, Episode, Lang, Ordering, Options)
        Return New Interfaces.ModuleResult With {.breakChain = False}
    End Function

    Public Function GetSingleEpisode(ByVal ShowID As Integer, ByVal TVDBID As String, ByVal Aired As String, ByVal Lang As String, ByVal Ordering As Enums.Ordering, ByVal Options As Structures.ScrapeOptions_TV, ByRef epDetails As MediaContainers.EpisodeDetails) As Interfaces.ModuleResult Implements Interfaces.ScraperModule_TV.GetSingleEpisode
        epDetails = TVScraper.GetSingleEpisode(ShowID, TVDBID, Aired, Lang, Ordering, Options)
        Return New Interfaces.ModuleResult With {.breakChain = False}
    End Function

    Public Function Scraper(ByVal ShowID As Integer, ByVal ShowTitle As String, ByVal TVDBID As String, ByVal ShowLang As String, ByVal SourceLang As String, ByVal Ordering As Enums.Ordering, ByVal Options As Structures.ScrapeOptions_TV, ByVal ScrapeType As Enums.ScrapeType_Movie_MovieSet_TV, ByVal WithCurrent As Boolean) As Interfaces.ModuleResult Implements Interfaces.ScraperModule_TV.Scraper
        LoadSettings()
        Dim filterOptions As Structures.ScrapeOptions_TV = Functions.TVScrapeOptionsAndAlso(Options, ConfigOptions)
        TVScraper.SingleScrape(ShowID, ShowTitle, TVDBID, ShowLang, SourceLang, Ordering, filterOptions, ScrapeType, WithCurrent)
        Return New Interfaces.ModuleResult With {.breakChain = False}
    End Function

    Public Function ScrapeSeason(ByVal ShowID As Integer, ByVal ShowTitle As String, ByVal TVDBID As String, ByVal iSeason As Integer, ByVal Lang As String, ByVal Ordering As Enums.Ordering, ByVal Options As Structures.ScrapeOptions_TV) As Interfaces.ModuleResult Implements Interfaces.ScraperModule_TV.ScrapeSeason
        LoadSettings()
        Dim filterOptions As Structures.ScrapeOptions_TV = Functions.TVScrapeOptionsAndAlso(Options, ConfigOptions)
        TVScraper.ScrapeSeason(ShowID, ShowTitle, TVDBID, iSeason, Lang, Ordering, filterOptions)
        Return New Interfaces.ModuleResult With {.breakChain = False}
    End Function

#End Region 'Methods

End Class