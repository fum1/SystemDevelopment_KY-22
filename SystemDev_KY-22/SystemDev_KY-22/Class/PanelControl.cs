/*
*******************************************************************************
グループ名　：KY-22
システム名称　：販売管理システム
モジュール名称：PanelControl
機能概要　　　：各種メニューのpanelに関連する共通の操作をまとめるクラス
改訂履歴　　　：2019/10/25 新規 T.Iwamoto
　　　　　　　　
Copyright(C) 2019 KY-22. All Rights Reserved.
********************************************************************************
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDev_KY_22
{
    class PanelControl
    {
        /*
        -------------------------------------------------------------------------------
        機能概要　：メニューで選択したボタンにselectpanelの高さとTopを合わせる
        引数　　　：(Button)button 押されたボタン
        　　　　　：(Panel)panel 各メニューに設置しているselectpanel
        戻り値　　：Void なし
        備考　　　：
        -------------------------------------------------------------------------------
        */
        public void Set(Button button,Panel panel)
        {
            panel.Visible = true;
            panel.Height = button.Height;
            panel.Top = button.Top;           
        }


        /*
        -------------------------------------------------------------------------------
        機能概要　：引数で設定したUserControlを表示しDockStyleをfillにし
                    他のUserControlを非表示にする
        引数　　　：(UserControl[])userControls 各メニューで設置したUserControlを格納した配列
　　　　　        ：(UserControl)selectControl 表示したいUserControl
        戻り値　　：Void なし
        備考　　　：
        -------------------------------------------------------------------------------
        */
        public void Chenge(UserControl[] userControls,UserControl selectControl)
        {
            for(int i = 0; i < userControls.Length; i++)
            {
                if(userControls[i] == selectControl)
                {
                    userControls[i].Visible = true;
                    userControls[i].Dock = DockStyle.Fill;
                }
                else
                {
                    userControls[i].Visible = false;
                }
            }
        }
    }
}
