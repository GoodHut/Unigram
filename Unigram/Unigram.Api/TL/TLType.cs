// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public enum TLType : uint
	{
		// Core types
		Int32 = 0xA8509BDA,
		Int128 = 0x4BB5362B,
		Int256 = 0x929C32F,
		Long = 0x22076CBA,
		Double = 0x2210C154,
		String = 0xB5286E24,

		Vector = 0x1CB5C415,

		None = 0x0,

		// Layers
		InvokeWithLayer1 = 0x53835315,
		InvokeWithLayer2 = 0x289DD1F6,
		InvokeWithLayer3 = 0xB7475268,
		InvokeWithLayer4 = 0xDEA0D430,
		InvokeWithLayer5 = 0x417A57AE,
		InvokeWithLayer6 = 0x3A64D54D,
		InvokeWithLayer7 = 0xA5BE56D3,
		InvokeWithLayer8 = 0xE9ABD9FD,
		InvokeWithLayer9 = 0x76715A63,
		InvokeWithLayer10 = 0x39620C41,
		InvokeWithLayer11 = 0xA6B88FDF,
		InvokeWithLayer12 = 0xDDA60D3C,
		InvokeWithLayer13 = 0x427C8EA2,
		InvokeWithLayer14 = 0x2B9B08FA,
		InvokeWithLayer15 = 0xB4418B64,
		InvokeWithLayer16 = 0xCF5F0987,
		InvokeWithLayer17 = 0x50858A19,
		InvokeWithLayer18 = 0x1C900537,

		// Manually parsed
		RPCResult = 0xF35C6D01,
		RPCReqError = 0x7AE432F5,
		MsgContainer = 0x73F1F8DC,
		GzipPacked = 0x3072CFA1,
		Null = 0x56730BCC,

		ContestSaveDeveloperInfo = 0x9A5F6E95,
		InputPeerEmpty = 0x7F3B18EA,
		InputPeerSelf = 0x7DA07EC9,
		InputPeerChat = 0x179BE863,
		InputPeerUser = 0x7B8E7DE6,
		InputPeerChannel = 0x20ADAEF8,
		InputUserEmpty = 0xB98886CF,
		InputUserSelf = 0xF7C1B13F,
		InputUser = 0xD8292816,
		InputPhoneContact = 0xF392B7F4,
		InputFile = 0xF52FF27F,
		InputFileBig = 0xFA4F0BB5,
		InputMediaEmpty = 0x9664F57F,
		InputMediaUploadedPhoto = 0x2F37E231,
		InputMediaPhoto = 0x81FA373A,
		InputMediaGeoPoint = 0xF9C44144,
		InputMediaContact = 0xA6E45987,
		InputMediaUploadedDocument = 0xE39621FD,
		InputMediaDocument = 0x5ACB668E,
		InputMediaVenue = 0xC13D1C11,
		InputMediaGifExternal = 0x4843B0FD,
		InputMediaPhotoExternal = 0x922AEC1,
		InputMediaDocumentExternal = 0xB6F74335,
		InputMediaGame = 0xD33F43F3,
		InputMediaInvoice = 0x92153685,
		InputMediaGeoLive = 0x7B1A118F,
		InputSingleMedia = 0x5EAA7809,
		InputChatPhotoEmpty = 0x1CA48F57,
		InputChatUploadedPhoto = 0x927C55B4,
		InputChatPhoto = 0x8953AD37,
		InputGeoPointEmpty = 0xE4C123D6,
		InputGeoPoint = 0xF3B7ACC9,
		InputPhotoEmpty = 0x1CD7BF0D,
		InputPhoto = 0xFB95C6C4,
		InputFileLocation = 0x14637196,
		InputEncryptedFileLocation = 0xF5235D55,
		InputDocumentFileLocation = 0x430F0724,
		InputAppEvent = 0x770656A8,
		PeerUser = 0x9DB1BC6D,
		PeerChat = 0xBAD0E5BB,
		PeerChannel = 0xBDDDE532,
		StorageFileUnknown = 0xAA963B05,
		StorageFilePartial = 0x40BC6F52,
		StorageFileJpeg = 0x7EFE0E,
		StorageFileGif = 0xCAE1AADF,
		StorageFilePng = 0xA4F63C0,
		StorageFilePdf = 0xAE1E508D,
		StorageFileMp3 = 0x528A0677,
		StorageFileMov = 0x4B09EBBC,
		StorageFileMp4 = 0xB3CEA0E4,
		StorageFileWebp = 0x1081464C,
		FileLocationUnavailable = 0x7C596B46,
		FileLocation = 0x53D69076,
		UserEmpty = 0x200250BA,
		User = 0x2E13F4C3,
		UserProfilePhotoEmpty = 0x4F11BAE1,
		UserProfilePhoto = 0xD559D8C8,
		UserStatusEmpty = 0x9D05049,
		UserStatusOnline = 0xEDB93949,
		UserStatusOffline = 0x8C703F,
		UserStatusRecently = 0xE26F42F1,
		UserStatusLastWeek = 0x7BF09FC,
		UserStatusLastMonth = 0x77EBC742,
		ChatEmpty = 0x9BA2D800,
		Chat = 0xD91CDD54,
		ChatForbidden = 0x7328BDB,
		Channel = 0x450B7115,
		ChannelForbidden = 0x289DA732,
		ChatFull = 0x2E02A614,
		ChannelFull = 0x76AF5481,
		ChatParticipant = 0xC8D7493E,
		ChatParticipantCreator = 0xDA13538A,
		ChatParticipantAdmin = 0xE2D6E436,
		ChatParticipantsForbidden = 0xFC900C2B,
		ChatParticipants = 0x3F460FED,
		ChatPhotoEmpty = 0x37C1011C,
		ChatPhoto = 0x6153276A,
		MessageEmpty = 0x83E5DE54,
		Message = 0x44F9B43D,
		MessageService = 0x9E19A1F6,
		MessageMediaEmpty = 0x3DED6320,
		MessageMediaPhoto = 0xB5223B0F,
		MessageMediaGeo = 0x56E0D474,
		MessageMediaContact = 0x5E7D2F39,
		MessageMediaUnsupported = 0x9F84F49E,
		MessageMediaDocument = 0x7C4414D3,
		MessageMediaWebPage = 0xA32DD600,
		MessageMediaVenue = 0x2EC0533F,
		MessageMediaGame = 0xFDB19008,
		MessageMediaInvoice = 0x84551347,
		MessageMediaGeoLive = 0x7C3C2609,
		MessageActionEmpty = 0xB6AEF7B0,
		MessageActionChatCreate = 0xA6638B9A,
		MessageActionChatEditTitle = 0xB5A1CE5A,
		MessageActionChatEditPhoto = 0x7FCB13A8,
		MessageActionChatDeletePhoto = 0x95E3FBEF,
		MessageActionChatAddUser = 0x488A7337,
		MessageActionChatDeleteUser = 0xB2AE9B0C,
		MessageActionChatJoinedByLink = 0xF89CF5E8,
		MessageActionChannelCreate = 0x95D2AC92,
		MessageActionChatMigrateTo = 0x51BDB021,
		MessageActionChannelMigrateFrom = 0xB055EAEE,
		MessageActionPinMessage = 0x94BD38ED,
		MessageActionHistoryClear = 0x9FBAB604,
		MessageActionGameScore = 0x92A72876,
		MessageActionPaymentSentMe = 0x8F31B327,
		MessageActionPaymentSent = 0x40699CD0,
		MessageActionPhoneCall = 0x80E11A7F,
		MessageActionScreenshotTaken = 0x4792929B,
		MessageActionCustomAction = 0xFAE69F56,
		Dialog = 0xE4DEF5DB,
		PhotoEmpty = 0x2331B22D,
		Photo = 0x9288DD29,
		PhotoSizeEmpty = 0xE17E23C,
		PhotoSize = 0x77BFB61B,
		PhotoCachedSize = 0xE9A734FA,
		GeoPointEmpty = 0x1117DD5F,
		GeoPoint = 0x2049D70C,
		AuthCheckedPhone = 0x811EA28E,
		AuthSentCode = 0x5E002502,
		AuthAuthorization = 0xCD050916,
		InputNotifyPeer = 0xB8BC5B0C,
		InputNotifyUsers = 0x193B4417,
		InputNotifyChats = 0x4A95E84E,
		InputNotifyAll = 0xA429B886,
		InputPeerNotifyEventsEmpty = 0xF03064D8,
		InputPeerNotifyEventsAll = 0xE86A2C74,
		InputPeerNotifySettings = 0x38935EB2,
		PeerNotifyEventsEmpty = 0xADD53CB3,
		PeerNotifyEventsAll = 0x6D1DED88,
		PeerNotifySettingsEmpty = 0x70A68512,
		PeerNotifySettings = 0x9ACDA4C0,
		PeerSettings = 0x818426CD,
		WallPaper = 0xCCB03657,
		WallPaperSolid = 0x63117F24,
		InputReportReasonSpam = 0x58DBCAB8,
		InputReportReasonViolence = 0x1E22C78D,
		InputReportReasonPornography = 0x2E59D922,
		InputReportReasonOther = 0xE1746D0A,
		UserFull = 0xF220F3F,
		Contact = 0xF911C994,
		ImportedContact = 0xD0028438,
		ContactBlocked = 0x561BC879,
		ContactStatus = 0xD3680C61,
		ContactsLink = 0x3ACE484C,
		ContactsContactsNotModified = 0xB74BA9D2,
		ContactsContacts = 0xEAE87E42,
		ContactsImportedContacts = 0x77D01C3B,
		ContactsBlocked = 0x1C138D15,
		ContactsBlockedSlice = 0x900802A1,
		MessagesDialogs = 0x15BA6C40,
		MessagesDialogsSlice = 0x71E094F3,
		MessagesMessages = 0x8C718E87,
		MessagesMessagesSlice = 0xB446AE3,
		MessagesChannelMessages = 0x99262E37,
		MessagesChats = 0x64FF9FD5,
		MessagesChatsSlice = 0x9CD81144,
		MessagesChatFull = 0xE5D7D19C,
		MessagesAffectedHistory = 0xB45C69D1,
		InputMessagesFilterEmpty = 0x57E2F66C,
		InputMessagesFilterPhotos = 0x9609A51C,
		InputMessagesFilterVideo = 0x9FC00E65,
		InputMessagesFilterPhotoVideo = 0x56E9F0E4,
		InputMessagesFilterPhotoVideoDocuments = 0xD95E73BB,
		InputMessagesFilterDocument = 0x9EDDF188,
		InputMessagesFilterUrl = 0x7EF0DD87,
		InputMessagesFilterGif = 0xFFC86587,
		InputMessagesFilterVoice = 0x50F5C392,
		InputMessagesFilterMusic = 0x3751B49E,
		InputMessagesFilterChatPhotos = 0x3A20ECB8,
		InputMessagesFilterPhoneCalls = 0x80C99768,
		InputMessagesFilterRoundVoice = 0x7A7C17A4,
		InputMessagesFilterRoundVideo = 0xB549DA53,
		InputMessagesFilterMyMentions = 0xC1F8E69A,
		InputMessagesFilterContacts = 0xE062DB83,
		InputMessagesFilterGeo = 0xE7026D0D,
		UpdateNewMessage = 0x1F2B0AFD,
		UpdateMessageID = 0x4E90BFD6,
		UpdateDeleteMessages = 0xA20DB0E5,
		UpdateUserTyping = 0x5C486927,
		UpdateChatUserTyping = 0x9A65EA1F,
		UpdateChatParticipants = 0x7761198,
		UpdateUserStatus = 0x1BFBD823,
		UpdateUserName = 0xA7332B73,
		UpdateUserPhoto = 0x95313B0C,
		UpdateContactRegistered = 0x2575BBB9,
		UpdateContactLink = 0x9D2E67C5,
		UpdateNewEncryptedMessage = 0x12BCBD9A,
		UpdateEncryptedChatTyping = 0x1710F156,
		UpdateEncryption = 0xB4A2E88D,
		UpdateEncryptedMessagesRead = 0x38FE25B7,
		UpdateChatParticipantAdd = 0xEA4B0E5C,
		UpdateChatParticipantDelete = 0x6E5F8C22,
		UpdateDCOptions = 0x8E5E9873,
		UpdateUserBlocked = 0x80ECE81A,
		UpdateNotifySettings = 0xBEC268EF,
		UpdateServiceNotification = 0xEBE46819,
		UpdatePrivacy = 0xEE3B272A,
		UpdateUserPhone = 0x12B9417B,
		UpdateReadHistoryInbox = 0x9961FD5C,
		UpdateReadHistoryOutbox = 0x2F2F21BF,
		UpdateWebPage = 0x7F891213,
		UpdateReadMessagesContents = 0x68C13933,
		UpdateChannelTooLong = 0xEB0467FB,
		UpdateChannel = 0xB6D45656,
		UpdateNewChannelMessage = 0x62BA04D9,
		UpdateReadChannelInbox = 0x4214F37F,
		UpdateDeleteChannelMessages = 0xC37521C9,
		UpdateChannelMessageViews = 0x98A12B4B,
		UpdateChatAdmins = 0x6E947941,
		UpdateChatParticipantAdmin = 0xB6901959,
		UpdateNewStickerSet = 0x688A30AA,
		UpdateStickerSetsOrder = 0xBB2D201,
		UpdateStickerSets = 0x43AE3DEC,
		UpdateSavedGifs = 0x9375341E,
		UpdateBotInlineQuery = 0x54826690,
		UpdateBotInlineSend = 0xE48F964,
		UpdateEditChannelMessage = 0x1B3F4DF7,
		UpdateChannelPinnedMessage = 0x98592475,
		UpdateBotCallbackQuery = 0xE73547E1,
		UpdateEditMessage = 0xE40370A3,
		UpdateInlineBotCallbackQuery = 0xF9D27A5A,
		UpdateReadChannelOutbox = 0x25D6C9C7,
		UpdateDraftMessage = 0xEE2BB969,
		UpdateReadFeaturedStickers = 0x571D2742,
		UpdateRecentStickers = 0x9A422C20,
		UpdateConfig = 0xA229DD06,
		UpdatePtsChanged = 0x3354678F,
		UpdateChannelWebPage = 0x40771900,
		UpdateDialogPinned = 0xD711A2CC,
		UpdatePinnedDialogs = 0xD8CAF68D,
		UpdateBotWebhookJSON = 0x8317C0C3,
		UpdateBotWebhookJSONQuery = 0x9B9240A6,
		UpdateBotShippingQuery = 0xE0CDC940,
		UpdateBotPrecheckoutQuery = 0x5D2F3AA9,
		UpdatePhoneCall = 0xAB0F6B1E,
		UpdateLangPackTooLong = 0x10C2404B,
		UpdateLangPack = 0x56022F4D,
		UpdateFavedStickers = 0xE511996D,
		UpdateChannelReadMessagesContents = 0x89893B45,
		UpdateContactsReset = 0x7084A7BE,
		UpdateChannelAvailableMessages = 0x70DB6837,
		UpdatesState = 0xA56C2A3E,
		UpdatesDifferenceEmpty = 0x5D75A138,
		UpdatesDifference = 0xF49CA0,
		UpdatesDifferenceSlice = 0xA8FB1981,
		UpdatesDifferenceTooLong = 0x4AFE8F6D,
		UpdatesTooLong = 0xE317AF7E,
		UpdateShortMessage = 0x914FBF11,
		UpdateShortChatMessage = 0x16812688,
		UpdateShort = 0x78D4DEC1,
		UpdatesCombined = 0x725B04C3,
		Updates = 0x74AE4240,
		UpdateShortSentMessage = 0x11F1331C,
		PhotosPhotos = 0x8DCA6AA5,
		PhotosPhotosSlice = 0x15051F54,
		PhotosPhoto = 0x20212CA8,
		UploadFile = 0x96A18D5,
		UploadFileCdnRedirect = 0xEA52FE5A,
		NearestDC = 0x8E1A1775,
		HelpAppUpdate = 0x8987F311,
		HelpNoAppUpdate = 0xC45A6536,
		HelpInviteText = 0x18CB9F78,
		EncryptedChatEmpty = 0xAB7EC0A0,
		EncryptedChatWaiting = 0x3BF703DC,
		EncryptedChatRequested = 0xC878527E,
		EncryptedChat = 0xFA56CE36,
		EncryptedChatDiscarded = 0x13D6DD27,
		InputEncryptedChat = 0xF141B5E1,
		EncryptedFileEmpty = 0xC21F497E,
		EncryptedFile = 0x4A70994C,
		InputEncryptedFileEmpty = 0x1837C364,
		InputEncryptedFileUploaded = 0x64BD0306,
		InputEncryptedFile = 0x5A17B5E5,
		InputEncryptedFileBigUploaded = 0x2DC173C8,
		EncryptedMessage = 0xED18C118,
		EncryptedMessageService = 0x23734B06,
		MessagesDHConfigNotModified = 0xC0E24635,
		MessagesDHConfig = 0x2C221EDD,
		MessagesSentEncryptedMessage = 0x560F8935,
		MessagesSentEncryptedFile = 0x9493FF32,
		InputDocumentEmpty = 0x72F0EAAE,
		InputDocument = 0x18798952,
		DocumentEmpty = 0x36F8C871,
		Document = 0x87232BC7,
		HelpSupport = 0x17C6B5F6,
		NotifyPeer = 0x9FD40BD8,
		NotifyUsers = 0xB4C83B4C,
		NotifyChats = 0xC007CEC3,
		NotifyAll = 0x74D07C60,
		SendMessageTypingAction = 0x16BF744E,
		SendMessageCancelAction = 0xFD5EC8F5,
		SendMessageRecordVideoAction = 0xA187D66F,
		SendMessageUploadVideoAction = 0xE9763AEC,
		SendMessageRecordAudioAction = 0xD52F73F7,
		SendMessageUploadAudioAction = 0xF351D7AB,
		SendMessageUploadPhotoAction = 0xD1D34A26,
		SendMessageUploadDocumentAction = 0xAA0CD9E4,
		SendMessageGeoLocationAction = 0x176F8BA1,
		SendMessageChooseContactAction = 0x628CBC6F,
		SendMessageGamePlayAction = 0xDD6A8F48,
		SendMessageRecordRoundAction = 0x88F27FBC,
		SendMessageUploadRoundAction = 0x243E1C66,
		ContactsFound = 0x1AA1F784,
		InputPrivacyKeyStatusTimestamp = 0x4F96CB18,
		InputPrivacyKeyChatInvite = 0xBDFB0426,
		InputPrivacyKeyPhoneCall = 0xFABADC5F,
		PrivacyKeyStatusTimestamp = 0xBC2EAB30,
		PrivacyKeyChatInvite = 0x500E6DFA,
		PrivacyKeyPhoneCall = 0x3D662B7B,
		InputPrivacyValueAllowContacts = 0xD09E07B,
		InputPrivacyValueAllowAll = 0x184B35CE,
		InputPrivacyValueAllowUsers = 0x131CC67F,
		InputPrivacyValueDisallowContacts = 0xBA52007,
		InputPrivacyValueDisallowAll = 0xD66B66C9,
		InputPrivacyValueDisallowUsers = 0x90110467,
		PrivacyValueAllowContacts = 0xFFFE1BAC,
		PrivacyValueAllowAll = 0x65427B82,
		PrivacyValueAllowUsers = 0x4D5BBE0C,
		PrivacyValueDisallowContacts = 0xF888FA1A,
		PrivacyValueDisallowAll = 0x8B73E763,
		PrivacyValueDisallowUsers = 0xC7F49B7,
		AccountPrivacyRules = 0x554ABB6F,
		AccountDaysTTL = 0xB8D0AFDF,
		DocumentAttributeImageSize = 0x6C37C15C,
		DocumentAttributeAnimated = 0x11B58939,
		DocumentAttributeSticker = 0x6319D612,
		DocumentAttributeVideo = 0xEF02CE6,
		DocumentAttributeAudio = 0x9852F9C6,
		DocumentAttributeFilename = 0x15590068,
		DocumentAttributeHasStickers = 0x9801D2F7,
		MessagesStickersNotModified = 0xF1749A22,
		MessagesStickers = 0x8A8ECD32,
		StickerPack = 0x12B299D4,
		MessagesAllStickersNotModified = 0xE86602C3,
		MessagesAllStickers = 0xEDFD405F,
		MessagesAffectedMessages = 0x84D19185,
		ContactLinkUnknown = 0x5F4F9247,
		ContactLinkNone = 0xFEEDD3AD,
		ContactLinkHasPhone = 0x268F3F59,
		ContactLinkContact = 0xD502C2D0,
		WebPageEmpty = 0xEB1477E8,
		WebPagePending = 0xC586DA1C,
		WebPage = 0x5F07B4BC,
		WebPageNotModified = 0x85849473,
		Authorization = 0x7BF2E6F6,
		AccountAuthorizations = 0x1250ABDE,
		AccountNoPassword = 0x96DABC18,
		AccountPassword = 0x7C18141C,
		AccountPasswordSettings = 0xB7B72AB3,
		AccountPasswordInputSettings = 0x86916DEB,
		AuthPasswordRecovery = 0x137948A5,
		ReceivedNotifyMessage = 0xA384B779,
		ChatInviteEmpty = 0x69DF3769,
		ChatInviteExported = 0xFC2E05BC,
		ChatInviteAlready = 0x5A686D7C,
		ChatInvite = 0xDB74F558,
		InputStickerSetEmpty = 0xFFB62B95,
		InputStickerSetID = 0x9DE7A269,
		InputStickerSetShortName = 0x861CC8A0,
		StickerSet = 0xCD303B41,
		MessagesStickerSet = 0xB60A24A6,
		BotCommand = 0xC27AC8C7,
		BotInfo = 0x98E81D3A,
		KeyboardButton = 0xA2FA4880,
		KeyboardButtonUrl = 0x258AFF05,
		KeyboardButtonCallback = 0x683A5E46,
		KeyboardButtonRequestPhone = 0xB16A6C29,
		KeyboardButtonRequestGeoLocation = 0xFC796B3F,
		KeyboardButtonSwitchInline = 0x568A748,
		KeyboardButtonGame = 0x50F41CCF,
		KeyboardButtonBuy = 0xAFD93FBB,
		KeyboardButtonRow = 0x77608B83,
		ReplyKeyboardHide = 0xA03E5B85,
		ReplyKeyboardForceReply = 0xF4108AA0,
		ReplyKeyboardMarkup = 0x3502758C,
		ReplyInlineMarkup = 0x48A30254,
		MessageEntityUnknown = 0xBB92BA95,
		MessageEntityMention = 0xFA04579D,
		MessageEntityHashtag = 0x6F635B0D,
		MessageEntityBotCommand = 0x6CEF8AC7,
		MessageEntityUrl = 0x6ED02538,
		MessageEntityEmail = 0x64E475C2,
		MessageEntityBold = 0xBD610BC9,
		MessageEntityItalic = 0x826F8B60,
		MessageEntityCode = 0x28A20571,
		MessageEntityPre = 0x73924BE0,
		MessageEntityTextUrl = 0x76A6D327,
		MessageEntityMentionName = 0x352DCA58,
		InputMessageEntityMentionName = 0x208E68C9,
		InputChannelEmpty = 0xEE8C1E86,
		InputChannel = 0xAFEB712E,
		ContactsResolvedPeer = 0x7F077AD9,
		MessageRange = 0xAE30253,
		UpdatesChannelDifferenceEmpty = 0x3E11AFFB,
		UpdatesChannelDifferenceTooLong = 0x6A9D7B35,
		UpdatesChannelDifference = 0x2064674E,
		ChannelMessagesFilterEmpty = 0x94D42EE7,
		ChannelMessagesFilter = 0xCD77D957,
		ChannelParticipant = 0x15EBAC1D,
		ChannelParticipantSelf = 0xA3289A6D,
		ChannelParticipantCreator = 0xE3E2E1F9,
		ChannelParticipantAdmin = 0xA82FA898,
		ChannelParticipantBanned = 0x222C1886,
		ChannelParticipantsRecent = 0xDE3F3C79,
		ChannelParticipantsAdmins = 0xB4608969,
		ChannelParticipantsKicked = 0xA3B54985,
		ChannelParticipantsBots = 0xB0D1865B,
		ChannelParticipantsBanned = 0x1427A5E1,
		ChannelParticipantsSearch = 0x656AC4B,
		ChannelsChannelParticipants = 0xF56EE2A8,
		ChannelsChannelParticipantsNotModified = 0xF0173FE9,
		ChannelsChannelParticipant = 0xD0D9B163,
		HelpTermsOfService = 0xF1EE3E90,
		FoundGif = 0x162ECC1F,
		FoundGifCached = 0x9C750409,
		MessagesFoundGifs = 0x450A1C0A,
		MessagesSavedGifsNotModified = 0xE8025CA2,
		MessagesSavedGifs = 0x2E0709A5,
		InputBotInlineMessageMediaAuto = 0x292FED13,
		InputBotInlineMessageText = 0x3DCD7A87,
		InputBotInlineMessageMediaGeo = 0xC1B15D65,
		InputBotInlineMessageMediaVenue = 0xAAAFADC8,
		InputBotInlineMessageMediaContact = 0x2DAF01A7,
		InputBotInlineMessageGame = 0x4B425864,
		InputBotInlineResult = 0x2CBBE15A,
		InputBotInlineResultPhoto = 0xA8D864A7,
		InputBotInlineResultDocument = 0xFFF8FDC4,
		InputBotInlineResultGame = 0x4FA417F2,
		BotInlineMessageMediaAuto = 0xA74B15B,
		BotInlineMessageText = 0x8C7F65E2,
		BotInlineMessageMediaGeo = 0xB722DE65,
		BotInlineMessageMediaVenue = 0x4366232E,
		BotInlineMessageMediaContact = 0x35EDB4D4,
		BotInlineResult = 0x9BEBAEB9,
		BotInlineMediaResult = 0x17DB940B,
		MessagesBotResults = 0x947CA848,
		ExportedMessageLink = 0x1F486803,
		MessageFwdHeader = 0x559EBE6D,
		AuthCodeTypeSms = 0x72A3158C,
		AuthCodeTypeCall = 0x741CD3E3,
		AuthCodeTypeFlashCall = 0x226CCEFB,
		AuthSentCodeTypeApp = 0x3DBB5986,
		AuthSentCodeTypeSms = 0xC000BBA2,
		AuthSentCodeTypeCall = 0x5353E5A7,
		AuthSentCodeTypeFlashCall = 0xAB03C6D9,
		MessagesBotCallbackAnswer = 0x36585EA4,
		MessagesMessageEditData = 0x26B5DDE6,
		InputBotInlineMessageID = 0x890C3D89,
		InlineBotSwitchPM = 0x3C20629F,
		MessagesPeerDialogs = 0x3371C354,
		TopPeer = 0xEDCDC05B,
		TopPeerCategoryBotsPM = 0xAB661B5B,
		TopPeerCategoryBotsInline = 0x148677E2,
		TopPeerCategoryCorrespondents = 0x637B7ED,
		TopPeerCategoryGroups = 0xBD17A14A,
		TopPeerCategoryChannels = 0x161D9628,
		TopPeerCategoryPhoneCalls = 0x1E76A78C,
		TopPeerCategoryPeers = 0xFB834291,
		ContactsTopPeersNotModified = 0xDE266EF5,
		ContactsTopPeers = 0x70B772A8,
		DraftMessageEmpty = 0xBA4BAEC5,
		DraftMessage = 0xFD8E711F,
		MessagesFeaturedStickersNotModified = 0x4EDE3CF,
		MessagesFeaturedStickers = 0xF89D88E5,
		MessagesRecentStickersNotModified = 0xB17F890,
		MessagesRecentStickers = 0x5CE20970,
		MessagesArchivedStickers = 0x4FCBA9C8,
		MessagesStickerSetInstallResultSuccess = 0x38641628,
		MessagesStickerSetInstallResultArchive = 0x35E410A8,
		StickerSetCovered = 0x6410A5D2,
		StickerSetMultiCovered = 0x3407E51B,
		MaskCoords = 0xAED6DBB2,
		InputStickeredMediaPhoto = 0x4A992157,
		InputStickeredMediaDocument = 0x438865B,
		Game = 0xBDF9653B,
		InputGameID = 0x32C3E77,
		InputGameShortName = 0xC331E80A,
		HighScore = 0x58FFFCD0,
		MessagesHighScores = 0x9A3BFD99,
		TextEmpty = 0xDC3D824F,
		TextPlain = 0x744694E0,
		TextBold = 0x6724ABC4,
		TextItalic = 0xD912A59C,
		TextUnderline = 0xC12622C4,
		TextStrike = 0x9BF8BB95,
		TextFixed = 0x6C3F19B9,
		TextUrl = 0x3C2884C1,
		TextEmail = 0xDE5A0DD6,
		TextConcat = 0x7E6260D7,
		PageBlockUnsupported = 0x13567E8A,
		PageBlockTitle = 0x70ABC3FD,
		PageBlockSubtitle = 0x8FFA9A1F,
		PageBlockAuthorDate = 0xBAAFE5E0,
		PageBlockHeader = 0xBFD064EC,
		PageBlockSubheader = 0xF12BB6E1,
		PageBlockParagraph = 0x467A0766,
		PageBlockPreformatted = 0xC070D93E,
		PageBlockFooter = 0x48870999,
		PageBlockDivider = 0xDB20B188,
		PageBlockAnchor = 0xCE0D37B0,
		PageBlockList = 0x3A58C7F4,
		PageBlockBlockquote = 0x263D7C26,
		PageBlockPullquote = 0x4F4456D3,
		PageBlockPhoto = 0xE9C69982,
		PageBlockVideo = 0xD9D71866,
		PageBlockCover = 0x39F23300,
		PageBlockEmbed = 0xCDE200D1,
		PageBlockEmbedPost = 0x292C7BE9,
		PageBlockCollage = 0x8B31C4F,
		PageBlockSlideshow = 0x130C8963,
		PageBlockChannel = 0xEF1751B5,
		PageBlockAudio = 0x31B81A7F,
		PagePart = 0x8E3F9EBE,
		PageFull = 0x556EC7AA,
		PhoneCallDiscardReasonMissed = 0x85E42301,
		PhoneCallDiscardReasonDisconnect = 0xE095C1A0,
		PhoneCallDiscardReasonHangup = 0x57ADC690,
		PhoneCallDiscardReasonBusy = 0xFAF7E8C9,
		DataJSON = 0x7D748D04,
		LabeledPrice = 0xCB296BF8,
		Invoice = 0xC30AA358,
		PaymentCharge = 0xEA02C27E,
		PostAddress = 0x1E8CAAEB,
		PaymentRequestedInfo = 0x909C3F94,
		PaymentSavedCredentialsCard = 0xCDC27A1F,
		WebDocument = 0xC61ACBD8,
		InputWebDocument = 0x9BED434D,
		InputWebFileLocation = 0xC239D686,
		UploadWebFile = 0x21E753BC,
		PaymentsPaymentForm = 0x3F56AEA3,
		PaymentsValidatedRequestedInfo = 0xD1451883,
		PaymentsPaymentResult = 0x4E5F810D,
		PaymentsPaymentVerficationNeeded = 0x6B56B921,
		PaymentsPaymentReceipt = 0x500911E1,
		PaymentsSavedInfo = 0xFB8FE43C,
		InputPaymentCredentialsSaved = 0xC10EB2CF,
		InputPaymentCredentials = 0x3417D728,
		AccountTmpPassword = 0xDB64FD34,
		ShippingOption = 0xB6213CDF,
		InputStickerSetItem = 0xFFA0A496,
		InputPhoneCall = 0x1E36FDED,
		PhoneCallEmpty = 0x5366C915,
		PhoneCallWaiting = 0x1B8F4AD1,
		PhoneCallRequested = 0x83761CE4,
		PhoneCallAccepted = 0x6D003D3F,
		PhoneCall = 0xFFE6AB67,
		PhoneCallDiscarded = 0x50CA4DE1,
		PhoneConnection = 0x9D4C17C0,
		PhoneCallProtocol = 0xA2BB35CB,
		PhonePhoneCall = 0xEC82E140,
		UploadCdnFileReuploadNeeded = 0xEEA8E46E,
		UploadCdnFile = 0xA99FCA4F,
		LangPackString = 0xCAD181F6,
		LangPackStringPluralized = 0x6C47AC9F,
		LangPackStringDeleted = 0x2979EEB2,
		LangPackDifference = 0xF385C1F6,
		LangPackLanguage = 0x117698F1,
		ChannelAdminRights = 0x5D7CEBA5,
		ChannelBannedRights = 0x58CF4249,
		ChannelAdminLogEventActionChangeTitle = 0xE6DFB825,
		ChannelAdminLogEventActionChangeAbout = 0x55188A2E,
		ChannelAdminLogEventActionChangeUsername = 0x6A4AFC38,
		ChannelAdminLogEventActionChangePhoto = 0xB82F55C3,
		ChannelAdminLogEventActionToggleInvites = 0x1B7907AE,
		ChannelAdminLogEventActionToggleSignatures = 0x26AE0971,
		ChannelAdminLogEventActionUpdatePinned = 0xE9E82C18,
		ChannelAdminLogEventActionEditMessage = 0x709B2405,
		ChannelAdminLogEventActionDeleteMessage = 0x42E047BB,
		ChannelAdminLogEventActionParticipantJoin = 0x183040D3,
		ChannelAdminLogEventActionParticipantLeave = 0xF89777F2,
		ChannelAdminLogEventActionParticipantInvite = 0xE31C34D8,
		ChannelAdminLogEventActionParticipantToggleBan = 0xE6D83D7E,
		ChannelAdminLogEventActionParticipantToggleAdmin = 0xD5676710,
		ChannelAdminLogEventActionChangeStickerSet = 0xB1C3CAA7,
		ChannelAdminLogEventActionTogglePreHistoryHidden = 0x5F5C95F1,
		ChannelAdminLogEvent = 0x3B5A3E40,
		ChannelsAdminLogResults = 0xED8AF74D,
		ChannelAdminLogEventsFilter = 0xEA107AE4,
		PopularContact = 0x5CE14175,
		CdnFileHash = 0x77EEC38F,
		MessagesFavedStickersNotModified = 0x9E8FA6D3,
		MessagesFavedStickers = 0xF37F2F16,
		HelpRecentMeUrls = 0xE0310D7,
		RecentMeUrlUser = 0x8DBC3336,
		RecentMeUrlChat = 0xA01B22F9,
		RecentMeUrlStickerSet = 0xBC0A57DC,
		RecentMeUrlChatInvite = 0xEB49081D,
		RecentMeUrlUnknown = 0x46E1D13D,
		InvokeAfterMsg = 0xCB9F372D,
		InvokeAfterMsgs = 0x3DC4B4F0,
		InitConnection = 0xC7481DA6,
		InvokeWithLayer = 0xDA9B0D0D,
		InvokeWithoutUpdates = 0xBF9459B7,
		AuthCheckPhone = 0x6FE51DFB,
		AuthSendCode = 0x86AEF0EC,
		AuthSignUp = 0x1B067634,
		AuthSignIn = 0xBCD51581,
		AuthLogOut = 0x5717DA40,
		AuthResetAuthorizations = 0x9FAB0D1A,
		AuthSendInvites = 0x771C1D97,
		AuthExportAuthorization = 0xE5BFFFCD,
		AuthImportAuthorization = 0xE3EF9613,
		AuthBindTempAuthKey = 0xCDD42A05,
		AuthImportBotAuthorization = 0x67A3FF2C,
		AuthCheckPassword = 0xA63011E,
		AuthRequestPasswordRecovery = 0xD897BC66,
		AuthRecoverPassword = 0x4EA56E92,
		AuthResendCode = 0x3EF1A9BF,
		AuthCancelCode = 0x1F040578,
		AuthDropTempAuthKeys = 0x8E48A188,
		AccountRegisterDevice = 0x637EA878,
		AccountUnregisterDevice = 0x65C55B40,
		AccountUpdateNotifySettings = 0x84BE5B93,
		AccountGetNotifySettings = 0x12B3AD31,
		AccountResetNotifySettings = 0xDB7E1747,
		AccountUpdateProfile = 0x78515775,
		AccountUpdateStatus = 0x6628562C,
		AccountGetWallPapers = 0xC04CFAC2,
		AccountReportPeer = 0xAE189D5F,
		AccountCheckUsername = 0x2714D86C,
		AccountUpdateUsername = 0x3E0BDD7C,
		AccountGetPrivacy = 0xDADBC950,
		AccountSetPrivacy = 0xC9F81CE8,
		AccountDeleteAccount = 0x418D4E0B,
		AccountGetAccountTTL = 0x8FC711D,
		AccountSetAccountTTL = 0x2442485E,
		AccountSendChangePhoneCode = 0x8E57DEB,
		AccountChangePhone = 0x70C32EDB,
		AccountUpdateDeviceLocked = 0x38DF3532,
		AccountGetAuthorizations = 0xE320C158,
		AccountResetAuthorization = 0xDF77F3BC,
		AccountGetPassword = 0x548A30F5,
		AccountGetPasswordSettings = 0xBC8D11BB,
		AccountUpdatePasswordSettings = 0xFA7C4B86,
		AccountSendConfirmPhoneCode = 0x1516D7BD,
		AccountConfirmPhone = 0x5F2178C3,
		AccountGetTmpPassword = 0x4A82327E,
		UsersGetUsers = 0xD91A548,
		UsersGetFullUser = 0xCA30A5B1,
		ContactsGetStatuses = 0xC4A353EE,
		ContactsGetContacts = 0xC023849F,
		ContactsImportContacts = 0x2C800BE5,
		ContactsDeleteContact = 0x8E953744,
		ContactsDeleteContacts = 0x59AB389E,
		ContactsBlock = 0x332B49FC,
		ContactsUnblock = 0xE54100BD,
		ContactsGetBlocked = 0xF57C350F,
		ContactsExportCard = 0x84E53737,
		ContactsImportCard = 0x4FE196FE,
		ContactsSearch = 0x11F812D8,
		ContactsResolveUsername = 0xF93CCBA3,
		ContactsGetTopPeers = 0xD4982DB5,
		ContactsResetTopPeerRating = 0x1AE373AC,
		ContactsResetSaved = 0x879537F1,
		MessagesGetMessages = 0x4222FA74,
		MessagesGetDialogs = 0x191BA9C5,
		MessagesGetHistory = 0xAFA92846,
		MessagesSearch = 0x39E9EA0,
		MessagesReadHistory = 0xE306D3A,
		MessagesDeleteHistory = 0x1C015B09,
		MessagesDeleteMessages = 0xE58E95D2,
		MessagesReceivedMessages = 0x5A954C0,
		MessagesSetTyping = 0xA3825E50,
		MessagesSendMessage = 0xFA88427A,
		MessagesSendMedia = 0xC8F16791,
		MessagesForwardMessages = 0x708E0195,
		MessagesReportSpam = 0xCF1592DB,
		MessagesHideReportSpam = 0xA8F1709B,
		MessagesGetPeerSettings = 0x3672E09C,
		MessagesGetChats = 0x3C6AA187,
		MessagesGetFullChat = 0x3B831C66,
		MessagesEditChatTitle = 0xDC452855,
		MessagesEditChatPhoto = 0xCA4C79D8,
		MessagesAddChatUser = 0xF9A0AA09,
		MessagesDeleteChatUser = 0xE0611F16,
		MessagesCreateChat = 0x9CB126E,
		MessagesForwardMessage = 0x33963BF9,
		MessagesGetDHConfig = 0x26CF8950,
		MessagesRequestEncryption = 0xF64DAF43,
		MessagesAcceptEncryption = 0x3DBC0415,
		MessagesDiscardEncryption = 0xEDD923C5,
		MessagesSetEncryptedTyping = 0x791451ED,
		MessagesReadEncryptedHistory = 0x7F4B690A,
		MessagesSendEncrypted = 0xA9776773,
		MessagesSendEncryptedFile = 0x9A901B66,
		MessagesSendEncryptedService = 0x32D439A4,
		MessagesReceivedQueue = 0x55A5BB66,
		MessagesReportEncryptedSpam = 0x4B0C8C0F,
		MessagesReadMessageContents = 0x36A73F77,
		MessagesGetAllStickers = 0x1C9618B1,
		MessagesGetWebPagePreview = 0x25223E24,
		MessagesExportChatInvite = 0x7D885289,
		MessagesCheckChatInvite = 0x3EADB1BB,
		MessagesImportChatInvite = 0x6C50051C,
		MessagesGetStickerSet = 0x2619A90E,
		MessagesInstallStickerSet = 0xC78FE460,
		MessagesUninstallStickerSet = 0xF96E55DE,
		MessagesStartBot = 0xE6DF7378,
		MessagesGetMessagesViews = 0xC4C8A55D,
		MessagesToggleChatAdmins = 0xEC8BD9E1,
		MessagesEditChatAdmin = 0xA9E69F2E,
		MessagesMigrateChat = 0x15A3B8E3,
		MessagesSearchGlobal = 0x9E3CACB0,
		MessagesReorderStickerSets = 0x78337739,
		MessagesGetDocumentByHash = 0x338E2464,
		MessagesSearchGifs = 0xBF9A776B,
		MessagesGetSavedGifs = 0x83BF3D52,
		MessagesSaveGif = 0x327A30CB,
		MessagesGetInlineBotResults = 0x514E999D,
		MessagesSetInlineBotResults = 0xEB5EA206,
		MessagesSendInlineBotResult = 0xB16E06FE,
		MessagesGetMessageEditData = 0xFDA68D36,
		MessagesEditMessage = 0x5D1B8DD,
		MessagesEditInlineBotMessage = 0x130C2C85,
		MessagesGetBotCallbackAnswer = 0x810A9FEC,
		MessagesSetBotCallbackAnswer = 0xD58F130A,
		MessagesGetPeerDialogs = 0x2D9776B9,
		MessagesSaveDraft = 0xBC39E14B,
		MessagesGetAllDrafts = 0x6A3F8D65,
		MessagesGetFeaturedStickers = 0x2DACCA4F,
		MessagesReadFeaturedStickers = 0x5B118126,
		MessagesGetRecentStickers = 0x5EA192C9,
		MessagesSaveRecentSticker = 0x392718F8,
		MessagesClearRecentStickers = 0x8999602D,
		MessagesGetArchivedStickers = 0x57F17692,
		MessagesGetMaskStickers = 0x65B8C79F,
		MessagesGetAttachedStickers = 0xCC5B67CC,
		MessagesSetGameScore = 0x8EF8ECC0,
		MessagesSetInlineGameScore = 0x15AD9F64,
		MessagesGetGameHighScores = 0xE822649D,
		MessagesGetInlineGameHighScores = 0xF635E1B,
		MessagesGetCommonChats = 0xD0A48C4,
		MessagesGetAllChats = 0xEBA80FF0,
		MessagesGetWebPage = 0x32CA8F91,
		MessagesToggleDialogPin = 0x3289BE6A,
		MessagesReorderPinnedDialogs = 0x959FF644,
		MessagesGetPinnedDialogs = 0xE254D64E,
		MessagesSetBotShippingResults = 0xE5F672FA,
		MessagesSetBotPrecheckoutResults = 0x9C2DD95,
		MessagesUploadMedia = 0x519BC2B1,
		MessagesSendScreenshotNotification = 0xC97DF020,
		MessagesGetFavedStickers = 0x21CE0B0E,
		MessagesFaveSticker = 0xB9FFC55B,
		MessagesGetUnreadMentions = 0x46578472,
		MessagesGetRecentLocations = 0x249431E2,
		MessagesReadMentions = 0xF0189D3,
		MessagesSendMultiMedia = 0x2095512F,
		UpdatesGetState = 0xEDD4882A,
		UpdatesGetDifference = 0x25939651,
		UpdatesGetChannelDifference = 0x3173D78,
		PhotosUpdateProfilePhoto = 0xF0BB5152,
		PhotosUploadProfilePhoto = 0x4F32C098,
		PhotosDeletePhotos = 0x87CF7F2F,
		PhotosGetUserPhotos = 0x91CD32A8,
		UploadSaveFilePart = 0xB304A621,
		UploadGetFile = 0xE3A6CFB5,
		UploadSaveBigFilePart = 0xDE7B673D,
		UploadGetWebFile = 0x24E6818D,
		UploadGetCdnFile = 0x2000BCC3,
		UploadReuploadCdnFile = 0x1AF91C09,
		UploadGetCdnFileHashes = 0xF715C87B,
		HelpGetConfig = 0xC4F9186B,
		HelpGetNearestDC = 0x1FB33026,
		HelpGetAppUpdate = 0xAE2DE196,
		HelpSaveAppLog = 0x6F02F748,
		HelpGetInviteText = 0x4D392343,
		HelpGetSupport = 0x9CDF08CD,
		HelpGetAppChangelog = 0x9010EF6F,
		HelpGetTermsOfService = 0x350170F3,
		HelpSetBotUpdatesStatus = 0xEC22CFCD,
		HelpGetCdnConfig = 0x52029342,
		HelpGetRecentMeUrls = 0x3DC0F114,
		ChannelsReadHistory = 0xCC104937,
		ChannelsDeleteMessages = 0x84C1FD4E,
		ChannelsDeleteUserHistory = 0xD10DD71B,
		ChannelsReportSpam = 0xFE087810,
		ChannelsGetMessages = 0x93D7B347,
		ChannelsGetParticipants = 0x123E05E9,
		ChannelsGetParticipant = 0x546DD7A6,
		ChannelsGetChannels = 0xA7F6BBB,
		ChannelsGetFullChannel = 0x8736A09,
		ChannelsCreateChannel = 0xF4893D7F,
		ChannelsEditAbout = 0x13E27F1E,
		ChannelsEditAdmin = 0x20B88214,
		ChannelsEditTitle = 0x566DECD0,
		ChannelsEditPhoto = 0xF12E57C9,
		ChannelsCheckUsername = 0x10E6BD2C,
		ChannelsUpdateUsername = 0x3514B3DE,
		ChannelsJoinChannel = 0x24B524C5,
		ChannelsLeaveChannel = 0xF836AA95,
		ChannelsInviteToChannel = 0x199F3A6C,
		ChannelsExportInvite = 0xC7560885,
		ChannelsDeleteChannel = 0xC0111FE3,
		ChannelsToggleInvites = 0x49609307,
		ChannelsExportMessageLink = 0xC846D22D,
		ChannelsToggleSignatures = 0x1F69B606,
		ChannelsUpdatePinnedMessage = 0xA72DED52,
		ChannelsGetAdminedPublicChannels = 0x8D8D82D7,
		ChannelsEditBanned = 0xBFD915CD,
		ChannelsGetAdminLog = 0x33DDF480,
		ChannelsSetStickers = 0xEA8CA4F9,
		ChannelsReadMessageContents = 0xEAB5DC38,
		ChannelsDeleteHistory = 0xAF369D42,
		ChannelsTogglePreHistoryHidden = 0xEABBB94C,
		BotsSendCustomRequest = 0xAA2769ED,
		BotsAnswerWebhookJSONQuery = 0xE6213F4D,
		PaymentsGetPaymentForm = 0x99F09745,
		PaymentsGetPaymentReceipt = 0xA092A980,
		PaymentsValidateRequestedInfo = 0x770A8E74,
		PaymentsSendPaymentForm = 0x2B8879B3,
		PaymentsGetSavedInfo = 0x227D824B,
		PaymentsClearSavedInfo = 0xD83D70C1,
		StickersCreateStickerSet = 0x9BD86E6A,
		StickersRemoveStickerFromSet = 0xF7760F51,
		StickersChangeStickerPosition = 0xFFB6D4CA,
		StickersAddStickerToSet = 0x8653FEBE,
		PhoneGetCallConfig = 0x55451FA9,
		PhoneRequestCall = 0x5B95B3D4,
		PhoneAcceptCall = 0x3BD2B4A0,
		PhoneConfirmCall = 0x2EFE1722,
		PhoneReceivedCall = 0x17D54F61,
		PhoneDiscardCall = 0x78D413A6,
		PhoneSetCallRating = 0x1C536A34,
		PhoneSaveCallDebug = 0x277ADD7E,
		LangPackGetLangPack = 0x9AB5C58E,
		LangPackGetStrings = 0x2E1EE318,
		LangPackGetDifference = 0xB2E4D7D,
		LangPackGetLanguages = 0x800FD57D,
	}
}