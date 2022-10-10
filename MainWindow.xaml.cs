using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CopyBoard
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Properties.Settings.Default.TabNumber = 1;

            // Tab選択変更時イベント登録
            ContentsTab.SelectionChanged += new SelectionChangedEventHandler( ContentsTab_SelectionChanged );

            // 設定済みタイトルを読み込み
            LoadDisplay();
        }

        /// <summary>
        /// メインウィンドウ更新処理
        /// </summary>
        void LoadDisplay()
        {
            // タブ1
            if ( Properties.Settings.Default.TabNumber == 1 ) {

                // ボタン Contentに"_"を設定した場合、アクセスキー指定となり表示されないので"__"に置き換える
                CpyBtn1.Content = Properties.Settings.Default.Title1.Replace( "_", "__" );
                CpyBtn2.Content = Properties.Settings.Default.Title2.Replace( "_", "__" );
                CpyBtn3.Content = Properties.Settings.Default.Title3.Replace( "_", "__" );
                CpyBtn4.Content = Properties.Settings.Default.Title4.Replace( "_", "__" );
                CpyBtn5.Content = Properties.Settings.Default.Title5.Replace( "_", "__" );
                CpyBtn6.Content = Properties.Settings.Default.Title6.Replace( "_", "__" );
                CpyBtn7.Content = Properties.Settings.Default.Title7.Replace( "_", "__" );
                CpyBtn8.Content = Properties.Settings.Default.Title8.Replace( "_", "__" );
                CpyBtn9.Content = Properties.Settings.Default.Title9.Replace( "_", "__" );
                CpyBtn10.Content = Properties.Settings.Default.Title10.Replace( "_", "__" );
            }
            // タブ2
            else if ( Properties.Settings.Default.TabNumber == 2 ) {
                CpyBtn11.Content = Properties.Settings.Default.Title11.Replace( "_", "__" );
                CpyBtn12.Content = Properties.Settings.Default.Title12.Replace( "_", "__" );
                CpyBtn13.Content = Properties.Settings.Default.Title13.Replace( "_", "__" );
                CpyBtn14.Content = Properties.Settings.Default.Title14.Replace( "_", "__" );
                CpyBtn15.Content = Properties.Settings.Default.Title15.Replace( "_", "__" );
                CpyBtn16.Content = Properties.Settings.Default.Title16.Replace( "_", "__" );
                CpyBtn17.Content = Properties.Settings.Default.Title17.Replace( "_", "__" );
                CpyBtn18.Content = Properties.Settings.Default.Title18.Replace( "_", "__" );
                CpyBtn19.Content = Properties.Settings.Default.Title19.Replace( "_", "__" );
                CpyBtn20.Content = Properties.Settings.Default.Title20.Replace( "_", "__" );
            }
            // タブ3
            else if ( Properties.Settings.Default.TabNumber == 3 ) {
                CpyBtn21.Content = Properties.Settings.Default.Title21.Replace( "_", "__" );
                CpyBtn22.Content = Properties.Settings.Default.Title22.Replace( "_", "__" );
                CpyBtn23.Content = Properties.Settings.Default.Title23.Replace( "_", "__" );
                CpyBtn24.Content = Properties.Settings.Default.Title24.Replace( "_", "__" );
                CpyBtn25.Content = Properties.Settings.Default.Title25.Replace( "_", "__" );
                CpyBtn26.Content = Properties.Settings.Default.Title26.Replace( "_", "__" );
                CpyBtn27.Content = Properties.Settings.Default.Title27.Replace( "_", "__" );
                CpyBtn28.Content = Properties.Settings.Default.Title28.Replace( "_", "__" );
                CpyBtn29.Content = Properties.Settings.Default.Title29.Replace( "_", "__" );
                CpyBtn30.Content = Properties.Settings.Default.Title30.Replace( "_", "__" );
            }
        }

        private void CpyBtn1_MouseUp( object sender, MouseButtonEventArgs e )
        {
            CpyBtnCommonMouseUp( e, 1 );
        }

        private void CpyBtn2_MouseUp( object sender, MouseButtonEventArgs e )
        {
            CpyBtnCommonMouseUp( e, 2 );
        }

        private void CpyBtn3_MouseUp( object sender, MouseButtonEventArgs e )
        {
            CpyBtnCommonMouseUp( e, 3 );
        }

        private void CpyBtn4_MouseUp( object sender, MouseButtonEventArgs e )
        {
            CpyBtnCommonMouseUp( e, 4 );
        }

        private void CpyBtn5_MouseUp( object sender, MouseButtonEventArgs e )
        {
            CpyBtnCommonMouseUp( e, 5 );
        }

        private void CpyBtn6_MouseUp( object sender, MouseButtonEventArgs e )
        {
            CpyBtnCommonMouseUp( e, 6 );
        }

        private void CpyBtn7_MouseUp( object sender, MouseButtonEventArgs e )
        {
            CpyBtnCommonMouseUp( e, 7 );
        }

        private void CpyBtn8_MouseUp( object sender, MouseButtonEventArgs e )
        {
            CpyBtnCommonMouseUp( e, 8 );
        }

        private void CpyBtn9_MouseUp( object sender, MouseButtonEventArgs e )
        {
            CpyBtnCommonMouseUp( e, 9 );
        }

        private void CpyBtn10_MouseUp( object sender, MouseButtonEventArgs e )
        {
            CpyBtnCommonMouseUp( e, 10 );
        }

        /// <summary>
        /// マウスアップ時の共通処理
        /// </summary>
        /// <param name="e">マウスボタンイベント</param>
        /// <param name="BtnNumber">上から何番目(1～10)</param>
        private void CpyBtnCommonMouseUp( MouseButtonEventArgs e, int BtnNumber )
        {
            // 押されたボタン番号を保持
            Properties.Settings.Default.ButtonNumber = BtnNumber;

            switch ( e.ChangedButton ) {
                case MouseButton.Right:
                    // 右クリック

                    // 編集画面を開く
                    OpenEditWindow();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// クリップボードにコピー処理
        /// </summary>
        private void CopyClipBoardContents()
        {
            var BtnNumber = Properties.Settings.Default.ButtonNumber;

            // 登録済みテキストをクリップボードにコピー
            object cpyTest = "";

            // タブ 1
            if ( Properties.Settings.Default.TabNumber == 1 ) {
                // 押されたボタンで登録済みテキストを抽出
                if ( BtnNumber == 1 ) {
                    cpyTest = Properties.Settings.Default.Contents1;
                }
                else if ( BtnNumber == 2 ) {
                    cpyTest = Properties.Settings.Default.Contents2;
                }
                else if ( BtnNumber == 3 ) {
                    cpyTest = Properties.Settings.Default.Contents3;
                }
                else if ( BtnNumber == 4 ) {
                    cpyTest = Properties.Settings.Default.Contents4;
                }
                else if ( BtnNumber == 5 ) {
                    cpyTest = Properties.Settings.Default.Contents5;
                }
                else if ( BtnNumber == 6 ) {
                    cpyTest = Properties.Settings.Default.Contents6;
                }
                else if ( BtnNumber == 7 ) {
                    cpyTest = Properties.Settings.Default.Contents7;
                }
                else if ( BtnNumber == 8 ) {
                    cpyTest = Properties.Settings.Default.Contents8;
                }
                else if ( BtnNumber == 9 ) {
                    cpyTest = Properties.Settings.Default.Contents9;
                }
                else if ( BtnNumber == 10 ) {
                    cpyTest = Properties.Settings.Default.Contents10;
                }
            }

            // タブ 2
            else if ( Properties.Settings.Default.TabNumber == 2 ) {
                // 押されたボタンで登録済みテキストを抽出
                if ( BtnNumber == 1 ) {
                    cpyTest = Properties.Settings.Default.Contents11;
                }
                else if ( BtnNumber == 2 ) {
                    cpyTest = Properties.Settings.Default.Contents12;
                }
                else if ( BtnNumber == 3 ) {
                    cpyTest = Properties.Settings.Default.Contents13;
                }
                else if ( BtnNumber == 4 ) {
                    cpyTest = Properties.Settings.Default.Contents14;
                }
                else if ( BtnNumber == 5 ) {
                    cpyTest = Properties.Settings.Default.Contents15;
                }
                else if ( BtnNumber == 6 ) {
                    cpyTest = Properties.Settings.Default.Contents16;
                }
                else if ( BtnNumber == 7 ) {
                    cpyTest = Properties.Settings.Default.Contents17;
                }
                else if ( BtnNumber == 8 ) {
                    cpyTest = Properties.Settings.Default.Contents18;
                }
                else if ( BtnNumber == 9 ) {
                    cpyTest = Properties.Settings.Default.Contents19;
                }
                else if ( BtnNumber == 10 ) {
                    cpyTest = Properties.Settings.Default.Contents20;
                }
            }

            // タブ 3
            else if ( Properties.Settings.Default.TabNumber == 3 ) {
                // 押されたボタンで登録済みテキストを抽出
                if ( BtnNumber == 1 ) {
                    cpyTest = Properties.Settings.Default.Contents21;
                }
                else if ( BtnNumber == 2 ) {
                    cpyTest = Properties.Settings.Default.Contents22;
                }
                else if ( BtnNumber == 3 ) {
                    cpyTest = Properties.Settings.Default.Contents23;
                }
                else if ( BtnNumber == 4 ) {
                    cpyTest = Properties.Settings.Default.Contents24;
                }
                else if ( BtnNumber == 5 ) {
                    cpyTest = Properties.Settings.Default.Contents25;
                }
                else if ( BtnNumber == 6 ) {
                    cpyTest = Properties.Settings.Default.Contents26;
                }
                else if ( BtnNumber == 7 ) {
                    cpyTest = Properties.Settings.Default.Contents27;
                }
                else if ( BtnNumber == 8 ) {
                    cpyTest = Properties.Settings.Default.Contents28;
                }
                else if ( BtnNumber == 9 ) {
                    cpyTest = Properties.Settings.Default.Contents29;
                }
                else if ( BtnNumber == 10 ) {
                    cpyTest = Properties.Settings.Default.Contents30;
                }
            }

            // クリップボードにコピー
            Clipboard.SetDataObject( cpyTest );
        }

        /// 選択されたタブの情報を表示する
        private void ContentsTab_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            // 選択されタブの番号を取得
            Properties.Settings.Default.TabNumber = ContentsTab.SelectedIndex + 1;

            // 設定済みタイトルを読み込み
            LoadDisplay();
        }

        /// <summary>
        /// アプリ終了時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void Window_Closing( object sender, System.ComponentModel.CancelEventArgs e )
        {
            // Settingsを保存
            Properties.Settings.Default.Save();
        }

        private void CpyBtn1_Click( object sender, RoutedEventArgs e )
        {
            CpyCommon( 1 );
        }

        private void CpyBtn2_Click( object sender, RoutedEventArgs e )
        {
            CpyCommon( 2 );
        }

        private void CpyBtn3_Click( object sender, RoutedEventArgs e )
        {
            CpyCommon( 3 );
        }

        private void CpyBtn4_Click( object sender, RoutedEventArgs e )
        {
            CpyCommon( 4 );
        }

        private void CpyBtn5_Click( object sender, RoutedEventArgs e )
        {
            CpyCommon( 5 );
        }

        private void CpyBtn6_Click( object sender, RoutedEventArgs e )
        {
            CpyCommon( 6 );
        }

        private void CpyBtn7_Click( object sender, RoutedEventArgs e )
        {
            CpyCommon( 7 );
        }

        private void CpyBtn8_Click( object sender, RoutedEventArgs e )
        {
            CpyCommon( 8 );
        }

        private void CpyBtn9_Click( object sender, RoutedEventArgs e )
        {
            CpyCommon( 9 );
        }

        private void CpyBtn10_Click( object sender, RoutedEventArgs e )
        {
            CpyCommon( 10 );
        }


        /// <summary>
        /// クリップボードコピーの共通処理
        /// </summary>
        /// <param name="BtnNumber">上から何番目(1～10)</param>
        private void CpyCommon( int BtnNumber )
        {
            // 押されたボタン番号を保持
            Properties.Settings.Default.ButtonNumber = BtnNumber;

            // クリップボードにコピー
            CopyClipBoardContents();
        }

        /// <summary>
        /// 編集画面を開く共通処理
        /// </summary>
        private void OpenEditWindow()
        {
            // 編集画面を開く
            var win = new Window1();
            win.ShowDialog();

            // 設定済みタイトルを読み込み
            LoadDisplay();
        }

        /// <summary>
        /// Keyup時の共通処理
        /// </summary>
        /// <param name="e">Keyイベント</param>
        /// <param name="BtnNumber">上から何番目(1～10)</param>
        private void CommonKeyup( KeyEventArgs e, int BtnNumber )
        {
            // 押されたボタン番号を保持
            Properties.Settings.Default.ButtonNumber = BtnNumber;

            if ( e.Key == Key.Space ) {
                // Space Kye 
                // クリップボードにコピー
                CpyCommon( BtnNumber );
            }
            else if ( e.Key == Key.E ) {
                // e Key
                // 編集画面を開く
                OpenEditWindow();
            }
        }

        private void CpyBtn1_KeyUp( object sender, KeyEventArgs e )
        {
            CommonKeyup( e, 1 );
        }

        private void CpyBtn2_KeyUp( object sender, KeyEventArgs e )
        {
            CommonKeyup( e, 2 );
        }

        private void CpyBtn3_KeyUp( object sender, KeyEventArgs e )
        {
            CommonKeyup( e, 3 );
        }

        private void CpyBtn4_KeyUp( object sender, KeyEventArgs e )
        {
            CommonKeyup( e, 4 );
        }

        private void CpyBtn5_KeyUp( object sender, KeyEventArgs e )
        {
            CommonKeyup( e, 5 );
        }

        private void CpyBtn6_KeyUp( object sender, KeyEventArgs e )
        {
            CommonKeyup( e, 6 );
        }

        private void CpyBtn7_KeyUp( object sender, KeyEventArgs e )
        {
            CommonKeyup( e, 7 );
        }

        private void CpyBtn8_KeyUp( object sender, KeyEventArgs e )
        {
            CommonKeyup( e, 8 );
        }
        private void CpyBtn9_KeyUp( object sender, KeyEventArgs e )
        {
            CommonKeyup( e, 9 );
        }

        private void CpyBtn10_KeyUp( object sender, KeyEventArgs e )
        {
            CommonKeyup( e, 10 );
        }
    }
}