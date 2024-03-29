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
        PlayerSpawn = 0x03E2,
        NpcSpawn = 0x0379,
        NpcSpawn2 = 0x01AC,
        ActorFreeSpawn = 0x0270,
        ObjectSpawn = 0x02C2,
        ObjectDespawn = 0x00C0,
        CreateTreasure = 0x00FC,
        OpenTreasure = 0x012B,
        TreasureFadeOut = 0x008F,
        ActorMove = 0x0173,
        _record_unk10_ = 0x035B,
        Transfer = 0x00A5,
        Effect = 0x0222,
        AoeEffect8 = 0x0316,
        AoeEffect16 = 0x0192,
        AoeEffect24 = 0x023B,
        AoeEffect32 = 0x03D2,
        ActorCast = 0x0396,
        ActorControl = 0x0243,
        ActorControlTarget = 0x01A2,
        ActorControlSelf = 0x0196,
        DirectorVars = 0x0205,
        ContentDirectorSync = 0x00F7,
        _record_unk23_ = 0x0134,
        EnvironmentControl = 0x0154,
        _record_unk29_ = 0x015C,
        LandSetMap = 0x0148,
        _record_unk31_ = 0x011C,
        EventStart = 0x0109,
        EventFinish = 0x02D1,
        EventPlay = 0x036E,
        EventPlay4 = 0x0153,
        EventPlay8 = 0x035D,
        EventPlay16 = 0x01F0,
        EventPlay32 = 0x02A7,
        EventPlay64 = 0x0175,
        EventPlay128 = 0x0296,
        EventPlay255 = 0x0305,
        BattleTalk2 = 0x02D9,
        BattleTalk4 = 0x0110,
        BattleTalk8 = 0x02FB,
        BalloonTalk2 = 0x00E7,
        BalloonTalk4 = 0x00EC,
        BalloonTalk8 = 0x00A4,
        SystemLogMessage = 0x0089,
        SystemLogMessage32 = 0x0180,
        SystemLogMessage48 = 0x0076,
        SystemLogMessage80 = 0x017E,
        SystemLogMessage144 = 0x01A6,
        NpcYell = 0x0070,
        ActorSetPos = 0x0280,
        PrepareZoning = 0x01F3,
        _record_unk58_ = 0x0115,
        WeatherChange = 0x03DA,
        UpdateParty = 0x01DE,
        UpdateAlliance = 0x02BE,
        UpdateSpAlliance = 0x008B,
        UpdateHpMpTp = 0x022F,
        StatusEffectList = 0x0237,
        StatusEffectList2 = 0x026A,
        StatusEffectList3 = 0x0202,
        EurekaStatusEffectList = 0x01F5,
        BossStatusEffectList = 0x0330,
        EffectResult = 0x0197,
        EffectResult4 = 0x0162,
        EffectResult8 = 0x013B,
        EffectResult16 = 0x029B,
        EffectResultBasic = 0x01AF,
        EffectResultBasic4 = 0x015A,
        EffectResultBasic8 = 0x019A,
        EffectResultBasic16 = 0x02A3,
        EffectResultBasic32 = 0x0322,
        EffectResultBasic64 = 0x032A,
        PartyPos = 0x021A,
        AlliancePos = 0x02F3,
        SpAlliancePos = 0x03A3,
        PlaceMarker = 0x0247,
        PlaceFieldMarkerPreset = 0x01BD,
        PlaceFieldMarker = 0x0212,
        ActorGauge = 0x0319,
        CharaVisualEffect = 0x02D2,
        Fall = 0x0366,
        UpdateHate = 0x019C,
        UpdateHater = 0x033F,
        FirstAttack = 0x0269,
        ModelEquip = 0x021E,
        EquipDisplayFlags = 0x0293,
        UnMount = 0x0117,
        Mount = 0x02DD,
        PlayMotionSync = 0x0151,
        CountdownInitiate = 0x037E,
        CountdownCancel = 0x02F0,
        InitZone = 0x038F,
        Examine = 0x03BC,
        ExamineSearchInfo = 0x0116,
        InventoryActionAck = 0x034C,
        MarketBoardItemListing = 0x0233,
        MarketBoardItemListingCount = 0x0168,
        MarketBoardItemListingHistory = 0x0347,
        MarketBoardSearchResult = 0x0169,
        MarketBoardPurchase = 0x0133,
        PlayerSetup = 0x006D,
        PlayerStats = 0x033C,
        Playtime = 0x0378,
        UpdateClassInfo = 0x00FA,
        UpdateInventorySlot = 0x0369,
        UpdateSearchInfo = 0x0242,
        WardLandInfo = 0x00DA,
        CEDirector = 0x01B0,
        Logout = 0x03B0,
        FreeCompanyInfo = 0x02B1,
        FreeCompanyDialog = 0x0391,
        AirshipStatusList = 0x01DF,
        AirshipStatus = 0x01C9,
        AirshipExplorationResult = 0x00ED,
        SubmarineStatusList = 0x0390,
        SubmarineProgressionStatus = 0x009E,
        SubmarineExplorationResult = 0x032E,
        CFPreferredRole = 0x03AA,
        CompanyAirshipStatus = 0x020C,
        CompanySubmersibleStatus = 0x0354,
        ContentFinderNotifyPop = 0x010C,
        FateInfo = 0x0165,
        UpdateRecastTimes = 0x0365,
        SocialList = 0x0171,
        IslandWorkshopSupplyDemand = 0x02A9,
        RSV = 0x01D0,
        RSF = 0x0106,
    };
    
    public enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x03B6,
        ActionRequestGroundTargeted = 0x032D,
        ChatHandler = 0x01C1,
        ClientTrigger = 0x01F6,
        InventoryModifyHandler = 0x02E5,
        MarketBoardPurchaseHandler = 0x02F2,
        SetSearchInfoHandler = 0x035A,
        UpdatePositionHandler = 0x0297,
        UpdatePositionInstance = 0x0294,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}
