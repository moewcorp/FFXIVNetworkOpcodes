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
        PlayerSpawn = 0x0285,
        NpcSpawn = 0x03CE,
        NpcSpawn2 = 0x0387,
        ActorFreeSpawn = 0x0344,
        ObjectSpawn = 0x00C0,
        ObjectDespawn = 0x02DB,
        CreateTreasure = 0x0124,
        OpenTreasure = 0x00E7,
        TreasureFadeOut = 0x0319,
        ActorMove = 0x01A0,
        _record_unk10_ = 0x0312,
        Transfer = 0x00F2,
        Effect = 0x00D3,
        AoeEffect8 = 0x0356,
        AoeEffect16 = 0x021E,
        AoeEffect24 = 0x0092,
        AoeEffect32 = 0x0237,
        ActorCast = 0x0165,
        ActorControl = 0x02C9,
        ActorControlTarget = 0x0169,
        ActorControlSelf = 0x0340,
        DirectorVars = 0x0361,
        ContentDirectorSync = 0x0339,
        _record_unk23_ = 0x01BD,
        EnvironmentControl = 0x02D8,
        _record_unk29_ = 0x01D9,
        LandSetMap = 0x039C,
        _record_unk31_ = 0x02DC,
        EventStart = 0x03D6,
        EventFinish = 0x03C7,
        EventPlay = 0x0335,
        EventPlay4 = 0x037D,
        EventPlay8 = 0x0203,
        EventPlay16 = 0x00EC,
        EventPlay32 = 0x0144,
        EventPlay64 = 0x03E4,
        EventPlay128 = 0x0232,
        EventPlay255 = 0x03A3,
        BattleTalk2 = 0x02EF,
        BattleTalk4 = 0x01A3,
        BattleTalk8 = 0x0348,
        BalloonTalk2 = 0x02DD,
        BalloonTalk4 = 0x02C1,
        BalloonTalk8 = 0x032C,
        SystemLogMessage = 0x0255,
        SystemLogMessage32 = 0x013A,
        SystemLogMessage48 = 0x014A,
        SystemLogMessage80 = 0x020C,
        SystemLogMessage144 = 0x01CF,
        NpcYell = 0x0096,
        ActorSetPos = 0x0079,
        PrepareZoning = 0x038E,
        _record_unk58_ = 0x0082,
        WeatherChange = 0x00B2,
        UpdateParty = 0x0164,
        UpdateAlliance = 0x0282,
        UpdateSpAlliance = 0x029C,
        UpdateHpMpTp = 0x024C,
        StatusEffectList = 0x033E,
        StatusEffectList2 = 0x01AC,
        StatusEffectList3 = 0x010E,
        EurekaStatusEffectList = 0x0298,
        BossStatusEffectList = 0x034A,
        EffectResult = 0x032E,
        EffectResult4 = 0x00E0,
        EffectResult8 = 0x0328,
        EffectResult16 = 0x011F,
        EffectResultBasic = 0x026D,
        EffectResultBasic4 = 0x02E3,
        EffectResultBasic8 = 0x038A,
        EffectResultBasic16 = 0x01C2,
        EffectResultBasic32 = 0x0392,
        EffectResultBasic64 = 0x0084,
        PartyPos = 0x03DE,
        AlliancePos = 0x0208,
        SpAlliancePos = 0x03B7,
        PlaceMarker = 0x017C,
        PlaceFieldMarkerPreset = 0x00E3,
        PlaceFieldMarker = 0x01DB,
        ActorGauge = 0x007B,
        CharaVisualEffect = 0x0288,
        Fall = 0x0310,
        UpdateHate = 0x0276,
        UpdateHater = 0x0143,
        FirstAttack = 0x030A,
        ModelEquip = 0x02B6,
        EquipDisplayFlags = 0x01F6,
        UnMount = 0x016B,
        Mount = 0x02A5,
        PlayMotionSync = 0x006E,
        CountdownInitiate = 0x032B,
        CountdownCancel = 0x0334,
        InitZone = 0x02D7,
        Examine = 0x0308,
        ExamineSearchInfo = 0x01D3,
        InventoryActionAck = 0x030D,
        MarketBoardItemListing = 0x0077,
        MarketBoardItemListingCount = 0x00FB,
        MarketBoardItemListingHistory = 0x00C5,
        MarketBoardSearchResult = 0x0153,
        MarketBoardPurchase = 0x030B,
        PlayerSetup = 0x01AB,
        PlayerStats = 0x012E,
        Playtime = 0x0245,
        UpdateClassInfo = 0x02A1,
        UpdateInventorySlot = 0x026A,
        UpdateSearchInfo = 0x02FB,
        WardLandInfo = 0x03B1,
        CEDirector = 0x0338,
        Logout = 0x02D5,
        FreeCompanyInfo = 0x02AE,
        FreeCompanyDialog = 0x02A6,
        AirshipStatusList = 0x01AE,
        AirshipStatus = 0x03C5,
        AirshipExplorationResult = 0x0105,
        SubmarineStatusList = 0x02F3,
        SubmarineProgressionStatus = 0x01C1,
        SubmarineExplorationResult = 0x01A4,
        CFPreferredRole = 0x0393,
        CompanyAirshipStatus = 0x019B,
        CompanySubmersibleStatus = 0x0136,
        ContentFinderNotifyPop = 0x0147,
        FateInfo = 0x02D3,
        UpdateRecastTimes = 0x015A,
        SocialList = 0x0148,
        IslandWorkshopSupplyDemand = 0x0078,
        RSV = 0x0329,
        RSF = 0x011C,
    };
    
    public enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x017F,
        ActionRequestGroundTargeted = 0x02C7,
        ChatHandler = 0x036F,
        ClientTrigger = 0x0103,
        InventoryModifyHandler = 0x039B,
        MarketBoardPurchaseHandler = 0x037B,
        SetSearchInfoHandler = 0x009C,
        UpdatePositionHandler = 0x0163,
        UpdatePositionInstance = 0x034C,
        Heartbeat = 0x034E,
        WorldTravel = 0x0098,
        ClientCountdownInitiate = 0x0077,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}