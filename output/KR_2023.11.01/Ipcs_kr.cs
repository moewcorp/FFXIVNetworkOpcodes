// Generated by https://github.com/gamous/FFXIVNetworkOpcodes
namespace FFXIVOpcodes.KR
{
    public enum ServerLobbyIpcType : ushort
    {
    
    };
    
    public enum ClientLobbyIpcType : ushort
    {
    
    };
    
    public enum ServerZoneIpcType : ushort
    {
        PlayerSpawn = 0x032F,
        NpcSpawn = 0x03C8,
        NpcSpawn2 = 0x02D1,
        ActorFreeSpawn = 0x00A9,
        ObjectSpawn = 0x0128,
        ObjectDespawn = 0x036E,
        CreateTreasure = 0x03B9,
        OpenTreasure = 0x01CC,
        TreasureFadeOut = 0x01C7,
        ActorMove = 0x02AB,
        _record_unk10_ = 0x0108,
        Transfer = 0x0346,
        Effect = 0x0305,
        AoeEffect8 = 0x01C8,
        AoeEffect16 = 0x01DB,
        AoeEffect24 = 0x011C,
        AoeEffect32 = 0x011B,
        ActorCast = 0x02DE,
        ActorControl = 0x020D,
        ActorControlTarget = 0x01A8,
        ActorControlSelf = 0x035B,
        DirectorVars = 0x0148,
        ContentDirectorSync = 0x00D1,
        _record_unk23_ = 0x01CF,
        EnvironmentControl = 0x00D9,
        _record_unk29_ = 0x03D9,
        LandSetMap = 0x02B2,
        _record_unk31_ = 0x03B3,
        EventStart = 0x013C,
        EventFinish = 0x02F2,
        EventPlay = 0x03BA,
        EventPlay4 = 0x01D3,
        EventPlay8 = 0x011A,
        EventPlay16 = 0x03B7,
        EventPlay32 = 0x008B,
        EventPlay64 = 0x0335,
        EventPlay128 = 0x028E,
        EventPlay255 = 0x0380,
        BattleTalk2 = 0x032B,
        BattleTalk4 = 0x00AF,
        BattleTalk8 = 0x00C6,
        BalloonTalk2 = 0x0220,
        BalloonTalk4 = 0x0215,
        BalloonTalk8 = 0x010A,
        SystemLogMessage = 0x03CF,
        SystemLogMessage32 = 0x0194,
        SystemLogMessage48 = 0x01E3,
        SystemLogMessage80 = 0x039F,
        SystemLogMessage144 = 0x0285,
        NpcYell = 0x02BE,
        ActorSetPos = 0x0190,
        PrepareZoning = 0x017C,
        _record_unk58_ = 0x00BD,
        WeatherChange = 0x023C,
        UpdateParty = 0x00EB,
        UpdateAlliance = 0x0086,
        UpdateSpAlliance = 0x0155,
        UpdateHpMpTp = 0x00FA,
        StatusEffectList = 0x03AA,
        StatusEffectList2 = 0x02D5,
        StatusEffectList3 = 0x014F,
        EurekaStatusEffectList = 0x0257,
        BossStatusEffectList = 0x022A,
        EffectResult = 0x013A,
        EffectResult4 = 0x0133,
        EffectResult8 = 0x02A2,
        EffectResult16 = 0x00A2,
        EffectResultBasic = 0x03A1,
        EffectResultBasic4 = 0x02C8,
        EffectResultBasic8 = 0x0223,
        EffectResultBasic16 = 0x0109,
        EffectResultBasic32 = 0x0340,
        EffectResultBasic64 = 0x00A8,
        PartyPos = 0x0207,
        AlliancePos = 0x02FE,
        SpAlliancePos = 0x03A8,
        PlaceMarker = 0x028D,
        PlaceFieldMarkerPreset = 0x03DB,
        PlaceFieldMarker = 0x0271,
        ActorGauge = 0x0102,
        CharaVisualEffect = 0x0203,
        Fall = 0x02C2,
        UpdateHate = 0x0200,
        UpdateHater = 0x02F3,
        FirstAttack = 0x0297,
        ModelEquip = 0x0272,
        EquipDisplayFlags = 0x03C2,
        UnMount = 0x00C5,
        Mount = 0x01C5,
        PlayMotionSync = 0x00B3,
        CountdownInitiate = 0x0358,
        CountdownCancel = 0x012E,
        InitZone = 0x0316,
        Examine = 0x0298,
        ExamineSearchInfo = 0x0121,
        InventoryActionAck = 0x02F7,
        MarketBoardItemListing = 0x0318,
        MarketBoardItemListingCount = 0x0390,
        MarketBoardItemListingHistory = 0x02F6,
        MarketBoardSearchResult = 0x02B5,
        MarketBoardPurchase = 0x0127,
        PlayerSetup = 0x0175,
        PlayerStats = 0x00CE,
        Playtime = 0x0195,
        UpdateClassInfo = 0x00A5,
        UpdateInventorySlot = 0x00C4,
        UpdateSearchInfo = 0x026C,
        WardLandInfo = 0x0239,
        CEDirector = 0x018E,
        Logout = 0x0367,
        FreeCompanyInfo = 0x03AE,
        FreeCompanyDialog = 0x0132,
        AirshipStatusList = 0x00AC,
        AirshipStatus = 0x00DC,
        AirshipExplorationResult = 0x01FB,
        SubmarineStatusList = 0x02A7,
        SubmarineProgressionStatus = 0x00B5,
        SubmarineExplorationResult = 0x01E4,
        CFPreferredRole = 0x00CF,
        CompanyAirshipStatus = 0x0364,
        CompanySubmersibleStatus = 0x0345,
        ContentFinderNotifyPop = 0x033C,
        FateInfo = 0x02ED,
        UpdateRecastTimes = 0x00D2,
        SocialList = 0x03C0,
        IslandWorkshopSupplyDemand = 0x01DC,
        RSV = 0x00C7,
        RSF = 0x039C,
    };
    
    public enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x02E7,
        ActionRequestGroundTargeted = 0x00C8,
        ChatHandler = 0x028B,
        ClientTrigger = 0x00F3,
        InventoryModifyHandler = 0x0319,
        MarketBoardPurchaseHandler = 0x0359,
        SetSearchInfoHandler = 0x00A3,
        UpdatePositionHandler = 0x0280,
        UpdatePositionInstance = 0x01F7,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}
