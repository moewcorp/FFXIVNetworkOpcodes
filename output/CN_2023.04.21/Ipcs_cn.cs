// Generated by https://github.com/gamous/FFXIVNetworkOpcodes
namespace FFXIVOpcodes.CN
{
    public enum ServerLobbyIpcType : ushort
    {
    
    };
    
    public enum ClientLobbyIpcType : ushort
    {
    
    };
    
    public enum ServerZoneIpcType : ushort
    {
        PlayerSpawn = 0x03AD,
        NpcSpawn = 0x0267,
        NpcSpawn2 = 0x0303,
        ActorFreeSpawn = 0x0231,
        ObjectSpawn = 0x01DA,
        ObjectDespawn = 0x025B,
        CreateTreasure = 0x037A,
        OpenTreasure = 0x032C,
        TreasureFadeOut = 0x01C4,
        ActorMove = 0x035F,
        _record_unk10_ = 0x03DC,
        Transfer = 0x02F0,
        Effect = 0x0318,
        AoeEffect8 = 0x0175,
        AoeEffect16 = 0x0348,
        AoeEffect24 = 0x0200,
        AoeEffect32 = 0x00A1,
        ActorCast = 0x0301,
        ActorControl = 0x020B,
        ActorControlTarget = 0x01EC,
        ActorControlSelf = 0x0139,
        DirectorVars = 0x0243,
        ContentDirectorSync = 0x0128,
        _record_unk23_ = 0x02C7,
        EnvironmentControl = 0x0245,
        _record_unk29_ = 0x00F1,
        LandSetMap = 0x03C6,
        _record_unk31_ = 0x0377,
        EventStart = 0x0208,
        EventFinish = 0x02CB,
        EventPlay = 0x0082,
        EventPlay4 = 0x0152,
        EventPlay8 = 0x0361,
        EventPlay16 = 0x00E0,
        EventPlay32 = 0x030E,
        EventPlay64 = 0x01B7,
        EventPlay128 = 0x00F6,
        EventPlay255 = 0x0333,
        BattleTalk2 = 0x03DB,
        BattleTalk4 = 0x00C7,
        BattleTalk8 = 0x02B1,
        BalloonTalk2 = 0x00FD,
        BalloonTalk4 = 0x01F3,
        BalloonTalk8 = 0x01AD,
        SystemLogMessage = 0x021D,
        SystemLogMessage32 = 0x0117,
        SystemLogMessage48 = 0x03C3,
        SystemLogMessage80 = 0x039E,
        SystemLogMessage144 = 0x039C,
        NpcYell = 0x026D,
        ActorSetPos = 0x014B,
        PrepareZoning = 0x03D2,
        StatusEffectList3 = 0x0285,
        WeatherChange = 0x00CC,
        UpdateParty = 0x0144,
        UpdateAlliance = 0x006A,
        UpdateSpAlliance = 0x00EA,
        UpdateHpMpTp = 0x01A8,
        StatusEffectList = 0x0199,
        EurekaStatusEffectList = 0x03AA,
        StatusEffectList2 = 0x00A2,
        BossStatusEffectList = 0x00AA,
        EffectResult = 0x0358,
        EffectResult4 = 0x0389,
        EffectResult8 = 0x0183,
        EffectResult16 = 0x0302,
        EffectResultBasic = 0x0340,
        EffectResultBasic4 = 0x0213,
        EffectResultBasic8 = 0x0265,
        EffectResultBasic16 = 0x016B,
        EffectResultBasic32 = 0x0102,
        EffectResultBasic64 = 0x01AC,
        PartyPos = 0x0332,
        AlliancePos = 0x0127,
        SpAlliancePos = 0x00B8,
        PlaceMarker = 0x0261,
        PlaceFieldMarkerPreset = 0x0315,
        PlaceFieldMarker = 0x0158,
        ActorGauge = 0x00A9,
        CharaVisualEffect = 0x0342,
        Fall = 0x0065,
        UpdateHate = 0x00D4,
        UpdateHater = 0x0124,
        FirstAttack = 0x00B7,
        ModelEquip = 0x01D1,
        EquipDisplayFlags = 0x01BD,
        UnMount = 0x0365,
        Mount = 0x03C9,
        PlayMotionSync = 0x019B,
        CountdownInitiate = 0x0343,
        CountdownCancel = 0x037F,
        InitZone = 0x01C5,
        Examine = 0x0123,
        ExamineSearchInfo = 0x0256,
        InventoryActionAck = 0x016A,
        MarketBoardItemListing = 0x01B0,
        MarketBoardItemListingCount = 0x034C,
        MarketBoardItemListingHistory = 0x0323,
        MarketBoardSearchResult = 0x029B,
        MarketBoardPurchase = 0x0317,
        PlayerSetup = 0x0085,
        PlayerStats = 0x02C3,
        Playtime = 0x0394,
        UpdateClassInfo = 0x0122,
        UpdateInventorySlot = 0x03A4,
        UpdateSearchInfo = 0x015F,
        WardLandInfo = 0x014C,
        CEDirector = 0x0239,
        Logout = 0x0168,
        FreeCompanyInfo = 0x00D9,
        FreeCompanyDialog = 0x01EA,
        AirshipStatusList = 0x01D9,
        AirshipStatus = 0x019E,
        AirshipExplorationResult = 0x0229,
        SubmarineStatusList = 0x02B0,
        SubmarineProgressionStatus = 0x0113,
        SubmarineExplorationResult = 0x02B3,
        CFPreferredRole = 0x026C,
        CompanyAirshipStatus = 0x00B1,
        CompanySubmersibleStatus = 0x0177,
        ContentFinderNotifyPop = 0x019D,
        FateInfo = 0x017C,
        UpdateRecastTimes = 0x0170,
        SocialList = 0x0114,
        IslandWorkshopSupplyDemand = 0x009A,
        RSV = 0x0282,
        RSF = 0x03E6,
    };
    
    public enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x02AB,
        ActionRequestGroundTargeted = 0x00C0,
        ChatHandler = 0x03E7,
        ClientTrigger  = 0x00E3,
        InventoryModifyHandler = 0x0241,
        MarketBoardPurchaseHandler = 0x018A,
        SetSearchInfoHandler = 0x0146,
        UpdatePositionHandler = 0x00FE,
        UpdatePositionInstance = 0x037B,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}