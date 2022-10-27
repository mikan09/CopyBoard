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
using System.Windows.Shapes;

namespace CopyBoard
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            LoadProperties();
        }


        /// <summary>
        /// Editウィンドウ表示時に登録済みのタイトルとテキストを読み込み、表示
        /// </summary>
        private void LoadProperties()
        {
            var tabNumber = Properties.Settings.Default.TabNumber;          // 選択されたタブ番号(1～3)
            var BtnNumber = Properties.Settings.Default.ButtonNumber;       // 押されたボタン番号(1～10)
            string dispTitle = "";                                          // 表示タイトル
            string dispContents = "";                                       // 表示テキスト

            // タブ 1
            if ( tabNumber == 1 ) {
                // 押されたボタンで登録済みテキストを抽出
                if ( BtnNumber == 1 ) {
                    dispTitle = Properties.Settings.Default.Title1;
                    dispContents = Properties.Settings.Default.Contents1;
                }
                else if ( BtnNumber == 2 ) {
                    dispTitle = Properties.Settings.Default.Title2;
                    dispContents = Properties.Settings.Default.Contents2;
                }
                else if ( BtnNumber == 3 ) {
                    dispTitle = Properties.Settings.Default.Title3;
                    dispContents = Properties.Settings.Default.Contents3;
                }
                else if ( BtnNumber == 4 ) {
                    dispTitle = Properties.Settings.Default.Title4;
                    dispContents = Properties.Settings.Default.Contents4;
                }
                else if ( BtnNumber == 5 ) {
                    dispTitle = Properties.Settings.Default.Title5;
                    dispContents = Properties.Settings.Default.Contents5;
                }
                else if ( BtnNumber == 6 ) {
                    dispTitle = Properties.Settings.Default.Title6;
                    dispContents = Properties.Settings.Default.Contents6;
                }
                else if ( BtnNumber == 7 ) {
                    dispTitle = Properties.Settings.Default.Title7;
                    dispContents = Properties.Settings.Default.Contents7;
                }
                else if ( BtnNumber == 8 ) {
                    dispTitle = Properties.Settings.Default.Title8;
                    dispContents = Properties.Settings.Default.Contents8;
                }
                else if ( BtnNumber == 9 ) {
                    dispTitle = Properties.Settings.Default.Title9;
                    dispContents = Properties.Settings.Default.Contents9;
                }
                else if ( BtnNumber == 10 ) {
                    dispTitle = Properties.Settings.Default.Title10;
                    dispContents = Properties.Settings.Default.Contents10;
                }
            }

            // タブ 2
            else if ( tabNumber == 2 ) {
                // 押されたボタンで登録済みテキストを抽出
                if ( BtnNumber == 1 ) {
                    dispTitle = Properties.Settings.Default.Title11;
                    dispContents = Properties.Settings.Default.Contents11;
                }
                else if ( BtnNumber == 2 ) {
                    dispTitle = Properties.Settings.Default.Title12;
                    dispContents = Properties.Settings.Default.Contents12;
                }
                else if ( BtnNumber == 3 ) {
                    dispTitle = Properties.Settings.Default.Title13;
                    dispContents = Properties.Settings.Default.Contents13;
                }
                else if ( BtnNumber == 4 ) {
                    dispTitle = Properties.Settings.Default.Title14;
                    dispContents = Properties.Settings.Default.Contents14;
                }
                else if ( BtnNumber == 5 ) {
                    dispTitle = Properties.Settings.Default.Title15;
                    dispContents = Properties.Settings.Default.Contents15;
                }
                else if ( BtnNumber == 6 ) {
                    dispTitle = Properties.Settings.Default.Title16;
                    dispContents = Properties.Settings.Default.Contents16;
                }
                else if ( BtnNumber == 7 ) {
                    dispTitle = Properties.Settings.Default.Title17;
                    dispContents = Properties.Settings.Default.Contents17;
                }
                else if ( BtnNumber == 8 ) {
                    dispTitle = Properties.Settings.Default.Title18;
                    dispContents = Properties.Settings.Default.Contents18;
                }
                else if ( BtnNumber == 9 ) {
                    dispTitle = Properties.Settings.Default.Title19;
                    dispContents = Properties.Settings.Default.Contents19;
                }
                else if ( BtnNumber == 10 ) {
                    dispTitle = Properties.Settings.Default.Title20;
                    dispContents = Properties.Settings.Default.Contents20;
                }
            }

            // タブ 3
            else if ( tabNumber == 3 ) {
                // 押されたボタンで登録済みテキストを抽出
                if ( BtnNumber == 1 ) {
                    dispTitle = Properties.Settings.Default.Title21;
                    dispContents = Properties.Settings.Default.Contents21;
                }
                else if ( BtnNumber == 2 ) {
                    dispTitle = Properties.Settings.Default.Title22;
                    dispContents = Properties.Settings.Default.Contents22;
                }
                else if ( BtnNumber == 3 ) {
                    dispTitle = Properties.Settings.Default.Title23;
                    dispContents = Properties.Settings.Default.Contents23;
                }
                else if ( BtnNumber == 4 ) {
                    dispTitle = Properties.Settings.Default.Title24;
                    dispContents = Properties.Settings.Default.Contents24;
                }
                else if ( BtnNumber == 5 ) {
                    dispTitle = Properties.Settings.Default.Title25;
                    dispContents = Properties.Settings.Default.Contents25;
                }
                else if ( BtnNumber == 6 ) {
                    dispTitle = Properties.Settings.Default.Title26;
                    dispContents = Properties.Settings.Default.Contents26;
                }
                else if ( BtnNumber == 7 ) {
                    dispTitle = Properties.Settings.Default.Title27;
                    dispContents = Properties.Settings.Default.Contents27;
                }
                else if ( BtnNumber == 8 ) {
                    dispTitle = Properties.Settings.Default.Title28;
                    dispContents = Properties.Settings.Default.Contents28;
                }
                else if ( BtnNumber == 9 ) {
                    dispTitle = Properties.Settings.Default.Title29;
                    dispContents = Properties.Settings.Default.Contents29;
                }
                else if ( BtnNumber == 10 ) {
                    dispTitle = Properties.Settings.Default.Title30;
                    dispContents = Properties.Settings.Default.Contents30;
                }
            }

            //テキストボックスに表示
            EditTitle.Text = dispTitle;
            EditContents.Text = dispContents;
        }

        private void SaveBtn_Click( object sender, RoutedEventArgs e )
        {
            var tabNumber = Properties.Settings.Default.TabNumber;          // 選択されたタブ番号(1～3)
            var BtnNumber = Properties.Settings.Default.ButtonNumber;       // 押されたボタン番号(1～10)

            // タブ 1
            if ( tabNumber == 1 ) {

                if ( BtnNumber == 1 ) {
                    Properties.Settings.Default.Title1 = EditTitle.Text;
                    Properties.Settings.Default.Contents1 = EditContents.Text;
                }
                else if ( BtnNumber == 2 ) {
                    Properties.Settings.Default.Title2 = EditTitle.Text;
                    Properties.Settings.Default.Contents2 = EditContents.Text;
                }
                else if ( BtnNumber == 3 ) {
                    Properties.Settings.Default.Title3 = EditTitle.Text;
                    Properties.Settings.Default.Contents3 = EditContents.Text;
                }
                else if ( BtnNumber == 4 ) {
                    Properties.Settings.Default.Title4 = EditTitle.Text;
                    Properties.Settings.Default.Contents4 = EditContents.Text;
                }
                else if ( BtnNumber == 5 ) {
                    Properties.Settings.Default.Title5 = EditTitle.Text;
                    Properties.Settings.Default.Contents5 = EditContents.Text;
                }
                else if ( BtnNumber == 6 ) {
                    Properties.Settings.Default.Title6 = EditTitle.Text;
                    Properties.Settings.Default.Contents6 = EditContents.Text;
                }
                else if ( BtnNumber == 7 ) {
                    Properties.Settings.Default.Title7 = EditTitle.Text;
                    Properties.Settings.Default.Contents7 = EditContents.Text;
                }
                else if ( BtnNumber == 8 ) {
                    Properties.Settings.Default.Title8 = EditTitle.Text;
                    Properties.Settings.Default.Contents8 = EditContents.Text;
                }
                else if ( BtnNumber == 9 ) {
                    Properties.Settings.Default.Title9 = EditTitle.Text;
                    Properties.Settings.Default.Contents9 = EditContents.Text;
                }
                else if ( BtnNumber == 10 ) {
                    Properties.Settings.Default.Title10 = EditTitle.Text;
                    Properties.Settings.Default.Contents10 = EditContents.Text;
                }
            }

            // タブ 2
            else if ( tabNumber == 2 ) {
                // 押されたボタンで登録済みテキストを抽出
                if ( BtnNumber == 1 ) {
                    Properties.Settings.Default.Title11 = EditTitle.Text;
                    Properties.Settings.Default.Contents11 = EditContents.Text;
                }
                else if ( BtnNumber == 2 ) {
                    Properties.Settings.Default.Title12 = EditTitle.Text;
                    Properties.Settings.Default.Contents12 = EditContents.Text;
                }
                else if ( BtnNumber == 3 ) {
                    Properties.Settings.Default.Title13 = EditTitle.Text;
                    Properties.Settings.Default.Contents13 = EditContents.Text;
                }
                else if ( BtnNumber == 4 ) {
                    Properties.Settings.Default.Title14 = EditTitle.Text;
                    Properties.Settings.Default.Contents14 = EditContents.Text;
                }
                else if ( BtnNumber == 5 ) {
                    Properties.Settings.Default.Title15 = EditTitle.Text;
                    Properties.Settings.Default.Contents15 = EditContents.Text;
                }
                else if ( BtnNumber == 6 ) {
                    Properties.Settings.Default.Title16 = EditTitle.Text;
                    Properties.Settings.Default.Contents16 = EditContents.Text;
                }
                else if ( BtnNumber == 7 ) {
                    Properties.Settings.Default.Title17 = EditTitle.Text;
                    Properties.Settings.Default.Contents17 = EditContents.Text;
                }
                else if ( BtnNumber == 8 ) {
                    Properties.Settings.Default.Title18 = EditTitle.Text;
                    Properties.Settings.Default.Contents18 = EditContents.Text;
                }
                else if ( BtnNumber == 9 ) {
                    Properties.Settings.Default.Title19 = EditTitle.Text;
                    Properties.Settings.Default.Contents19 = EditContents.Text;
                }
                else if ( BtnNumber == 10 ) {
                    Properties.Settings.Default.Title20 = EditTitle.Text;
                    Properties.Settings.Default.Contents20 = EditContents.Text;
                }
            }

            // タブ 3
            else if ( tabNumber == 3 ) {
                // 押されたボタンで登録済みテキストを抽出
                if ( BtnNumber == 1 ) {
                    Properties.Settings.Default.Title21 = EditTitle.Text;
                    Properties.Settings.Default.Contents21 = EditContents.Text;
                }
                else if ( BtnNumber == 2 ) {
                    Properties.Settings.Default.Title22 = EditTitle.Text;
                    Properties.Settings.Default.Contents22 = EditContents.Text;
                }
                else if ( BtnNumber == 3 ) {
                    Properties.Settings.Default.Title23 = EditTitle.Text;
                    Properties.Settings.Default.Contents23 = EditContents.Text;
                }
                else if ( BtnNumber == 4 ) {
                    Properties.Settings.Default.Title24 = EditTitle.Text;
                    Properties.Settings.Default.Contents24 = EditContents.Text;
                }
                else if ( BtnNumber == 5 ) {
                    Properties.Settings.Default.Title25 = EditTitle.Text;
                    Properties.Settings.Default.Contents25 = EditContents.Text;
                }
                else if ( BtnNumber == 6 ) {
                    Properties.Settings.Default.Title26 = EditTitle.Text;
                    Properties.Settings.Default.Contents26 = EditContents.Text;
                }
                else if ( BtnNumber == 7 ) {
                    Properties.Settings.Default.Title27 = EditTitle.Text;
                    Properties.Settings.Default.Contents27 = EditContents.Text;
                }
                else if ( BtnNumber == 8 ) {
                    Properties.Settings.Default.Title28 = EditTitle.Text;
                    Properties.Settings.Default.Contents28 = EditContents.Text;
                }
                else if ( BtnNumber == 9 ) {
                    Properties.Settings.Default.Title29 = EditTitle.Text;
                    Properties.Settings.Default.Contents29 = EditContents.Text;
                }
                else if ( BtnNumber == 10 ) {
                    Properties.Settings.Default.Title30 = EditTitle.Text;
                    Properties.Settings.Default.Contents30 = EditContents.Text;
                }
            }

            // ウィンドウを閉じる
            Close();
        }

        private void CancelBtn_Click( object sender, RoutedEventArgs e )
        {
            // ウィンドウを閉じる
            Close();
        }
    }
}
