﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

using RooStatsSim.DB;
using RooStatsSim.DB.Table;
using RooStatsSim.Equation.Job;
using RooStatsSim.Skills;
using RooStatsSim.UI.Status;
using RooStatsSim.UI.Manager;
using RooStatsSim.UI.ACK;
using RooStatsSim.User;
using RooStatsSim.UI.StackBuff;

namespace RooStatsSim
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        public static DBlist _roo_db;
        DBManager _db_manager;
        StatusWindow _status = new StatusWindow();
        ProgramInfo _info = new ProgramInfo();
        StackBuff _stacK_buff = new StackBuff();

        public MainWindow()
        {
            //Version Check

            InitializeComponent();

            _roo_db = new DBlist();
            DBSerizator.ReadDB(ref _roo_db);
            _user_data = UserData.GetInstance;



            job_UI_setting((int)(JOB_LIST.LOAD_KNIGHT));

            //DB생성, Window open 등

            _status.Show();
            
        }

        #region UI Variable Define
        readonly Dictionary<ELEMENT_TYPE, string> element_dict = new Dictionary<ELEMENT_TYPE, string>()
        {
            {ELEMENT_TYPE.NORMAL, "무" },
            {ELEMENT_TYPE.WIND, "풍" },
            {ELEMENT_TYPE.EARTH, "지" },
            {ELEMENT_TYPE.FIRE, "화" },
            {ELEMENT_TYPE.WATER, "수" },
            {ELEMENT_TYPE.POISON, "독" },
            {ELEMENT_TYPE.HOLY, "성" },
            {ELEMENT_TYPE.DARK, "암" },
            {ELEMENT_TYPE.ASTRAL, "염" },
            {ELEMENT_TYPE.UNDEAD, "불사" },
        };


        ItemAbility ability;
        //Status status;
        UserData _user_data;
        MonsterDB mobDB;
        AdvantageTable advantage_table;
        JobSelect job_selection = new JobSelect();
        int job_select = (int)(JOB_LIST.LOAD_KNIGHT);
        double element_ratio;
        double size_panelty;
        bool[] BuffList;
        #endregion

        #region UI Setting
        public bool IsNumeric(string source)
        {
            Regex regex = new Regex("[^0-9.-]+");
            return !regex.IsMatch(source);
        }
        private void NurmericCheckFunc(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsNumeric(e.Text);
        }

        private void TxtboxSelectAll(object sender, RoutedEventArgs e)
        {
            Dispatcher.CurrentDispatcher.BeginInvoke(
                DispatcherPriority.ContextIdle,
                new Action(
                    delegate
                    {
                        (sender as TextBox).SelectAll();
                    }
                )
            );
        }
        private void job_UI_setting(int param_job_select)
        {
            List<SkillInfo> skillNames = job_selection.GetSkillCnt(job_select);
            BuffList = new bool[skillNames.Count];

            if (SkillListBox != null)
                SkillListBox.ItemsSource = new SkillAdd(skillNames);
        }

        private void job_sel_Click(object sender, RoutedEventArgs e)
        {
            RadioButton source = e.Source as RadioButton;
            job_select = Convert.ToInt32(source.Tag);
            
            job_selection.JobSelectNum = (JOB_LIST)job_select;
            job_UI_setting(job_select);   
        }
        #endregion


        private void ATK_ReverseClick(object sender, RoutedEventArgs e)
        {
            //InputUIData();

            //txt_atk_equip.Text = Convert.ToString(job_selection.GetReverseATK(Convert.ToInt32(txt_sATK.Text)));
        }
        private void CalcSim_Click(object sender, RoutedEventArgs e)
        {
            //InputUIData();

            //double skill_damage = (Convert.ToInt32(txt_skill_percent.Text) + Convert.ToInt32(txt_skill_add_percent.Text)) * 0.01;
            //int calcATK_min = Convert.ToInt32(Math.Floor(job_selection.GetMinATK() * skill_damage));
            //int calcATK_max = Convert.ToInt32(Math.Floor(job_selection.GetMaxATK() * skill_damage));

            //retCalc.Text = Convert.ToString(calcATK_min) + " ~ " + Convert.ToString(calcATK_max);
            //txt_sATK.Text = Convert.ToString(job_selection.GetWinATK());
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            BuffList[Convert.ToInt32(((e.Source as CheckBox).Tag))] = (bool)((e.Source as CheckBox).IsChecked);

            MessageBox.Show(Convert.ToString((e.Source as CheckBox).IsChecked));
        }

        private void Status_window_Click(object sender, RoutedEventArgs e)
        {
            if (_status.IsVisible)
                _status.Hide();
            else
                _status.Show();
        }

        private void DBManager_window_Click(object sender, RoutedEventArgs e)
        {
            if (_db_manager == null)
                _db_manager = new DBManager();
            else
                _db_manager.Show();
        }

        private void Info_window_Click(object sender, RoutedEventArgs e)
        {
            if (_info.IsVisible)
                _info.Hide();
            else
                _info.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _status.Close();
            _info.Close();
            if ( _db_manager != null)
                _db_manager.Close();
        }

        private void StackBuff_window_Click(object sender, RoutedEventArgs e)
        {
            if (_stacK_buff.IsVisible)
                _stacK_buff.Hide();
            else
                _stacK_buff.Show();
        }

        private void Skill_window_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Equip_window_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
