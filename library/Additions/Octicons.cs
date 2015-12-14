namespace Mikepenz.Typeface
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using Android.Util;
  using Mikepenz.Iconics.Typeface;

  public class Octicons : Java.Lang.Object, ITypeface
  {
		const string TtfFile = "octicons-v3.2.0.ttf";

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

		public string MappingPrefix
		{
			get
			{
				return "oct";
			}
		}

		public string FontName
		{
			get
			{
				return "Octicons";
			}
		}

		public string Version
		{
			get
			{
				return "3.2.0";
			}
		}

		public int IconCount
		{
			get
			{
				return _chars.Count;
			}
		}


    public ICollection<string> Icons
    {
      get
      {
        return Icon.Values.Select(icon => icon.Name).ToList();
      }
    }

		public string Author
		{
			get
			{
				return "GitHub";
			}
		}

		public string Url
		{
			get
			{
				return "https://github.com/github/octicons";
			}
		}

		public string Description
		{
			get
			{
				return "GitHub's icon font https://octicons.github.com/";
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
		//		+++++++++


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
					var message = string.Format("Failed to load font file : {0} for {1} typeface. Reason: {2}", TtfFile, FontName, e.Message); 
					Log.Error("Iconics", message);
        }
      }
      return _typeface;
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
          return _typeFace ?? (_typeFace = new Octicons());
        }
      }

      public static readonly Icon OctAlert = new Icon('\uf02d', "oct_alert");
      public static readonly Icon OctArrowDown = new Icon('\uf03f', "oct_arrow_down");
      public static readonly Icon OctArrowLeft = new Icon('\uf040', "oct_arrow_left");
      public static readonly Icon OctArrowRight = new Icon('\uf03e', "oct_arrow_right");
      public static readonly Icon OctArrowSmallDown = new Icon('\uf0a0', "oct_arrow_small_down");
      public static readonly Icon OctArrowSmallLeft = new Icon('\uf0a1', "oct_arrow_small_left");
      public static readonly Icon OctArrowSmallRight = new Icon('\uf071', "oct_arrow_small_right");
      public static readonly Icon OctArrowSmallUp = new Icon('\uf09f', "oct_arrow_small_up");
      public static readonly Icon OctArrowUp = new Icon('\uf03d', "oct_arrow_up");
      public static readonly Icon OctMicroscope = new Icon('\uf0dd', "oct_microscope");
      public static readonly Icon OctBeaker = new Icon('\uf0dd', "oct_beaker");
      public static readonly Icon OctBell = new Icon('\uf0de', "oct_bell");
      public static readonly Icon OctBold = new Icon('\uf0e2', "oct_bold");
      public static readonly Icon OctBook = new Icon('\uf007', "oct_book");
      public static readonly Icon OctBookmark = new Icon('\uf07b', "oct_bookmark");
      public static readonly Icon OctBriefcase = new Icon('\uf0d3', "oct_briefcase");
      public static readonly Icon OctBroadcast = new Icon('\uf048', "oct_broadcast");
      public static readonly Icon OctBrowser = new Icon('\uf0c5', "oct_browser");
      public static readonly Icon OctBug = new Icon('\uf091', "oct_bug");
      public static readonly Icon OctCalendar = new Icon('\uf068', "oct_calendar");
      public static readonly Icon OctCheck = new Icon('\uf03a', "oct_check");
      public static readonly Icon OctChecklist = new Icon('\uf076', "oct_checklist");
      public static readonly Icon OctChevronDown = new Icon('\uf0a3', "oct_chevron_down");
      public static readonly Icon OctChevronLeft = new Icon('\uf0a4', "oct_chevron_left");
      public static readonly Icon OctChevronRight = new Icon('\uf078', "oct_chevron_right");
      public static readonly Icon OctChevronUp = new Icon('\uf0a2', "oct_chevron_up");
      public static readonly Icon OctCircleSlash = new Icon('\uf084', "oct_circle_slash");
      public static readonly Icon OctCircuitBoard = new Icon('\uf0d6', "oct_circuit_board");
      public static readonly Icon OctClippy = new Icon('\uf035', "oct_clippy");
      public static readonly Icon OctClock = new Icon('\uf046', "oct_clock");
      public static readonly Icon OctCloudDownload = new Icon('\uf00b', "oct_cloud_download");
      public static readonly Icon OctCloudUpload = new Icon('\uf00c', "oct_cloud_upload");
      public static readonly Icon OctCode = new Icon('\uf05f', "oct_code");
      public static readonly Icon OctColorMode = new Icon('\uf065', "oct_color_mode");
      public static readonly Icon OctCommentAdd = new Icon('\uf02b', "oct_comment_add");
      public static readonly Icon OctComment = new Icon('\uf02b', "oct_comment");
      public static readonly Icon OctCommentDiscussion = new Icon('\uf04f', "oct_comment_discussion");
      public static readonly Icon OctCreditCard = new Icon('\uf045', "oct_credit_card");
      public static readonly Icon OctDash = new Icon('\uf0ca', "oct_dash");
      public static readonly Icon OctDashboard = new Icon('\uf07d', "oct_dashboard");
      public static readonly Icon OctDatabase = new Icon('\uf096', "oct_database");
      public static readonly Icon OctClone = new Icon('\uf0dc', "oct_clone");
      public static readonly Icon OctDesktopDownload = new Icon('\uf0dc', "oct_desktop_download");
      public static readonly Icon OctDeviceCamera = new Icon('\uf056', "oct_device_camera");
      public static readonly Icon OctDeviceCameraVideo = new Icon('\uf057', "oct_device_camera_video");
      public static readonly Icon OctDeviceDesktop = new Icon('\uf27c', "oct_device_desktop");
      public static readonly Icon OctDeviceMobile = new Icon('\uf038', "oct_device_mobile");
      public static readonly Icon OctDiff = new Icon('\uf04d', "oct_diff");
      public static readonly Icon OctDiffAdded = new Icon('\uf06b', "oct_diff_added");
      public static readonly Icon OctDiffIgnored = new Icon('\uf099', "oct_diff_ignored");
      public static readonly Icon OctDiffModified = new Icon('\uf06d', "oct_diff_modified");
      public static readonly Icon OctDiffRemoved = new Icon('\uf06c', "oct_diff_removed");
      public static readonly Icon OctDiffRenamed = new Icon('\uf06e', "oct_diff_renamed");
      public static readonly Icon OctEllipsis = new Icon('\uf09a', "oct_ellipsis");
      public static readonly Icon OctEyeUnwatch = new Icon('\uf04e', "oct_eye_unwatch");
      public static readonly Icon OctEyeWatch = new Icon('\uf04e', "oct_eye_watch");
      public static readonly Icon OctEye = new Icon('\uf04e', "oct_eye");
      public static readonly Icon OctFileBinary = new Icon('\uf094', "oct_file_binary");
      public static readonly Icon OctFileCode = new Icon('\uf010', "oct_file_code");
      public static readonly Icon OctFileDirectory = new Icon('\uf016', "oct_file_directory");
      public static readonly Icon OctFileMedia = new Icon('\uf012', "oct_file_media");
      public static readonly Icon OctFilePdf = new Icon('\uf014', "oct_file_pdf");
      public static readonly Icon OctFileSubmodule = new Icon('\uf017', "oct_file_submodule");
      public static readonly Icon OctFileSymlinkDirectory = new Icon('\uf0b1', "oct_file_symlink_directory");
      public static readonly Icon OctFileSymlinkFile = new Icon('\uf0b0', "oct_file_symlink_file");
      public static readonly Icon OctFileText = new Icon('\uf011', "oct_file_text");
      public static readonly Icon OctFileZip = new Icon('\uf013', "oct_file_zip");
      public static readonly Icon OctFlame = new Icon('\uf0d2', "oct_flame");
      public static readonly Icon OctFold = new Icon('\uf0cc', "oct_fold");
      public static readonly Icon OctGear = new Icon('\uf02f', "oct_gear");
      public static readonly Icon OctGift = new Icon('\uf042', "oct_gift");
      public static readonly Icon OctGist = new Icon('\uf00e', "oct_gist");
      public static readonly Icon OctGistSecret = new Icon('\uf08c', "oct_gist_secret");
      public static readonly Icon OctGitBranchCreate = new Icon('\uf020', "oct_git_branch_create");
      public static readonly Icon OctGitBranchDelete = new Icon('\uf020', "oct_git_branch_delete");
      public static readonly Icon OctGitBranch = new Icon('\uf020', "oct_git_branch");
      public static readonly Icon OctGitCommit = new Icon('\uf01f', "oct_git_commit");
      public static readonly Icon OctGitCompare = new Icon('\uf0ac', "oct_git_compare");
      public static readonly Icon OctGitMerge = new Icon('\uf023', "oct_git_merge");
      public static readonly Icon OctGitPullRequestAbandoned = new Icon('\uf009', "oct_git_pull_request_abandoned");
      public static readonly Icon OctGitPullRequest = new Icon('\uf009', "oct_git_pull_request");
      public static readonly Icon OctGlobe = new Icon('\uf0b6', "oct_globe");
      public static readonly Icon OctGraph = new Icon('\uf043', "oct_graph");
      public static readonly Icon OctHeart = new Icon('\u2665', "oct_heart");
      public static readonly Icon OctHistory = new Icon('\uf07e', "oct_history");
      public static readonly Icon OctHome = new Icon('\uf08d', "oct_home");
      public static readonly Icon OctHorizontalRule = new Icon('\uf070', "oct_horizontal_rule");
      public static readonly Icon OctHubot = new Icon('\uf09d', "oct_hubot");
      public static readonly Icon OctInbox = new Icon('\uf0cf', "oct_inbox");
      public static readonly Icon OctInfo = new Icon('\uf059', "oct_info");
      public static readonly Icon OctIssueClosed = new Icon('\uf028', "oct_issue_closed");
      public static readonly Icon OctIssueOpened = new Icon('\uf026', "oct_issue_opened");
      public static readonly Icon OctIssueReopened = new Icon('\uf027', "oct_issue_reopened");
      public static readonly Icon OctItalic = new Icon('\uf0e4', "oct_italic");
      public static readonly Icon OctJersey = new Icon('\uf019', "oct_jersey");
      public static readonly Icon OctKey = new Icon('\uf049', "oct_key");
      public static readonly Icon OctKeyboard = new Icon('\uf00d', "oct_keyboard");
      public static readonly Icon OctLaw = new Icon('\uf0d8', "oct_law");
      public static readonly Icon OctLightBulb = new Icon('\uf000', "oct_light_bulb");
      public static readonly Icon OctLink = new Icon('\uf05c', "oct_link");
      public static readonly Icon OctLinkExternal = new Icon('\uf07f', "oct_link_external");
      public static readonly Icon OctListOrdered = new Icon('\uf062', "oct_list_ordered");
      public static readonly Icon OctListUnordered = new Icon('\uf061', "oct_list_unordered");
      public static readonly Icon OctLocation = new Icon('\uf060', "oct_location");
      public static readonly Icon OctGistPrivate = new Icon('\uf06a', "oct_gist_private");
      public static readonly Icon OctMirrorPrivate = new Icon('\uf06a', "oct_mirror_private");
      public static readonly Icon OctGitForkPrivate = new Icon('\uf06a', "oct_git_fork_private");
      public static readonly Icon OctLock = new Icon('\uf06a', "oct_lock");
      public static readonly Icon OctLogoGithub = new Icon('\uf092', "oct_logo_github");
      public static readonly Icon OctMail = new Icon('\uf03b', "oct_mail");
      public static readonly Icon OctMailRead = new Icon('\uf03c', "oct_mail_read");
      public static readonly Icon OctMailReply = new Icon('\uf051', "oct_mail_reply");
      public static readonly Icon OctMarkGithub = new Icon('\uf00a', "oct_mark_github");
      public static readonly Icon OctMarkdown = new Icon('\uf0c9', "oct_markdown");
      public static readonly Icon OctMegaphone = new Icon('\uf077', "oct_megaphone");
      public static readonly Icon OctMention = new Icon('\uf0be', "oct_mention");
      public static readonly Icon OctMilestone = new Icon('\uf075', "oct_milestone");
      public static readonly Icon OctMirrorPublic = new Icon('\uf024', "oct_mirror_public");
      public static readonly Icon OctMirror = new Icon('\uf024', "oct_mirror");
      public static readonly Icon OctMortarBoard = new Icon('\uf0d7', "oct_mortar_board");
      public static readonly Icon OctMute = new Icon('\uf080', "oct_mute");
      public static readonly Icon OctNoNewline = new Icon('\uf09c', "oct_no_newline");
      public static readonly Icon OctOctoface = new Icon('\uf008', "oct_octoface");
      public static readonly Icon OctOrganization = new Icon('\uf037', "oct_organization");
      public static readonly Icon OctPackage = new Icon('\uf0c4', "oct_package");
      public static readonly Icon OctPaintcan = new Icon('\uf0d1', "oct_paintcan");
      public static readonly Icon OctPencil = new Icon('\uf058', "oct_pencil");
      public static readonly Icon OctPersonAdd = new Icon('\uf018', "oct_person_add");
      public static readonly Icon OctPersonFollow = new Icon('\uf018', "oct_person_follow");
      public static readonly Icon OctPerson = new Icon('\uf018', "oct_person");
      public static readonly Icon OctPin = new Icon('\uf041', "oct_pin");
      public static readonly Icon OctPlug = new Icon('\uf0d4', "oct_plug");
      public static readonly Icon OctRepoCreate = new Icon('\uf05d', "oct_repo_create");
      public static readonly Icon OctGistNew = new Icon('\uf05d', "oct_gist_new");
      public static readonly Icon OctFileDirectoryCreate = new Icon('\uf05d', "oct_file_directory_create");
      public static readonly Icon OctFileAdd = new Icon('\uf05d', "oct_file_add");
      public static readonly Icon OctPlus = new Icon('\uf05d', "oct_plus");
      public static readonly Icon OctPrimitiveDot = new Icon('\uf052', "oct_primitive_dot");
      public static readonly Icon OctPrimitiveSquare = new Icon('\uf053', "oct_primitive_square");
      public static readonly Icon OctPulse = new Icon('\uf085', "oct_pulse");
      public static readonly Icon OctQuestion = new Icon('\uf02c', "oct_question");
      public static readonly Icon OctQuote = new Icon('\uf063', "oct_quote");
      public static readonly Icon OctRadioTower = new Icon('\uf030', "oct_radio_tower");
      public static readonly Icon OctRepoDelete = new Icon('\uf001', "oct_repo_delete");
      public static readonly Icon OctRepo = new Icon('\uf001', "oct_repo");
      public static readonly Icon OctRepoClone = new Icon('\uf04c', "oct_repo_clone");
      public static readonly Icon OctRepoForcePush = new Icon('\uf04a', "oct_repo_force_push");
      public static readonly Icon OctGistFork = new Icon('\uf002', "oct_gist_fork");
      public static readonly Icon OctRepoForked = new Icon('\uf002', "oct_repo_forked");
      public static readonly Icon OctRepoPull = new Icon('\uf006', "oct_repo_pull");
      public static readonly Icon OctRepoPush = new Icon('\uf005', "oct_repo_push");
      public static readonly Icon OctRocket = new Icon('\uf033', "oct_rocket");
      public static readonly Icon OctRss = new Icon('\uf034', "oct_rss");
      public static readonly Icon OctRuby = new Icon('\uf047', "oct_ruby");
      public static readonly Icon OctSearchSave = new Icon('\uf02e', "oct_search_save");
      public static readonly Icon OctSearch = new Icon('\uf02e', "oct_search");
      public static readonly Icon OctServer = new Icon('\uf097', "oct_server");
      public static readonly Icon OctSettings = new Icon('\uf07c', "oct_settings");
      public static readonly Icon OctShield = new Icon('\uf0e1', "oct_shield");
      public static readonly Icon OctLogIn = new Icon('\uf036', "oct_log_in");
      public static readonly Icon OctSignIn = new Icon('\uf036', "oct_sign_in");
      public static readonly Icon OctLogOut = new Icon('\uf032', "oct_log_out");
      public static readonly Icon OctSignOut = new Icon('\uf032', "oct_sign_out");
      public static readonly Icon OctSquirrel = new Icon('\uf0b2', "oct_squirrel");
      public static readonly Icon OctStarAdd = new Icon('\uf02a', "oct_star_add");
      public static readonly Icon OctStarDelete = new Icon('\uf02a', "oct_star_delete");
      public static readonly Icon OctStar = new Icon('\uf02a', "oct_star");
      public static readonly Icon OctStop = new Icon('\uf08f', "oct_stop");
      public static readonly Icon OctRepoSync = new Icon('\uf087', "oct_repo_sync");
      public static readonly Icon OctSync = new Icon('\uf087', "oct_sync");
      public static readonly Icon OctTagRemove = new Icon('\uf015', "oct_tag_remove");
      public static readonly Icon OctTagAdd = new Icon('\uf015', "oct_tag_add");
      public static readonly Icon OctTag = new Icon('\uf015', "oct_tag");
      public static readonly Icon OctTasklist = new Icon('\uf0e5', "oct_tasklist");
      public static readonly Icon OctTelescope = new Icon('\uf088', "oct_telescope");
      public static readonly Icon OctTerminal = new Icon('\uf0c8', "oct_terminal");
      public static readonly Icon OctTextSize = new Icon('\uf0e3', "oct_text_size");
      public static readonly Icon OctThreeBars = new Icon('\uf05e', "oct_three_bars");
      public static readonly Icon OctThumbsdown = new Icon('\uf0db', "oct_thumbsdown");
      public static readonly Icon OctThumbsup = new Icon('\uf0da', "oct_thumbsup");
      public static readonly Icon OctTools = new Icon('\uf031', "oct_tools");
      public static readonly Icon OctTrashcan = new Icon('\uf0d0', "oct_trashcan");
      public static readonly Icon OctTriangleDown = new Icon('\uf05b', "oct_triangle_down");
      public static readonly Icon OctTriangleLeft = new Icon('\uf044', "oct_triangle_left");
      public static readonly Icon OctTriangleRight = new Icon('\uf05a', "oct_triangle_right");
      public static readonly Icon OctTriangleUp = new Icon('\uf0aa', "oct_triangle_up");
      public static readonly Icon OctUnfold = new Icon('\uf039', "oct_unfold");
      public static readonly Icon OctUnmute = new Icon('\uf0ba', "oct_unmute");
      public static readonly Icon OctVersions = new Icon('\uf064', "oct_versions");
      public static readonly Icon OctWatch = new Icon('\uf0e0', "oct_watch");
      public static readonly Icon OctRemoveClose = new Icon('\uf081', "oct_remove_close");
      public static readonly Icon OctX = new Icon('\uf081', "oct_x");
      public static readonly Icon OctZap = new Icon('\u26A1', "oct_zap");

      public static IEnumerable<Icon> Values
      {
        get
        {
      		yield return OctAlert;
      		yield return OctArrowDown;
      		yield return OctArrowLeft;
      		yield return OctArrowRight;
      		yield return OctArrowSmallDown;
      		yield return OctArrowSmallLeft;
      		yield return OctArrowSmallRight;
      		yield return OctArrowSmallUp;
      		yield return OctArrowUp;
      		yield return OctMicroscope;
      		yield return OctBeaker;
      		yield return OctBell;
      		yield return OctBold;
      		yield return OctBook;
      		yield return OctBookmark;
      		yield return OctBriefcase;
      		yield return OctBroadcast;
      		yield return OctBrowser;
      		yield return OctBug;
      		yield return OctCalendar;
      		yield return OctCheck;
      		yield return OctChecklist;
      		yield return OctChevronDown;
      		yield return OctChevronLeft;
      		yield return OctChevronRight;
      		yield return OctChevronUp;
      		yield return OctCircleSlash;
      		yield return OctCircuitBoard;
      		yield return OctClippy;
      		yield return OctClock;
      		yield return OctCloudDownload;
      		yield return OctCloudUpload;
      		yield return OctCode;
      		yield return OctColorMode;
      		yield return OctCommentAdd;
      		yield return OctComment;
      		yield return OctCommentDiscussion;
      		yield return OctCreditCard;
      		yield return OctDash;
      		yield return OctDashboard;
      		yield return OctDatabase;
      		yield return OctClone;
      		yield return OctDesktopDownload;
      		yield return OctDeviceCamera;
      		yield return OctDeviceCameraVideo;
      		yield return OctDeviceDesktop;
      		yield return OctDeviceMobile;
      		yield return OctDiff;
      		yield return OctDiffAdded;
      		yield return OctDiffIgnored;
      		yield return OctDiffModified;
      		yield return OctDiffRemoved;
      		yield return OctDiffRenamed;
      		yield return OctEllipsis;
      		yield return OctEyeUnwatch;
      		yield return OctEyeWatch;
      		yield return OctEye;
      		yield return OctFileBinary;
      		yield return OctFileCode;
      		yield return OctFileDirectory;
      		yield return OctFileMedia;
      		yield return OctFilePdf;
      		yield return OctFileSubmodule;
      		yield return OctFileSymlinkDirectory;
      		yield return OctFileSymlinkFile;
      		yield return OctFileText;
      		yield return OctFileZip;
      		yield return OctFlame;
      		yield return OctFold;
      		yield return OctGear;
      		yield return OctGift;
      		yield return OctGist;
      		yield return OctGistSecret;
      		yield return OctGitBranchCreate;
      		yield return OctGitBranchDelete;
      		yield return OctGitBranch;
      		yield return OctGitCommit;
      		yield return OctGitCompare;
      		yield return OctGitMerge;
      		yield return OctGitPullRequestAbandoned;
      		yield return OctGitPullRequest;
      		yield return OctGlobe;
      		yield return OctGraph;
      		yield return OctHeart;
      		yield return OctHistory;
      		yield return OctHome;
      		yield return OctHorizontalRule;
      		yield return OctHubot;
      		yield return OctInbox;
      		yield return OctInfo;
      		yield return OctIssueClosed;
      		yield return OctIssueOpened;
      		yield return OctIssueReopened;
      		yield return OctItalic;
      		yield return OctJersey;
      		yield return OctKey;
      		yield return OctKeyboard;
      		yield return OctLaw;
      		yield return OctLightBulb;
      		yield return OctLink;
      		yield return OctLinkExternal;
      		yield return OctListOrdered;
      		yield return OctListUnordered;
      		yield return OctLocation;
      		yield return OctGistPrivate;
      		yield return OctMirrorPrivate;
      		yield return OctGitForkPrivate;
      		yield return OctLock;
      		yield return OctLogoGithub;
      		yield return OctMail;
      		yield return OctMailRead;
      		yield return OctMailReply;
      		yield return OctMarkGithub;
      		yield return OctMarkdown;
      		yield return OctMegaphone;
      		yield return OctMention;
      		yield return OctMilestone;
      		yield return OctMirrorPublic;
      		yield return OctMirror;
      		yield return OctMortarBoard;
      		yield return OctMute;
      		yield return OctNoNewline;
      		yield return OctOctoface;
      		yield return OctOrganization;
      		yield return OctPackage;
      		yield return OctPaintcan;
      		yield return OctPencil;
      		yield return OctPersonAdd;
      		yield return OctPersonFollow;
      		yield return OctPerson;
      		yield return OctPin;
      		yield return OctPlug;
      		yield return OctRepoCreate;
      		yield return OctGistNew;
      		yield return OctFileDirectoryCreate;
      		yield return OctFileAdd;
      		yield return OctPlus;
      		yield return OctPrimitiveDot;
      		yield return OctPrimitiveSquare;
      		yield return OctPulse;
      		yield return OctQuestion;
      		yield return OctQuote;
      		yield return OctRadioTower;
      		yield return OctRepoDelete;
      		yield return OctRepo;
      		yield return OctRepoClone;
      		yield return OctRepoForcePush;
      		yield return OctGistFork;
      		yield return OctRepoForked;
      		yield return OctRepoPull;
      		yield return OctRepoPush;
      		yield return OctRocket;
      		yield return OctRss;
      		yield return OctRuby;
      		yield return OctSearchSave;
      		yield return OctSearch;
      		yield return OctServer;
      		yield return OctSettings;
      		yield return OctShield;
      		yield return OctLogIn;
      		yield return OctSignIn;
      		yield return OctLogOut;
      		yield return OctSignOut;
      		yield return OctSquirrel;
      		yield return OctStarAdd;
      		yield return OctStarDelete;
      		yield return OctStar;
      		yield return OctStop;
      		yield return OctRepoSync;
      		yield return OctSync;
      		yield return OctTagRemove;
      		yield return OctTagAdd;
      		yield return OctTag;
      		yield return OctTasklist;
      		yield return OctTelescope;
      		yield return OctTerminal;
      		yield return OctTextSize;
      		yield return OctThreeBars;
      		yield return OctThumbsdown;
      		yield return OctThumbsup;
      		yield return OctTools;
      		yield return OctTrashcan;
      		yield return OctTriangleDown;
      		yield return OctTriangleLeft;
      		yield return OctTriangleRight;
      		yield return OctTriangleUp;
      		yield return OctUnfold;
      		yield return OctUnmute;
      		yield return OctVersions;
      		yield return OctWatch;
      		yield return OctRemoveClose;
      		yield return OctX;
      		yield return OctZap;
        }
      }
    }
  }
}