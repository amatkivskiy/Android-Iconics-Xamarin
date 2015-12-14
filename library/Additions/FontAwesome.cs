namespace Mikepenz.Typeface
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using Android.Util;
  using Mikepenz.Iconics.Typeface;

  public class FontAwesome : Java.Lang.Object, ITypeface
  {
	const string TtfFile = "fontawesome-webfont-v4.5.0.1.ttf";

    static Android.Graphics.Typeface _typeface = null;

    static Dictionary<string, Java.Lang.Character> _chars;

    public IIcon GetIcon(string key)
    {
      return Icon.Values.ToList().Find(icon => icon.Name.Equals(key));
    }

    public IDictionary<string, Java.Lang.Character> Characters
    {
      get
      {
        return _chars ?? (_chars = Icon.Values.ToDictionary(icon => icon.Name, icon => new Java.Lang.Character(icon.Character)));
      }
    }

    public ICollection<string> Icons
    {
      get
      {
        return Icon.Values.Select(icon => icon.Name).ToList();
      }
    }

    public Android.Graphics.Typeface GetTypeface(Android.Content.Context context)
    {
      if (_typeface == null)
      {
        try
        {
          _typeface = Android.Graphics.Typeface.CreateFromAsset(context.Assets, "fonts/" + TtfFile);
        }
        catch (Exception e)
        {
          Log.Error("Iconics", "Failed to load font from Assets: " + e.Message);
        }
      }
      return _typeface;
    }

    public string Author
    {
      get
      {
		return "Dave Gandy";
      }
    }

    public string Description
    {
      get
      {
		return "Font Awesome is a full suite of 479 pictographic icons for easy scalable vector graphics on websites, created and maintained by Dave Gandy. Stay up to date @fontawesome.";
      }
    }

    public string FontName
    {
      get
      {
		return "FontAwesome";
      }
    }

    public int IconCount
    {
      get
      {
        return _chars.Count;
      }
    }

    public string License
    {
      get
      {
		return "SIL OFL 1.1";
      }
    }

    public string LicenseUrl
    {
      get
      {
		return "http://scripts.sil.org/OFL";
      }
    }

    public string MappingPrefix
    {
      get
      {
        return "faw";
      }
    }

    public string Url
    {
      get
      {
		return "https://github.com/FortAwesome/Font-Awesome";
      }
    }

    public string Version
    {
      get
      {
		return "4.5.0.1";
      }
    }

    public class Icon : Java.Lang.Object, IIcon
    {
      readonly char character;
      readonly string name;

      static ITypeface _typeFace;

      public Icon(char character, string name)
      {
        this.character = character;
        this.name = name;
      }

      public char Character
      {
        get
        {
          return this.character;
        }
      }

      public string FormattedName
      {
        get
        {
          return "{" + this.name + "}";
        }
      }

      public string Name
      {
        get
        {
          return this.name;
        }
      }

      public ITypeface Typeface
      {
        get
        {
		  return _typeFace ?? (_typeFace = new FontAwesome());
        }
      }

      public static readonly Icon FawGlass = new Icon('\uf000', "faw_glass");
      public static readonly Icon FawMusic = new Icon('\uf001', "faw_music");
      public static readonly Icon FawSearch = new Icon('\uf002', "faw_search");
      public static readonly Icon FawEnvelopeO = new Icon('\uf003', "faw_envelope_o");
      public static readonly Icon FawHeart = new Icon('\uf004', "faw_heart");
      public static readonly Icon FawStar = new Icon('\uf005', "faw_star");
      public static readonly Icon FawStarO = new Icon('\uf006', "faw_star_o");
      public static readonly Icon FawUser = new Icon('\uf007', "faw_user");
      public static readonly Icon FawFilm = new Icon('\uf008', "faw_film");
      public static readonly Icon FawThLarge = new Icon('\uf009', "faw_th_large");
      public static readonly Icon FawTh = new Icon('\uf00a', "faw_th");
      public static readonly Icon FawThList = new Icon('\uf00b', "faw_th_list");
      public static readonly Icon FawCheck = new Icon('\uf00c', "faw_check");
      public static readonly Icon FawTimes = new Icon('\uf00d', "faw_times");
      public static readonly Icon FawSearchPlus = new Icon('\uf00e', "faw_search_plus");
      public static readonly Icon FawSearchMinus = new Icon('\uf010', "faw_search_minus");
      public static readonly Icon FawPowerOff = new Icon('\uf011', "faw_power_off");
      public static readonly Icon FawSignal = new Icon('\uf012', "faw_signal");
      public static readonly Icon FawCog = new Icon('\uf013', "faw_cog");
      public static readonly Icon FawTrashO = new Icon('\uf014', "faw_trash_o");
      public static readonly Icon FawHome = new Icon('\uf015', "faw_home");
      public static readonly Icon FawFileO = new Icon('\uf016', "faw_file_o");
      public static readonly Icon FawClockO = new Icon('\uf017', "faw_clock_o");
      public static readonly Icon FawRoad = new Icon('\uf018', "faw_road");
      public static readonly Icon FawDownload = new Icon('\uf019', "faw_download");
      public static readonly Icon FawArrowCircleODown = new Icon('\uf01a', "faw_arrow_circle_o_down");
      public static readonly Icon FawArrowCircleOUp = new Icon('\uf01b', "faw_arrow_circle_o_up");
      public static readonly Icon FawInbox = new Icon('\uf01c', "faw_inbox");
      public static readonly Icon FawPlayCircleO = new Icon('\uf01d', "faw_play_circle_o");
      public static readonly Icon FawRepeat = new Icon('\uf01e', "faw_repeat");
      public static readonly Icon FawRefresh = new Icon('\uf021', "faw_refresh");
      public static readonly Icon FawListAlt = new Icon('\uf022', "faw_list_alt");
      public static readonly Icon FawLock = new Icon('\uf023', "faw_lock");
      public static readonly Icon FawFlag = new Icon('\uf024', "faw_flag");
      public static readonly Icon FawHeadphones = new Icon('\uf025', "faw_headphones");
      public static readonly Icon FawVolumeOff = new Icon('\uf026', "faw_volume_off");
      public static readonly Icon FawVolumeDown = new Icon('\uf027', "faw_volume_down");
      public static readonly Icon FawVolumeUp = new Icon('\uf028', "faw_volume_up");
      public static readonly Icon FawQrcode = new Icon('\uf029', "faw_qrcode");
      public static readonly Icon FawBarcode = new Icon('\uf02a', "faw_barcode");
      public static readonly Icon FawTag = new Icon('\uf02b', "faw_tag");
      public static readonly Icon FawTags = new Icon('\uf02c', "faw_tags");
      public static readonly Icon FawBook = new Icon('\uf02d', "faw_book");
      public static readonly Icon FawBookmark = new Icon('\uf02e', "faw_bookmark");
      public static readonly Icon FawPrint = new Icon('\uf02f', "faw_print");
      public static readonly Icon FawCamera = new Icon('\uf030', "faw_camera");
      public static readonly Icon FawFont = new Icon('\uf031', "faw_font");
      public static readonly Icon FawBold = new Icon('\uf032', "faw_bold");
      public static readonly Icon FawItalic = new Icon('\uf033', "faw_italic");
      public static readonly Icon FawTextHeight = new Icon('\uf034', "faw_text_height");
      public static readonly Icon FawTextWidth = new Icon('\uf035', "faw_text_width");
      public static readonly Icon FawAlignLeft = new Icon('\uf036', "faw_align_left");
      public static readonly Icon FawAlignCenter = new Icon('\uf037', "faw_align_center");
      public static readonly Icon FawAlignRight = new Icon('\uf038', "faw_align_right");
      public static readonly Icon FawAlignJustify = new Icon('\uf039', "faw_align_justify");
      public static readonly Icon FawList = new Icon('\uf03a', "faw_list");
      public static readonly Icon FawOutdent = new Icon('\uf03b', "faw_outdent");
      public static readonly Icon FawIndent = new Icon('\uf03c', "faw_indent");
      public static readonly Icon FawVideoCamera = new Icon('\uf03d', "faw_video_camera");
      public static readonly Icon FawPictureO = new Icon('\uf03e', "faw_picture_o");
      public static readonly Icon FawPencil = new Icon('\uf040', "faw_pencil");
      public static readonly Icon FawMapMarker = new Icon('\uf041', "faw_map_marker");
      public static readonly Icon FawAdjust = new Icon('\uf042', "faw_adjust");
      public static readonly Icon FawTint = new Icon('\uf043', "faw_tint");
      public static readonly Icon FawPencilSquareO = new Icon('\uf044', "faw_pencil_square_o");
      public static readonly Icon FawShareSquareO = new Icon('\uf045', "faw_share_square_o");
      public static readonly Icon FawCheckSquareO = new Icon('\uf046', "faw_check_square_o");
      public static readonly Icon FawArrows = new Icon('\uf047', "faw_arrows");
      public static readonly Icon FawStepBackward = new Icon('\uf048', "faw_step_backward");
      public static readonly Icon FawFastBackward = new Icon('\uf049', "faw_fast_backward");
      public static readonly Icon FawBackward = new Icon('\uf04a', "faw_backward");
      public static readonly Icon FawPlay = new Icon('\uf04b', "faw_play");
      public static readonly Icon FawPause = new Icon('\uf04c', "faw_pause");
      public static readonly Icon FawStop = new Icon('\uf04d', "faw_stop");
      public static readonly Icon FawForward = new Icon('\uf04e', "faw_forward");
      public static readonly Icon FawFastForward = new Icon('\uf050', "faw_fast_forward");
      public static readonly Icon FawStepForward = new Icon('\uf051', "faw_step_forward");
      public static readonly Icon FawEject = new Icon('\uf052', "faw_eject");
      public static readonly Icon FawChevronLeft = new Icon('\uf053', "faw_chevron_left");
      public static readonly Icon FawChevronRight = new Icon('\uf054', "faw_chevron_right");
      public static readonly Icon FawPlusCircle = new Icon('\uf055', "faw_plus_circle");
      public static readonly Icon FawMinusCircle = new Icon('\uf056', "faw_minus_circle");
      public static readonly Icon FawTimesCircle = new Icon('\uf057', "faw_times_circle");
      public static readonly Icon FawCheckCircle = new Icon('\uf058', "faw_check_circle");
      public static readonly Icon FawQuestionCircle = new Icon('\uf059', "faw_question_circle");
      public static readonly Icon FawInfoCircle = new Icon('\uf05a', "faw_info_circle");
      public static readonly Icon FawCrosshairs = new Icon('\uf05b', "faw_crosshairs");
      public static readonly Icon FawTimesCircleO = new Icon('\uf05c', "faw_times_circle_o");
      public static readonly Icon FawCheckCircleO = new Icon('\uf05d', "faw_check_circle_o");
      public static readonly Icon FawBan = new Icon('\uf05e', "faw_ban");
      public static readonly Icon FawArrowLeft = new Icon('\uf060', "faw_arrow_left");
      public static readonly Icon FawArrowRight = new Icon('\uf061', "faw_arrow_right");
      public static readonly Icon FawArrowUp = new Icon('\uf062', "faw_arrow_up");
      public static readonly Icon FawArrowDown = new Icon('\uf063', "faw_arrow_down");
      public static readonly Icon FawShare = new Icon('\uf064', "faw_share");
      public static readonly Icon FawExpand = new Icon('\uf065', "faw_expand");
      public static readonly Icon FawCompress = new Icon('\uf066', "faw_compress");
      public static readonly Icon FawPlus = new Icon('\uf067', "faw_plus");
      public static readonly Icon FawMinus = new Icon('\uf068', "faw_minus");
      public static readonly Icon FawAsterisk = new Icon('\uf069', "faw_asterisk");
      public static readonly Icon FawExclamationCircle = new Icon('\uf06a', "faw_exclamation_circle");
      public static readonly Icon FawGift = new Icon('\uf06b', "faw_gift");
      public static readonly Icon FawLeaf = new Icon('\uf06c', "faw_leaf");
      public static readonly Icon FawFire = new Icon('\uf06d', "faw_fire");
      public static readonly Icon FawEye = new Icon('\uf06e', "faw_eye");
      public static readonly Icon FawEyeSlash = new Icon('\uf070', "faw_eye_slash");
      public static readonly Icon FawExclamationTriangle = new Icon('\uf071', "faw_exclamation_triangle");
      public static readonly Icon FawPlane = new Icon('\uf072', "faw_plane");
      public static readonly Icon FawCalendar = new Icon('\uf073', "faw_calendar");
      public static readonly Icon FawRandom = new Icon('\uf074', "faw_random");
      public static readonly Icon FawComment = new Icon('\uf075', "faw_comment");
      public static readonly Icon FawMagnet = new Icon('\uf076', "faw_magnet");
      public static readonly Icon FawChevronUp = new Icon('\uf077', "faw_chevron_up");
      public static readonly Icon FawChevronDown = new Icon('\uf078', "faw_chevron_down");
      public static readonly Icon FawRetweet = new Icon('\uf079', "faw_retweet");
      public static readonly Icon FawShoppingCart = new Icon('\uf07a', "faw_shopping_cart");
      public static readonly Icon FawFolder = new Icon('\uf07b', "faw_folder");
      public static readonly Icon FawFolderOpen = new Icon('\uf07c', "faw_folder_open");
      public static readonly Icon FawArrowsV = new Icon('\uf07d', "faw_arrows_v");
      public static readonly Icon FawArrowsH = new Icon('\uf07e', "faw_arrows_h");
      public static readonly Icon FawBarChart = new Icon('\uf080', "faw_bar_chart");
      public static readonly Icon FawTwitterSquare = new Icon('\uf081', "faw_twitter_square");
      public static readonly Icon FawFacebookSquare = new Icon('\uf082', "faw_facebook_square");
      public static readonly Icon FawCameraRetro = new Icon('\uf083', "faw_camera_retro");
      public static readonly Icon FawKey = new Icon('\uf084', "faw_key");
      public static readonly Icon FawCogs = new Icon('\uf085', "faw_cogs");
      public static readonly Icon FawComments = new Icon('\uf086', "faw_comments");
      public static readonly Icon FawThumbsOUp = new Icon('\uf087', "faw_thumbs_o_up");
      public static readonly Icon FawThumbsODown = new Icon('\uf088', "faw_thumbs_o_down");
      public static readonly Icon FawStarHalf = new Icon('\uf089', "faw_star_half");
      public static readonly Icon FawHeartO = new Icon('\uf08a', "faw_heart_o");
      public static readonly Icon FawSignOut = new Icon('\uf08b', "faw_sign_out");
      public static readonly Icon FawLinkedinSquare = new Icon('\uf08c', "faw_linkedin_square");
      public static readonly Icon FawThumbTack = new Icon('\uf08d', "faw_thumb_tack");
      public static readonly Icon FawExternalLink = new Icon('\uf08e', "faw_external_link");
      public static readonly Icon FawSignIn = new Icon('\uf090', "faw_sign_in");
      public static readonly Icon FawTrophy = new Icon('\uf091', "faw_trophy");
      public static readonly Icon FawGithubSquare = new Icon('\uf092', "faw_github_square");
      public static readonly Icon FawUpload = new Icon('\uf093', "faw_upload");
      public static readonly Icon FawLemonO = new Icon('\uf094', "faw_lemon_o");
      public static readonly Icon FawPhone = new Icon('\uf095', "faw_phone");
      public static readonly Icon FawSquareO = new Icon('\uf096', "faw_square_o");
      public static readonly Icon FawBookmarkO = new Icon('\uf097', "faw_bookmark_o");
      public static readonly Icon FawPhoneSquare = new Icon('\uf098', "faw_phone_square");
      public static readonly Icon FawTwitter = new Icon('\uf099', "faw_twitter");
      public static readonly Icon FawFacebook = new Icon('\uf09a', "faw_facebook");
      public static readonly Icon FawGithub = new Icon('\uf09b', "faw_github");
      public static readonly Icon FawUnlock = new Icon('\uf09c', "faw_unlock");
      public static readonly Icon FawCreditCard = new Icon('\uf09d', "faw_credit_card");
      public static readonly Icon FawRss = new Icon('\uf09e', "faw_rss");
      public static readonly Icon FawHddO = new Icon('\uf0a0', "faw_hdd_o");
      public static readonly Icon FawBullhorn = new Icon('\uf0a1', "faw_bullhorn");
      public static readonly Icon FawBell = new Icon('\uf0f3', "faw_bell");
      public static readonly Icon FawCertificate = new Icon('\uf0a3', "faw_certificate");
      public static readonly Icon FawHandORight = new Icon('\uf0a4', "faw_hand_o_right");
      public static readonly Icon FawHandOLeft = new Icon('\uf0a5', "faw_hand_o_left");
      public static readonly Icon FawHandOUp = new Icon('\uf0a6', "faw_hand_o_up");
      public static readonly Icon FawHandODown = new Icon('\uf0a7', "faw_hand_o_down");
      public static readonly Icon FawArrowCircleLeft = new Icon('\uf0a8', "faw_arrow_circle_left");
      public static readonly Icon FawArrowCircleRight = new Icon('\uf0a9', "faw_arrow_circle_right");
      public static readonly Icon FawArrowCircleUp = new Icon('\uf0aa', "faw_arrow_circle_up");
      public static readonly Icon FawArrowCircleDown = new Icon('\uf0ab', "faw_arrow_circle_down");
      public static readonly Icon FawGlobe = new Icon('\uf0ac', "faw_globe");
      public static readonly Icon FawWrench = new Icon('\uf0ad', "faw_wrench");
      public static readonly Icon FawTasks = new Icon('\uf0ae', "faw_tasks");
      public static readonly Icon FawFilter = new Icon('\uf0b0', "faw_filter");
      public static readonly Icon FawBriefcase = new Icon('\uf0b1', "faw_briefcase");
      public static readonly Icon FawArrowsAlt = new Icon('\uf0b2', "faw_arrows_alt");
      public static readonly Icon FawUsers = new Icon('\uf0c0', "faw_users");
      public static readonly Icon FawLink = new Icon('\uf0c1', "faw_link");
      public static readonly Icon FawCloud = new Icon('\uf0c2', "faw_cloud");
      public static readonly Icon FawFlask = new Icon('\uf0c3', "faw_flask");
      public static readonly Icon FawScissors = new Icon('\uf0c4', "faw_scissors");
      public static readonly Icon FawFilesO = new Icon('\uf0c5', "faw_files_o");
      public static readonly Icon FawPaperclip = new Icon('\uf0c6', "faw_paperclip");
      public static readonly Icon FawFloppyO = new Icon('\uf0c7', "faw_floppy_o");
      public static readonly Icon FawSquare = new Icon('\uf0c8', "faw_square");
      public static readonly Icon FawBars = new Icon('\uf0c9', "faw_bars");
      public static readonly Icon FawListUl = new Icon('\uf0ca', "faw_list_ul");
      public static readonly Icon FawListOl = new Icon('\uf0cb', "faw_list_ol");
      public static readonly Icon FawStrikethrough = new Icon('\uf0cc', "faw_strikethrough");
      public static readonly Icon FawUnderline = new Icon('\uf0cd', "faw_underline");
      public static readonly Icon FawTable = new Icon('\uf0ce', "faw_table");
      public static readonly Icon FawMagic = new Icon('\uf0d0', "faw_magic");
      public static readonly Icon FawTruck = new Icon('\uf0d1', "faw_truck");
      public static readonly Icon FawPinterest = new Icon('\uf0d2', "faw_pinterest");
      public static readonly Icon FawPinterestSquare = new Icon('\uf0d3', "faw_pinterest_square");
      public static readonly Icon FawGooglePlusSquare = new Icon('\uf0d4', "faw_google_plus_square");
      public static readonly Icon FawGooglePlus = new Icon('\uf0d5', "faw_google_plus");
      public static readonly Icon FawMoney = new Icon('\uf0d6', "faw_money");
      public static readonly Icon FawCaretDown = new Icon('\uf0d7', "faw_caret_down");
      public static readonly Icon FawCaretUp = new Icon('\uf0d8', "faw_caret_up");
      public static readonly Icon FawCaretLeft = new Icon('\uf0d9', "faw_caret_left");
      public static readonly Icon FawCaretRight = new Icon('\uf0da', "faw_caret_right");
      public static readonly Icon FawColumns = new Icon('\uf0db', "faw_columns");
      public static readonly Icon FawSort = new Icon('\uf0dc', "faw_sort");
      public static readonly Icon FawSortDesc = new Icon('\uf0dd', "faw_sort_desc");
      public static readonly Icon FawSortAsc = new Icon('\uf0de', "faw_sort_asc");
      public static readonly Icon FawEnvelope = new Icon('\uf0e0', "faw_envelope");
      public static readonly Icon FawLinkedin = new Icon('\uf0e1', "faw_linkedin");
      public static readonly Icon FawUndo = new Icon('\uf0e2', "faw_undo");
      public static readonly Icon FawGavel = new Icon('\uf0e3', "faw_gavel");
      public static readonly Icon FawTachometer = new Icon('\uf0e4', "faw_tachometer");
      public static readonly Icon FawCommentO = new Icon('\uf0e5', "faw_comment_o");
      public static readonly Icon FawCommentsO = new Icon('\uf0e6', "faw_comments_o");
      public static readonly Icon FawBolt = new Icon('\uf0e7', "faw_bolt");
      public static readonly Icon FawSitemap = new Icon('\uf0e8', "faw_sitemap");
      public static readonly Icon FawUmbrella = new Icon('\uf0e9', "faw_umbrella");
      public static readonly Icon FawClipboard = new Icon('\uf0ea', "faw_clipboard");
      public static readonly Icon FawLightbulbO = new Icon('\uf0eb', "faw_lightbulb_o");
      public static readonly Icon FawExchange = new Icon('\uf0ec', "faw_exchange");
      public static readonly Icon FawCloudDownload = new Icon('\uf0ed', "faw_cloud_download");
      public static readonly Icon FawCloudUpload = new Icon('\uf0ee', "faw_cloud_upload");
      public static readonly Icon FawUserMd = new Icon('\uf0f0', "faw_user_md");
      public static readonly Icon FawStethoscope = new Icon('\uf0f1', "faw_stethoscope");
      public static readonly Icon FawSuitcase = new Icon('\uf0f2', "faw_suitcase");
      public static readonly Icon FawBellO = new Icon('\uf0a2', "faw_bell_o");
      public static readonly Icon FawCoffee = new Icon('\uf0f4', "faw_coffee");
      public static readonly Icon FawCutlery = new Icon('\uf0f5', "faw_cutlery");
      public static readonly Icon FawFileTextO = new Icon('\uf0f6', "faw_file_text_o");
      public static readonly Icon FawBuildingO = new Icon('\uf0f7', "faw_building_o");
      public static readonly Icon FawHospitalO = new Icon('\uf0f8', "faw_hospital_o");
      public static readonly Icon FawAmbulance = new Icon('\uf0f9', "faw_ambulance");
      public static readonly Icon FawMedkit = new Icon('\uf0fa', "faw_medkit");
      public static readonly Icon FawFighterJet = new Icon('\uf0fb', "faw_fighter_jet");
      public static readonly Icon FawBeer = new Icon('\uf0fc', "faw_beer");
      public static readonly Icon FawHSquare = new Icon('\uf0fd', "faw_h_square");
      public static readonly Icon FawPlusSquare = new Icon('\uf0fe', "faw_plus_square");
      public static readonly Icon FawAngleDoubleLeft = new Icon('\uf100', "faw_angle_double_left");
      public static readonly Icon FawAngleDoubleRight = new Icon('\uf101', "faw_angle_double_right");
      public static readonly Icon FawAngleDoubleUp = new Icon('\uf102', "faw_angle_double_up");
      public static readonly Icon FawAngleDoubleDown = new Icon('\uf103', "faw_angle_double_down");
      public static readonly Icon FawAngleLeft = new Icon('\uf104', "faw_angle_left");
      public static readonly Icon FawAngleRight = new Icon('\uf105', "faw_angle_right");
      public static readonly Icon FawAngleUp = new Icon('\uf106', "faw_angle_up");
      public static readonly Icon FawAngleDown = new Icon('\uf107', "faw_angle_down");
      public static readonly Icon FawDesktop = new Icon('\uf108', "faw_desktop");
      public static readonly Icon FawLaptop = new Icon('\uf109', "faw_laptop");
      public static readonly Icon FawTablet = new Icon('\uf10a', "faw_tablet");
      public static readonly Icon FawMobile = new Icon('\uf10b', "faw_mobile");
      public static readonly Icon FawCircleO = new Icon('\uf10c', "faw_circle_o");
      public static readonly Icon FawQuoteLeft = new Icon('\uf10d', "faw_quote_left");
      public static readonly Icon FawQuoteRight = new Icon('\uf10e', "faw_quote_right");
      public static readonly Icon FawSpinner = new Icon('\uf110', "faw_spinner");
      public static readonly Icon FawCircle = new Icon('\uf111', "faw_circle");
      public static readonly Icon FawReply = new Icon('\uf112', "faw_reply");
      public static readonly Icon FawGithubAlt = new Icon('\uf113', "faw_github_alt");
      public static readonly Icon FawFolderO = new Icon('\uf114', "faw_folder_o");
      public static readonly Icon FawFolderOpenO = new Icon('\uf115', "faw_folder_open_o");
      public static readonly Icon FawSmileO = new Icon('\uf118', "faw_smile_o");
      public static readonly Icon FawFrownO = new Icon('\uf119', "faw_frown_o");
      public static readonly Icon FawMehO = new Icon('\uf11a', "faw_meh_o");
      public static readonly Icon FawGamepad = new Icon('\uf11b', "faw_gamepad");
      public static readonly Icon FawKeyboardO = new Icon('\uf11c', "faw_keyboard_o");
      public static readonly Icon FawFlagO = new Icon('\uf11d', "faw_flag_o");
      public static readonly Icon FawFlagCheckered = new Icon('\uf11e', "faw_flag_checkered");
      public static readonly Icon FawTerminal = new Icon('\uf120', "faw_terminal");
      public static readonly Icon FawCode = new Icon('\uf121', "faw_code");
      public static readonly Icon FawReplyAll = new Icon('\uf122', "faw_reply_all");
      public static readonly Icon FawStarHalfO = new Icon('\uf123', "faw_star_half_o");
      public static readonly Icon FawLocationArrow = new Icon('\uf124', "faw_location_arrow");
      public static readonly Icon FawCrop = new Icon('\uf125', "faw_crop");
      public static readonly Icon FawCodeFork = new Icon('\uf126', "faw_code_fork");
      public static readonly Icon FawChainBroken = new Icon('\uf127', "faw_chain_broken");
      public static readonly Icon FawQuestion = new Icon('\uf128', "faw_question");
      public static readonly Icon FawInfo = new Icon('\uf129', "faw_info");
      public static readonly Icon FawExclamation = new Icon('\uf12a', "faw_exclamation");
      public static readonly Icon FawSuperscript = new Icon('\uf12b', "faw_superscript");
      public static readonly Icon FawSubscript = new Icon('\uf12c', "faw_subscript");
      public static readonly Icon FawEraser = new Icon('\uf12d', "faw_eraser");
      public static readonly Icon FawPuzzlePiece = new Icon('\uf12e', "faw_puzzle_piece");
      public static readonly Icon FawMicrophone = new Icon('\uf130', "faw_microphone");
      public static readonly Icon FawMicrophoneSlash = new Icon('\uf131', "faw_microphone_slash");
      public static readonly Icon FawShield = new Icon('\uf132', "faw_shield");
      public static readonly Icon FawCalendarO = new Icon('\uf133', "faw_calendar_o");
      public static readonly Icon FawFireExtinguisher = new Icon('\uf134', "faw_fire_extinguisher");
      public static readonly Icon FawRocket = new Icon('\uf135', "faw_rocket");
      public static readonly Icon FawMaxcdn = new Icon('\uf136', "faw_maxcdn");
      public static readonly Icon FawChevronCircleLeft = new Icon('\uf137', "faw_chevron_circle_left");
      public static readonly Icon FawChevronCircleRight = new Icon('\uf138', "faw_chevron_circle_right");
      public static readonly Icon FawChevronCircleUp = new Icon('\uf139', "faw_chevron_circle_up");
      public static readonly Icon FawChevronCircleDown = new Icon('\uf13a', "faw_chevron_circle_down");
      public static readonly Icon FawHtml5 = new Icon('\uf13b', "faw_html5");
      public static readonly Icon FawCss3 = new Icon('\uf13c', "faw_css3");
      public static readonly Icon FawAnchor = new Icon('\uf13d', "faw_anchor");
      public static readonly Icon FawUnlockAlt = new Icon('\uf13e', "faw_unlock_alt");
      public static readonly Icon FawBullseye = new Icon('\uf140', "faw_bullseye");
      public static readonly Icon FawEllipsisH = new Icon('\uf141', "faw_ellipsis_h");
      public static readonly Icon FawEllipsisV = new Icon('\uf142', "faw_ellipsis_v");
      public static readonly Icon FawRssSquare = new Icon('\uf143', "faw_rss_square");
      public static readonly Icon FawPlayCircle = new Icon('\uf144', "faw_play_circle");
      public static readonly Icon FawTicket = new Icon('\uf145', "faw_ticket");
      public static readonly Icon FawMinusSquare = new Icon('\uf146', "faw_minus_square");
      public static readonly Icon FawMinusSquareO = new Icon('\uf147', "faw_minus_square_o");
      public static readonly Icon FawLevelUp = new Icon('\uf148', "faw_level_up");
      public static readonly Icon FawLevelDown = new Icon('\uf149', "faw_level_down");
      public static readonly Icon FawCheckSquare = new Icon('\uf14a', "faw_check_square");
      public static readonly Icon FawPencilSquare = new Icon('\uf14b', "faw_pencil_square");
      public static readonly Icon FawExternalLinkSquare = new Icon('\uf14c', "faw_external_link_square");
      public static readonly Icon FawShareSquare = new Icon('\uf14d', "faw_share_square");
      public static readonly Icon FawCompass = new Icon('\uf14e', "faw_compass");
      public static readonly Icon FawCaretSquareODown = new Icon('\uf150', "faw_caret_square_o_down");
      public static readonly Icon FawCaretSquareOUp = new Icon('\uf151', "faw_caret_square_o_up");
      public static readonly Icon FawCaretSquareORight = new Icon('\uf152', "faw_caret_square_o_right");
      public static readonly Icon FawEur = new Icon('\uf153', "faw_eur");
      public static readonly Icon FawGbp = new Icon('\uf154', "faw_gbp");
      public static readonly Icon FawUsd = new Icon('\uf155', "faw_usd");
      public static readonly Icon FawInr = new Icon('\uf156', "faw_inr");
      public static readonly Icon FawJpy = new Icon('\uf157', "faw_jpy");
      public static readonly Icon FawRub = new Icon('\uf158', "faw_rub");
      public static readonly Icon FawKrw = new Icon('\uf159', "faw_krw");
      public static readonly Icon FawBtc = new Icon('\uf15a', "faw_btc");
      public static readonly Icon FawFile = new Icon('\uf15b', "faw_file");
      public static readonly Icon FawFileText = new Icon('\uf15c', "faw_file_text");
      public static readonly Icon FawSortAlphaAsc = new Icon('\uf15d', "faw_sort_alpha_asc");
      public static readonly Icon FawSortAlphaDesc = new Icon('\uf15e', "faw_sort_alpha_desc");
      public static readonly Icon FawSortAmountAsc = new Icon('\uf160', "faw_sort_amount_asc");
      public static readonly Icon FawSortAmountDesc = new Icon('\uf161', "faw_sort_amount_desc");
      public static readonly Icon FawSortNumericAsc = new Icon('\uf162', "faw_sort_numeric_asc");
      public static readonly Icon FawSortNumericDesc = new Icon('\uf163', "faw_sort_numeric_desc");
      public static readonly Icon FawThumbsUp = new Icon('\uf164', "faw_thumbs_up");
      public static readonly Icon FawThumbsDown = new Icon('\uf165', "faw_thumbs_down");
      public static readonly Icon FawYoutubeSquare = new Icon('\uf166', "faw_youtube_square");
      public static readonly Icon FawYoutube = new Icon('\uf167', "faw_youtube");
      public static readonly Icon FawXing = new Icon('\uf168', "faw_xing");
      public static readonly Icon FawXingSquare = new Icon('\uf169', "faw_xing_square");
      public static readonly Icon FawYoutubePlay = new Icon('\uf16a', "faw_youtube_play");
      public static readonly Icon FawDropbox = new Icon('\uf16b', "faw_dropbox");
      public static readonly Icon FawStackOverflow = new Icon('\uf16c', "faw_stack_overflow");
      public static readonly Icon FawInstagram = new Icon('\uf16d', "faw_instagram");
      public static readonly Icon FawFlickr = new Icon('\uf16e', "faw_flickr");
      public static readonly Icon FawAdn = new Icon('\uf170', "faw_adn");
      public static readonly Icon FawBitbucket = new Icon('\uf171', "faw_bitbucket");
      public static readonly Icon FawBitbucketSquare = new Icon('\uf172', "faw_bitbucket_square");
      public static readonly Icon FawTumblr = new Icon('\uf173', "faw_tumblr");
      public static readonly Icon FawTumblrSquare = new Icon('\uf174', "faw_tumblr_square");
      public static readonly Icon FawLongArrowDown = new Icon('\uf175', "faw_long_arrow_down");
      public static readonly Icon FawLongArrowUp = new Icon('\uf176', "faw_long_arrow_up");
      public static readonly Icon FawLongArrowLeft = new Icon('\uf177', "faw_long_arrow_left");
      public static readonly Icon FawLongArrowRight = new Icon('\uf178', "faw_long_arrow_right");
      public static readonly Icon FawApple = new Icon('\uf179', "faw_apple");
      public static readonly Icon FawWindows = new Icon('\uf17a', "faw_windows");
      public static readonly Icon FawAndroid = new Icon('\uf17b', "faw_android");
      public static readonly Icon FawLinux = new Icon('\uf17c', "faw_linux");
      public static readonly Icon FawDribbble = new Icon('\uf17d', "faw_dribbble");
      public static readonly Icon FawSkype = new Icon('\uf17e', "faw_skype");
      public static readonly Icon FawFoursquare = new Icon('\uf180', "faw_foursquare");
      public static readonly Icon FawTrello = new Icon('\uf181', "faw_trello");
      public static readonly Icon FawFemale = new Icon('\uf182', "faw_female");
      public static readonly Icon FawMale = new Icon('\uf183', "faw_male");
      public static readonly Icon FawGratipay = new Icon('\uf184', "faw_gratipay");
      public static readonly Icon FawSunO = new Icon('\uf185', "faw_sun_o");
      public static readonly Icon FawMoonO = new Icon('\uf186', "faw_moon_o");
      public static readonly Icon FawArchive = new Icon('\uf187', "faw_archive");
      public static readonly Icon FawBug = new Icon('\uf188', "faw_bug");
      public static readonly Icon FawVk = new Icon('\uf189', "faw_vk");
      public static readonly Icon FawWeibo = new Icon('\uf18a', "faw_weibo");
      public static readonly Icon FawRenren = new Icon('\uf18b', "faw_renren");
      public static readonly Icon FawPagelines = new Icon('\uf18c', "faw_pagelines");
      public static readonly Icon FawStackExchange = new Icon('\uf18d', "faw_stack_exchange");
      public static readonly Icon FawArrowCircleORight = new Icon('\uf18e', "faw_arrow_circle_o_right");
      public static readonly Icon FawArrowCircleOLeft = new Icon('\uf190', "faw_arrow_circle_o_left");
      public static readonly Icon FawCaretSquareOLeft = new Icon('\uf191', "faw_caret_square_o_left");
      public static readonly Icon FawDotCircleO = new Icon('\uf192', "faw_dot_circle_o");
      public static readonly Icon FawWheelchair = new Icon('\uf193', "faw_wheelchair");
      public static readonly Icon FawVimeoSquare = new Icon('\uf194', "faw_vimeo_square");
      public static readonly Icon FawTry = new Icon('\uf195', "faw_try");
      public static readonly Icon FawPlusSquareO = new Icon('\uf196', "faw_plus_square_o");
      public static readonly Icon FawSpaceShuttle = new Icon('\uf197', "faw_space_shuttle");
      public static readonly Icon FawSlack = new Icon('\uf198', "faw_slack");
      public static readonly Icon FawEnvelopeSquare = new Icon('\uf199', "faw_envelope_square");
      public static readonly Icon FawWordpress = new Icon('\uf19a', "faw_wordpress");
      public static readonly Icon FawOpenid = new Icon('\uf19b', "faw_openid");
      public static readonly Icon FawUniversity = new Icon('\uf19c', "faw_university");
      public static readonly Icon FawGraduationCap = new Icon('\uf19d', "faw_graduation_cap");
      public static readonly Icon FawYahoo = new Icon('\uf19e', "faw_yahoo");
      public static readonly Icon FawGoogle = new Icon('\uf1a0', "faw_google");
      public static readonly Icon FawReddit = new Icon('\uf1a1', "faw_reddit");
      public static readonly Icon FawRedditSquare = new Icon('\uf1a2', "faw_reddit_square");
      public static readonly Icon FawStumbleuponCircle = new Icon('\uf1a3', "faw_stumbleupon_circle");
      public static readonly Icon FawStumbleupon = new Icon('\uf1a4', "faw_stumbleupon");
      public static readonly Icon FawDelicious = new Icon('\uf1a5', "faw_delicious");
      public static readonly Icon FawDigg = new Icon('\uf1a6', "faw_digg");
      public static readonly Icon FawPiedPiper = new Icon('\uf1a7', "faw_pied_piper");
      public static readonly Icon FawPiedPiperAlt = new Icon('\uf1a8', "faw_pied_piper_alt");
      public static readonly Icon FawDrupal = new Icon('\uf1a9', "faw_drupal");
      public static readonly Icon FawJoomla = new Icon('\uf1aa', "faw_joomla");
      public static readonly Icon FawLanguage = new Icon('\uf1ab', "faw_language");
      public static readonly Icon FawFax = new Icon('\uf1ac', "faw_fax");
      public static readonly Icon FawBuilding = new Icon('\uf1ad', "faw_building");
      public static readonly Icon FawChild = new Icon('\uf1ae', "faw_child");
      public static readonly Icon FawPaw = new Icon('\uf1b0', "faw_paw");
      public static readonly Icon FawSpoon = new Icon('\uf1b1', "faw_spoon");
      public static readonly Icon FawCube = new Icon('\uf1b2', "faw_cube");
      public static readonly Icon FawCubes = new Icon('\uf1b3', "faw_cubes");
      public static readonly Icon FawBehance = new Icon('\uf1b4', "faw_behance");
      public static readonly Icon FawBehanceSquare = new Icon('\uf1b5', "faw_behance_square");
      public static readonly Icon FawSteam = new Icon('\uf1b6', "faw_steam");
      public static readonly Icon FawSteamSquare = new Icon('\uf1b7', "faw_steam_square");
      public static readonly Icon FawRecycle = new Icon('\uf1b8', "faw_recycle");
      public static readonly Icon FawCar = new Icon('\uf1b9', "faw_car");
      public static readonly Icon FawTaxi = new Icon('\uf1ba', "faw_taxi");
      public static readonly Icon FawTree = new Icon('\uf1bb', "faw_tree");
      public static readonly Icon FawSpotify = new Icon('\uf1bc', "faw_spotify");
      public static readonly Icon FawDeviantart = new Icon('\uf1bd', "faw_deviantart");
      public static readonly Icon FawSoundcloud = new Icon('\uf1be', "faw_soundcloud");
      public static readonly Icon FawDatabase = new Icon('\uf1c0', "faw_database");
      public static readonly Icon FawFilePdfO = new Icon('\uf1c1', "faw_file_pdf_o");
      public static readonly Icon FawFileWordO = new Icon('\uf1c2', "faw_file_word_o");
      public static readonly Icon FawFileExcelO = new Icon('\uf1c3', "faw_file_excel_o");
      public static readonly Icon FawFilePowerpointO = new Icon('\uf1c4', "faw_file_powerpoint_o");
      public static readonly Icon FawFileImageO = new Icon('\uf1c5', "faw_file_image_o");
      public static readonly Icon FawFileArchiveO = new Icon('\uf1c6', "faw_file_archive_o");
      public static readonly Icon FawFileAudioO = new Icon('\uf1c7', "faw_file_audio_o");
      public static readonly Icon FawFileVideoO = new Icon('\uf1c8', "faw_file_video_o");
      public static readonly Icon FawFileCodeO = new Icon('\uf1c9', "faw_file_code_o");
      public static readonly Icon FawVine = new Icon('\uf1ca', "faw_vine");
      public static readonly Icon FawCodepen = new Icon('\uf1cb', "faw_codepen");
      public static readonly Icon FawJsfiddle = new Icon('\uf1cc', "faw_jsfiddle");
      public static readonly Icon FawLifeRing = new Icon('\uf1cd', "faw_life_ring");
      public static readonly Icon FawCircleONotch = new Icon('\uf1ce', "faw_circle_o_notch");
      public static readonly Icon FawRebel = new Icon('\uf1d0', "faw_rebel");
      public static readonly Icon FawEmpire = new Icon('\uf1d1', "faw_empire");
      public static readonly Icon FawGitSquare = new Icon('\uf1d2', "faw_git_square");
      public static readonly Icon FawGit = new Icon('\uf1d3', "faw_git");
      public static readonly Icon FawHackerNews = new Icon('\uf1d4', "faw_hacker_news");
      public static readonly Icon FawTencentWeibo = new Icon('\uf1d5', "faw_tencent_weibo");
      public static readonly Icon FawQq = new Icon('\uf1d6', "faw_qq");
      public static readonly Icon FawWeixin = new Icon('\uf1d7', "faw_weixin");
      public static readonly Icon FawPaperPlane = new Icon('\uf1d8', "faw_paper_plane");
      public static readonly Icon FawPaperPlaneO = new Icon('\uf1d9', "faw_paper_plane_o");
      public static readonly Icon FawHistory = new Icon('\uf1da', "faw_history");
      public static readonly Icon FawCircleThin = new Icon('\uf1db', "faw_circle_thin");
      public static readonly Icon FawHeader = new Icon('\uf1dc', "faw_header");
      public static readonly Icon FawParagraph = new Icon('\uf1dd', "faw_paragraph");
      public static readonly Icon FawSliders = new Icon('\uf1de', "faw_sliders");
      public static readonly Icon FawShareAlt = new Icon('\uf1e0', "faw_share_alt");
      public static readonly Icon FawShareAltSquare = new Icon('\uf1e1', "faw_share_alt_square");
      public static readonly Icon FawBomb = new Icon('\uf1e2', "faw_bomb");
      public static readonly Icon FawFutbolO = new Icon('\uf1e3', "faw_futbol_o");
      public static readonly Icon FawTty = new Icon('\uf1e4', "faw_tty");
      public static readonly Icon FawBinoculars = new Icon('\uf1e5', "faw_binoculars");
      public static readonly Icon FawPlug = new Icon('\uf1e6', "faw_plug");
      public static readonly Icon FawSlideshare = new Icon('\uf1e7', "faw_slideshare");
      public static readonly Icon FawTwitch = new Icon('\uf1e8', "faw_twitch");
      public static readonly Icon FawYelp = new Icon('\uf1e9', "faw_yelp");
      public static readonly Icon FawNewspaperO = new Icon('\uf1ea', "faw_newspaper_o");
      public static readonly Icon FawWifi = new Icon('\uf1eb', "faw_wifi");
      public static readonly Icon FawCalculator = new Icon('\uf1ec', "faw_calculator");
      public static readonly Icon FawPaypal = new Icon('\uf1ed', "faw_paypal");
      public static readonly Icon FawGoogleWallet = new Icon('\uf1ee', "faw_google_wallet");
      public static readonly Icon FawCcVisa = new Icon('\uf1f0', "faw_cc_visa");
      public static readonly Icon FawCcMastercard = new Icon('\uf1f1', "faw_cc_mastercard");
      public static readonly Icon FawCcDiscover = new Icon('\uf1f2', "faw_cc_discover");
      public static readonly Icon FawCcAmex = new Icon('\uf1f3', "faw_cc_amex");
      public static readonly Icon FawCcPaypal = new Icon('\uf1f4', "faw_cc_paypal");
      public static readonly Icon FawCcStripe = new Icon('\uf1f5', "faw_cc_stripe");
      public static readonly Icon FawBellSlash = new Icon('\uf1f6', "faw_bell_slash");
      public static readonly Icon FawBellSlashO = new Icon('\uf1f7', "faw_bell_slash_o");
      public static readonly Icon FawTrash = new Icon('\uf1f8', "faw_trash");
      public static readonly Icon FawCopyright = new Icon('\uf1f9', "faw_copyright");
      public static readonly Icon FawAt = new Icon('\uf1fa', "faw_at");
      public static readonly Icon FawEyedropper = new Icon('\uf1fb', "faw_eyedropper");
      public static readonly Icon FawPaintBrush = new Icon('\uf1fc', "faw_paint_brush");
      public static readonly Icon FawBirthdayCake = new Icon('\uf1fd', "faw_birthday_cake");
      public static readonly Icon FawAreaChart = new Icon('\uf1fe', "faw_area_chart");
      public static readonly Icon FawPieChart = new Icon('\uf200', "faw_pie_chart");
      public static readonly Icon FawLineChart = new Icon('\uf201', "faw_line_chart");
      public static readonly Icon FawLastfm = new Icon('\uf202', "faw_lastfm");
      public static readonly Icon FawLastfmSquare = new Icon('\uf203', "faw_lastfm_square");
      public static readonly Icon FawToggleOff = new Icon('\uf204', "faw_toggle_off");
      public static readonly Icon FawToggleOn = new Icon('\uf205', "faw_toggle_on");
      public static readonly Icon FawBicycle = new Icon('\uf206', "faw_bicycle");
      public static readonly Icon FawBus = new Icon('\uf207', "faw_bus");
      public static readonly Icon FawIoxhost = new Icon('\uf208', "faw_ioxhost");
      public static readonly Icon FawAngellist = new Icon('\uf209', "faw_angellist");
      public static readonly Icon FawCc = new Icon('\uf20a', "faw_cc");
      public static readonly Icon FawIls = new Icon('\uf20b', "faw_ils");
      public static readonly Icon FawMeanpath = new Icon('\uf20c', "faw_meanpath");
      public static readonly Icon FawBuysellads = new Icon('\uf20d', "faw_buysellads");
      public static readonly Icon FawConnectdevelop = new Icon('\uf20e', "faw_connectdevelop");
      public static readonly Icon FawDashcube = new Icon('\uf210', "faw_dashcube");
      public static readonly Icon FawForumbee = new Icon('\uf211', "faw_forumbee");
      public static readonly Icon FawLeanpub = new Icon('\uf212', "faw_leanpub");
      public static readonly Icon FawSellsy = new Icon('\uf213', "faw_sellsy");
      public static readonly Icon FawShirtsinbulk = new Icon('\uf214', "faw_shirtsinbulk");
      public static readonly Icon FawSimplybuilt = new Icon('\uf215', "faw_simplybuilt");
      public static readonly Icon FawSkyatlas = new Icon('\uf216', "faw_skyatlas");
      public static readonly Icon FawCartPlus = new Icon('\uf217', "faw_cart_plus");
      public static readonly Icon FawCartArrowDown = new Icon('\uf218', "faw_cart_arrow_down");
      public static readonly Icon FawDiamond = new Icon('\uf219', "faw_diamond");
      public static readonly Icon FawShip = new Icon('\uf21a', "faw_ship");
      public static readonly Icon FawUserSecret = new Icon('\uf21b', "faw_user_secret");
      public static readonly Icon FawMotorcycle = new Icon('\uf21c', "faw_motorcycle");
      public static readonly Icon FawStreetView = new Icon('\uf21d', "faw_street_view");
      public static readonly Icon FawHeartbeat = new Icon('\uf21e', "faw_heartbeat");
      public static readonly Icon FawVenus = new Icon('\uf221', "faw_venus");
      public static readonly Icon FawMars = new Icon('\uf222', "faw_mars");
      public static readonly Icon FawMercury = new Icon('\uf223', "faw_mercury");
      public static readonly Icon FawTransgender = new Icon('\uf224', "faw_transgender");
      public static readonly Icon FawTransgenderAlt = new Icon('\uf225', "faw_transgender_alt");
      public static readonly Icon FawVenusDouble = new Icon('\uf226', "faw_venus_double");
      public static readonly Icon FawMarsDouble = new Icon('\uf227', "faw_mars_double");
      public static readonly Icon FawVenusMars = new Icon('\uf228', "faw_venus_mars");
      public static readonly Icon FawMarsStroke = new Icon('\uf229', "faw_mars_stroke");
      public static readonly Icon FawMarsStrokeV = new Icon('\uf22a', "faw_mars_stroke_v");
      public static readonly Icon FawMarsStrokeH = new Icon('\uf22b', "faw_mars_stroke_h");
      public static readonly Icon FawNeuter = new Icon('\uf22c', "faw_neuter");
      public static readonly Icon FawGenderless = new Icon('\uf22d', "faw_genderless");
      public static readonly Icon FawFacebookOfficial = new Icon('\uf230', "faw_facebook_official");
      public static readonly Icon FawPinterestP = new Icon('\uf231', "faw_pinterest_p");
      public static readonly Icon FawWhatsapp = new Icon('\uf232', "faw_whatsapp");
      public static readonly Icon FawServer = new Icon('\uf233', "faw_server");
      public static readonly Icon FawUserPlus = new Icon('\uf234', "faw_user_plus");
      public static readonly Icon FawUserTimes = new Icon('\uf235', "faw_user_times");
      public static readonly Icon FawBed = new Icon('\uf236', "faw_bed");
      public static readonly Icon FawViacoin = new Icon('\uf237', "faw_viacoin");
      public static readonly Icon FawTrain = new Icon('\uf238', "faw_train");
      public static readonly Icon FawSubway = new Icon('\uf239', "faw_subway");
      public static readonly Icon FawMedium = new Icon('\uf23a', "faw_medium");
      public static readonly Icon FawYCombinator = new Icon('\uf23b', "faw_y_combinator");
      public static readonly Icon FawOptinMonster = new Icon('\uf23c', "faw_optin_monster");
      public static readonly Icon FawOpencart = new Icon('\uf23d', "faw_opencart");
      public static readonly Icon FawExpeditedssl = new Icon('\uf23e', "faw_expeditedssl");
      public static readonly Icon FawBatteryFull = new Icon('\uf240', "faw_battery_full");
      public static readonly Icon FawBatteryThreeQuarters = new Icon('\uf241', "faw_battery_three_quarters");
      public static readonly Icon FawBatteryHalf = new Icon('\uf242', "faw_battery_half");
      public static readonly Icon FawBatteryQuarter = new Icon('\uf243', "faw_battery_quarter");
      public static readonly Icon FawBatteryEmpty = new Icon('\uf244', "faw_battery_empty");
      public static readonly Icon FawMousePointer = new Icon('\uf245', "faw_mouse_pointer");
      public static readonly Icon FawICursor = new Icon('\uf246', "faw_i_cursor");
      public static readonly Icon FawObjectGroup = new Icon('\uf247', "faw_object_group");
      public static readonly Icon FawObjectUngroup = new Icon('\uf248', "faw_object_ungroup");
      public static readonly Icon FawStickyNote = new Icon('\uf249', "faw_sticky_note");
      public static readonly Icon FawStickyNoteO = new Icon('\uf24a', "faw_sticky_note_o");
      public static readonly Icon FawCcJcb = new Icon('\uf24b', "faw_cc_jcb");
      public static readonly Icon FawCcDinersClub = new Icon('\uf24c', "faw_cc_diners_club");
      public static readonly Icon FawClone = new Icon('\uf24d', "faw_clone");
      public static readonly Icon FawBalanceScale = new Icon('\uf24e', "faw_balance_scale");
      public static readonly Icon FawHourglassO = new Icon('\uf250', "faw_hourglass_o");
      public static readonly Icon FawHourglassStart = new Icon('\uf251', "faw_hourglass_start");
      public static readonly Icon FawHourglassHalf = new Icon('\uf252', "faw_hourglass_half");
      public static readonly Icon FawHourglassEnd = new Icon('\uf253', "faw_hourglass_end");
      public static readonly Icon FawHourglass = new Icon('\uf254', "faw_hourglass");
      public static readonly Icon FawHandRockO = new Icon('\uf255', "faw_hand_rock_o");
      public static readonly Icon FawHandPaperO = new Icon('\uf256', "faw_hand_paper_o");
      public static readonly Icon FawHandScissorsO = new Icon('\uf257', "faw_hand_scissors_o");
      public static readonly Icon FawHandLizardO = new Icon('\uf258', "faw_hand_lizard_o");
      public static readonly Icon FawHandSpockO = new Icon('\uf259', "faw_hand_spock_o");
      public static readonly Icon FawHandPointerO = new Icon('\uf25a', "faw_hand_pointer_o");
      public static readonly Icon FawHandPeaceO = new Icon('\uf25b', "faw_hand_peace_o");
      public static readonly Icon FawTrademark = new Icon('\uf25c', "faw_trademark");
      public static readonly Icon FawRegistered = new Icon('\uf25d', "faw_registered");
      public static readonly Icon FawCreativeCommons = new Icon('\uf25e', "faw_creative_commons");
      public static readonly Icon FawGg = new Icon('\uf260', "faw_gg");
      public static readonly Icon FawGgCircle = new Icon('\uf261', "faw_gg_circle");
      public static readonly Icon FawTripadvisor = new Icon('\uf262', "faw_tripadvisor");
      public static readonly Icon FawOdnoklassniki = new Icon('\uf263', "faw_odnoklassniki");
      public static readonly Icon FawOdnoklassnikiSquare = new Icon('\uf264', "faw_odnoklassniki_square");
      public static readonly Icon FawGetPocket = new Icon('\uf265', "faw_get_pocket");
      public static readonly Icon FawWikipediaW = new Icon('\uf266', "faw_wikipedia_w");
      public static readonly Icon FawSafari = new Icon('\uf267', "faw_safari");
      public static readonly Icon FawChrome = new Icon('\uf268', "faw_chrome");
      public static readonly Icon FawFirefox = new Icon('\uf269', "faw_firefox");
      public static readonly Icon FawOpera = new Icon('\uf26a', "faw_opera");
      public static readonly Icon FawInternetExplorer = new Icon('\uf26b', "faw_internet_explorer");
      public static readonly Icon FawTelevision = new Icon('\uf26c', "faw_television");
      public static readonly Icon FawContao = new Icon('\uf26d', "faw_contao");
      public static readonly Icon Faw500px = new Icon('\uf26e', "faw_500px");
      public static readonly Icon FawAmazon = new Icon('\uf270', "faw_amazon");
      public static readonly Icon FawCalendarPlusO = new Icon('\uf271', "faw_calendar_plus_o");
      public static readonly Icon FawCalendarMinusO = new Icon('\uf272', "faw_calendar_minus_o");
      public static readonly Icon FawCalendarTimesO = new Icon('\uf273', "faw_calendar_times_o");
      public static readonly Icon FawCalendarCheckO = new Icon('\uf274', "faw_calendar_check_o");
      public static readonly Icon FawIndustry = new Icon('\uf275', "faw_industry");
      public static readonly Icon FawMapPin = new Icon('\uf276', "faw_map_pin");
      public static readonly Icon FawMapSigns = new Icon('\uf277', "faw_map_signs");
      public static readonly Icon FawMapO = new Icon('\uf278', "faw_map_o");
      public static readonly Icon FawMap = new Icon('\uf279', "faw_map");
      public static readonly Icon FawCommenting = new Icon('\uf27a', "faw_commenting");
      public static readonly Icon FawCommentingO = new Icon('\uf27b', "faw_commenting_o");
      public static readonly Icon FawHouzz = new Icon('\uf27c', "faw_houzz");
      public static readonly Icon FawVimeo = new Icon('\uf27d', "faw_vimeo");
      public static readonly Icon FawBlackTie = new Icon('\uf27e', "faw_black_tie");
      public static readonly Icon FawFonticons = new Icon('\uf280', "faw_fonticons");
      public static readonly Icon FawRedditAlien = new Icon('\uf281', "faw_reddit_alien");
      public static readonly Icon FawEdge = new Icon('\uf282', "faw_edge");
      public static readonly Icon FawCreditCardAlt = new Icon('\uf283', "faw_credit_card_alt");
      public static readonly Icon FawCodiepie = new Icon('\uf284', "faw_codiepie");
      public static readonly Icon FawModx = new Icon('\uf285', "faw_modx");
      public static readonly Icon FawFortAwesome = new Icon('\uf286', "faw_fort_awesome");
      public static readonly Icon FawUsb = new Icon('\uf287', "faw_usb");
      public static readonly Icon FawProductHunt = new Icon('\uf288', "faw_product_hunt");
      public static readonly Icon FawMixcloud = new Icon('\uf289', "faw_mixcloud");
      public static readonly Icon FawScribd = new Icon('\uf28a', "faw_scribd");
      public static readonly Icon FawPauseCircle = new Icon('\uf28b', "faw_pause_circle");
      public static readonly Icon FawPauseCircleO = new Icon('\uf28c', "faw_pause_circle_o");
      public static readonly Icon FawStopCircle = new Icon('\uf28d', "faw_stop_circle");
      public static readonly Icon FawStopCircleO = new Icon('\uf28e', "faw_stop_circle_o");
      public static readonly Icon FawShoppingBag = new Icon('\uf290', "faw_shopping_bag");
      public static readonly Icon FawShoppingBasket = new Icon('\uf291', "faw_shopping_basket");
      public static readonly Icon FawHashtag = new Icon('\uf292', "faw_hashtag");
      public static readonly Icon FawBluetooth = new Icon('\uf293', "faw_bluetooth");
      public static readonly Icon FawBluetoothB = new Icon('\uf294', "faw_bluetooth_b");
      public static readonly Icon FawPercent = new Icon('\uf295', "faw_percent");

      public static IEnumerable<Icon> Values
      {
        get
        {
      		yield return FawGlass;
      		yield return FawMusic;
      		yield return FawSearch;
      		yield return FawEnvelopeO;
      		yield return FawHeart;
      		yield return FawStar;
      		yield return FawStarO;
      		yield return FawUser;
      		yield return FawFilm;
      		yield return FawThLarge;
      		yield return FawTh;
      		yield return FawThList;
      		yield return FawCheck;
      		yield return FawTimes;
      		yield return FawSearchPlus;
      		yield return FawSearchMinus;
      		yield return FawPowerOff;
      		yield return FawSignal;
      		yield return FawCog;
      		yield return FawTrashO;
      		yield return FawHome;
      		yield return FawFileO;
      		yield return FawClockO;
      		yield return FawRoad;
      		yield return FawDownload;
      		yield return FawArrowCircleODown;
      		yield return FawArrowCircleOUp;
      		yield return FawInbox;
      		yield return FawPlayCircleO;
      		yield return FawRepeat;
      		yield return FawRefresh;
      		yield return FawListAlt;
      		yield return FawLock;
      		yield return FawFlag;
      		yield return FawHeadphones;
      		yield return FawVolumeOff;
      		yield return FawVolumeDown;
      		yield return FawVolumeUp;
      		yield return FawQrcode;
      		yield return FawBarcode;
      		yield return FawTag;
      		yield return FawTags;
      		yield return FawBook;
      		yield return FawBookmark;
      		yield return FawPrint;
      		yield return FawCamera;
      		yield return FawFont;
      		yield return FawBold;
      		yield return FawItalic;
      		yield return FawTextHeight;
      		yield return FawTextWidth;
      		yield return FawAlignLeft;
      		yield return FawAlignCenter;
      		yield return FawAlignRight;
      		yield return FawAlignJustify;
      		yield return FawList;
      		yield return FawOutdent;
      		yield return FawIndent;
      		yield return FawVideoCamera;
      		yield return FawPictureO;
      		yield return FawPencil;
      		yield return FawMapMarker;
      		yield return FawAdjust;
      		yield return FawTint;
      		yield return FawPencilSquareO;
      		yield return FawShareSquareO;
      		yield return FawCheckSquareO;
      		yield return FawArrows;
      		yield return FawStepBackward;
      		yield return FawFastBackward;
      		yield return FawBackward;
      		yield return FawPlay;
      		yield return FawPause;
      		yield return FawStop;
      		yield return FawForward;
      		yield return FawFastForward;
      		yield return FawStepForward;
      		yield return FawEject;
      		yield return FawChevronLeft;
      		yield return FawChevronRight;
      		yield return FawPlusCircle;
      		yield return FawMinusCircle;
      		yield return FawTimesCircle;
      		yield return FawCheckCircle;
      		yield return FawQuestionCircle;
      		yield return FawInfoCircle;
      		yield return FawCrosshairs;
      		yield return FawTimesCircleO;
      		yield return FawCheckCircleO;
      		yield return FawBan;
      		yield return FawArrowLeft;
      		yield return FawArrowRight;
      		yield return FawArrowUp;
      		yield return FawArrowDown;
      		yield return FawShare;
      		yield return FawExpand;
      		yield return FawCompress;
      		yield return FawPlus;
      		yield return FawMinus;
      		yield return FawAsterisk;
      		yield return FawExclamationCircle;
      		yield return FawGift;
      		yield return FawLeaf;
      		yield return FawFire;
      		yield return FawEye;
      		yield return FawEyeSlash;
      		yield return FawExclamationTriangle;
      		yield return FawPlane;
      		yield return FawCalendar;
      		yield return FawRandom;
      		yield return FawComment;
      		yield return FawMagnet;
      		yield return FawChevronUp;
      		yield return FawChevronDown;
      		yield return FawRetweet;
      		yield return FawShoppingCart;
      		yield return FawFolder;
      		yield return FawFolderOpen;
      		yield return FawArrowsV;
      		yield return FawArrowsH;
      		yield return FawBarChart;
      		yield return FawTwitterSquare;
      		yield return FawFacebookSquare;
      		yield return FawCameraRetro;
      		yield return FawKey;
      		yield return FawCogs;
      		yield return FawComments;
      		yield return FawThumbsOUp;
      		yield return FawThumbsODown;
      		yield return FawStarHalf;
      		yield return FawHeartO;
      		yield return FawSignOut;
      		yield return FawLinkedinSquare;
      		yield return FawThumbTack;
      		yield return FawExternalLink;
      		yield return FawSignIn;
      		yield return FawTrophy;
      		yield return FawGithubSquare;
      		yield return FawUpload;
      		yield return FawLemonO;
      		yield return FawPhone;
      		yield return FawSquareO;
      		yield return FawBookmarkO;
      		yield return FawPhoneSquare;
      		yield return FawTwitter;
      		yield return FawFacebook;
      		yield return FawGithub;
      		yield return FawUnlock;
      		yield return FawCreditCard;
      		yield return FawRss;
      		yield return FawHddO;
      		yield return FawBullhorn;
      		yield return FawBell;
      		yield return FawCertificate;
      		yield return FawHandORight;
      		yield return FawHandOLeft;
      		yield return FawHandOUp;
      		yield return FawHandODown;
      		yield return FawArrowCircleLeft;
      		yield return FawArrowCircleRight;
      		yield return FawArrowCircleUp;
      		yield return FawArrowCircleDown;
      		yield return FawGlobe;
      		yield return FawWrench;
      		yield return FawTasks;
      		yield return FawFilter;
      		yield return FawBriefcase;
      		yield return FawArrowsAlt;
      		yield return FawUsers;
      		yield return FawLink;
      		yield return FawCloud;
      		yield return FawFlask;
      		yield return FawScissors;
      		yield return FawFilesO;
      		yield return FawPaperclip;
      		yield return FawFloppyO;
      		yield return FawSquare;
      		yield return FawBars;
      		yield return FawListUl;
      		yield return FawListOl;
      		yield return FawStrikethrough;
      		yield return FawUnderline;
      		yield return FawTable;
      		yield return FawMagic;
      		yield return FawTruck;
      		yield return FawPinterest;
      		yield return FawPinterestSquare;
      		yield return FawGooglePlusSquare;
      		yield return FawGooglePlus;
      		yield return FawMoney;
      		yield return FawCaretDown;
      		yield return FawCaretUp;
      		yield return FawCaretLeft;
      		yield return FawCaretRight;
      		yield return FawColumns;
      		yield return FawSort;
      		yield return FawSortDesc;
      		yield return FawSortAsc;
      		yield return FawEnvelope;
      		yield return FawLinkedin;
      		yield return FawUndo;
      		yield return FawGavel;
      		yield return FawTachometer;
      		yield return FawCommentO;
      		yield return FawCommentsO;
      		yield return FawBolt;
      		yield return FawSitemap;
      		yield return FawUmbrella;
      		yield return FawClipboard;
      		yield return FawLightbulbO;
      		yield return FawExchange;
      		yield return FawCloudDownload;
      		yield return FawCloudUpload;
      		yield return FawUserMd;
      		yield return FawStethoscope;
      		yield return FawSuitcase;
      		yield return FawBellO;
      		yield return FawCoffee;
      		yield return FawCutlery;
      		yield return FawFileTextO;
      		yield return FawBuildingO;
      		yield return FawHospitalO;
      		yield return FawAmbulance;
      		yield return FawMedkit;
      		yield return FawFighterJet;
      		yield return FawBeer;
      		yield return FawHSquare;
      		yield return FawPlusSquare;
      		yield return FawAngleDoubleLeft;
      		yield return FawAngleDoubleRight;
      		yield return FawAngleDoubleUp;
      		yield return FawAngleDoubleDown;
      		yield return FawAngleLeft;
      		yield return FawAngleRight;
      		yield return FawAngleUp;
      		yield return FawAngleDown;
      		yield return FawDesktop;
      		yield return FawLaptop;
      		yield return FawTablet;
      		yield return FawMobile;
      		yield return FawCircleO;
      		yield return FawQuoteLeft;
      		yield return FawQuoteRight;
      		yield return FawSpinner;
      		yield return FawCircle;
      		yield return FawReply;
      		yield return FawGithubAlt;
      		yield return FawFolderO;
      		yield return FawFolderOpenO;
      		yield return FawSmileO;
      		yield return FawFrownO;
      		yield return FawMehO;
      		yield return FawGamepad;
      		yield return FawKeyboardO;
      		yield return FawFlagO;
      		yield return FawFlagCheckered;
      		yield return FawTerminal;
      		yield return FawCode;
      		yield return FawReplyAll;
      		yield return FawStarHalfO;
      		yield return FawLocationArrow;
      		yield return FawCrop;
      		yield return FawCodeFork;
      		yield return FawChainBroken;
      		yield return FawQuestion;
      		yield return FawInfo;
      		yield return FawExclamation;
      		yield return FawSuperscript;
      		yield return FawSubscript;
      		yield return FawEraser;
      		yield return FawPuzzlePiece;
      		yield return FawMicrophone;
      		yield return FawMicrophoneSlash;
      		yield return FawShield;
      		yield return FawCalendarO;
      		yield return FawFireExtinguisher;
      		yield return FawRocket;
      		yield return FawMaxcdn;
      		yield return FawChevronCircleLeft;
      		yield return FawChevronCircleRight;
      		yield return FawChevronCircleUp;
      		yield return FawChevronCircleDown;
      		yield return FawHtml5;
      		yield return FawCss3;
      		yield return FawAnchor;
      		yield return FawUnlockAlt;
      		yield return FawBullseye;
      		yield return FawEllipsisH;
      		yield return FawEllipsisV;
      		yield return FawRssSquare;
      		yield return FawPlayCircle;
      		yield return FawTicket;
      		yield return FawMinusSquare;
      		yield return FawMinusSquareO;
      		yield return FawLevelUp;
      		yield return FawLevelDown;
      		yield return FawCheckSquare;
      		yield return FawPencilSquare;
      		yield return FawExternalLinkSquare;
      		yield return FawShareSquare;
      		yield return FawCompass;
      		yield return FawCaretSquareODown;
      		yield return FawCaretSquareOUp;
      		yield return FawCaretSquareORight;
      		yield return FawEur;
      		yield return FawGbp;
      		yield return FawUsd;
      		yield return FawInr;
      		yield return FawJpy;
      		yield return FawRub;
      		yield return FawKrw;
      		yield return FawBtc;
      		yield return FawFile;
      		yield return FawFileText;
      		yield return FawSortAlphaAsc;
      		yield return FawSortAlphaDesc;
      		yield return FawSortAmountAsc;
      		yield return FawSortAmountDesc;
      		yield return FawSortNumericAsc;
      		yield return FawSortNumericDesc;
      		yield return FawThumbsUp;
      		yield return FawThumbsDown;
      		yield return FawYoutubeSquare;
      		yield return FawYoutube;
      		yield return FawXing;
      		yield return FawXingSquare;
      		yield return FawYoutubePlay;
      		yield return FawDropbox;
      		yield return FawStackOverflow;
      		yield return FawInstagram;
      		yield return FawFlickr;
      		yield return FawAdn;
      		yield return FawBitbucket;
      		yield return FawBitbucketSquare;
      		yield return FawTumblr;
      		yield return FawTumblrSquare;
      		yield return FawLongArrowDown;
      		yield return FawLongArrowUp;
      		yield return FawLongArrowLeft;
      		yield return FawLongArrowRight;
      		yield return FawApple;
      		yield return FawWindows;
      		yield return FawAndroid;
      		yield return FawLinux;
      		yield return FawDribbble;
      		yield return FawSkype;
      		yield return FawFoursquare;
      		yield return FawTrello;
      		yield return FawFemale;
      		yield return FawMale;
      		yield return FawGratipay;
      		yield return FawSunO;
      		yield return FawMoonO;
      		yield return FawArchive;
      		yield return FawBug;
      		yield return FawVk;
      		yield return FawWeibo;
      		yield return FawRenren;
      		yield return FawPagelines;
      		yield return FawStackExchange;
      		yield return FawArrowCircleORight;
      		yield return FawArrowCircleOLeft;
      		yield return FawCaretSquareOLeft;
      		yield return FawDotCircleO;
      		yield return FawWheelchair;
      		yield return FawVimeoSquare;
      		yield return FawTry;
      		yield return FawPlusSquareO;
      		yield return FawSpaceShuttle;
      		yield return FawSlack;
      		yield return FawEnvelopeSquare;
      		yield return FawWordpress;
      		yield return FawOpenid;
      		yield return FawUniversity;
      		yield return FawGraduationCap;
      		yield return FawYahoo;
      		yield return FawGoogle;
      		yield return FawReddit;
      		yield return FawRedditSquare;
      		yield return FawStumbleuponCircle;
      		yield return FawStumbleupon;
      		yield return FawDelicious;
      		yield return FawDigg;
      		yield return FawPiedPiper;
      		yield return FawPiedPiperAlt;
      		yield return FawDrupal;
      		yield return FawJoomla;
      		yield return FawLanguage;
      		yield return FawFax;
      		yield return FawBuilding;
      		yield return FawChild;
      		yield return FawPaw;
      		yield return FawSpoon;
      		yield return FawCube;
      		yield return FawCubes;
      		yield return FawBehance;
      		yield return FawBehanceSquare;
      		yield return FawSteam;
      		yield return FawSteamSquare;
      		yield return FawRecycle;
      		yield return FawCar;
      		yield return FawTaxi;
      		yield return FawTree;
      		yield return FawSpotify;
      		yield return FawDeviantart;
      		yield return FawSoundcloud;
      		yield return FawDatabase;
      		yield return FawFilePdfO;
      		yield return FawFileWordO;
      		yield return FawFileExcelO;
      		yield return FawFilePowerpointO;
      		yield return FawFileImageO;
      		yield return FawFileArchiveO;
      		yield return FawFileAudioO;
      		yield return FawFileVideoO;
      		yield return FawFileCodeO;
      		yield return FawVine;
      		yield return FawCodepen;
      		yield return FawJsfiddle;
      		yield return FawLifeRing;
      		yield return FawCircleONotch;
      		yield return FawRebel;
      		yield return FawEmpire;
      		yield return FawGitSquare;
      		yield return FawGit;
      		yield return FawHackerNews;
      		yield return FawTencentWeibo;
      		yield return FawQq;
      		yield return FawWeixin;
      		yield return FawPaperPlane;
      		yield return FawPaperPlaneO;
      		yield return FawHistory;
      		yield return FawCircleThin;
      		yield return FawHeader;
      		yield return FawParagraph;
      		yield return FawSliders;
      		yield return FawShareAlt;
      		yield return FawShareAltSquare;
      		yield return FawBomb;
      		yield return FawFutbolO;
      		yield return FawTty;
      		yield return FawBinoculars;
      		yield return FawPlug;
      		yield return FawSlideshare;
      		yield return FawTwitch;
      		yield return FawYelp;
      		yield return FawNewspaperO;
      		yield return FawWifi;
      		yield return FawCalculator;
      		yield return FawPaypal;
      		yield return FawGoogleWallet;
      		yield return FawCcVisa;
      		yield return FawCcMastercard;
      		yield return FawCcDiscover;
      		yield return FawCcAmex;
      		yield return FawCcPaypal;
      		yield return FawCcStripe;
      		yield return FawBellSlash;
      		yield return FawBellSlashO;
      		yield return FawTrash;
      		yield return FawCopyright;
      		yield return FawAt;
      		yield return FawEyedropper;
      		yield return FawPaintBrush;
      		yield return FawBirthdayCake;
      		yield return FawAreaChart;
      		yield return FawPieChart;
      		yield return FawLineChart;
      		yield return FawLastfm;
      		yield return FawLastfmSquare;
      		yield return FawToggleOff;
      		yield return FawToggleOn;
      		yield return FawBicycle;
      		yield return FawBus;
      		yield return FawIoxhost;
      		yield return FawAngellist;
      		yield return FawCc;
      		yield return FawIls;
      		yield return FawMeanpath;
      		yield return FawBuysellads;
      		yield return FawConnectdevelop;
      		yield return FawDashcube;
      		yield return FawForumbee;
      		yield return FawLeanpub;
      		yield return FawSellsy;
      		yield return FawShirtsinbulk;
      		yield return FawSimplybuilt;
      		yield return FawSkyatlas;
      		yield return FawCartPlus;
      		yield return FawCartArrowDown;
      		yield return FawDiamond;
      		yield return FawShip;
      		yield return FawUserSecret;
      		yield return FawMotorcycle;
      		yield return FawStreetView;
      		yield return FawHeartbeat;
      		yield return FawVenus;
      		yield return FawMars;
      		yield return FawMercury;
      		yield return FawTransgender;
      		yield return FawTransgenderAlt;
      		yield return FawVenusDouble;
      		yield return FawMarsDouble;
      		yield return FawVenusMars;
      		yield return FawMarsStroke;
      		yield return FawMarsStrokeV;
      		yield return FawMarsStrokeH;
      		yield return FawNeuter;
      		yield return FawGenderless;
      		yield return FawFacebookOfficial;
      		yield return FawPinterestP;
      		yield return FawWhatsapp;
      		yield return FawServer;
      		yield return FawUserPlus;
      		yield return FawUserTimes;
      		yield return FawBed;
      		yield return FawViacoin;
      		yield return FawTrain;
      		yield return FawSubway;
      		yield return FawMedium;
      		yield return FawYCombinator;
      		yield return FawOptinMonster;
      		yield return FawOpencart;
      		yield return FawExpeditedssl;
      		yield return FawBatteryFull;
      		yield return FawBatteryThreeQuarters;
      		yield return FawBatteryHalf;
      		yield return FawBatteryQuarter;
      		yield return FawBatteryEmpty;
      		yield return FawMousePointer;
      		yield return FawICursor;
      		yield return FawObjectGroup;
      		yield return FawObjectUngroup;
      		yield return FawStickyNote;
      		yield return FawStickyNoteO;
      		yield return FawCcJcb;
      		yield return FawCcDinersClub;
      		yield return FawClone;
      		yield return FawBalanceScale;
      		yield return FawHourglassO;
      		yield return FawHourglassStart;
      		yield return FawHourglassHalf;
      		yield return FawHourglassEnd;
      		yield return FawHourglass;
      		yield return FawHandRockO;
      		yield return FawHandPaperO;
      		yield return FawHandScissorsO;
      		yield return FawHandLizardO;
      		yield return FawHandSpockO;
      		yield return FawHandPointerO;
      		yield return FawHandPeaceO;
      		yield return FawTrademark;
      		yield return FawRegistered;
      		yield return FawCreativeCommons;
      		yield return FawGg;
      		yield return FawGgCircle;
      		yield return FawTripadvisor;
      		yield return FawOdnoklassniki;
      		yield return FawOdnoklassnikiSquare;
      		yield return FawGetPocket;
      		yield return FawWikipediaW;
      		yield return FawSafari;
      		yield return FawChrome;
      		yield return FawFirefox;
      		yield return FawOpera;
      		yield return FawInternetExplorer;
      		yield return FawTelevision;
      		yield return FawContao;
      		yield return Faw500px;
      		yield return FawAmazon;
      		yield return FawCalendarPlusO;
      		yield return FawCalendarMinusO;
      		yield return FawCalendarTimesO;
      		yield return FawCalendarCheckO;
      		yield return FawIndustry;
      		yield return FawMapPin;
      		yield return FawMapSigns;
      		yield return FawMapO;
      		yield return FawMap;
      		yield return FawCommenting;
      		yield return FawCommentingO;
      		yield return FawHouzz;
      		yield return FawVimeo;
      		yield return FawBlackTie;
      		yield return FawFonticons;
      		yield return FawRedditAlien;
      		yield return FawEdge;
      		yield return FawCreditCardAlt;
      		yield return FawCodiepie;
      		yield return FawModx;
      		yield return FawFortAwesome;
      		yield return FawUsb;
      		yield return FawProductHunt;
      		yield return FawMixcloud;
      		yield return FawScribd;
      		yield return FawPauseCircle;
      		yield return FawPauseCircleO;
      		yield return FawStopCircle;
      		yield return FawStopCircleO;
      		yield return FawShoppingBag;
      		yield return FawShoppingBasket;
      		yield return FawHashtag;
      		yield return FawBluetooth;
      		yield return FawBluetoothB;
      		yield return FawPercent;
        }
      }
    }
  }
}