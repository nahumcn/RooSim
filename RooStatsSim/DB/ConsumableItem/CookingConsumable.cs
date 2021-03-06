﻿using System;
using System.Collections.Generic;
using RooStatsSim.DB.Table;

namespace RooStatsSim.DB.ConsumableItem
{
    public enum BASIC_COOKING_CONSUMABLE_ITEM
    {
        RICE_BALLS,
        STEAMED_CRAB,
        CAVIAR,
        NOODLE,
        SCALLOP,
        CRAB_MEAT,
        SHRIMP,
        TUNNY,
        CLAM_PORRIDGE,
    }
    public enum ADVANCED_COOKING_CONSUMABLE_ITEM
    {
        GIANT_SSAMBAP,
        SHRIMP_SUSHI,
        SCALLOP_SUSHI,
        CRAB_MEAT_SUSHI,
        TUNA_SUSHI,
        CAVIAR_SUSHI,
        SEAFOOD_FRIED_RICE,
        SHRIMP_BIBIM_NOODLES,
        SEAFOOD_FRIED_NOODLES,
        CAVIAR_BIBIM_NOODLES,
        SCALLOP_SEAFOOD_NOODLES,
        KING_SCALLOPS,
        SHRIMP_CRAB_MEAT,
        SHRIMP_TUNA_BIBIMBAP,
        SHRIMP_CAVIAR,
        SHRIMP_PORRIDGE,
        SEAFOOD_DISHES,
        FRIED_SPECIAL_SCALLOPS,
        SCALLOP_SEAFOOD_PORRIDGE,
        GRILLED_SEAFOOD_SKEWERS,
        CAVIAR_MEAT_ROLLS,
        CLAM_CRAB_MEAT_PORRIDGE,
        SPECIAL_GRILLED_TUNA_SKEWERS,
        SHELLFISH_TUNA_PORRIDGE,
        FINEST_SHELLFISH_PORRIDGE,
    }
    public class CookingConsumable
    {
        public static Dictionary<string, string> BASIC_COOKING_CONSUMABLE_ITEM_KOR = new Dictionary<string, string>()
        {
            {Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM),BASIC_COOKING_CONSUMABLE_ITEM.RICE_BALLS), "주먹밥" },
            {Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM),BASIC_COOKING_CONSUMABLE_ITEM.STEAMED_CRAB), "게 집게발 찜" },
            {Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM),BASIC_COOKING_CONSUMABLE_ITEM.CAVIAR), "캐비어" },
            {Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM),BASIC_COOKING_CONSUMABLE_ITEM.NOODLE), "깔끔한 국수" },
            {Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM),BASIC_COOKING_CONSUMABLE_ITEM.SCALLOP), "가리비볶음" },
            {Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM),BASIC_COOKING_CONSUMABLE_ITEM.CRAB_MEAT), "게맛살" },
            {Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM),BASIC_COOKING_CONSUMABLE_ITEM.SHRIMP), "쉬림프소스" },
            {Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM),BASIC_COOKING_CONSUMABLE_ITEM.TUNNY), "다랑어꼬치구이" },
            {Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM),BASIC_COOKING_CONSUMABLE_ITEM.CLAM_PORRIDGE), "조개죽" },
        };
        public static Dictionary<string, string> ADVANCED_COOKING_CONSUMABLE_ITEM_KOR = new Dictionary<string, string>()
        {
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.GIANT_SSAMBAP), "거대 쌈밥 요리" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_SUSHI), "새우 초밥" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SCALLOP_SUSHI), "가리비 초밥" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.CRAB_MEAT_SUSHI), "게살 초밥" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.TUNA_SUSHI), "다랑어 초밥" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.CAVIAR_SUSHI), "캐비어 초밥" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SEAFOOD_FRIED_RICE), "해물 볶음밥" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_BIBIM_NOODLES), "쉬림프 비빔면" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SEAFOOD_FRIED_NOODLES), "해물 볶음면" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.CAVIAR_BIBIM_NOODLES), "캐비어 비빔면" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SCALLOP_SEAFOOD_NOODLES), "가리비 해물면" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.KING_SCALLOPS), "왕 가리비" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_CRAB_MEAT), "쉬림프 게맛살" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_TUNA_BIBIMBAP), "새우 다랑어 비빔밥" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_CAVIAR), "쉬림프 캐비어" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_PORRIDGE), "쉬림프 조개죽" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SEAFOOD_DISHES), "해산물 요리" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.FRIED_SPECIAL_SCALLOPS), "특제 가리비 볶음" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SCALLOP_SEAFOOD_PORRIDGE), "가리비 해물죽" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.GRILLED_SEAFOOD_SKEWERS), "해물 꼬치 구이" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.CAVIAR_MEAT_ROLLS), "캐비어 고기 말이" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.CLAM_CRAB_MEAT_PORRIDGE), "조개 게살 죽" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SPECIAL_GRILLED_TUNA_SKEWERS), "특제 다랑어 꼬치 구이" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.SHELLFISH_TUNA_PORRIDGE), "조개 다랑어죽" },
            {Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM),ADVANCED_COOKING_CONSUMABLE_ITEM.FINEST_SHELLFISH_PORRIDGE), "최고급 조개죽" },
        };
        public Dictionary<string, ConsumableBuffInfo> Buff { get; set; }

        public CookingConsumable()
        {
            int max_lvl = 3;
            Buff = new Dictionary<string, ConsumableBuffInfo>();
            foreach (string name in Enum.GetNames(typeof(BASIC_COOKING_CONSUMABLE_ITEM)))
            {
                Buff.Add(name, new ConsumableBuffInfo(name, BASIC_COOKING_CONSUMABLE_ITEM_KOR[name], max_lvl));
                for (int i = 0; i < max_lvl; i++)
                    Buff[name].OPTION.Add(new ItemDB());
            }

            //주먹밥 
            for (int i = 0; i < max_lvl; i++)
                Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.RICE_BALLS)].OPTION[i].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HP)] = (i + 1) * 400;
            //캐비어
            for (int i = 0; i < max_lvl; i++)
            {
                Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.CAVIAR)].OPTION[i].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HIT)] = (i + 1) * 5;
                Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.CAVIAR)].OPTION[i].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.FLEE)] = (i + 1) * 5;
            }
            //깔끔한 국수 근물
            for (int i = 0; i < max_lvl; i++)
                Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.NOODLE)].OPTION[i].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MELEE_PHYSICAL_DAMAGE)] = (i + 1) * 5;
            //가리비볶음 원물
            for (int i = 0; i < max_lvl; i++)
                Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.SCALLOP)].OPTION[i].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.RANGE_PHYSICAL_DAMAGE)] = (i + 1) * 5;
            //게맛살 마뎀
            for (int i = 0; i < max_lvl; i++)
                Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.CRAB_MEAT)].OPTION[i].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MAGICAL_DAMAGE)] = (i + 1) * 5;
            //쉬림프소스 공속
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.SHRIMP)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.ASPD)] = 5;
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.SHRIMP)].OPTION[1].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.ASPD)] = 8;
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.SHRIMP)].OPTION[2].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.ASPD)] = 10;
            //다랑어꼬치구이 크크뎀
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.TUNNY)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.CRI)] = 3;
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.TUNNY)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.CRI_DAMAGE)] = 4;
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.TUNNY)].OPTION[1].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.CRI)] = 5;
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.TUNNY)].OPTION[1].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.CRI_DAMAGE)] = 7;
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.TUNNY)].OPTION[2].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.CRI)] = 8;
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.TUNNY)].OPTION[2].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.CRI_DAMAGE)] = 10;
            //조개죽 캐스팅
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.TUNNY)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.VARIABLE_CASTING)] = 5;
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.TUNNY)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.FIXED_CASTING)] = 1;
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.TUNNY)].OPTION[1].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.VARIABLE_CASTING)] = 8;
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.TUNNY)].OPTION[1].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.FIXED_CASTING)] = 3;
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.TUNNY)].OPTION[2].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.VARIABLE_CASTING)] = 10;
            Buff[Enum.GetName(typeof(BASIC_COOKING_CONSUMABLE_ITEM), BASIC_COOKING_CONSUMABLE_ITEM.TUNNY)].OPTION[2].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.FIXED_CASTING)] = 5;


            max_lvl = 1;
            Buff = new Dictionary<string, ConsumableBuffInfo>();
            foreach (string name in Enum.GetNames(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM)))
            {
                Buff.Add(name, new ConsumableBuffInfo(name, ADVANCED_COOKING_CONSUMABLE_ITEM_KOR[name], max_lvl));
                for (int i = 0; i < max_lvl; i++)
                    Buff[name].OPTION.Add(new ItemDB());
            }

            //거대 쌈밥 요리
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.GIANT_SSAMBAP)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MELEE_PHYSICAL_DAMAGE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.GIANT_SSAMBAP)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HP)] = 500;
            //새우 초밥
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_SUSHI)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.ASPD)] = 10;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_SUSHI)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HP)] = 500;
            //가리비 초밥
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SCALLOP_SUSHI)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MELEE_PHYSICAL_DAMAGE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SCALLOP_SUSHI)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HP)] = 500;
            //게살 초밥
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CRAB_MEAT_SUSHI)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MAGICAL_DAMAGE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CRAB_MEAT_SUSHI)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HP)] = 500;
            //다랑어 초밥
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.TUNA_SUSHI)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.CRI)] = 8;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.TUNA_SUSHI)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.CRI_DAMAGE)] = 10;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.TUNA_SUSHI)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HP)] = 500;
            //캐비어 초밥
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CAVIAR_SUSHI)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HIT)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CAVIAR_SUSHI)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.FLEE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CAVIAR_SUSHI)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HP)] = 500;
            //해물 볶음밥
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SEAFOOD_FRIED_RICE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.VARIABLE_CASTING)] = 10;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SEAFOOD_FRIED_RICE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.FIXED_CASTING)] = 5;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SEAFOOD_FRIED_RICE)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HP)] = 500;
            //쉬림프 비빔면
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_BIBIM_NOODLES)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MELEE_PHYSICAL_DAMAGE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_BIBIM_NOODLES)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.ASPD)] = 5;
            //해물 볶음면
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SEAFOOD_FRIED_NOODLES)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MELEE_PHYSICAL_DAMAGE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SEAFOOD_FRIED_NOODLES)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.CRI_DAMAGE)] = 5;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SEAFOOD_FRIED_NOODLES)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.CRI)] = 4;
            //캐비어 비빔면
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CAVIAR_BIBIM_NOODLES)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MELEE_PHYSICAL_DAMAGE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CAVIAR_BIBIM_NOODLES)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HIT)] = 7;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CAVIAR_BIBIM_NOODLES)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.FLEE)] = 7;
            //가리비 해물면
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SCALLOP_SEAFOOD_NOODLES)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MELEE_PHYSICAL_DAMAGE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SCALLOP_SEAFOOD_NOODLES)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.VARIABLE_CASTING)] = 5;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SCALLOP_SEAFOOD_NOODLES)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.FIXED_CASTING)] = 3;
            //왕가리비
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.KING_SCALLOPS)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.RANGE_PHYSICAL_DAMAGE)] = 7;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.KING_SCALLOPS)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.ASPD)] = 10;
            //쉬림프 게맛살
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_CRAB_MEAT)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MAGICAL_DAMAGE)] = 7;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_CRAB_MEAT)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.ASPD)] = 10;
            //새우 다랑어 비빔밥
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_TUNA_BIBIMBAP)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.CRI)] = 4;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_TUNA_BIBIMBAP)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.CRI_DAMAGE)] = 5;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_TUNA_BIBIMBAP)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.ASPD)] = 10;
            //쉬림프 캐비어
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_CAVIAR)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HIT)] = 7;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_CAVIAR)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.FLEE)] = 7;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_CAVIAR)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.ASPD)] = 10;
            //쉬림프 조개죽
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.ASPD)] = 10;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.VARIABLE_CASTING)] = 5;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHRIMP_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.FIXED_CASTING)] = 3;
            //해산물 요리
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SEAFOOD_DISHES)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.CRI)] = 4;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SEAFOOD_DISHES)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.CRI_DAMAGE)] = 5;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SEAFOOD_DISHES)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.RANGE_PHYSICAL_DAMAGE)] = 15;
            //특제 가리비 볶음
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.FRIED_SPECIAL_SCALLOPS)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HIT)] = 7;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.FRIED_SPECIAL_SCALLOPS)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.FLEE)] = 7;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.FRIED_SPECIAL_SCALLOPS)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.RANGE_PHYSICAL_DAMAGE)] = 15;
            //가리비 해물죽
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SCALLOP_SEAFOOD_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MELEE_PHYSICAL_DAMAGE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SCALLOP_SEAFOOD_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.VARIABLE_CASTING)] = 5;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SCALLOP_SEAFOOD_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.FIXED_CASTING)] = 3;
            //해물 꼬치 구이
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.GRILLED_SEAFOOD_SKEWERS)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MAGICAL_DAMAGE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.GRILLED_SEAFOOD_SKEWERS)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.CRI)] = 4;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.GRILLED_SEAFOOD_SKEWERS)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.CRI_DAMAGE)] = 5;
            //캐비어 고기말이
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CAVIAR_MEAT_ROLLS)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MAGICAL_DAMAGE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CAVIAR_MEAT_ROLLS)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HIT)] = 7;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CAVIAR_MEAT_ROLLS)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.FLEE)] = 7;
            //조개 게살죽
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CLAM_CRAB_MEAT_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.MAGICAL_DAMAGE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CLAM_CRAB_MEAT_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.VARIABLE_CASTING)] = 5;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.CLAM_CRAB_MEAT_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.FIXED_CASTING)] = 3;
            //특제 다랑어 꼬치구이
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SPECIAL_GRILLED_TUNA_SKEWERS)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.CRI)] = 8;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SPECIAL_GRILLED_TUNA_SKEWERS)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.CRI_DAMAGE)] = 10;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SPECIAL_GRILLED_TUNA_SKEWERS)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HIT)] = 7;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SPECIAL_GRILLED_TUNA_SKEWERS)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.FLEE)] = 7;
            //조개 다랑어죽
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHELLFISH_TUNA_PORRIDGE)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.CRI)] = 8;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHELLFISH_TUNA_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.CRI_DAMAGE)] = 10;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHELLFISH_TUNA_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.VARIABLE_CASTING)] = 5;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.SHELLFISH_TUNA_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.FIXED_CASTING)] = 3;
            //최고급 조개죽
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.FINEST_SHELLFISH_PORRIDGE)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.HIT)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.FINEST_SHELLFISH_PORRIDGE)].OPTION[0].Option_ITYPE[Enum.GetName(typeof(ITYPE), ITYPE.FLEE)] = 15;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.FINEST_SHELLFISH_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.VARIABLE_CASTING)] = 5;
            Buff[Enum.GetName(typeof(ADVANCED_COOKING_CONSUMABLE_ITEM), ADVANCED_COOKING_CONSUMABLE_ITEM.FINEST_SHELLFISH_PORRIDGE)].OPTION[0].Option_DTYPE[Enum.GetName(typeof(DTYPE), DTYPE.FIXED_CASTING)] = 3;
        }
    }
}
