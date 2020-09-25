﻿using System;
using System.Windows;
using System.Windows.Controls;
using DbManager.DB;
using DbManager.UI;
using System.Collections.Generic;

namespace DbManager
{
    /// <summary>
    /// ItemManager.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ItemManager : Page
    {
        DBlist _DB;
        Dictionary<int, ItemDB> now_DB;
        ItemDB_Binding now_item = new ItemDB_Binding();
        ItemListBox BindingItemList;
        ItemOption_Binding now_option = new ItemOption_Binding();
        testBox BindingItemOptionList;

        public ItemManager(ref DBlist DB)
        {
            _DB = DB;
            InitializeComponent();

            ItemDB test = new ItemDB();
            test.i_option.Add(ITYPE.ATK, 50);
            test.i_option.Add(ITYPE.MATK, 30);
            test.Name = "test1";
            ItemDB test2 = new ItemDB();
            test2.i_option.Add(ITYPE.ATK, 5);
            test2.i_option.Add(ITYPE.MATK, 3);
            test2.Name = "test2";
            test2.Id = 1;
            _DB._equip_db.Add(0, test);
            _DB._equip_db.Add(1, test2);
            
            DataContext = now_item;

            now_DB = SelectedItemType();
            InitializeContents();

            BindingItemList = new ItemListBox(ref now_DB);
            DB_ListBox.ItemsSource = BindingItemList;
            BindingItemOptionList = new testBox(ref now_item.i_option);
            testOption.ItemsSource = BindingItemOptionList;

            SetComboBox();
        }

        void SetComboBox()
        {
            foreach (ITYPE option in Enum.GetValues(typeof(ITYPE)))
            {
                string statusName = Enum.GetName(typeof(ITYPE), option);
                cmb_Ioption.Items.Add(statusName);
            }
            foreach (DTYPE option in Enum.GetValues(typeof(DTYPE)))
            {
                string statusName = Enum.GetName(typeof(DTYPE), option);
                cmb_Doption.Items.Add(statusName);
            }
            foreach (STATUS_EFFECT_TYPE option in Enum.GetValues(typeof(STATUS_EFFECT_TYPE)))
            {
                string statusName = Enum.GetName(typeof(STATUS_EFFECT_TYPE), option);
                cmb_SEoption.Items.Add(statusName);
            }
            foreach (IFTYPE option in Enum.GetValues(typeof(IFTYPE)))
            {
                string statusName = Enum.GetName(typeof(IFTYPE), option);
                cmb_IFoption.Items.Add(statusName);
            }
        }

        void InitializeContents()
        {
            if (now_DB == null)
                now_item.Id = 0;
            else
                now_item.Id = now_DB.Count;

            now_item.Name = "";
            now_item.i_option.Clear();
            now_item.d_option.Clear();
            now_item.if_option.Clear();
            now_item.se_option.Clear();

            now_item.mobtype_inc_option.Clear();
            now_item.size_inc_option.Clear();
            now_item.tribe_inc_option.Clear();
            now_item.element_inc_option.Clear();
            now_item.mobtype_dec_option.Clear();
            now_item.size_dec_option.Clear();
            now_item.tribe_dec_option.Clear();
            now_item.element_dec_option.Clear();
        }

        #region To pass mainwindow
        private bool _isNew = false;
        public bool IsNew
        {
            get { return _isNew; }
            set { _isNew = value; }
        }
        #endregion

        private Dictionary<int, ItemDB> SelectedItemType()
        {
            int selected = cmb_equip_type.SelectedIndex + 1;

            switch (selected)
            {
                case (int)ITEM_TYPE_ENUM.MONSTER_RESEARCH:
                    return _DB._monster_research_db;
                case (int)ITEM_TYPE_ENUM.STICKER:
                    return _DB._stiker_db;
                case (int)ITEM_TYPE_ENUM.DRESS_STYLE:
                    return _DB._dress_style_db;
                case (int)ITEM_TYPE_ENUM.EQUIPMENT:
                    return _DB._equip_db;
                case (int)ITEM_TYPE_ENUM.CARD:
                    return _DB._card_db;
            }

            return null;
        }
        private void New_DB_Click(object sender, RoutedEventArgs e)
        {
            InitializeContents();
            Item_name.Focus();
        }
        private void Add_DB_Click(object sender, RoutedEventArgs e)
        {
            if (string.Compare(Item_name.Text, "") == 0)
                return;

            now_DB[now_item.Id] = new ItemDB(now_item);
            BindingItemList.AddList(new ItemDB(now_item));

            InitializeContents();
            Item_name.Focus();
            _isNew = true;
        }

        private void DB_Type_Click(object sender, RoutedEventArgs e)
        {
            RadioButton a = sender as RadioButton;
        }

        private void DB_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ItemDB_Binding temp = (ItemDB_Binding)DB_ListBox.SelectedItem;
            if (temp != null)
            {
                now_item.ChangeValue(temp);
                BindingItemOptionList = new testBox(ref now_item.i_option);
                testOption.ItemsSource = BindingItemOptionList;
            }
                
        }

        private void cmb_equip_type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedItemType();
        }
    }
}
