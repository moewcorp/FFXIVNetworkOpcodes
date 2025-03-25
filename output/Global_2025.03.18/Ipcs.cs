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
        PlayerSpawn = 0x0331,
        NpcSpawn = 0x013F,
        NpcSpawn2 = 0x0303,
        ActorFreeSpawn = 0x0090,
        ObjectSpawn = 0x03C9,
        ObjectDespawn = 0x0186,
        CreateTreasure = 0x016D,
        OpenTreasure = 0x0308,
        TreasureFadeOut = 0x02BE,
        ActorMove = 0x0159,
        Transfer = 0x00A1,
        Effect = 0x0311,
        AoeEffect8 = 0x022E,
        AoeEffect16 = 0x012D,
        AoeEffect24 = 0x030F,
        AoeEffect32 = 0x0330,
        ActorCast = 0x017A,
        ActorControl = 0x0208,
        ActorControlTarget = 0x00E0,
        ActorControlSelf = 0x016F,
        DirectorVars = 0x02E7,
        EnvironmentControl = 0x00F2,
        _record_unk29_ = 0x030B,
        LandSetMap = 0x0304,
        _record_unk31_ = 0x02CE,
        EventStart = 0x03BB,
        EventFinish = 0x0246,
        EventPlay = 0x03DF,
        EventPlay4 = 0x007E,
        EventPlay8 = 0x0227,
        EventPlay16 = 0x0081,
        EventPlay32 = 0x0315,
        EventPlay64 = 0x02FF,
        EventPlay128 = 0x00E6,
        EventPlay255 = 0x01D3,
        BattleTalk2 = 0x021D,
        BattleTalk4 = 0x03B4,
        BattleTalk8 = 0x0232,
        BalloonTalk2 = 0x00C3,
        BalloonTalk4 = 0x0158,
        BalloonTalk8 = 0x0258,
        SystemLogMessage = 0x0282,
        SystemLogMessage32 = 0x01B3,
        SystemLogMessage48 = 0x0108,
        SystemLogMessage80 = 0x0394,
        SystemLogMessage144 = 0x0343,
        NpcYell = 0x01BB,
        ActorSetPos = 0x0088,
        PrepareZoning = 0x016C,
        WeatherChange = 0x0175,
        UpdateParty = 0x036F,
        UpdateAlliance = 0x00A6,
        UpdateSpAlliance = 0x01EB,
        UpdateHpMpTp = 0x0145,
        StatusEffectList = 0x0347,
        StatusEffectList2 = 0x02C4,
        StatusEffectList3 = 0x02C7,
        EurekaStatusEffectList = 0x038C,
        BossStatusEffectList = 0x015E,
        EffectResult = 0x037B,
        EffectResult4 = 0x0102,
        EffectResult8 = 0x03A1,
        EffectResult16 = 0x03E3,
        EffectResultBasic = 0x0320,
        EffectResultBasic4 = 0x0373,
        EffectResultBasic8 = 0x0138,
        EffectResultBasic16 = 0x035D,
        EffectResultBasic32 = 0x0150,
        EffectResultBasic64 = 0x00B8,
        PartyPos = 0x0160,
        AlliancePos = 0x01ED,
        SpAlliancePos = 0x00C8,
        PlaceMarker = 0x033E,
        PlaceFieldMarkerPreset = 0x019D,
        PlaceFieldMarker = 0x0239,
        ActorGauge = 0x03B2,
        CharaVisualEffect = 0x02D0,
        Fall = 0x02C3,
        UpdateHate = 0x02C0,
        UpdateHater = 0x016E,
        FirstAttack = 0x0125,
        ModelEquip = 0x009E,
        EquipDisplayFlags = 0x020B,
        UnMount = 0x00E4,
        Mount = 0x01E7,
        PlayMotionSync = 0x0289,
        CountdownInitiate = 0x037E,
        CountdownCancel = 0x0080,
        InitZone = 0x02BB,
        Examine = 0x0087,
        ExamineSearchInfo = 0x0257,
        InventoryActionAck = 0x0106,
        MarketBoardItemListing = 0x01D1,
        MarketBoardItemListingCount = 0x009D,
        MarketBoardItemListingHistory = 0x030E,
        MarketBoardSearchResult = 0x0136,
        MarketBoardPurchase = 0x019F,
        PlayerSetup = 0x00DA,
        PlayerStats = 0x0191,
        Playtime = 0x0241,
        UpdateClassInfo = 0x0077,
        UpdateInventorySlot = 0x0118,
        UpdateSearchInfo = 0x00C7,
        WardLandInfo = 0x03CA,
        CEDirector = 0x00B6,
        Logout = 0x0069,
        FreeCompanyInfo = 0x01BF,
        FreeCompanyDialog = 0x0270,
        AirshipStatusList = 0x03DB,
        AirshipStatus = 0x0340,
        AirshipExplorationResult = 0x029E,
        SubmarineStatusList = 0x00D6,
        SubmarineProgressionStatus = 0x0225,
        SubmarineExplorationResult = 0x0076,
        CFPreferredRole = 0x0290,
        CompanyAirshipStatus = 0x038B,
        CompanySubmersibleStatus = 0x0240,
        ContentFinderNotifyPop = 0x022D,
        FateInfo = 0x02D6,
        UpdateRecastTimes = 0x014F,
        SocialList = 0x026B,
        IslandWorkshopSupplyDemand = 0x0360,
        RSV = 0x023A,
        RSF = 0x035C,
        WorldVisitQueue = 0x02A7,
    };
    
    public enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0361,
        ActionRequestGroundTargeted = 0x02E2,
        ChatHandler = 0x0177,
        ClientTrigger = 0x0364,
        InventoryModifyHandler = 0x013E,
        MarketBoardPurchaseHandler = 0x03D8,
        MarketBoardRequestItemListingInfo = 0x0210,
        SetSearchInfoHandler = 0x01A4,
        UpdatePositionHandler = 0x0231,
        UpdatePositionInstance = 0x0273,
        Heartbeat = 0x01D2,
        WorldTravel = 0x0395,
        ClientCountdownInitiate = 0x0272,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}
