﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RooStatsSim.User
{
    enum LEVEL_ENUM : int
    {
        BASE = 0,
        BASE_POINT,
        JOB,
        JOB_POINT,
    }
    enum STATUS_ENUM : int
    {
        STR = 0,
        AGI,
        VIT,
        INT,
        DEX,
        LUK
    }

    // User data singleton design pattern
    public sealed class UserData
    {
        private UserData() { }
        private static UserData _instance = null;
        public static UserData GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserData();
                return _instance;
            }
        }

        public Level Level = new Level();
        public Status Status = new Status();
    }

    public class Level : List<ABILITTY>
    {
        public Level()
        {
            Add(new ABILITTY());  //BASE
            Add(new ABILITTY());
            Add(new ABILITTY());  //JOB
            Add(new ABILITTY());
        }
    }

    public class Status : List<ABILITTY>
    {
        public Status()
        {
            Add(new ABILITTY());  //STR
            Add(new ABILITTY());
            Add(new ABILITTY());
            Add(new ABILITTY());
            Add(new ABILITTY());
            Add(new ABILITTY());  //LUK
        }
    }

    public class ABILITTY
    {
        public int Point;
        public int AddPoint;
        public ABILITTY() { Point = 1; AddPoint = 0; }
    }
}
