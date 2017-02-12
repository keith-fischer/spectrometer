
Imports System.Runtime.InteropServices

Public Enum EventCode
    Complete = &H1
    UserAbort = &H2
    ErrorAbort = &H3
    Time = &H4
    Repaint = &H5
    StErrStopped = &H6
    StErrStPlaying = &H7
    ErrorStPlaying = &H8
    PaletteChanged = &H9
    VideoSizeChanged = &HA
    QualityChange = &HB
    ShuttingDown = &HC
    ClockChanged = &HD
    Paused = &HE
    OpeningFile = &H10
    BufferingData = &H11
    FullScreenLost = &H12
    Activate = &H13
    NeedRestart = &H14
    WindowDestroyed = &H15
    DisplayChanged = &H16
    Starvation = &H17
    OleEvent = &H18
    NotifyWindow = &H19
    StreamControlStopped = &H1A
    StreamControlStarted = &H1B
    EndOfSegment = &H1C
    SegmentStarted = &H1D
    LengthChanged = &H1E
    DeviceLost = &H1F
    SampleNeeded = &H20
    ProcessingLatency = &H21
    SampleLatency = &H22
    ScrubTime = &H23
    StepComplete = &H24
    SkipFrames = &H25
    TimeCodeAvailable = &H30
    ExtDeviceModeChange = &H31
    StateChange = &H32
    PleaseReOpen = &H40
    Status = &H41
    MarkerHit = &H42
    LoadStatus = &H43
    FileClosed = &H44
    ErrorAbortEx = &H45
    EOSSoon = &H46
    ContentPropertyChanged = &H47
    BandwidthChange = &H48
    VideoFrameReady = &H49
    GraphChanged = &H50
    ClockUnset = &H51
    VMRRenderDeviceSet = &H53
    VMRSurfaceFlipped = &H54
    VMRReconnectionFailed = &H55
    PreprocessComplete = &H56
    CodecApiEvent = &H57
    DvdDomainChange = &H101
    DvdTitleChange = &H102
    DvdChapterStart = &H103
    DvdAudioStreamChange = &H104
    DvdSubPicictureStreamChange = &H105
    DvdAngleChange = &H106
    DvdButtonChange = &H107
    DvdValidUopsChange = &H108
    DvdStillOn = &H109
    DvdStillOff = &H10A
    DvdCurrentTime = &H10B
    DvdError = &H10C
    DvdWarning = &H10D
    DvdChapterAutoStop = &H10E
    DvdNoFpPgc = &H10F
    DvdPlaybackRateChange = &H110
    DvdParentalLevelChange = &H111
    DvdPlaybackStopped = &H112
    DvdAnglesAvailable = &H113
    DvdPlayPeriodAutoStop = &H114
    DvdButtonAutoActivated = &H115
    DvdCmdStart = &H116
    DvdCmdEnd = &H117
    DvdDiscEjected = &H118
    DvdDiscInserted = &H119
    DvdCurrentHmsfTime = &H11A
    DvdKaraokeMode = &H11B
    DvdProgramCellChange = &H11C
    DvdTitleSetChange = &H11D
    DvdProgramChainChange = &H11E 
    DvdVOBU_Offset = &H11F
    DvdVOBU_Timestamp = &H120
    DvdGPRM_Change = &H121
    DvdSPRM_Change = &H122
    DvdBeginNavigationCommands = &H123
    DvdNavigationCommand = &H124
    SNDDEVInError = &H200
    SNDDEVOutError = &H201
    WMTIndexEvent = &H251
    WMTEvent = &H252
    Built = &H300
    Unbuilt = &H301
    StreamBufferTimeHole = &H326
    StreamBufferStaleDataRead = &H327
    StreamBufferStaleFileDeleted = &H328
    StreamBufferContentBecomingStale = &H329
    StreamBufferWriteFailure = &H32A
    StreamBufferReadFailure = &H32B
    StreamBufferRateChanged = &H32C
End Enum

