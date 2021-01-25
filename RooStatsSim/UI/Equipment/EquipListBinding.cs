﻿using RooStatsSim;
using RooStatsSim.DB;
using RooStatsSim.DB.Table;
using RooStatsSim.UI.Equipment;
using RooStatsSim.UI.Menu;
using RooStatsSim.User;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using RooStatsSim.DB.Enchant;

namespace RooStatsSim.UI.Equipment
{
    class EquipList : ObservableCollection<EquipTreeViewBinding>
    {
        public string Name { get; set; }

        public EquipList()
        {
            EquipTreeViewBinding CardTree;
            Add(CardTree = new EquipTreeViewBinding("카드"));
            EquipTreeViewBinding EnchantTree;
            Add(EnchantTree = new EquipTreeViewBinding("인챈트"));
        }
        public EquipList(EQUIP.EquipItem equip_item)
        {
            Name = equip_item.EquipInfo.Name;
            EquipTreeViewBinding CardTree = new EquipTreeViewBinding("카드");
            Add(CardTree);
            foreach (int card_id in equip_item.Card)
            {
                ItemDB card = MainWindow._roo_db.Card_db[card_id];
                CardTree.SubList.Add(new EquipTreeViewBinding(card));
            }
            EquipTreeViewBinding EnchantTree = new EquipTreeViewBinding("인챈트");
            Add(EnchantTree);
            foreach (EQUIP.EquipItem.Enchant_param enchant_id in equip_item.Enchant)
            {
                ItemDB Enchant = new ItemDB
                {
                    Name = Equip._enchant_db.Dic[enchant_id.name].NAME_KOR + " " + Convert.ToString(enchant_id.point)
                };
                if (Equip._enchant_db.Dic[enchant_id.name].IsAdvanced)
                {
                    Enchant += Equip._enchant_db.Dic[enchant_id.name].OPTION[enchant_id.point];
                }
                else
                    Enchant += (Equip._enchant_db.Dic[enchant_id.name].OPTION[0] * enchant_id.point);

                EnchantTree.SubList.Add(new EquipTreeViewBinding(Enchant));
            }
        }
    }
}


class ItemListFilter : ObservableCollection<EquipId>
{
    public ItemListFilter(ref UserData user, ITEM_TYPE_ENUM itemtype, EQUIP_TYPE_ENUM equiptype)
    {
        foreach(KeyValuePair<int, ItemDB> itemPair in GetItemList(itemtype, equiptype))
        {
            if ( ( (itemPair.Value)._wear_job_limit.Count != 0 ) &&
                (!(itemPair.Value)._wear_job_limit.Contains(user.Job)) )
                continue;
            if ((itemPair.Value).Equip_type != equiptype)
                continue;
            Add(new EquipId()
            {
                Id = itemPair.Key,
                Name = itemPair.Value.Name,
                ImageRoot = itemPair.Value.ImageName
            });
        }
    }
    public ItemListFilter(ITEM_TYPE_ENUM itemtype, EQUIP_TYPE_ENUM equiptype)
    {
        if (itemtype != ITEM_TYPE_ENUM.ENCHANT)
            return;
        foreach (KeyValuePair<string, EnchantInfo> itemPair in Equip._enchant_db.Dic)
        {
            Add(new EquipId()
            {
                Name_Eng = itemPair.Value.NAME,
                Name = itemPair.Value.NAME_KOR
            });
        }
    }

    Dictionary<int, ItemDB> GetItemList(ITEM_TYPE_ENUM itemtype, EQUIP_TYPE_ENUM equiptype = EQUIP_TYPE_ENUM.HEAD_TOP)
    {
        switch(itemtype)
        {
            case ITEM_TYPE_ENUM.EQUIPMENT:
                return MainWindow._roo_db.Equip_db[(int)EnumBaseTable_Kor.EQUIP_TYPE_TO_DB_ENUM[equiptype]];
            case ITEM_TYPE_ENUM.CARD:
                return MainWindow._roo_db.Card_db;
            case ITEM_TYPE_ENUM.ENCHANT:
                return MainWindow._roo_db.Enchant_db;
            case ITEM_TYPE_ENUM.GEAR:
                return MainWindow._roo_db.Gear_db;
        }
        return null;
    }
}