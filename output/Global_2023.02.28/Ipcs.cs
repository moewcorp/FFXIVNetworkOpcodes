// Generated by https://github.com/gamous/FFXIVNetworkOpcodes
namespace FFXIVOpcodes.Global
{
    public enum ServerLobbyIpcType : ushort
    {
    
    };
    
    public enum ClientLobbyIpcType : ushort
    {
    
    };
    
    public enum ServerZoneIpcType : ushort
    {
        PlayerSpawn = 0x0100,
        NpcSpawn = 0x01C0,
        NpcSpawn2 = 0x0163,
        ActorFreeSpawn = 0x00CD,
        ObjectSpawn = 0x01F4,
        ObjectDespawn = 0x02CB,
        CreateTreasure = 0x00E6,
        OpenTreasure = 0x016B,
        TreasureFadeOut = 0x03D8,
        ActorMove = 0x00B4,
        _record_unk10_ = 0x03CD,
        Transfer = 0x02A2,
        Effect = 0x00D4,
        AoeEffect8 = 0x01A4,
        AoeEffect16 = 0x01C9,
        AoeEffect24 = 0x0252,
        AoeEffect32 = 0x02C8,
        ActorCast = 0x0291,
        ActorControl = 0x01BB,
        ActorControlTarget = 0x019D,
        ActorControlSelf = 0x0228,
        DirectorVars = 0x0215,
        ContentDirectorSync = 0x02B6,
        _record_unk23_ = 0x036A,
        EnvironmentControl = 0x0126,
        _record_unk29_ = 0x01B6,
        LandSetMap = 0x030D,
        _record_unk31_ = 0x007C,
        EventStart = 0x008F,
        EventFinish = 0x039A,
        EventPlay = 0x017F,
        EventPlay4 = 0x00CA,
        EventPlay8 = 0x0175,
        EventPlay16 = 0x026A,
        EventPlay32 = 0x0074,
        EventPlay64 = 0x0255,
        EventPlay128 = 0x0330,
        EventPlay255 = 0x00DD,
        BattleTalk2 = 0x0165,
        BattleTalk4 = 0x01C6,
        BattleTalk8 = 0x0360,
        BalloonTalk2 = 0x0290,
        BalloonTalk4 = 0x01E4,
        BalloonTalk8 = 0x0388,
        SystemLogMessage = 0x00F7,
        SystemLogMessage32 = 0x0082,
        SystemLogMessage48 = 0x00FC,
        SystemLogMessage80 = 0x0202,
        SystemLogMessage144 = 0x01AC,
        NpcYell = 0x010D,
        ActorSetPos = 0x02E5,
        PrepareZoning = 0x0099,
        _record_unk58_ = 0x0340,
        StatusEffectList3 = 0x0123,
        WeatherChange = 0x0371,
        UpdateParty = 0x03BB,
        UpdateAlliance = 0x0398,
        UpdateSpAlliance = 0x021D,
        UpdateHpMpTp = 0x0394,
        StatusEffectList = 0x02D4,
        EurekaStatusEffectList = 0x03D0,
        StatusEffectList2 = 0x03DE,
        BossStatusEffectList = 0x035D,
        EffectResult = 0x037B,
        EffectResult4 = 0x0105,
        EffectResult8 = 0x012E,
        EffectResult16 = 0x03C4,
        EffectResultBasic = 0x01FB,
        EffectResultBasic4 = 0x0314,
        EffectResultBasic8 = 0x0093,
        EffectResultBasic16 = 0x009C,
        EffectResultBasic32 = 0x02BF,
        EffectResultBasic64 = 0x02A7,
        PartyPos = 0x0346,
        AlliancePos = 0x03B5,
        SpAlliancePos = 0x02F2,
        PlaceMarker = 0x018B,
        PlaceFieldMarkerPreset = 0x0090,
        PlaceFieldMarker = 0x0160,
        ActorGauge = 0x0376,
        CharaVisualEffect = 0x0339,
        Fall = 0x02E0,
        UpdateHate = 0x017A,
        UpdateHater = 0x0205,
        FirstAttack = 0x00E9,
        ModelEquip = 0x0381,
        EquipDisplayFlags = 0x022F,
        UnMount = 0x012C,
        Mount = 0x0317,
        PlayMotionSync = 0x0362,
        CountdownInitiate = 0x023E,
        CountdownCancel = 0x0365,
        InitZone = 0x037D,
        Examine = 0x03DC,
        ExamineSearchInfo = 0x00F9,
        InventoryActionAck = 0x0256,
        MarketBoardItemListing = 0x03CB,
        MarketBoardItemListingCount = 0x032E,
        MarketBoardItemListingHistory = 0x03B1,
        MarketBoardSearchResult = 0x031E,
        MarketBoardPurchase = 0x0243,
        PlayerSetup = 0x027F,
        PlayerStats = 0x00EE,
        Playtime = 0x0301,
        UpdateInventorySlot = 0x020D,
        UpdateSearchInfo = 0x02B8,
        WardLandInfo = 0x01B5,
        CEDirector = 0x0287,
        Logout = 0x0181,
        FreeCompanyInfo = 0x0177,
        FreeCompanyDialog = 0x00AC,
        AirshipStatusList = 0x0335,
        AirshipStatus = 0x02F3,
        AirshipExplorationResult = 0x028F,
        SubmarineStatusList = 0x0076,
        SubmarineProgressionStatus = 0x0292,
        SubmarineExplorationResult = 0x0196,
        CFPreferredRole = 0x02AA,
        CompanyAirshipStatus = 0x01E5,
        CompanySubmersibleStatus = 0x00A5,
        ContentFinderNotifyPop = 0x03C6,
        FateInfo = 0x0355,
        UpdateRecastTimes = 0x0358,
        SocialList = 0x0222,
        IslandWorkshopSupplyDemand = 0x01B2,
        RSV = 0x0141,
        RSF = 0x01F0,
    };
    
    public enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0197,
        ActionRequestGroundTargeted = 0x0089,
        ChatHandler = 0x02B0,
        ClientTrigger  = 0x0342,
        InventoryModifyHandler = 0x00E4,
        MarketBoardPurchaseHandler = 0x033B,
        SetSearchInfoHandler = 0x036F,
        UpdatePositionHandler = 0x02C3,
        UpdatePositionInstance = 0x0391,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}
