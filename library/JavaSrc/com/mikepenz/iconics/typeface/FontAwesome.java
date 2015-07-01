/**
 * Copyright 2014 Mike Penz
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * It uses FontAwesome font, licensed under OFL 1.1, which is compatible
 * with this library's license.
 *
 *     http://scripts.sil.org/cms/scripts/render_download.php?format=file&media_id=OFL_plaintext&filename=OFL.txt
 */
package com.mikepenz.iconics.typeface;

import android.content.Context;
import android.graphics.Typeface;

import java.util.Collection;
import java.util.HashMap;
import java.util.LinkedList;

/**
 * Created by mikepenz on 01.11.14.
 */
public class FontAwesome implements ITypeface {
    private static final String TTF_FILE = "fontawesome-webfont-4.3.0.ttf";

    private static Typeface typeface = null;

    private static HashMap<String, Character> mChars;

    @Override
    public IIcon getIcon(String key) {
        return Icon.valueOf(key);
    }

    @Override
    public HashMap<String, Character> getCharacters() {
        if (mChars == null) {
            HashMap<String, Character> aChars = new HashMap<String, Character>();
            for (Icon v : Icon.values()) {
                aChars.put(v.name(), v.character);
            }
            mChars = aChars;
        }

        return mChars;
    }

    @Override
    public String getMappingPrefix() {
        return "faw";
    }

    @Override
    public String getFontName() {
        return "FontAwesome";
    }

    @Override
    public String getVersion() {
        return "4.3.0";
    }

    @Override
    public int getIconCount() {
        return mChars.size();
    }

    @Override
    public Collection<String> getIcons() {
        Collection<String> icons = new LinkedList<String>();

        for (Icon value : Icon.values()) {
            icons.add(value.name());
        }

        return icons;
    }

    @Override
    public String getAuthor() {
        return "Dave Gandy";
    }

    @Override
    public String getUrl() {
        return "https://github.com/FortAwesome/Font-Awesome";
    }

    @Override
    public String getDescription() {
        return "Font Awesome is a full suite of 479 pictographic icons for easy scalable vector graphics on websites, created and maintained by Dave Gandy. Stay up to date @fontawesome.";
    }

    @Override
    public String getLicense() {
        return "SIL OFL 1.1";
    }

    @Override
    public String getLicenseUrl() {
        return "http://scripts.sil.org/OFL";
    }

    @Override
    public Typeface getTypeface(Context context) {
        if (typeface == null) {
            try {
                typeface = Typeface.createFromAsset(context.getAssets(), "fonts/" + TTF_FILE);
            } catch (Exception e) {
                return null;
            }
        }
        return typeface;
    }

