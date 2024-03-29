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
        PlayerSpawn = 0x0167,
        NpcSpawn = 0x02BB,
        NpcSpawn2 = 0x01C8,
        ActorFreeSpawn = 0x01E7,
        ObjectSpawn = 0x00DD,
        ObjectDespawn = 0x0337,
        CreateTreasure = 0x0097,
        OpenTreasure = 0x01B8,
        TreasureFadeOut = 0x0170,
        ActorMove = 0x02F9,
        _record_unk10_ = 0x0306,
        Transfer = 0x01E3,
        Effect = 0x00C0,
        AoeEffect8 = 0x01D6,
        AoeEffect16 = 0x025D,
        AoeEffect24 = 0x00D9,
        AoeEffect32 = 0x01A3,
        ActorCast = 0x02D2,
        ActorControl = 0x0342,
        ActorControlTarget = 0x01D7,
        ActorControlSelf = 0x00E4,
        DirectorVars = 0x019A,
        ContentDirectorSync = 0x020A,
        _record_unk23_ = 0x006B,
        EnvironmentControl = 0x014B,
        _record_unk29_ = 0x033A,
        LandSetMap = 0x007F,
        _record_unk31_ = 0x03AB,
        EventStart = 0x00CD,
        EventFinish = 0x01BE,
        EventPlay = 0x022E,
        EventPlay4 = 0x034A,
        EventPlay8 = 0x02E8,
        EventPlay16 = 0x00DB,
        EventPlay32 = 0x00A5,
        EventPlay64 = 0x0147,
        EventPlay128 = 0x0197,
        EventPlay255 = 0x00A6,
        BattleTalk2 = 0x0106,
        BattleTalk4 = 0x018F,
        BattleTalk8 = 0x01F1,
        BalloonTalk2 = 0x0160,
        BalloonTalk4 = 0x01B4,
        BalloonTalk8 = 0x00C8,
        SystemLogMessage = 0x03D7,
        SystemLogMessage32 = 0x02AC,
        SystemLogMessage48 = 0x0148,
        SystemLogMessage80 = 0x01B9,
        SystemLogMessage144 = 0x030E,
        NpcYell = 0x0129,
        ActorSetPos = 0x028F,
        PrepareZoning = 0x02C3,
        _record_unk58_ = 0x0383,
        WeatherChange = 0x0397,
        UpdateParty = 0x0361,
        UpdateAlliance = 0x0233,
        UpdateSpAlliance = 0x01D5,
        UpdateHpMpTp = 0x0353,
        StatusEffectList = 0x0163,
        StatusEffectList2 = 0x03B0,
        StatusEffectList3 = 0x02D0,
        EurekaStatusEffectList = 0x0290,
        BossStatusEffectList = 0x01DF,
        EffectResult = 0x01FC,
        EffectResult4 = 0x015F,
        EffectResult8 = 0x0362,
        EffectResult16 = 0x035C,
        EffectResultBasic = 0x033E,
        EffectResultBasic4 = 0x01AA,
        EffectResultBasic8 = 0x03DC,
        EffectResultBasic16 = 0x01C3,
        EffectResultBasic32 = 0x02C2,
        EffectResultBasic64 = 0x039A,
        PartyPos = 0x0340,
        AlliancePos = 0x033B,
        SpAlliancePos = 0x01CA,
        PlaceMarker = 0x03BC,
        PlaceFieldMarkerPreset = 0x02ED,
        PlaceFieldMarker = 0x02A1,
        ActorGauge = 0x036C,
        CharaVisualEffect = 0x0344,
        Fall = 0x0136,
        UpdateHate = 0x01EB,
        UpdateHater = 0x03E3,
        FirstAttack = 0x0297,
        ModelEquip = 0x00C4,
        EquipDisplayFlags = 0x02F8,
        UnMount = 0x0338,
        Mount = 0x029F,
        PlayMotionSync = 0x00F0,
        CountdownInitiate = 0x03DA,
        CountdownCancel = 0x03A3,
        InitZone = 0x0243,
        Examine = 0x0153,
        ExamineSearchInfo = 0x0150,
        InventoryActionAck = 0x02CD,
        MarketBoardItemListing = 0x0376,
        MarketBoardItemListingCount = 0x02B6,
        MarketBoardItemListingHistory = 0x0253,
        MarketBoardSearchResult = 0x016E,
        MarketBoardPurchase = 0x02AF,
        PlayerSetup = 0x0095,
        PlayerStats = 0x0087,
        Playtime = 0x027B,
        UpdateClassInfo = 0x02EA,
        UpdateInventorySlot = 0x0295,
        UpdateSearchInfo = 0x0110,
        WardLandInfo = 0x021A,
        CEDirector = 0x013C,
        Logout = 0x0066,
        FreeCompanyInfo = 0x01F6,
        FreeCompanyDialog = 0x0093,
        AirshipStatusList = 0x01CD,
        AirshipStatus = 0x025F,
        AirshipExplorationResult = 0x01FD,
        SubmarineStatusList = 0x01A2,
        SubmarineProgressionStatus = 0x027C,
        SubmarineExplorationResult = 0x02F7,
        CFPreferredRole = 0x0389,
        CompanyAirshipStatus = 0x00AB,
        CompanySubmersibleStatus = 0x03C2,
        ContentFinderNotifyPop = 0x030D,
        FateInfo = 0x017B,
        UpdateRecastTimes = 0x01A9,
        SocialList = 0x018C,
        IslandWorkshopSupplyDemand = 0x0127,
        RSV = 0x01BD,
        RSF = 0x03D8,
    };
    
    public enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0260,
        ActionRequestGroundTargeted = 0x014F,
        ChatHandler = 0x0348,
        ClientTrigger = 0x008F,
        InventoryModifyHandler = 0x039E,
        MarketBoardPurchaseHandler = 0x01BF,
        SetSearchInfoHandler = 0x02AE,
        UpdatePositionHandler = 0x0374,
        UpdatePositionInstance = 0x02D7,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}
