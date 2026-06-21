// This code is auto generated. Do not modify.
using System;
using System.Diagnostics.CodeAnalysis;
using AtomUI.Controls;

namespace AtomUI.Icons.IconPark;

public partial class IconParkIconProvider
{
    private const int IconFactoryIconCount = 2658;
    private const int IconFactoryChunkSize = 64;

    private static int GetIconIndex(IconParkIconKind kind)
    {
        var index = (int)kind - 1;
        if ((uint)index >= IconFactoryIconCount)
        {
            throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }

        return index;
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconType(IconParkIconKind kind)
    {
        var index = GetIconIndex(kind);
        return GetIconTypeChunk(index / IconFactoryChunkSize, kind);
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk(int chunkIndex, IconParkIconKind kind)
    {
        return chunkIndex switch
        {
            0 => GetIconTypeChunk0(kind),
            1 => GetIconTypeChunk1(kind),
            2 => GetIconTypeChunk2(kind),
            3 => GetIconTypeChunk3(kind),
            4 => GetIconTypeChunk4(kind),
            5 => GetIconTypeChunk5(kind),
            6 => GetIconTypeChunk6(kind),
            7 => GetIconTypeChunk7(kind),
            8 => GetIconTypeChunk8(kind),
            9 => GetIconTypeChunk9(kind),
            10 => GetIconTypeChunk10(kind),
            11 => GetIconTypeChunk11(kind),
            12 => GetIconTypeChunk12(kind),
            13 => GetIconTypeChunk13(kind),
            14 => GetIconTypeChunk14(kind),
            15 => GetIconTypeChunk15(kind),
            16 => GetIconTypeChunk16(kind),
            17 => GetIconTypeChunk17(kind),
            18 => GetIconTypeChunk18(kind),
            19 => GetIconTypeChunk19(kind),
            20 => GetIconTypeChunk20(kind),
            21 => GetIconTypeChunk21(kind),
            22 => GetIconTypeChunk22(kind),
            23 => GetIconTypeChunk23(kind),
            24 => GetIconTypeChunk24(kind),
            25 => GetIconTypeChunk25(kind),
            26 => GetIconTypeChunk26(kind),
            27 => GetIconTypeChunk27(kind),
            28 => GetIconTypeChunk28(kind),
            29 => GetIconTypeChunk29(kind),
            30 => GetIconTypeChunk30(kind),
            31 => GetIconTypeChunk31(kind),
            32 => GetIconTypeChunk32(kind),
            33 => GetIconTypeChunk33(kind),
            34 => GetIconTypeChunk34(kind),
            35 => GetIconTypeChunk35(kind),
            36 => GetIconTypeChunk36(kind),
            37 => GetIconTypeChunk37(kind),
            38 => GetIconTypeChunk38(kind),
            39 => GetIconTypeChunk39(kind),
            40 => GetIconTypeChunk40(kind),
            41 => GetIconTypeChunk41(kind),
            _ => throw new ArgumentOutOfRangeException(nameof(chunkIndex))
        };
    }

    private static Icon CreateIcon(IconParkIconKind kind)
    {
        var index = GetIconIndex(kind);
        return CreateIconChunk(index / IconFactoryChunkSize, kind);
    }

    private static Icon CreateIconChunk(int chunkIndex, IconParkIconKind kind)
    {
        return chunkIndex switch
        {
            0 => CreateIconChunk0(kind),
            1 => CreateIconChunk1(kind),
            2 => CreateIconChunk2(kind),
            3 => CreateIconChunk3(kind),
            4 => CreateIconChunk4(kind),
            5 => CreateIconChunk5(kind),
            6 => CreateIconChunk6(kind),
            7 => CreateIconChunk7(kind),
            8 => CreateIconChunk8(kind),
            9 => CreateIconChunk9(kind),
            10 => CreateIconChunk10(kind),
            11 => CreateIconChunk11(kind),
            12 => CreateIconChunk12(kind),
            13 => CreateIconChunk13(kind),
            14 => CreateIconChunk14(kind),
            15 => CreateIconChunk15(kind),
            16 => CreateIconChunk16(kind),
            17 => CreateIconChunk17(kind),
            18 => CreateIconChunk18(kind),
            19 => CreateIconChunk19(kind),
            20 => CreateIconChunk20(kind),
            21 => CreateIconChunk21(kind),
            22 => CreateIconChunk22(kind),
            23 => CreateIconChunk23(kind),
            24 => CreateIconChunk24(kind),
            25 => CreateIconChunk25(kind),
            26 => CreateIconChunk26(kind),
            27 => CreateIconChunk27(kind),
            28 => CreateIconChunk28(kind),
            29 => CreateIconChunk29(kind),
            30 => CreateIconChunk30(kind),
            31 => CreateIconChunk31(kind),
            32 => CreateIconChunk32(kind),
            33 => CreateIconChunk33(kind),
            34 => CreateIconChunk34(kind),
            35 => CreateIconChunk35(kind),
            36 => CreateIconChunk36(kind),
            37 => CreateIconChunk37(kind),
            38 => CreateIconChunk38(kind),
            39 => CreateIconChunk39(kind),
            40 => CreateIconChunk40(kind),
            41 => CreateIconChunk41(kind),
            _ => throw new ArgumentOutOfRangeException(nameof(chunkIndex))
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk0(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.ACane: return typeof(ACane);
            case IconParkIconKind.Abdominal: return typeof(Abdominal);
            case IconParkIconKind.Abnormal: return typeof(Abnormal);
            case IconParkIconKind.Acceleration: return typeof(Acceleration);
            case IconParkIconKind.AcceptEmail: return typeof(AcceptEmail);
            case IconParkIconKind.Acoustic: return typeof(Acoustic);
            case IconParkIconKind.ActivitySource: return typeof(ActivitySource);
            case IconParkIconKind.Ad: return typeof(Ad);
            case IconParkIconKind.AdProduct: return typeof(AdProduct);
            case IconParkIconKind.Add: return typeof(Add);
            case IconParkIconKind.AddComputer: return typeof(AddComputer);
            case IconParkIconKind.AddFour: return typeof(AddFour);
            case IconParkIconKind.AddItem: return typeof(AddItem);
            case IconParkIconKind.AddMode: return typeof(AddMode);
            case IconParkIconKind.AddMusic: return typeof(AddMusic);
            case IconParkIconKind.AddOne: return typeof(AddOne);
            case IconParkIconKind.AddPic: return typeof(AddPic);
            case IconParkIconKind.AddPicture: return typeof(AddPicture);
            case IconParkIconKind.AddPrint: return typeof(AddPrint);
            case IconParkIconKind.AddSubset: return typeof(AddSubset);
            case IconParkIconKind.AddSubtract: return typeof(AddSubtract);
            case IconParkIconKind.AddText: return typeof(AddText);
            case IconParkIconKind.AddTextTwo: return typeof(AddTextTwo);
            case IconParkIconKind.AddThree: return typeof(AddThree);
            case IconParkIconKind.AddTwo: return typeof(AddTwo);
            case IconParkIconKind.AddUser: return typeof(AddUser);
            case IconParkIconKind.AddWeb: return typeof(AddWeb);
            case IconParkIconKind.AddressBook: return typeof(AddressBook);
            case IconParkIconKind.AdjacentItem: return typeof(AdjacentItem);
            case IconParkIconKind.Adjustment: return typeof(Adjustment);
            case IconParkIconKind.AdobeIllustrate: return typeof(AdobeIllustrate);
            case IconParkIconKind.AdobeIndesign: return typeof(AdobeIndesign);
            case IconParkIconKind.AdobeLightroom: return typeof(AdobeLightroom);
            case IconParkIconKind.AdobePhotoshop: return typeof(AdobePhotoshop);
            case IconParkIconKind.Afferent: return typeof(Afferent);
            case IconParkIconKind.AfferentFour: return typeof(AfferentFour);
            case IconParkIconKind.AfferentThree: return typeof(AfferentThree);
            case IconParkIconKind.AfferentTwo: return typeof(AfferentTwo);
            case IconParkIconKind.AfroPick: return typeof(AfroPick);
            case IconParkIconKind.Agreement: return typeof(Agreement);
            case IconParkIconKind.Aiming: return typeof(Aiming);
            case IconParkIconKind.AirBike: return typeof(AirBike);
            case IconParkIconKind.AirConditioning: return typeof(AirConditioning);
            case IconParkIconKind.Airplane: return typeof(Airplane);
            case IconParkIconKind.AirplaneWindow: return typeof(AirplaneWindow);
            case IconParkIconKind.AirplaneWindowOne: return typeof(AirplaneWindowOne);
            case IconParkIconKind.Airplay: return typeof(Airplay);
            case IconParkIconKind.Airpods: return typeof(Airpods);
            case IconParkIconKind.Alarm: return typeof(Alarm);
            case IconParkIconKind.AlarmClock: return typeof(AlarmClock);
            case IconParkIconKind.AlignBottom: return typeof(AlignBottom);
            case IconParkIconKind.AlignBottomTwo: return typeof(AlignBottomTwo);
            case IconParkIconKind.AlignHorizontalCenterTwo: return typeof(AlignHorizontalCenterTwo);
            case IconParkIconKind.AlignHorizontally: return typeof(AlignHorizontally);
            case IconParkIconKind.AlignLeft: return typeof(AlignLeft);
            case IconParkIconKind.AlignLeftOne: return typeof(AlignLeftOne);
            case IconParkIconKind.AlignLeftTwo: return typeof(AlignLeftTwo);
            case IconParkIconKind.AlignRight: return typeof(AlignRight);
            case IconParkIconKind.AlignRightOne: return typeof(AlignRightOne);
            case IconParkIconKind.AlignRightTwo: return typeof(AlignRightTwo);
            case IconParkIconKind.AlignTextBoth: return typeof(AlignTextBoth);
            case IconParkIconKind.AlignTextBothOne: return typeof(AlignTextBothOne);
            case IconParkIconKind.AlignTextBottom: return typeof(AlignTextBottom);
            case IconParkIconKind.AlignTextBottomOne: return typeof(AlignTextBottomOne);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk0(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.ACane => new ACane(),
            IconParkIconKind.Abdominal => new Abdominal(),
            IconParkIconKind.Abnormal => new Abnormal(),
            IconParkIconKind.Acceleration => new Acceleration(),
            IconParkIconKind.AcceptEmail => new AcceptEmail(),
            IconParkIconKind.Acoustic => new Acoustic(),
            IconParkIconKind.ActivitySource => new ActivitySource(),
            IconParkIconKind.Ad => new Ad(),
            IconParkIconKind.AdProduct => new AdProduct(),
            IconParkIconKind.Add => new Add(),
            IconParkIconKind.AddComputer => new AddComputer(),
            IconParkIconKind.AddFour => new AddFour(),
            IconParkIconKind.AddItem => new AddItem(),
            IconParkIconKind.AddMode => new AddMode(),
            IconParkIconKind.AddMusic => new AddMusic(),
            IconParkIconKind.AddOne => new AddOne(),
            IconParkIconKind.AddPic => new AddPic(),
            IconParkIconKind.AddPicture => new AddPicture(),
            IconParkIconKind.AddPrint => new AddPrint(),
            IconParkIconKind.AddSubset => new AddSubset(),
            IconParkIconKind.AddSubtract => new AddSubtract(),
            IconParkIconKind.AddText => new AddText(),
            IconParkIconKind.AddTextTwo => new AddTextTwo(),
            IconParkIconKind.AddThree => new AddThree(),
            IconParkIconKind.AddTwo => new AddTwo(),
            IconParkIconKind.AddUser => new AddUser(),
            IconParkIconKind.AddWeb => new AddWeb(),
            IconParkIconKind.AddressBook => new AddressBook(),
            IconParkIconKind.AdjacentItem => new AdjacentItem(),
            IconParkIconKind.Adjustment => new Adjustment(),
            IconParkIconKind.AdobeIllustrate => new AdobeIllustrate(),
            IconParkIconKind.AdobeIndesign => new AdobeIndesign(),
            IconParkIconKind.AdobeLightroom => new AdobeLightroom(),
            IconParkIconKind.AdobePhotoshop => new AdobePhotoshop(),
            IconParkIconKind.Afferent => new Afferent(),
            IconParkIconKind.AfferentFour => new AfferentFour(),
            IconParkIconKind.AfferentThree => new AfferentThree(),
            IconParkIconKind.AfferentTwo => new AfferentTwo(),
            IconParkIconKind.AfroPick => new AfroPick(),
            IconParkIconKind.Agreement => new Agreement(),
            IconParkIconKind.Aiming => new Aiming(),
            IconParkIconKind.AirBike => new AirBike(),
            IconParkIconKind.AirConditioning => new AirConditioning(),
            IconParkIconKind.Airplane => new Airplane(),
            IconParkIconKind.AirplaneWindow => new AirplaneWindow(),
            IconParkIconKind.AirplaneWindowOne => new AirplaneWindowOne(),
            IconParkIconKind.Airplay => new Airplay(),
            IconParkIconKind.Airpods => new Airpods(),
            IconParkIconKind.Alarm => new Alarm(),
            IconParkIconKind.AlarmClock => new AlarmClock(),
            IconParkIconKind.AlignBottom => new AlignBottom(),
            IconParkIconKind.AlignBottomTwo => new AlignBottomTwo(),
            IconParkIconKind.AlignHorizontalCenterTwo => new AlignHorizontalCenterTwo(),
            IconParkIconKind.AlignHorizontally => new AlignHorizontally(),
            IconParkIconKind.AlignLeft => new AlignLeft(),
            IconParkIconKind.AlignLeftOne => new AlignLeftOne(),
            IconParkIconKind.AlignLeftTwo => new AlignLeftTwo(),
            IconParkIconKind.AlignRight => new AlignRight(),
            IconParkIconKind.AlignRightOne => new AlignRightOne(),
            IconParkIconKind.AlignRightTwo => new AlignRightTwo(),
            IconParkIconKind.AlignTextBoth => new AlignTextBoth(),
            IconParkIconKind.AlignTextBothOne => new AlignTextBothOne(),
            IconParkIconKind.AlignTextBottom => new AlignTextBottom(),
            IconParkIconKind.AlignTextBottomOne => new AlignTextBottomOne(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk1(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.AlignTextCenter: return typeof(AlignTextCenter);
            case IconParkIconKind.AlignTextCenterOne: return typeof(AlignTextCenterOne);
            case IconParkIconKind.AlignTextLeft: return typeof(AlignTextLeft);
            case IconParkIconKind.AlignTextLeftOne: return typeof(AlignTextLeftOne);
            case IconParkIconKind.AlignTextMiddle: return typeof(AlignTextMiddle);
            case IconParkIconKind.AlignTextMiddleOne: return typeof(AlignTextMiddleOne);
            case IconParkIconKind.AlignTextRight: return typeof(AlignTextRight);
            case IconParkIconKind.AlignTextRightOne: return typeof(AlignTextRightOne);
            case IconParkIconKind.AlignTextTop: return typeof(AlignTextTop);
            case IconParkIconKind.AlignTextTopOne: return typeof(AlignTextTopOne);
            case IconParkIconKind.AlignTop: return typeof(AlignTop);
            case IconParkIconKind.AlignTopTwo: return typeof(AlignTopTwo);
            case IconParkIconKind.AlignVerticalCenterTwo: return typeof(AlignVerticalCenterTwo);
            case IconParkIconKind.AlignVertically: return typeof(AlignVertically);
            case IconParkIconKind.AlignmentBottomCenter: return typeof(AlignmentBottomCenter);
            case IconParkIconKind.AlignmentBottomLeft: return typeof(AlignmentBottomLeft);
            case IconParkIconKind.AlignmentBottomRight: return typeof(AlignmentBottomRight);
            case IconParkIconKind.AlignmentHorizontalBottom: return typeof(AlignmentHorizontalBottom);
            case IconParkIconKind.AlignmentHorizontalCenter: return typeof(AlignmentHorizontalCenter);
            case IconParkIconKind.AlignmentHorizontalTop: return typeof(AlignmentHorizontalTop);
            case IconParkIconKind.AlignmentLeftBottom: return typeof(AlignmentLeftBottom);
            case IconParkIconKind.AlignmentLeftCenter: return typeof(AlignmentLeftCenter);
            case IconParkIconKind.AlignmentLeftTop: return typeof(AlignmentLeftTop);
            case IconParkIconKind.AlignmentRightBottom: return typeof(AlignmentRightBottom);
            case IconParkIconKind.AlignmentRightCenter: return typeof(AlignmentRightCenter);
            case IconParkIconKind.AlignmentRightTop: return typeof(AlignmentRightTop);
            case IconParkIconKind.AlignmentTopCenter: return typeof(AlignmentTopCenter);
            case IconParkIconKind.AlignmentTopLeft: return typeof(AlignmentTopLeft);
            case IconParkIconKind.AlignmentTopRight: return typeof(AlignmentTopRight);
            case IconParkIconKind.AlignmentVerticalCenter: return typeof(AlignmentVerticalCenter);
            case IconParkIconKind.AlignmentVerticalLeft: return typeof(AlignmentVerticalLeft);
            case IconParkIconKind.AlignmentVerticalRight: return typeof(AlignmentVerticalRight);
            case IconParkIconKind.Alipay: return typeof(Alipay);
            case IconParkIconKind.AllApplication: return typeof(AllApplication);
            case IconParkIconKind.AlphabeticalSorting: return typeof(AlphabeticalSorting);
            case IconParkIconKind.AlphabeticalSortingTwo: return typeof(AlphabeticalSortingTwo);
            case IconParkIconKind.Ambulance: return typeof(Ambulance);
            case IconParkIconKind.Analysis: return typeof(Analysis);
            case IconParkIconKind.Anchor: return typeof(Anchor);
            case IconParkIconKind.AnchorOne: return typeof(AnchorOne);
            case IconParkIconKind.AnchorRound: return typeof(AnchorRound);
            case IconParkIconKind.AnchorSqure: return typeof(AnchorSqure);
            case IconParkIconKind.AnchorTwo: return typeof(AnchorTwo);
            case IconParkIconKind.Android: return typeof(Android);
            case IconParkIconKind.AngryFace: return typeof(AngryFace);
            case IconParkIconKind.AnguishedFace: return typeof(AnguishedFace);
            case IconParkIconKind.Announcement: return typeof(Announcement);
            case IconParkIconKind.AntiCorrosion: return typeof(AntiCorrosion);
            case IconParkIconKind.AperturePriority: return typeof(AperturePriority);
            case IconParkIconKind.Api: return typeof(Api);
            case IconParkIconKind.ApiApp: return typeof(ApiApp);
            case IconParkIconKind.AppStore: return typeof(AppStore);
            case IconParkIconKind.AppSwitch: return typeof(AppSwitch);
            case IconParkIconKind.Apple: return typeof(Apple);
            case IconParkIconKind.AppleOne: return typeof(AppleOne);
            case IconParkIconKind.AppletClosed: return typeof(AppletClosed);
            case IconParkIconKind.Application: return typeof(Application);
            case IconParkIconKind.ApplicationEffect: return typeof(ApplicationEffect);
            case IconParkIconKind.ApplicationMenu: return typeof(ApplicationMenu);
            case IconParkIconKind.ApplicationOne: return typeof(ApplicationOne);
            case IconParkIconKind.ApplicationTwo: return typeof(ApplicationTwo);
            case IconParkIconKind.Appointment: return typeof(Appointment);
            case IconParkIconKind.Aquarius: return typeof(Aquarius);
            case IconParkIconKind.ArcDeTriomphe: return typeof(ArcDeTriomphe);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk1(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.AlignTextCenter => new AlignTextCenter(),
            IconParkIconKind.AlignTextCenterOne => new AlignTextCenterOne(),
            IconParkIconKind.AlignTextLeft => new AlignTextLeft(),
            IconParkIconKind.AlignTextLeftOne => new AlignTextLeftOne(),
            IconParkIconKind.AlignTextMiddle => new AlignTextMiddle(),
            IconParkIconKind.AlignTextMiddleOne => new AlignTextMiddleOne(),
            IconParkIconKind.AlignTextRight => new AlignTextRight(),
            IconParkIconKind.AlignTextRightOne => new AlignTextRightOne(),
            IconParkIconKind.AlignTextTop => new AlignTextTop(),
            IconParkIconKind.AlignTextTopOne => new AlignTextTopOne(),
            IconParkIconKind.AlignTop => new AlignTop(),
            IconParkIconKind.AlignTopTwo => new AlignTopTwo(),
            IconParkIconKind.AlignVerticalCenterTwo => new AlignVerticalCenterTwo(),
            IconParkIconKind.AlignVertically => new AlignVertically(),
            IconParkIconKind.AlignmentBottomCenter => new AlignmentBottomCenter(),
            IconParkIconKind.AlignmentBottomLeft => new AlignmentBottomLeft(),
            IconParkIconKind.AlignmentBottomRight => new AlignmentBottomRight(),
            IconParkIconKind.AlignmentHorizontalBottom => new AlignmentHorizontalBottom(),
            IconParkIconKind.AlignmentHorizontalCenter => new AlignmentHorizontalCenter(),
            IconParkIconKind.AlignmentHorizontalTop => new AlignmentHorizontalTop(),
            IconParkIconKind.AlignmentLeftBottom => new AlignmentLeftBottom(),
            IconParkIconKind.AlignmentLeftCenter => new AlignmentLeftCenter(),
            IconParkIconKind.AlignmentLeftTop => new AlignmentLeftTop(),
            IconParkIconKind.AlignmentRightBottom => new AlignmentRightBottom(),
            IconParkIconKind.AlignmentRightCenter => new AlignmentRightCenter(),
            IconParkIconKind.AlignmentRightTop => new AlignmentRightTop(),
            IconParkIconKind.AlignmentTopCenter => new AlignmentTopCenter(),
            IconParkIconKind.AlignmentTopLeft => new AlignmentTopLeft(),
            IconParkIconKind.AlignmentTopRight => new AlignmentTopRight(),
            IconParkIconKind.AlignmentVerticalCenter => new AlignmentVerticalCenter(),
            IconParkIconKind.AlignmentVerticalLeft => new AlignmentVerticalLeft(),
            IconParkIconKind.AlignmentVerticalRight => new AlignmentVerticalRight(),
            IconParkIconKind.Alipay => new Alipay(),
            IconParkIconKind.AllApplication => new AllApplication(),
            IconParkIconKind.AlphabeticalSorting => new AlphabeticalSorting(),
            IconParkIconKind.AlphabeticalSortingTwo => new AlphabeticalSortingTwo(),
            IconParkIconKind.Ambulance => new Ambulance(),
            IconParkIconKind.Analysis => new Analysis(),
            IconParkIconKind.Anchor => new Anchor(),
            IconParkIconKind.AnchorOne => new AnchorOne(),
            IconParkIconKind.AnchorRound => new AnchorRound(),
            IconParkIconKind.AnchorSqure => new AnchorSqure(),
            IconParkIconKind.AnchorTwo => new AnchorTwo(),
            IconParkIconKind.Android => new Android(),
            IconParkIconKind.AngryFace => new AngryFace(),
            IconParkIconKind.AnguishedFace => new AnguishedFace(),
            IconParkIconKind.Announcement => new Announcement(),
            IconParkIconKind.AntiCorrosion => new AntiCorrosion(),
            IconParkIconKind.AperturePriority => new AperturePriority(),
            IconParkIconKind.Api => new Api(),
            IconParkIconKind.ApiApp => new ApiApp(),
            IconParkIconKind.AppStore => new AppStore(),
            IconParkIconKind.AppSwitch => new AppSwitch(),
            IconParkIconKind.Apple => new Apple(),
            IconParkIconKind.AppleOne => new AppleOne(),
            IconParkIconKind.AppletClosed => new AppletClosed(),
            IconParkIconKind.Application => new Application(),
            IconParkIconKind.ApplicationEffect => new ApplicationEffect(),
            IconParkIconKind.ApplicationMenu => new ApplicationMenu(),
            IconParkIconKind.ApplicationOne => new ApplicationOne(),
            IconParkIconKind.ApplicationTwo => new ApplicationTwo(),
            IconParkIconKind.Appointment => new Appointment(),
            IconParkIconKind.Aquarius => new Aquarius(),
            IconParkIconKind.ArcDeTriomphe => new ArcDeTriomphe(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk2(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.ArchersBow: return typeof(ArchersBow);
            case IconParkIconKind.Archery: return typeof(Archery);
            case IconParkIconKind.AreaMap: return typeof(AreaMap);
            case IconParkIconKind.Arena: return typeof(Arena);
            case IconParkIconKind.Aries: return typeof(Aries);
            case IconParkIconKind.Arithmetic: return typeof(Arithmetic);
            case IconParkIconKind.ArithmeticButtons: return typeof(ArithmeticButtons);
            case IconParkIconKind.ArithmeticOne: return typeof(ArithmeticOne);
            case IconParkIconKind.ArrowCircleDown: return typeof(ArrowCircleDown);
            case IconParkIconKind.ArrowCircleLeft: return typeof(ArrowCircleLeft);
            case IconParkIconKind.ArrowCircleRight: return typeof(ArrowCircleRight);
            case IconParkIconKind.ArrowCircleUp: return typeof(ArrowCircleUp);
            case IconParkIconKind.ArrowDown: return typeof(ArrowDown);
            case IconParkIconKind.ArrowKeys: return typeof(ArrowKeys);
            case IconParkIconKind.ArrowLeft: return typeof(ArrowLeft);
            case IconParkIconKind.ArrowLeftDown: return typeof(ArrowLeftDown);
            case IconParkIconKind.ArrowLeftUp: return typeof(ArrowLeftUp);
            case IconParkIconKind.ArrowRight: return typeof(ArrowRight);
            case IconParkIconKind.ArrowRightDown: return typeof(ArrowRightDown);
            case IconParkIconKind.ArrowRightUp: return typeof(ArrowRightUp);
            case IconParkIconKind.ArrowUp: return typeof(ArrowUp);
            case IconParkIconKind.AssemblyLine: return typeof(AssemblyLine);
            case IconParkIconKind.Association: return typeof(Association);
            case IconParkIconKind.Asterisk: return typeof(Asterisk);
            case IconParkIconKind.AsteriskKey: return typeof(AsteriskKey);
            case IconParkIconKind.AstonishedFace: return typeof(AstonishedFace);
            case IconParkIconKind.AtSign: return typeof(AtSign);
            case IconParkIconKind.Attention: return typeof(Attention);
            case IconParkIconKind.AudioFile: return typeof(AudioFile);
            case IconParkIconKind.Audit: return typeof(Audit);
            case IconParkIconKind.AutoFocus: return typeof(AutoFocus);
            case IconParkIconKind.AutoHeightOne: return typeof(AutoHeightOne);
            case IconParkIconKind.AutoLineHeight: return typeof(AutoLineHeight);
            case IconParkIconKind.AutoLineWidth: return typeof(AutoLineWidth);
            case IconParkIconKind.AutoWidth: return typeof(AutoWidth);
            case IconParkIconKind.AutoWidthOne: return typeof(AutoWidthOne);
            case IconParkIconKind.Avatar: return typeof(Avatar);
            case IconParkIconKind.Average: return typeof(Average);
            case IconParkIconKind.Aviation: return typeof(Aviation);
            case IconParkIconKind.Avocado: return typeof(Avocado);
            case IconParkIconKind.AvocadoOne: return typeof(AvocadoOne);
            case IconParkIconKind.Baby: return typeof(Baby);
            case IconParkIconKind.BabyApp: return typeof(BabyApp);
            case IconParkIconKind.BabyBottle: return typeof(BabyBottle);
            case IconParkIconKind.BabyCarSeat: return typeof(BabyCarSeat);
            case IconParkIconKind.BabyFeet: return typeof(BabyFeet);
            case IconParkIconKind.BabyMeal: return typeof(BabyMeal);
            case IconParkIconKind.BabyMobile: return typeof(BabyMobile);
            case IconParkIconKind.BabyOne: return typeof(BabyOne);
            case IconParkIconKind.BabyPants: return typeof(BabyPants);
            case IconParkIconKind.BabySling: return typeof(BabySling);
            case IconParkIconKind.BabyTaste: return typeof(BabyTaste);
            case IconParkIconKind.BachelorCap: return typeof(BachelorCap);
            case IconParkIconKind.BachelorCapOne: return typeof(BachelorCapOne);
            case IconParkIconKind.BachelorCapTwo: return typeof(BachelorCapTwo);
            case IconParkIconKind.Back: return typeof(Back);
            case IconParkIconKind.BackOne: return typeof(BackOne);
            case IconParkIconKind.BackgroundColor: return typeof(BackgroundColor);
            case IconParkIconKind.Backpack: return typeof(Backpack);
            case IconParkIconKind.Bad: return typeof(Bad);
            case IconParkIconKind.BadOne: return typeof(BadOne);
            case IconParkIconKind.BadTwo: return typeof(BadTwo);
            case IconParkIconKind.Badge: return typeof(Badge);
            case IconParkIconKind.BadgeTwo: return typeof(BadgeTwo);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk2(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.ArchersBow => new ArchersBow(),
            IconParkIconKind.Archery => new Archery(),
            IconParkIconKind.AreaMap => new AreaMap(),
            IconParkIconKind.Arena => new Arena(),
            IconParkIconKind.Aries => new Aries(),
            IconParkIconKind.Arithmetic => new Arithmetic(),
            IconParkIconKind.ArithmeticButtons => new ArithmeticButtons(),
            IconParkIconKind.ArithmeticOne => new ArithmeticOne(),
            IconParkIconKind.ArrowCircleDown => new ArrowCircleDown(),
            IconParkIconKind.ArrowCircleLeft => new ArrowCircleLeft(),
            IconParkIconKind.ArrowCircleRight => new ArrowCircleRight(),
            IconParkIconKind.ArrowCircleUp => new ArrowCircleUp(),
            IconParkIconKind.ArrowDown => new ArrowDown(),
            IconParkIconKind.ArrowKeys => new ArrowKeys(),
            IconParkIconKind.ArrowLeft => new ArrowLeft(),
            IconParkIconKind.ArrowLeftDown => new ArrowLeftDown(),
            IconParkIconKind.ArrowLeftUp => new ArrowLeftUp(),
            IconParkIconKind.ArrowRight => new ArrowRight(),
            IconParkIconKind.ArrowRightDown => new ArrowRightDown(),
            IconParkIconKind.ArrowRightUp => new ArrowRightUp(),
            IconParkIconKind.ArrowUp => new ArrowUp(),
            IconParkIconKind.AssemblyLine => new AssemblyLine(),
            IconParkIconKind.Association => new Association(),
            IconParkIconKind.Asterisk => new Asterisk(),
            IconParkIconKind.AsteriskKey => new AsteriskKey(),
            IconParkIconKind.AstonishedFace => new AstonishedFace(),
            IconParkIconKind.AtSign => new AtSign(),
            IconParkIconKind.Attention => new Attention(),
            IconParkIconKind.AudioFile => new AudioFile(),
            IconParkIconKind.Audit => new Audit(),
            IconParkIconKind.AutoFocus => new AutoFocus(),
            IconParkIconKind.AutoHeightOne => new AutoHeightOne(),
            IconParkIconKind.AutoLineHeight => new AutoLineHeight(),
            IconParkIconKind.AutoLineWidth => new AutoLineWidth(),
            IconParkIconKind.AutoWidth => new AutoWidth(),
            IconParkIconKind.AutoWidthOne => new AutoWidthOne(),
            IconParkIconKind.Avatar => new Avatar(),
            IconParkIconKind.Average => new Average(),
            IconParkIconKind.Aviation => new Aviation(),
            IconParkIconKind.Avocado => new Avocado(),
            IconParkIconKind.AvocadoOne => new AvocadoOne(),
            IconParkIconKind.Baby => new Baby(),
            IconParkIconKind.BabyApp => new BabyApp(),
            IconParkIconKind.BabyBottle => new BabyBottle(),
            IconParkIconKind.BabyCarSeat => new BabyCarSeat(),
            IconParkIconKind.BabyFeet => new BabyFeet(),
            IconParkIconKind.BabyMeal => new BabyMeal(),
            IconParkIconKind.BabyMobile => new BabyMobile(),
            IconParkIconKind.BabyOne => new BabyOne(),
            IconParkIconKind.BabyPants => new BabyPants(),
            IconParkIconKind.BabySling => new BabySling(),
            IconParkIconKind.BabyTaste => new BabyTaste(),
            IconParkIconKind.BachelorCap => new BachelorCap(),
            IconParkIconKind.BachelorCapOne => new BachelorCapOne(),
            IconParkIconKind.BachelorCapTwo => new BachelorCapTwo(),
            IconParkIconKind.Back => new Back(),
            IconParkIconKind.BackOne => new BackOne(),
            IconParkIconKind.BackgroundColor => new BackgroundColor(),
            IconParkIconKind.Backpack => new Backpack(),
            IconParkIconKind.Bad => new Bad(),
            IconParkIconKind.BadOne => new BadOne(),
            IconParkIconKind.BadTwo => new BadTwo(),
            IconParkIconKind.Badge => new Badge(),
            IconParkIconKind.BadgeTwo => new BadgeTwo(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk3(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Badminton: return typeof(Badminton);
            case IconParkIconKind.BaggageDelay: return typeof(BaggageDelay);
            case IconParkIconKind.Balance: return typeof(Balance);
            case IconParkIconKind.BalanceOne: return typeof(BalanceOne);
            case IconParkIconKind.BalanceTwo: return typeof(BalanceTwo);
            case IconParkIconKind.Banana: return typeof(Banana);
            case IconParkIconKind.Bank: return typeof(Bank);
            case IconParkIconKind.BankCard: return typeof(BankCard);
            case IconParkIconKind.BankCardOne: return typeof(BankCardOne);
            case IconParkIconKind.BankCardTwo: return typeof(BankCardTwo);
            case IconParkIconKind.BankTransfer: return typeof(BankTransfer);
            case IconParkIconKind.Baokemeng: return typeof(Baokemeng);
            case IconParkIconKind.BarCode: return typeof(BarCode);
            case IconParkIconKind.Barbecue: return typeof(Barbecue);
            case IconParkIconKind.BarberBrush: return typeof(BarberBrush);
            case IconParkIconKind.BarberClippers: return typeof(BarberClippers);
            case IconParkIconKind.Baseball: return typeof(Baseball);
            case IconParkIconKind.BaseballBat: return typeof(BaseballBat);
            case IconParkIconKind.BaseballCap: return typeof(BaseballCap);
            case IconParkIconKind.Basketball: return typeof(Basketball);
            case IconParkIconKind.BasketballClothes: return typeof(BasketballClothes);
            case IconParkIconKind.BasketballOne: return typeof(BasketballOne);
            case IconParkIconKind.BasketballStand: return typeof(BasketballStand);
            case IconParkIconKind.Bat: return typeof(Bat);
            case IconParkIconKind.BatteryCharge: return typeof(BatteryCharge);
            case IconParkIconKind.BatteryEmpty: return typeof(BatteryEmpty);
            case IconParkIconKind.BatteryFailure: return typeof(BatteryFailure);
            case IconParkIconKind.BatteryFull: return typeof(BatteryFull);
            case IconParkIconKind.BatteryStorage: return typeof(BatteryStorage);
            case IconParkIconKind.BatteryTips: return typeof(BatteryTips);
            case IconParkIconKind.BatteryWorking: return typeof(BatteryWorking);
            case IconParkIconKind.BatteryWorkingOne: return typeof(BatteryWorkingOne);
            case IconParkIconKind.BeachUmbrella: return typeof(BeachUmbrella);
            case IconParkIconKind.Bear: return typeof(Bear);
            case IconParkIconKind.Beauty: return typeof(Beauty);
            case IconParkIconKind.BeautyInstrument: return typeof(BeautyInstrument);
            case IconParkIconKind.Bedside: return typeof(Bedside);
            case IconParkIconKind.BedsideTwo: return typeof(BedsideTwo);
            case IconParkIconKind.Bee: return typeof(Bee);
            case IconParkIconKind.Beer: return typeof(Beer);
            case IconParkIconKind.BeerMug: return typeof(BeerMug);
            case IconParkIconKind.Behance: return typeof(Behance);
            case IconParkIconKind.BellRing: return typeof(BellRing);
            case IconParkIconKind.Belt: return typeof(Belt);
            case IconParkIconKind.Benz: return typeof(Benz);
            case IconParkIconKind.BezierCurve: return typeof(BezierCurve);
            case IconParkIconKind.Bib: return typeof(Bib);
            case IconParkIconKind.BigClock: return typeof(BigClock);
            case IconParkIconKind.BigX: return typeof(BigX);
            case IconParkIconKind.Bike: return typeof(Bike);
            case IconParkIconKind.Bill: return typeof(Bill);
            case IconParkIconKind.Bird: return typeof(Bird);
            case IconParkIconKind.BirthdayCake: return typeof(BirthdayCake);
            case IconParkIconKind.Bitcoin: return typeof(Bitcoin);
            case IconParkIconKind.BlackEight: return typeof(BlackEight);
            case IconParkIconKind.Blackboard: return typeof(Blackboard);
            case IconParkIconKind.Blade: return typeof(Blade);
            case IconParkIconKind.Bless: return typeof(Bless);
            case IconParkIconKind.Block: return typeof(Block);
            case IconParkIconKind.BlockEight: return typeof(BlockEight);
            case IconParkIconKind.BlockFive: return typeof(BlockFive);
            case IconParkIconKind.BlockFour: return typeof(BlockFour);
            case IconParkIconKind.BlockNine: return typeof(BlockNine);
            case IconParkIconKind.BlockOne: return typeof(BlockOne);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk3(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Badminton => new Badminton(),
            IconParkIconKind.BaggageDelay => new BaggageDelay(),
            IconParkIconKind.Balance => new Balance(),
            IconParkIconKind.BalanceOne => new BalanceOne(),
            IconParkIconKind.BalanceTwo => new BalanceTwo(),
            IconParkIconKind.Banana => new Banana(),
            IconParkIconKind.Bank => new Bank(),
            IconParkIconKind.BankCard => new BankCard(),
            IconParkIconKind.BankCardOne => new BankCardOne(),
            IconParkIconKind.BankCardTwo => new BankCardTwo(),
            IconParkIconKind.BankTransfer => new BankTransfer(),
            IconParkIconKind.Baokemeng => new Baokemeng(),
            IconParkIconKind.BarCode => new BarCode(),
            IconParkIconKind.Barbecue => new Barbecue(),
            IconParkIconKind.BarberBrush => new BarberBrush(),
            IconParkIconKind.BarberClippers => new BarberClippers(),
            IconParkIconKind.Baseball => new Baseball(),
            IconParkIconKind.BaseballBat => new BaseballBat(),
            IconParkIconKind.BaseballCap => new BaseballCap(),
            IconParkIconKind.Basketball => new Basketball(),
            IconParkIconKind.BasketballClothes => new BasketballClothes(),
            IconParkIconKind.BasketballOne => new BasketballOne(),
            IconParkIconKind.BasketballStand => new BasketballStand(),
            IconParkIconKind.Bat => new Bat(),
            IconParkIconKind.BatteryCharge => new BatteryCharge(),
            IconParkIconKind.BatteryEmpty => new BatteryEmpty(),
            IconParkIconKind.BatteryFailure => new BatteryFailure(),
            IconParkIconKind.BatteryFull => new BatteryFull(),
            IconParkIconKind.BatteryStorage => new BatteryStorage(),
            IconParkIconKind.BatteryTips => new BatteryTips(),
            IconParkIconKind.BatteryWorking => new BatteryWorking(),
            IconParkIconKind.BatteryWorkingOne => new BatteryWorkingOne(),
            IconParkIconKind.BeachUmbrella => new BeachUmbrella(),
            IconParkIconKind.Bear => new Bear(),
            IconParkIconKind.Beauty => new Beauty(),
            IconParkIconKind.BeautyInstrument => new BeautyInstrument(),
            IconParkIconKind.Bedside => new Bedside(),
            IconParkIconKind.BedsideTwo => new BedsideTwo(),
            IconParkIconKind.Bee => new Bee(),
            IconParkIconKind.Beer => new Beer(),
            IconParkIconKind.BeerMug => new BeerMug(),
            IconParkIconKind.Behance => new Behance(),
            IconParkIconKind.BellRing => new BellRing(),
            IconParkIconKind.Belt => new Belt(),
            IconParkIconKind.Benz => new Benz(),
            IconParkIconKind.BezierCurve => new BezierCurve(),
            IconParkIconKind.Bib => new Bib(),
            IconParkIconKind.BigClock => new BigClock(),
            IconParkIconKind.BigX => new BigX(),
            IconParkIconKind.Bike => new Bike(),
            IconParkIconKind.Bill => new Bill(),
            IconParkIconKind.Bird => new Bird(),
            IconParkIconKind.BirthdayCake => new BirthdayCake(),
            IconParkIconKind.Bitcoin => new Bitcoin(),
            IconParkIconKind.BlackEight => new BlackEight(),
            IconParkIconKind.Blackboard => new Blackboard(),
            IconParkIconKind.Blade => new Blade(),
            IconParkIconKind.Bless => new Bless(),
            IconParkIconKind.Block => new Block(),
            IconParkIconKind.BlockEight => new BlockEight(),
            IconParkIconKind.BlockFive => new BlockFive(),
            IconParkIconKind.BlockFour => new BlockFour(),
            IconParkIconKind.BlockNine => new BlockNine(),
            IconParkIconKind.BlockOne => new BlockOne(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk4(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.BlockSeven: return typeof(BlockSeven);
            case IconParkIconKind.BlockSix: return typeof(BlockSix);
            case IconParkIconKind.BlockTen: return typeof(BlockTen);
            case IconParkIconKind.BlockThree: return typeof(BlockThree);
            case IconParkIconKind.BlockTwo: return typeof(BlockTwo);
            case IconParkIconKind.Blockchain: return typeof(Blockchain);
            case IconParkIconKind.BlocksAndArrows: return typeof(BlocksAndArrows);
            case IconParkIconKind.Bloom: return typeof(Bloom);
            case IconParkIconKind.Blossom: return typeof(Blossom);
            case IconParkIconKind.Bluetooth: return typeof(Bluetooth);
            case IconParkIconKind.Boiler: return typeof(Boiler);
            case IconParkIconKind.BoltOne: return typeof(BoltOne);
            case IconParkIconKind.Bone: return typeof(Bone);
            case IconParkIconKind.Book: return typeof(Book);
            case IconParkIconKind.BookOne: return typeof(BookOne);
            case IconParkIconKind.BookOpen: return typeof(BookOpen);
            case IconParkIconKind.Bookmark: return typeof(Bookmark);
            case IconParkIconKind.BookmarkOne: return typeof(BookmarkOne);
            case IconParkIconKind.BookmarkThree: return typeof(BookmarkThree);
            case IconParkIconKind.Bookshelf: return typeof(Bookshelf);
            case IconParkIconKind.BoosterCarSeat: return typeof(BoosterCarSeat);
            case IconParkIconKind.Booth: return typeof(Booth);
            case IconParkIconKind.Boots: return typeof(Boots);
            case IconParkIconKind.Bottle: return typeof(Bottle);
            case IconParkIconKind.BottleOne: return typeof(BottleOne);
            case IconParkIconKind.BottleThree: return typeof(BottleThree);
            case IconParkIconKind.BottleTwo: return typeof(BottleTwo);
            case IconParkIconKind.BottomBar: return typeof(BottomBar);
            case IconParkIconKind.BottomBarOne: return typeof(BottomBarOne);
            case IconParkIconKind.Bow: return typeof(Bow);
            case IconParkIconKind.Bowl: return typeof(Bowl);
            case IconParkIconKind.BowlOne: return typeof(BowlOne);
            case IconParkIconKind.Bowling: return typeof(Bowling);
            case IconParkIconKind.Box: return typeof(Box);
            case IconParkIconKind.Boxing: return typeof(Boxing);
            case IconParkIconKind.BoxingOne: return typeof(BoxingOne);
            case IconParkIconKind.Boy: return typeof(Boy);
            case IconParkIconKind.BoyOne: return typeof(BoyOne);
            case IconParkIconKind.BoyStroller: return typeof(BoyStroller);
            case IconParkIconKind.BoyTwo: return typeof(BoyTwo);
            case IconParkIconKind.Brain: return typeof(Brain);
            case IconParkIconKind.BrakePads: return typeof(BrakePads);
            case IconParkIconKind.Branch: return typeof(Branch);
            case IconParkIconKind.BranchOne: return typeof(BranchOne);
            case IconParkIconKind.BranchTwo: return typeof(BranchTwo);
            case IconParkIconKind.BrdigeThree: return typeof(BrdigeThree);
            case IconParkIconKind.Bread: return typeof(Bread);
            case IconParkIconKind.BreadMachine: return typeof(BreadMachine);
            case IconParkIconKind.BreadOne: return typeof(BreadOne);
            case IconParkIconKind.BreastPump: return typeof(BreastPump);
            case IconParkIconKind.BridgeOne: return typeof(BridgeOne);
            case IconParkIconKind.BridgeTwo: return typeof(BridgeTwo);
            case IconParkIconKind.Briefcase: return typeof(Briefcase);
            case IconParkIconKind.Brightness: return typeof(Brightness);
            case IconParkIconKind.BringForward: return typeof(BringForward);
            case IconParkIconKind.BringToFront: return typeof(BringToFront);
            case IconParkIconKind.BringToFrontOne: return typeof(BringToFrontOne);
            case IconParkIconKind.Broadcast: return typeof(Broadcast);
            case IconParkIconKind.BroadcastOne: return typeof(BroadcastOne);
            case IconParkIconKind.BroadcastRadio: return typeof(BroadcastRadio);
            case IconParkIconKind.Browser: return typeof(Browser);
            case IconParkIconKind.BrowserChrome: return typeof(BrowserChrome);
            case IconParkIconKind.BrowserSafari: return typeof(BrowserSafari);
            case IconParkIconKind.BubbleChart: return typeof(BubbleChart);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk4(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.BlockSeven => new BlockSeven(),
            IconParkIconKind.BlockSix => new BlockSix(),
            IconParkIconKind.BlockTen => new BlockTen(),
            IconParkIconKind.BlockThree => new BlockThree(),
            IconParkIconKind.BlockTwo => new BlockTwo(),
            IconParkIconKind.Blockchain => new Blockchain(),
            IconParkIconKind.BlocksAndArrows => new BlocksAndArrows(),
            IconParkIconKind.Bloom => new Bloom(),
            IconParkIconKind.Blossom => new Blossom(),
            IconParkIconKind.Bluetooth => new Bluetooth(),
            IconParkIconKind.Boiler => new Boiler(),
            IconParkIconKind.BoltOne => new BoltOne(),
            IconParkIconKind.Bone => new Bone(),
            IconParkIconKind.Book => new Book(),
            IconParkIconKind.BookOne => new BookOne(),
            IconParkIconKind.BookOpen => new BookOpen(),
            IconParkIconKind.Bookmark => new Bookmark(),
            IconParkIconKind.BookmarkOne => new BookmarkOne(),
            IconParkIconKind.BookmarkThree => new BookmarkThree(),
            IconParkIconKind.Bookshelf => new Bookshelf(),
            IconParkIconKind.BoosterCarSeat => new BoosterCarSeat(),
            IconParkIconKind.Booth => new Booth(),
            IconParkIconKind.Boots => new Boots(),
            IconParkIconKind.Bottle => new Bottle(),
            IconParkIconKind.BottleOne => new BottleOne(),
            IconParkIconKind.BottleThree => new BottleThree(),
            IconParkIconKind.BottleTwo => new BottleTwo(),
            IconParkIconKind.BottomBar => new BottomBar(),
            IconParkIconKind.BottomBarOne => new BottomBarOne(),
            IconParkIconKind.Bow => new Bow(),
            IconParkIconKind.Bowl => new Bowl(),
            IconParkIconKind.BowlOne => new BowlOne(),
            IconParkIconKind.Bowling => new Bowling(),
            IconParkIconKind.Box => new Box(),
            IconParkIconKind.Boxing => new Boxing(),
            IconParkIconKind.BoxingOne => new BoxingOne(),
            IconParkIconKind.Boy => new Boy(),
            IconParkIconKind.BoyOne => new BoyOne(),
            IconParkIconKind.BoyStroller => new BoyStroller(),
            IconParkIconKind.BoyTwo => new BoyTwo(),
            IconParkIconKind.Brain => new Brain(),
            IconParkIconKind.BrakePads => new BrakePads(),
            IconParkIconKind.Branch => new Branch(),
            IconParkIconKind.BranchOne => new BranchOne(),
            IconParkIconKind.BranchTwo => new BranchTwo(),
            IconParkIconKind.BrdigeThree => new BrdigeThree(),
            IconParkIconKind.Bread => new Bread(),
            IconParkIconKind.BreadMachine => new BreadMachine(),
            IconParkIconKind.BreadOne => new BreadOne(),
            IconParkIconKind.BreastPump => new BreastPump(),
            IconParkIconKind.BridgeOne => new BridgeOne(),
            IconParkIconKind.BridgeTwo => new BridgeTwo(),
            IconParkIconKind.Briefcase => new Briefcase(),
            IconParkIconKind.Brightness => new Brightness(),
            IconParkIconKind.BringForward => new BringForward(),
            IconParkIconKind.BringToFront => new BringToFront(),
            IconParkIconKind.BringToFrontOne => new BringToFrontOne(),
            IconParkIconKind.Broadcast => new Broadcast(),
            IconParkIconKind.BroadcastOne => new BroadcastOne(),
            IconParkIconKind.BroadcastRadio => new BroadcastRadio(),
            IconParkIconKind.Browser => new Browser(),
            IconParkIconKind.BrowserChrome => new BrowserChrome(),
            IconParkIconKind.BrowserSafari => new BrowserSafari(),
            IconParkIconKind.BubbleChart => new BubbleChart(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk5(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Bug: return typeof(Bug);
            case IconParkIconKind.BuildingFour: return typeof(BuildingFour);
            case IconParkIconKind.BuildingOne: return typeof(BuildingOne);
            case IconParkIconKind.BuildingThree: return typeof(BuildingThree);
            case IconParkIconKind.BuildingTwo: return typeof(BuildingTwo);
            case IconParkIconKind.BulletMap: return typeof(BulletMap);
            case IconParkIconKind.Bus: return typeof(Bus);
            case IconParkIconKind.BusOne: return typeof(BusOne);
            case IconParkIconKind.BusTwo: return typeof(BusTwo);
            case IconParkIconKind.Butterfly: return typeof(Butterfly);
            case IconParkIconKind.Buy: return typeof(Buy);
            case IconParkIconKind.Bydesign: return typeof(Bydesign);
            case IconParkIconKind.Bye: return typeof(Bye);
            case IconParkIconKind.Bytedance: return typeof(Bytedance);
            case IconParkIconKind.BytedanceApplets: return typeof(BytedanceApplets);
            case IconParkIconKind.BytedanceMiniApp: return typeof(BytedanceMiniApp);
            case IconParkIconKind.CableCar: return typeof(CableCar);
            case IconParkIconKind.Cactus: return typeof(Cactus);
            case IconParkIconKind.Cake: return typeof(Cake);
            case IconParkIconKind.CakeFive: return typeof(CakeFive);
            case IconParkIconKind.CakeFour: return typeof(CakeFour);
            case IconParkIconKind.CakeOne: return typeof(CakeOne);
            case IconParkIconKind.CakeThree: return typeof(CakeThree);
            case IconParkIconKind.CakeTwo: return typeof(CakeTwo);
            case IconParkIconKind.Calculator: return typeof(Calculator);
            case IconParkIconKind.CalculatorOne: return typeof(CalculatorOne);
            case IconParkIconKind.Calendar: return typeof(Calendar);
            case IconParkIconKind.CalendarDot: return typeof(CalendarDot);
            case IconParkIconKind.CalendarThirty: return typeof(CalendarThirty);
            case IconParkIconKind.CalendarThirtyTwo: return typeof(CalendarThirtyTwo);
            case IconParkIconKind.CalendarThree: return typeof(CalendarThree);
            case IconParkIconKind.Camera: return typeof(Camera);
            case IconParkIconKind.CameraFive: return typeof(CameraFive);
            case IconParkIconKind.CameraFour: return typeof(CameraFour);
            case IconParkIconKind.CameraOne: return typeof(CameraOne);
            case IconParkIconKind.CameraThree: return typeof(CameraThree);
            case IconParkIconKind.CameraTwo: return typeof(CameraTwo);
            case IconParkIconKind.Camp: return typeof(Camp);
            case IconParkIconKind.Cancer: return typeof(Cancer);
            case IconParkIconKind.Candy: return typeof(Candy);
            case IconParkIconKind.CannedFruit: return typeof(CannedFruit);
            case IconParkIconKind.Capricornus: return typeof(Capricornus);
            case IconParkIconKind.Car: return typeof(Car);
            case IconParkIconKind.CarBattery: return typeof(CarBattery);
            case IconParkIconKind.CardTwo: return typeof(CardTwo);
            case IconParkIconKind.Cardioelectric: return typeof(Cardioelectric);
            case IconParkIconKind.Carousel: return typeof(Carousel);
            case IconParkIconKind.CarouselVideo: return typeof(CarouselVideo);
            case IconParkIconKind.Carrot: return typeof(Carrot);
            case IconParkIconKind.CastScreen: return typeof(CastScreen);
            case IconParkIconKind.Castle: return typeof(Castle);
            case IconParkIconKind.Cat: return typeof(Cat);
            case IconParkIconKind.CategoryManagement: return typeof(CategoryManagement);
            case IconParkIconKind.Cattle: return typeof(Cattle);
            case IconParkIconKind.CattleZodiac: return typeof(CattleZodiac);
            case IconParkIconKind.Caution: return typeof(Caution);
            case IconParkIconKind.Cc: return typeof(Cc);
            case IconParkIconKind.Cd: return typeof(Cd);
            case IconParkIconKind.CeMarking: return typeof(CeMarking);
            case IconParkIconKind.Cell: return typeof(Cell);
            case IconParkIconKind.CenterAlignment: return typeof(CenterAlignment);
            case IconParkIconKind.Certificate: return typeof(Certificate);
            case IconParkIconKind.ChafingDish: return typeof(ChafingDish);
            case IconParkIconKind.ChafingDishOne: return typeof(ChafingDishOne);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk5(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Bug => new Bug(),
            IconParkIconKind.BuildingFour => new BuildingFour(),
            IconParkIconKind.BuildingOne => new BuildingOne(),
            IconParkIconKind.BuildingThree => new BuildingThree(),
            IconParkIconKind.BuildingTwo => new BuildingTwo(),
            IconParkIconKind.BulletMap => new BulletMap(),
            IconParkIconKind.Bus => new Bus(),
            IconParkIconKind.BusOne => new BusOne(),
            IconParkIconKind.BusTwo => new BusTwo(),
            IconParkIconKind.Butterfly => new Butterfly(),
            IconParkIconKind.Buy => new Buy(),
            IconParkIconKind.Bydesign => new Bydesign(),
            IconParkIconKind.Bye => new Bye(),
            IconParkIconKind.Bytedance => new Bytedance(),
            IconParkIconKind.BytedanceApplets => new BytedanceApplets(),
            IconParkIconKind.BytedanceMiniApp => new BytedanceMiniApp(),
            IconParkIconKind.CableCar => new CableCar(),
            IconParkIconKind.Cactus => new Cactus(),
            IconParkIconKind.Cake => new Cake(),
            IconParkIconKind.CakeFive => new CakeFive(),
            IconParkIconKind.CakeFour => new CakeFour(),
            IconParkIconKind.CakeOne => new CakeOne(),
            IconParkIconKind.CakeThree => new CakeThree(),
            IconParkIconKind.CakeTwo => new CakeTwo(),
            IconParkIconKind.Calculator => new Calculator(),
            IconParkIconKind.CalculatorOne => new CalculatorOne(),
            IconParkIconKind.Calendar => new Calendar(),
            IconParkIconKind.CalendarDot => new CalendarDot(),
            IconParkIconKind.CalendarThirty => new CalendarThirty(),
            IconParkIconKind.CalendarThirtyTwo => new CalendarThirtyTwo(),
            IconParkIconKind.CalendarThree => new CalendarThree(),
            IconParkIconKind.Camera => new Camera(),
            IconParkIconKind.CameraFive => new CameraFive(),
            IconParkIconKind.CameraFour => new CameraFour(),
            IconParkIconKind.CameraOne => new CameraOne(),
            IconParkIconKind.CameraThree => new CameraThree(),
            IconParkIconKind.CameraTwo => new CameraTwo(),
            IconParkIconKind.Camp => new Camp(),
            IconParkIconKind.Cancer => new Cancer(),
            IconParkIconKind.Candy => new Candy(),
            IconParkIconKind.CannedFruit => new CannedFruit(),
            IconParkIconKind.Capricornus => new Capricornus(),
            IconParkIconKind.Car => new Car(),
            IconParkIconKind.CarBattery => new CarBattery(),
            IconParkIconKind.CardTwo => new CardTwo(),
            IconParkIconKind.Cardioelectric => new Cardioelectric(),
            IconParkIconKind.Carousel => new Carousel(),
            IconParkIconKind.CarouselVideo => new CarouselVideo(),
            IconParkIconKind.Carrot => new Carrot(),
            IconParkIconKind.CastScreen => new CastScreen(),
            IconParkIconKind.Castle => new Castle(),
            IconParkIconKind.Cat => new Cat(),
            IconParkIconKind.CategoryManagement => new CategoryManagement(),
            IconParkIconKind.Cattle => new Cattle(),
            IconParkIconKind.CattleZodiac => new CattleZodiac(),
            IconParkIconKind.Caution => new Caution(),
            IconParkIconKind.Cc => new Cc(),
            IconParkIconKind.Cd => new Cd(),
            IconParkIconKind.CeMarking => new CeMarking(),
            IconParkIconKind.Cell => new Cell(),
            IconParkIconKind.CenterAlignment => new CenterAlignment(),
            IconParkIconKind.Certificate => new Certificate(),
            IconParkIconKind.ChafingDish => new ChafingDish(),
            IconParkIconKind.ChafingDishOne => new ChafingDishOne(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk6(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Chair: return typeof(Chair);
            case IconParkIconKind.ChairOne: return typeof(ChairOne);
            case IconParkIconKind.Change: return typeof(Change);
            case IconParkIconKind.ChangeDateSort: return typeof(ChangeDateSort);
            case IconParkIconKind.ChargingTreasure: return typeof(ChargingTreasure);
            case IconParkIconKind.ChartGraph: return typeof(ChartGraph);
            case IconParkIconKind.ChartHistogram: return typeof(ChartHistogram);
            case IconParkIconKind.ChartHistogramOne: return typeof(ChartHistogramOne);
            case IconParkIconKind.ChartHistogramTwo: return typeof(ChartHistogramTwo);
            case IconParkIconKind.ChartLine: return typeof(ChartLine);
            case IconParkIconKind.ChartLineArea: return typeof(ChartLineArea);
            case IconParkIconKind.ChartPie: return typeof(ChartPie);
            case IconParkIconKind.ChartPieOne: return typeof(ChartPieOne);
            case IconParkIconKind.ChartProportion: return typeof(ChartProportion);
            case IconParkIconKind.ChartRing: return typeof(ChartRing);
            case IconParkIconKind.ChartScatter: return typeof(ChartScatter);
            case IconParkIconKind.ChartStock: return typeof(ChartStock);
            case IconParkIconKind.Check: return typeof(Check);
            case IconParkIconKind.CheckCorrect: return typeof(CheckCorrect);
            case IconParkIconKind.CheckIn: return typeof(CheckIn);
            case IconParkIconKind.CheckOne: return typeof(CheckOne);
            case IconParkIconKind.CheckSmall: return typeof(CheckSmall);
            case IconParkIconKind.Checkbox: return typeof(Checkbox);
            case IconParkIconKind.Checkerboard: return typeof(Checkerboard);
            case IconParkIconKind.Checklist: return typeof(Checklist);
            case IconParkIconKind.Cheese: return typeof(Cheese);
            case IconParkIconKind.ChefHat: return typeof(ChefHat);
            case IconParkIconKind.ChefHatOne: return typeof(ChefHatOne);
            case IconParkIconKind.Cherry: return typeof(Cherry);
            case IconParkIconKind.Chess: return typeof(Chess);
            case IconParkIconKind.ChessOne: return typeof(ChessOne);
            case IconParkIconKind.Chest: return typeof(Chest);
            case IconParkIconKind.Chicken: return typeof(Chicken);
            case IconParkIconKind.ChickenLeg: return typeof(ChickenLeg);
            case IconParkIconKind.ChickenZodiac: return typeof(ChickenZodiac);
            case IconParkIconKind.ChildWithPacifier: return typeof(ChildWithPacifier);
            case IconParkIconKind.ChildrenCap: return typeof(ChildrenCap);
            case IconParkIconKind.ChildrenPyramid: return typeof(ChildrenPyramid);
            case IconParkIconKind.Chili: return typeof(Chili);
            case IconParkIconKind.Chimney: return typeof(Chimney);
            case IconParkIconKind.Chinese: return typeof(Chinese);
            case IconParkIconKind.ChineseOne: return typeof(ChineseOne);
            case IconParkIconKind.ChinesePavilion: return typeof(ChinesePavilion);
            case IconParkIconKind.Chip: return typeof(Chip);
            case IconParkIconKind.ChoppingBoard: return typeof(ChoppingBoard);
            case IconParkIconKind.ChopsticksFork: return typeof(ChopsticksFork);
            case IconParkIconKind.ChristmasTree: return typeof(ChristmasTree);
            case IconParkIconKind.ChristmasTreeOne: return typeof(ChristmasTreeOne);
            case IconParkIconKind.ChurchOne: return typeof(ChurchOne);
            case IconParkIconKind.ChurchTwo: return typeof(ChurchTwo);
            case IconParkIconKind.CircleDoubleDown: return typeof(CircleDoubleDown);
            case IconParkIconKind.CircleDoubleLeft: return typeof(CircleDoubleLeft);
            case IconParkIconKind.CircleDoubleRight: return typeof(CircleDoubleRight);
            case IconParkIconKind.CircleDoubleUp: return typeof(CircleDoubleUp);
            case IconParkIconKind.CircleFiveLine: return typeof(CircleFiveLine);
            case IconParkIconKind.CircleFour: return typeof(CircleFour);
            case IconParkIconKind.CircleFourLine: return typeof(CircleFourLine);
            case IconParkIconKind.CircleHouse: return typeof(CircleHouse);
            case IconParkIconKind.CircleLeftDown: return typeof(CircleLeftDown);
            case IconParkIconKind.CircleLeftUp: return typeof(CircleLeftUp);
            case IconParkIconKind.CircleRightDown: return typeof(CircleRightDown);
            case IconParkIconKind.CircleRightUp: return typeof(CircleRightUp);
            case IconParkIconKind.CircleThree: return typeof(CircleThree);
            case IconParkIconKind.CircleTwoLine: return typeof(CircleTwoLine);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk6(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Chair => new Chair(),
            IconParkIconKind.ChairOne => new ChairOne(),
            IconParkIconKind.Change => new Change(),
            IconParkIconKind.ChangeDateSort => new ChangeDateSort(),
            IconParkIconKind.ChargingTreasure => new ChargingTreasure(),
            IconParkIconKind.ChartGraph => new ChartGraph(),
            IconParkIconKind.ChartHistogram => new ChartHistogram(),
            IconParkIconKind.ChartHistogramOne => new ChartHistogramOne(),
            IconParkIconKind.ChartHistogramTwo => new ChartHistogramTwo(),
            IconParkIconKind.ChartLine => new ChartLine(),
            IconParkIconKind.ChartLineArea => new ChartLineArea(),
            IconParkIconKind.ChartPie => new ChartPie(),
            IconParkIconKind.ChartPieOne => new ChartPieOne(),
            IconParkIconKind.ChartProportion => new ChartProportion(),
            IconParkIconKind.ChartRing => new ChartRing(),
            IconParkIconKind.ChartScatter => new ChartScatter(),
            IconParkIconKind.ChartStock => new ChartStock(),
            IconParkIconKind.Check => new Check(),
            IconParkIconKind.CheckCorrect => new CheckCorrect(),
            IconParkIconKind.CheckIn => new CheckIn(),
            IconParkIconKind.CheckOne => new CheckOne(),
            IconParkIconKind.CheckSmall => new CheckSmall(),
            IconParkIconKind.Checkbox => new Checkbox(),
            IconParkIconKind.Checkerboard => new Checkerboard(),
            IconParkIconKind.Checklist => new Checklist(),
            IconParkIconKind.Cheese => new Cheese(),
            IconParkIconKind.ChefHat => new ChefHat(),
            IconParkIconKind.ChefHatOne => new ChefHatOne(),
            IconParkIconKind.Cherry => new Cherry(),
            IconParkIconKind.Chess => new Chess(),
            IconParkIconKind.ChessOne => new ChessOne(),
            IconParkIconKind.Chest => new Chest(),
            IconParkIconKind.Chicken => new Chicken(),
            IconParkIconKind.ChickenLeg => new ChickenLeg(),
            IconParkIconKind.ChickenZodiac => new ChickenZodiac(),
            IconParkIconKind.ChildWithPacifier => new ChildWithPacifier(),
            IconParkIconKind.ChildrenCap => new ChildrenCap(),
            IconParkIconKind.ChildrenPyramid => new ChildrenPyramid(),
            IconParkIconKind.Chili => new Chili(),
            IconParkIconKind.Chimney => new Chimney(),
            IconParkIconKind.Chinese => new Chinese(),
            IconParkIconKind.ChineseOne => new ChineseOne(),
            IconParkIconKind.ChinesePavilion => new ChinesePavilion(),
            IconParkIconKind.Chip => new Chip(),
            IconParkIconKind.ChoppingBoard => new ChoppingBoard(),
            IconParkIconKind.ChopsticksFork => new ChopsticksFork(),
            IconParkIconKind.ChristmasTree => new ChristmasTree(),
            IconParkIconKind.ChristmasTreeOne => new ChristmasTreeOne(),
            IconParkIconKind.ChurchOne => new ChurchOne(),
            IconParkIconKind.ChurchTwo => new ChurchTwo(),
            IconParkIconKind.CircleDoubleDown => new CircleDoubleDown(),
            IconParkIconKind.CircleDoubleLeft => new CircleDoubleLeft(),
            IconParkIconKind.CircleDoubleRight => new CircleDoubleRight(),
            IconParkIconKind.CircleDoubleUp => new CircleDoubleUp(),
            IconParkIconKind.CircleFiveLine => new CircleFiveLine(),
            IconParkIconKind.CircleFour => new CircleFour(),
            IconParkIconKind.CircleFourLine => new CircleFourLine(),
            IconParkIconKind.CircleHouse => new CircleHouse(),
            IconParkIconKind.CircleLeftDown => new CircleLeftDown(),
            IconParkIconKind.CircleLeftUp => new CircleLeftUp(),
            IconParkIconKind.CircleRightDown => new CircleRightDown(),
            IconParkIconKind.CircleRightUp => new CircleRightUp(),
            IconParkIconKind.CircleThree => new CircleThree(),
            IconParkIconKind.CircleTwoLine => new CircleTwoLine(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk7(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.CirclesAndTriangles: return typeof(CirclesAndTriangles);
            case IconParkIconKind.CirclesSeven: return typeof(CirclesSeven);
            case IconParkIconKind.CircularConnection: return typeof(CircularConnection);
            case IconParkIconKind.Circus: return typeof(Circus);
            case IconParkIconKind.City: return typeof(City);
            case IconParkIconKind.CityGate: return typeof(CityGate);
            case IconParkIconKind.CityOne: return typeof(CityOne);
            case IconParkIconKind.Clap: return typeof(Clap);
            case IconParkIconKind.Classroom: return typeof(Classroom);
            case IconParkIconKind.Clear: return typeof(Clear);
            case IconParkIconKind.ClearFormat: return typeof(ClearFormat);
            case IconParkIconKind.Click: return typeof(Click);
            case IconParkIconKind.ClickTap: return typeof(ClickTap);
            case IconParkIconKind.ClickTapTwo: return typeof(ClickTapTwo);
            case IconParkIconKind.ClickToFold: return typeof(ClickToFold);
            case IconParkIconKind.Clipboard: return typeof(Clipboard);
            case IconParkIconKind.ClockTower: return typeof(ClockTower);
            case IconParkIconKind.Close: return typeof(Close);
            case IconParkIconKind.CloseOne: return typeof(CloseOne);
            case IconParkIconKind.CloseRemind: return typeof(CloseRemind);
            case IconParkIconKind.CloseSmall: return typeof(CloseSmall);
            case IconParkIconKind.CloseWifi: return typeof(CloseWifi);
            case IconParkIconKind.ClothesBriefs: return typeof(ClothesBriefs);
            case IconParkIconKind.ClothesCardigan: return typeof(ClothesCardigan);
            case IconParkIconKind.ClothesCrewNeck: return typeof(ClothesCrewNeck);
            case IconParkIconKind.ClothesDiapers: return typeof(ClothesDiapers);
            case IconParkIconKind.ClothesGloves: return typeof(ClothesGloves);
            case IconParkIconKind.ClothesGlovesTwo: return typeof(ClothesGlovesTwo);
            case IconParkIconKind.ClothesHoodie: return typeof(ClothesHoodie);
            case IconParkIconKind.ClothesPants: return typeof(ClothesPants);
            case IconParkIconKind.ClothesPantsShort: return typeof(ClothesPantsShort);
            case IconParkIconKind.ClothesPantsSweat: return typeof(ClothesPantsSweat);
            case IconParkIconKind.ClothesShortSleeve: return typeof(ClothesShortSleeve);
            case IconParkIconKind.ClothesSkates: return typeof(ClothesSkates);
            case IconParkIconKind.ClothesSuit: return typeof(ClothesSuit);
            case IconParkIconKind.ClothesSweater: return typeof(ClothesSweater);
            case IconParkIconKind.ClothesTurtleneck: return typeof(ClothesTurtleneck);
            case IconParkIconKind.ClothesWindbreaker: return typeof(ClothesWindbreaker);
            case IconParkIconKind.CloudStorage: return typeof(CloudStorage);
            case IconParkIconKind.Cloudy: return typeof(Cloudy);
            case IconParkIconKind.CloudyNight: return typeof(CloudyNight);
            case IconParkIconKind.Clue: return typeof(Clue);
            case IconParkIconKind.CoatHanger: return typeof(CoatHanger);
            case IconParkIconKind.Cocktail: return typeof(Cocktail);
            case IconParkIconKind.CoconutTree: return typeof(CoconutTree);
            case IconParkIconKind.Code: return typeof(Code);
            case IconParkIconKind.CodeBrackets: return typeof(CodeBrackets);
            case IconParkIconKind.CodeComputer: return typeof(CodeComputer);
            case IconParkIconKind.CodeDownload: return typeof(CodeDownload);
            case IconParkIconKind.CodeLaptop: return typeof(CodeLaptop);
            case IconParkIconKind.CodeOne: return typeof(CodeOne);
            case IconParkIconKind.CoffeeMachine: return typeof(CoffeeMachine);
            case IconParkIconKind.Cola: return typeof(Cola);
            case IconParkIconKind.CollapseTextInput: return typeof(CollapseTextInput);
            case IconParkIconKind.CollectComputer: return typeof(CollectComputer);
            case IconParkIconKind.CollectLaptop: return typeof(CollectLaptop);
            case IconParkIconKind.CollectPicture: return typeof(CollectPicture);
            case IconParkIconKind.CollectionFiles: return typeof(CollectionFiles);
            case IconParkIconKind.CollectionRecords: return typeof(CollectionRecords);
            case IconParkIconKind.ColorCard: return typeof(ColorCard);
            case IconParkIconKind.ColorFilter: return typeof(ColorFilter);
            case IconParkIconKind.Column: return typeof(Column);
            case IconParkIconKind.Comb: return typeof(Comb);
            case IconParkIconKind.Come: return typeof(Come);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk7(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.CirclesAndTriangles => new CirclesAndTriangles(),
            IconParkIconKind.CirclesSeven => new CirclesSeven(),
            IconParkIconKind.CircularConnection => new CircularConnection(),
            IconParkIconKind.Circus => new Circus(),
            IconParkIconKind.City => new City(),
            IconParkIconKind.CityGate => new CityGate(),
            IconParkIconKind.CityOne => new CityOne(),
            IconParkIconKind.Clap => new Clap(),
            IconParkIconKind.Classroom => new Classroom(),
            IconParkIconKind.Clear => new Clear(),
            IconParkIconKind.ClearFormat => new ClearFormat(),
            IconParkIconKind.Click => new Click(),
            IconParkIconKind.ClickTap => new ClickTap(),
            IconParkIconKind.ClickTapTwo => new ClickTapTwo(),
            IconParkIconKind.ClickToFold => new ClickToFold(),
            IconParkIconKind.Clipboard => new Clipboard(),
            IconParkIconKind.ClockTower => new ClockTower(),
            IconParkIconKind.Close => new Close(),
            IconParkIconKind.CloseOne => new CloseOne(),
            IconParkIconKind.CloseRemind => new CloseRemind(),
            IconParkIconKind.CloseSmall => new CloseSmall(),
            IconParkIconKind.CloseWifi => new CloseWifi(),
            IconParkIconKind.ClothesBriefs => new ClothesBriefs(),
            IconParkIconKind.ClothesCardigan => new ClothesCardigan(),
            IconParkIconKind.ClothesCrewNeck => new ClothesCrewNeck(),
            IconParkIconKind.ClothesDiapers => new ClothesDiapers(),
            IconParkIconKind.ClothesGloves => new ClothesGloves(),
            IconParkIconKind.ClothesGlovesTwo => new ClothesGlovesTwo(),
            IconParkIconKind.ClothesHoodie => new ClothesHoodie(),
            IconParkIconKind.ClothesPants => new ClothesPants(),
            IconParkIconKind.ClothesPantsShort => new ClothesPantsShort(),
            IconParkIconKind.ClothesPantsSweat => new ClothesPantsSweat(),
            IconParkIconKind.ClothesShortSleeve => new ClothesShortSleeve(),
            IconParkIconKind.ClothesSkates => new ClothesSkates(),
            IconParkIconKind.ClothesSuit => new ClothesSuit(),
            IconParkIconKind.ClothesSweater => new ClothesSweater(),
            IconParkIconKind.ClothesTurtleneck => new ClothesTurtleneck(),
            IconParkIconKind.ClothesWindbreaker => new ClothesWindbreaker(),
            IconParkIconKind.CloudStorage => new CloudStorage(),
            IconParkIconKind.Cloudy => new Cloudy(),
            IconParkIconKind.CloudyNight => new CloudyNight(),
            IconParkIconKind.Clue => new Clue(),
            IconParkIconKind.CoatHanger => new CoatHanger(),
            IconParkIconKind.Cocktail => new Cocktail(),
            IconParkIconKind.CoconutTree => new CoconutTree(),
            IconParkIconKind.Code => new Code(),
            IconParkIconKind.CodeBrackets => new CodeBrackets(),
            IconParkIconKind.CodeComputer => new CodeComputer(),
            IconParkIconKind.CodeDownload => new CodeDownload(),
            IconParkIconKind.CodeLaptop => new CodeLaptop(),
            IconParkIconKind.CodeOne => new CodeOne(),
            IconParkIconKind.CoffeeMachine => new CoffeeMachine(),
            IconParkIconKind.Cola => new Cola(),
            IconParkIconKind.CollapseTextInput => new CollapseTextInput(),
            IconParkIconKind.CollectComputer => new CollectComputer(),
            IconParkIconKind.CollectLaptop => new CollectLaptop(),
            IconParkIconKind.CollectPicture => new CollectPicture(),
            IconParkIconKind.CollectionFiles => new CollectionFiles(),
            IconParkIconKind.CollectionRecords => new CollectionRecords(),
            IconParkIconKind.ColorCard => new ColorCard(),
            IconParkIconKind.ColorFilter => new ColorFilter(),
            IconParkIconKind.Column => new Column(),
            IconParkIconKind.Comb => new Comb(),
            IconParkIconKind.Come => new Come(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk8(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Command: return typeof(Command);
            case IconParkIconKind.Comment: return typeof(Comment);
            case IconParkIconKind.CommentOne: return typeof(CommentOne);
            case IconParkIconKind.Comments: return typeof(Comments);
            case IconParkIconKind.Commodity: return typeof(Commodity);
            case IconParkIconKind.Communication: return typeof(Communication);
            case IconParkIconKind.CommuterBag: return typeof(CommuterBag);
            case IconParkIconKind.Compass: return typeof(Compass);
            case IconParkIconKind.CompassOne: return typeof(CompassOne);
            case IconParkIconKind.Components: return typeof(Components);
            case IconParkIconKind.Composition: return typeof(Composition);
            case IconParkIconKind.Compression: return typeof(Compression);
            case IconParkIconKind.Computer: return typeof(Computer);
            case IconParkIconKind.ComputerOne: return typeof(ComputerOne);
            case IconParkIconKind.ConceptSharing: return typeof(ConceptSharing);
            case IconParkIconKind.Concern: return typeof(Concern);
            case IconParkIconKind.Conditioner: return typeof(Conditioner);
            case IconParkIconKind.Cone: return typeof(Cone);
            case IconParkIconKind.Cones: return typeof(Cones);
            case IconParkIconKind.Config: return typeof(Config);
            case IconParkIconKind.ConfoundedFace: return typeof(ConfoundedFace);
            case IconParkIconKind.ConfusedFace: return typeof(ConfusedFace);
            case IconParkIconKind.Connect: return typeof(Connect);
            case IconParkIconKind.ConnectAddressOne: return typeof(ConnectAddressOne);
            case IconParkIconKind.ConnectAddressTwo: return typeof(ConnectAddressTwo);
            case IconParkIconKind.Connection: return typeof(Connection);
            case IconParkIconKind.ConnectionArrow: return typeof(ConnectionArrow);
            case IconParkIconKind.ConnectionBox: return typeof(ConnectionBox);
            case IconParkIconKind.ConnectionPoint: return typeof(ConnectionPoint);
            case IconParkIconKind.ConnectionPointTwo: return typeof(ConnectionPointTwo);
            case IconParkIconKind.Consignment: return typeof(Consignment);
            case IconParkIconKind.Consume: return typeof(Consume);
            case IconParkIconKind.Contrast: return typeof(Contrast);
            case IconParkIconKind.ContrastView: return typeof(ContrastView);
            case IconParkIconKind.ContrastViewCircle: return typeof(ContrastViewCircle);
            case IconParkIconKind.Control: return typeof(Control);
            case IconParkIconKind.ConvergingGateway: return typeof(ConvergingGateway);
            case IconParkIconKind.Cook: return typeof(Cook);
            case IconParkIconKind.Cooking: return typeof(Cooking);
            case IconParkIconKind.CookingPot: return typeof(CookingPot);
            case IconParkIconKind.Cool: return typeof(Cool);
            case IconParkIconKind.CooperativeHandshake: return typeof(CooperativeHandshake);
            case IconParkIconKind.CoordinateSystem: return typeof(CoordinateSystem);
            case IconParkIconKind.Copy: return typeof(Copy);
            case IconParkIconKind.CopyLink: return typeof(CopyLink);
            case IconParkIconKind.CopyOne: return typeof(CopyOne);
            case IconParkIconKind.Copyright: return typeof(Copyright);
            case IconParkIconKind.CornerDownLeft: return typeof(CornerDownLeft);
            case IconParkIconKind.CornerDownRight: return typeof(CornerDownRight);
            case IconParkIconKind.CornerLeftDown: return typeof(CornerLeftDown);
            case IconParkIconKind.CornerLeftUp: return typeof(CornerLeftUp);
            case IconParkIconKind.CornerRightDown: return typeof(CornerRightDown);
            case IconParkIconKind.CornerRightUp: return typeof(CornerRightUp);
            case IconParkIconKind.CornerUpLeft: return typeof(CornerUpLeft);
            case IconParkIconKind.CornerUpRight: return typeof(CornerUpRight);
            case IconParkIconKind.Coronavirus: return typeof(Coronavirus);
            case IconParkIconKind.Correct: return typeof(Correct);
            case IconParkIconKind.CosmeticBrush: return typeof(CosmeticBrush);
            case IconParkIconKind.Coupon: return typeof(Coupon);
            case IconParkIconKind.Court: return typeof(Court);
            case IconParkIconKind.Cpu: return typeof(Cpu);
            case IconParkIconKind.Crab: return typeof(Crab);
            case IconParkIconKind.CreationDateSort: return typeof(CreationDateSort);
            case IconParkIconKind.Creative: return typeof(Creative);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk8(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Command => new Command(),
            IconParkIconKind.Comment => new Comment(),
            IconParkIconKind.CommentOne => new CommentOne(),
            IconParkIconKind.Comments => new Comments(),
            IconParkIconKind.Commodity => new Commodity(),
            IconParkIconKind.Communication => new Communication(),
            IconParkIconKind.CommuterBag => new CommuterBag(),
            IconParkIconKind.Compass => new Compass(),
            IconParkIconKind.CompassOne => new CompassOne(),
            IconParkIconKind.Components => new Components(),
            IconParkIconKind.Composition => new Composition(),
            IconParkIconKind.Compression => new Compression(),
            IconParkIconKind.Computer => new Computer(),
            IconParkIconKind.ComputerOne => new ComputerOne(),
            IconParkIconKind.ConceptSharing => new ConceptSharing(),
            IconParkIconKind.Concern => new Concern(),
            IconParkIconKind.Conditioner => new Conditioner(),
            IconParkIconKind.Cone => new Cone(),
            IconParkIconKind.Cones => new Cones(),
            IconParkIconKind.Config => new Config(),
            IconParkIconKind.ConfoundedFace => new ConfoundedFace(),
            IconParkIconKind.ConfusedFace => new ConfusedFace(),
            IconParkIconKind.Connect => new Connect(),
            IconParkIconKind.ConnectAddressOne => new ConnectAddressOne(),
            IconParkIconKind.ConnectAddressTwo => new ConnectAddressTwo(),
            IconParkIconKind.Connection => new Connection(),
            IconParkIconKind.ConnectionArrow => new ConnectionArrow(),
            IconParkIconKind.ConnectionBox => new ConnectionBox(),
            IconParkIconKind.ConnectionPoint => new ConnectionPoint(),
            IconParkIconKind.ConnectionPointTwo => new ConnectionPointTwo(),
            IconParkIconKind.Consignment => new Consignment(),
            IconParkIconKind.Consume => new Consume(),
            IconParkIconKind.Contrast => new Contrast(),
            IconParkIconKind.ContrastView => new ContrastView(),
            IconParkIconKind.ContrastViewCircle => new ContrastViewCircle(),
            IconParkIconKind.Control => new Control(),
            IconParkIconKind.ConvergingGateway => new ConvergingGateway(),
            IconParkIconKind.Cook => new Cook(),
            IconParkIconKind.Cooking => new Cooking(),
            IconParkIconKind.CookingPot => new CookingPot(),
            IconParkIconKind.Cool => new Cool(),
            IconParkIconKind.CooperativeHandshake => new CooperativeHandshake(),
            IconParkIconKind.CoordinateSystem => new CoordinateSystem(),
            IconParkIconKind.Copy => new Copy(),
            IconParkIconKind.CopyLink => new CopyLink(),
            IconParkIconKind.CopyOne => new CopyOne(),
            IconParkIconKind.Copyright => new Copyright(),
            IconParkIconKind.CornerDownLeft => new CornerDownLeft(),
            IconParkIconKind.CornerDownRight => new CornerDownRight(),
            IconParkIconKind.CornerLeftDown => new CornerLeftDown(),
            IconParkIconKind.CornerLeftUp => new CornerLeftUp(),
            IconParkIconKind.CornerRightDown => new CornerRightDown(),
            IconParkIconKind.CornerRightUp => new CornerRightUp(),
            IconParkIconKind.CornerUpLeft => new CornerUpLeft(),
            IconParkIconKind.CornerUpRight => new CornerUpRight(),
            IconParkIconKind.Coronavirus => new Coronavirus(),
            IconParkIconKind.Correct => new Correct(),
            IconParkIconKind.CosmeticBrush => new CosmeticBrush(),
            IconParkIconKind.Coupon => new Coupon(),
            IconParkIconKind.Court => new Court(),
            IconParkIconKind.Cpu => new Cpu(),
            IconParkIconKind.Crab => new Crab(),
            IconParkIconKind.CreationDateSort => new CreationDateSort(),
            IconParkIconKind.Creative => new Creative(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk9(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Credit: return typeof(Credit);
            case IconParkIconKind.Crib: return typeof(Crib);
            case IconParkIconKind.Croissant: return typeof(Croissant);
            case IconParkIconKind.CrossRing: return typeof(CrossRing);
            case IconParkIconKind.CrossRingTwo: return typeof(CrossRingTwo);
            case IconParkIconKind.CrossSociety: return typeof(CrossSociety);
            case IconParkIconKind.Crown: return typeof(Crown);
            case IconParkIconKind.CrownThree: return typeof(CrownThree);
            case IconParkIconKind.CrownTwo: return typeof(CrownTwo);
            case IconParkIconKind.Cruise: return typeof(Cruise);
            case IconParkIconKind.CryingBaby: return typeof(CryingBaby);
            case IconParkIconKind.Cube: return typeof(Cube);
            case IconParkIconKind.CubeFive: return typeof(CubeFive);
            case IconParkIconKind.CubeFour: return typeof(CubeFour);
            case IconParkIconKind.CubeThree: return typeof(CubeThree);
            case IconParkIconKind.CubeTwo: return typeof(CubeTwo);
            case IconParkIconKind.Cup: return typeof(Cup);
            case IconParkIconKind.CupFour: return typeof(CupFour);
            case IconParkIconKind.CupOne: return typeof(CupOne);
            case IconParkIconKind.Curling: return typeof(Curling);
            case IconParkIconKind.Currency: return typeof(Currency);
            case IconParkIconKind.CurveAdjustment: return typeof(CurveAdjustment);
            case IconParkIconKind.Customer: return typeof(Customer);
            case IconParkIconKind.Cutting: return typeof(Cutting);
            case IconParkIconKind.CuttingOne: return typeof(CuttingOne);
            case IconParkIconKind.Cuvette: return typeof(Cuvette);
            case IconParkIconKind.Cycle: return typeof(Cycle);
            case IconParkIconKind.CycleArrow: return typeof(CycleArrow);
            case IconParkIconKind.CycleMovement: return typeof(CycleMovement);
            case IconParkIconKind.CycleOne: return typeof(CycleOne);
            case IconParkIconKind.Cylinder: return typeof(Cylinder);
            case IconParkIconKind.DamageMap: return typeof(DamageMap);
            case IconParkIconKind.DarkMode: return typeof(DarkMode);
            case IconParkIconKind.Dashboard: return typeof(Dashboard);
            case IconParkIconKind.DashboardCar: return typeof(DashboardCar);
            case IconParkIconKind.DashboardOne: return typeof(DashboardOne);
            case IconParkIconKind.DashboardTwo: return typeof(DashboardTwo);
            case IconParkIconKind.Data: return typeof(Data);
            case IconParkIconKind.DataAll: return typeof(DataAll);
            case IconParkIconKind.DataArrival: return typeof(DataArrival);
            case IconParkIconKind.DataDisplay: return typeof(DataDisplay);
            case IconParkIconKind.DataFile: return typeof(DataFile);
            case IconParkIconKind.DataFour: return typeof(DataFour);
            case IconParkIconKind.DataLock: return typeof(DataLock);
            case IconParkIconKind.DataNull: return typeof(DataNull);
            case IconParkIconKind.DataOne: return typeof(DataOne);
            case IconParkIconKind.DataScreen: return typeof(DataScreen);
            case IconParkIconKind.DataServer: return typeof(DataServer);
            case IconParkIconKind.DataSheet: return typeof(DataSheet);
            case IconParkIconKind.DataSwitching: return typeof(DataSwitching);
            case IconParkIconKind.DataThree: return typeof(DataThree);
            case IconParkIconKind.DataTwo: return typeof(DataTwo);
            case IconParkIconKind.DataUser: return typeof(DataUser);
            case IconParkIconKind.DatabaseAlert: return typeof(DatabaseAlert);
            case IconParkIconKind.DatabaseCode: return typeof(DatabaseCode);
            case IconParkIconKind.DatabaseConfig: return typeof(DatabaseConfig);
            case IconParkIconKind.DatabaseDownload: return typeof(DatabaseDownload);
            case IconParkIconKind.DatabaseEnter: return typeof(DatabaseEnter);
            case IconParkIconKind.DatabaseFail: return typeof(DatabaseFail);
            case IconParkIconKind.DatabaseFirst: return typeof(DatabaseFirst);
            case IconParkIconKind.DatabaseForbid: return typeof(DatabaseForbid);
            case IconParkIconKind.DatabaseLock: return typeof(DatabaseLock);
            case IconParkIconKind.DatabaseNetwork: return typeof(DatabaseNetwork);
            case IconParkIconKind.DatabaseNetworkPoint: return typeof(DatabaseNetworkPoint);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk9(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Credit => new Credit(),
            IconParkIconKind.Crib => new Crib(),
            IconParkIconKind.Croissant => new Croissant(),
            IconParkIconKind.CrossRing => new CrossRing(),
            IconParkIconKind.CrossRingTwo => new CrossRingTwo(),
            IconParkIconKind.CrossSociety => new CrossSociety(),
            IconParkIconKind.Crown => new Crown(),
            IconParkIconKind.CrownThree => new CrownThree(),
            IconParkIconKind.CrownTwo => new CrownTwo(),
            IconParkIconKind.Cruise => new Cruise(),
            IconParkIconKind.CryingBaby => new CryingBaby(),
            IconParkIconKind.Cube => new Cube(),
            IconParkIconKind.CubeFive => new CubeFive(),
            IconParkIconKind.CubeFour => new CubeFour(),
            IconParkIconKind.CubeThree => new CubeThree(),
            IconParkIconKind.CubeTwo => new CubeTwo(),
            IconParkIconKind.Cup => new Cup(),
            IconParkIconKind.CupFour => new CupFour(),
            IconParkIconKind.CupOne => new CupOne(),
            IconParkIconKind.Curling => new Curling(),
            IconParkIconKind.Currency => new Currency(),
            IconParkIconKind.CurveAdjustment => new CurveAdjustment(),
            IconParkIconKind.Customer => new Customer(),
            IconParkIconKind.Cutting => new Cutting(),
            IconParkIconKind.CuttingOne => new CuttingOne(),
            IconParkIconKind.Cuvette => new Cuvette(),
            IconParkIconKind.Cycle => new Cycle(),
            IconParkIconKind.CycleArrow => new CycleArrow(),
            IconParkIconKind.CycleMovement => new CycleMovement(),
            IconParkIconKind.CycleOne => new CycleOne(),
            IconParkIconKind.Cylinder => new Cylinder(),
            IconParkIconKind.DamageMap => new DamageMap(),
            IconParkIconKind.DarkMode => new DarkMode(),
            IconParkIconKind.Dashboard => new Dashboard(),
            IconParkIconKind.DashboardCar => new DashboardCar(),
            IconParkIconKind.DashboardOne => new DashboardOne(),
            IconParkIconKind.DashboardTwo => new DashboardTwo(),
            IconParkIconKind.Data => new Data(),
            IconParkIconKind.DataAll => new DataAll(),
            IconParkIconKind.DataArrival => new DataArrival(),
            IconParkIconKind.DataDisplay => new DataDisplay(),
            IconParkIconKind.DataFile => new DataFile(),
            IconParkIconKind.DataFour => new DataFour(),
            IconParkIconKind.DataLock => new DataLock(),
            IconParkIconKind.DataNull => new DataNull(),
            IconParkIconKind.DataOne => new DataOne(),
            IconParkIconKind.DataScreen => new DataScreen(),
            IconParkIconKind.DataServer => new DataServer(),
            IconParkIconKind.DataSheet => new DataSheet(),
            IconParkIconKind.DataSwitching => new DataSwitching(),
            IconParkIconKind.DataThree => new DataThree(),
            IconParkIconKind.DataTwo => new DataTwo(),
            IconParkIconKind.DataUser => new DataUser(),
            IconParkIconKind.DatabaseAlert => new DatabaseAlert(),
            IconParkIconKind.DatabaseCode => new DatabaseCode(),
            IconParkIconKind.DatabaseConfig => new DatabaseConfig(),
            IconParkIconKind.DatabaseDownload => new DatabaseDownload(),
            IconParkIconKind.DatabaseEnter => new DatabaseEnter(),
            IconParkIconKind.DatabaseFail => new DatabaseFail(),
            IconParkIconKind.DatabaseFirst => new DatabaseFirst(),
            IconParkIconKind.DatabaseForbid => new DatabaseForbid(),
            IconParkIconKind.DatabaseLock => new DatabaseLock(),
            IconParkIconKind.DatabaseNetwork => new DatabaseNetwork(),
            IconParkIconKind.DatabaseNetworkPoint => new DatabaseNetworkPoint(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk10(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.DatabasePoint: return typeof(DatabasePoint);
            case IconParkIconKind.DatabasePosition: return typeof(DatabasePosition);
            case IconParkIconKind.DatabasePower: return typeof(DatabasePower);
            case IconParkIconKind.DatabaseProportion: return typeof(DatabaseProportion);
            case IconParkIconKind.DatabaseSearch: return typeof(DatabaseSearch);
            case IconParkIconKind.DatabaseSetting: return typeof(DatabaseSetting);
            case IconParkIconKind.DatabaseSuccess: return typeof(DatabaseSuccess);
            case IconParkIconKind.DatabaseSync: return typeof(DatabaseSync);
            case IconParkIconKind.DatabaseTime: return typeof(DatabaseTime);
            case IconParkIconKind.DateComesBack: return typeof(DateComesBack);
            case IconParkIconKind.DeadlineSort: return typeof(DeadlineSort);
            case IconParkIconKind.DeathStar: return typeof(DeathStar);
            case IconParkIconKind.Deeplink: return typeof(Deeplink);
            case IconParkIconKind.Deer: return typeof(Deer);
            case IconParkIconKind.DegreeHat: return typeof(DegreeHat);
            case IconParkIconKind.Delete: return typeof(Delete);
            case IconParkIconKind.DeleteFive: return typeof(DeleteFive);
            case IconParkIconKind.DeleteFour: return typeof(DeleteFour);
            case IconParkIconKind.DeleteKey: return typeof(DeleteKey);
            case IconParkIconKind.DeleteMode: return typeof(DeleteMode);
            case IconParkIconKind.DeleteOne: return typeof(DeleteOne);
            case IconParkIconKind.DeleteThemes: return typeof(DeleteThemes);
            case IconParkIconKind.DeleteThree: return typeof(DeleteThree);
            case IconParkIconKind.DeleteTwo: return typeof(DeleteTwo);
            case IconParkIconKind.Delivery: return typeof(Delivery);
            case IconParkIconKind.Deposit: return typeof(Deposit);
            case IconParkIconKind.Descend: return typeof(Descend);
            case IconParkIconKind.DeskLamp: return typeof(DeskLamp);
            case IconParkIconKind.DeskLampOne: return typeof(DeskLampOne);
            case IconParkIconKind.Detection: return typeof(Detection);
            case IconParkIconKind.Devices: return typeof(Devices);
            case IconParkIconKind.Diamond: return typeof(Diamond);
            case IconParkIconKind.DiamondNecklace: return typeof(DiamondNecklace);
            case IconParkIconKind.DiamondOne: return typeof(DiamondOne);
            case IconParkIconKind.DiamondRing: return typeof(DiamondRing);
            case IconParkIconKind.DiamondThree: return typeof(DiamondThree);
            case IconParkIconKind.DiamondTwo: return typeof(DiamondTwo);
            case IconParkIconKind.Diamonds: return typeof(Diamonds);
            case IconParkIconKind.Dianziqian: return typeof(Dianziqian);
            case IconParkIconKind.DiapersOne: return typeof(DiapersOne);
            case IconParkIconKind.DifferenceSet: return typeof(DifferenceSet);
            case IconParkIconKind.DigitalWatches: return typeof(DigitalWatches);
            case IconParkIconKind.Direction: return typeof(Direction);
            case IconParkIconKind.DirectionAdjustment: return typeof(DirectionAdjustment);
            case IconParkIconKind.DirectionAdjustmentThree: return typeof(DirectionAdjustmentThree);
            case IconParkIconKind.DirectionAdjustmentTwo: return typeof(DirectionAdjustmentTwo);
            case IconParkIconKind.DisabaledWeb: return typeof(DisabaledWeb);
            case IconParkIconKind.DisabledComputer: return typeof(DisabledComputer);
            case IconParkIconKind.DisabledLaptop: return typeof(DisabledLaptop);
            case IconParkIconKind.DisabledPicture: return typeof(DisabledPicture);
            case IconParkIconKind.DisappointedFace: return typeof(DisappointedFace);
            case IconParkIconKind.DiscoveryIndex: return typeof(DiscoveryIndex);
            case IconParkIconKind.Disk: return typeof(Disk);
            case IconParkIconKind.DiskOne: return typeof(DiskOne);
            case IconParkIconKind.DiskTwo: return typeof(DiskTwo);
            case IconParkIconKind.Dislike: return typeof(Dislike);
            case IconParkIconKind.DislikeTwo: return typeof(DislikeTwo);
            case IconParkIconKind.Display: return typeof(Display);
            case IconParkIconKind.Distortion: return typeof(Distortion);
            case IconParkIconKind.DistraughtFace: return typeof(DistraughtFace);
            case IconParkIconKind.DistributeHorizontalSpacing: return typeof(DistributeHorizontalSpacing);
            case IconParkIconKind.DistributeHorizontally: return typeof(DistributeHorizontally);
            case IconParkIconKind.DistributeVerticalSpacing: return typeof(DistributeVerticalSpacing);
            case IconParkIconKind.DistributeVertically: return typeof(DistributeVertically);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk10(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.DatabasePoint => new DatabasePoint(),
            IconParkIconKind.DatabasePosition => new DatabasePosition(),
            IconParkIconKind.DatabasePower => new DatabasePower(),
            IconParkIconKind.DatabaseProportion => new DatabaseProportion(),
            IconParkIconKind.DatabaseSearch => new DatabaseSearch(),
            IconParkIconKind.DatabaseSetting => new DatabaseSetting(),
            IconParkIconKind.DatabaseSuccess => new DatabaseSuccess(),
            IconParkIconKind.DatabaseSync => new DatabaseSync(),
            IconParkIconKind.DatabaseTime => new DatabaseTime(),
            IconParkIconKind.DateComesBack => new DateComesBack(),
            IconParkIconKind.DeadlineSort => new DeadlineSort(),
            IconParkIconKind.DeathStar => new DeathStar(),
            IconParkIconKind.Deeplink => new Deeplink(),
            IconParkIconKind.Deer => new Deer(),
            IconParkIconKind.DegreeHat => new DegreeHat(),
            IconParkIconKind.Delete => new Delete(),
            IconParkIconKind.DeleteFive => new DeleteFive(),
            IconParkIconKind.DeleteFour => new DeleteFour(),
            IconParkIconKind.DeleteKey => new DeleteKey(),
            IconParkIconKind.DeleteMode => new DeleteMode(),
            IconParkIconKind.DeleteOne => new DeleteOne(),
            IconParkIconKind.DeleteThemes => new DeleteThemes(),
            IconParkIconKind.DeleteThree => new DeleteThree(),
            IconParkIconKind.DeleteTwo => new DeleteTwo(),
            IconParkIconKind.Delivery => new Delivery(),
            IconParkIconKind.Deposit => new Deposit(),
            IconParkIconKind.Descend => new Descend(),
            IconParkIconKind.DeskLamp => new DeskLamp(),
            IconParkIconKind.DeskLampOne => new DeskLampOne(),
            IconParkIconKind.Detection => new Detection(),
            IconParkIconKind.Devices => new Devices(),
            IconParkIconKind.Diamond => new Diamond(),
            IconParkIconKind.DiamondNecklace => new DiamondNecklace(),
            IconParkIconKind.DiamondOne => new DiamondOne(),
            IconParkIconKind.DiamondRing => new DiamondRing(),
            IconParkIconKind.DiamondThree => new DiamondThree(),
            IconParkIconKind.DiamondTwo => new DiamondTwo(),
            IconParkIconKind.Diamonds => new Diamonds(),
            IconParkIconKind.Dianziqian => new Dianziqian(),
            IconParkIconKind.DiapersOne => new DiapersOne(),
            IconParkIconKind.DifferenceSet => new DifferenceSet(),
            IconParkIconKind.DigitalWatches => new DigitalWatches(),
            IconParkIconKind.Direction => new Direction(),
            IconParkIconKind.DirectionAdjustment => new DirectionAdjustment(),
            IconParkIconKind.DirectionAdjustmentThree => new DirectionAdjustmentThree(),
            IconParkIconKind.DirectionAdjustmentTwo => new DirectionAdjustmentTwo(),
            IconParkIconKind.DisabaledWeb => new DisabaledWeb(),
            IconParkIconKind.DisabledComputer => new DisabledComputer(),
            IconParkIconKind.DisabledLaptop => new DisabledLaptop(),
            IconParkIconKind.DisabledPicture => new DisabledPicture(),
            IconParkIconKind.DisappointedFace => new DisappointedFace(),
            IconParkIconKind.DiscoveryIndex => new DiscoveryIndex(),
            IconParkIconKind.Disk => new Disk(),
            IconParkIconKind.DiskOne => new DiskOne(),
            IconParkIconKind.DiskTwo => new DiskTwo(),
            IconParkIconKind.Dislike => new Dislike(),
            IconParkIconKind.DislikeTwo => new DislikeTwo(),
            IconParkIconKind.Display => new Display(),
            IconParkIconKind.Distortion => new Distortion(),
            IconParkIconKind.DistraughtFace => new DistraughtFace(),
            IconParkIconKind.DistributeHorizontalSpacing => new DistributeHorizontalSpacing(),
            IconParkIconKind.DistributeHorizontally => new DistributeHorizontally(),
            IconParkIconKind.DistributeVerticalSpacing => new DistributeVerticalSpacing(),
            IconParkIconKind.DistributeVertically => new DistributeVertically(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk11(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.DividingLine: return typeof(DividingLine);
            case IconParkIconKind.DividingLineOne: return typeof(DividingLineOne);
            case IconParkIconKind.Diving: return typeof(Diving);
            case IconParkIconKind.DivingBottle: return typeof(DivingBottle);
            case IconParkIconKind.DivingSuit: return typeof(DivingSuit);
            case IconParkIconKind.Division: return typeof(Division);
            case IconParkIconKind.DizzyFace: return typeof(DizzyFace);
            case IconParkIconKind.DocAdd: return typeof(DocAdd);
            case IconParkIconKind.DocDetail: return typeof(DocDetail);
            case IconParkIconKind.DocFail: return typeof(DocFail);
            case IconParkIconKind.DocSearch: return typeof(DocSearch);
            case IconParkIconKind.DocSearchTwo: return typeof(DocSearchTwo);
            case IconParkIconKind.DocSuccess: return typeof(DocSuccess);
            case IconParkIconKind.DocumentFolder: return typeof(DocumentFolder);
            case IconParkIconKind.Dog: return typeof(Dog);
            case IconParkIconKind.DogZodiac: return typeof(DogZodiac);
            case IconParkIconKind.Dollar: return typeof(Dollar);
            case IconParkIconKind.Dolphin: return typeof(Dolphin);
            case IconParkIconKind.Dome: return typeof(Dome);
            case IconParkIconKind.DomeLight: return typeof(DomeLight);
            case IconParkIconKind.DoneAll: return typeof(DoneAll);
            case IconParkIconKind.Dongchedi: return typeof(Dongchedi);
            case IconParkIconKind.DoorHandle: return typeof(DoorHandle);
            case IconParkIconKind.Dot: return typeof(Dot);
            case IconParkIconKind.DoubleBed: return typeof(DoubleBed);
            case IconParkIconKind.DoubleDown: return typeof(DoubleDown);
            case IconParkIconKind.DoubleLeft: return typeof(DoubleLeft);
            case IconParkIconKind.DoubleRight: return typeof(DoubleRight);
            case IconParkIconKind.DoubleUp: return typeof(DoubleUp);
            case IconParkIconKind.Doughnut: return typeof(Doughnut);
            case IconParkIconKind.Down: return typeof(Down);
            case IconParkIconKind.DownC: return typeof(DownC);
            case IconParkIconKind.DownOne: return typeof(DownOne);
            case IconParkIconKind.DownPicture: return typeof(DownPicture);
            case IconParkIconKind.DownSmall: return typeof(DownSmall);
            case IconParkIconKind.DownSquare: return typeof(DownSquare);
            case IconParkIconKind.DownTwo: return typeof(DownTwo);
            case IconParkIconKind.Download: return typeof(Download);
            case IconParkIconKind.DownloadComputer: return typeof(DownloadComputer);
            case IconParkIconKind.DownloadFour: return typeof(DownloadFour);
            case IconParkIconKind.DownloadLaptop: return typeof(DownloadLaptop);
            case IconParkIconKind.DownloadOne: return typeof(DownloadOne);
            case IconParkIconKind.DownloadThree: return typeof(DownloadThree);
            case IconParkIconKind.DownloadTwo: return typeof(DownloadTwo);
            case IconParkIconKind.DownloadWeb: return typeof(DownloadWeb);
            case IconParkIconKind.Drag: return typeof(Drag);
            case IconParkIconKind.DragonZodiac: return typeof(DragonZodiac);
            case IconParkIconKind.Dribble: return typeof(Dribble);
            case IconParkIconKind.Drink: return typeof(Drink);
            case IconParkIconKind.Drone: return typeof(Drone);
            case IconParkIconKind.DroneOne: return typeof(DroneOne);
            case IconParkIconKind.DropDownList: return typeof(DropDownList);
            case IconParkIconKind.DropShadowDown: return typeof(DropShadowDown);
            case IconParkIconKind.DropShadowLeft: return typeof(DropShadowLeft);
            case IconParkIconKind.DropShadowRight: return typeof(DropShadowRight);
            case IconParkIconKind.DropShadowUp: return typeof(DropShadowUp);
            case IconParkIconKind.Dropbox: return typeof(Dropbox);
            case IconParkIconKind.Drumstick: return typeof(Drumstick);
            case IconParkIconKind.Dubai: return typeof(Dubai);
            case IconParkIconKind.Duck: return typeof(Duck);
            case IconParkIconKind.DumbbelLine: return typeof(DumbbelLine);
            case IconParkIconKind.Dumbbell: return typeof(Dumbbell);
            case IconParkIconKind.Dvi: return typeof(Dvi);
            case IconParkIconKind.Eagle: return typeof(Eagle);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk11(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.DividingLine => new DividingLine(),
            IconParkIconKind.DividingLineOne => new DividingLineOne(),
            IconParkIconKind.Diving => new Diving(),
            IconParkIconKind.DivingBottle => new DivingBottle(),
            IconParkIconKind.DivingSuit => new DivingSuit(),
            IconParkIconKind.Division => new Division(),
            IconParkIconKind.DizzyFace => new DizzyFace(),
            IconParkIconKind.DocAdd => new DocAdd(),
            IconParkIconKind.DocDetail => new DocDetail(),
            IconParkIconKind.DocFail => new DocFail(),
            IconParkIconKind.DocSearch => new DocSearch(),
            IconParkIconKind.DocSearchTwo => new DocSearchTwo(),
            IconParkIconKind.DocSuccess => new DocSuccess(),
            IconParkIconKind.DocumentFolder => new DocumentFolder(),
            IconParkIconKind.Dog => new Dog(),
            IconParkIconKind.DogZodiac => new DogZodiac(),
            IconParkIconKind.Dollar => new Dollar(),
            IconParkIconKind.Dolphin => new Dolphin(),
            IconParkIconKind.Dome => new Dome(),
            IconParkIconKind.DomeLight => new DomeLight(),
            IconParkIconKind.DoneAll => new DoneAll(),
            IconParkIconKind.Dongchedi => new Dongchedi(),
            IconParkIconKind.DoorHandle => new DoorHandle(),
            IconParkIconKind.Dot => new Dot(),
            IconParkIconKind.DoubleBed => new DoubleBed(),
            IconParkIconKind.DoubleDown => new DoubleDown(),
            IconParkIconKind.DoubleLeft => new DoubleLeft(),
            IconParkIconKind.DoubleRight => new DoubleRight(),
            IconParkIconKind.DoubleUp => new DoubleUp(),
            IconParkIconKind.Doughnut => new Doughnut(),
            IconParkIconKind.Down => new Down(),
            IconParkIconKind.DownC => new DownC(),
            IconParkIconKind.DownOne => new DownOne(),
            IconParkIconKind.DownPicture => new DownPicture(),
            IconParkIconKind.DownSmall => new DownSmall(),
            IconParkIconKind.DownSquare => new DownSquare(),
            IconParkIconKind.DownTwo => new DownTwo(),
            IconParkIconKind.Download => new Download(),
            IconParkIconKind.DownloadComputer => new DownloadComputer(),
            IconParkIconKind.DownloadFour => new DownloadFour(),
            IconParkIconKind.DownloadLaptop => new DownloadLaptop(),
            IconParkIconKind.DownloadOne => new DownloadOne(),
            IconParkIconKind.DownloadThree => new DownloadThree(),
            IconParkIconKind.DownloadTwo => new DownloadTwo(),
            IconParkIconKind.DownloadWeb => new DownloadWeb(),
            IconParkIconKind.Drag => new Drag(),
            IconParkIconKind.DragonZodiac => new DragonZodiac(),
            IconParkIconKind.Dribble => new Dribble(),
            IconParkIconKind.Drink => new Drink(),
            IconParkIconKind.Drone => new Drone(),
            IconParkIconKind.DroneOne => new DroneOne(),
            IconParkIconKind.DropDownList => new DropDownList(),
            IconParkIconKind.DropShadowDown => new DropShadowDown(),
            IconParkIconKind.DropShadowLeft => new DropShadowLeft(),
            IconParkIconKind.DropShadowRight => new DropShadowRight(),
            IconParkIconKind.DropShadowUp => new DropShadowUp(),
            IconParkIconKind.Dropbox => new Dropbox(),
            IconParkIconKind.Drumstick => new Drumstick(),
            IconParkIconKind.Dubai => new Dubai(),
            IconParkIconKind.Duck => new Duck(),
            IconParkIconKind.DumbbelLine => new DumbbelLine(),
            IconParkIconKind.Dumbbell => new Dumbbell(),
            IconParkIconKind.Dvi => new Dvi(),
            IconParkIconKind.Eagle => new Eagle(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk12(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Earth: return typeof(Earth);
            case IconParkIconKind.Easy: return typeof(Easy);
            case IconParkIconKind.Ecg: return typeof(Ecg);
            case IconParkIconKind.Edit: return typeof(Edit);
            case IconParkIconKind.EditMovie: return typeof(EditMovie);
            case IconParkIconKind.EditName: return typeof(EditName);
            case IconParkIconKind.EditOne: return typeof(EditOne);
            case IconParkIconKind.EditTwo: return typeof(EditTwo);
            case IconParkIconKind.Editing: return typeof(Editing);
            case IconParkIconKind.Editor: return typeof(Editor);
            case IconParkIconKind.Eeg: return typeof(Eeg);
            case IconParkIconKind.Effects: return typeof(Effects);
            case IconParkIconKind.EfferentFour: return typeof(EfferentFour);
            case IconParkIconKind.EfferentThree: return typeof(EfferentThree);
            case IconParkIconKind.Egg: return typeof(Egg);
            case IconParkIconKind.EggOne: return typeof(EggOne);
            case IconParkIconKind.Eggplant: return typeof(Eggplant);
            case IconParkIconKind.EiffelTower: return typeof(EiffelTower);
            case IconParkIconKind.EightKey: return typeof(EightKey);
            case IconParkIconKind.ElectricDrill: return typeof(ElectricDrill);
            case IconParkIconKind.ElectricIron: return typeof(ElectricIron);
            case IconParkIconKind.ElectricWave: return typeof(ElectricWave);
            case IconParkIconKind.Electrocardiogram: return typeof(Electrocardiogram);
            case IconParkIconKind.ElectronicDoorLock: return typeof(ElectronicDoorLock);
            case IconParkIconKind.ElectronicLocksClose: return typeof(ElectronicLocksClose);
            case IconParkIconKind.ElectronicLocksOpen: return typeof(ElectronicLocksOpen);
            case IconParkIconKind.ElectronicPen: return typeof(ElectronicPen);
            case IconParkIconKind.Elephant: return typeof(Elephant);
            case IconParkIconKind.Elevator: return typeof(Elevator);
            case IconParkIconKind.EmailBlock: return typeof(EmailBlock);
            case IconParkIconKind.EmailDelect: return typeof(EmailDelect);
            case IconParkIconKind.EmailDown: return typeof(EmailDown);
            case IconParkIconKind.EmailFail: return typeof(EmailFail);
            case IconParkIconKind.EmailLock: return typeof(EmailLock);
            case IconParkIconKind.EmailPush: return typeof(EmailPush);
            case IconParkIconKind.EmailSearch: return typeof(EmailSearch);
            case IconParkIconKind.EmailSecurity: return typeof(EmailSecurity);
            case IconParkIconKind.EmailSuccessfully: return typeof(EmailSuccessfully);
            case IconParkIconKind.EmotionHappy: return typeof(EmotionHappy);
            case IconParkIconKind.EmotionUnhappy: return typeof(EmotionUnhappy);
            case IconParkIconKind.Empty: return typeof(Empty);
            case IconParkIconKind.EndTimeSort: return typeof(EndTimeSort);
            case IconParkIconKind.Endless: return typeof(Endless);
            case IconParkIconKind.Endocrine: return typeof(Endocrine);
            case IconParkIconKind.EndpointDisplacement: return typeof(EndpointDisplacement);
            case IconParkIconKind.EndpointFlat: return typeof(EndpointFlat);
            case IconParkIconKind.EndpointRound: return typeof(EndpointRound);
            case IconParkIconKind.EndpointSquare: return typeof(EndpointSquare);
            case IconParkIconKind.EnergySocket: return typeof(EnergySocket);
            case IconParkIconKind.EngineeringBrand: return typeof(EngineeringBrand);
            case IconParkIconKind.EngineeringVehicle: return typeof(EngineeringVehicle);
            case IconParkIconKind.English: return typeof(English);
            case IconParkIconKind.EnglishMustache: return typeof(EnglishMustache);
            case IconParkIconKind.Enquire: return typeof(Enquire);
            case IconParkIconKind.EnterKey: return typeof(EnterKey);
            case IconParkIconKind.EnterKeyOne: return typeof(EnterKeyOne);
            case IconParkIconKind.EnterTheKeyboard: return typeof(EnterTheKeyboard);
            case IconParkIconKind.Entertainment: return typeof(Entertainment);
            case IconParkIconKind.Envelope: return typeof(Envelope);
            case IconParkIconKind.EnvelopeOne: return typeof(EnvelopeOne);
            case IconParkIconKind.EqualRatio: return typeof(EqualRatio);
            case IconParkIconKind.Equalizer: return typeof(Equalizer);
            case IconParkIconKind.Erase: return typeof(Erase);
            case IconParkIconKind.Error: return typeof(Error);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk12(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Earth => new Earth(),
            IconParkIconKind.Easy => new Easy(),
            IconParkIconKind.Ecg => new Ecg(),
            IconParkIconKind.Edit => new Edit(),
            IconParkIconKind.EditMovie => new EditMovie(),
            IconParkIconKind.EditName => new EditName(),
            IconParkIconKind.EditOne => new EditOne(),
            IconParkIconKind.EditTwo => new EditTwo(),
            IconParkIconKind.Editing => new Editing(),
            IconParkIconKind.Editor => new Editor(),
            IconParkIconKind.Eeg => new Eeg(),
            IconParkIconKind.Effects => new Effects(),
            IconParkIconKind.EfferentFour => new EfferentFour(),
            IconParkIconKind.EfferentThree => new EfferentThree(),
            IconParkIconKind.Egg => new Egg(),
            IconParkIconKind.EggOne => new EggOne(),
            IconParkIconKind.Eggplant => new Eggplant(),
            IconParkIconKind.EiffelTower => new EiffelTower(),
            IconParkIconKind.EightKey => new EightKey(),
            IconParkIconKind.ElectricDrill => new ElectricDrill(),
            IconParkIconKind.ElectricIron => new ElectricIron(),
            IconParkIconKind.ElectricWave => new ElectricWave(),
            IconParkIconKind.Electrocardiogram => new Electrocardiogram(),
            IconParkIconKind.ElectronicDoorLock => new ElectronicDoorLock(),
            IconParkIconKind.ElectronicLocksClose => new ElectronicLocksClose(),
            IconParkIconKind.ElectronicLocksOpen => new ElectronicLocksOpen(),
            IconParkIconKind.ElectronicPen => new ElectronicPen(),
            IconParkIconKind.Elephant => new Elephant(),
            IconParkIconKind.Elevator => new Elevator(),
            IconParkIconKind.EmailBlock => new EmailBlock(),
            IconParkIconKind.EmailDelect => new EmailDelect(),
            IconParkIconKind.EmailDown => new EmailDown(),
            IconParkIconKind.EmailFail => new EmailFail(),
            IconParkIconKind.EmailLock => new EmailLock(),
            IconParkIconKind.EmailPush => new EmailPush(),
            IconParkIconKind.EmailSearch => new EmailSearch(),
            IconParkIconKind.EmailSecurity => new EmailSecurity(),
            IconParkIconKind.EmailSuccessfully => new EmailSuccessfully(),
            IconParkIconKind.EmotionHappy => new EmotionHappy(),
            IconParkIconKind.EmotionUnhappy => new EmotionUnhappy(),
            IconParkIconKind.Empty => new Empty(),
            IconParkIconKind.EndTimeSort => new EndTimeSort(),
            IconParkIconKind.Endless => new Endless(),
            IconParkIconKind.Endocrine => new Endocrine(),
            IconParkIconKind.EndpointDisplacement => new EndpointDisplacement(),
            IconParkIconKind.EndpointFlat => new EndpointFlat(),
            IconParkIconKind.EndpointRound => new EndpointRound(),
            IconParkIconKind.EndpointSquare => new EndpointSquare(),
            IconParkIconKind.EnergySocket => new EnergySocket(),
            IconParkIconKind.EngineeringBrand => new EngineeringBrand(),
            IconParkIconKind.EngineeringVehicle => new EngineeringVehicle(),
            IconParkIconKind.English => new English(),
            IconParkIconKind.EnglishMustache => new EnglishMustache(),
            IconParkIconKind.Enquire => new Enquire(),
            IconParkIconKind.EnterKey => new EnterKey(),
            IconParkIconKind.EnterKeyOne => new EnterKeyOne(),
            IconParkIconKind.EnterTheKeyboard => new EnterTheKeyboard(),
            IconParkIconKind.Entertainment => new Entertainment(),
            IconParkIconKind.Envelope => new Envelope(),
            IconParkIconKind.EnvelopeOne => new EnvelopeOne(),
            IconParkIconKind.EqualRatio => new EqualRatio(),
            IconParkIconKind.Equalizer => new Equalizer(),
            IconParkIconKind.Erase => new Erase(),
            IconParkIconKind.Error => new Error(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk13(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.ErrorComputer: return typeof(ErrorComputer);
            case IconParkIconKind.ErrorPicture: return typeof(ErrorPicture);
            case IconParkIconKind.ErrorPrompt: return typeof(ErrorPrompt);
            case IconParkIconKind.Escalators: return typeof(Escalators);
            case IconParkIconKind.EthernetOff: return typeof(EthernetOff);
            case IconParkIconKind.EthernetOn: return typeof(EthernetOn);
            case IconParkIconKind.EveryUser: return typeof(EveryUser);
            case IconParkIconKind.Excel: return typeof(Excel);
            case IconParkIconKind.ExcelOne: return typeof(ExcelOne);
            case IconParkIconKind.Exchange: return typeof(Exchange);
            case IconParkIconKind.ExchangeFour: return typeof(ExchangeFour);
            case IconParkIconKind.ExchangeOne: return typeof(ExchangeOne);
            case IconParkIconKind.ExchangeThree: return typeof(ExchangeThree);
            case IconParkIconKind.ExchangeTwo: return typeof(ExchangeTwo);
            case IconParkIconKind.ExcludeSelection: return typeof(ExcludeSelection);
            case IconParkIconKind.ExclusiveGateway: return typeof(ExclusiveGateway);
            case IconParkIconKind.ExpandDown: return typeof(ExpandDown);
            case IconParkIconKind.ExpandDownOne: return typeof(ExpandDownOne);
            case IconParkIconKind.ExpandLeft: return typeof(ExpandLeft);
            case IconParkIconKind.ExpandLeftAndRight: return typeof(ExpandLeftAndRight);
            case IconParkIconKind.ExpandRight: return typeof(ExpandRight);
            case IconParkIconKind.ExpandTextInput: return typeof(ExpandTextInput);
            case IconParkIconKind.ExpandUp: return typeof(ExpandUp);
            case IconParkIconKind.Expenses: return typeof(Expenses);
            case IconParkIconKind.ExpensesOne: return typeof(ExpensesOne);
            case IconParkIconKind.Experiment: return typeof(Experiment);
            case IconParkIconKind.ExperimentOne: return typeof(ExperimentOne);
            case IconParkIconKind.Export: return typeof(Export);
            case IconParkIconKind.ExpressDelivery: return typeof(ExpressDelivery);
            case IconParkIconKind.ExpressionlessFace: return typeof(ExpressionlessFace);
            case IconParkIconKind.Extend: return typeof(Extend);
            case IconParkIconKind.ExternalTransmission: return typeof(ExternalTransmission);
            case IconParkIconKind.Eyebrow: return typeof(Eyebrow);
            case IconParkIconKind.Eyes: return typeof(Eyes);
            case IconParkIconKind.FEightKey: return typeof(FEightKey);
            case IconParkIconKind.FFiveKey: return typeof(FFiveKey);
            case IconParkIconKind.FFourKey: return typeof(FFourKey);
            case IconParkIconKind.FNKey: return typeof(FNKey);
            case IconParkIconKind.FNineKey: return typeof(FNineKey);
            case IconParkIconKind.FOneKey: return typeof(FOneKey);
            case IconParkIconKind.FSevenKey: return typeof(FSevenKey);
            case IconParkIconKind.FSixKey: return typeof(FSixKey);
            case IconParkIconKind.FThreeKey: return typeof(FThreeKey);
            case IconParkIconKind.FTwoKey: return typeof(FTwoKey);
            case IconParkIconKind.FZeroKey: return typeof(FZeroKey);
            case IconParkIconKind.FacePowder: return typeof(FacePowder);
            case IconParkIconKind.FaceRecognition: return typeof(FaceRecognition);
            case IconParkIconKind.FaceWithSmilingOpenEyes: return typeof(FaceWithSmilingOpenEyes);
            case IconParkIconKind.FaceWithoutMouth: return typeof(FaceWithoutMouth);
            case IconParkIconKind.Facebook: return typeof(Facebook);
            case IconParkIconKind.FacebookOne: return typeof(FacebookOne);
            case IconParkIconKind.Facetime: return typeof(Facetime);
            case IconParkIconKind.Faceu: return typeof(Faceu);
            case IconParkIconKind.FacialCleanser: return typeof(FacialCleanser);
            case IconParkIconKind.FacialMask: return typeof(FacialMask);
            case IconParkIconKind.FactoryBuilding: return typeof(FactoryBuilding);
            case IconParkIconKind.FailPicture: return typeof(FailPicture);
            case IconParkIconKind.Family: return typeof(Family);
            case IconParkIconKind.Fan: return typeof(Fan);
            case IconParkIconKind.Fanqiexiaoshuo: return typeof(Fanqiexiaoshuo);
            case IconParkIconKind.Feelgood: return typeof(Feelgood);
            case IconParkIconKind.FeelgoodOne: return typeof(FeelgoodOne);
            case IconParkIconKind.Feiyu: return typeof(Feiyu);
            case IconParkIconKind.Female: return typeof(Female);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk13(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.ErrorComputer => new ErrorComputer(),
            IconParkIconKind.ErrorPicture => new ErrorPicture(),
            IconParkIconKind.ErrorPrompt => new ErrorPrompt(),
            IconParkIconKind.Escalators => new Escalators(),
            IconParkIconKind.EthernetOff => new EthernetOff(),
            IconParkIconKind.EthernetOn => new EthernetOn(),
            IconParkIconKind.EveryUser => new EveryUser(),
            IconParkIconKind.Excel => new Excel(),
            IconParkIconKind.ExcelOne => new ExcelOne(),
            IconParkIconKind.Exchange => new Exchange(),
            IconParkIconKind.ExchangeFour => new ExchangeFour(),
            IconParkIconKind.ExchangeOne => new ExchangeOne(),
            IconParkIconKind.ExchangeThree => new ExchangeThree(),
            IconParkIconKind.ExchangeTwo => new ExchangeTwo(),
            IconParkIconKind.ExcludeSelection => new ExcludeSelection(),
            IconParkIconKind.ExclusiveGateway => new ExclusiveGateway(),
            IconParkIconKind.ExpandDown => new ExpandDown(),
            IconParkIconKind.ExpandDownOne => new ExpandDownOne(),
            IconParkIconKind.ExpandLeft => new ExpandLeft(),
            IconParkIconKind.ExpandLeftAndRight => new ExpandLeftAndRight(),
            IconParkIconKind.ExpandRight => new ExpandRight(),
            IconParkIconKind.ExpandTextInput => new ExpandTextInput(),
            IconParkIconKind.ExpandUp => new ExpandUp(),
            IconParkIconKind.Expenses => new Expenses(),
            IconParkIconKind.ExpensesOne => new ExpensesOne(),
            IconParkIconKind.Experiment => new Experiment(),
            IconParkIconKind.ExperimentOne => new ExperimentOne(),
            IconParkIconKind.Export => new Export(),
            IconParkIconKind.ExpressDelivery => new ExpressDelivery(),
            IconParkIconKind.ExpressionlessFace => new ExpressionlessFace(),
            IconParkIconKind.Extend => new Extend(),
            IconParkIconKind.ExternalTransmission => new ExternalTransmission(),
            IconParkIconKind.Eyebrow => new Eyebrow(),
            IconParkIconKind.Eyes => new Eyes(),
            IconParkIconKind.FEightKey => new FEightKey(),
            IconParkIconKind.FFiveKey => new FFiveKey(),
            IconParkIconKind.FFourKey => new FFourKey(),
            IconParkIconKind.FNKey => new FNKey(),
            IconParkIconKind.FNineKey => new FNineKey(),
            IconParkIconKind.FOneKey => new FOneKey(),
            IconParkIconKind.FSevenKey => new FSevenKey(),
            IconParkIconKind.FSixKey => new FSixKey(),
            IconParkIconKind.FThreeKey => new FThreeKey(),
            IconParkIconKind.FTwoKey => new FTwoKey(),
            IconParkIconKind.FZeroKey => new FZeroKey(),
            IconParkIconKind.FacePowder => new FacePowder(),
            IconParkIconKind.FaceRecognition => new FaceRecognition(),
            IconParkIconKind.FaceWithSmilingOpenEyes => new FaceWithSmilingOpenEyes(),
            IconParkIconKind.FaceWithoutMouth => new FaceWithoutMouth(),
            IconParkIconKind.Facebook => new Facebook(),
            IconParkIconKind.FacebookOne => new FacebookOne(),
            IconParkIconKind.Facetime => new Facetime(),
            IconParkIconKind.Faceu => new Faceu(),
            IconParkIconKind.FacialCleanser => new FacialCleanser(),
            IconParkIconKind.FacialMask => new FacialMask(),
            IconParkIconKind.FactoryBuilding => new FactoryBuilding(),
            IconParkIconKind.FailPicture => new FailPicture(),
            IconParkIconKind.Family => new Family(),
            IconParkIconKind.Fan => new Fan(),
            IconParkIconKind.Fanqiexiaoshuo => new Fanqiexiaoshuo(),
            IconParkIconKind.Feelgood => new Feelgood(),
            IconParkIconKind.FeelgoodOne => new FeelgoodOne(),
            IconParkIconKind.Feiyu => new Feiyu(),
            IconParkIconKind.Female => new Female(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk14(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.FenceOne: return typeof(FenceOne);
            case IconParkIconKind.FenceTwo: return typeof(FenceTwo);
            case IconParkIconKind.FerrisWheel: return typeof(FerrisWheel);
            case IconParkIconKind.Figma: return typeof(Figma);
            case IconParkIconKind.FigmaComponent: return typeof(FigmaComponent);
            case IconParkIconKind.FigmaFlattenSelection: return typeof(FigmaFlattenSelection);
            case IconParkIconKind.FigmaMask: return typeof(FigmaMask);
            case IconParkIconKind.FigmaResetInstance: return typeof(FigmaResetInstance);
            case IconParkIconKind.FileAddition: return typeof(FileAddition);
            case IconParkIconKind.FileAdditionOne: return typeof(FileAdditionOne);
            case IconParkIconKind.FileCabinet: return typeof(FileCabinet);
            case IconParkIconKind.FileCode: return typeof(FileCode);
            case IconParkIconKind.FileCodeOne: return typeof(FileCodeOne);
            case IconParkIconKind.FileCollection: return typeof(FileCollection);
            case IconParkIconKind.FileCollectionOne: return typeof(FileCollectionOne);
            case IconParkIconKind.FileConversion: return typeof(FileConversion);
            case IconParkIconKind.FileConversionOne: return typeof(FileConversionOne);
            case IconParkIconKind.FileDate: return typeof(FileDate);
            case IconParkIconKind.FileDateOne: return typeof(FileDateOne);
            case IconParkIconKind.FileDisplay: return typeof(FileDisplay);
            case IconParkIconKind.FileDisplayOne: return typeof(FileDisplayOne);
            case IconParkIconKind.FileDoc: return typeof(FileDoc);
            case IconParkIconKind.FileEditing: return typeof(FileEditing);
            case IconParkIconKind.FileEditingOne: return typeof(FileEditingOne);
            case IconParkIconKind.FileExcel: return typeof(FileExcel);
            case IconParkIconKind.FileFailed: return typeof(FileFailed);
            case IconParkIconKind.FileFailedOne: return typeof(FileFailedOne);
            case IconParkIconKind.FileFocus: return typeof(FileFocus);
            case IconParkIconKind.FileFocusOne: return typeof(FileFocusOne);
            case IconParkIconKind.FileGif: return typeof(FileGif);
            case IconParkIconKind.FileHash: return typeof(FileHash);
            case IconParkIconKind.FileHashOne: return typeof(FileHashOne);
            case IconParkIconKind.FileHiding: return typeof(FileHiding);
            case IconParkIconKind.FileHidingOne: return typeof(FileHidingOne);
            case IconParkIconKind.FileJpg: return typeof(FileJpg);
            case IconParkIconKind.FileLock: return typeof(FileLock);
            case IconParkIconKind.FileLockOne: return typeof(FileLockOne);
            case IconParkIconKind.FileMusic: return typeof(FileMusic);
            case IconParkIconKind.FileMusicOne: return typeof(FileMusicOne);
            case IconParkIconKind.FilePdf: return typeof(FilePdf);
            case IconParkIconKind.FilePdfOne: return typeof(FilePdfOne);
            case IconParkIconKind.FilePpt: return typeof(FilePpt);
            case IconParkIconKind.FileProtection: return typeof(FileProtection);
            case IconParkIconKind.FileProtectionOne: return typeof(FileProtectionOne);
            case IconParkIconKind.FileQuality: return typeof(FileQuality);
            case IconParkIconKind.FileQualityOne: return typeof(FileQualityOne);
            case IconParkIconKind.FileQuestion: return typeof(FileQuestion);
            case IconParkIconKind.FileRemoval: return typeof(FileRemoval);
            case IconParkIconKind.FileRemovalOne: return typeof(FileRemovalOne);
            case IconParkIconKind.FileSearch: return typeof(FileSearch);
            case IconParkIconKind.FileSearchOne: return typeof(FileSearchOne);
            case IconParkIconKind.FileSearchTwo: return typeof(FileSearchTwo);
            case IconParkIconKind.FileSettings: return typeof(FileSettings);
            case IconParkIconKind.FileSettingsOne: return typeof(FileSettingsOne);
            case IconParkIconKind.FileStaff: return typeof(FileStaff);
            case IconParkIconKind.FileStaffOne: return typeof(FileStaffOne);
            case IconParkIconKind.FileSuccess: return typeof(FileSuccess);
            case IconParkIconKind.FileSuccessOne: return typeof(FileSuccessOne);
            case IconParkIconKind.FileText: return typeof(FileText);
            case IconParkIconKind.FileTextOne: return typeof(FileTextOne);
            case IconParkIconKind.FileTips: return typeof(FileTips);
            case IconParkIconKind.FileTipsOne: return typeof(FileTipsOne);
            case IconParkIconKind.FileTxt: return typeof(FileTxt);
            case IconParkIconKind.FileTxtOne: return typeof(FileTxtOne);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk14(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.FenceOne => new FenceOne(),
            IconParkIconKind.FenceTwo => new FenceTwo(),
            IconParkIconKind.FerrisWheel => new FerrisWheel(),
            IconParkIconKind.Figma => new Figma(),
            IconParkIconKind.FigmaComponent => new FigmaComponent(),
            IconParkIconKind.FigmaFlattenSelection => new FigmaFlattenSelection(),
            IconParkIconKind.FigmaMask => new FigmaMask(),
            IconParkIconKind.FigmaResetInstance => new FigmaResetInstance(),
            IconParkIconKind.FileAddition => new FileAddition(),
            IconParkIconKind.FileAdditionOne => new FileAdditionOne(),
            IconParkIconKind.FileCabinet => new FileCabinet(),
            IconParkIconKind.FileCode => new FileCode(),
            IconParkIconKind.FileCodeOne => new FileCodeOne(),
            IconParkIconKind.FileCollection => new FileCollection(),
            IconParkIconKind.FileCollectionOne => new FileCollectionOne(),
            IconParkIconKind.FileConversion => new FileConversion(),
            IconParkIconKind.FileConversionOne => new FileConversionOne(),
            IconParkIconKind.FileDate => new FileDate(),
            IconParkIconKind.FileDateOne => new FileDateOne(),
            IconParkIconKind.FileDisplay => new FileDisplay(),
            IconParkIconKind.FileDisplayOne => new FileDisplayOne(),
            IconParkIconKind.FileDoc => new FileDoc(),
            IconParkIconKind.FileEditing => new FileEditing(),
            IconParkIconKind.FileEditingOne => new FileEditingOne(),
            IconParkIconKind.FileExcel => new FileExcel(),
            IconParkIconKind.FileFailed => new FileFailed(),
            IconParkIconKind.FileFailedOne => new FileFailedOne(),
            IconParkIconKind.FileFocus => new FileFocus(),
            IconParkIconKind.FileFocusOne => new FileFocusOne(),
            IconParkIconKind.FileGif => new FileGif(),
            IconParkIconKind.FileHash => new FileHash(),
            IconParkIconKind.FileHashOne => new FileHashOne(),
            IconParkIconKind.FileHiding => new FileHiding(),
            IconParkIconKind.FileHidingOne => new FileHidingOne(),
            IconParkIconKind.FileJpg => new FileJpg(),
            IconParkIconKind.FileLock => new FileLock(),
            IconParkIconKind.FileLockOne => new FileLockOne(),
            IconParkIconKind.FileMusic => new FileMusic(),
            IconParkIconKind.FileMusicOne => new FileMusicOne(),
            IconParkIconKind.FilePdf => new FilePdf(),
            IconParkIconKind.FilePdfOne => new FilePdfOne(),
            IconParkIconKind.FilePpt => new FilePpt(),
            IconParkIconKind.FileProtection => new FileProtection(),
            IconParkIconKind.FileProtectionOne => new FileProtectionOne(),
            IconParkIconKind.FileQuality => new FileQuality(),
            IconParkIconKind.FileQualityOne => new FileQualityOne(),
            IconParkIconKind.FileQuestion => new FileQuestion(),
            IconParkIconKind.FileRemoval => new FileRemoval(),
            IconParkIconKind.FileRemovalOne => new FileRemovalOne(),
            IconParkIconKind.FileSearch => new FileSearch(),
            IconParkIconKind.FileSearchOne => new FileSearchOne(),
            IconParkIconKind.FileSearchTwo => new FileSearchTwo(),
            IconParkIconKind.FileSettings => new FileSettings(),
            IconParkIconKind.FileSettingsOne => new FileSettingsOne(),
            IconParkIconKind.FileStaff => new FileStaff(),
            IconParkIconKind.FileStaffOne => new FileStaffOne(),
            IconParkIconKind.FileSuccess => new FileSuccess(),
            IconParkIconKind.FileSuccessOne => new FileSuccessOne(),
            IconParkIconKind.FileText => new FileText(),
            IconParkIconKind.FileTextOne => new FileTextOne(),
            IconParkIconKind.FileTips => new FileTips(),
            IconParkIconKind.FileTipsOne => new FileTipsOne(),
            IconParkIconKind.FileTxt => new FileTxt(),
            IconParkIconKind.FileTxtOne => new FileTxtOne(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk15(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.FileWithdrawal: return typeof(FileWithdrawal);
            case IconParkIconKind.FileWithdrawalOne: return typeof(FileWithdrawalOne);
            case IconParkIconKind.FileWord: return typeof(FileWord);
            case IconParkIconKind.FileZip: return typeof(FileZip);
            case IconParkIconKind.Fill: return typeof(Fill);
            case IconParkIconKind.Film: return typeof(Film);
            case IconParkIconKind.Filter: return typeof(Filter);
            case IconParkIconKind.FilterOne: return typeof(FilterOne);
            case IconParkIconKind.Finance: return typeof(Finance);
            case IconParkIconKind.Financing: return typeof(Financing);
            case IconParkIconKind.FinancingOne: return typeof(FinancingOne);
            case IconParkIconKind.FinancingTwo: return typeof(FinancingTwo);
            case IconParkIconKind.Find: return typeof(Find);
            case IconParkIconKind.FindOne: return typeof(FindOne);
            case IconParkIconKind.Fingernail: return typeof(Fingernail);
            case IconParkIconKind.Fingerprint: return typeof(Fingerprint);
            case IconParkIconKind.FingerprintThree: return typeof(FingerprintThree);
            case IconParkIconKind.FingerprintTwo: return typeof(FingerprintTwo);
            case IconParkIconKind.Fire: return typeof(Fire);
            case IconParkIconKind.FireExtinguisher: return typeof(FireExtinguisher);
            case IconParkIconKind.FireExtinguisherOne: return typeof(FireExtinguisherOne);
            case IconParkIconKind.FireTwo: return typeof(FireTwo);
            case IconParkIconKind.Fireworks: return typeof(Fireworks);
            case IconParkIconKind.First: return typeof(First);
            case IconParkIconKind.FirstAidKit: return typeof(FirstAidKit);
            case IconParkIconKind.Fish: return typeof(Fish);
            case IconParkIconKind.FishOne: return typeof(FishOne);
            case IconParkIconKind.Fishing: return typeof(Fishing);
            case IconParkIconKind.Fist: return typeof(Fist);
            case IconParkIconKind.Fitness: return typeof(Fitness);
            case IconParkIconKind.Five: return typeof(Five);
            case IconParkIconKind.FiveEllipses: return typeof(FiveEllipses);
            case IconParkIconKind.FiveFive: return typeof(FiveFive);
            case IconParkIconKind.FiveKey: return typeof(FiveKey);
            case IconParkIconKind.FiveStarBadge: return typeof(FiveStarBadge);
            case IconParkIconKind.Flag: return typeof(Flag);
            case IconParkIconKind.FlashPayment: return typeof(FlashPayment);
            case IconParkIconKind.Flashlamp: return typeof(Flashlamp);
            case IconParkIconKind.Flashlight: return typeof(Flashlight);
            case IconParkIconKind.Flask: return typeof(Flask);
            case IconParkIconKind.FlightAirflow: return typeof(FlightAirflow);
            case IconParkIconKind.FlightSafety: return typeof(FlightSafety);
            case IconParkIconKind.FlipCamera: return typeof(FlipCamera);
            case IconParkIconKind.FlipHorizontally: return typeof(FlipHorizontally);
            case IconParkIconKind.FlipVertically: return typeof(FlipVertically);
            case IconParkIconKind.Flirt: return typeof(Flirt);
            case IconParkIconKind.Float: return typeof(Float);
            case IconParkIconKind.FloorTile: return typeof(FloorTile);
            case IconParkIconKind.Fm: return typeof(Fm);
            case IconParkIconKind.Focus: return typeof(Focus);
            case IconParkIconKind.FocusOne: return typeof(FocusOne);
            case IconParkIconKind.Fog: return typeof(Fog);
            case IconParkIconKind.FoldUpOne: return typeof(FoldUpOne);
            case IconParkIconKind.Folder: return typeof(Folder);
            case IconParkIconKind.FolderBlock: return typeof(FolderBlock);
            case IconParkIconKind.FolderBlockOne: return typeof(FolderBlockOne);
            case IconParkIconKind.FolderClose: return typeof(FolderClose);
            case IconParkIconKind.FolderCode: return typeof(FolderCode);
            case IconParkIconKind.FolderCodeOne: return typeof(FolderCodeOne);
            case IconParkIconKind.FolderConversion: return typeof(FolderConversion);
            case IconParkIconKind.FolderConversionOne: return typeof(FolderConversionOne);
            case IconParkIconKind.FolderDownload: return typeof(FolderDownload);
            case IconParkIconKind.FolderFailed: return typeof(FolderFailed);
            case IconParkIconKind.FolderFailedOne: return typeof(FolderFailedOne);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk15(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.FileWithdrawal => new FileWithdrawal(),
            IconParkIconKind.FileWithdrawalOne => new FileWithdrawalOne(),
            IconParkIconKind.FileWord => new FileWord(),
            IconParkIconKind.FileZip => new FileZip(),
            IconParkIconKind.Fill => new Fill(),
            IconParkIconKind.Film => new Film(),
            IconParkIconKind.Filter => new Filter(),
            IconParkIconKind.FilterOne => new FilterOne(),
            IconParkIconKind.Finance => new Finance(),
            IconParkIconKind.Financing => new Financing(),
            IconParkIconKind.FinancingOne => new FinancingOne(),
            IconParkIconKind.FinancingTwo => new FinancingTwo(),
            IconParkIconKind.Find => new Find(),
            IconParkIconKind.FindOne => new FindOne(),
            IconParkIconKind.Fingernail => new Fingernail(),
            IconParkIconKind.Fingerprint => new Fingerprint(),
            IconParkIconKind.FingerprintThree => new FingerprintThree(),
            IconParkIconKind.FingerprintTwo => new FingerprintTwo(),
            IconParkIconKind.Fire => new Fire(),
            IconParkIconKind.FireExtinguisher => new FireExtinguisher(),
            IconParkIconKind.FireExtinguisherOne => new FireExtinguisherOne(),
            IconParkIconKind.FireTwo => new FireTwo(),
            IconParkIconKind.Fireworks => new Fireworks(),
            IconParkIconKind.First => new First(),
            IconParkIconKind.FirstAidKit => new FirstAidKit(),
            IconParkIconKind.Fish => new Fish(),
            IconParkIconKind.FishOne => new FishOne(),
            IconParkIconKind.Fishing => new Fishing(),
            IconParkIconKind.Fist => new Fist(),
            IconParkIconKind.Fitness => new Fitness(),
            IconParkIconKind.Five => new Five(),
            IconParkIconKind.FiveEllipses => new FiveEllipses(),
            IconParkIconKind.FiveFive => new FiveFive(),
            IconParkIconKind.FiveKey => new FiveKey(),
            IconParkIconKind.FiveStarBadge => new FiveStarBadge(),
            IconParkIconKind.Flag => new Flag(),
            IconParkIconKind.FlashPayment => new FlashPayment(),
            IconParkIconKind.Flashlamp => new Flashlamp(),
            IconParkIconKind.Flashlight => new Flashlight(),
            IconParkIconKind.Flask => new Flask(),
            IconParkIconKind.FlightAirflow => new FlightAirflow(),
            IconParkIconKind.FlightSafety => new FlightSafety(),
            IconParkIconKind.FlipCamera => new FlipCamera(),
            IconParkIconKind.FlipHorizontally => new FlipHorizontally(),
            IconParkIconKind.FlipVertically => new FlipVertically(),
            IconParkIconKind.Flirt => new Flirt(),
            IconParkIconKind.Float => new Float(),
            IconParkIconKind.FloorTile => new FloorTile(),
            IconParkIconKind.Fm => new Fm(),
            IconParkIconKind.Focus => new Focus(),
            IconParkIconKind.FocusOne => new FocusOne(),
            IconParkIconKind.Fog => new Fog(),
            IconParkIconKind.FoldUpOne => new FoldUpOne(),
            IconParkIconKind.Folder => new Folder(),
            IconParkIconKind.FolderBlock => new FolderBlock(),
            IconParkIconKind.FolderBlockOne => new FolderBlockOne(),
            IconParkIconKind.FolderClose => new FolderClose(),
            IconParkIconKind.FolderCode => new FolderCode(),
            IconParkIconKind.FolderCodeOne => new FolderCodeOne(),
            IconParkIconKind.FolderConversion => new FolderConversion(),
            IconParkIconKind.FolderConversionOne => new FolderConversionOne(),
            IconParkIconKind.FolderDownload => new FolderDownload(),
            IconParkIconKind.FolderFailed => new FolderFailed(),
            IconParkIconKind.FolderFailedOne => new FolderFailedOne(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk16(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.FolderFocus: return typeof(FolderFocus);
            case IconParkIconKind.FolderFocusOne: return typeof(FolderFocusOne);
            case IconParkIconKind.FolderLock: return typeof(FolderLock);
            case IconParkIconKind.FolderLockOne: return typeof(FolderLockOne);
            case IconParkIconKind.FolderMinus: return typeof(FolderMinus);
            case IconParkIconKind.FolderMusic: return typeof(FolderMusic);
            case IconParkIconKind.FolderMusicOne: return typeof(FolderMusicOne);
            case IconParkIconKind.FolderOne: return typeof(FolderOne);
            case IconParkIconKind.FolderOpen: return typeof(FolderOpen);
            case IconParkIconKind.FolderPlus: return typeof(FolderPlus);
            case IconParkIconKind.FolderProtection: return typeof(FolderProtection);
            case IconParkIconKind.FolderProtectionOne: return typeof(FolderProtectionOne);
            case IconParkIconKind.FolderQuality: return typeof(FolderQuality);
            case IconParkIconKind.FolderQualityOne: return typeof(FolderQualityOne);
            case IconParkIconKind.FolderSearch: return typeof(FolderSearch);
            case IconParkIconKind.FolderSearchOne: return typeof(FolderSearchOne);
            case IconParkIconKind.FolderSettings: return typeof(FolderSettings);
            case IconParkIconKind.FolderSettingsOne: return typeof(FolderSettingsOne);
            case IconParkIconKind.FolderSuccess: return typeof(FolderSuccess);
            case IconParkIconKind.FolderSuccessOne: return typeof(FolderSuccessOne);
            case IconParkIconKind.FolderUpload: return typeof(FolderUpload);
            case IconParkIconKind.FolderWithdrawal: return typeof(FolderWithdrawal);
            case IconParkIconKind.FolderWithdrawalOne: return typeof(FolderWithdrawalOne);
            case IconParkIconKind.FollowUpDateSort: return typeof(FollowUpDateSort);
            case IconParkIconKind.FontSearch: return typeof(FontSearch);
            case IconParkIconKind.FontSize: return typeof(FontSize);
            case IconParkIconKind.FontSizeTwo: return typeof(FontSizeTwo);
            case IconParkIconKind.Foot: return typeof(Foot);
            case IconParkIconKind.Football: return typeof(Football);
            case IconParkIconKind.Forbid: return typeof(Forbid);
            case IconParkIconKind.Fork: return typeof(Fork);
            case IconParkIconKind.ForkSpoon: return typeof(ForkSpoon);
            case IconParkIconKind.Form: return typeof(Form);
            case IconParkIconKind.FormOne: return typeof(FormOne);
            case IconParkIconKind.Format: return typeof(Format);
            case IconParkIconKind.FormatBrush: return typeof(FormatBrush);
            case IconParkIconKind.Formula: return typeof(Formula);
            case IconParkIconKind.FoundationMakeup: return typeof(FoundationMakeup);
            case IconParkIconKind.Four: return typeof(Four);
            case IconParkIconKind.FourArrows: return typeof(FourArrows);
            case IconParkIconKind.FourFour: return typeof(FourFour);
            case IconParkIconKind.FourKey: return typeof(FourKey);
            case IconParkIconKind.FourLeaves: return typeof(FourLeaves);
            case IconParkIconKind.FourPointConnection: return typeof(FourPointConnection);
            case IconParkIconKind.FourRoundPointConnection: return typeof(FourRoundPointConnection);
            case IconParkIconKind.Foursquare: return typeof(Foursquare);
            case IconParkIconKind.FreezeColumn: return typeof(FreezeColumn);
            case IconParkIconKind.FreezeLine: return typeof(FreezeLine);
            case IconParkIconKind.FreezingLineColumn: return typeof(FreezingLineColumn);
            case IconParkIconKind.FrenchFries: return typeof(FrenchFries);
            case IconParkIconKind.FriendsCircle: return typeof(FriendsCircle);
            case IconParkIconKind.Frigate: return typeof(Frigate);
            case IconParkIconKind.Frog: return typeof(Frog);
            case IconParkIconKind.FrowningFaceWhitOpenMouth: return typeof(FrowningFaceWhitOpenMouth);
            case IconParkIconKind.Fruiter: return typeof(Fruiter);
            case IconParkIconKind.FullDressLonguette: return typeof(FullDressLonguette);
            case IconParkIconKind.FullScreen: return typeof(FullScreen);
            case IconParkIconKind.FullScreenOne: return typeof(FullScreenOne);
            case IconParkIconKind.FullScreenPlay: return typeof(FullScreenPlay);
            case IconParkIconKind.FullScreenTwo: return typeof(FullScreenTwo);
            case IconParkIconKind.FullSelection: return typeof(FullSelection);
            case IconParkIconKind.Fullwidth: return typeof(Fullwidth);
            case IconParkIconKind.Funds: return typeof(Funds);
            case IconParkIconKind.FutureBuildOne: return typeof(FutureBuildOne);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk16(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.FolderFocus => new FolderFocus(),
            IconParkIconKind.FolderFocusOne => new FolderFocusOne(),
            IconParkIconKind.FolderLock => new FolderLock(),
            IconParkIconKind.FolderLockOne => new FolderLockOne(),
            IconParkIconKind.FolderMinus => new FolderMinus(),
            IconParkIconKind.FolderMusic => new FolderMusic(),
            IconParkIconKind.FolderMusicOne => new FolderMusicOne(),
            IconParkIconKind.FolderOne => new FolderOne(),
            IconParkIconKind.FolderOpen => new FolderOpen(),
            IconParkIconKind.FolderPlus => new FolderPlus(),
            IconParkIconKind.FolderProtection => new FolderProtection(),
            IconParkIconKind.FolderProtectionOne => new FolderProtectionOne(),
            IconParkIconKind.FolderQuality => new FolderQuality(),
            IconParkIconKind.FolderQualityOne => new FolderQualityOne(),
            IconParkIconKind.FolderSearch => new FolderSearch(),
            IconParkIconKind.FolderSearchOne => new FolderSearchOne(),
            IconParkIconKind.FolderSettings => new FolderSettings(),
            IconParkIconKind.FolderSettingsOne => new FolderSettingsOne(),
            IconParkIconKind.FolderSuccess => new FolderSuccess(),
            IconParkIconKind.FolderSuccessOne => new FolderSuccessOne(),
            IconParkIconKind.FolderUpload => new FolderUpload(),
            IconParkIconKind.FolderWithdrawal => new FolderWithdrawal(),
            IconParkIconKind.FolderWithdrawalOne => new FolderWithdrawalOne(),
            IconParkIconKind.FollowUpDateSort => new FollowUpDateSort(),
            IconParkIconKind.FontSearch => new FontSearch(),
            IconParkIconKind.FontSize => new FontSize(),
            IconParkIconKind.FontSizeTwo => new FontSizeTwo(),
            IconParkIconKind.Foot => new Foot(),
            IconParkIconKind.Football => new Football(),
            IconParkIconKind.Forbid => new Forbid(),
            IconParkIconKind.Fork => new Fork(),
            IconParkIconKind.ForkSpoon => new ForkSpoon(),
            IconParkIconKind.Form => new Form(),
            IconParkIconKind.FormOne => new FormOne(),
            IconParkIconKind.Format => new Format(),
            IconParkIconKind.FormatBrush => new FormatBrush(),
            IconParkIconKind.Formula => new Formula(),
            IconParkIconKind.FoundationMakeup => new FoundationMakeup(),
            IconParkIconKind.Four => new Four(),
            IconParkIconKind.FourArrows => new FourArrows(),
            IconParkIconKind.FourFour => new FourFour(),
            IconParkIconKind.FourKey => new FourKey(),
            IconParkIconKind.FourLeaves => new FourLeaves(),
            IconParkIconKind.FourPointConnection => new FourPointConnection(),
            IconParkIconKind.FourRoundPointConnection => new FourRoundPointConnection(),
            IconParkIconKind.Foursquare => new Foursquare(),
            IconParkIconKind.FreezeColumn => new FreezeColumn(),
            IconParkIconKind.FreezeLine => new FreezeLine(),
            IconParkIconKind.FreezingLineColumn => new FreezingLineColumn(),
            IconParkIconKind.FrenchFries => new FrenchFries(),
            IconParkIconKind.FriendsCircle => new FriendsCircle(),
            IconParkIconKind.Frigate => new Frigate(),
            IconParkIconKind.Frog => new Frog(),
            IconParkIconKind.FrowningFaceWhitOpenMouth => new FrowningFaceWhitOpenMouth(),
            IconParkIconKind.Fruiter => new Fruiter(),
            IconParkIconKind.FullDressLonguette => new FullDressLonguette(),
            IconParkIconKind.FullScreen => new FullScreen(),
            IconParkIconKind.FullScreenOne => new FullScreenOne(),
            IconParkIconKind.FullScreenPlay => new FullScreenPlay(),
            IconParkIconKind.FullScreenTwo => new FullScreenTwo(),
            IconParkIconKind.FullSelection => new FullSelection(),
            IconParkIconKind.Fullwidth => new Fullwidth(),
            IconParkIconKind.Funds => new Funds(),
            IconParkIconKind.FutureBuildOne => new FutureBuildOne(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk17(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.FutureBuildThree: return typeof(FutureBuildThree);
            case IconParkIconKind.FutureBuildTwo: return typeof(FutureBuildTwo);
            case IconParkIconKind.Game: return typeof(Game);
            case IconParkIconKind.GameConsole: return typeof(GameConsole);
            case IconParkIconKind.GameConsoleOne: return typeof(GameConsoleOne);
            case IconParkIconKind.GameEmoji: return typeof(GameEmoji);
            case IconParkIconKind.GameHandle: return typeof(GameHandle);
            case IconParkIconKind.GamePs: return typeof(GamePs);
            case IconParkIconKind.GameThree: return typeof(GameThree);
            case IconParkIconKind.GameTwo: return typeof(GameTwo);
            case IconParkIconKind.Gamepad: return typeof(Gamepad);
            case IconParkIconKind.Garage: return typeof(Garage);
            case IconParkIconKind.Garlic: return typeof(Garlic);
            case IconParkIconKind.Gas: return typeof(Gas);
            case IconParkIconKind.Gastrointestinal: return typeof(Gastrointestinal);
            case IconParkIconKind.Gate: return typeof(Gate);
            case IconParkIconKind.GateMachine: return typeof(GateMachine);
            case IconParkIconKind.Gauze: return typeof(Gauze);
            case IconParkIconKind.Gavel: return typeof(Gavel);
            case IconParkIconKind.Gemini: return typeof(Gemini);
            case IconParkIconKind.GeneralBranch: return typeof(GeneralBranch);
            case IconParkIconKind.GeometricFlowers: return typeof(GeometricFlowers);
            case IconParkIconKind.Germs: return typeof(Germs);
            case IconParkIconKind.Ghost: return typeof(Ghost);
            case IconParkIconKind.Gift: return typeof(Gift);
            case IconParkIconKind.GiftBag: return typeof(GiftBag);
            case IconParkIconKind.GiftBox: return typeof(GiftBox);
            case IconParkIconKind.Girl: return typeof(Girl);
            case IconParkIconKind.GirlOne: return typeof(GirlOne);
            case IconParkIconKind.GirlTwo: return typeof(GirlTwo);
            case IconParkIconKind.Github: return typeof(Github);
            case IconParkIconKind.GithubOne: return typeof(GithubOne);
            case IconParkIconKind.Gitlab: return typeof(Gitlab);
            case IconParkIconKind.Glasses: return typeof(Glasses);
            case IconParkIconKind.GlassesOne: return typeof(GlassesOne);
            case IconParkIconKind.GlassesThree: return typeof(GlassesThree);
            case IconParkIconKind.Globe: return typeof(Globe);
            case IconParkIconKind.Glove: return typeof(Glove);
            case IconParkIconKind.GoAhead: return typeof(GoAhead);
            case IconParkIconKind.GoEnd: return typeof(GoEnd);
            case IconParkIconKind.GoOn: return typeof(GoOn);
            case IconParkIconKind.GoStart: return typeof(GoStart);
            case IconParkIconKind.Goblet: return typeof(Goblet);
            case IconParkIconKind.GobletCracking: return typeof(GobletCracking);
            case IconParkIconKind.GobletFull: return typeof(GobletFull);
            case IconParkIconKind.GobletOne: return typeof(GobletOne);
            case IconParkIconKind.GoldMedal: return typeof(GoldMedal);
            case IconParkIconKind.GoldMedalTwo: return typeof(GoldMedalTwo);
            case IconParkIconKind.GolfCourse: return typeof(GolfCourse);
            case IconParkIconKind.Gongfu: return typeof(Gongfu);
            case IconParkIconKind.Good: return typeof(Good);
            case IconParkIconKind.GoodOne: return typeof(GoodOne);
            case IconParkIconKind.GoodTwo: return typeof(GoodTwo);
            case IconParkIconKind.Google: return typeof(Google);
            case IconParkIconKind.GoogleAds: return typeof(GoogleAds);
            case IconParkIconKind.Gopro: return typeof(Gopro);
            case IconParkIconKind.Gps: return typeof(Gps);
            case IconParkIconKind.GraphicDesign: return typeof(GraphicDesign);
            case IconParkIconKind.GraphicDesignTwo: return typeof(GraphicDesignTwo);
            case IconParkIconKind.GraphicStitching: return typeof(GraphicStitching);
            case IconParkIconKind.GraphicStitchingFour: return typeof(GraphicStitchingFour);
            case IconParkIconKind.GraphicStitchingThree: return typeof(GraphicStitchingThree);
            case IconParkIconKind.GreatWall: return typeof(GreatWall);
            case IconParkIconKind.GreenHouse: return typeof(GreenHouse);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk17(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.FutureBuildThree => new FutureBuildThree(),
            IconParkIconKind.FutureBuildTwo => new FutureBuildTwo(),
            IconParkIconKind.Game => new Game(),
            IconParkIconKind.GameConsole => new GameConsole(),
            IconParkIconKind.GameConsoleOne => new GameConsoleOne(),
            IconParkIconKind.GameEmoji => new GameEmoji(),
            IconParkIconKind.GameHandle => new GameHandle(),
            IconParkIconKind.GamePs => new GamePs(),
            IconParkIconKind.GameThree => new GameThree(),
            IconParkIconKind.GameTwo => new GameTwo(),
            IconParkIconKind.Gamepad => new Gamepad(),
            IconParkIconKind.Garage => new Garage(),
            IconParkIconKind.Garlic => new Garlic(),
            IconParkIconKind.Gas => new Gas(),
            IconParkIconKind.Gastrointestinal => new Gastrointestinal(),
            IconParkIconKind.Gate => new Gate(),
            IconParkIconKind.GateMachine => new GateMachine(),
            IconParkIconKind.Gauze => new Gauze(),
            IconParkIconKind.Gavel => new Gavel(),
            IconParkIconKind.Gemini => new Gemini(),
            IconParkIconKind.GeneralBranch => new GeneralBranch(),
            IconParkIconKind.GeometricFlowers => new GeometricFlowers(),
            IconParkIconKind.Germs => new Germs(),
            IconParkIconKind.Ghost => new Ghost(),
            IconParkIconKind.Gift => new Gift(),
            IconParkIconKind.GiftBag => new GiftBag(),
            IconParkIconKind.GiftBox => new GiftBox(),
            IconParkIconKind.Girl => new Girl(),
            IconParkIconKind.GirlOne => new GirlOne(),
            IconParkIconKind.GirlTwo => new GirlTwo(),
            IconParkIconKind.Github => new Github(),
            IconParkIconKind.GithubOne => new GithubOne(),
            IconParkIconKind.Gitlab => new Gitlab(),
            IconParkIconKind.Glasses => new Glasses(),
            IconParkIconKind.GlassesOne => new GlassesOne(),
            IconParkIconKind.GlassesThree => new GlassesThree(),
            IconParkIconKind.Globe => new Globe(),
            IconParkIconKind.Glove => new Glove(),
            IconParkIconKind.GoAhead => new GoAhead(),
            IconParkIconKind.GoEnd => new GoEnd(),
            IconParkIconKind.GoOn => new GoOn(),
            IconParkIconKind.GoStart => new GoStart(),
            IconParkIconKind.Goblet => new Goblet(),
            IconParkIconKind.GobletCracking => new GobletCracking(),
            IconParkIconKind.GobletFull => new GobletFull(),
            IconParkIconKind.GobletOne => new GobletOne(),
            IconParkIconKind.GoldMedal => new GoldMedal(),
            IconParkIconKind.GoldMedalTwo => new GoldMedalTwo(),
            IconParkIconKind.GolfCourse => new GolfCourse(),
            IconParkIconKind.Gongfu => new Gongfu(),
            IconParkIconKind.Good => new Good(),
            IconParkIconKind.GoodOne => new GoodOne(),
            IconParkIconKind.GoodTwo => new GoodTwo(),
            IconParkIconKind.Google => new Google(),
            IconParkIconKind.GoogleAds => new GoogleAds(),
            IconParkIconKind.Gopro => new Gopro(),
            IconParkIconKind.Gps => new Gps(),
            IconParkIconKind.GraphicDesign => new GraphicDesign(),
            IconParkIconKind.GraphicDesignTwo => new GraphicDesignTwo(),
            IconParkIconKind.GraphicStitching => new GraphicStitching(),
            IconParkIconKind.GraphicStitchingFour => new GraphicStitchingFour(),
            IconParkIconKind.GraphicStitchingThree => new GraphicStitchingThree(),
            IconParkIconKind.GreatWall => new GreatWall(),
            IconParkIconKind.GreenHouse => new GreenHouse(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk18(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.GreenNewEnergy: return typeof(GreenNewEnergy);
            case IconParkIconKind.GridFour: return typeof(GridFour);
            case IconParkIconKind.GridNine: return typeof(GridNine);
            case IconParkIconKind.GridSixteen: return typeof(GridSixteen);
            case IconParkIconKind.GridThree: return typeof(GridThree);
            case IconParkIconKind.GridTwo: return typeof(GridTwo);
            case IconParkIconKind.GrimacingFace: return typeof(GrimacingFace);
            case IconParkIconKind.GrinningFace: return typeof(GrinningFace);
            case IconParkIconKind.GrinningFaceWithOpenMouth: return typeof(GrinningFaceWithOpenMouth);
            case IconParkIconKind.GrinningFaceWithSquintingEyes: return typeof(GrinningFaceWithSquintingEyes);
            case IconParkIconKind.GrinningFaceWithTightlyClosedEyes: return typeof(GrinningFaceWithTightlyClosedEyes);
            case IconParkIconKind.GrinningFaceWithTightlyClosedEyesOpenMouth: return typeof(GrinningFaceWithTightlyClosedEyesOpenMouth);
            case IconParkIconKind.Group: return typeof(Group);
            case IconParkIconKind.GuideBoard: return typeof(GuideBoard);
            case IconParkIconKind.Gymnastics: return typeof(Gymnastics);
            case IconParkIconKind.GymnasticsOne: return typeof(GymnasticsOne);
            case IconParkIconKind.H: return typeof(H);
            case IconParkIconKind.H1: return typeof(H1);
            case IconParkIconKind.H2: return typeof(H2);
            case IconParkIconKind.H3: return typeof(H3);
            case IconParkIconKind.HairBrush: return typeof(HairBrush);
            case IconParkIconKind.HairClip: return typeof(HairClip);
            case IconParkIconKind.HairDryer: return typeof(HairDryer);
            case IconParkIconKind.HairDryerOne: return typeof(HairDryerOne);
            case IconParkIconKind.Halo: return typeof(Halo);
            case IconParkIconKind.Hamburger: return typeof(Hamburger);
            case IconParkIconKind.HamburgerButton: return typeof(HamburgerButton);
            case IconParkIconKind.HamburgerOne: return typeof(HamburgerOne);
            case IconParkIconKind.HammerAndAnvil: return typeof(HammerAndAnvil);
            case IconParkIconKind.HandCream: return typeof(HandCream);
            case IconParkIconKind.HandDown: return typeof(HandDown);
            case IconParkIconKind.HandDrag: return typeof(HandDrag);
            case IconParkIconKind.HandLeft: return typeof(HandLeft);
            case IconParkIconKind.HandPaintedPlate: return typeof(HandPaintedPlate);
            case IconParkIconKind.HandRight: return typeof(HandRight);
            case IconParkIconKind.HandUp: return typeof(HandUp);
            case IconParkIconKind.Handbag: return typeof(Handbag);
            case IconParkIconKind.Handheld: return typeof(Handheld);
            case IconParkIconKind.HandleA: return typeof(HandleA);
            case IconParkIconKind.HandleB: return typeof(HandleB);
            case IconParkIconKind.HandleC: return typeof(HandleC);
            case IconParkIconKind.HandleDown: return typeof(HandleDown);
            case IconParkIconKind.HandleLeft: return typeof(HandleLeft);
            case IconParkIconKind.HandleRight: return typeof(HandleRight);
            case IconParkIconKind.HandleRound: return typeof(HandleRound);
            case IconParkIconKind.HandleSquare: return typeof(HandleSquare);
            case IconParkIconKind.HandleTriangle: return typeof(HandleTriangle);
            case IconParkIconKind.HandleUp: return typeof(HandleUp);
            case IconParkIconKind.HandleX: return typeof(HandleX);
            case IconParkIconKind.HandleY: return typeof(HandleY);
            case IconParkIconKind.HandleZ: return typeof(HandleZ);
            case IconParkIconKind.Hands: return typeof(Hands);
            case IconParkIconKind.Handwashing: return typeof(Handwashing);
            case IconParkIconKind.HandwashingFluid: return typeof(HandwashingFluid);
            case IconParkIconKind.HanfuChineseStyle: return typeof(HanfuChineseStyle);
            case IconParkIconKind.Hanger: return typeof(Hanger);
            case IconParkIconKind.HangerOne: return typeof(HangerOne);
            case IconParkIconKind.HangerTwo: return typeof(HangerTwo);
            case IconParkIconKind.HardDisk: return typeof(HardDisk);
            case IconParkIconKind.HardDiskOne: return typeof(HardDiskOne);
            case IconParkIconKind.Harm: return typeof(Harm);
            case IconParkIconKind.HashtagKey: return typeof(HashtagKey);
            case IconParkIconKind.Hat: return typeof(Hat);
            case IconParkIconKind.Hdd: return typeof(Hdd);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk18(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.GreenNewEnergy => new GreenNewEnergy(),
            IconParkIconKind.GridFour => new GridFour(),
            IconParkIconKind.GridNine => new GridNine(),
            IconParkIconKind.GridSixteen => new GridSixteen(),
            IconParkIconKind.GridThree => new GridThree(),
            IconParkIconKind.GridTwo => new GridTwo(),
            IconParkIconKind.GrimacingFace => new GrimacingFace(),
            IconParkIconKind.GrinningFace => new GrinningFace(),
            IconParkIconKind.GrinningFaceWithOpenMouth => new GrinningFaceWithOpenMouth(),
            IconParkIconKind.GrinningFaceWithSquintingEyes => new GrinningFaceWithSquintingEyes(),
            IconParkIconKind.GrinningFaceWithTightlyClosedEyes => new GrinningFaceWithTightlyClosedEyes(),
            IconParkIconKind.GrinningFaceWithTightlyClosedEyesOpenMouth => new GrinningFaceWithTightlyClosedEyesOpenMouth(),
            IconParkIconKind.Group => new Group(),
            IconParkIconKind.GuideBoard => new GuideBoard(),
            IconParkIconKind.Gymnastics => new Gymnastics(),
            IconParkIconKind.GymnasticsOne => new GymnasticsOne(),
            IconParkIconKind.H => new H(),
            IconParkIconKind.H1 => new H1(),
            IconParkIconKind.H2 => new H2(),
            IconParkIconKind.H3 => new H3(),
            IconParkIconKind.HairBrush => new HairBrush(),
            IconParkIconKind.HairClip => new HairClip(),
            IconParkIconKind.HairDryer => new HairDryer(),
            IconParkIconKind.HairDryerOne => new HairDryerOne(),
            IconParkIconKind.Halo => new Halo(),
            IconParkIconKind.Hamburger => new Hamburger(),
            IconParkIconKind.HamburgerButton => new HamburgerButton(),
            IconParkIconKind.HamburgerOne => new HamburgerOne(),
            IconParkIconKind.HammerAndAnvil => new HammerAndAnvil(),
            IconParkIconKind.HandCream => new HandCream(),
            IconParkIconKind.HandDown => new HandDown(),
            IconParkIconKind.HandDrag => new HandDrag(),
            IconParkIconKind.HandLeft => new HandLeft(),
            IconParkIconKind.HandPaintedPlate => new HandPaintedPlate(),
            IconParkIconKind.HandRight => new HandRight(),
            IconParkIconKind.HandUp => new HandUp(),
            IconParkIconKind.Handbag => new Handbag(),
            IconParkIconKind.Handheld => new Handheld(),
            IconParkIconKind.HandleA => new HandleA(),
            IconParkIconKind.HandleB => new HandleB(),
            IconParkIconKind.HandleC => new HandleC(),
            IconParkIconKind.HandleDown => new HandleDown(),
            IconParkIconKind.HandleLeft => new HandleLeft(),
            IconParkIconKind.HandleRight => new HandleRight(),
            IconParkIconKind.HandleRound => new HandleRound(),
            IconParkIconKind.HandleSquare => new HandleSquare(),
            IconParkIconKind.HandleTriangle => new HandleTriangle(),
            IconParkIconKind.HandleUp => new HandleUp(),
            IconParkIconKind.HandleX => new HandleX(),
            IconParkIconKind.HandleY => new HandleY(),
            IconParkIconKind.HandleZ => new HandleZ(),
            IconParkIconKind.Hands => new Hands(),
            IconParkIconKind.Handwashing => new Handwashing(),
            IconParkIconKind.HandwashingFluid => new HandwashingFluid(),
            IconParkIconKind.HanfuChineseStyle => new HanfuChineseStyle(),
            IconParkIconKind.Hanger => new Hanger(),
            IconParkIconKind.HangerOne => new HangerOne(),
            IconParkIconKind.HangerTwo => new HangerTwo(),
            IconParkIconKind.HardDisk => new HardDisk(),
            IconParkIconKind.HardDiskOne => new HardDiskOne(),
            IconParkIconKind.Harm => new Harm(),
            IconParkIconKind.HashtagKey => new HashtagKey(),
            IconParkIconKind.Hat => new Hat(),
            IconParkIconKind.Hdd => new Hdd(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk19(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.HdmiCable: return typeof(HdmiCable);
            case IconParkIconKind.HdmiConnector: return typeof(HdmiConnector);
            case IconParkIconKind.HeadphoneSound: return typeof(HeadphoneSound);
            case IconParkIconKind.Headset: return typeof(Headset);
            case IconParkIconKind.HeadsetOne: return typeof(HeadsetOne);
            case IconParkIconKind.HeadsetTwo: return typeof(HeadsetTwo);
            case IconParkIconKind.Headwear: return typeof(Headwear);
            case IconParkIconKind.Health: return typeof(Health);
            case IconParkIconKind.HealthProducts: return typeof(HealthProducts);
            case IconParkIconKind.HealthyRecognition: return typeof(HealthyRecognition);
            case IconParkIconKind.Heart: return typeof(Heart);
            case IconParkIconKind.HeartBallon: return typeof(HeartBallon);
            case IconParkIconKind.HeartRate: return typeof(HeartRate);
            case IconParkIconKind.Heartbeat: return typeof(Heartbeat);
            case IconParkIconKind.HeaterResistor: return typeof(HeaterResistor);
            case IconParkIconKind.HeavyMetal: return typeof(HeavyMetal);
            case IconParkIconKind.HeavyRain: return typeof(HeavyRain);
            case IconParkIconKind.HeavyWind: return typeof(HeavyWind);
            case IconParkIconKind.Helmet: return typeof(Helmet);
            case IconParkIconKind.HelmetOne: return typeof(HelmetOne);
            case IconParkIconKind.Help: return typeof(Help);
            case IconParkIconKind.Helpcenter: return typeof(Helpcenter);
            case IconParkIconKind.HexagonOne: return typeof(HexagonOne);
            case IconParkIconKind.HexagonStrip: return typeof(HexagonStrip);
            case IconParkIconKind.Hexagonal: return typeof(Hexagonal);
            case IconParkIconKind.Hi: return typeof(Hi);
            case IconParkIconKind.HighHeeledShoes: return typeof(HighHeeledShoes);
            case IconParkIconKind.HighLight: return typeof(HighLight);
            case IconParkIconKind.HighSpeedRail: return typeof(HighSpeedRail);
            case IconParkIconKind.Hippo: return typeof(Hippo);
            case IconParkIconKind.Histogram: return typeof(Histogram);
            case IconParkIconKind.History: return typeof(History);
            case IconParkIconKind.HistoryQuery: return typeof(HistoryQuery);
            case IconParkIconKind.Hockey: return typeof(Hockey);
            case IconParkIconKind.Hold: return typeof(Hold);
            case IconParkIconKind.HoldInterface: return typeof(HoldInterface);
            case IconParkIconKind.HoldSeeds: return typeof(HoldSeeds);
            case IconParkIconKind.HoldingHands: return typeof(HoldingHands);
            case IconParkIconKind.HolySword: return typeof(HolySword);
            case IconParkIconKind.Home: return typeof(Home);
            case IconParkIconKind.HomeTwo: return typeof(HomeTwo);
            case IconParkIconKind.Homestay: return typeof(Homestay);
            case IconParkIconKind.Honey: return typeof(Honey);
            case IconParkIconKind.HoneyOne: return typeof(HoneyOne);
            case IconParkIconKind.HorizontalSpacingBetweenItems: return typeof(HorizontalSpacingBetweenItems);
            case IconParkIconKind.HorizontalTidyUp: return typeof(HorizontalTidyUp);
            case IconParkIconKind.HorizontallyCentered: return typeof(HorizontallyCentered);
            case IconParkIconKind.HorseZodiac: return typeof(HorseZodiac);
            case IconParkIconKind.Hospital: return typeof(Hospital);
            case IconParkIconKind.HospitalBed: return typeof(HospitalBed);
            case IconParkIconKind.HospitalFour: return typeof(HospitalFour);
            case IconParkIconKind.HospitalThree: return typeof(HospitalThree);
            case IconParkIconKind.HospitalTwo: return typeof(HospitalTwo);
            case IconParkIconKind.HotAirBalloon: return typeof(HotAirBalloon);
            case IconParkIconKind.HotPot: return typeof(HotPot);
            case IconParkIconKind.HotPotOne: return typeof(HotPotOne);
            case IconParkIconKind.Hotel: return typeof(Hotel);
            case IconParkIconKind.HotelDoNotClean: return typeof(HotelDoNotClean);
            case IconParkIconKind.HotelPleaseClean: return typeof(HotelPleaseClean);
            case IconParkIconKind.Hourglass: return typeof(Hourglass);
            case IconParkIconKind.HourglassFull: return typeof(HourglassFull);
            case IconParkIconKind.HourglassNull: return typeof(HourglassNull);
            case IconParkIconKind.HtmlFive: return typeof(HtmlFive);
            case IconParkIconKind.HuntingGear: return typeof(HuntingGear);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk19(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.HdmiCable => new HdmiCable(),
            IconParkIconKind.HdmiConnector => new HdmiConnector(),
            IconParkIconKind.HeadphoneSound => new HeadphoneSound(),
            IconParkIconKind.Headset => new Headset(),
            IconParkIconKind.HeadsetOne => new HeadsetOne(),
            IconParkIconKind.HeadsetTwo => new HeadsetTwo(),
            IconParkIconKind.Headwear => new Headwear(),
            IconParkIconKind.Health => new Health(),
            IconParkIconKind.HealthProducts => new HealthProducts(),
            IconParkIconKind.HealthyRecognition => new HealthyRecognition(),
            IconParkIconKind.Heart => new Heart(),
            IconParkIconKind.HeartBallon => new HeartBallon(),
            IconParkIconKind.HeartRate => new HeartRate(),
            IconParkIconKind.Heartbeat => new Heartbeat(),
            IconParkIconKind.HeaterResistor => new HeaterResistor(),
            IconParkIconKind.HeavyMetal => new HeavyMetal(),
            IconParkIconKind.HeavyRain => new HeavyRain(),
            IconParkIconKind.HeavyWind => new HeavyWind(),
            IconParkIconKind.Helmet => new Helmet(),
            IconParkIconKind.HelmetOne => new HelmetOne(),
            IconParkIconKind.Help => new Help(),
            IconParkIconKind.Helpcenter => new Helpcenter(),
            IconParkIconKind.HexagonOne => new HexagonOne(),
            IconParkIconKind.HexagonStrip => new HexagonStrip(),
            IconParkIconKind.Hexagonal => new Hexagonal(),
            IconParkIconKind.Hi => new Hi(),
            IconParkIconKind.HighHeeledShoes => new HighHeeledShoes(),
            IconParkIconKind.HighLight => new HighLight(),
            IconParkIconKind.HighSpeedRail => new HighSpeedRail(),
            IconParkIconKind.Hippo => new Hippo(),
            IconParkIconKind.Histogram => new Histogram(),
            IconParkIconKind.History => new History(),
            IconParkIconKind.HistoryQuery => new HistoryQuery(),
            IconParkIconKind.Hockey => new Hockey(),
            IconParkIconKind.Hold => new Hold(),
            IconParkIconKind.HoldInterface => new HoldInterface(),
            IconParkIconKind.HoldSeeds => new HoldSeeds(),
            IconParkIconKind.HoldingHands => new HoldingHands(),
            IconParkIconKind.HolySword => new HolySword(),
            IconParkIconKind.Home => new Home(),
            IconParkIconKind.HomeTwo => new HomeTwo(),
            IconParkIconKind.Homestay => new Homestay(),
            IconParkIconKind.Honey => new Honey(),
            IconParkIconKind.HoneyOne => new HoneyOne(),
            IconParkIconKind.HorizontalSpacingBetweenItems => new HorizontalSpacingBetweenItems(),
            IconParkIconKind.HorizontalTidyUp => new HorizontalTidyUp(),
            IconParkIconKind.HorizontallyCentered => new HorizontallyCentered(),
            IconParkIconKind.HorseZodiac => new HorseZodiac(),
            IconParkIconKind.Hospital => new Hospital(),
            IconParkIconKind.HospitalBed => new HospitalBed(),
            IconParkIconKind.HospitalFour => new HospitalFour(),
            IconParkIconKind.HospitalThree => new HospitalThree(),
            IconParkIconKind.HospitalTwo => new HospitalTwo(),
            IconParkIconKind.HotAirBalloon => new HotAirBalloon(),
            IconParkIconKind.HotPot => new HotPot(),
            IconParkIconKind.HotPotOne => new HotPotOne(),
            IconParkIconKind.Hotel => new Hotel(),
            IconParkIconKind.HotelDoNotClean => new HotelDoNotClean(),
            IconParkIconKind.HotelPleaseClean => new HotelPleaseClean(),
            IconParkIconKind.Hourglass => new Hourglass(),
            IconParkIconKind.HourglassFull => new HourglassFull(),
            IconParkIconKind.HourglassNull => new HourglassNull(),
            IconParkIconKind.HtmlFive => new HtmlFive(),
            IconParkIconKind.HuntingGear => new HuntingGear(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk20(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Huoshanzhibo: return typeof(Huoshanzhibo);
            case IconParkIconKind.IMac: return typeof(IMac);
            case IconParkIconKind.Icecream: return typeof(Icecream);
            case IconParkIconKind.IcecreamFive: return typeof(IcecreamFive);
            case IconParkIconKind.IcecreamFour: return typeof(IcecreamFour);
            case IconParkIconKind.IcecreamOne: return typeof(IcecreamOne);
            case IconParkIconKind.IcecreamThree: return typeof(IcecreamThree);
            case IconParkIconKind.IcecreamTwo: return typeof(IcecreamTwo);
            case IconParkIconKind.IdCard: return typeof(IdCard);
            case IconParkIconKind.IdCardH: return typeof(IdCardH);
            case IconParkIconKind.IdCardV: return typeof(IdCardV);
            case IconParkIconKind.ImageFiles: return typeof(ImageFiles);
            case IconParkIconKind.Imbalance: return typeof(Imbalance);
            case IconParkIconKind.ImportAndExport: return typeof(ImportAndExport);
            case IconParkIconKind.InFlight: return typeof(InFlight);
            case IconParkIconKind.Inbox: return typeof(Inbox);
            case IconParkIconKind.InboxDownloadR: return typeof(InboxDownloadR);
            case IconParkIconKind.InboxIn: return typeof(InboxIn);
            case IconParkIconKind.InboxOut: return typeof(InboxOut);
            case IconParkIconKind.InboxR: return typeof(InboxR);
            case IconParkIconKind.InboxSuccess: return typeof(InboxSuccess);
            case IconParkIconKind.InboxSuccessR: return typeof(InboxSuccessR);
            case IconParkIconKind.InboxUploadR: return typeof(InboxUploadR);
            case IconParkIconKind.InclusiveGateway: return typeof(InclusiveGateway);
            case IconParkIconKind.Income: return typeof(Income);
            case IconParkIconKind.IncomeOne: return typeof(IncomeOne);
            case IconParkIconKind.Incoming: return typeof(Incoming);
            case IconParkIconKind.Increase: return typeof(Increase);
            case IconParkIconKind.IncreaseTheScale: return typeof(IncreaseTheScale);
            case IconParkIconKind.IndentLeft: return typeof(IndentLeft);
            case IconParkIconKind.IndentRight: return typeof(IndentRight);
            case IconParkIconKind.IndexFinger: return typeof(IndexFinger);
            case IconParkIconKind.InductionLock: return typeof(InductionLock);
            case IconParkIconKind.IndustrialScales: return typeof(IndustrialScales);
            case IconParkIconKind.Info: return typeof(Info);
            case IconParkIconKind.Infusion: return typeof(Infusion);
            case IconParkIconKind.Injection: return typeof(Injection);
            case IconParkIconKind.Inline: return typeof(Inline);
            case IconParkIconKind.InnerShadowBottomLeft: return typeof(InnerShadowBottomLeft);
            case IconParkIconKind.InnerShadowBottomRight: return typeof(InnerShadowBottomRight);
            case IconParkIconKind.InnerShadowDown: return typeof(InnerShadowDown);
            case IconParkIconKind.InnerShadowLeft: return typeof(InnerShadowLeft);
            case IconParkIconKind.InnerShadowRight: return typeof(InnerShadowRight);
            case IconParkIconKind.InnerShadowTopLeft: return typeof(InnerShadowTopLeft);
            case IconParkIconKind.InnerShadowTopRight: return typeof(InnerShadowTopRight);
            case IconParkIconKind.InnerShadowUp: return typeof(InnerShadowUp);
            case IconParkIconKind.InsertCard: return typeof(InsertCard);
            case IconParkIconKind.InsertTable: return typeof(InsertTable);
            case IconParkIconKind.Inspection: return typeof(Inspection);
            case IconParkIconKind.Instagram: return typeof(Instagram);
            case IconParkIconKind.InstagramOne: return typeof(InstagramOne);
            case IconParkIconKind.Install: return typeof(Install);
            case IconParkIconKind.Instruction: return typeof(Instruction);
            case IconParkIconKind.Intercom: return typeof(Intercom);
            case IconParkIconKind.IntermediateMode: return typeof(IntermediateMode);
            case IconParkIconKind.InternalData: return typeof(InternalData);
            case IconParkIconKind.InternalExpansion: return typeof(InternalExpansion);
            case IconParkIconKind.InternalReduction: return typeof(InternalReduction);
            case IconParkIconKind.InternalTransmission: return typeof(InternalTransmission);
            case IconParkIconKind.International: return typeof(International);
            case IconParkIconKind.IntersectSelection: return typeof(IntersectSelection);
            case IconParkIconKind.Intersection: return typeof(Intersection);
            case IconParkIconKind.InvalidFiles: return typeof(InvalidFiles);
            case IconParkIconKind.InvertCamera: return typeof(InvertCamera);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk20(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Huoshanzhibo => new Huoshanzhibo(),
            IconParkIconKind.IMac => new IMac(),
            IconParkIconKind.Icecream => new Icecream(),
            IconParkIconKind.IcecreamFive => new IcecreamFive(),
            IconParkIconKind.IcecreamFour => new IcecreamFour(),
            IconParkIconKind.IcecreamOne => new IcecreamOne(),
            IconParkIconKind.IcecreamThree => new IcecreamThree(),
            IconParkIconKind.IcecreamTwo => new IcecreamTwo(),
            IconParkIconKind.IdCard => new IdCard(),
            IconParkIconKind.IdCardH => new IdCardH(),
            IconParkIconKind.IdCardV => new IdCardV(),
            IconParkIconKind.ImageFiles => new ImageFiles(),
            IconParkIconKind.Imbalance => new Imbalance(),
            IconParkIconKind.ImportAndExport => new ImportAndExport(),
            IconParkIconKind.InFlight => new InFlight(),
            IconParkIconKind.Inbox => new Inbox(),
            IconParkIconKind.InboxDownloadR => new InboxDownloadR(),
            IconParkIconKind.InboxIn => new InboxIn(),
            IconParkIconKind.InboxOut => new InboxOut(),
            IconParkIconKind.InboxR => new InboxR(),
            IconParkIconKind.InboxSuccess => new InboxSuccess(),
            IconParkIconKind.InboxSuccessR => new InboxSuccessR(),
            IconParkIconKind.InboxUploadR => new InboxUploadR(),
            IconParkIconKind.InclusiveGateway => new InclusiveGateway(),
            IconParkIconKind.Income => new Income(),
            IconParkIconKind.IncomeOne => new IncomeOne(),
            IconParkIconKind.Incoming => new Incoming(),
            IconParkIconKind.Increase => new Increase(),
            IconParkIconKind.IncreaseTheScale => new IncreaseTheScale(),
            IconParkIconKind.IndentLeft => new IndentLeft(),
            IconParkIconKind.IndentRight => new IndentRight(),
            IconParkIconKind.IndexFinger => new IndexFinger(),
            IconParkIconKind.InductionLock => new InductionLock(),
            IconParkIconKind.IndustrialScales => new IndustrialScales(),
            IconParkIconKind.Info => new Info(),
            IconParkIconKind.Infusion => new Infusion(),
            IconParkIconKind.Injection => new Injection(),
            IconParkIconKind.Inline => new Inline(),
            IconParkIconKind.InnerShadowBottomLeft => new InnerShadowBottomLeft(),
            IconParkIconKind.InnerShadowBottomRight => new InnerShadowBottomRight(),
            IconParkIconKind.InnerShadowDown => new InnerShadowDown(),
            IconParkIconKind.InnerShadowLeft => new InnerShadowLeft(),
            IconParkIconKind.InnerShadowRight => new InnerShadowRight(),
            IconParkIconKind.InnerShadowTopLeft => new InnerShadowTopLeft(),
            IconParkIconKind.InnerShadowTopRight => new InnerShadowTopRight(),
            IconParkIconKind.InnerShadowUp => new InnerShadowUp(),
            IconParkIconKind.InsertCard => new InsertCard(),
            IconParkIconKind.InsertTable => new InsertTable(),
            IconParkIconKind.Inspection => new Inspection(),
            IconParkIconKind.Instagram => new Instagram(),
            IconParkIconKind.InstagramOne => new InstagramOne(),
            IconParkIconKind.Install => new Install(),
            IconParkIconKind.Instruction => new Instruction(),
            IconParkIconKind.Intercom => new Intercom(),
            IconParkIconKind.IntermediateMode => new IntermediateMode(),
            IconParkIconKind.InternalData => new InternalData(),
            IconParkIconKind.InternalExpansion => new InternalExpansion(),
            IconParkIconKind.InternalReduction => new InternalReduction(),
            IconParkIconKind.InternalTransmission => new InternalTransmission(),
            IconParkIconKind.International => new International(),
            IconParkIconKind.IntersectSelection => new IntersectSelection(),
            IconParkIconKind.Intersection => new Intersection(),
            IconParkIconKind.InvalidFiles => new InvalidFiles(),
            IconParkIconKind.InvertCamera => new InvertCamera(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk21(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.InvertLeft: return typeof(InvertLeft);
            case IconParkIconKind.InvertRight: return typeof(InvertRight);
            case IconParkIconKind.IosFaceRecognition: return typeof(IosFaceRecognition);
            case IconParkIconKind.Ipad: return typeof(Ipad);
            case IconParkIconKind.IpadOne: return typeof(IpadOne);
            case IconParkIconKind.Iphone: return typeof(Iphone);
            case IconParkIconKind.Ipo: return typeof(Ipo);
            case IconParkIconKind.Iron: return typeof(Iron);
            case IconParkIconKind.IronDisable: return typeof(IronDisable);
            case IconParkIconKind.IronThree: return typeof(IronThree);
            case IconParkIconKind.IronTwo: return typeof(IronTwo);
            case IconParkIconKind.Iwatch: return typeof(Iwatch);
            case IconParkIconKind.IwatchOne: return typeof(IwatchOne);
            case IconParkIconKind.IwatchTwo: return typeof(IwatchTwo);
            case IconParkIconKind.Jewelry: return typeof(Jewelry);
            case IconParkIconKind.Jinritoutiao: return typeof(Jinritoutiao);
            case IconParkIconKind.Journey: return typeof(Journey);
            case IconParkIconKind.Joystick: return typeof(Joystick);
            case IconParkIconKind.Juice: return typeof(Juice);
            case IconParkIconKind.Jump: return typeof(Jump);
            case IconParkIconKind.KagiMap: return typeof(KagiMap);
            case IconParkIconKind.Kettle: return typeof(Kettle);
            case IconParkIconKind.KettleOne: return typeof(KettleOne);
            case IconParkIconKind.Key: return typeof(Key);
            case IconParkIconKind.KeyOne: return typeof(KeyOne);
            case IconParkIconKind.KeyTwo: return typeof(KeyTwo);
            case IconParkIconKind.Keyboard: return typeof(Keyboard);
            case IconParkIconKind.KeyboardOne: return typeof(KeyboardOne);
            case IconParkIconKind.Keyhole: return typeof(Keyhole);
            case IconParkIconKind.Keyline: return typeof(Keyline);
            case IconParkIconKind.KitchenKnife: return typeof(KitchenKnife);
            case IconParkIconKind.KnifeFork: return typeof(KnifeFork);
            case IconParkIconKind.KoalaBear: return typeof(KoalaBear);
            case IconParkIconKind.Kungfu: return typeof(Kungfu);
            case IconParkIconKind.Label: return typeof(Label);
            case IconParkIconKind.Ladder: return typeof(Ladder);
            case IconParkIconKind.LadderOne: return typeof(LadderOne);
            case IconParkIconKind.Lamp: return typeof(Lamp);
            case IconParkIconKind.LandSurveying: return typeof(LandSurveying);
            case IconParkIconKind.Landing: return typeof(Landing);
            case IconParkIconKind.Landscape: return typeof(Landscape);
            case IconParkIconKind.Laptop: return typeof(Laptop);
            case IconParkIconKind.LaptopComputer: return typeof(LaptopComputer);
            case IconParkIconKind.LaptopOne: return typeof(LaptopOne);
            case IconParkIconKind.Lark: return typeof(Lark);
            case IconParkIconKind.LarkOne: return typeof(LarkOne);
            case IconParkIconKind.LatticePattern: return typeof(LatticePattern);
            case IconParkIconKind.Layers: return typeof(Layers);
            case IconParkIconKind.LayoutFive: return typeof(LayoutFive);
            case IconParkIconKind.LayoutFour: return typeof(LayoutFour);
            case IconParkIconKind.LayoutOne: return typeof(LayoutOne);
            case IconParkIconKind.LayoutThree: return typeof(LayoutThree);
            case IconParkIconKind.LayoutTwo: return typeof(LayoutTwo);
            case IconParkIconKind.Leaf: return typeof(Leaf);
            case IconParkIconKind.Leaves: return typeof(Leaves);
            case IconParkIconKind.LeavesOne: return typeof(LeavesOne);
            case IconParkIconKind.LeavesTwo: return typeof(LeavesTwo);
            case IconParkIconKind.LedDiode: return typeof(LedDiode);
            case IconParkIconKind.Left: return typeof(Left);
            case IconParkIconKind.LeftAlignment: return typeof(LeftAlignment);
            case IconParkIconKind.LeftAndRightBranch: return typeof(LeftAndRightBranch);
            case IconParkIconKind.LeftBar: return typeof(LeftBar);
            case IconParkIconKind.LeftBranch: return typeof(LeftBranch);
            case IconParkIconKind.LeftC: return typeof(LeftC);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk21(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.InvertLeft => new InvertLeft(),
            IconParkIconKind.InvertRight => new InvertRight(),
            IconParkIconKind.IosFaceRecognition => new IosFaceRecognition(),
            IconParkIconKind.Ipad => new Ipad(),
            IconParkIconKind.IpadOne => new IpadOne(),
            IconParkIconKind.Iphone => new Iphone(),
            IconParkIconKind.Ipo => new Ipo(),
            IconParkIconKind.Iron => new Iron(),
            IconParkIconKind.IronDisable => new IronDisable(),
            IconParkIconKind.IronThree => new IronThree(),
            IconParkIconKind.IronTwo => new IronTwo(),
            IconParkIconKind.Iwatch => new Iwatch(),
            IconParkIconKind.IwatchOne => new IwatchOne(),
            IconParkIconKind.IwatchTwo => new IwatchTwo(),
            IconParkIconKind.Jewelry => new Jewelry(),
            IconParkIconKind.Jinritoutiao => new Jinritoutiao(),
            IconParkIconKind.Journey => new Journey(),
            IconParkIconKind.Joystick => new Joystick(),
            IconParkIconKind.Juice => new Juice(),
            IconParkIconKind.Jump => new Jump(),
            IconParkIconKind.KagiMap => new KagiMap(),
            IconParkIconKind.Kettle => new Kettle(),
            IconParkIconKind.KettleOne => new KettleOne(),
            IconParkIconKind.Key => new Key(),
            IconParkIconKind.KeyOne => new KeyOne(),
            IconParkIconKind.KeyTwo => new KeyTwo(),
            IconParkIconKind.Keyboard => new Keyboard(),
            IconParkIconKind.KeyboardOne => new KeyboardOne(),
            IconParkIconKind.Keyhole => new Keyhole(),
            IconParkIconKind.Keyline => new Keyline(),
            IconParkIconKind.KitchenKnife => new KitchenKnife(),
            IconParkIconKind.KnifeFork => new KnifeFork(),
            IconParkIconKind.KoalaBear => new KoalaBear(),
            IconParkIconKind.Kungfu => new Kungfu(),
            IconParkIconKind.Label => new Label(),
            IconParkIconKind.Ladder => new Ladder(),
            IconParkIconKind.LadderOne => new LadderOne(),
            IconParkIconKind.Lamp => new Lamp(),
            IconParkIconKind.LandSurveying => new LandSurveying(),
            IconParkIconKind.Landing => new Landing(),
            IconParkIconKind.Landscape => new Landscape(),
            IconParkIconKind.Laptop => new Laptop(),
            IconParkIconKind.LaptopComputer => new LaptopComputer(),
            IconParkIconKind.LaptopOne => new LaptopOne(),
            IconParkIconKind.Lark => new Lark(),
            IconParkIconKind.LarkOne => new LarkOne(),
            IconParkIconKind.LatticePattern => new LatticePattern(),
            IconParkIconKind.Layers => new Layers(),
            IconParkIconKind.LayoutFive => new LayoutFive(),
            IconParkIconKind.LayoutFour => new LayoutFour(),
            IconParkIconKind.LayoutOne => new LayoutOne(),
            IconParkIconKind.LayoutThree => new LayoutThree(),
            IconParkIconKind.LayoutTwo => new LayoutTwo(),
            IconParkIconKind.Leaf => new Leaf(),
            IconParkIconKind.Leaves => new Leaves(),
            IconParkIconKind.LeavesOne => new LeavesOne(),
            IconParkIconKind.LeavesTwo => new LeavesTwo(),
            IconParkIconKind.LedDiode => new LedDiode(),
            IconParkIconKind.Left => new Left(),
            IconParkIconKind.LeftAlignment => new LeftAlignment(),
            IconParkIconKind.LeftAndRightBranch => new LeftAndRightBranch(),
            IconParkIconKind.LeftBar => new LeftBar(),
            IconParkIconKind.LeftBranch => new LeftBranch(),
            IconParkIconKind.LeftC => new LeftC(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk22(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.LeftExpand: return typeof(LeftExpand);
            case IconParkIconKind.LeftOne: return typeof(LeftOne);
            case IconParkIconKind.LeftSmall: return typeof(LeftSmall);
            case IconParkIconKind.LeftSmallDown: return typeof(LeftSmallDown);
            case IconParkIconKind.LeftSmallUp: return typeof(LeftSmallUp);
            case IconParkIconKind.LeftSquare: return typeof(LeftSquare);
            case IconParkIconKind.LeftTwo: return typeof(LeftTwo);
            case IconParkIconKind.Lemon: return typeof(Lemon);
            case IconParkIconKind.LensAlignment: return typeof(LensAlignment);
            case IconParkIconKind.Leo: return typeof(Leo);
            case IconParkIconKind.Level: return typeof(Level);
            case IconParkIconKind.LevelAdjustment: return typeof(LevelAdjustment);
            case IconParkIconKind.LevelEightTitle: return typeof(LevelEightTitle);
            case IconParkIconKind.LevelFiveTitle: return typeof(LevelFiveTitle);
            case IconParkIconKind.LevelFourTitle: return typeof(LevelFourTitle);
            case IconParkIconKind.LevelNineTitle: return typeof(LevelNineTitle);
            case IconParkIconKind.LevelSevenTitle: return typeof(LevelSevenTitle);
            case IconParkIconKind.LevelSixTitle: return typeof(LevelSixTitle);
            case IconParkIconKind.Libra: return typeof(Libra);
            case IconParkIconKind.Lifebuoy: return typeof(Lifebuoy);
            case IconParkIconKind.Light: return typeof(Light);
            case IconParkIconKind.LightHouse: return typeof(LightHouse);
            case IconParkIconKind.LightMember: return typeof(LightMember);
            case IconParkIconKind.LightRain: return typeof(LightRain);
            case IconParkIconKind.Lightning: return typeof(Lightning);
            case IconParkIconKind.Like: return typeof(Like);
            case IconParkIconKind.Lincoln: return typeof(Lincoln);
            case IconParkIconKind.Link: return typeof(Link);
            case IconParkIconKind.LinkBreak: return typeof(LinkBreak);
            case IconParkIconKind.LinkCloud: return typeof(LinkCloud);
            case IconParkIconKind.LinkCloudFaild: return typeof(LinkCloudFaild);
            case IconParkIconKind.LinkCloudSucess: return typeof(LinkCloudSucess);
            case IconParkIconKind.LinkFour: return typeof(LinkFour);
            case IconParkIconKind.LinkIn: return typeof(LinkIn);
            case IconParkIconKind.LinkInterrupt: return typeof(LinkInterrupt);
            case IconParkIconKind.LinkLeft: return typeof(LinkLeft);
            case IconParkIconKind.LinkOne: return typeof(LinkOne);
            case IconParkIconKind.LinkOut: return typeof(LinkOut);
            case IconParkIconKind.LinkRight: return typeof(LinkRight);
            case IconParkIconKind.LinkThree: return typeof(LinkThree);
            case IconParkIconKind.LinkTwo: return typeof(LinkTwo);
            case IconParkIconKind.LipGloss: return typeof(LipGloss);
            case IconParkIconKind.LipTattoo: return typeof(LipTattoo);
            case IconParkIconKind.Lipstick: return typeof(Lipstick);
            case IconParkIconKind.LipstickOne: return typeof(LipstickOne);
            case IconParkIconKind.Liqueur: return typeof(Liqueur);
            case IconParkIconKind.List: return typeof(List);
            case IconParkIconKind.ListAdd: return typeof(ListAdd);
            case IconParkIconKind.ListAlphabet: return typeof(ListAlphabet);
            case IconParkIconKind.ListBottom: return typeof(ListBottom);
            case IconParkIconKind.ListCheckbox: return typeof(ListCheckbox);
            case IconParkIconKind.ListFail: return typeof(ListFail);
            case IconParkIconKind.ListMiddle: return typeof(ListMiddle);
            case IconParkIconKind.ListNumbers: return typeof(ListNumbers);
            case IconParkIconKind.ListOne: return typeof(ListOne);
            case IconParkIconKind.ListSuccess: return typeof(ListSuccess);
            case IconParkIconKind.ListTop: return typeof(ListTop);
            case IconParkIconKind.ListTwo: return typeof(ListTwo);
            case IconParkIconKind.ListView: return typeof(ListView);
            case IconParkIconKind.Loading: return typeof(Loading);
            case IconParkIconKind.LoadingFour: return typeof(LoadingFour);
            case IconParkIconKind.LoadingOne: return typeof(LoadingOne);
            case IconParkIconKind.LoadingThree: return typeof(LoadingThree);
            case IconParkIconKind.LoadingTwo: return typeof(LoadingTwo);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk22(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.LeftExpand => new LeftExpand(),
            IconParkIconKind.LeftOne => new LeftOne(),
            IconParkIconKind.LeftSmall => new LeftSmall(),
            IconParkIconKind.LeftSmallDown => new LeftSmallDown(),
            IconParkIconKind.LeftSmallUp => new LeftSmallUp(),
            IconParkIconKind.LeftSquare => new LeftSquare(),
            IconParkIconKind.LeftTwo => new LeftTwo(),
            IconParkIconKind.Lemon => new Lemon(),
            IconParkIconKind.LensAlignment => new LensAlignment(),
            IconParkIconKind.Leo => new Leo(),
            IconParkIconKind.Level => new Level(),
            IconParkIconKind.LevelAdjustment => new LevelAdjustment(),
            IconParkIconKind.LevelEightTitle => new LevelEightTitle(),
            IconParkIconKind.LevelFiveTitle => new LevelFiveTitle(),
            IconParkIconKind.LevelFourTitle => new LevelFourTitle(),
            IconParkIconKind.LevelNineTitle => new LevelNineTitle(),
            IconParkIconKind.LevelSevenTitle => new LevelSevenTitle(),
            IconParkIconKind.LevelSixTitle => new LevelSixTitle(),
            IconParkIconKind.Libra => new Libra(),
            IconParkIconKind.Lifebuoy => new Lifebuoy(),
            IconParkIconKind.Light => new Light(),
            IconParkIconKind.LightHouse => new LightHouse(),
            IconParkIconKind.LightMember => new LightMember(),
            IconParkIconKind.LightRain => new LightRain(),
            IconParkIconKind.Lightning => new Lightning(),
            IconParkIconKind.Like => new Like(),
            IconParkIconKind.Lincoln => new Lincoln(),
            IconParkIconKind.Link => new Link(),
            IconParkIconKind.LinkBreak => new LinkBreak(),
            IconParkIconKind.LinkCloud => new LinkCloud(),
            IconParkIconKind.LinkCloudFaild => new LinkCloudFaild(),
            IconParkIconKind.LinkCloudSucess => new LinkCloudSucess(),
            IconParkIconKind.LinkFour => new LinkFour(),
            IconParkIconKind.LinkIn => new LinkIn(),
            IconParkIconKind.LinkInterrupt => new LinkInterrupt(),
            IconParkIconKind.LinkLeft => new LinkLeft(),
            IconParkIconKind.LinkOne => new LinkOne(),
            IconParkIconKind.LinkOut => new LinkOut(),
            IconParkIconKind.LinkRight => new LinkRight(),
            IconParkIconKind.LinkThree => new LinkThree(),
            IconParkIconKind.LinkTwo => new LinkTwo(),
            IconParkIconKind.LipGloss => new LipGloss(),
            IconParkIconKind.LipTattoo => new LipTattoo(),
            IconParkIconKind.Lipstick => new Lipstick(),
            IconParkIconKind.LipstickOne => new LipstickOne(),
            IconParkIconKind.Liqueur => new Liqueur(),
            IconParkIconKind.List => new List(),
            IconParkIconKind.ListAdd => new ListAdd(),
            IconParkIconKind.ListAlphabet => new ListAlphabet(),
            IconParkIconKind.ListBottom => new ListBottom(),
            IconParkIconKind.ListCheckbox => new ListCheckbox(),
            IconParkIconKind.ListFail => new ListFail(),
            IconParkIconKind.ListMiddle => new ListMiddle(),
            IconParkIconKind.ListNumbers => new ListNumbers(),
            IconParkIconKind.ListOne => new ListOne(),
            IconParkIconKind.ListSuccess => new ListSuccess(),
            IconParkIconKind.ListTop => new ListTop(),
            IconParkIconKind.ListTwo => new ListTwo(),
            IconParkIconKind.ListView => new ListView(),
            IconParkIconKind.Loading => new Loading(),
            IconParkIconKind.LoadingFour => new LoadingFour(),
            IconParkIconKind.LoadingOne => new LoadingOne(),
            IconParkIconKind.LoadingThree => new LoadingThree(),
            IconParkIconKind.LoadingTwo => new LoadingTwo(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk23(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Local: return typeof(Local);
            case IconParkIconKind.LocalPin: return typeof(LocalPin);
            case IconParkIconKind.LocalTwo: return typeof(LocalTwo);
            case IconParkIconKind.Lock: return typeof(Lock);
            case IconParkIconKind.LockOne: return typeof(LockOne);
            case IconParkIconKind.LockingComputer: return typeof(LockingComputer);
            case IconParkIconKind.LockingLaptop: return typeof(LockingLaptop);
            case IconParkIconKind.LockingPicture: return typeof(LockingPicture);
            case IconParkIconKind.LockingWeb: return typeof(LockingWeb);
            case IconParkIconKind.Log: return typeof(Log);
            case IconParkIconKind.Login: return typeof(Login);
            case IconParkIconKind.Logout: return typeof(Logout);
            case IconParkIconKind.Lollipop: return typeof(Lollipop);
            case IconParkIconKind.LoopOnce: return typeof(LoopOnce);
            case IconParkIconKind.Lotion: return typeof(Lotion);
            case IconParkIconKind.Lotus: return typeof(Lotus);
            case IconParkIconKind.LoudlyCryingFace: return typeof(LoudlyCryingFace);
            case IconParkIconKind.LoudlyCryingFaceWhitOpenMouth: return typeof(LoudlyCryingFaceWhitOpenMouth);
            case IconParkIconKind.LoveAndHelp: return typeof(LoveAndHelp);
            case IconParkIconKind.LowerBranch: return typeof(LowerBranch);
            case IconParkIconKind.Luggage: return typeof(Luggage);
            case IconParkIconKind.Luminous: return typeof(Luminous);
            case IconParkIconKind.Lung: return typeof(Lung);
            case IconParkIconKind.MacFinder: return typeof(MacFinder);
            case IconParkIconKind.MacadamiaNut: return typeof(MacadamiaNut);
            case IconParkIconKind.Magic: return typeof(Magic);
            case IconParkIconKind.MagicHat: return typeof(MagicHat);
            case IconParkIconKind.MagicWand: return typeof(MagicWand);
            case IconParkIconKind.Magnet: return typeof(Magnet);
            case IconParkIconKind.Mail: return typeof(Mail);
            case IconParkIconKind.MailDownload: return typeof(MailDownload);
            case IconParkIconKind.MailEdit: return typeof(MailEdit);
            case IconParkIconKind.MailOpen: return typeof(MailOpen);
            case IconParkIconKind.MailPackage: return typeof(MailPackage);
            case IconParkIconKind.MailReview: return typeof(MailReview);
            case IconParkIconKind.MailUnpacking: return typeof(MailUnpacking);
            case IconParkIconKind.MaillOne: return typeof(MaillOne);
            case IconParkIconKind.Makeups: return typeof(Makeups);
            case IconParkIconKind.Male: return typeof(Male);
            case IconParkIconKind.MallBag: return typeof(MallBag);
            case IconParkIconKind.ManualGear: return typeof(ManualGear);
            case IconParkIconKind.ManyToMany: return typeof(ManyToMany);
            case IconParkIconKind.MapDistance: return typeof(MapDistance);
            case IconParkIconKind.MapDraw: return typeof(MapDraw);
            case IconParkIconKind.MapRoad: return typeof(MapRoad);
            case IconParkIconKind.MapRoadTwo: return typeof(MapRoadTwo);
            case IconParkIconKind.MapTwo: return typeof(MapTwo);
            case IconParkIconKind.Margin: return typeof(Margin);
            case IconParkIconKind.MarginOne: return typeof(MarginOne);
            case IconParkIconKind.Mark: return typeof(Mark);
            case IconParkIconKind.Market: return typeof(Market);
            case IconParkIconKind.MarketAnalysis: return typeof(MarketAnalysis);
            case IconParkIconKind.Mascara: return typeof(Mascara);
            case IconParkIconKind.Mask: return typeof(Mask);
            case IconParkIconKind.MaskOne: return typeof(MaskOne);
            case IconParkIconKind.MaskTwo: return typeof(MaskTwo);
            case IconParkIconKind.MaslowPyramids: return typeof(MaslowPyramids);
            case IconParkIconKind.MassageChair: return typeof(MassageChair);
            case IconParkIconKind.MassageChairOne: return typeof(MassageChairOne);
            case IconParkIconKind.MassageTable: return typeof(MassageTable);
            case IconParkIconKind.Master: return typeof(Master);
            case IconParkIconKind.Material: return typeof(Material);
            case IconParkIconKind.MaterialThree: return typeof(MaterialThree);
            case IconParkIconKind.MaterialTwo: return typeof(MaterialTwo);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk23(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Local => new Local(),
            IconParkIconKind.LocalPin => new LocalPin(),
            IconParkIconKind.LocalTwo => new LocalTwo(),
            IconParkIconKind.Lock => new Lock(),
            IconParkIconKind.LockOne => new LockOne(),
            IconParkIconKind.LockingComputer => new LockingComputer(),
            IconParkIconKind.LockingLaptop => new LockingLaptop(),
            IconParkIconKind.LockingPicture => new LockingPicture(),
            IconParkIconKind.LockingWeb => new LockingWeb(),
            IconParkIconKind.Log => new Log(),
            IconParkIconKind.Login => new Login(),
            IconParkIconKind.Logout => new Logout(),
            IconParkIconKind.Lollipop => new Lollipop(),
            IconParkIconKind.LoopOnce => new LoopOnce(),
            IconParkIconKind.Lotion => new Lotion(),
            IconParkIconKind.Lotus => new Lotus(),
            IconParkIconKind.LoudlyCryingFace => new LoudlyCryingFace(),
            IconParkIconKind.LoudlyCryingFaceWhitOpenMouth => new LoudlyCryingFaceWhitOpenMouth(),
            IconParkIconKind.LoveAndHelp => new LoveAndHelp(),
            IconParkIconKind.LowerBranch => new LowerBranch(),
            IconParkIconKind.Luggage => new Luggage(),
            IconParkIconKind.Luminous => new Luminous(),
            IconParkIconKind.Lung => new Lung(),
            IconParkIconKind.MacFinder => new MacFinder(),
            IconParkIconKind.MacadamiaNut => new MacadamiaNut(),
            IconParkIconKind.Magic => new Magic(),
            IconParkIconKind.MagicHat => new MagicHat(),
            IconParkIconKind.MagicWand => new MagicWand(),
            IconParkIconKind.Magnet => new Magnet(),
            IconParkIconKind.Mail => new Mail(),
            IconParkIconKind.MailDownload => new MailDownload(),
            IconParkIconKind.MailEdit => new MailEdit(),
            IconParkIconKind.MailOpen => new MailOpen(),
            IconParkIconKind.MailPackage => new MailPackage(),
            IconParkIconKind.MailReview => new MailReview(),
            IconParkIconKind.MailUnpacking => new MailUnpacking(),
            IconParkIconKind.MaillOne => new MaillOne(),
            IconParkIconKind.Makeups => new Makeups(),
            IconParkIconKind.Male => new Male(),
            IconParkIconKind.MallBag => new MallBag(),
            IconParkIconKind.ManualGear => new ManualGear(),
            IconParkIconKind.ManyToMany => new ManyToMany(),
            IconParkIconKind.MapDistance => new MapDistance(),
            IconParkIconKind.MapDraw => new MapDraw(),
            IconParkIconKind.MapRoad => new MapRoad(),
            IconParkIconKind.MapRoadTwo => new MapRoadTwo(),
            IconParkIconKind.MapTwo => new MapTwo(),
            IconParkIconKind.Margin => new Margin(),
            IconParkIconKind.MarginOne => new MarginOne(),
            IconParkIconKind.Mark => new Mark(),
            IconParkIconKind.Market => new Market(),
            IconParkIconKind.MarketAnalysis => new MarketAnalysis(),
            IconParkIconKind.Mascara => new Mascara(),
            IconParkIconKind.Mask => new Mask(),
            IconParkIconKind.MaskOne => new MaskOne(),
            IconParkIconKind.MaskTwo => new MaskTwo(),
            IconParkIconKind.MaslowPyramids => new MaslowPyramids(),
            IconParkIconKind.MassageChair => new MassageChair(),
            IconParkIconKind.MassageChairOne => new MassageChairOne(),
            IconParkIconKind.MassageTable => new MassageTable(),
            IconParkIconKind.Master => new Master(),
            IconParkIconKind.Material => new Material(),
            IconParkIconKind.MaterialThree => new MaterialThree(),
            IconParkIconKind.MaterialTwo => new MaterialTwo(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk24(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Maximum: return typeof(Maximum);
            case IconParkIconKind.Maya: return typeof(Maya);
            case IconParkIconKind.MayuraGesture: return typeof(MayuraGesture);
            case IconParkIconKind.Me: return typeof(Me);
            case IconParkIconKind.MeasuringCup: return typeof(MeasuringCup);
            case IconParkIconKind.MedalOne: return typeof(MedalOne);
            case IconParkIconKind.Mediaeditor: return typeof(Mediaeditor);
            case IconParkIconKind.MedicalBox: return typeof(MedicalBox);
            case IconParkIconKind.MedicalFiles: return typeof(MedicalFiles);
            case IconParkIconKind.MedicalMark: return typeof(MedicalMark);
            case IconParkIconKind.MedicationTime: return typeof(MedicationTime);
            case IconParkIconKind.MedicineBottle: return typeof(MedicineBottle);
            case IconParkIconKind.MedicineBottleOne: return typeof(MedicineBottleOne);
            case IconParkIconKind.MedicineChest: return typeof(MedicineChest);
            case IconParkIconKind.Memory: return typeof(Memory);
            case IconParkIconKind.MemoryCard: return typeof(MemoryCard);
            case IconParkIconKind.MemoryCardOne: return typeof(MemoryCardOne);
            case IconParkIconKind.MemoryOne: return typeof(MemoryOne);
            case IconParkIconKind.MenJacket: return typeof(MenJacket);
            case IconParkIconKind.MenuFold: return typeof(MenuFold);
            case IconParkIconKind.MenuFoldOne: return typeof(MenuFoldOne);
            case IconParkIconKind.MenuUnfold: return typeof(MenuUnfold);
            case IconParkIconKind.MenuUnfoldOne: return typeof(MenuUnfoldOne);
            case IconParkIconKind.Merge: return typeof(Merge);
            case IconParkIconKind.MergeCells: return typeof(MergeCells);
            case IconParkIconKind.Message: return typeof(Message);
            case IconParkIconKind.MessageEmoji: return typeof(MessageEmoji);
            case IconParkIconKind.MessageFailed: return typeof(MessageFailed);
            case IconParkIconKind.MessageOne: return typeof(MessageOne);
            case IconParkIconKind.MessagePrivacy: return typeof(MessagePrivacy);
            case IconParkIconKind.MessageSearch: return typeof(MessageSearch);
            case IconParkIconKind.MessageSecurity: return typeof(MessageSecurity);
            case IconParkIconKind.MessageSent: return typeof(MessageSent);
            case IconParkIconKind.MessageSuccess: return typeof(MessageSuccess);
            case IconParkIconKind.MessageUnread: return typeof(MessageUnread);
            case IconParkIconKind.Messages: return typeof(Messages);
            case IconParkIconKind.MessagesOne: return typeof(MessagesOne);
            case IconParkIconKind.MicroSd: return typeof(MicroSd);
            case IconParkIconKind.MicroSlrCamera: return typeof(MicroSlrCamera);
            case IconParkIconKind.Microphone: return typeof(Microphone);
            case IconParkIconKind.MicrophoneOne: return typeof(MicrophoneOne);
            case IconParkIconKind.Microscope: return typeof(Microscope);
            case IconParkIconKind.MicroscopeOne: return typeof(MicroscopeOne);
            case IconParkIconKind.MicrowaveOven: return typeof(MicrowaveOven);
            case IconParkIconKind.Microwaves: return typeof(Microwaves);
            case IconParkIconKind.MiddleFinger: return typeof(MiddleFinger);
            case IconParkIconKind.Milk: return typeof(Milk);
            case IconParkIconKind.MilkOne: return typeof(MilkOne);
            case IconParkIconKind.Min: return typeof(Min);
            case IconParkIconKind.MindMapping: return typeof(MindMapping);
            case IconParkIconKind.MindmapList: return typeof(MindmapList);
            case IconParkIconKind.MindmapMap: return typeof(MindmapMap);
            case IconParkIconKind.MiniSdCard: return typeof(MiniSdCard);
            case IconParkIconKind.Minus: return typeof(Minus);
            case IconParkIconKind.MinusTheBottom: return typeof(MinusTheBottom);
            case IconParkIconKind.MinusTheTop: return typeof(MinusTheTop);
            case IconParkIconKind.Mirror: return typeof(Mirror);
            case IconParkIconKind.MirrorOne: return typeof(MirrorOne);
            case IconParkIconKind.MirrorTwo: return typeof(MirrorTwo);
            case IconParkIconKind.MisalignedSemicircle: return typeof(MisalignedSemicircle);
            case IconParkIconKind.Mitsubishi: return typeof(Mitsubishi);
            case IconParkIconKind.Modify: return typeof(Modify);
            case IconParkIconKind.ModifyTwo: return typeof(ModifyTwo);
            case IconParkIconKind.Monitor: return typeof(Monitor);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk24(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Maximum => new Maximum(),
            IconParkIconKind.Maya => new Maya(),
            IconParkIconKind.MayuraGesture => new MayuraGesture(),
            IconParkIconKind.Me => new Me(),
            IconParkIconKind.MeasuringCup => new MeasuringCup(),
            IconParkIconKind.MedalOne => new MedalOne(),
            IconParkIconKind.Mediaeditor => new Mediaeditor(),
            IconParkIconKind.MedicalBox => new MedicalBox(),
            IconParkIconKind.MedicalFiles => new MedicalFiles(),
            IconParkIconKind.MedicalMark => new MedicalMark(),
            IconParkIconKind.MedicationTime => new MedicationTime(),
            IconParkIconKind.MedicineBottle => new MedicineBottle(),
            IconParkIconKind.MedicineBottleOne => new MedicineBottleOne(),
            IconParkIconKind.MedicineChest => new MedicineChest(),
            IconParkIconKind.Memory => new Memory(),
            IconParkIconKind.MemoryCard => new MemoryCard(),
            IconParkIconKind.MemoryCardOne => new MemoryCardOne(),
            IconParkIconKind.MemoryOne => new MemoryOne(),
            IconParkIconKind.MenJacket => new MenJacket(),
            IconParkIconKind.MenuFold => new MenuFold(),
            IconParkIconKind.MenuFoldOne => new MenuFoldOne(),
            IconParkIconKind.MenuUnfold => new MenuUnfold(),
            IconParkIconKind.MenuUnfoldOne => new MenuUnfoldOne(),
            IconParkIconKind.Merge => new Merge(),
            IconParkIconKind.MergeCells => new MergeCells(),
            IconParkIconKind.Message => new Message(),
            IconParkIconKind.MessageEmoji => new MessageEmoji(),
            IconParkIconKind.MessageFailed => new MessageFailed(),
            IconParkIconKind.MessageOne => new MessageOne(),
            IconParkIconKind.MessagePrivacy => new MessagePrivacy(),
            IconParkIconKind.MessageSearch => new MessageSearch(),
            IconParkIconKind.MessageSecurity => new MessageSecurity(),
            IconParkIconKind.MessageSent => new MessageSent(),
            IconParkIconKind.MessageSuccess => new MessageSuccess(),
            IconParkIconKind.MessageUnread => new MessageUnread(),
            IconParkIconKind.Messages => new Messages(),
            IconParkIconKind.MessagesOne => new MessagesOne(),
            IconParkIconKind.MicroSd => new MicroSd(),
            IconParkIconKind.MicroSlrCamera => new MicroSlrCamera(),
            IconParkIconKind.Microphone => new Microphone(),
            IconParkIconKind.MicrophoneOne => new MicrophoneOne(),
            IconParkIconKind.Microscope => new Microscope(),
            IconParkIconKind.MicroscopeOne => new MicroscopeOne(),
            IconParkIconKind.MicrowaveOven => new MicrowaveOven(),
            IconParkIconKind.Microwaves => new Microwaves(),
            IconParkIconKind.MiddleFinger => new MiddleFinger(),
            IconParkIconKind.Milk => new Milk(),
            IconParkIconKind.MilkOne => new MilkOne(),
            IconParkIconKind.Min => new Min(),
            IconParkIconKind.MindMapping => new MindMapping(),
            IconParkIconKind.MindmapList => new MindmapList(),
            IconParkIconKind.MindmapMap => new MindmapMap(),
            IconParkIconKind.MiniSdCard => new MiniSdCard(),
            IconParkIconKind.Minus => new Minus(),
            IconParkIconKind.MinusTheBottom => new MinusTheBottom(),
            IconParkIconKind.MinusTheTop => new MinusTheTop(),
            IconParkIconKind.Mirror => new Mirror(),
            IconParkIconKind.MirrorOne => new MirrorOne(),
            IconParkIconKind.MirrorTwo => new MirrorTwo(),
            IconParkIconKind.MisalignedSemicircle => new MisalignedSemicircle(),
            IconParkIconKind.Mitsubishi => new Mitsubishi(),
            IconParkIconKind.Modify => new Modify(),
            IconParkIconKind.ModifyTwo => new ModifyTwo(),
            IconParkIconKind.Monitor => new Monitor(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk25(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.MonitorCamera: return typeof(MonitorCamera);
            case IconParkIconKind.MonitorOff: return typeof(MonitorOff);
            case IconParkIconKind.MonitorOne: return typeof(MonitorOne);
            case IconParkIconKind.MonitorTwo: return typeof(MonitorTwo);
            case IconParkIconKind.Monkey: return typeof(Monkey);
            case IconParkIconKind.MonkeyZodiac: return typeof(MonkeyZodiac);
            case IconParkIconKind.MonumentOne: return typeof(MonumentOne);
            case IconParkIconKind.MonumentTwo: return typeof(MonumentTwo);
            case IconParkIconKind.Moon: return typeof(Moon);
            case IconParkIconKind.More: return typeof(More);
            case IconParkIconKind.MoreApp: return typeof(MoreApp);
            case IconParkIconKind.MoreFour: return typeof(MoreFour);
            case IconParkIconKind.MoreOne: return typeof(MoreOne);
            case IconParkIconKind.MoreThree: return typeof(MoreThree);
            case IconParkIconKind.MoreTwo: return typeof(MoreTwo);
            case IconParkIconKind.Mosaic: return typeof(Mosaic);
            case IconParkIconKind.Mountain: return typeof(Mountain);
            case IconParkIconKind.Mounted: return typeof(Mounted);
            case IconParkIconKind.Mouse: return typeof(Mouse);
            case IconParkIconKind.MouseOne: return typeof(MouseOne);
            case IconParkIconKind.MouseZodiac: return typeof(MouseZodiac);
            case IconParkIconKind.Mouth: return typeof(Mouth);
            case IconParkIconKind.Move: return typeof(Move);
            case IconParkIconKind.MoveIn: return typeof(MoveIn);
            case IconParkIconKind.MoveInOne: return typeof(MoveInOne);
            case IconParkIconKind.MoveOne: return typeof(MoveOne);
            case IconParkIconKind.Movie: return typeof(Movie);
            case IconParkIconKind.MovieBoard: return typeof(MovieBoard);
            case IconParkIconKind.MovingPicture: return typeof(MovingPicture);
            case IconParkIconKind.MultiCircular: return typeof(MultiCircular);
            case IconParkIconKind.MultiFunctionKnife: return typeof(MultiFunctionKnife);
            case IconParkIconKind.MultiPictureCarousel: return typeof(MultiPictureCarousel);
            case IconParkIconKind.MultiRectangle: return typeof(MultiRectangle);
            case IconParkIconKind.MultiRing: return typeof(MultiRing);
            case IconParkIconKind.MultiTriangular: return typeof(MultiTriangular);
            case IconParkIconKind.MultiTriangularFour: return typeof(MultiTriangularFour);
            case IconParkIconKind.MultiTriangularThree: return typeof(MultiTriangularThree);
            case IconParkIconKind.MultiTriangularTwo: return typeof(MultiTriangularTwo);
            case IconParkIconKind.Multicast: return typeof(Multicast);
            case IconParkIconKind.MultilayerSphere: return typeof(MultilayerSphere);
            case IconParkIconKind.Muscle: return typeof(Muscle);
            case IconParkIconKind.MuseumOne: return typeof(MuseumOne);
            case IconParkIconKind.MuseumTwo: return typeof(MuseumTwo);
            case IconParkIconKind.Music: return typeof(Music);
            case IconParkIconKind.MusicCd: return typeof(MusicCd);
            case IconParkIconKind.MusicList: return typeof(MusicList);
            case IconParkIconKind.MusicMenu: return typeof(MusicMenu);
            case IconParkIconKind.MusicOne: return typeof(MusicOne);
            case IconParkIconKind.MusicRhythm: return typeof(MusicRhythm);
            case IconParkIconKind.Mute: return typeof(Mute);
            case IconParkIconKind.NailPolish: return typeof(NailPolish);
            case IconParkIconKind.NailPolishOne: return typeof(NailPolishOne);
            case IconParkIconKind.Nasal: return typeof(Nasal);
            case IconParkIconKind.NaturalMode: return typeof(NaturalMode);
            case IconParkIconKind.Navigation: return typeof(Navigation);
            case IconParkIconKind.Necktie: return typeof(Necktie);
            case IconParkIconKind.Needle: return typeof(Needle);
            case IconParkIconKind.NegativeDynamics: return typeof(NegativeDynamics);
            case IconParkIconKind.NestedArrows: return typeof(NestedArrows);
            case IconParkIconKind.Nests: return typeof(Nests);
            case IconParkIconKind.NetworkDrive: return typeof(NetworkDrive);
            case IconParkIconKind.NetworkTree: return typeof(NetworkTree);
            case IconParkIconKind.Neural: return typeof(Neural);
            case IconParkIconKind.NeutralFace: return typeof(NeutralFace);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk25(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.MonitorCamera => new MonitorCamera(),
            IconParkIconKind.MonitorOff => new MonitorOff(),
            IconParkIconKind.MonitorOne => new MonitorOne(),
            IconParkIconKind.MonitorTwo => new MonitorTwo(),
            IconParkIconKind.Monkey => new Monkey(),
            IconParkIconKind.MonkeyZodiac => new MonkeyZodiac(),
            IconParkIconKind.MonumentOne => new MonumentOne(),
            IconParkIconKind.MonumentTwo => new MonumentTwo(),
            IconParkIconKind.Moon => new Moon(),
            IconParkIconKind.More => new More(),
            IconParkIconKind.MoreApp => new MoreApp(),
            IconParkIconKind.MoreFour => new MoreFour(),
            IconParkIconKind.MoreOne => new MoreOne(),
            IconParkIconKind.MoreThree => new MoreThree(),
            IconParkIconKind.MoreTwo => new MoreTwo(),
            IconParkIconKind.Mosaic => new Mosaic(),
            IconParkIconKind.Mountain => new Mountain(),
            IconParkIconKind.Mounted => new Mounted(),
            IconParkIconKind.Mouse => new Mouse(),
            IconParkIconKind.MouseOne => new MouseOne(),
            IconParkIconKind.MouseZodiac => new MouseZodiac(),
            IconParkIconKind.Mouth => new Mouth(),
            IconParkIconKind.Move => new Move(),
            IconParkIconKind.MoveIn => new MoveIn(),
            IconParkIconKind.MoveInOne => new MoveInOne(),
            IconParkIconKind.MoveOne => new MoveOne(),
            IconParkIconKind.Movie => new Movie(),
            IconParkIconKind.MovieBoard => new MovieBoard(),
            IconParkIconKind.MovingPicture => new MovingPicture(),
            IconParkIconKind.MultiCircular => new MultiCircular(),
            IconParkIconKind.MultiFunctionKnife => new MultiFunctionKnife(),
            IconParkIconKind.MultiPictureCarousel => new MultiPictureCarousel(),
            IconParkIconKind.MultiRectangle => new MultiRectangle(),
            IconParkIconKind.MultiRing => new MultiRing(),
            IconParkIconKind.MultiTriangular => new MultiTriangular(),
            IconParkIconKind.MultiTriangularFour => new MultiTriangularFour(),
            IconParkIconKind.MultiTriangularThree => new MultiTriangularThree(),
            IconParkIconKind.MultiTriangularTwo => new MultiTriangularTwo(),
            IconParkIconKind.Multicast => new Multicast(),
            IconParkIconKind.MultilayerSphere => new MultilayerSphere(),
            IconParkIconKind.Muscle => new Muscle(),
            IconParkIconKind.MuseumOne => new MuseumOne(),
            IconParkIconKind.MuseumTwo => new MuseumTwo(),
            IconParkIconKind.Music => new Music(),
            IconParkIconKind.MusicCd => new MusicCd(),
            IconParkIconKind.MusicList => new MusicList(),
            IconParkIconKind.MusicMenu => new MusicMenu(),
            IconParkIconKind.MusicOne => new MusicOne(),
            IconParkIconKind.MusicRhythm => new MusicRhythm(),
            IconParkIconKind.Mute => new Mute(),
            IconParkIconKind.NailPolish => new NailPolish(),
            IconParkIconKind.NailPolishOne => new NailPolishOne(),
            IconParkIconKind.Nasal => new Nasal(),
            IconParkIconKind.NaturalMode => new NaturalMode(),
            IconParkIconKind.Navigation => new Navigation(),
            IconParkIconKind.Necktie => new Necktie(),
            IconParkIconKind.Needle => new Needle(),
            IconParkIconKind.NegativeDynamics => new NegativeDynamics(),
            IconParkIconKind.NestedArrows => new NestedArrows(),
            IconParkIconKind.Nests => new Nests(),
            IconParkIconKind.NetworkDrive => new NetworkDrive(),
            IconParkIconKind.NetworkTree => new NetworkTree(),
            IconParkIconKind.Neural => new Neural(),
            IconParkIconKind.NeutralFace => new NeutralFace(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk26(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.NewAfferent: return typeof(NewAfferent);
            case IconParkIconKind.NewComputer: return typeof(NewComputer);
            case IconParkIconKind.NewDianziqian: return typeof(NewDianziqian);
            case IconParkIconKind.NewEfferent: return typeof(NewEfferent);
            case IconParkIconKind.NewLark: return typeof(NewLark);
            case IconParkIconKind.NewPicture: return typeof(NewPicture);
            case IconParkIconKind.Newlybuild: return typeof(Newlybuild);
            case IconParkIconKind.NewspaperFolding: return typeof(NewspaperFolding);
            case IconParkIconKind.Next: return typeof(Next);
            case IconParkIconKind.NineKey: return typeof(NineKey);
            case IconParkIconKind.NinePointsConnected: return typeof(NinePointsConnected);
            case IconParkIconKind.NintendoSwitch: return typeof(NintendoSwitch);
            case IconParkIconKind.Nmr: return typeof(Nmr);
            case IconParkIconKind.NoShooting: return typeof(NoShooting);
            case IconParkIconKind.NodeFlat: return typeof(NodeFlat);
            case IconParkIconKind.NodeRound: return typeof(NodeRound);
            case IconParkIconKind.NodeSquare: return typeof(NodeSquare);
            case IconParkIconKind.Noodles: return typeof(Noodles);
            case IconParkIconKind.Notebook: return typeof(Notebook);
            case IconParkIconKind.NotebookAndPen: return typeof(NotebookAndPen);
            case IconParkIconKind.NotebookOne: return typeof(NotebookOne);
            case IconParkIconKind.Notepad: return typeof(Notepad);
            case IconParkIconKind.Notes: return typeof(Notes);
            case IconParkIconKind.NuclearPlant: return typeof(NuclearPlant);
            case IconParkIconKind.NurseCap: return typeof(NurseCap);
            case IconParkIconKind.Nut: return typeof(Nut);
            case IconParkIconKind.Nutrition: return typeof(Nutrition);
            case IconParkIconKind.Oceanengine: return typeof(Oceanengine);
            case IconParkIconKind.Octagon: return typeof(Octagon);
            case IconParkIconKind.OffScreen: return typeof(OffScreen);
            case IconParkIconKind.OffScreenOne: return typeof(OffScreenOne);
            case IconParkIconKind.OffScreenTwo: return typeof(OffScreenTwo);
            case IconParkIconKind.OilIndustry: return typeof(OilIndustry);
            case IconParkIconKind.Okay: return typeof(Okay);
            case IconParkIconKind.One: return typeof(One);
            case IconParkIconKind.OneKey: return typeof(OneKey);
            case IconParkIconKind.OneOne: return typeof(OneOne);
            case IconParkIconKind.OneThirdRotation: return typeof(OneThirdRotation);
            case IconParkIconKind.OneToMany: return typeof(OneToMany);
            case IconParkIconKind.OneToOne: return typeof(OneToOne);
            case IconParkIconKind.Onesies: return typeof(Onesies);
            case IconParkIconKind.OnlineMeeting: return typeof(OnlineMeeting);
            case IconParkIconKind.Open: return typeof(Open);
            case IconParkIconKind.OpenAnAccount: return typeof(OpenAnAccount);
            case IconParkIconKind.OpenDoor: return typeof(OpenDoor);
            case IconParkIconKind.OpenOne: return typeof(OpenOne);
            case IconParkIconKind.Optimize: return typeof(Optimize);
            case IconParkIconKind.Optional: return typeof(Optional);
            case IconParkIconKind.Orange: return typeof(Orange);
            case IconParkIconKind.OrangeOne: return typeof(OrangeOne);
            case IconParkIconKind.OrangeStation: return typeof(OrangeStation);
            case IconParkIconKind.Order: return typeof(Order);
            case IconParkIconKind.OrderedList: return typeof(OrderedList);
            case IconParkIconKind.Orthopedic: return typeof(Orthopedic);
            case IconParkIconKind.Oscillator: return typeof(Oscillator);
            case IconParkIconKind.Other: return typeof(Other);
            case IconParkIconKind.Outbound: return typeof(Outbound);
            case IconParkIconKind.Outdoor: return typeof(Outdoor);
            case IconParkIconKind.Outgoing: return typeof(Outgoing);
            case IconParkIconKind.OvalLove: return typeof(OvalLove);
            case IconParkIconKind.OvalLoveTwo: return typeof(OvalLoveTwo);
            case IconParkIconKind.OvalOne: return typeof(OvalOne);
            case IconParkIconKind.Oven: return typeof(Oven);
            case IconParkIconKind.OvenTray: return typeof(OvenTray);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk26(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.NewAfferent => new NewAfferent(),
            IconParkIconKind.NewComputer => new NewComputer(),
            IconParkIconKind.NewDianziqian => new NewDianziqian(),
            IconParkIconKind.NewEfferent => new NewEfferent(),
            IconParkIconKind.NewLark => new NewLark(),
            IconParkIconKind.NewPicture => new NewPicture(),
            IconParkIconKind.Newlybuild => new Newlybuild(),
            IconParkIconKind.NewspaperFolding => new NewspaperFolding(),
            IconParkIconKind.Next => new Next(),
            IconParkIconKind.NineKey => new NineKey(),
            IconParkIconKind.NinePointsConnected => new NinePointsConnected(),
            IconParkIconKind.NintendoSwitch => new NintendoSwitch(),
            IconParkIconKind.Nmr => new Nmr(),
            IconParkIconKind.NoShooting => new NoShooting(),
            IconParkIconKind.NodeFlat => new NodeFlat(),
            IconParkIconKind.NodeRound => new NodeRound(),
            IconParkIconKind.NodeSquare => new NodeSquare(),
            IconParkIconKind.Noodles => new Noodles(),
            IconParkIconKind.Notebook => new Notebook(),
            IconParkIconKind.NotebookAndPen => new NotebookAndPen(),
            IconParkIconKind.NotebookOne => new NotebookOne(),
            IconParkIconKind.Notepad => new Notepad(),
            IconParkIconKind.Notes => new Notes(),
            IconParkIconKind.NuclearPlant => new NuclearPlant(),
            IconParkIconKind.NurseCap => new NurseCap(),
            IconParkIconKind.Nut => new Nut(),
            IconParkIconKind.Nutrition => new Nutrition(),
            IconParkIconKind.Oceanengine => new Oceanengine(),
            IconParkIconKind.Octagon => new Octagon(),
            IconParkIconKind.OffScreen => new OffScreen(),
            IconParkIconKind.OffScreenOne => new OffScreenOne(),
            IconParkIconKind.OffScreenTwo => new OffScreenTwo(),
            IconParkIconKind.OilIndustry => new OilIndustry(),
            IconParkIconKind.Okay => new Okay(),
            IconParkIconKind.One => new One(),
            IconParkIconKind.OneKey => new OneKey(),
            IconParkIconKind.OneOne => new OneOne(),
            IconParkIconKind.OneThirdRotation => new OneThirdRotation(),
            IconParkIconKind.OneToMany => new OneToMany(),
            IconParkIconKind.OneToOne => new OneToOne(),
            IconParkIconKind.Onesies => new Onesies(),
            IconParkIconKind.OnlineMeeting => new OnlineMeeting(),
            IconParkIconKind.Open => new Open(),
            IconParkIconKind.OpenAnAccount => new OpenAnAccount(),
            IconParkIconKind.OpenDoor => new OpenDoor(),
            IconParkIconKind.OpenOne => new OpenOne(),
            IconParkIconKind.Optimize => new Optimize(),
            IconParkIconKind.Optional => new Optional(),
            IconParkIconKind.Orange => new Orange(),
            IconParkIconKind.OrangeOne => new OrangeOne(),
            IconParkIconKind.OrangeStation => new OrangeStation(),
            IconParkIconKind.Order => new Order(),
            IconParkIconKind.OrderedList => new OrderedList(),
            IconParkIconKind.Orthopedic => new Orthopedic(),
            IconParkIconKind.Oscillator => new Oscillator(),
            IconParkIconKind.Other => new Other(),
            IconParkIconKind.Outbound => new Outbound(),
            IconParkIconKind.Outdoor => new Outdoor(),
            IconParkIconKind.Outgoing => new Outgoing(),
            IconParkIconKind.OvalLove => new OvalLove(),
            IconParkIconKind.OvalLoveTwo => new OvalLoveTwo(),
            IconParkIconKind.OvalOne => new OvalOne(),
            IconParkIconKind.Oven => new Oven(),
            IconParkIconKind.OvenTray => new OvenTray(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk27(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.OverallReduction: return typeof(OverallReduction);
            case IconParkIconKind.Owl: return typeof(Owl);
            case IconParkIconKind.Pacifier: return typeof(Pacifier);
            case IconParkIconKind.Pad: return typeof(Pad);
            case IconParkIconKind.Page: return typeof(Page);
            case IconParkIconKind.PageTemplate: return typeof(PageTemplate);
            case IconParkIconKind.Pagoda: return typeof(Pagoda);
            case IconParkIconKind.Paint: return typeof(Paint);
            case IconParkIconKind.PaintedEggshell: return typeof(PaintedEggshell);
            case IconParkIconKind.PaintedScreen: return typeof(PaintedScreen);
            case IconParkIconKind.Palace: return typeof(Palace);
            case IconParkIconKind.Palm: return typeof(Palm);
            case IconParkIconKind.Panda: return typeof(Panda);
            case IconParkIconKind.Pangle: return typeof(Pangle);
            case IconParkIconKind.PanoramaHorizontal: return typeof(PanoramaHorizontal);
            case IconParkIconKind.Panties: return typeof(Panties);
            case IconParkIconKind.PaperMoney: return typeof(PaperMoney);
            case IconParkIconKind.PaperMoneyTwo: return typeof(PaperMoneyTwo);
            case IconParkIconKind.PaperShip: return typeof(PaperShip);
            case IconParkIconKind.Paperclip: return typeof(Paperclip);
            case IconParkIconKind.Parabola: return typeof(Parabola);
            case IconParkIconKind.Parachute: return typeof(Parachute);
            case IconParkIconKind.ParagraphAlphabet: return typeof(ParagraphAlphabet);
            case IconParkIconKind.ParagraphBreak: return typeof(ParagraphBreak);
            case IconParkIconKind.ParagraphBreakTwo: return typeof(ParagraphBreakTwo);
            case IconParkIconKind.ParagraphCut: return typeof(ParagraphCut);
            case IconParkIconKind.ParagraphRectangle: return typeof(ParagraphRectangle);
            case IconParkIconKind.ParagraphRound: return typeof(ParagraphRound);
            case IconParkIconKind.ParagraphTriangle: return typeof(ParagraphTriangle);
            case IconParkIconKind.ParagraphUnfold: return typeof(ParagraphUnfold);
            case IconParkIconKind.ParallelGateway: return typeof(ParallelGateway);
            case IconParkIconKind.Parallelogram: return typeof(Parallelogram);
            case IconParkIconKind.ParentingBook: return typeof(ParentingBook);
            case IconParkIconKind.Parking: return typeof(Parking);
            case IconParkIconKind.PartyBalloon: return typeof(PartyBalloon);
            case IconParkIconKind.Passport: return typeof(Passport);
            case IconParkIconKind.PassportOne: return typeof(PassportOne);
            case IconParkIconKind.Pause: return typeof(Pause);
            case IconParkIconKind.PauseOne: return typeof(PauseOne);
            case IconParkIconKind.PayCode: return typeof(PayCode);
            case IconParkIconKind.PayCodeOne: return typeof(PayCodeOne);
            case IconParkIconKind.PayCodeTwo: return typeof(PayCodeTwo);
            case IconParkIconKind.PaymentMethod: return typeof(PaymentMethod);
            case IconParkIconKind.Paypal: return typeof(Paypal);
            case IconParkIconKind.Peach: return typeof(Peach);
            case IconParkIconKind.Pear: return typeof(Pear);
            case IconParkIconKind.PearlOfTheOrient: return typeof(PearlOfTheOrient);
            case IconParkIconKind.Peas: return typeof(Peas);
            case IconParkIconKind.Pencil: return typeof(Pencil);
            case IconParkIconKind.Pennant: return typeof(Pennant);
            case IconParkIconKind.PentagonOne: return typeof(PentagonOne);
            case IconParkIconKind.People: return typeof(People);
            case IconParkIconKind.PeopleBottom: return typeof(PeopleBottom);
            case IconParkIconKind.PeopleBottomCard: return typeof(PeopleBottomCard);
            case IconParkIconKind.PeopleDelete: return typeof(PeopleDelete);
            case IconParkIconKind.PeopleDeleteOne: return typeof(PeopleDeleteOne);
            case IconParkIconKind.PeopleDownload: return typeof(PeopleDownload);
            case IconParkIconKind.PeopleLeft: return typeof(PeopleLeft);
            case IconParkIconKind.PeopleMinus: return typeof(PeopleMinus);
            case IconParkIconKind.PeopleMinusOne: return typeof(PeopleMinusOne);
            case IconParkIconKind.PeoplePlus: return typeof(PeoplePlus);
            case IconParkIconKind.PeoplePlusOne: return typeof(PeoplePlusOne);
            case IconParkIconKind.PeopleRight: return typeof(PeopleRight);
            case IconParkIconKind.PeopleSafe: return typeof(PeopleSafe);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk27(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.OverallReduction => new OverallReduction(),
            IconParkIconKind.Owl => new Owl(),
            IconParkIconKind.Pacifier => new Pacifier(),
            IconParkIconKind.Pad => new Pad(),
            IconParkIconKind.Page => new Page(),
            IconParkIconKind.PageTemplate => new PageTemplate(),
            IconParkIconKind.Pagoda => new Pagoda(),
            IconParkIconKind.Paint => new Paint(),
            IconParkIconKind.PaintedEggshell => new PaintedEggshell(),
            IconParkIconKind.PaintedScreen => new PaintedScreen(),
            IconParkIconKind.Palace => new Palace(),
            IconParkIconKind.Palm => new Palm(),
            IconParkIconKind.Panda => new Panda(),
            IconParkIconKind.Pangle => new Pangle(),
            IconParkIconKind.PanoramaHorizontal => new PanoramaHorizontal(),
            IconParkIconKind.Panties => new Panties(),
            IconParkIconKind.PaperMoney => new PaperMoney(),
            IconParkIconKind.PaperMoneyTwo => new PaperMoneyTwo(),
            IconParkIconKind.PaperShip => new PaperShip(),
            IconParkIconKind.Paperclip => new Paperclip(),
            IconParkIconKind.Parabola => new Parabola(),
            IconParkIconKind.Parachute => new Parachute(),
            IconParkIconKind.ParagraphAlphabet => new ParagraphAlphabet(),
            IconParkIconKind.ParagraphBreak => new ParagraphBreak(),
            IconParkIconKind.ParagraphBreakTwo => new ParagraphBreakTwo(),
            IconParkIconKind.ParagraphCut => new ParagraphCut(),
            IconParkIconKind.ParagraphRectangle => new ParagraphRectangle(),
            IconParkIconKind.ParagraphRound => new ParagraphRound(),
            IconParkIconKind.ParagraphTriangle => new ParagraphTriangle(),
            IconParkIconKind.ParagraphUnfold => new ParagraphUnfold(),
            IconParkIconKind.ParallelGateway => new ParallelGateway(),
            IconParkIconKind.Parallelogram => new Parallelogram(),
            IconParkIconKind.ParentingBook => new ParentingBook(),
            IconParkIconKind.Parking => new Parking(),
            IconParkIconKind.PartyBalloon => new PartyBalloon(),
            IconParkIconKind.Passport => new Passport(),
            IconParkIconKind.PassportOne => new PassportOne(),
            IconParkIconKind.Pause => new Pause(),
            IconParkIconKind.PauseOne => new PauseOne(),
            IconParkIconKind.PayCode => new PayCode(),
            IconParkIconKind.PayCodeOne => new PayCodeOne(),
            IconParkIconKind.PayCodeTwo => new PayCodeTwo(),
            IconParkIconKind.PaymentMethod => new PaymentMethod(),
            IconParkIconKind.Paypal => new Paypal(),
            IconParkIconKind.Peach => new Peach(),
            IconParkIconKind.Pear => new Pear(),
            IconParkIconKind.PearlOfTheOrient => new PearlOfTheOrient(),
            IconParkIconKind.Peas => new Peas(),
            IconParkIconKind.Pencil => new Pencil(),
            IconParkIconKind.Pennant => new Pennant(),
            IconParkIconKind.PentagonOne => new PentagonOne(),
            IconParkIconKind.People => new People(),
            IconParkIconKind.PeopleBottom => new PeopleBottom(),
            IconParkIconKind.PeopleBottomCard => new PeopleBottomCard(),
            IconParkIconKind.PeopleDelete => new PeopleDelete(),
            IconParkIconKind.PeopleDeleteOne => new PeopleDeleteOne(),
            IconParkIconKind.PeopleDownload => new PeopleDownload(),
            IconParkIconKind.PeopleLeft => new PeopleLeft(),
            IconParkIconKind.PeopleMinus => new PeopleMinus(),
            IconParkIconKind.PeopleMinusOne => new PeopleMinusOne(),
            IconParkIconKind.PeoplePlus => new PeoplePlus(),
            IconParkIconKind.PeoplePlusOne => new PeoplePlusOne(),
            IconParkIconKind.PeopleRight => new PeopleRight(),
            IconParkIconKind.PeopleSafe => new PeopleSafe(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk28(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.PeopleSafeOne: return typeof(PeopleSafeOne);
            case IconParkIconKind.PeopleSearch: return typeof(PeopleSearch);
            case IconParkIconKind.PeopleSearchOne: return typeof(PeopleSearchOne);
            case IconParkIconKind.PeopleSpeak: return typeof(PeopleSpeak);
            case IconParkIconKind.PeopleTop: return typeof(PeopleTop);
            case IconParkIconKind.PeopleTopCard: return typeof(PeopleTopCard);
            case IconParkIconKind.PeopleUnknown: return typeof(PeopleUnknown);
            case IconParkIconKind.PeopleUpload: return typeof(PeopleUpload);
            case IconParkIconKind.Peoples: return typeof(Peoples);
            case IconParkIconKind.PeoplesTwo: return typeof(PeoplesTwo);
            case IconParkIconKind.Percentage: return typeof(Percentage);
            case IconParkIconKind.Performance: return typeof(Performance);
            case IconParkIconKind.Perfume: return typeof(Perfume);
            case IconParkIconKind.PerfumerBottle: return typeof(PerfumerBottle);
            case IconParkIconKind.Period: return typeof(Period);
            case IconParkIconKind.Permissions: return typeof(Permissions);
            case IconParkIconKind.PersonalCollection: return typeof(PersonalCollection);
            case IconParkIconKind.PersonalPrivacy: return typeof(PersonalPrivacy);
            case IconParkIconKind.Perspective: return typeof(Perspective);
            case IconParkIconKind.Pesticide: return typeof(Pesticide);
            case IconParkIconKind.Petrol: return typeof(Petrol);
            case IconParkIconKind.Phone: return typeof(Phone);
            case IconParkIconKind.PhoneBooth: return typeof(PhoneBooth);
            case IconParkIconKind.PhoneCall: return typeof(PhoneCall);
            case IconParkIconKind.PhoneIncoming: return typeof(PhoneIncoming);
            case IconParkIconKind.PhoneIncomingOne: return typeof(PhoneIncomingOne);
            case IconParkIconKind.PhoneMissed: return typeof(PhoneMissed);
            case IconParkIconKind.PhoneOff: return typeof(PhoneOff);
            case IconParkIconKind.PhoneOne: return typeof(PhoneOne);
            case IconParkIconKind.PhoneOutgoing: return typeof(PhoneOutgoing);
            case IconParkIconKind.PhoneOutgoingOne: return typeof(PhoneOutgoingOne);
            case IconParkIconKind.PhoneTelephone: return typeof(PhoneTelephone);
            case IconParkIconKind.PhoneTwo: return typeof(PhoneTwo);
            case IconParkIconKind.PhoneVideoCall: return typeof(PhoneVideoCall);
            case IconParkIconKind.Phonograph: return typeof(Phonograph);
            case IconParkIconKind.Photograph: return typeof(Photograph);
            case IconParkIconKind.Piano: return typeof(Piano);
            case IconParkIconKind.Pic: return typeof(Pic);
            case IconParkIconKind.PicOne: return typeof(PicOne);
            case IconParkIconKind.Picture: return typeof(Picture);
            case IconParkIconKind.PictureAlbum: return typeof(PictureAlbum);
            case IconParkIconKind.PictureOne: return typeof(PictureOne);
            case IconParkIconKind.Pie: return typeof(Pie);
            case IconParkIconKind.PieFive: return typeof(PieFive);
            case IconParkIconKind.PieFour: return typeof(PieFour);
            case IconParkIconKind.PieOne: return typeof(PieOne);
            case IconParkIconKind.PieSeven: return typeof(PieSeven);
            case IconParkIconKind.PieSix: return typeof(PieSix);
            case IconParkIconKind.PieThree: return typeof(PieThree);
            case IconParkIconKind.PieTwo: return typeof(PieTwo);
            case IconParkIconKind.Pig: return typeof(Pig);
            case IconParkIconKind.PigZodiac: return typeof(PigZodiac);
            case IconParkIconKind.Pigeon: return typeof(Pigeon);
            case IconParkIconKind.Pill: return typeof(Pill);
            case IconParkIconKind.Pills: return typeof(Pills);
            case IconParkIconKind.Pin: return typeof(Pin);
            case IconParkIconKind.Pineapple: return typeof(Pineapple);
            case IconParkIconKind.Pinwheel: return typeof(Pinwheel);
            case IconParkIconKind.Pisces: return typeof(Pisces);
            case IconParkIconKind.PivotTable: return typeof(PivotTable);
            case IconParkIconKind.Plan: return typeof(Plan);
            case IconParkIconKind.Planet: return typeof(Planet);
            case IconParkIconKind.PlasticSurgery: return typeof(PlasticSurgery);
            case IconParkIconKind.Platte: return typeof(Platte);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk28(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.PeopleSafeOne => new PeopleSafeOne(),
            IconParkIconKind.PeopleSearch => new PeopleSearch(),
            IconParkIconKind.PeopleSearchOne => new PeopleSearchOne(),
            IconParkIconKind.PeopleSpeak => new PeopleSpeak(),
            IconParkIconKind.PeopleTop => new PeopleTop(),
            IconParkIconKind.PeopleTopCard => new PeopleTopCard(),
            IconParkIconKind.PeopleUnknown => new PeopleUnknown(),
            IconParkIconKind.PeopleUpload => new PeopleUpload(),
            IconParkIconKind.Peoples => new Peoples(),
            IconParkIconKind.PeoplesTwo => new PeoplesTwo(),
            IconParkIconKind.Percentage => new Percentage(),
            IconParkIconKind.Performance => new Performance(),
            IconParkIconKind.Perfume => new Perfume(),
            IconParkIconKind.PerfumerBottle => new PerfumerBottle(),
            IconParkIconKind.Period => new Period(),
            IconParkIconKind.Permissions => new Permissions(),
            IconParkIconKind.PersonalCollection => new PersonalCollection(),
            IconParkIconKind.PersonalPrivacy => new PersonalPrivacy(),
            IconParkIconKind.Perspective => new Perspective(),
            IconParkIconKind.Pesticide => new Pesticide(),
            IconParkIconKind.Petrol => new Petrol(),
            IconParkIconKind.Phone => new Phone(),
            IconParkIconKind.PhoneBooth => new PhoneBooth(),
            IconParkIconKind.PhoneCall => new PhoneCall(),
            IconParkIconKind.PhoneIncoming => new PhoneIncoming(),
            IconParkIconKind.PhoneIncomingOne => new PhoneIncomingOne(),
            IconParkIconKind.PhoneMissed => new PhoneMissed(),
            IconParkIconKind.PhoneOff => new PhoneOff(),
            IconParkIconKind.PhoneOne => new PhoneOne(),
            IconParkIconKind.PhoneOutgoing => new PhoneOutgoing(),
            IconParkIconKind.PhoneOutgoingOne => new PhoneOutgoingOne(),
            IconParkIconKind.PhoneTelephone => new PhoneTelephone(),
            IconParkIconKind.PhoneTwo => new PhoneTwo(),
            IconParkIconKind.PhoneVideoCall => new PhoneVideoCall(),
            IconParkIconKind.Phonograph => new Phonograph(),
            IconParkIconKind.Photograph => new Photograph(),
            IconParkIconKind.Piano => new Piano(),
            IconParkIconKind.Pic => new Pic(),
            IconParkIconKind.PicOne => new PicOne(),
            IconParkIconKind.Picture => new Picture(),
            IconParkIconKind.PictureAlbum => new PictureAlbum(),
            IconParkIconKind.PictureOne => new PictureOne(),
            IconParkIconKind.Pie => new Pie(),
            IconParkIconKind.PieFive => new PieFive(),
            IconParkIconKind.PieFour => new PieFour(),
            IconParkIconKind.PieOne => new PieOne(),
            IconParkIconKind.PieSeven => new PieSeven(),
            IconParkIconKind.PieSix => new PieSix(),
            IconParkIconKind.PieThree => new PieThree(),
            IconParkIconKind.PieTwo => new PieTwo(),
            IconParkIconKind.Pig => new Pig(),
            IconParkIconKind.PigZodiac => new PigZodiac(),
            IconParkIconKind.Pigeon => new Pigeon(),
            IconParkIconKind.Pill => new Pill(),
            IconParkIconKind.Pills => new Pills(),
            IconParkIconKind.Pin => new Pin(),
            IconParkIconKind.Pineapple => new Pineapple(),
            IconParkIconKind.Pinwheel => new Pinwheel(),
            IconParkIconKind.Pisces => new Pisces(),
            IconParkIconKind.PivotTable => new PivotTable(),
            IconParkIconKind.Plan => new Plan(),
            IconParkIconKind.Planet => new Planet(),
            IconParkIconKind.PlasticSurgery => new PlasticSurgery(),
            IconParkIconKind.Platte => new Platte(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk29(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Play: return typeof(Play);
            case IconParkIconKind.PlayBasketball: return typeof(PlayBasketball);
            case IconParkIconKind.PlayCycle: return typeof(PlayCycle);
            case IconParkIconKind.PlayOnce: return typeof(PlayOnce);
            case IconParkIconKind.PlayOne: return typeof(PlayOne);
            case IconParkIconKind.PlayTwo: return typeof(PlayTwo);
            case IconParkIconKind.PlayVolleyball: return typeof(PlayVolleyball);
            case IconParkIconKind.PlayWrong: return typeof(PlayWrong);
            case IconParkIconKind.PlaybackProgress: return typeof(PlaybackProgress);
            case IconParkIconKind.Plug: return typeof(Plug);
            case IconParkIconKind.PlugOne: return typeof(PlugOne);
            case IconParkIconKind.Plus: return typeof(Plus);
            case IconParkIconKind.PlusCross: return typeof(PlusCross);
            case IconParkIconKind.Point: return typeof(Point);
            case IconParkIconKind.PointOut: return typeof(PointOut);
            case IconParkIconKind.PokeballOne: return typeof(PokeballOne);
            case IconParkIconKind.Poker: return typeof(Poker);
            case IconParkIconKind.Popcorn: return typeof(Popcorn);
            case IconParkIconKind.PopcornOne: return typeof(PopcornOne);
            case IconParkIconKind.PositiveDynamics: return typeof(PositiveDynamics);
            case IconParkIconKind.Pot: return typeof(Pot);
            case IconParkIconKind.Potentiometer: return typeof(Potentiometer);
            case IconParkIconKind.Pound: return typeof(Pound);
            case IconParkIconKind.PoundSign: return typeof(PoundSign);
            case IconParkIconKind.PoutingFace: return typeof(PoutingFace);
            case IconParkIconKind.Powder: return typeof(Powder);
            case IconParkIconKind.Power: return typeof(Power);
            case IconParkIconKind.PowerSupply: return typeof(PowerSupply);
            case IconParkIconKind.PowerSupplyOne: return typeof(PowerSupplyOne);
            case IconParkIconKind.Powerpoint: return typeof(Powerpoint);
            case IconParkIconKind.Ppt: return typeof(Ppt);
            case IconParkIconKind.PregnantWomen: return typeof(PregnantWomen);
            case IconParkIconKind.Preschool: return typeof(Preschool);
            case IconParkIconKind.Prescription: return typeof(Prescription);
            case IconParkIconKind.Press: return typeof(Press);
            case IconParkIconKind.PreviewClose: return typeof(PreviewClose);
            case IconParkIconKind.PreviewCloseOne: return typeof(PreviewCloseOne);
            case IconParkIconKind.PreviewOpen: return typeof(PreviewOpen);
            case IconParkIconKind.Printer: return typeof(Printer);
            case IconParkIconKind.PrinterOne: return typeof(PrinterOne);
            case IconParkIconKind.PrinterTwo: return typeof(PrinterTwo);
            case IconParkIconKind.Prison: return typeof(Prison);
            case IconParkIconKind.ProcessLine: return typeof(ProcessLine);
            case IconParkIconKind.Projector: return typeof(Projector);
            case IconParkIconKind.ProjectorOne: return typeof(ProjectorOne);
            case IconParkIconKind.ProjectorThree: return typeof(ProjectorThree);
            case IconParkIconKind.ProjectorTwo: return typeof(ProjectorTwo);
            case IconParkIconKind.ProportionalScaling: return typeof(ProportionalScaling);
            case IconParkIconKind.Protect: return typeof(Protect);
            case IconParkIconKind.Protection: return typeof(Protection);
            case IconParkIconKind.PublicToilet: return typeof(PublicToilet);
            case IconParkIconKind.PullDoor: return typeof(PullDoor);
            case IconParkIconKind.PullRequests: return typeof(PullRequests);
            case IconParkIconKind.Pumpkin: return typeof(Pumpkin);
            case IconParkIconKind.PureNatural: return typeof(PureNatural);
            case IconParkIconKind.PushDoor: return typeof(PushDoor);
            case IconParkIconKind.Pushpin: return typeof(Pushpin);
            case IconParkIconKind.Puzzle: return typeof(Puzzle);
            case IconParkIconKind.Pyramid: return typeof(Pyramid);
            case IconParkIconKind.PyramidOne: return typeof(PyramidOne);
            case IconParkIconKind.QingniaoClue: return typeof(QingniaoClue);
            case IconParkIconKind.Qiyehao: return typeof(Qiyehao);
            case IconParkIconKind.QuadrangularPyramid: return typeof(QuadrangularPyramid);
            case IconParkIconKind.Quadrilateral: return typeof(Quadrilateral);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk29(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Play => new Play(),
            IconParkIconKind.PlayBasketball => new PlayBasketball(),
            IconParkIconKind.PlayCycle => new PlayCycle(),
            IconParkIconKind.PlayOnce => new PlayOnce(),
            IconParkIconKind.PlayOne => new PlayOne(),
            IconParkIconKind.PlayTwo => new PlayTwo(),
            IconParkIconKind.PlayVolleyball => new PlayVolleyball(),
            IconParkIconKind.PlayWrong => new PlayWrong(),
            IconParkIconKind.PlaybackProgress => new PlaybackProgress(),
            IconParkIconKind.Plug => new Plug(),
            IconParkIconKind.PlugOne => new PlugOne(),
            IconParkIconKind.Plus => new Plus(),
            IconParkIconKind.PlusCross => new PlusCross(),
            IconParkIconKind.Point => new Point(),
            IconParkIconKind.PointOut => new PointOut(),
            IconParkIconKind.PokeballOne => new PokeballOne(),
            IconParkIconKind.Poker => new Poker(),
            IconParkIconKind.Popcorn => new Popcorn(),
            IconParkIconKind.PopcornOne => new PopcornOne(),
            IconParkIconKind.PositiveDynamics => new PositiveDynamics(),
            IconParkIconKind.Pot => new Pot(),
            IconParkIconKind.Potentiometer => new Potentiometer(),
            IconParkIconKind.Pound => new Pound(),
            IconParkIconKind.PoundSign => new PoundSign(),
            IconParkIconKind.PoutingFace => new PoutingFace(),
            IconParkIconKind.Powder => new Powder(),
            IconParkIconKind.Power => new Power(),
            IconParkIconKind.PowerSupply => new PowerSupply(),
            IconParkIconKind.PowerSupplyOne => new PowerSupplyOne(),
            IconParkIconKind.Powerpoint => new Powerpoint(),
            IconParkIconKind.Ppt => new Ppt(),
            IconParkIconKind.PregnantWomen => new PregnantWomen(),
            IconParkIconKind.Preschool => new Preschool(),
            IconParkIconKind.Prescription => new Prescription(),
            IconParkIconKind.Press => new Press(),
            IconParkIconKind.PreviewClose => new PreviewClose(),
            IconParkIconKind.PreviewCloseOne => new PreviewCloseOne(),
            IconParkIconKind.PreviewOpen => new PreviewOpen(),
            IconParkIconKind.Printer => new Printer(),
            IconParkIconKind.PrinterOne => new PrinterOne(),
            IconParkIconKind.PrinterTwo => new PrinterTwo(),
            IconParkIconKind.Prison => new Prison(),
            IconParkIconKind.ProcessLine => new ProcessLine(),
            IconParkIconKind.Projector => new Projector(),
            IconParkIconKind.ProjectorOne => new ProjectorOne(),
            IconParkIconKind.ProjectorThree => new ProjectorThree(),
            IconParkIconKind.ProjectorTwo => new ProjectorTwo(),
            IconParkIconKind.ProportionalScaling => new ProportionalScaling(),
            IconParkIconKind.Protect => new Protect(),
            IconParkIconKind.Protection => new Protection(),
            IconParkIconKind.PublicToilet => new PublicToilet(),
            IconParkIconKind.PullDoor => new PullDoor(),
            IconParkIconKind.PullRequests => new PullRequests(),
            IconParkIconKind.Pumpkin => new Pumpkin(),
            IconParkIconKind.PureNatural => new PureNatural(),
            IconParkIconKind.PushDoor => new PushDoor(),
            IconParkIconKind.Pushpin => new Pushpin(),
            IconParkIconKind.Puzzle => new Puzzle(),
            IconParkIconKind.Pyramid => new Pyramid(),
            IconParkIconKind.PyramidOne => new PyramidOne(),
            IconParkIconKind.QingniaoClue => new QingniaoClue(),
            IconParkIconKind.Qiyehao => new Qiyehao(),
            IconParkIconKind.QuadrangularPyramid => new QuadrangularPyramid(),
            IconParkIconKind.Quadrilateral => new Quadrilateral(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk30(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Quote: return typeof(Quote);
            case IconParkIconKind.Rabbit: return typeof(Rabbit);
            case IconParkIconKind.RabbitZodiac: return typeof(RabbitZodiac);
            case IconParkIconKind.Radar: return typeof(Radar);
            case IconParkIconKind.RadarChart: return typeof(RadarChart);
            case IconParkIconKind.RadarThree: return typeof(RadarThree);
            case IconParkIconKind.RadarTwo: return typeof(RadarTwo);
            case IconParkIconKind.Radiation: return typeof(Radiation);
            case IconParkIconKind.Radio: return typeof(Radio);
            case IconParkIconKind.RadioNanny: return typeof(RadioNanny);
            case IconParkIconKind.RadioOne: return typeof(RadioOne);
            case IconParkIconKind.RadioTwo: return typeof(RadioTwo);
            case IconParkIconKind.Radish: return typeof(Radish);
            case IconParkIconKind.RadishOne: return typeof(RadishOne);
            case IconParkIconKind.Railway: return typeof(Railway);
            case IconParkIconKind.Ranking: return typeof(Ranking);
            case IconParkIconKind.RankingList: return typeof(RankingList);
            case IconParkIconKind.Rattle: return typeof(Rattle);
            case IconParkIconKind.RattleOne: return typeof(RattleOne);
            case IconParkIconKind.Razor: return typeof(Razor);
            case IconParkIconKind.ReadBook: return typeof(ReadBook);
            case IconParkIconKind.Receive: return typeof(Receive);
            case IconParkIconKind.Receiver: return typeof(Receiver);
            case IconParkIconKind.RecentViewsSort: return typeof(RecentViewsSort);
            case IconParkIconKind.Record: return typeof(Record);
            case IconParkIconKind.RecordDisc: return typeof(RecordDisc);
            case IconParkIconKind.RecordPlayer: return typeof(RecordPlayer);
            case IconParkIconKind.Rectangle: return typeof(Rectangle);
            case IconParkIconKind.RectangleOne: return typeof(RectangleOne);
            case IconParkIconKind.RectangleSmall: return typeof(RectangleSmall);
            case IconParkIconKind.RectangleTear: return typeof(RectangleTear);
            case IconParkIconKind.RectangleX: return typeof(RectangleX);
            case IconParkIconKind.RectangularCircularConnection: return typeof(RectangularCircularConnection);
            case IconParkIconKind.RectangularCircularSeparation: return typeof(RectangularCircularSeparation);
            case IconParkIconKind.RectangularVertebra: return typeof(RectangularVertebra);
            case IconParkIconKind.RecycleBin: return typeof(RecycleBin);
            case IconParkIconKind.Recycling: return typeof(Recycling);
            case IconParkIconKind.RecyclingPool: return typeof(RecyclingPool);
            case IconParkIconKind.RedCross: return typeof(RedCross);
            case IconParkIconKind.RedEnvelope: return typeof(RedEnvelope);
            case IconParkIconKind.RedEnvelopes: return typeof(RedEnvelopes);
            case IconParkIconKind.Redo: return typeof(Redo);
            case IconParkIconKind.Reduce: return typeof(Reduce);
            case IconParkIconKind.ReduceDecimalPlaces: return typeof(ReduceDecimalPlaces);
            case IconParkIconKind.ReduceOne: return typeof(ReduceOne);
            case IconParkIconKind.ReduceTwo: return typeof(ReduceTwo);
            case IconParkIconKind.ReduceUser: return typeof(ReduceUser);
            case IconParkIconKind.Reel: return typeof(Reel);
            case IconParkIconKind.Refraction: return typeof(Refraction);
            case IconParkIconKind.Refresh: return typeof(Refresh);
            case IconParkIconKind.RefreshOne: return typeof(RefreshOne);
            case IconParkIconKind.Refrigerator: return typeof(Refrigerator);
            case IconParkIconKind.Reject: return typeof(Reject);
            case IconParkIconKind.RelationalGraph: return typeof(RelationalGraph);
            case IconParkIconKind.RelievedFace: return typeof(RelievedFace);
            case IconParkIconKind.Reload: return typeof(Reload);
            case IconParkIconKind.Remind: return typeof(Remind);
            case IconParkIconKind.RemindDisable: return typeof(RemindDisable);
            case IconParkIconKind.RemoteControl: return typeof(RemoteControl);
            case IconParkIconKind.RemoteControlOne: return typeof(RemoteControlOne);
            case IconParkIconKind.Renal: return typeof(Renal);
            case IconParkIconKind.Renault: return typeof(Renault);
            case IconParkIconKind.Repair: return typeof(Repair);
            case IconParkIconKind.ReplayFive: return typeof(ReplayFive);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk30(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Quote => new Quote(),
            IconParkIconKind.Rabbit => new Rabbit(),
            IconParkIconKind.RabbitZodiac => new RabbitZodiac(),
            IconParkIconKind.Radar => new Radar(),
            IconParkIconKind.RadarChart => new RadarChart(),
            IconParkIconKind.RadarThree => new RadarThree(),
            IconParkIconKind.RadarTwo => new RadarTwo(),
            IconParkIconKind.Radiation => new Radiation(),
            IconParkIconKind.Radio => new Radio(),
            IconParkIconKind.RadioNanny => new RadioNanny(),
            IconParkIconKind.RadioOne => new RadioOne(),
            IconParkIconKind.RadioTwo => new RadioTwo(),
            IconParkIconKind.Radish => new Radish(),
            IconParkIconKind.RadishOne => new RadishOne(),
            IconParkIconKind.Railway => new Railway(),
            IconParkIconKind.Ranking => new Ranking(),
            IconParkIconKind.RankingList => new RankingList(),
            IconParkIconKind.Rattle => new Rattle(),
            IconParkIconKind.RattleOne => new RattleOne(),
            IconParkIconKind.Razor => new Razor(),
            IconParkIconKind.ReadBook => new ReadBook(),
            IconParkIconKind.Receive => new Receive(),
            IconParkIconKind.Receiver => new Receiver(),
            IconParkIconKind.RecentViewsSort => new RecentViewsSort(),
            IconParkIconKind.Record => new Record(),
            IconParkIconKind.RecordDisc => new RecordDisc(),
            IconParkIconKind.RecordPlayer => new RecordPlayer(),
            IconParkIconKind.Rectangle => new Rectangle(),
            IconParkIconKind.RectangleOne => new RectangleOne(),
            IconParkIconKind.RectangleSmall => new RectangleSmall(),
            IconParkIconKind.RectangleTear => new RectangleTear(),
            IconParkIconKind.RectangleX => new RectangleX(),
            IconParkIconKind.RectangularCircularConnection => new RectangularCircularConnection(),
            IconParkIconKind.RectangularCircularSeparation => new RectangularCircularSeparation(),
            IconParkIconKind.RectangularVertebra => new RectangularVertebra(),
            IconParkIconKind.RecycleBin => new RecycleBin(),
            IconParkIconKind.Recycling => new Recycling(),
            IconParkIconKind.RecyclingPool => new RecyclingPool(),
            IconParkIconKind.RedCross => new RedCross(),
            IconParkIconKind.RedEnvelope => new RedEnvelope(),
            IconParkIconKind.RedEnvelopes => new RedEnvelopes(),
            IconParkIconKind.Redo => new Redo(),
            IconParkIconKind.Reduce => new Reduce(),
            IconParkIconKind.ReduceDecimalPlaces => new ReduceDecimalPlaces(),
            IconParkIconKind.ReduceOne => new ReduceOne(),
            IconParkIconKind.ReduceTwo => new ReduceTwo(),
            IconParkIconKind.ReduceUser => new ReduceUser(),
            IconParkIconKind.Reel => new Reel(),
            IconParkIconKind.Refraction => new Refraction(),
            IconParkIconKind.Refresh => new Refresh(),
            IconParkIconKind.RefreshOne => new RefreshOne(),
            IconParkIconKind.Refrigerator => new Refrigerator(),
            IconParkIconKind.Reject => new Reject(),
            IconParkIconKind.RelationalGraph => new RelationalGraph(),
            IconParkIconKind.RelievedFace => new RelievedFace(),
            IconParkIconKind.Reload => new Reload(),
            IconParkIconKind.Remind => new Remind(),
            IconParkIconKind.RemindDisable => new RemindDisable(),
            IconParkIconKind.RemoteControl => new RemoteControl(),
            IconParkIconKind.RemoteControlOne => new RemoteControlOne(),
            IconParkIconKind.Renal => new Renal(),
            IconParkIconKind.Renault => new Renault(),
            IconParkIconKind.Repair => new Repair(),
            IconParkIconKind.ReplayFive => new ReplayFive(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk31(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.ReplayMusic: return typeof(ReplayMusic);
            case IconParkIconKind.Report: return typeof(Report);
            case IconParkIconKind.Repositioning: return typeof(Repositioning);
            case IconParkIconKind.Resistor: return typeof(Resistor);
            case IconParkIconKind.Respect: return typeof(Respect);
            case IconParkIconKind.Resting: return typeof(Resting);
            case IconParkIconKind.RetroBag: return typeof(RetroBag);
            case IconParkIconKind.Return: return typeof(Return);
            case IconParkIconKind.ReverseLens: return typeof(ReverseLens);
            case IconParkIconKind.ReverseLensOne: return typeof(ReverseLensOne);
            case IconParkIconKind.ReverseOperationIn: return typeof(ReverseOperationIn);
            case IconParkIconKind.ReverseOperationOut: return typeof(ReverseOperationOut);
            case IconParkIconKind.ReverseRotation: return typeof(ReverseRotation);
            case IconParkIconKind.Rice: return typeof(Rice);
            case IconParkIconKind.Riding: return typeof(Riding);
            case IconParkIconKind.RidingOne: return typeof(RidingOne);
            case IconParkIconKind.Right: return typeof(Right);
            case IconParkIconKind.RightAngle: return typeof(RightAngle);
            case IconParkIconKind.RightBar: return typeof(RightBar);
            case IconParkIconKind.RightBranch: return typeof(RightBranch);
            case IconParkIconKind.RightBranchOne: return typeof(RightBranchOne);
            case IconParkIconKind.RightBranchTwo: return typeof(RightBranchTwo);
            case IconParkIconKind.RightC: return typeof(RightC);
            case IconParkIconKind.RightExpand: return typeof(RightExpand);
            case IconParkIconKind.RightOne: return typeof(RightOne);
            case IconParkIconKind.RightRun: return typeof(RightRun);
            case IconParkIconKind.RightSmall: return typeof(RightSmall);
            case IconParkIconKind.RightSmallDown: return typeof(RightSmallDown);
            case IconParkIconKind.RightSmallUp: return typeof(RightSmallUp);
            case IconParkIconKind.RightSquare: return typeof(RightSquare);
            case IconParkIconKind.RightTwo: return typeof(RightTwo);
            case IconParkIconKind.RightUser: return typeof(RightUser);
            case IconParkIconKind.Ring: return typeof(Ring);
            case IconParkIconKind.RingOne: return typeof(RingOne);
            case IconParkIconKind.Rings: return typeof(Rings);
            case IconParkIconKind.Ripple: return typeof(Ripple);
            case IconParkIconKind.Road: return typeof(Road);
            case IconParkIconKind.RoadCone: return typeof(RoadCone);
            case IconParkIconKind.RoadOne: return typeof(RoadOne);
            case IconParkIconKind.RoadSign: return typeof(RoadSign);
            case IconParkIconKind.RoadSignBoth: return typeof(RoadSignBoth);
            case IconParkIconKind.Robot: return typeof(Robot);
            case IconParkIconKind.RobotOne: return typeof(RobotOne);
            case IconParkIconKind.RobotTwo: return typeof(RobotTwo);
            case IconParkIconKind.Rock: return typeof(Rock);
            case IconParkIconKind.RockGesture: return typeof(RockGesture);
            case IconParkIconKind.Rocket: return typeof(Rocket);
            case IconParkIconKind.RocketOne: return typeof(RocketOne);
            case IconParkIconKind.RockingHorse: return typeof(RockingHorse);
            case IconParkIconKind.Rollerskates: return typeof(Rollerskates);
            case IconParkIconKind.Romper: return typeof(Romper);
            case IconParkIconKind.RopeSkipping: return typeof(RopeSkipping);
            case IconParkIconKind.RopeSkippingOne: return typeof(RopeSkippingOne);
            case IconParkIconKind.Rotate: return typeof(Rotate);
            case IconParkIconKind.RotateOne: return typeof(RotateOne);
            case IconParkIconKind.RotatingAdd: return typeof(RotatingAdd);
            case IconParkIconKind.RotatingForward: return typeof(RotatingForward);
            case IconParkIconKind.Rotation: return typeof(Rotation);
            case IconParkIconKind.RotationHorizontal: return typeof(RotationHorizontal);
            case IconParkIconKind.RotationOne: return typeof(RotationOne);
            case IconParkIconKind.RotationVertical: return typeof(RotationVertical);
            case IconParkIconKind.Round: return typeof(Round);
            case IconParkIconKind.RoundCaliper: return typeof(RoundCaliper);
            case IconParkIconKind.RoundDistortion: return typeof(RoundDistortion);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk31(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.ReplayMusic => new ReplayMusic(),
            IconParkIconKind.Report => new Report(),
            IconParkIconKind.Repositioning => new Repositioning(),
            IconParkIconKind.Resistor => new Resistor(),
            IconParkIconKind.Respect => new Respect(),
            IconParkIconKind.Resting => new Resting(),
            IconParkIconKind.RetroBag => new RetroBag(),
            IconParkIconKind.Return => new Return(),
            IconParkIconKind.ReverseLens => new ReverseLens(),
            IconParkIconKind.ReverseLensOne => new ReverseLensOne(),
            IconParkIconKind.ReverseOperationIn => new ReverseOperationIn(),
            IconParkIconKind.ReverseOperationOut => new ReverseOperationOut(),
            IconParkIconKind.ReverseRotation => new ReverseRotation(),
            IconParkIconKind.Rice => new Rice(),
            IconParkIconKind.Riding => new Riding(),
            IconParkIconKind.RidingOne => new RidingOne(),
            IconParkIconKind.Right => new Right(),
            IconParkIconKind.RightAngle => new RightAngle(),
            IconParkIconKind.RightBar => new RightBar(),
            IconParkIconKind.RightBranch => new RightBranch(),
            IconParkIconKind.RightBranchOne => new RightBranchOne(),
            IconParkIconKind.RightBranchTwo => new RightBranchTwo(),
            IconParkIconKind.RightC => new RightC(),
            IconParkIconKind.RightExpand => new RightExpand(),
            IconParkIconKind.RightOne => new RightOne(),
            IconParkIconKind.RightRun => new RightRun(),
            IconParkIconKind.RightSmall => new RightSmall(),
            IconParkIconKind.RightSmallDown => new RightSmallDown(),
            IconParkIconKind.RightSmallUp => new RightSmallUp(),
            IconParkIconKind.RightSquare => new RightSquare(),
            IconParkIconKind.RightTwo => new RightTwo(),
            IconParkIconKind.RightUser => new RightUser(),
            IconParkIconKind.Ring => new Ring(),
            IconParkIconKind.RingOne => new RingOne(),
            IconParkIconKind.Rings => new Rings(),
            IconParkIconKind.Ripple => new Ripple(),
            IconParkIconKind.Road => new Road(),
            IconParkIconKind.RoadCone => new RoadCone(),
            IconParkIconKind.RoadOne => new RoadOne(),
            IconParkIconKind.RoadSign => new RoadSign(),
            IconParkIconKind.RoadSignBoth => new RoadSignBoth(),
            IconParkIconKind.Robot => new Robot(),
            IconParkIconKind.RobotOne => new RobotOne(),
            IconParkIconKind.RobotTwo => new RobotTwo(),
            IconParkIconKind.Rock => new Rock(),
            IconParkIconKind.RockGesture => new RockGesture(),
            IconParkIconKind.Rocket => new Rocket(),
            IconParkIconKind.RocketOne => new RocketOne(),
            IconParkIconKind.RockingHorse => new RockingHorse(),
            IconParkIconKind.Rollerskates => new Rollerskates(),
            IconParkIconKind.Romper => new Romper(),
            IconParkIconKind.RopeSkipping => new RopeSkipping(),
            IconParkIconKind.RopeSkippingOne => new RopeSkippingOne(),
            IconParkIconKind.Rotate => new Rotate(),
            IconParkIconKind.RotateOne => new RotateOne(),
            IconParkIconKind.RotatingAdd => new RotatingAdd(),
            IconParkIconKind.RotatingForward => new RotatingForward(),
            IconParkIconKind.Rotation => new Rotation(),
            IconParkIconKind.RotationHorizontal => new RotationHorizontal(),
            IconParkIconKind.RotationOne => new RotationOne(),
            IconParkIconKind.RotationVertical => new RotationVertical(),
            IconParkIconKind.Round => new Round(),
            IconParkIconKind.RoundCaliper => new RoundCaliper(),
            IconParkIconKind.RoundDistortion => new RoundDistortion(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk32(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.RoundMask: return typeof(RoundMask);
            case IconParkIconKind.RoundSocket: return typeof(RoundSocket);
            case IconParkIconKind.RoundTrip: return typeof(RoundTrip);
            case IconParkIconKind.Router: return typeof(Router);
            case IconParkIconKind.RouterOne: return typeof(RouterOne);
            case IconParkIconKind.RowHeight: return typeof(RowHeight);
            case IconParkIconKind.Rowing: return typeof(Rowing);
            case IconParkIconKind.RsMale: return typeof(RsMale);
            case IconParkIconKind.Rss: return typeof(Rss);
            case IconParkIconKind.Rugby: return typeof(Rugby);
            case IconParkIconKind.RugbyOne: return typeof(RugbyOne);
            case IconParkIconKind.RuleTwo: return typeof(RuleTwo);
            case IconParkIconKind.Ruler: return typeof(Ruler);
            case IconParkIconKind.RulerOne: return typeof(RulerOne);
            case IconParkIconKind.RunLeft: return typeof(RunLeft);
            case IconParkIconKind.STurnDown: return typeof(STurnDown);
            case IconParkIconKind.STurnLeft: return typeof(STurnLeft);
            case IconParkIconKind.STurnRight: return typeof(STurnRight);
            case IconParkIconKind.STurnUp: return typeof(STurnUp);
            case IconParkIconKind.SafeRetrieval: return typeof(SafeRetrieval);
            case IconParkIconKind.Sagittarius: return typeof(Sagittarius);
            case IconParkIconKind.Sailboat: return typeof(Sailboat);
            case IconParkIconKind.SailboatOne: return typeof(SailboatOne);
            case IconParkIconKind.Sailing: return typeof(Sailing);
            case IconParkIconKind.SalesReport: return typeof(SalesReport);
            case IconParkIconKind.Sandals: return typeof(Sandals);
            case IconParkIconKind.Sandstorm: return typeof(Sandstorm);
            case IconParkIconKind.Sandwich: return typeof(Sandwich);
            case IconParkIconKind.SandwichOne: return typeof(SandwichOne);
            case IconParkIconKind.Sapling: return typeof(Sapling);
            case IconParkIconKind.Save: return typeof(Save);
            case IconParkIconKind.SaveOne: return typeof(SaveOne);
            case IconParkIconKind.Scale: return typeof(Scale);
            case IconParkIconKind.ScaleOne: return typeof(ScaleOne);
            case IconParkIconKind.Scallion: return typeof(Scallion);
            case IconParkIconKind.Scan: return typeof(Scan);
            case IconParkIconKind.ScanCode: return typeof(ScanCode);
            case IconParkIconKind.ScanSetting: return typeof(ScanSetting);
            case IconParkIconKind.Scanning: return typeof(Scanning);
            case IconParkIconKind.ScanningTwo: return typeof(ScanningTwo);
            case IconParkIconKind.ScatterAlignment: return typeof(ScatterAlignment);
            case IconParkIconKind.Schedule: return typeof(Schedule);
            case IconParkIconKind.School: return typeof(School);
            case IconParkIconKind.Scissors: return typeof(Scissors);
            case IconParkIconKind.Scoreboard: return typeof(Scoreboard);
            case IconParkIconKind.Scorpio: return typeof(Scorpio);
            case IconParkIconKind.ScreenRotation: return typeof(ScreenRotation);
            case IconParkIconKind.Screenshot: return typeof(Screenshot);
            case IconParkIconKind.ScreenshotOne: return typeof(ScreenshotOne);
            case IconParkIconKind.ScreenshotTwo: return typeof(ScreenshotTwo);
            case IconParkIconKind.Screwdriver: return typeof(Screwdriver);
            case IconParkIconKind.Sd: return typeof(Sd);
            case IconParkIconKind.SdCard: return typeof(SdCard);
            case IconParkIconKind.Seal: return typeof(Seal);
            case IconParkIconKind.Search: return typeof(Search);
            case IconParkIconKind.Seat: return typeof(Seat);
            case IconParkIconKind.Security: return typeof(Security);
            case IconParkIconKind.SecurityStall: return typeof(SecurityStall);
            case IconParkIconKind.Seedling: return typeof(Seedling);
            case IconParkIconKind.Selected: return typeof(Selected);
            case IconParkIconKind.SelectedFocus: return typeof(SelectedFocus);
            case IconParkIconKind.Selfie: return typeof(Selfie);
            case IconParkIconKind.Send: return typeof(Send);
            case IconParkIconKind.SendBackward: return typeof(SendBackward);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk32(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.RoundMask => new RoundMask(),
            IconParkIconKind.RoundSocket => new RoundSocket(),
            IconParkIconKind.RoundTrip => new RoundTrip(),
            IconParkIconKind.Router => new Router(),
            IconParkIconKind.RouterOne => new RouterOne(),
            IconParkIconKind.RowHeight => new RowHeight(),
            IconParkIconKind.Rowing => new Rowing(),
            IconParkIconKind.RsMale => new RsMale(),
            IconParkIconKind.Rss => new Rss(),
            IconParkIconKind.Rugby => new Rugby(),
            IconParkIconKind.RugbyOne => new RugbyOne(),
            IconParkIconKind.RuleTwo => new RuleTwo(),
            IconParkIconKind.Ruler => new Ruler(),
            IconParkIconKind.RulerOne => new RulerOne(),
            IconParkIconKind.RunLeft => new RunLeft(),
            IconParkIconKind.STurnDown => new STurnDown(),
            IconParkIconKind.STurnLeft => new STurnLeft(),
            IconParkIconKind.STurnRight => new STurnRight(),
            IconParkIconKind.STurnUp => new STurnUp(),
            IconParkIconKind.SafeRetrieval => new SafeRetrieval(),
            IconParkIconKind.Sagittarius => new Sagittarius(),
            IconParkIconKind.Sailboat => new Sailboat(),
            IconParkIconKind.SailboatOne => new SailboatOne(),
            IconParkIconKind.Sailing => new Sailing(),
            IconParkIconKind.SalesReport => new SalesReport(),
            IconParkIconKind.Sandals => new Sandals(),
            IconParkIconKind.Sandstorm => new Sandstorm(),
            IconParkIconKind.Sandwich => new Sandwich(),
            IconParkIconKind.SandwichOne => new SandwichOne(),
            IconParkIconKind.Sapling => new Sapling(),
            IconParkIconKind.Save => new Save(),
            IconParkIconKind.SaveOne => new SaveOne(),
            IconParkIconKind.Scale => new Scale(),
            IconParkIconKind.ScaleOne => new ScaleOne(),
            IconParkIconKind.Scallion => new Scallion(),
            IconParkIconKind.Scan => new Scan(),
            IconParkIconKind.ScanCode => new ScanCode(),
            IconParkIconKind.ScanSetting => new ScanSetting(),
            IconParkIconKind.Scanning => new Scanning(),
            IconParkIconKind.ScanningTwo => new ScanningTwo(),
            IconParkIconKind.ScatterAlignment => new ScatterAlignment(),
            IconParkIconKind.Schedule => new Schedule(),
            IconParkIconKind.School => new School(),
            IconParkIconKind.Scissors => new Scissors(),
            IconParkIconKind.Scoreboard => new Scoreboard(),
            IconParkIconKind.Scorpio => new Scorpio(),
            IconParkIconKind.ScreenRotation => new ScreenRotation(),
            IconParkIconKind.Screenshot => new Screenshot(),
            IconParkIconKind.ScreenshotOne => new ScreenshotOne(),
            IconParkIconKind.ScreenshotTwo => new ScreenshotTwo(),
            IconParkIconKind.Screwdriver => new Screwdriver(),
            IconParkIconKind.Sd => new Sd(),
            IconParkIconKind.SdCard => new SdCard(),
            IconParkIconKind.Seal => new Seal(),
            IconParkIconKind.Search => new Search(),
            IconParkIconKind.Seat => new Seat(),
            IconParkIconKind.Security => new Security(),
            IconParkIconKind.SecurityStall => new SecurityStall(),
            IconParkIconKind.Seedling => new Seedling(),
            IconParkIconKind.Selected => new Selected(),
            IconParkIconKind.SelectedFocus => new SelectedFocus(),
            IconParkIconKind.Selfie => new Selfie(),
            IconParkIconKind.Send => new Send(),
            IconParkIconKind.SendBackward => new SendBackward(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk33(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.SendEmail: return typeof(SendEmail);
            case IconParkIconKind.SendOne: return typeof(SendOne);
            case IconParkIconKind.SendToBack: return typeof(SendToBack);
            case IconParkIconKind.SentToBack: return typeof(SentToBack);
            case IconParkIconKind.Seo: return typeof(Seo);
            case IconParkIconKind.SeoFolder: return typeof(SeoFolder);
            case IconParkIconKind.Server: return typeof(Server);
            case IconParkIconKind.SetOff: return typeof(SetOff);
            case IconParkIconKind.Setting: return typeof(Setting);
            case IconParkIconKind.SettingComputer: return typeof(SettingComputer);
            case IconParkIconKind.SettingConfig: return typeof(SettingConfig);
            case IconParkIconKind.SettingLaptop: return typeof(SettingLaptop);
            case IconParkIconKind.SettingOne: return typeof(SettingOne);
            case IconParkIconKind.SettingThree: return typeof(SettingThree);
            case IconParkIconKind.SettingTwo: return typeof(SettingTwo);
            case IconParkIconKind.SettingWeb: return typeof(SettingWeb);
            case IconParkIconKind.SevenKey: return typeof(SevenKey);
            case IconParkIconKind.Shade: return typeof(Shade);
            case IconParkIconKind.Shake: return typeof(Shake);
            case IconParkIconKind.Share: return typeof(Share);
            case IconParkIconKind.ShareOne: return typeof(ShareOne);
            case IconParkIconKind.ShareSys: return typeof(ShareSys);
            case IconParkIconKind.ShareThree: return typeof(ShareThree);
            case IconParkIconKind.ShareTwo: return typeof(ShareTwo);
            case IconParkIconKind.Shaver: return typeof(Shaver);
            case IconParkIconKind.ShaverOne: return typeof(ShaverOne);
            case IconParkIconKind.Shaving: return typeof(Shaving);
            case IconParkIconKind.SheepZodiac: return typeof(SheepZodiac);
            case IconParkIconKind.Shield: return typeof(Shield);
            case IconParkIconKind.ShieldAdd: return typeof(ShieldAdd);
            case IconParkIconKind.Ship: return typeof(Ship);
            case IconParkIconKind.Shop: return typeof(Shop);
            case IconParkIconKind.Shopping: return typeof(Shopping);
            case IconParkIconKind.ShoppingBag: return typeof(ShoppingBag);
            case IconParkIconKind.ShoppingBagOne: return typeof(ShoppingBagOne);
            case IconParkIconKind.ShoppingCart: return typeof(ShoppingCart);
            case IconParkIconKind.ShoppingCartAdd: return typeof(ShoppingCartAdd);
            case IconParkIconKind.ShoppingCartDel: return typeof(ShoppingCartDel);
            case IconParkIconKind.ShoppingCartOne: return typeof(ShoppingCartOne);
            case IconParkIconKind.ShoppingCartTwo: return typeof(ShoppingCartTwo);
            case IconParkIconKind.ShoppingMall: return typeof(ShoppingMall);
            case IconParkIconKind.ShortSkirt: return typeof(ShortSkirt);
            case IconParkIconKind.Shorts: return typeof(Shorts);
            case IconParkIconKind.ShoulderBag: return typeof(ShoulderBag);
            case IconParkIconKind.Shovel: return typeof(Shovel);
            case IconParkIconKind.ShovelOne: return typeof(ShovelOne);
            case IconParkIconKind.ShowerHead: return typeof(ShowerHead);
            case IconParkIconKind.Shrimp: return typeof(Shrimp);
            case IconParkIconKind.Shuffle: return typeof(Shuffle);
            case IconParkIconKind.ShuffleOne: return typeof(ShuffleOne);
            case IconParkIconKind.ShutterPriority: return typeof(ShutterPriority);
            case IconParkIconKind.Sickbed: return typeof(Sickbed);
            case IconParkIconKind.Signal: return typeof(Signal);
            case IconParkIconKind.SignalOne: return typeof(SignalOne);
            case IconParkIconKind.SignalStrength: return typeof(SignalStrength);
            case IconParkIconKind.SignalTower: return typeof(SignalTower);
            case IconParkIconKind.SignalTowerOne: return typeof(SignalTowerOne);
            case IconParkIconKind.Sim: return typeof(Sim);
            case IconParkIconKind.SimCard: return typeof(SimCard);
            case IconParkIconKind.SingleBed: return typeof(SingleBed);
            case IconParkIconKind.Sinusoid: return typeof(Sinusoid);
            case IconParkIconKind.SippyCup: return typeof(SippyCup);
            case IconParkIconKind.Six: return typeof(Six);
            case IconParkIconKind.SixCircularConnection: return typeof(SixCircularConnection);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk33(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.SendEmail => new SendEmail(),
            IconParkIconKind.SendOne => new SendOne(),
            IconParkIconKind.SendToBack => new SendToBack(),
            IconParkIconKind.SentToBack => new SentToBack(),
            IconParkIconKind.Seo => new Seo(),
            IconParkIconKind.SeoFolder => new SeoFolder(),
            IconParkIconKind.Server => new Server(),
            IconParkIconKind.SetOff => new SetOff(),
            IconParkIconKind.Setting => new Setting(),
            IconParkIconKind.SettingComputer => new SettingComputer(),
            IconParkIconKind.SettingConfig => new SettingConfig(),
            IconParkIconKind.SettingLaptop => new SettingLaptop(),
            IconParkIconKind.SettingOne => new SettingOne(),
            IconParkIconKind.SettingThree => new SettingThree(),
            IconParkIconKind.SettingTwo => new SettingTwo(),
            IconParkIconKind.SettingWeb => new SettingWeb(),
            IconParkIconKind.SevenKey => new SevenKey(),
            IconParkIconKind.Shade => new Shade(),
            IconParkIconKind.Shake => new Shake(),
            IconParkIconKind.Share => new Share(),
            IconParkIconKind.ShareOne => new ShareOne(),
            IconParkIconKind.ShareSys => new ShareSys(),
            IconParkIconKind.ShareThree => new ShareThree(),
            IconParkIconKind.ShareTwo => new ShareTwo(),
            IconParkIconKind.Shaver => new Shaver(),
            IconParkIconKind.ShaverOne => new ShaverOne(),
            IconParkIconKind.Shaving => new Shaving(),
            IconParkIconKind.SheepZodiac => new SheepZodiac(),
            IconParkIconKind.Shield => new Shield(),
            IconParkIconKind.ShieldAdd => new ShieldAdd(),
            IconParkIconKind.Ship => new Ship(),
            IconParkIconKind.Shop => new Shop(),
            IconParkIconKind.Shopping => new Shopping(),
            IconParkIconKind.ShoppingBag => new ShoppingBag(),
            IconParkIconKind.ShoppingBagOne => new ShoppingBagOne(),
            IconParkIconKind.ShoppingCart => new ShoppingCart(),
            IconParkIconKind.ShoppingCartAdd => new ShoppingCartAdd(),
            IconParkIconKind.ShoppingCartDel => new ShoppingCartDel(),
            IconParkIconKind.ShoppingCartOne => new ShoppingCartOne(),
            IconParkIconKind.ShoppingCartTwo => new ShoppingCartTwo(),
            IconParkIconKind.ShoppingMall => new ShoppingMall(),
            IconParkIconKind.ShortSkirt => new ShortSkirt(),
            IconParkIconKind.Shorts => new Shorts(),
            IconParkIconKind.ShoulderBag => new ShoulderBag(),
            IconParkIconKind.Shovel => new Shovel(),
            IconParkIconKind.ShovelOne => new ShovelOne(),
            IconParkIconKind.ShowerHead => new ShowerHead(),
            IconParkIconKind.Shrimp => new Shrimp(),
            IconParkIconKind.Shuffle => new Shuffle(),
            IconParkIconKind.ShuffleOne => new ShuffleOne(),
            IconParkIconKind.ShutterPriority => new ShutterPriority(),
            IconParkIconKind.Sickbed => new Sickbed(),
            IconParkIconKind.Signal => new Signal(),
            IconParkIconKind.SignalOne => new SignalOne(),
            IconParkIconKind.SignalStrength => new SignalStrength(),
            IconParkIconKind.SignalTower => new SignalTower(),
            IconParkIconKind.SignalTowerOne => new SignalTowerOne(),
            IconParkIconKind.Sim => new Sim(),
            IconParkIconKind.SimCard => new SimCard(),
            IconParkIconKind.SingleBed => new SingleBed(),
            IconParkIconKind.Sinusoid => new Sinusoid(),
            IconParkIconKind.SippyCup => new SippyCup(),
            IconParkIconKind.Six => new Six(),
            IconParkIconKind.SixCircularConnection => new SixCircularConnection(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk34(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.SixKey: return typeof(SixKey);
            case IconParkIconKind.SixPoints: return typeof(SixPoints);
            case IconParkIconKind.Skate: return typeof(Skate);
            case IconParkIconKind.Skates: return typeof(Skates);
            case IconParkIconKind.Skating: return typeof(Skating);
            case IconParkIconKind.Sketch: return typeof(Sketch);
            case IconParkIconKind.SkiingNordic: return typeof(SkiingNordic);
            case IconParkIconKind.Skull: return typeof(Skull);
            case IconParkIconKind.Slave: return typeof(Slave);
            case IconParkIconKind.Sleaves: return typeof(Sleaves);
            case IconParkIconKind.Sleep: return typeof(Sleep);
            case IconParkIconKind.SleepOne: return typeof(SleepOne);
            case IconParkIconKind.SleepTwo: return typeof(SleepTwo);
            case IconParkIconKind.Slide: return typeof(Slide);
            case IconParkIconKind.SlideTwo: return typeof(SlideTwo);
            case IconParkIconKind.SlidingHorizontal: return typeof(SlidingHorizontal);
            case IconParkIconKind.SlidingVertical: return typeof(SlidingVertical);
            case IconParkIconKind.SlightlyFrowningFaceWhitOpenMouth: return typeof(SlightlyFrowningFaceWhitOpenMouth);
            case IconParkIconKind.SlightlySmilingFace: return typeof(SlightlySmilingFace);
            case IconParkIconKind.Slippers: return typeof(Slippers);
            case IconParkIconKind.SlippersOne: return typeof(SlippersOne);
            case IconParkIconKind.SlyFaceWhitSmile: return typeof(SlyFaceWhitSmile);
            case IconParkIconKind.SmartOptimization: return typeof(SmartOptimization);
            case IconParkIconKind.SmilingFace: return typeof(SmilingFace);
            case IconParkIconKind.SmilingFaceWithSquintingEyes: return typeof(SmilingFaceWithSquintingEyes);
            case IconParkIconKind.Snacks: return typeof(Snacks);
            case IconParkIconKind.SnakeZodiac: return typeof(SnakeZodiac);
            case IconParkIconKind.Snow: return typeof(Snow);
            case IconParkIconKind.Snowflake: return typeof(Snowflake);
            case IconParkIconKind.Snowman: return typeof(Snowman);
            case IconParkIconKind.SoapBubble: return typeof(SoapBubble);
            case IconParkIconKind.Soccer: return typeof(Soccer);
            case IconParkIconKind.SoccerOne: return typeof(SoccerOne);
            case IconParkIconKind.Socks: return typeof(Socks);
            case IconParkIconKind.Sofa: return typeof(Sofa);
            case IconParkIconKind.SofaTwo: return typeof(SofaTwo);
            case IconParkIconKind.Softball: return typeof(Softball);
            case IconParkIconKind.SolarEnergy: return typeof(SolarEnergy);
            case IconParkIconKind.SolarEnergyOne: return typeof(SolarEnergyOne);
            case IconParkIconKind.SolidStateDisk: return typeof(SolidStateDisk);
            case IconParkIconKind.SorcererHat: return typeof(SorcererHat);
            case IconParkIconKind.Sort: return typeof(Sort);
            case IconParkIconKind.SortAmountDown: return typeof(SortAmountDown);
            case IconParkIconKind.SortAmountUp: return typeof(SortAmountUp);
            case IconParkIconKind.SortFour: return typeof(SortFour);
            case IconParkIconKind.SortOne: return typeof(SortOne);
            case IconParkIconKind.SortThree: return typeof(SortThree);
            case IconParkIconKind.SortTwo: return typeof(SortTwo);
            case IconParkIconKind.Sound: return typeof(Sound);
            case IconParkIconKind.SoundOne: return typeof(SoundOne);
            case IconParkIconKind.SoundWave: return typeof(SoundWave);
            case IconParkIconKind.SourceCode: return typeof(SourceCode);
            case IconParkIconKind.SoybeanMilkMaker: return typeof(SoybeanMilkMaker);
            case IconParkIconKind.SpaCandle: return typeof(SpaCandle);
            case IconParkIconKind.SpaceColony: return typeof(SpaceColony);
            case IconParkIconKind.Spanner: return typeof(Spanner);
            case IconParkIconKind.Speaker: return typeof(Speaker);
            case IconParkIconKind.SpeakerOne: return typeof(SpeakerOne);
            case IconParkIconKind.Speed: return typeof(Speed);
            case IconParkIconKind.SpeedOne: return typeof(SpeedOne);
            case IconParkIconKind.Sperm: return typeof(Sperm);
            case IconParkIconKind.Sphere: return typeof(Sphere);
            case IconParkIconKind.SpiderMan: return typeof(SpiderMan);
            case IconParkIconKind.Spikedshoes: return typeof(Spikedshoes);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk34(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.SixKey => new SixKey(),
            IconParkIconKind.SixPoints => new SixPoints(),
            IconParkIconKind.Skate => new Skate(),
            IconParkIconKind.Skates => new Skates(),
            IconParkIconKind.Skating => new Skating(),
            IconParkIconKind.Sketch => new Sketch(),
            IconParkIconKind.SkiingNordic => new SkiingNordic(),
            IconParkIconKind.Skull => new Skull(),
            IconParkIconKind.Slave => new Slave(),
            IconParkIconKind.Sleaves => new Sleaves(),
            IconParkIconKind.Sleep => new Sleep(),
            IconParkIconKind.SleepOne => new SleepOne(),
            IconParkIconKind.SleepTwo => new SleepTwo(),
            IconParkIconKind.Slide => new Slide(),
            IconParkIconKind.SlideTwo => new SlideTwo(),
            IconParkIconKind.SlidingHorizontal => new SlidingHorizontal(),
            IconParkIconKind.SlidingVertical => new SlidingVertical(),
            IconParkIconKind.SlightlyFrowningFaceWhitOpenMouth => new SlightlyFrowningFaceWhitOpenMouth(),
            IconParkIconKind.SlightlySmilingFace => new SlightlySmilingFace(),
            IconParkIconKind.Slippers => new Slippers(),
            IconParkIconKind.SlippersOne => new SlippersOne(),
            IconParkIconKind.SlyFaceWhitSmile => new SlyFaceWhitSmile(),
            IconParkIconKind.SmartOptimization => new SmartOptimization(),
            IconParkIconKind.SmilingFace => new SmilingFace(),
            IconParkIconKind.SmilingFaceWithSquintingEyes => new SmilingFaceWithSquintingEyes(),
            IconParkIconKind.Snacks => new Snacks(),
            IconParkIconKind.SnakeZodiac => new SnakeZodiac(),
            IconParkIconKind.Snow => new Snow(),
            IconParkIconKind.Snowflake => new Snowflake(),
            IconParkIconKind.Snowman => new Snowman(),
            IconParkIconKind.SoapBubble => new SoapBubble(),
            IconParkIconKind.Soccer => new Soccer(),
            IconParkIconKind.SoccerOne => new SoccerOne(),
            IconParkIconKind.Socks => new Socks(),
            IconParkIconKind.Sofa => new Sofa(),
            IconParkIconKind.SofaTwo => new SofaTwo(),
            IconParkIconKind.Softball => new Softball(),
            IconParkIconKind.SolarEnergy => new SolarEnergy(),
            IconParkIconKind.SolarEnergyOne => new SolarEnergyOne(),
            IconParkIconKind.SolidStateDisk => new SolidStateDisk(),
            IconParkIconKind.SorcererHat => new SorcererHat(),
            IconParkIconKind.Sort => new Sort(),
            IconParkIconKind.SortAmountDown => new SortAmountDown(),
            IconParkIconKind.SortAmountUp => new SortAmountUp(),
            IconParkIconKind.SortFour => new SortFour(),
            IconParkIconKind.SortOne => new SortOne(),
            IconParkIconKind.SortThree => new SortThree(),
            IconParkIconKind.SortTwo => new SortTwo(),
            IconParkIconKind.Sound => new Sound(),
            IconParkIconKind.SoundOne => new SoundOne(),
            IconParkIconKind.SoundWave => new SoundWave(),
            IconParkIconKind.SourceCode => new SourceCode(),
            IconParkIconKind.SoybeanMilkMaker => new SoybeanMilkMaker(),
            IconParkIconKind.SpaCandle => new SpaCandle(),
            IconParkIconKind.SpaceColony => new SpaceColony(),
            IconParkIconKind.Spanner => new Spanner(),
            IconParkIconKind.Speaker => new Speaker(),
            IconParkIconKind.SpeakerOne => new SpeakerOne(),
            IconParkIconKind.Speed => new Speed(),
            IconParkIconKind.SpeedOne => new SpeedOne(),
            IconParkIconKind.Sperm => new Sperm(),
            IconParkIconKind.Sphere => new Sphere(),
            IconParkIconKind.SpiderMan => new SpiderMan(),
            IconParkIconKind.Spikedshoes => new Spikedshoes(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk35(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.SpinningTop: return typeof(SpinningTop);
            case IconParkIconKind.Split: return typeof(Split);
            case IconParkIconKind.SplitBranch: return typeof(SplitBranch);
            case IconParkIconKind.SplitCells: return typeof(SplitCells);
            case IconParkIconKind.SplitTurnDownLeft: return typeof(SplitTurnDownLeft);
            case IconParkIconKind.SplitTurnDownRight: return typeof(SplitTurnDownRight);
            case IconParkIconKind.Spoon: return typeof(Spoon);
            case IconParkIconKind.Sport: return typeof(Sport);
            case IconParkIconKind.Sporting: return typeof(Sporting);
            case IconParkIconKind.Square: return typeof(Square);
            case IconParkIconKind.SquareSmall: return typeof(SquareSmall);
            case IconParkIconKind.Ssd: return typeof(Ssd);
            case IconParkIconKind.StackLight: return typeof(StackLight);
            case IconParkIconKind.Stamp: return typeof(Stamp);
            case IconParkIconKind.StandUp: return typeof(StandUp);
            case IconParkIconKind.Stapler: return typeof(Stapler);
            case IconParkIconKind.Star: return typeof(Star);
            case IconParkIconKind.StarOne: return typeof(StarOne);
            case IconParkIconKind.StartTimeSort: return typeof(StartTimeSort);
            case IconParkIconKind.SteeringWheel: return typeof(SteeringWheel);
            case IconParkIconKind.Steoller: return typeof(Steoller);
            case IconParkIconKind.StereoNesting: return typeof(StereoNesting);
            case IconParkIconKind.StereoOne: return typeof(StereoOne);
            case IconParkIconKind.StereoPerspective: return typeof(StereoPerspective);
            case IconParkIconKind.Stethoscope: return typeof(Stethoscope);
            case IconParkIconKind.Stickers: return typeof(Stickers);
            case IconParkIconKind.StockMarket: return typeof(StockMarket);
            case IconParkIconKind.Stopwatch: return typeof(Stopwatch);
            case IconParkIconKind.StopwatchStart: return typeof(StopwatchStart);
            case IconParkIconKind.StorageCardOne: return typeof(StorageCardOne);
            case IconParkIconKind.StorageCardTwo: return typeof(StorageCardTwo);
            case IconParkIconKind.StraightRazor: return typeof(StraightRazor);
            case IconParkIconKind.StrawHat: return typeof(StrawHat);
            case IconParkIconKind.Stretching: return typeof(Stretching);
            case IconParkIconKind.StretchingOne: return typeof(StretchingOne);
            case IconParkIconKind.Strikethrough: return typeof(Strikethrough);
            case IconParkIconKind.Strongbox: return typeof(Strongbox);
            case IconParkIconKind.SubtractSelection: return typeof(SubtractSelection);
            case IconParkIconKind.SubtractSelectionOne: return typeof(SubtractSelectionOne);
            case IconParkIconKind.Subway: return typeof(Subway);
            case IconParkIconKind.Success: return typeof(Success);
            case IconParkIconKind.SuccessPicture: return typeof(SuccessPicture);
            case IconParkIconKind.Sum: return typeof(Sum);
            case IconParkIconKind.Sun: return typeof(Sun);
            case IconParkIconKind.SunHat: return typeof(SunHat);
            case IconParkIconKind.SunOne: return typeof(SunOne);
            case IconParkIconKind.Sunbath: return typeof(Sunbath);
            case IconParkIconKind.Sunny: return typeof(Sunny);
            case IconParkIconKind.Sunrise: return typeof(Sunrise);
            case IconParkIconKind.Sunset: return typeof(Sunset);
            case IconParkIconKind.Sunshade: return typeof(Sunshade);
            case IconParkIconKind.SurprisedFaceWithOpenBigMouth: return typeof(SurprisedFaceWithOpenBigMouth);
            case IconParkIconKind.SurprisedFaceWithOpenMouth: return typeof(SurprisedFaceWithOpenMouth);
            case IconParkIconKind.SurveillanceCameras: return typeof(SurveillanceCameras);
            case IconParkIconKind.SurveillanceCamerasOne: return typeof(SurveillanceCamerasOne);
            case IconParkIconKind.SurveillanceCamerasTwo: return typeof(SurveillanceCamerasTwo);
            case IconParkIconKind.Swallow: return typeof(Swallow);
            case IconParkIconKind.Sweater: return typeof(Sweater);
            case IconParkIconKind.SwimmingPool: return typeof(SwimmingPool);
            case IconParkIconKind.SwimmingRing: return typeof(SwimmingRing);
            case IconParkIconKind.Swimsuit: return typeof(Swimsuit);
            case IconParkIconKind.Swing: return typeof(Swing);
            case IconParkIconKind.Swipe: return typeof(Swipe);
            case IconParkIconKind.Switch: return typeof(Switch);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk35(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.SpinningTop => new SpinningTop(),
            IconParkIconKind.Split => new Split(),
            IconParkIconKind.SplitBranch => new SplitBranch(),
            IconParkIconKind.SplitCells => new SplitCells(),
            IconParkIconKind.SplitTurnDownLeft => new SplitTurnDownLeft(),
            IconParkIconKind.SplitTurnDownRight => new SplitTurnDownRight(),
            IconParkIconKind.Spoon => new Spoon(),
            IconParkIconKind.Sport => new Sport(),
            IconParkIconKind.Sporting => new Sporting(),
            IconParkIconKind.Square => new Square(),
            IconParkIconKind.SquareSmall => new SquareSmall(),
            IconParkIconKind.Ssd => new Ssd(),
            IconParkIconKind.StackLight => new StackLight(),
            IconParkIconKind.Stamp => new Stamp(),
            IconParkIconKind.StandUp => new StandUp(),
            IconParkIconKind.Stapler => new Stapler(),
            IconParkIconKind.Star => new Star(),
            IconParkIconKind.StarOne => new StarOne(),
            IconParkIconKind.StartTimeSort => new StartTimeSort(),
            IconParkIconKind.SteeringWheel => new SteeringWheel(),
            IconParkIconKind.Steoller => new Steoller(),
            IconParkIconKind.StereoNesting => new StereoNesting(),
            IconParkIconKind.StereoOne => new StereoOne(),
            IconParkIconKind.StereoPerspective => new StereoPerspective(),
            IconParkIconKind.Stethoscope => new Stethoscope(),
            IconParkIconKind.Stickers => new Stickers(),
            IconParkIconKind.StockMarket => new StockMarket(),
            IconParkIconKind.Stopwatch => new Stopwatch(),
            IconParkIconKind.StopwatchStart => new StopwatchStart(),
            IconParkIconKind.StorageCardOne => new StorageCardOne(),
            IconParkIconKind.StorageCardTwo => new StorageCardTwo(),
            IconParkIconKind.StraightRazor => new StraightRazor(),
            IconParkIconKind.StrawHat => new StrawHat(),
            IconParkIconKind.Stretching => new Stretching(),
            IconParkIconKind.StretchingOne => new StretchingOne(),
            IconParkIconKind.Strikethrough => new Strikethrough(),
            IconParkIconKind.Strongbox => new Strongbox(),
            IconParkIconKind.SubtractSelection => new SubtractSelection(),
            IconParkIconKind.SubtractSelectionOne => new SubtractSelectionOne(),
            IconParkIconKind.Subway => new Subway(),
            IconParkIconKind.Success => new Success(),
            IconParkIconKind.SuccessPicture => new SuccessPicture(),
            IconParkIconKind.Sum => new Sum(),
            IconParkIconKind.Sun => new Sun(),
            IconParkIconKind.SunHat => new SunHat(),
            IconParkIconKind.SunOne => new SunOne(),
            IconParkIconKind.Sunbath => new Sunbath(),
            IconParkIconKind.Sunny => new Sunny(),
            IconParkIconKind.Sunrise => new Sunrise(),
            IconParkIconKind.Sunset => new Sunset(),
            IconParkIconKind.Sunshade => new Sunshade(),
            IconParkIconKind.SurprisedFaceWithOpenBigMouth => new SurprisedFaceWithOpenBigMouth(),
            IconParkIconKind.SurprisedFaceWithOpenMouth => new SurprisedFaceWithOpenMouth(),
            IconParkIconKind.SurveillanceCameras => new SurveillanceCameras(),
            IconParkIconKind.SurveillanceCamerasOne => new SurveillanceCamerasOne(),
            IconParkIconKind.SurveillanceCamerasTwo => new SurveillanceCamerasTwo(),
            IconParkIconKind.Swallow => new Swallow(),
            IconParkIconKind.Sweater => new Sweater(),
            IconParkIconKind.SwimmingPool => new SwimmingPool(),
            IconParkIconKind.SwimmingRing => new SwimmingRing(),
            IconParkIconKind.Swimsuit => new Swimsuit(),
            IconParkIconKind.Swing => new Swing(),
            IconParkIconKind.Swipe => new Swipe(),
            IconParkIconKind.Switch => new Switch(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk36(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.SwitchButton: return typeof(SwitchButton);
            case IconParkIconKind.SwitchContrast: return typeof(SwitchContrast);
            case IconParkIconKind.SwitchNintendo: return typeof(SwitchNintendo);
            case IconParkIconKind.SwitchOne: return typeof(SwitchOne);
            case IconParkIconKind.SwitchThemes: return typeof(SwitchThemes);
            case IconParkIconKind.SwitchTrack: return typeof(SwitchTrack);
            case IconParkIconKind.SwitchingDone: return typeof(SwitchingDone);
            case IconParkIconKind.Symbol: return typeof(Symbol);
            case IconParkIconKind.SymbolDoubleX: return typeof(SymbolDoubleX);
            case IconParkIconKind.Symmetry: return typeof(Symmetry);
            case IconParkIconKind.Sync: return typeof(Sync);
            case IconParkIconKind.System: return typeof(System);
            case IconParkIconKind.TShirt: return typeof(TShirt);
            case IconParkIconKind.Table: return typeof(Table);
            case IconParkIconKind.TableFile: return typeof(TableFile);
            case IconParkIconKind.TableLamp: return typeof(TableLamp);
            case IconParkIconKind.TableReport: return typeof(TableReport);
            case IconParkIconKind.Tabletennis: return typeof(Tabletennis);
            case IconParkIconKind.Tag: return typeof(Tag);
            case IconParkIconKind.TagOne: return typeof(TagOne);
            case IconParkIconKind.Tailoring: return typeof(Tailoring);
            case IconParkIconKind.TailoringTwo: return typeof(TailoringTwo);
            case IconParkIconKind.TajMahal: return typeof(TajMahal);
            case IconParkIconKind.TakeOff: return typeof(TakeOff);
            case IconParkIconKind.TakeOffOne: return typeof(TakeOffOne);
            case IconParkIconKind.Taobao: return typeof(Taobao);
            case IconParkIconKind.Tape: return typeof(Tape);
            case IconParkIconKind.TapeMeasure: return typeof(TapeMeasure);
            case IconParkIconKind.Target: return typeof(Target);
            case IconParkIconKind.TargetOne: return typeof(TargetOne);
            case IconParkIconKind.TargetTwo: return typeof(TargetTwo);
            case IconParkIconKind.Taurus: return typeof(Taurus);
            case IconParkIconKind.Taxi: return typeof(Taxi);
            case IconParkIconKind.Tea: return typeof(Tea);
            case IconParkIconKind.TeaDrink: return typeof(TeaDrink);
            case IconParkIconKind.Teapot: return typeof(Teapot);
            case IconParkIconKind.Teeth: return typeof(Teeth);
            case IconParkIconKind.Telegram: return typeof(Telegram);
            case IconParkIconKind.Telescope: return typeof(Telescope);
            case IconParkIconKind.TencentQq: return typeof(TencentQq);
            case IconParkIconKind.Tennis: return typeof(Tennis);
            case IconParkIconKind.Tent: return typeof(Tent);
            case IconParkIconKind.TentBanner: return typeof(TentBanner);
            case IconParkIconKind.Terminal: return typeof(Terminal);
            case IconParkIconKind.TerminationFile: return typeof(TerminationFile);
            case IconParkIconKind.Terrace: return typeof(Terrace);
            case IconParkIconKind.TestTube: return typeof(TestTube);
            case IconParkIconKind.Text: return typeof(Text);
            case IconParkIconKind.TextBold: return typeof(TextBold);
            case IconParkIconKind.TextItalic: return typeof(TextItalic);
            case IconParkIconKind.TextMessage: return typeof(TextMessage);
            case IconParkIconKind.TextRecognition: return typeof(TextRecognition);
            case IconParkIconKind.TextRotationDown: return typeof(TextRotationDown);
            case IconParkIconKind.TextRotationLeft: return typeof(TextRotationLeft);
            case IconParkIconKind.TextRotationNone: return typeof(TextRotationNone);
            case IconParkIconKind.TextRotationUp: return typeof(TextRotationUp);
            case IconParkIconKind.TextStyle: return typeof(TextStyle);
            case IconParkIconKind.TextStyleOne: return typeof(TextStyleOne);
            case IconParkIconKind.TextUnderline: return typeof(TextUnderline);
            case IconParkIconKind.TextWrapOverflow: return typeof(TextWrapOverflow);
            case IconParkIconKind.TextWrapTruncation: return typeof(TextWrapTruncation);
            case IconParkIconKind.Textarea: return typeof(Textarea);
            case IconParkIconKind.Texture: return typeof(Texture);
            case IconParkIconKind.TextureTwo: return typeof(TextureTwo);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk36(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.SwitchButton => new SwitchButton(),
            IconParkIconKind.SwitchContrast => new SwitchContrast(),
            IconParkIconKind.SwitchNintendo => new SwitchNintendo(),
            IconParkIconKind.SwitchOne => new SwitchOne(),
            IconParkIconKind.SwitchThemes => new SwitchThemes(),
            IconParkIconKind.SwitchTrack => new SwitchTrack(),
            IconParkIconKind.SwitchingDone => new SwitchingDone(),
            IconParkIconKind.Symbol => new Symbol(),
            IconParkIconKind.SymbolDoubleX => new SymbolDoubleX(),
            IconParkIconKind.Symmetry => new Symmetry(),
            IconParkIconKind.Sync => new Sync(),
            IconParkIconKind.System => new System(),
            IconParkIconKind.TShirt => new TShirt(),
            IconParkIconKind.Table => new Table(),
            IconParkIconKind.TableFile => new TableFile(),
            IconParkIconKind.TableLamp => new TableLamp(),
            IconParkIconKind.TableReport => new TableReport(),
            IconParkIconKind.Tabletennis => new Tabletennis(),
            IconParkIconKind.Tag => new Tag(),
            IconParkIconKind.TagOne => new TagOne(),
            IconParkIconKind.Tailoring => new Tailoring(),
            IconParkIconKind.TailoringTwo => new TailoringTwo(),
            IconParkIconKind.TajMahal => new TajMahal(),
            IconParkIconKind.TakeOff => new TakeOff(),
            IconParkIconKind.TakeOffOne => new TakeOffOne(),
            IconParkIconKind.Taobao => new Taobao(),
            IconParkIconKind.Tape => new Tape(),
            IconParkIconKind.TapeMeasure => new TapeMeasure(),
            IconParkIconKind.Target => new Target(),
            IconParkIconKind.TargetOne => new TargetOne(),
            IconParkIconKind.TargetTwo => new TargetTwo(),
            IconParkIconKind.Taurus => new Taurus(),
            IconParkIconKind.Taxi => new Taxi(),
            IconParkIconKind.Tea => new Tea(),
            IconParkIconKind.TeaDrink => new TeaDrink(),
            IconParkIconKind.Teapot => new Teapot(),
            IconParkIconKind.Teeth => new Teeth(),
            IconParkIconKind.Telegram => new Telegram(),
            IconParkIconKind.Telescope => new Telescope(),
            IconParkIconKind.TencentQq => new TencentQq(),
            IconParkIconKind.Tennis => new Tennis(),
            IconParkIconKind.Tent => new Tent(),
            IconParkIconKind.TentBanner => new TentBanner(),
            IconParkIconKind.Terminal => new Terminal(),
            IconParkIconKind.TerminationFile => new TerminationFile(),
            IconParkIconKind.Terrace => new Terrace(),
            IconParkIconKind.TestTube => new TestTube(),
            IconParkIconKind.Text => new Text(),
            IconParkIconKind.TextBold => new TextBold(),
            IconParkIconKind.TextItalic => new TextItalic(),
            IconParkIconKind.TextMessage => new TextMessage(),
            IconParkIconKind.TextRecognition => new TextRecognition(),
            IconParkIconKind.TextRotationDown => new TextRotationDown(),
            IconParkIconKind.TextRotationLeft => new TextRotationLeft(),
            IconParkIconKind.TextRotationNone => new TextRotationNone(),
            IconParkIconKind.TextRotationUp => new TextRotationUp(),
            IconParkIconKind.TextStyle => new TextStyle(),
            IconParkIconKind.TextStyleOne => new TextStyleOne(),
            IconParkIconKind.TextUnderline => new TextUnderline(),
            IconParkIconKind.TextWrapOverflow => new TextWrapOverflow(),
            IconParkIconKind.TextWrapTruncation => new TextWrapTruncation(),
            IconParkIconKind.Textarea => new Textarea(),
            IconParkIconKind.Texture => new Texture(),
            IconParkIconKind.TextureTwo => new TextureTwo(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk37(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.TheSingleShoulderBag: return typeof(TheSingleShoulderBag);
            case IconParkIconKind.Theater: return typeof(Theater);
            case IconParkIconKind.Theme: return typeof(Theme);
            case IconParkIconKind.Thermometer: return typeof(Thermometer);
            case IconParkIconKind.ThermometerOne: return typeof(ThermometerOne);
            case IconParkIconKind.ThermosCup: return typeof(ThermosCup);
            case IconParkIconKind.Thin: return typeof(Thin);
            case IconParkIconKind.ThinkingProblem: return typeof(ThinkingProblem);
            case IconParkIconKind.Three: return typeof(Three);
            case IconParkIconKind.ThreeDGlasses: return typeof(ThreeDGlasses);
            case IconParkIconKind.ThreeHexagons: return typeof(ThreeHexagons);
            case IconParkIconKind.ThreeKey: return typeof(ThreeKey);
            case IconParkIconKind.ThreeSlashes: return typeof(ThreeSlashes);
            case IconParkIconKind.ThreeThree: return typeof(ThreeThree);
            case IconParkIconKind.ThreeTriangles: return typeof(ThreeTriangles);
            case IconParkIconKind.ThumbsDown: return typeof(ThumbsDown);
            case IconParkIconKind.ThumbsUp: return typeof(ThumbsUp);
            case IconParkIconKind.Thunderbolt: return typeof(Thunderbolt);
            case IconParkIconKind.Thunderstorm: return typeof(Thunderstorm);
            case IconParkIconKind.ThunderstormOne: return typeof(ThunderstormOne);
            case IconParkIconKind.Ticket: return typeof(Ticket);
            case IconParkIconKind.TicketOne: return typeof(TicketOne);
            case IconParkIconKind.TicketsChecked: return typeof(TicketsChecked);
            case IconParkIconKind.TicketsOne: return typeof(TicketsOne);
            case IconParkIconKind.TicketsTwo: return typeof(TicketsTwo);
            case IconParkIconKind.TigerZodiac: return typeof(TigerZodiac);
            case IconParkIconKind.Tiktok: return typeof(Tiktok);
            case IconParkIconKind.Time: return typeof(Time);
            case IconParkIconKind.TimedMail: return typeof(TimedMail);
            case IconParkIconKind.Timeline: return typeof(Timeline);
            case IconParkIconKind.Timer: return typeof(Timer);
            case IconParkIconKind.Tips: return typeof(Tips);
            case IconParkIconKind.TipsOne: return typeof(TipsOne);
            case IconParkIconKind.TireSwing: return typeof(TireSwing);
            case IconParkIconKind.TitleLevel: return typeof(TitleLevel);
            case IconParkIconKind.ToBottom: return typeof(ToBottom);
            case IconParkIconKind.ToBottomOne: return typeof(ToBottomOne);
            case IconParkIconKind.ToLeft: return typeof(ToLeft);
            case IconParkIconKind.ToRight: return typeof(ToRight);
            case IconParkIconKind.ToTop: return typeof(ToTop);
            case IconParkIconKind.ToTopOne: return typeof(ToTopOne);
            case IconParkIconKind.Toilet: return typeof(Toilet);
            case IconParkIconKind.Tomato: return typeof(Tomato);
            case IconParkIconKind.Tool: return typeof(Tool);
            case IconParkIconKind.Toolkit: return typeof(Toolkit);
            case IconParkIconKind.TopBar: return typeof(TopBar);
            case IconParkIconKind.Topbuzz: return typeof(Topbuzz);
            case IconParkIconKind.Topic: return typeof(Topic);
            case IconParkIconKind.TopicDiscussion: return typeof(TopicDiscussion);
            case IconParkIconKind.Torch: return typeof(Torch);
            case IconParkIconKind.TourBus: return typeof(TourBus);
            case IconParkIconKind.Towel: return typeof(Towel);
            case IconParkIconKind.Tower: return typeof(Tower);
            case IconParkIconKind.TowerOfBabel: return typeof(TowerOfBabel);
            case IconParkIconKind.TowerOfPisa: return typeof(TowerOfPisa);
            case IconParkIconKind.Toxins: return typeof(Toxins);
            case IconParkIconKind.Trace: return typeof(Trace);
            case IconParkIconKind.Trademark: return typeof(Trademark);
            case IconParkIconKind.TraditionalChineseMedicine: return typeof(TraditionalChineseMedicine);
            case IconParkIconKind.Train: return typeof(Train);
            case IconParkIconKind.Transaction: return typeof(Transaction);
            case IconParkIconKind.TransactionOrder: return typeof(TransactionOrder);
            case IconParkIconKind.Transfer: return typeof(Transfer);
            case IconParkIconKind.TransferData: return typeof(TransferData);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk37(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.TheSingleShoulderBag => new TheSingleShoulderBag(),
            IconParkIconKind.Theater => new Theater(),
            IconParkIconKind.Theme => new Theme(),
            IconParkIconKind.Thermometer => new Thermometer(),
            IconParkIconKind.ThermometerOne => new ThermometerOne(),
            IconParkIconKind.ThermosCup => new ThermosCup(),
            IconParkIconKind.Thin => new Thin(),
            IconParkIconKind.ThinkingProblem => new ThinkingProblem(),
            IconParkIconKind.Three => new Three(),
            IconParkIconKind.ThreeDGlasses => new ThreeDGlasses(),
            IconParkIconKind.ThreeHexagons => new ThreeHexagons(),
            IconParkIconKind.ThreeKey => new ThreeKey(),
            IconParkIconKind.ThreeSlashes => new ThreeSlashes(),
            IconParkIconKind.ThreeThree => new ThreeThree(),
            IconParkIconKind.ThreeTriangles => new ThreeTriangles(),
            IconParkIconKind.ThumbsDown => new ThumbsDown(),
            IconParkIconKind.ThumbsUp => new ThumbsUp(),
            IconParkIconKind.Thunderbolt => new Thunderbolt(),
            IconParkIconKind.Thunderstorm => new Thunderstorm(),
            IconParkIconKind.ThunderstormOne => new ThunderstormOne(),
            IconParkIconKind.Ticket => new Ticket(),
            IconParkIconKind.TicketOne => new TicketOne(),
            IconParkIconKind.TicketsChecked => new TicketsChecked(),
            IconParkIconKind.TicketsOne => new TicketsOne(),
            IconParkIconKind.TicketsTwo => new TicketsTwo(),
            IconParkIconKind.TigerZodiac => new TigerZodiac(),
            IconParkIconKind.Tiktok => new Tiktok(),
            IconParkIconKind.Time => new Time(),
            IconParkIconKind.TimedMail => new TimedMail(),
            IconParkIconKind.Timeline => new Timeline(),
            IconParkIconKind.Timer => new Timer(),
            IconParkIconKind.Tips => new Tips(),
            IconParkIconKind.TipsOne => new TipsOne(),
            IconParkIconKind.TireSwing => new TireSwing(),
            IconParkIconKind.TitleLevel => new TitleLevel(),
            IconParkIconKind.ToBottom => new ToBottom(),
            IconParkIconKind.ToBottomOne => new ToBottomOne(),
            IconParkIconKind.ToLeft => new ToLeft(),
            IconParkIconKind.ToRight => new ToRight(),
            IconParkIconKind.ToTop => new ToTop(),
            IconParkIconKind.ToTopOne => new ToTopOne(),
            IconParkIconKind.Toilet => new Toilet(),
            IconParkIconKind.Tomato => new Tomato(),
            IconParkIconKind.Tool => new Tool(),
            IconParkIconKind.Toolkit => new Toolkit(),
            IconParkIconKind.TopBar => new TopBar(),
            IconParkIconKind.Topbuzz => new Topbuzz(),
            IconParkIconKind.Topic => new Topic(),
            IconParkIconKind.TopicDiscussion => new TopicDiscussion(),
            IconParkIconKind.Torch => new Torch(),
            IconParkIconKind.TourBus => new TourBus(),
            IconParkIconKind.Towel => new Towel(),
            IconParkIconKind.Tower => new Tower(),
            IconParkIconKind.TowerOfBabel => new TowerOfBabel(),
            IconParkIconKind.TowerOfPisa => new TowerOfPisa(),
            IconParkIconKind.Toxins => new Toxins(),
            IconParkIconKind.Trace => new Trace(),
            IconParkIconKind.Trademark => new Trademark(),
            IconParkIconKind.TraditionalChineseMedicine => new TraditionalChineseMedicine(),
            IconParkIconKind.Train => new Train(),
            IconParkIconKind.Transaction => new Transaction(),
            IconParkIconKind.TransactionOrder => new TransactionOrder(),
            IconParkIconKind.Transfer => new Transfer(),
            IconParkIconKind.TransferData => new TransferData(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk38(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Transform: return typeof(Transform);
            case IconParkIconKind.Translate: return typeof(Translate);
            case IconParkIconKind.Translation: return typeof(Translation);
            case IconParkIconKind.Transport: return typeof(Transport);
            case IconParkIconKind.Transporter: return typeof(Transporter);
            case IconParkIconKind.Trapezoid: return typeof(Trapezoid);
            case IconParkIconKind.Tray: return typeof(Tray);
            case IconParkIconKind.Treadmill: return typeof(Treadmill);
            case IconParkIconKind.TreadmillOne: return typeof(TreadmillOne);
            case IconParkIconKind.TreadmillTwo: return typeof(TreadmillTwo);
            case IconParkIconKind.TreasureChest: return typeof(TreasureChest);
            case IconParkIconKind.Tree: return typeof(Tree);
            case IconParkIconKind.TreeDiagram: return typeof(TreeDiagram);
            case IconParkIconKind.TreeList: return typeof(TreeList);
            case IconParkIconKind.TreeOne: return typeof(TreeOne);
            case IconParkIconKind.TreeTwo: return typeof(TreeTwo);
            case IconParkIconKind.Trend: return typeof(Trend);
            case IconParkIconKind.TrendTwo: return typeof(TrendTwo);
            case IconParkIconKind.TrendingDown: return typeof(TrendingDown);
            case IconParkIconKind.TrendingUp: return typeof(TrendingUp);
            case IconParkIconKind.Triangle: return typeof(Triangle);
            case IconParkIconKind.TriangleRoundRectangle: return typeof(TriangleRoundRectangle);
            case IconParkIconKind.TriangleRuler: return typeof(TriangleRuler);
            case IconParkIconKind.TriangularPyramid: return typeof(TriangularPyramid);
            case IconParkIconKind.Trophy: return typeof(Trophy);
            case IconParkIconKind.TrousersBellBottoms: return typeof(TrousersBellBottoms);
            case IconParkIconKind.Truck: return typeof(Truck);
            case IconParkIconKind.Trumpet: return typeof(Trumpet);
            case IconParkIconKind.Trunk: return typeof(Trunk);
            case IconParkIconKind.Tub: return typeof(Tub);
            case IconParkIconKind.Tuchong: return typeof(Tuchong);
            case IconParkIconKind.Tumblr: return typeof(Tumblr);
            case IconParkIconKind.Turkey: return typeof(Turkey);
            case IconParkIconKind.TurnAround: return typeof(TurnAround);
            case IconParkIconKind.TurnOffBluetooth: return typeof(TurnOffBluetooth);
            case IconParkIconKind.TurnOn: return typeof(TurnOn);
            case IconParkIconKind.Tv: return typeof(Tv);
            case IconParkIconKind.TvOne: return typeof(TvOne);
            case IconParkIconKind.Twitter: return typeof(Twitter);
            case IconParkIconKind.Two: return typeof(Two);
            case IconParkIconKind.TwoDimensionalCode: return typeof(TwoDimensionalCode);
            case IconParkIconKind.TwoDimensionalCodeOne: return typeof(TwoDimensionalCodeOne);
            case IconParkIconKind.TwoDimensionalCodeTwo: return typeof(TwoDimensionalCodeTwo);
            case IconParkIconKind.TwoEllipses: return typeof(TwoEllipses);
            case IconParkIconKind.TwoFingers: return typeof(TwoFingers);
            case IconParkIconKind.TwoHands: return typeof(TwoHands);
            case IconParkIconKind.TwoKey: return typeof(TwoKey);
            case IconParkIconKind.TwoSemicircles: return typeof(TwoSemicircles);
            case IconParkIconKind.TwoTriangles: return typeof(TwoTriangles);
            case IconParkIconKind.TwoTrianglesTwo: return typeof(TwoTrianglesTwo);
            case IconParkIconKind.TwoTwo: return typeof(TwoTwo);
            case IconParkIconKind.TypeDrive: return typeof(TypeDrive);
            case IconParkIconKind.UDisk: return typeof(UDisk);
            case IconParkIconKind.UTurnDown: return typeof(UTurnDown);
            case IconParkIconKind.UTurnLeft: return typeof(UTurnLeft);
            case IconParkIconKind.UTurnRight: return typeof(UTurnRight);
            case IconParkIconKind.UTurnUp: return typeof(UTurnUp);
            case IconParkIconKind.Ulikecam: return typeof(Ulikecam);
            case IconParkIconKind.Umbrella: return typeof(Umbrella);
            case IconParkIconKind.UmbrellaOne: return typeof(UmbrellaOne);
            case IconParkIconKind.UmbrellaTwo: return typeof(UmbrellaTwo);
            case IconParkIconKind.Undo: return typeof(Undo);
            case IconParkIconKind.Ungroup: return typeof(Ungroup);
            case IconParkIconKind.Unicast: return typeof(Unicast);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk38(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Transform => new Transform(),
            IconParkIconKind.Translate => new Translate(),
            IconParkIconKind.Translation => new Translation(),
            IconParkIconKind.Transport => new Transport(),
            IconParkIconKind.Transporter => new Transporter(),
            IconParkIconKind.Trapezoid => new Trapezoid(),
            IconParkIconKind.Tray => new Tray(),
            IconParkIconKind.Treadmill => new Treadmill(),
            IconParkIconKind.TreadmillOne => new TreadmillOne(),
            IconParkIconKind.TreadmillTwo => new TreadmillTwo(),
            IconParkIconKind.TreasureChest => new TreasureChest(),
            IconParkIconKind.Tree => new Tree(),
            IconParkIconKind.TreeDiagram => new TreeDiagram(),
            IconParkIconKind.TreeList => new TreeList(),
            IconParkIconKind.TreeOne => new TreeOne(),
            IconParkIconKind.TreeTwo => new TreeTwo(),
            IconParkIconKind.Trend => new Trend(),
            IconParkIconKind.TrendTwo => new TrendTwo(),
            IconParkIconKind.TrendingDown => new TrendingDown(),
            IconParkIconKind.TrendingUp => new TrendingUp(),
            IconParkIconKind.Triangle => new Triangle(),
            IconParkIconKind.TriangleRoundRectangle => new TriangleRoundRectangle(),
            IconParkIconKind.TriangleRuler => new TriangleRuler(),
            IconParkIconKind.TriangularPyramid => new TriangularPyramid(),
            IconParkIconKind.Trophy => new Trophy(),
            IconParkIconKind.TrousersBellBottoms => new TrousersBellBottoms(),
            IconParkIconKind.Truck => new Truck(),
            IconParkIconKind.Trumpet => new Trumpet(),
            IconParkIconKind.Trunk => new Trunk(),
            IconParkIconKind.Tub => new Tub(),
            IconParkIconKind.Tuchong => new Tuchong(),
            IconParkIconKind.Tumblr => new Tumblr(),
            IconParkIconKind.Turkey => new Turkey(),
            IconParkIconKind.TurnAround => new TurnAround(),
            IconParkIconKind.TurnOffBluetooth => new TurnOffBluetooth(),
            IconParkIconKind.TurnOn => new TurnOn(),
            IconParkIconKind.Tv => new Tv(),
            IconParkIconKind.TvOne => new TvOne(),
            IconParkIconKind.Twitter => new Twitter(),
            IconParkIconKind.Two => new Two(),
            IconParkIconKind.TwoDimensionalCode => new TwoDimensionalCode(),
            IconParkIconKind.TwoDimensionalCodeOne => new TwoDimensionalCodeOne(),
            IconParkIconKind.TwoDimensionalCodeTwo => new TwoDimensionalCodeTwo(),
            IconParkIconKind.TwoEllipses => new TwoEllipses(),
            IconParkIconKind.TwoFingers => new TwoFingers(),
            IconParkIconKind.TwoHands => new TwoHands(),
            IconParkIconKind.TwoKey => new TwoKey(),
            IconParkIconKind.TwoSemicircles => new TwoSemicircles(),
            IconParkIconKind.TwoTriangles => new TwoTriangles(),
            IconParkIconKind.TwoTrianglesTwo => new TwoTrianglesTwo(),
            IconParkIconKind.TwoTwo => new TwoTwo(),
            IconParkIconKind.TypeDrive => new TypeDrive(),
            IconParkIconKind.UDisk => new UDisk(),
            IconParkIconKind.UTurnDown => new UTurnDown(),
            IconParkIconKind.UTurnLeft => new UTurnLeft(),
            IconParkIconKind.UTurnRight => new UTurnRight(),
            IconParkIconKind.UTurnUp => new UTurnUp(),
            IconParkIconKind.Ulikecam => new Ulikecam(),
            IconParkIconKind.Umbrella => new Umbrella(),
            IconParkIconKind.UmbrellaOne => new UmbrellaOne(),
            IconParkIconKind.UmbrellaTwo => new UmbrellaTwo(),
            IconParkIconKind.Undo => new Undo(),
            IconParkIconKind.Ungroup => new Ungroup(),
            IconParkIconKind.Unicast => new Unicast(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk39(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.UnionSelection: return typeof(UnionSelection);
            case IconParkIconKind.Universal: return typeof(Universal);
            case IconParkIconKind.Unlike: return typeof(Unlike);
            case IconParkIconKind.Unlink: return typeof(Unlink);
            case IconParkIconKind.Unlock: return typeof(Unlock);
            case IconParkIconKind.UnlockOne: return typeof(UnlockOne);
            case IconParkIconKind.UnorderedList: return typeof(UnorderedList);
            case IconParkIconKind.Up: return typeof(Up);
            case IconParkIconKind.UpAndDown: return typeof(UpAndDown);
            case IconParkIconKind.UpC: return typeof(UpC);
            case IconParkIconKind.UpOne: return typeof(UpOne);
            case IconParkIconKind.UpSmall: return typeof(UpSmall);
            case IconParkIconKind.UpSquare: return typeof(UpSquare);
            case IconParkIconKind.UpTwo: return typeof(UpTwo);
            case IconParkIconKind.UpdateRotation: return typeof(UpdateRotation);
            case IconParkIconKind.Upload: return typeof(Upload);
            case IconParkIconKind.UploadComputer: return typeof(UploadComputer);
            case IconParkIconKind.UploadLaptop: return typeof(UploadLaptop);
            case IconParkIconKind.UploadLogs: return typeof(UploadLogs);
            case IconParkIconKind.UploadOne: return typeof(UploadOne);
            case IconParkIconKind.UploadPicture: return typeof(UploadPicture);
            case IconParkIconKind.UploadThree: return typeof(UploadThree);
            case IconParkIconKind.UploadTwo: return typeof(UploadTwo);
            case IconParkIconKind.UploadWeb: return typeof(UploadWeb);
            case IconParkIconKind.UpsideDownFace: return typeof(UpsideDownFace);
            case IconParkIconKind.Usb: return typeof(Usb);
            case IconParkIconKind.UsbMemoryStick: return typeof(UsbMemoryStick);
            case IconParkIconKind.UsbMicroOne: return typeof(UsbMicroOne);
            case IconParkIconKind.UsbMicroTwo: return typeof(UsbMicroTwo);
            case IconParkIconKind.UsbOne: return typeof(UsbOne);
            case IconParkIconKind.UsbTypeC: return typeof(UsbTypeC);
            case IconParkIconKind.User: return typeof(User);
            case IconParkIconKind.UserBusiness: return typeof(UserBusiness);
            case IconParkIconKind.UserPositioning: return typeof(UserPositioning);
            case IconParkIconKind.UserToUserTransmission: return typeof(UserToUserTransmission);
            case IconParkIconKind.Uterus: return typeof(Uterus);
            case IconParkIconKind.Vacation: return typeof(Vacation);
            case IconParkIconKind.VacuumCleaner: return typeof(VacuumCleaner);
            case IconParkIconKind.VegetableBasket: return typeof(VegetableBasket);
            case IconParkIconKind.Vegetables: return typeof(Vegetables);
            case IconParkIconKind.VerticalSpacingBetweenItems: return typeof(VerticalSpacingBetweenItems);
            case IconParkIconKind.VerticalTidyUp: return typeof(VerticalTidyUp);
            case IconParkIconKind.VerticalTimeline: return typeof(VerticalTimeline);
            case IconParkIconKind.VerticallyCentered: return typeof(VerticallyCentered);
            case IconParkIconKind.Vest: return typeof(Vest);
            case IconParkIconKind.Vial: return typeof(Vial);
            case IconParkIconKind.ViciaFaba: return typeof(ViciaFaba);
            case IconParkIconKind.Video: return typeof(Video);
            case IconParkIconKind.VideoConference: return typeof(VideoConference);
            case IconParkIconKind.VideoFile: return typeof(VideoFile);
            case IconParkIconKind.VideoOne: return typeof(VideoOne);
            case IconParkIconKind.VideoTwo: return typeof(VideoTwo);
            case IconParkIconKind.Videocamera: return typeof(Videocamera);
            case IconParkIconKind.VideocameraOne: return typeof(VideocameraOne);
            case IconParkIconKind.Viencharts: return typeof(Viencharts);
            case IconParkIconKind.ViewGridCard: return typeof(ViewGridCard);
            case IconParkIconKind.ViewGridDetail: return typeof(ViewGridDetail);
            case IconParkIconKind.ViewGridList: return typeof(ViewGridList);
            case IconParkIconKind.ViewList: return typeof(ViewList);
            case IconParkIconKind.Viewfinder: return typeof(Viewfinder);
            case IconParkIconKind.Vigo: return typeof(Vigo);
            case IconParkIconKind.Vip: return typeof(Vip);
            case IconParkIconKind.VipOne: return typeof(VipOne);
            case IconParkIconKind.Virgo: return typeof(Virgo);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk39(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.UnionSelection => new UnionSelection(),
            IconParkIconKind.Universal => new Universal(),
            IconParkIconKind.Unlike => new Unlike(),
            IconParkIconKind.Unlink => new Unlink(),
            IconParkIconKind.Unlock => new Unlock(),
            IconParkIconKind.UnlockOne => new UnlockOne(),
            IconParkIconKind.UnorderedList => new UnorderedList(),
            IconParkIconKind.Up => new Up(),
            IconParkIconKind.UpAndDown => new UpAndDown(),
            IconParkIconKind.UpC => new UpC(),
            IconParkIconKind.UpOne => new UpOne(),
            IconParkIconKind.UpSmall => new UpSmall(),
            IconParkIconKind.UpSquare => new UpSquare(),
            IconParkIconKind.UpTwo => new UpTwo(),
            IconParkIconKind.UpdateRotation => new UpdateRotation(),
            IconParkIconKind.Upload => new Upload(),
            IconParkIconKind.UploadComputer => new UploadComputer(),
            IconParkIconKind.UploadLaptop => new UploadLaptop(),
            IconParkIconKind.UploadLogs => new UploadLogs(),
            IconParkIconKind.UploadOne => new UploadOne(),
            IconParkIconKind.UploadPicture => new UploadPicture(),
            IconParkIconKind.UploadThree => new UploadThree(),
            IconParkIconKind.UploadTwo => new UploadTwo(),
            IconParkIconKind.UploadWeb => new UploadWeb(),
            IconParkIconKind.UpsideDownFace => new UpsideDownFace(),
            IconParkIconKind.Usb => new Usb(),
            IconParkIconKind.UsbMemoryStick => new UsbMemoryStick(),
            IconParkIconKind.UsbMicroOne => new UsbMicroOne(),
            IconParkIconKind.UsbMicroTwo => new UsbMicroTwo(),
            IconParkIconKind.UsbOne => new UsbOne(),
            IconParkIconKind.UsbTypeC => new UsbTypeC(),
            IconParkIconKind.User => new User(),
            IconParkIconKind.UserBusiness => new UserBusiness(),
            IconParkIconKind.UserPositioning => new UserPositioning(),
            IconParkIconKind.UserToUserTransmission => new UserToUserTransmission(),
            IconParkIconKind.Uterus => new Uterus(),
            IconParkIconKind.Vacation => new Vacation(),
            IconParkIconKind.VacuumCleaner => new VacuumCleaner(),
            IconParkIconKind.VegetableBasket => new VegetableBasket(),
            IconParkIconKind.Vegetables => new Vegetables(),
            IconParkIconKind.VerticalSpacingBetweenItems => new VerticalSpacingBetweenItems(),
            IconParkIconKind.VerticalTidyUp => new VerticalTidyUp(),
            IconParkIconKind.VerticalTimeline => new VerticalTimeline(),
            IconParkIconKind.VerticallyCentered => new VerticallyCentered(),
            IconParkIconKind.Vest => new Vest(),
            IconParkIconKind.Vial => new Vial(),
            IconParkIconKind.ViciaFaba => new ViciaFaba(),
            IconParkIconKind.Video => new Video(),
            IconParkIconKind.VideoConference => new VideoConference(),
            IconParkIconKind.VideoFile => new VideoFile(),
            IconParkIconKind.VideoOne => new VideoOne(),
            IconParkIconKind.VideoTwo => new VideoTwo(),
            IconParkIconKind.Videocamera => new Videocamera(),
            IconParkIconKind.VideocameraOne => new VideocameraOne(),
            IconParkIconKind.Viencharts => new Viencharts(),
            IconParkIconKind.ViewGridCard => new ViewGridCard(),
            IconParkIconKind.ViewGridDetail => new ViewGridDetail(),
            IconParkIconKind.ViewGridList => new ViewGridList(),
            IconParkIconKind.ViewList => new ViewList(),
            IconParkIconKind.Viewfinder => new Viewfinder(),
            IconParkIconKind.Vigo => new Vigo(),
            IconParkIconKind.Vip => new Vip(),
            IconParkIconKind.VipOne => new VipOne(),
            IconParkIconKind.Virgo => new Virgo(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk40(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.VirtualRealityGlasses: return typeof(VirtualRealityGlasses);
            case IconParkIconKind.Voice: return typeof(Voice);
            case IconParkIconKind.VoiceInput: return typeof(VoiceInput);
            case IconParkIconKind.VoiceMessage: return typeof(VoiceMessage);
            case IconParkIconKind.VoiceOff: return typeof(VoiceOff);
            case IconParkIconKind.VoiceOne: return typeof(VoiceOne);
            case IconParkIconKind.Voicemail: return typeof(Voicemail);
            case IconParkIconKind.Volkswagen: return typeof(Volkswagen);
            case IconParkIconKind.Volleyball: return typeof(Volleyball);
            case IconParkIconKind.VolumeDown: return typeof(VolumeDown);
            case IconParkIconKind.VolumeMute: return typeof(VolumeMute);
            case IconParkIconKind.VolumeNotice: return typeof(VolumeNotice);
            case IconParkIconKind.VolumeSmall: return typeof(VolumeSmall);
            case IconParkIconKind.VolumeUp: return typeof(VolumeUp);
            case IconParkIconKind.VrGlasses: return typeof(VrGlasses);
            case IconParkIconKind.Waistline: return typeof(Waistline);
            case IconParkIconKind.Wallet: return typeof(Wallet);
            case IconParkIconKind.WalletOne: return typeof(WalletOne);
            case IconParkIconKind.WalletThree: return typeof(WalletThree);
            case IconParkIconKind.WalletTwo: return typeof(WalletTwo);
            case IconParkIconKind.Warehousing: return typeof(Warehousing);
            case IconParkIconKind.WashingMachine: return typeof(WashingMachine);
            case IconParkIconKind.WashingMachineOne: return typeof(WashingMachineOne);
            case IconParkIconKind.Watch: return typeof(Watch);
            case IconParkIconKind.WatchOne: return typeof(WatchOne);
            case IconParkIconKind.Water: return typeof(Water);
            case IconParkIconKind.WaterLevel: return typeof(WaterLevel);
            case IconParkIconKind.WaterNo: return typeof(WaterNo);
            case IconParkIconKind.WaterRate: return typeof(WaterRate);
            case IconParkIconKind.WaterRateTwo: return typeof(WaterRateTwo);
            case IconParkIconKind.WaterfallsH: return typeof(WaterfallsH);
            case IconParkIconKind.WaterfallsV: return typeof(WaterfallsV);
            case IconParkIconKind.Watermelon: return typeof(Watermelon);
            case IconParkIconKind.WatermelonOne: return typeof(WatermelonOne);
            case IconParkIconKind.Waterpolo: return typeof(Waterpolo);
            case IconParkIconKind.WaterpoloOne: return typeof(WaterpoloOne);
            case IconParkIconKind.Waves: return typeof(Waves);
            case IconParkIconKind.WavesLeft: return typeof(WavesLeft);
            case IconParkIconKind.WavesRight: return typeof(WavesRight);
            case IconParkIconKind.WearyFace: return typeof(WearyFace);
            case IconParkIconKind.WebPage: return typeof(WebPage);
            case IconParkIconKind.Webcam: return typeof(Webcam);
            case IconParkIconKind.Wechat: return typeof(Wechat);
            case IconParkIconKind.Weibo: return typeof(Weibo);
            case IconParkIconKind.Weight: return typeof(Weight);
            case IconParkIconKind.Weightlifting: return typeof(Weightlifting);
            case IconParkIconKind.WeixinCardsOffers: return typeof(WeixinCardsOffers);
            case IconParkIconKind.WeixinFavorites: return typeof(WeixinFavorites);
            case IconParkIconKind.WeixinGames: return typeof(WeixinGames);
            case IconParkIconKind.WeixinMarket: return typeof(WeixinMarket);
            case IconParkIconKind.WeixinMiniApp: return typeof(WeixinMiniApp);
            case IconParkIconKind.WeixinPeopleNearby: return typeof(WeixinPeopleNearby);
            case IconParkIconKind.WeixinScan: return typeof(WeixinScan);
            case IconParkIconKind.WeixinSearch: return typeof(WeixinSearch);
            case IconParkIconKind.WeixinShake: return typeof(WeixinShake);
            case IconParkIconKind.WeixinTopStories: return typeof(WeixinTopStories);
            case IconParkIconKind.Whale: return typeof(Whale);
            case IconParkIconKind.Wheelchair: return typeof(Wheelchair);
            case IconParkIconKind.Whirlwind: return typeof(Whirlwind);
            case IconParkIconKind.Whistling: return typeof(Whistling);
            case IconParkIconKind.WholeSiteAccelerator: return typeof(WholeSiteAccelerator);
            case IconParkIconKind.Wifi: return typeof(Wifi);
            case IconParkIconKind.Wind: return typeof(Wind);
            case IconParkIconKind.WindTurbine: return typeof(WindTurbine);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk40(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.VirtualRealityGlasses => new VirtualRealityGlasses(),
            IconParkIconKind.Voice => new Voice(),
            IconParkIconKind.VoiceInput => new VoiceInput(),
            IconParkIconKind.VoiceMessage => new VoiceMessage(),
            IconParkIconKind.VoiceOff => new VoiceOff(),
            IconParkIconKind.VoiceOne => new VoiceOne(),
            IconParkIconKind.Voicemail => new Voicemail(),
            IconParkIconKind.Volkswagen => new Volkswagen(),
            IconParkIconKind.Volleyball => new Volleyball(),
            IconParkIconKind.VolumeDown => new VolumeDown(),
            IconParkIconKind.VolumeMute => new VolumeMute(),
            IconParkIconKind.VolumeNotice => new VolumeNotice(),
            IconParkIconKind.VolumeSmall => new VolumeSmall(),
            IconParkIconKind.VolumeUp => new VolumeUp(),
            IconParkIconKind.VrGlasses => new VrGlasses(),
            IconParkIconKind.Waistline => new Waistline(),
            IconParkIconKind.Wallet => new Wallet(),
            IconParkIconKind.WalletOne => new WalletOne(),
            IconParkIconKind.WalletThree => new WalletThree(),
            IconParkIconKind.WalletTwo => new WalletTwo(),
            IconParkIconKind.Warehousing => new Warehousing(),
            IconParkIconKind.WashingMachine => new WashingMachine(),
            IconParkIconKind.WashingMachineOne => new WashingMachineOne(),
            IconParkIconKind.Watch => new Watch(),
            IconParkIconKind.WatchOne => new WatchOne(),
            IconParkIconKind.Water => new Water(),
            IconParkIconKind.WaterLevel => new WaterLevel(),
            IconParkIconKind.WaterNo => new WaterNo(),
            IconParkIconKind.WaterRate => new WaterRate(),
            IconParkIconKind.WaterRateTwo => new WaterRateTwo(),
            IconParkIconKind.WaterfallsH => new WaterfallsH(),
            IconParkIconKind.WaterfallsV => new WaterfallsV(),
            IconParkIconKind.Watermelon => new Watermelon(),
            IconParkIconKind.WatermelonOne => new WatermelonOne(),
            IconParkIconKind.Waterpolo => new Waterpolo(),
            IconParkIconKind.WaterpoloOne => new WaterpoloOne(),
            IconParkIconKind.Waves => new Waves(),
            IconParkIconKind.WavesLeft => new WavesLeft(),
            IconParkIconKind.WavesRight => new WavesRight(),
            IconParkIconKind.WearyFace => new WearyFace(),
            IconParkIconKind.WebPage => new WebPage(),
            IconParkIconKind.Webcam => new Webcam(),
            IconParkIconKind.Wechat => new Wechat(),
            IconParkIconKind.Weibo => new Weibo(),
            IconParkIconKind.Weight => new Weight(),
            IconParkIconKind.Weightlifting => new Weightlifting(),
            IconParkIconKind.WeixinCardsOffers => new WeixinCardsOffers(),
            IconParkIconKind.WeixinFavorites => new WeixinFavorites(),
            IconParkIconKind.WeixinGames => new WeixinGames(),
            IconParkIconKind.WeixinMarket => new WeixinMarket(),
            IconParkIconKind.WeixinMiniApp => new WeixinMiniApp(),
            IconParkIconKind.WeixinPeopleNearby => new WeixinPeopleNearby(),
            IconParkIconKind.WeixinScan => new WeixinScan(),
            IconParkIconKind.WeixinSearch => new WeixinSearch(),
            IconParkIconKind.WeixinShake => new WeixinShake(),
            IconParkIconKind.WeixinTopStories => new WeixinTopStories(),
            IconParkIconKind.Whale => new Whale(),
            IconParkIconKind.Wheelchair => new Wheelchair(),
            IconParkIconKind.Whirlwind => new Whirlwind(),
            IconParkIconKind.Whistling => new Whistling(),
            IconParkIconKind.WholeSiteAccelerator => new WholeSiteAccelerator(),
            IconParkIconKind.Wifi => new Wifi(),
            IconParkIconKind.Wind => new Wind(),
            IconParkIconKind.WindTurbine => new WindTurbine(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk41(IconParkIconKind kind)
    {
        switch (kind)
        {
            case IconParkIconKind.Windmill: return typeof(Windmill);
            case IconParkIconKind.WindmillOne: return typeof(WindmillOne);
            case IconParkIconKind.WindmillTwo: return typeof(WindmillTwo);
            case IconParkIconKind.Windows: return typeof(Windows);
            case IconParkIconKind.WingsuitFlying: return typeof(WingsuitFlying);
            case IconParkIconKind.WinkingFace: return typeof(WinkingFace);
            case IconParkIconKind.WinkingFaceWithOpenEyes: return typeof(WinkingFaceWithOpenEyes);
            case IconParkIconKind.Woman: return typeof(Woman);
            case IconParkIconKind.Women: return typeof(Women);
            case IconParkIconKind.WomenCoat: return typeof(WomenCoat);
            case IconParkIconKind.WoolenHat: return typeof(WoolenHat);
            case IconParkIconKind.Word: return typeof(Word);
            case IconParkIconKind.Workbench: return typeof(Workbench);
            case IconParkIconKind.Worker: return typeof(Worker);
            case IconParkIconKind.World: return typeof(World);
            case IconParkIconKind.WorriedFace: return typeof(WorriedFace);
            case IconParkIconKind.Write: return typeof(Write);
            case IconParkIconKind.WritingFluently: return typeof(WritingFluently);
            case IconParkIconKind.WrongUser: return typeof(WrongUser);
            case IconParkIconKind.Xiaodu: return typeof(Xiaodu);
            case IconParkIconKind.XiaoduHome: return typeof(XiaoduHome);
            case IconParkIconKind.Xigua: return typeof(Xigua);
            case IconParkIconKind.Xingfuli: return typeof(Xingfuli);
            case IconParkIconKind.Xingtu: return typeof(Xingtu);
            case IconParkIconKind.Yep: return typeof(Yep);
            case IconParkIconKind.Youtobe: return typeof(Youtobe);
            case IconParkIconKind.Youtube: return typeof(Youtube);
            case IconParkIconKind.ZeroKey: return typeof(ZeroKey);
            case IconParkIconKind.Zijinyunying: return typeof(Zijinyunying);
            case IconParkIconKind.Zip: return typeof(Zip);
            case IconParkIconKind.Zoom: return typeof(Zoom);
            case IconParkIconKind.ZoomIn: return typeof(ZoomIn);
            case IconParkIconKind.ZoomInternal: return typeof(ZoomInternal);
            case IconParkIconKind.ZoomOut: return typeof(ZoomOut);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk41(IconParkIconKind kind)
    {
        return kind switch
        {
            IconParkIconKind.Windmill => new Windmill(),
            IconParkIconKind.WindmillOne => new WindmillOne(),
            IconParkIconKind.WindmillTwo => new WindmillTwo(),
            IconParkIconKind.Windows => new Windows(),
            IconParkIconKind.WingsuitFlying => new WingsuitFlying(),
            IconParkIconKind.WinkingFace => new WinkingFace(),
            IconParkIconKind.WinkingFaceWithOpenEyes => new WinkingFaceWithOpenEyes(),
            IconParkIconKind.Woman => new Woman(),
            IconParkIconKind.Women => new Women(),
            IconParkIconKind.WomenCoat => new WomenCoat(),
            IconParkIconKind.WoolenHat => new WoolenHat(),
            IconParkIconKind.Word => new Word(),
            IconParkIconKind.Workbench => new Workbench(),
            IconParkIconKind.Worker => new Worker(),
            IconParkIconKind.World => new World(),
            IconParkIconKind.WorriedFace => new WorriedFace(),
            IconParkIconKind.Write => new Write(),
            IconParkIconKind.WritingFluently => new WritingFluently(),
            IconParkIconKind.WrongUser => new WrongUser(),
            IconParkIconKind.Xiaodu => new Xiaodu(),
            IconParkIconKind.XiaoduHome => new XiaoduHome(),
            IconParkIconKind.Xigua => new Xigua(),
            IconParkIconKind.Xingfuli => new Xingfuli(),
            IconParkIconKind.Xingtu => new Xingtu(),
            IconParkIconKind.Yep => new Yep(),
            IconParkIconKind.Youtobe => new Youtobe(),
            IconParkIconKind.Youtube => new Youtube(),
            IconParkIconKind.ZeroKey => new ZeroKey(),
            IconParkIconKind.Zijinyunying => new Zijinyunying(),
            IconParkIconKind.Zip => new Zip(),
            IconParkIconKind.Zoom => new Zoom(),
            IconParkIconKind.ZoomIn => new ZoomIn(),
            IconParkIconKind.ZoomInternal => new ZoomInternal(),
            IconParkIconKind.ZoomOut => new ZoomOut(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }
}