    public static enum Icon implements IIcon {
        faw_adjust('\uf042'),
        faw_adn('\uf170'),
        faw_align_center('\uf037'),
        faw_align_justify('\uf039'),
        faw_align_left('\uf036'),
        faw_align_right('\uf038'),
        faw_ambulance('\uf0f9'),
        faw_anchor('\uf13d'),
        faw_android('\uf17b'),
        faw_angellist('\uf209'),
        faw_angle_double_down('\uf103'),
        faw_angle_double_left('\uf100'),
        faw_angle_double_right('\uf101'),
        faw_angle_double_up('\uf102'),
        faw_angle_down('\uf107'),
        faw_angle_left('\uf104'),
        faw_angle_right('\uf105'),
        faw_angle_up('\uf106'),
        faw_apple('\uf179'),
        faw_archive('\uf187'),
        faw_area_chart('\uf1fe'),
        faw_arrow_circle_down('\uf0ab'),
        faw_arrow_circle_left('\uf0a8'),
        faw_arrow_circle_o_down('\uf01a'),
        faw_arrow_circle_o_left('\uf190'),
        faw_arrow_circle_o_right('\uf18e'),
        faw_arrow_circle_o_up('\uf01b'),
        faw_arrow_circle_right('\uf0a9'),
        faw_arrow_circle_up('\uf0aa'),
        faw_arrow_down('\uf063'),
        faw_arrow_left('\uf060'),
        faw_arrow_right('\uf061'),
        faw_arrow_up('\uf062'),
        faw_arrows('\uf047'),
        faw_arrows_alt('\uf0b2'),
        faw_arrows_h('\uf07e'),
        faw_arrows_v('\uf07d'),
        faw_asterisk('\uf069'),
        faw_at('\uf1fa'),
        faw_automobile('\uf1b9'),
        faw_backward('\uf04a'),
        faw_ban('\uf05e'),
        faw_bank('\uf19c'),
        faw_bar_chart('\uf080'),
        faw_bar_chart_o('\uf080'),
        faw_barcode('\uf02a'),
        faw_bars('\uf0c9'),
        faw_bed('\uf236'),
        faw_beer('\uf0fc'),
        faw_behance('\uf1b4'),
        faw_behance_square('\uf1b5'),
        faw_bell('\uf0f3'),
        faw_bell_o('\uf0a2'),
        faw_bell_slash('\uf1f6'),
        faw_bell_slash_o('\uf1f7'),
        faw_bicycle('\uf206'),
        faw_binoculars('\uf1e5'),
        faw_birthday_cake('\uf1fd'),
        faw_bitbucket('\uf171'),
        faw_bitbucket_square('\uf172'),
        faw_bitcoin('\uf15a'),
        faw_bold('\uf032'),
        faw_bolt('\uf0e7'),
        faw_bomb('\uf1e2'),
        faw_book('\uf02d'),
        faw_bookmark('\uf02e'),
        faw_bookmark_o('\uf097'),
        faw_briefcase('\uf0b1'),
        faw_btc('\uf15a'),
        faw_bug('\uf188'),
        faw_building('\uf1ad'),
        faw_building_o('\uf0f7'),
        faw_bullhorn('\uf0a1'),
        faw_bullseye('\uf140'),
        faw_bus('\uf207'),
        faw_buysellads('\uf20d'),
        faw_cab('\uf1ba'),
        faw_calculator('\uf1ec'),
        faw_calendar('\uf073'),
        faw_calendar_o('\uf133'),
        faw_camera('\uf030'),
        faw_camera_retro('\uf083'),
        faw_car('\uf1b9'),
        faw_caret_down('\uf0d7'),
        faw_caret_left('\uf0d9'),
        faw_caret_right('\uf0da'),
        faw_caret_square_o_down('\uf150'),
        faw_caret_square_o_left('\uf191'),
        faw_caret_square_o_right('\uf152'),
        faw_caret_square_o_up('\uf151'),
        faw_caret_up('\uf0d8'),
        faw_cart_arrow_down('\uf218'),
        faw_cart_plus('\uf217'),
        faw_cc('\uf20a'),
        faw_cc_amex('\uf1f3'),
        faw_cc_discover('\uf1f2'),
        faw_cc_mastercard('\uf1f1'),
        faw_cc_paypal('\uf1f4'),
        faw_cc_stripe('\uf1f5'),
        faw_cc_visa('\uf1f0'),
        faw_certificate('\uf0a3'),
        faw_chain('\uf0c1'),
        faw_chain_broken('\uf127'),
        faw_check('\uf00c'),
        faw_check_circle('\uf058'),
        faw_check_circle_o('\uf05d'),
        faw_check_square('\uf14a'),
        faw_check_square_o('\uf046'),
        faw_chevron_circle_down('\uf13a'),
        faw_chevron_circle_left('\uf137'),
        faw_chevron_circle_right('\uf138'),
        faw_chevron_circle_up('\uf139'),
        faw_chevron_down('\uf078'),
        faw_chevron_left('\uf053'),
        faw_chevron_right('\uf054'),
        faw_chevron_up('\uf077'),
        faw_child('\uf1ae'),
        faw_circle('\uf111'),
        faw_circle_o('\uf10c'),
        faw_circle_o_notch('\uf1ce'),
        faw_circle_thin('\uf1db'),
        faw_clipboard('\uf0ea'),
        faw_clock_o('\uf017'),
        faw_close('\uf00d'),
        faw_cloud('\uf0c2'),
        faw_cloud_download('\uf0ed'),
        faw_cloud_upload('\uf0ee'),
        faw_cny('\uf157'),
        faw_code('\uf121'),
        faw_code_fork('\uf126'),
        faw_codepen('\uf1cb'),
        faw_coffee('\uf0f4'),
        faw_cog('\uf013'),
        faw_cogs('\uf085'),
        faw_columns('\uf0db'),
        faw_comment('\uf075'),
        faw_comment_o('\uf0e5'),
        faw_comments('\uf086'),
        faw_comments_o('\uf0e6'),
        faw_compass('\uf14e'),
        faw_compress('\uf066'),
        faw_connectdevelop('\uf20e'),
        faw_copy('\uf0c5'),
        faw_copyright('\uf1f9'),
        faw_credit_card('\uf09d'),
        faw_crop('\uf125'),
        faw_crosshairs('\uf05b'),
        faw_css3('\uf13c'),
        faw_cube('\uf1b2'),
        faw_cubes('\uf1b3'),
        faw_cut('\uf0c4'),
        faw_cutlery('\uf0f5'),
        faw_dashboard('\uf0e4'),
        faw_dashcube('\uf210'),
        faw_database('\uf1c0'),
        faw_dedent('\uf03b'),
        faw_delicious('\uf1a5'),
        faw_desktop('\uf108'),
        faw_deviantart('\uf1bd'),
        faw_diamond('\uf219'),
        faw_digg('\uf1a6'),
        faw_dollar('\uf155'),
        faw_dot_circle_o('\uf192'),
        faw_download('\uf019'),
        faw_dribbble('\uf17d'),
        faw_dropbox('\uf16b'),
        faw_drupal('\uf1a9'),
        faw_edit('\uf044'),
        faw_eject('\uf052'),
        faw_ellipsis_h('\uf141'),
        faw_ellipsis_v('\uf142'),
        faw_empire('\uf1d1'),
        faw_envelope('\uf0e0'),
        faw_envelope_o('\uf003'),
        faw_envelope_square('\uf199'),
        faw_eraser('\uf12d'),
        faw_eur('\uf153'),
        faw_euro('\uf153'),
        faw_exchange('\uf0ec'),
        faw_exclamation('\uf12a'),
        faw_exclamation_circle('\uf06a'),
        faw_exclamation_triangle('\uf071'),
        faw_expand('\uf065'),
        faw_external_link('\uf08e'),
        faw_external_link_square('\uf14c'),
        faw_eye('\uf06e'),
        faw_eye_slash('\uf070'),
        faw_eyedropper('\uf1fb'),
        faw_facebook('\uf09a'),
        faw_facebook_f('\uf09a'),
        faw_facebook_official('\uf230'),
        faw_facebook_square('\uf082'),
        faw_fast_backward('\uf049'),
        faw_fast_forward('\uf050'),
        faw_fax('\uf1ac'),
        faw_female('\uf182'),
        faw_fighter_jet('\uf0fb'),
        faw_file('\uf15b'),
        faw_file_archive_o('\uf1c6'),
        faw_file_audio_o('\uf1c7'),
        faw_file_code_o('\uf1c9'),
        faw_file_excel_o('\uf1c3'),
        faw_file_image_o('\uf1c5'),
        faw_file_movie_o('\uf1c8'),
        faw_file_o('\uf016'),
        faw_file_pdf_o('\uf1c1'),
        faw_file_photo_o('\uf1c5'),
        faw_file_picture_o('\uf1c5'),
        faw_file_powerpoint_o('\uf1c4'),
        faw_file_sound_o('\uf1c7'),
        faw_file_text('\uf15c'),
        faw_file_text_o('\uf0f6'),
        faw_file_video_o('\uf1c8'),
        faw_file_word_o('\uf1c2'),
        faw_file_zip_o('\uf1c6'),
        faw_files_o('\uf0c5'),
        faw_film('\uf008'),
        faw_filter('\uf0b0'),
        faw_fire('\uf06d'),
        faw_fire_extinguisher('\uf134'),
        faw_flag('\uf024'),
        faw_flag_checkered('\uf11e'),
        faw_flag_o('\uf11d'),
        faw_flash('\uf0e7'),
        faw_flask('\uf0c3'),
        faw_flickr('\uf16e'),
        faw_floppy_o('\uf0c7'),
        faw_folder('\uf07b'),
        faw_folder_o('\uf114'),
        faw_folder_open('\uf07c'),
        faw_folder_open_o('\uf115'),
        faw_font('\uf031'),
        faw_forumbee('\uf211'),
        faw_forward('\uf04e'),
        faw_foursquare('\uf180'),
        faw_frown_o('\uf119'),
        faw_futbol_o('\uf1e3'),
        faw_gamepad('\uf11b'),
        faw_gavel('\uf0e3'),
        faw_gbp('\uf154'),
        faw_ge('\uf1d1'),
        faw_gear('\uf013'),
        faw_gears('\uf085'),
        faw_genderless('\uf1db'),
        faw_gift('\uf06b'),
        faw_git('\uf1d3'),
        faw_git_square('\uf1d2'),
        faw_github('\uf09b'),
        faw_github_alt('\uf113'),
        faw_github_square('\uf092'),
        faw_gittip('\uf184'),
        faw_glass('\uf000'),
        faw_globe('\uf0ac'),
        faw_google('\uf1a0'),
        faw_google_plus('\uf0d5'),
        faw_google_plus_square('\uf0d4'),
        faw_google_wallet('\uf1ee'),
        faw_graduation_cap('\uf19d'),
        faw_gratipay('\uf184'),
        faw_group('\uf0c0'),
        faw_h_square('\uf0fd'),
        faw_hacker_news('\uf1d4'),
        faw_hand_o_down('\uf0a7'),
        faw_hand_o_left('\uf0a5'),
        faw_hand_o_right('\uf0a4'),
        faw_hand_o_up('\uf0a6'),
        faw_hdd_o('\uf0a0'),
        faw_header('\uf1dc'),
        faw_headphones('\uf025'),
        faw_heart('\uf004'),
        faw_heart_o('\uf08a'),
        faw_heartbeat('\uf21e'),
        faw_history('\uf1da'),
        faw_home('\uf015'),
        faw_hospital_o('\uf0f8'),
        faw_hotel('\uf236'),
        faw_html5('\uf13b'),
        faw_ils('\uf20b'),
        faw_image('\uf03e'),
        faw_inbox('\uf01c'),
        faw_indent('\uf03c'),
        faw_info('\uf129'),
        faw_info_circle('\uf05a'),
        faw_inr('\uf156'),
        faw_instagram('\uf16d'),
        faw_institution('\uf19c'),
        faw_ioxhost('\uf208'),
        faw_italic('\uf033'),
        faw_joomla('\uf1aa'),
        faw_jpy('\uf157'),
        faw_jsfiddle('\uf1cc'),
        faw_key('\uf084'),
        faw_keyboard_o('\uf11c'),
        faw_krw('\uf159'),
        faw_language('\uf1ab'),
        faw_laptop('\uf109'),
        faw_lastfm('\uf202'),
        faw_lastfm_square('\uf203'),
        faw_leaf('\uf06c'),
        faw_leanpub('\uf212'),
        faw_legal('\uf0e3'),
        faw_lemon_o('\uf094'),
        faw_level_down('\uf149'),
        faw_level_up('\uf148'),
        faw_life_bouy('\uf1cd'),
        faw_life_buoy('\uf1cd'),
        faw_life_ring('\uf1cd'),
        faw_life_saver('\uf1cd'),
        faw_lightbulb_o('\uf0eb'),
        faw_line_chart('\uf201'),
        faw_link('\uf0c1'),
        faw_linkedin('\uf0e1'),
        faw_linkedin_square('\uf08c'),
        faw_linux('\uf17c'),
        faw_list('\uf03a'),
        faw_list_alt('\uf022'),
        faw_list_ol('\uf0cb'),
        faw_list_ul('\uf0ca'),
        faw_location_arrow('\uf124'),
        faw_lock('\uf023'),
        faw_long_arrow_down('\uf175'),
        faw_long_arrow_left('\uf177'),
        faw_long_arrow_right('\uf178'),
        faw_long_arrow_up('\uf176'),
        faw_magic('\uf0d0'),
        faw_magnet('\uf076'),
        faw_mail_forward('\uf064'),
        faw_mail_reply('\uf112'),
        faw_mail_reply_all('\uf122'),
        faw_male('\uf183'),
        faw_map_marker('\uf041'),
        faw_mars('\uf222'),
        faw_mars_double('\uf227'),
        faw_mars_stroke('\uf229'),
        faw_mars_stroke_h('\uf22b'),
        faw_mars_stroke_v('\uf22a'),
        faw_maxcdn('\uf136'),
        faw_meanpath('\uf20c'),
        faw_medium('\uf23a'),
        faw_medkit('\uf0fa'),
        faw_meh_o('\uf11a'),
        faw_mercury('\uf223'),
        faw_microphone('\uf130'),
        faw_microphone_slash('\uf131'),
        faw_minus('\uf068'),
        faw_minus_circle('\uf056'),
        faw_minus_square('\uf146'),
        faw_minus_square_o('\uf147'),
        faw_mobile('\uf10b'),
        faw_mobile_phone('\uf10b'),
        faw_money('\uf0d6'),
        faw_moon_o('\uf186'),
        faw_mortar_board('\uf19d'),
        faw_motorcycle('\uf21c'),
        faw_music('\uf001'),
        faw_navicon('\uf0c9'),
        faw_neuter('\uf22c'),
        faw_newspaper_o('\uf1ea'),
        faw_openid('\uf19b'),
        faw_outdent('\uf03b'),
        faw_pagelines('\uf18c'),
        faw_paint_brush('\uf1fc'),
        faw_paper_plane('\uf1d8'),
        faw_paper_plane_o('\uf1d9'),
        faw_paperclip('\uf0c6'),
        faw_paragraph('\uf1dd'),
        faw_paste('\uf0ea'),
        faw_pause('\uf04c'),
        faw_paw('\uf1b0'),
        faw_paypal('\uf1ed'),
        faw_pencil('\uf040'),
        faw_pencil_square('\uf14b'),
        faw_pencil_square_o('\uf044'),
        faw_phone('\uf095'),
        faw_phone_square('\uf098'),
        faw_photo('\uf03e'),
        faw_picture_o('\uf03e'),
        faw_pie_chart('\uf200'),
        faw_pied_piper('\uf1a7'),
        faw_pied_piper_alt('\uf1a8'),
        faw_pinterest('\uf0d2'),
        faw_pinterest_p('\uf231'),
        faw_pinterest_square('\uf0d3'),
        faw_plane('\uf072'),
        faw_play('\uf04b'),
        faw_play_circle('\uf144'),
        faw_play_circle_o('\uf01d'),
        faw_plug('\uf1e6'),
        faw_plus('\uf067'),
        faw_plus_circle('\uf055'),
        faw_plus_square('\uf0fe'),
        faw_plus_square_o('\uf196'),
        faw_power_off('\uf011'),
        faw_print('\uf02f'),
        faw_puzzle_piece('\uf12e'),
        faw_qq('\uf1d6'),
        faw_qrcode('\uf029'),
        faw_question('\uf128'),
        faw_question_circle('\uf059'),
        faw_quote_left('\uf10d'),
        faw_quote_right('\uf10e'),
        faw_ra('\uf1d0'),
        faw_random('\uf074'),
        faw_rebel('\uf1d0'),
        faw_recycle('\uf1b8'),
        faw_reddit('\uf1a1'),
        faw_reddit_square('\uf1a2'),
        faw_refresh('\uf021'),
        faw_remove('\uf00d'),
        faw_renren('\uf18b'),
        faw_reorder('\uf0c9'),
        faw_repeat('\uf01e'),
        faw_reply('\uf112'),
        faw_reply_all('\uf122'),
        faw_retweet('\uf079'),
        faw_rmb('\uf157'),
        faw_road('\uf018'),
        faw_rocket('\uf135'),
        faw_rotate_left('\uf0e2'),
        faw_rotate_right('\uf01e'),
        faw_rouble('\uf158'),
        faw_rss('\uf09e'),
        faw_rss_square('\uf143'),
        faw_rub('\uf158'),
        faw_ruble('\uf158'),
        faw_rupee('\uf156'),
        faw_save('\uf0c7'),
        faw_scissors('\uf0c4'),
        faw_search('\uf002'),
        faw_search_minus('\uf010'),
        faw_search_plus('\uf00e'),
        faw_sellsy('\uf213'),
        faw_send('\uf1d8'),
        faw_send_o('\uf1d9'),
        faw_server('\uf233'),
        faw_share('\uf064'),
        faw_share_alt('\uf1e0'),
        faw_share_alt_square('\uf1e1'),
        faw_share_square('\uf14d'),
        faw_share_square_o('\uf045'),
        faw_shekel('\uf20b'),
        faw_sheqel('\uf20b'),
        faw_shield('\uf132'),
        faw_ship('\uf21a'),
        faw_shirtsinbulk('\uf214'),
        faw_shopping_cart('\uf07a'),
        faw_sign_in('\uf090'),
        faw_sign_out('\uf08b'),
        faw_signal('\uf012'),
        faw_simplybuilt('\uf215'),
        faw_sitemap('\uf0e8'),
        faw_skyatlas('\uf216'),
        faw_skype('\uf17e'),
        faw_slack('\uf198'),
        faw_sliders('\uf1de'),
        faw_slideshare('\uf1e7'),
        faw_smile_o('\uf118'),
        faw_soccer_ball_o('\uf1e3'),
        faw_sort('\uf0dc'),
        faw_sort_alpha_asc('\uf15d'),
        faw_sort_alpha_desc('\uf15e'),
        faw_sort_amount_asc('\uf160'),
        faw_sort_amount_desc('\uf161'),
        faw_sort_asc('\uf0de'),
        faw_sort_desc('\uf0dd'),
        faw_sort_down('\uf0dd'),
        faw_sort_numeric_asc('\uf162'),
        faw_sort_numeric_desc('\uf163'),
        faw_sort_up('\uf0de'),
        faw_soundcloud('\uf1be'),
        faw_space_shuttle('\uf197'),
        faw_spinner('\uf110'),
        faw_spoon('\uf1b1'),
        faw_spotify('\uf1bc'),
        faw_square('\uf0c8'),
        faw_square_o('\uf096'),
        faw_stack_exchange('\uf18d'),
        faw_stack_overflow('\uf16c'),
        faw_star('\uf005'),
        faw_star_half('\uf089'),
        faw_star_half_empty('\uf123'),
        faw_star_half_full('\uf123'),
        faw_star_half_o('\uf123'),
        faw_star_o('\uf006'),
        faw_steam('\uf1b6'),
        faw_steam_square('\uf1b7'),
        faw_step_backward('\uf048'),
        faw_step_forward('\uf051'),
        faw_stethoscope('\uf0f1'),
        faw_stop('\uf04d'),
        faw_street_view('\uf21d'),
        faw_strikethrough('\uf0cc'),
        faw_stumbleupon('\uf1a4'),
        faw_stumbleupon_circle('\uf1a3'),
        faw_subscript('\uf12c'),
        faw_subway('\uf239'),
        faw_suitcase('\uf0f2'),
        faw_sun_o('\uf185'),
        faw_superscript('\uf12b'),
        faw_support('\uf1cd'),
        faw_table('\uf0ce'),
        faw_tablet('\uf10a'),
        faw_tachometer('\uf0e4'),
        faw_tag('\uf02b'),
        faw_tags('\uf02c'),
        faw_tasks('\uf0ae'),
        faw_taxi('\uf1ba'),
        faw_tencent_weibo('\uf1d5'),
        faw_terminal('\uf120'),
        faw_text_height('\uf034'),
        faw_text_width('\uf035'),
        faw_th('\uf00a'),
        faw_th_large('\uf009'),
        faw_th_list('\uf00b'),
        faw_thumb_tack('\uf08d'),
        faw_thumbs_down('\uf165'),
        faw_thumbs_o_down('\uf088'),
        faw_thumbs_o_up('\uf087'),
        faw_thumbs_up('\uf164'),
        faw_ticket('\uf145'),
        faw_times('\uf00d'),
        faw_times_circle('\uf057'),
        faw_times_circle_o('\uf05c'),
        faw_tint('\uf043'),
        faw_toggle_down('\uf150'),
        faw_toggle_left('\uf191'),
        faw_toggle_off('\uf204'),
        faw_toggle_on('\uf205'),
        faw_toggle_right('\uf152'),
        faw_toggle_up('\uf151'),
        faw_train('\uf238'),
        faw_transgender('\uf224'),
        faw_transgender_alt('\uf225'),
        faw_trash('\uf1f8'),
        faw_trash_o('\uf014'),
        faw_tree('\uf1bb'),
        faw_trello('\uf181'),
        faw_trophy('\uf091'),
        faw_truck('\uf0d1'),
        faw_try('\uf195'),
        faw_tty('\uf1e4'),
        faw_tumblr('\uf173'),
        faw_tumblr_square('\uf174'),
        faw_turkish_lira('\uf195'),
        faw_twitch('\uf1e8'),
        faw_twitter('\uf099'),
        faw_twitter_square('\uf081'),
        faw_umbrella('\uf0e9'),
        faw_underline('\uf0cd'),
        faw_undo('\uf0e2'),
        faw_university('\uf19c'),
        faw_unlink('\uf127'),
        faw_unlock('\uf09c'),
        faw_unlock_alt('\uf13e'),
        faw_unsorted('\uf0dc'),
        faw_upload('\uf093'),
        faw_usd('\uf155'),
        faw_user('\uf007'),
        faw_user_md('\uf0f0'),
        faw_user_plus('\uf234'),
        faw_user_secret('\uf21b'),
        faw_user_times('\uf235'),
        faw_users('\uf0c0'),
        faw_venus('\uf221'),
        faw_venus_double('\uf226'),
        faw_venus_mars('\uf228'),
        faw_viacoin('\uf237'),
        faw_video_camera('\uf03d'),
        faw_vimeo_square('\uf194'),
        faw_vine('\uf1ca'),
        faw_vk('\uf189'),
        faw_volume_down('\uf027'),
        faw_volume_off('\uf026'),
        faw_volume_up('\uf028'),
        faw_warning('\uf071'),
        faw_wechat('\uf1d7'),
        faw_weibo('\uf18a'),
        faw_weixin('\uf1d7'),
        faw_whatsapp('\uf232'),
        faw_wheelchair('\uf193'),
        faw_wifi('\uf1eb'),
        faw_windows('\uf17a'),
        faw_won('\uf159'),
        faw_wordpress('\uf19a'),
        faw_wrench('\uf0ad'),
        faw_xing('\uf168'),
        faw_xing_square('\uf169'),
        faw_yahoo('\uf19e'),
        faw_yelp('\uf1e9'),
        faw_yen('\uf157'),
        faw_youtube('\uf167'),
        faw_youtube_play('\uf16a'),
        faw_youtube_square('\uf166');

        char character;

        Icon(char character) {
            this.character = character;
        }

        public String getFormattedName() {
            return "{" + name() + "}";
        }

        public char getCharacter() {
            return character;
        }

        public String getName() {
            return name();
        }

        // remember the typeface so we can use it later
        private static ITypeface typeface;

        public ITypeface getTypeface() {
            if (typeface == null) {
                typeface = new FontAwesome();
            }
            return typeface;
        }
    }
}
