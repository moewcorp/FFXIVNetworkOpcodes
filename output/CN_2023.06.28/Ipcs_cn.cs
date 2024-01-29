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
        PlayerSpawn = 0x00C8,
        NpcSpawn = 0x0366,
        NpcSpawn2 = 0x013E,
        ActorFreeSpawn = 0x03DF,
        ObjectSpawn = 0x0153,
        ObjectDespawn = 0x02C3,
        CreateTreasure = 0x01F0,
        OpenTreasure = 0x0293,
        TreasureFadeOut = 0x00F3,
        ActorMove = 0x038E,
        _record_unk10_ = 0x01E0,
        Transfer = 0x03C7,
        Effect = 0x00CD,
        AoeEffect8 = 0x0215,
        AoeEffect16 = 0x0252,
        AoeEffect24 = 0x0271,
        AoeEffect32 = 0x018C,
        ActorCast = 0x0184,
        ActorControl = 0x02A5,
        ActorControlTarget = 0x02D0,
        ActorControlSelf = 0x01A3,
        DirectorVars = 0x0068,
        ContentDirectorSync = 0x0351,
        _record_unk23_ = 0x02F2,
        EnvironmentControl = 0x030E,
        _record_unk29_ = 0x025D,
        LandSetMap = 0x0334,
        _record_unk31_ = 0x02CA,
        EventStart = 0x00DE,
        EventFinish = 0x02B1,
        EventPlay = 0x03CE,
        EventPlay4 = 0x00BC,
        EventPlay8 = 0x01A1,
        EventPlay16 = 0x01B7,
        EventPlay32 = 0x0372,
        EventPlay64 = 0x0279,
        EventPlay128 = 0x012E,
        EventPlay255 = 0x03A2,
        BattleTalk2 = 0x01D9,
        BattleTalk4 = 0x0226,
        BattleTalk8 = 0x0212,
        BalloonTalk2 = 0x0088,
        BalloonTalk4 = 0x02F5,
        BalloonTalk8 = 0x032B,
        SystemLogMessage = 0x0183,
        SystemLogMessage32 = 0x00A3,
        SystemLogMessage48 = 0x03AD,
        SystemLogMessage80 = 0x023D,
        SystemLogMessage144 = 0x0299,
        NpcYell = 0x01CD,
        ActorSetPos = 0x024E,
        PrepareZoning = 0x0146,
        WeatherChange = 0x008F,
        UpdateParty = 0x0208,
        UpdateAlliance = 0x00DC,
        UpdateSpAlliance = 0x0379,
        UpdateHpMpTp = 0x0247,
        StatusEffectList = 0x0149,
        StatusEffectList2 = 0x03B1,
        StatusEffectList3 = 0x03C2,
        EurekaStatusEffectList = 0x0337,
        BossStatusEffectList = 0x00B1,
        EffectResult = 0x0378,
        EffectResult4 = 0x0290,
        EffectResult8 = 0x0340,
        EffectResult16 = 0x0395,
        EffectResultBasic = 0x0258,
        EffectResultBasic4 = 0x036C,
        EffectResultBasic8 = 0x02EA,
        EffectResultBasic16 = 0x038D,
        EffectResultBasic32 = 0x0131,
        EffectResultBasic64 = 0x0222,
        PartyPos = 0x02F0,
        AlliancePos = 0x025C,
        SpAlliancePos = 0x01ED,
        PlaceMarker = 0x02AA,
        PlaceFieldMarkerPreset = 0x0136,
        PlaceFieldMarker = 0x00DA,
        ActorGauge = 0x00C9,
        CharaVisualEffect = 0x01C7,
        Fall = 0x037C,
        UpdateHate = 0x0331,
        UpdateHater = 0x00BD,
        FirstAttack = 0x013B,
        ModelEquip = 0x026D,
        EquipDisplayFlags = 0x027A,
        UnMount = 0x00C1,
        Mount = 0x03D6,
        PlayMotionSync = 0x02FC,
        CountdownInitiate = 0x03AE,
        CountdownCancel = 0x01FB,
        InitZone = 0x01E3,
        Examine = 0x0255,
        ExamineSearchInfo = 0x0353,
        InventoryActionAck = 0x008B,
        MarketBoardItemListing = 0x03B0,
        MarketBoardItemListingCount = 0x00EF,
        MarketBoardItemListingHistory = 0x03AC,
        MarketBoardSearchResult = 0x025A,
        MarketBoardPurchase = 0x034A,
        PlayerSetup = 0x03A8,
        PlayerStats = 0x017D,
        Playtime = 0x033E,
        UpdateClassInfo = 0x028C,
        UpdateInventorySlot = 0x01C1,
        UpdateSearchInfo = 0x007B,
        WardLandInfo = 0x029F,
        CEDirector = 0x03E6,
        Logout = 0x033D,
        FreeCompanyInfo = 0x011F,
        FreeCompanyDialog = 0x0137,
        AirshipStatusList = 0x02E3,
        AirshipStatus = 0x03C8,
        AirshipExplorationResult = 0x032E,
        SubmarineStatusList = 0x0365,
        SubmarineProgressionStatus = 0x039D,
        SubmarineExplorationResult = 0x0158,
        CFPreferredRole = 0x0303,
        CompanyAirshipStatus = 0x00E1,
        CompanySubmersibleStatus = 0x01E6,
        ContentFinderNotifyPop = 0x00CA,
        FateInfo = 0x02CF,
        UpdateRecastTimes = 0x0300,
        SocialList = 0x014D,
        IslandWorkshopSupplyDemand = 0x0310,
        RSV = 0x030F,
        RSF = 0x028E,
    };
    
    public enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0374,
        ActionRequestGroundTargeted = 0x02B5,
        ChatHandler = 0x0326,
        ClientTrigger  = 0x0325,
        InventoryModifyHandler = 0x029A,
        MarketBoardPurchaseHandler = 0x017A,
        SetSearchInfoHandler = 0x019D,
        UpdatePositionHandler = 0x0315,
        UpdatePositionInstance = 0x0320,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}