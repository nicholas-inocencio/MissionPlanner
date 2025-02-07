﻿using MissionPlanner.Utilities;
using System.Collections.Generic;

namespace MissionPlanner.Grid
{
    public struct GridData
    {
        public List<PointLatLngAlt> poly;
        //simple
        public string camera;
        public decimal alt;
        public decimal angle;
        public bool camdir;
        public decimal speed;
        public bool usespeed;
        public bool autotakeoff;
        public bool autotakeoff_RTL;

        public decimal splitmission;

        public bool internals;
        public bool footprints;
        public bool advanced;

        //options
        public decimal dist;
        public decimal overshoot1;
        public decimal overshoot2;
        public decimal leadin;
        public decimal leadin2;
        public string startfrom;
        public decimal overlap;
        public decimal sidelap;
        public decimal spacing;
        public bool crossgrid;
        public bool spiral;
        // Copter Settings
        public decimal copter_delay;
        public bool copter_headinghold_chk;
        public decimal copter_headinghold;
        public bool copter_spline;
        // plane settings
        public bool alternateLanes;
        public decimal minlaneseparation;
        // spiral settings
        public decimal clockwiseLaps;
        public bool matchPerimeter;

        // camera config
        public bool trigdist;
        public bool digicam;
        public bool repeatservo;

        public bool breaktrigdist;

        public decimal repeatservo_no;
        public decimal repeatservo_pwm;
        public decimal repeatservo_cycle;

        // do set servo
        public decimal setservo_no;
        public decimal setservo_low;
        public decimal setservo_high;


    }
}