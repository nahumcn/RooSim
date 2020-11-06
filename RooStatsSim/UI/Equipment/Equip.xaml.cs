﻿using RooStatsSim.DB;
using RooStatsSim.User;
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

namespace RooStatsSim.UI.Equipment
{
    /// <summary>
    /// Equip.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Equip : Window
    {
        UserData _user_data;
        ItemListFilter EquipItemList;
        ItemListFilter CardItemList;
        ItemListFilter EnchantList;

        EQUIP_TYPE_ENUM now_selected_equip_type;
        public Equip()
        {
            _user_data = UserData.GetInstance;

            InitializeComponent();
        }


        private TreeViewItem GetEquipTypeItem(EQUIP_TYPE_ENUM equip_type)
        {
            switch (equip_type)
            {
                case EQUIP_TYPE_ENUM.HEAD_TOP:
                    return head_top_tree;
                case EQUIP_TYPE_ENUM.HEAD_MID:
                    return head_mid_tree;
                case EQUIP_TYPE_ENUM.HEAD_BOT:
                    return head_bot_tree;
                case EQUIP_TYPE_ENUM.WEAPON:
                    return main_weapon_tree;
                case EQUIP_TYPE_ENUM.SUB_WEAPON:
                    return sub_weapon_tree;
                case EQUIP_TYPE_ENUM.ARMOR:
                    return armor_tree;
                case EQUIP_TYPE_ENUM.CLOAK:
                    return cloak_tree;
                case EQUIP_TYPE_ENUM.SHOES:
                    return shoes_tree;
                case EQUIP_TYPE_ENUM.ACCESSORIES1:
                    return acc1_tree;
                case EQUIP_TYPE_ENUM.ACCESSORIES2:
                    return acc2_tree;
            }
            return null;
        }
        
        private void SelectEquipment_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            now_selected_equip_type = (EQUIP_TYPE_ENUM)Enum.Parse(typeof(EQUIP_TYPE_ENUM), (string)((sender as ContentControl).Tag));
            EquipItemList = new ItemListFilter(ref _user_data, ITEM_TYPE_ENUM.EQUIPMENT, now_selected_equip_type);
            ItemSelector.ItemsSource = EquipItemList;
            ItemSlectorTab.SelectedIndex = 0;
        }

        private void SelectItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EquipId item = ((sender as ContentControl).Content as StackPanel).DataContext as EquipId;

            _user_data.Equip.List[(int)now_selected_equip_type].Equip = MainWindow._roo_db.Equip_db[item.Id];
            GetEquipTypeItem(now_selected_equip_type).Header = item.Name;
            GetEquipTypeItem(now_selected_equip_type).ItemsSource = new EquipList(_user_data.Equip.List[(int)now_selected_equip_type]);

            CardItemList = new ItemListFilter(ref _user_data, ITEM_TYPE_ENUM.CARD, now_selected_equip_type);
            CardSelector.ItemsSource = CardItemList;
            //EnchantList = new ItemListFilter(ref _user_data, ITEM_TYPE_ENUM.ENCHANT, now_selected_equip_type);

            ItemSlectorTab.SelectedIndex = 1;
            _user_data.CalcUserData();
        }

        private void SelectCard_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EquipId item = ((sender as ContentControl).Content as StackPanel).DataContext as EquipId;

            _user_data.Equip.List[(int)now_selected_equip_type].AddCard(MainWindow._roo_db.Card_db[item.Id]);
            GetEquipTypeItem(now_selected_equip_type).ItemsSource = new EquipList(_user_data.Equip.List[(int)now_selected_equip_type]);
            _user_data.CalcUserData();
        }
    }
}
