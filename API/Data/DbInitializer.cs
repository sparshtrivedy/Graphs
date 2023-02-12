using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LumberContext context)
        {
            if (context.Lumbers.Any()) return;

            var lumbers = new List<Lumber>
            {
                new Lumber
                {
                Date=new DateTime(2022,10,06),
                Open=441.4,
                High=468.6,
                Low=441.3,
                Close=454.7,
                AdjClose=454.7,
                Volume=207,
                },
                new Lumber
                {
                Date=new DateTime(2022,10,05),
                Open=434,
                High=437.6,
                Low=421.2,
                Close=436.6,
                AdjClose=436.6,
                Volume=207,
                },
                new Lumber
                {
                Date=new DateTime(2022,10,04),
                Open=436,
                High=448,
                Low=426.2,
                Close=434,
                AdjClose=434,
                Volume=298,
                },
                new Lumber
                {
                Date=new DateTime(2022,10,03),
                Open=437.7,
                High=442.3,
                Low=421.3,
                Close=426,
                AdjClose=426,
                Volume=404,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,30),
                Open=418.7,
                High=429.7,
                Low=412.5,
                Close=422.5,
                AdjClose=422.5,
                Volume=370,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,29),
                Open=431.9,
                High=432.4,
                Low=402.8,
                Close=410.9,
                AdjClose=410.9,
                Volume=593,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,28),
                Open=443.7,
                High=451,
                Low=420.1,
                Close=432.8,
                AdjClose=432.8,
                Volume=281,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,27),
                Open=426.1,
                High=448.5,
                Low=422,
                Close=429.3,
                AdjClose=429.3,
                Volume=367,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,26),
                Open=432.7,
                High=443.9,
                Low=410.7,
                Close=410.8,
                AdjClose=410.8,
                Volume=446,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,23),
                Open=451.8,
                High=455,
                Low=430.1,
                Close=435,
                AdjClose=435,
                Volume=552,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,23),
                Open=489.9,
                High=489.9,
                Low=460,
                Close=460.2,
                AdjClose=460.2,
                Volume=362,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,21),
                Open=521.7,
                High=522.2,
                Low=492.1,
                Close=496,
                AdjClose=496,
                Volume=295,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,20),
                Open=503.6,
                High=527,
                Low=502,
                Close=515.7,
                AdjClose=515.7,
                Volume=334,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,19),
                Open=479.1,
                High=486.4,
                Low=461.4,
                Close=482.2,
                AdjClose=482.2,
                Volume=173,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,16),
                Open=488.9,
                High=488.9,
                Low=469.5,
                Close=481.2,
                AdjClose=481.2,
                Volume=242,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,15),
                Open=499,
                High=499,
                Low=482,
                Close=483.5,
                AdjClose=483.5,
                Volume=335,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,14),
                Open=549.7,
                High=549.7,
                Low=511,
                Close=511,
                AdjClose=511,
                Volume=40,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,13),
                Open=550,
                High=567,
                Low=548,
                Close=560,
                AdjClose=560,
                Volume=194,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,12),
                Open=514.7,
                High=554.9,
                Low=511,
                Close=554.9,
                AdjClose=554.9,
                Volume=76,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,09),
                Open=511.9,
                High=519.9,
                Low=504.7,
                Close=509,
                AdjClose=509,
                Volume=54,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,08),
                Open=500.9,
                High=514.9,
                Low=499,
                Close=513.4,
                AdjClose=513.4,
                Volume=101,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,07),
                Open=490,
                High=509,
                Low=485.1,
                Close=505.5,
                AdjClose=505.5,
                Volume=85,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,06),
                Open=492.2,
                High=496.3,
                Low=485,
                Close=490,
                AdjClose=490,
                Volume=83,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,05),
                Open=0,
                High=0,
                Low=0,
                Close=0,
                AdjClose=0,
                Volume=0,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,02),
                Open=492.4,
                High=499,
                Low=484,
                Close=493.8,
                AdjClose=493.8,
                Volume=85,
                },
                new Lumber
                {
                Date=new DateTime(2022,09,01),
                Open=514.4,
                High=517.7,
                Low=489,
                Close=499.7,
                AdjClose=499.7,
                Volume=134,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,31),
                Open=500.2,
                High=516.5,
                Low=500.2,
                Close=509,
                AdjClose=509,
                Volume=193,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,30),
                Open=503.7,
                High=514,
                Low=495.2,
                Close=504.8,
                AdjClose=504.8,
                Volume=265,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,29),
                Open=523.4,
                High=524.5,
                Low=509.8,
                Close=516,
                AdjClose=516,
                Volume=154,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,26),
                Open=520,
                High=549,
                Low=511.8,
                Close=523.6,
                AdjClose=523.6,
                Volume=157,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,25),
                Open=495.4,
                High=529.9,
                Low=495.2,
                Close=520,
                AdjClose=520,
                Volume=182,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,24),
                Open=522,
                High=529.4,
                Low=490,
                Close=495.4,
                AdjClose=495.4,
                Volume=313,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,23),
                Open=504.6,
                High=530,
                Low=503.2,
                Close=516,
                AdjClose=516,
                Volume=246,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,22),
                Open=514.3,
                High=516.6,
                Low=500,
                Close=500,
                AdjClose=500,
                Volume=280,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,19),
                Open=558.9,
                High=558.9,
                Low=516.6,
                Close=520,
                AdjClose=520,
                Volume=392,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,18),
                Open=595.9,
                High=596.2,
                Low=560,
                Close=565.5,
                AdjClose=565.5,
                Volume=251,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,17),
                Open=592.5,
                High=609.7,
                Low=588,
                Close=598.4,
                AdjClose=598.4,
                Volume=259,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,16),
                Open=581.8,
                High=598.3,
                Low=577.8,
                Close=596.1,
                AdjClose=596.1,
                Volume=213,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,15),
                Open=590.1,
                High=604.7,
                Low=576.6,
                Close=588.9,
                AdjClose=588.9,
                Volume=218,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,12),
                Open=602.7,
                High=611.4,
                Low=583.8,
                Close=588.7,
                AdjClose=588.7,
                Volume=219,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,11),
                Open=621.7,
                High=635.6,
                Low=577.1,
                Close=595.6,
                AdjClose=595.6,
                Volume=647,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,10),
                Open=573,
                High=601.8,
                Low=573,
                Close=601.8,
                AdjClose=601.8,
                Volume=487,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,09),
                Open=528.5,
                High=565,
                Low=528.4,
                Close=552.8,
                AdjClose=552.8,
                Volume=376,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,08),
                Open=489,
                High=528.2,
                Low=483.2,
                Close=519.3,
                AdjClose=519.3,
                Volume=398,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,05),
                Open=501.1,
                High=518.5,
                Low=473.6,
                Close=479.2,
                AdjClose=479.2,
                Volume=282,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,04),
                Open=491,
                High=502,
                Low=470.6,
                Close=500,
                AdjClose=500,
                Volume=372,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,03),
                Open=521,
                High=521.3,
                Low=483,
                Close=493.2,
                AdjClose=493.2,
                Volume=362,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,02),
                Open=541,
                High=541,
                Low=520.4,
                Close=521.2,
                AdjClose=521.2,
                Volume=227,
                },
                new Lumber
                {
                Date=new DateTime(2022,08,01),
                Open=529.8,
                High=545.2,
                Low=514.1,
                Close=534.2,
                AdjClose=534.2,
                Volume=351,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,29),
                Open=534.6,
                High=535.1,
                Low=523.1,
                Close=527.1,
                AdjClose=527.1,
                Volume=307,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,28),
                Open=555.2,
                High=559.2,
                Low=531,
                Close=536.7,
                AdjClose=536.7,
                Volume=371,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,27),
                Open=549,
                High=561.6,
                Low=542,
                Close=555.2,
                AdjClose=555.2,
                Volume=201,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,26),
                Open=565.3,
                High=574.5,
                Low=531.2,
                Close=556.6,
                AdjClose=556.6,
                Volume=374,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,25),
                Open=583,
                High=583,
                Low=554.3,
                Close=572.2,
                AdjClose=572.2,
                Volume=280,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,22),
                Open=617,
                High=617,
                Low=576.2,
                Close=585.3,
                AdjClose=585.3,
                Volume=256,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,21),
                Open=623.8,
                High=630,
                Low=599.4,
                Close=623.2,
                AdjClose=623.2,
                Volume=243,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,20),
                Open=648.1,
                High=648.5,
                Low=623.1,
                Close=631.6,
                AdjClose=631.6,
                Volume=127,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,19),
                Open=642.1,
                High=648.7,
                Low=628.2,
                Close=646.3,
                AdjClose=646.3,
                Volume=147,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,18),
                Open=655,
                High=659.9,
                Low=626.2,
                Close=640.8,
                AdjClose=640.8,
                Volume=176,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,15),
                Open=655,
                High=682,
                Low=655,
                Close=682,
                AdjClose=682,
                Volume=187,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,14),
                Open=640,
                High=645.7,
                Low=635,
                Close=640,
                AdjClose=640,
                Volume=50,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,13),
                Open=650,
                High=660,
                Low=643.5,
                Close=652,
                AdjClose=652,
                Volume=65,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,12),
                Open=656.6,
                High=656.6,
                Low=643,
                Close=645,
                AdjClose=645,
                Volume=33,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,11),
                Open=660,
                High=670,
                Low=640.3,
                Close=661.1,
                AdjClose=661.1,
                Volume=34,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,08),
                Open=666.1,
                High=677.5,
                Low=650,
                Close=659,
                AdjClose=659,
                Volume=34,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,07),
                Open=640,
                High=672,
                Low=640,
                Close=668,
                AdjClose=668,
                Volume=59,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,06),
                Open=650,
                High=650,
                Low=610.3,
                Close=635,
                AdjClose=635,
                Volume=80,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,05),
                Open=654,
                High=654,
                Low=626.6,
                Close=640,
                AdjClose=640,
                Volume=63,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,04),
                Open=0,
                High=0,
                Low=0,
                Close=0,
                AdjClose=0,
                Volume=0,
                },
                new Lumber
                {
                Date=new DateTime(2022,07,01),
                Open=660,
                High=682.6,
                Low=650,
                Close=657,
                AdjClose=657,
                Volume=118,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,30),
                Open=635,
                High=670,
                Low=629.1,
                Close=663.3,
                AdjClose=663.3,
                Volume=212,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,29),
                Open=628,
                High=642.5,
                Low=624.2,
                Close=633.6,
                AdjClose=633.6,
                Volume=195,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,28),
                Open=602.8,
                High=630.5,
                Low=602.5,
                Close=617.6,
                AdjClose=617.6,
                Volume=164,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,27),
                Open=603.1,
                High=617.5,
                Low=603.1,
                Close=611,
                AdjClose=611,
                Volume=94,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,24),
                Open=622,
                High=625,
                Low=608.5,
                Close=608.6,
                AdjClose=608.6,
                Volume=145,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,23),
                Open=610.7,
                High=623,
                Low=591.1,
                Close=617,
                AdjClose=617,
                Volume=201,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,22),
                Open=628.8,
                High=630.1,
                Low=603.3,
                Close=611.6,
                AdjClose=611.6,
                Volume=285,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,21),
                Open=591.8,
                High=630.1,
                Low=591.2,
                Close=610.1,
                AdjClose=610.1,
                Volume=422,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,20),
                Open=0,
                High=0,
                Low=0,
                Close=0,
                AdjClose=0,
                Volume=0,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,17),
                Open=574.5,
                High=591.8,
                Low=566.6,
                Close=581.1,
                AdjClose=581.1,
                Volume=250,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,16),
                Open=560.1,
                High=578.9,
                Low=556,
                Close=569,
                AdjClose=569,
                Volume=215,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,15),
                Open=546.7,
                High=568.4,
                Low=530.8,
                Close=563.5,
                AdjClose=563.5,
                Volume=383,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,14),
                Open=519.3,
                High=552.7,
                Low=518.5,
                Close=538,
                AdjClose=538,
                Volume=217,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,13),
                Open=549.6,
                High=554.6,
                Low=517,
                Close=528,
                AdjClose=528,
                Volume=191,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,10),
                Open=555.8,
                High=564.5,
                Low=550,
                Close=555.9,
                AdjClose=555.9,
                Volume=155,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,09),
                Open=570,
                High=582,
                Low=558.1,
                Close=568.3,
                AdjClose=568.3,
                Volume=177,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,08),
                Open=591.4,
                High=592,
                Low=566.1,
                Close=573,
                AdjClose=573,
                Volume=267,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,07),
                Open=601.1,
                High=610.9,
                Low=585.4,
                Close=596.8,
                AdjClose=596.8,
                Volume=211,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,06),
                Open=634.7,
                High=634.7,
                Low=589,
                Close=600.3,
                AdjClose=600.3,
                Volume=188,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,03),
                Open=605,
                High=630,
                Low=595.6,
                Close=623.3,
                AdjClose=623.3,
                Volume=296,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,02),
                Open=600.8,
                High=624,
                Low=594,
                Close=598.5,
                AdjClose=598.5,
                Volume=340,
                },
                new Lumber
                {
                Date=new DateTime(2022,06,01),
                Open=644.8,
                High=644.8,
                Low=604.5,
                Close=608.6,
                AdjClose=608.6,
                Volume=420,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,31),
                Open=698.8,
                High=699.2,
                Low=649.8,
                Close=653.5,
                AdjClose=653.5,
                Volume=270,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,30),
                Open=0,
                High=0,
                Low=0,
                Close=0,
                AdjClose=0,
                Volume=0,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,27),
                Open=698.7,
                High=715,
                Low=670,
                Close=695.1,
                AdjClose=695.1,
                Volume=263,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,26),
                Open=670.9,
                High=690,
                Low=659.1,
                Close=683,
                AdjClose=683,
                Volume=238,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,25),
                Open=659.5,
                High=665,
                Low=647.8,
                Close=651.8,
                AdjClose=651.8,
                Volume=166,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,24),
                Open=644.5,
                High=672,
                Low=636.3,
                Close=660,
                AdjClose=660,
                Volume=153,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,23),
                Open=670.1,
                High=675,
                Low=640.6,
                Close=651.9,
                AdjClose=651.9,
                Volume=193,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,20),
                Open=675,
                High=690.5,
                Low=655,
                Close=667.3,
                AdjClose=667.3,
                Volume=153,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,19),
                Open=728.5,
                High=728.5,
                Low=690.5,
                Close=690.5,
                AdjClose=690.5,
                Volume=243,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,18),
                Open=778.9,
                High=778.9,
                Low=739,
                Close=739.5,
                AdjClose=739.5,
                Volume=196,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,17),
                Open=804.5,
                High=812.2,
                Low=775.5,
                Close=788,
                AdjClose=788,
                Volume=133,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,16),
                Open=772.2,
                High=792,
                Low=752.4,
                Close=787,
                AdjClose=787,
                Volume=170,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,13),
                Open=985,
                High=985,
                Low=920,
                Close=920,
                AdjClose=920,
                Volume=211,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,12),
                Open=1024.90,
                High=1024.90,
                Low=1000.00,
                Close=1004.00,
                AdjClose=1004.00,
                Volume=43,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,11),
                Open=1011.00,
                High=1025.00,
                Low=1007.50,
                Close=1007.50,
                AdjClose=1007.50,
                Volume=99,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,10),
                Open=1008.00,
                High=1025.00,
                Low=1008.00,
                Close=1022.00,
                AdjClose=1022.00,
                Volume=68,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,09),
                Open=1000.10,
                High=1015.00,
                Low=975,
                Close=1009.00,
                AdjClose=1009.00,
                Volume=89,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,06),
                Open=990,
                High=1005.00,
                Low=985,
                Close=1000.10,
                AdjClose=1000.10,
                Volume=147,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,05),
                Open=1010.00,
                High=1033.40,
                Low=993.8,
                Close=1020.00,
                AdjClose=1020.00,
                Volume=131,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,04),
                Open=1021.60,
                High=1025.50,
                Low=980,
                Close=1010.00,
                AdjClose=1010.00,
                Volume=144,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,03),
                Open=1036.00,
                High=1045.00,
                Low=1022.00,
                Close=1039.50,
                AdjClose=1039.50,
                Volume=103,
                },
                new Lumber
                {
                Date=new DateTime(2022,05,02),
                Open=1033.90,
                High=1054.00,
                Low=1025.00,
                Close=1034.70,
                AdjClose=1034.70,
                Volume=91,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,29),
                Open=1025.00,
                High=1047.40,
                Low=1023.00,
                Close=1039.70,
                AdjClose=1039.70,
                Volume=181,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,28),
                Open=1044.70,
                High=1045.90,
                Low=1020.00,
                Close=1044.80,
                AdjClose=1044.80,
                Volume=81,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,27),
                Open=1036.30,
                High=1062.80,
                Low=1026.10,
                Close=1052.40,
                AdjClose=1052.40,
                Volume=190,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,26),
                Open=1009.00,
                High=1049.40,
                Low=1008.00,
                Close=1034.80,
                AdjClose=1034.80,
                Volume=175,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,25),
                Open=980.2,
                High=1017.30,
                Low=945.6,
                Close=1015.00,
                AdjClose=1015.00,
                Volume=149,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,22),
                Open=1021.10,
                High=1029.90,
                Low=1000.00,
                Close=1002.60,
                AdjClose=1002.60,
                Volume=183,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,21),
                Open=1005.10,
                High=1041.40,
                Low=989.8,
                Close=1025.00,
                AdjClose=1025.00,
                Volume=202,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,20),
                Open=960,
                High=995.6,
                Low=945.7,
                Close=995.6,
                AdjClose=995.6,
                Volume=249,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,19),
                Open=945.4,
                High=951.5,
                Low=920.3,
                Close=938.6,
                AdjClose=938.6,
                Volume=156,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,18),
                Open=887.9,
                High=924.2,
                Low=871.7,
                Close=923.9,
                AdjClose=923.9,
                Volume=187,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,14),
                Open=880.3,
                High=904.8,
                Low=862.1,
                Close=889,
                AdjClose=889,
                Volume=160,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,13),
                Open=876.6,
                High=902.5,
                Low=844.8,
                Close=883.7,
                AdjClose=883.7,
                Volume=177,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,12),
                Open=862,
                High=890,
                Low=829.3,
                Close=874.2,
                AdjClose=874.2,
                Volume=248,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,11),
                Open=971.1,
                High=992.6,
                Low=870,
                Close=886.3,
                AdjClose=886.3,
                Volume=229,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,08),
                Open=891,
                High=949.9,
                Low=890,
                Close=949.9,
                AdjClose=949.9,
                Volume=242,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,07),
                Open=864.9,
                High=896.7,
                Low=846.7,
                Close=892.9,
                AdjClose=892.9,
                Volume=349,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,06),
                Open=925,
                High=925,
                Low=881.4,
                Close=881.4,
                AdjClose=881.4,
                Volume=174,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,05),
                Open=973.9,
                High=977.8,
                Low=935,
                Close=938.4,
                AdjClose=938.4,
                Volume=129,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,04),
                Open=965,
                High=993.3,
                Low=945.2,
                Close=966.5,
                AdjClose=966.5,
                Volume=121,
                },
                new Lumber
                {
                Date=new DateTime(2022,04,01),
                Open=955.2,
                High=984.8,
                Low=929.5,
                Close=964.9,
                AdjClose=964.9,
                Volume=320,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,31),
                Open=1012.70,
                High=1043.00,
                Low=945,
                Close=965.3,
                AdjClose=965.3,
                Volume=285,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,30),
                Open=1075.00,
                High=1084.90,
                Low=997,
                Close=1001.70,
                AdjClose=1001.70,
                Volume=184,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,29),
                Open=993.8,
                High=1055.00,
                Low=993.8,
                Close=1054.00,
                AdjClose=1054.00,
                Volume=158,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,28),
                Open=986,
                High=1001.00,
                Low=977.8,
                Close=999.5,
                AdjClose=999.5,
                Volume=71,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,25),
                Open=1016.20,
                High=1022.00,
                Low=974.8,
                Close=1008.00,
                AdjClose=1008.00,
                Volume=250,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,24),
                Open=1022.40,
                High=1059.90,
                Low=1003.40,
                Close=1020.00,
                AdjClose=1020.00,
                Volume=239,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,23),
                Open=1085.20,
                High=1089.80,
                Low=1054.30,
                Close=1054.30,
                AdjClose=1054.30,
                Volume=110,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,22),
                Open=1100.00,
                High=1130.00,
                Low=1042.30,
                Close=1111.30,
                AdjClose=1111.30,
                Volume=322,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,21),
                Open=1201.30,
                High=1229.00,
                Low=1128.30,
                Close=1128.30,
                AdjClose=1128.30,
                Volume=127,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,18),
                Open=1223.40,
                High=1246.00,
                Low=1173.50,
                Close=1185.30,
                AdjClose=1185.30,
                Volume=181,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,17),
                Open=1152.00,
                High=1207.00,
                Low=1150.00,
                Close=1207.00,
                AdjClose=1207.00,
                Volume=236,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,16),
                Open=1201.00,
                High=1201.00,
                Low=1125.00,
                Close=1150.00,
                AdjClose=1150.00,
                Volume=236,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,15),
                Open=1420.00,
                High=1420.00,
                Low=1420.00,
                Close=1420.00,
                AdjClose=1420.00,
                Volume=213,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,14),
                Open=1348.00,
                High=1430.00,
                Low=1348.00,
                Close=1410.00,
                AdjClose=1410.00,
                Volume=33,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,11),
                Open=1370.00,
                High=1420.00,
                Low=1310.00,
                Close=1410.00,
                AdjClose=1410.00,
                Volume=23,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,10),
                Open=1355.00,
                High=1382.00,
                Low=1344.00,
                Close=1348.50,
                AdjClose=1348.50,
                Volume=39,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,09),
                Open=1350.60,
                High=1377.10,
                Low=1335.90,
                Close=1350.50,
                AdjClose=1350.50,
                Volume=42,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,08),
                Open=1411.00,
                High=1425.00,
                Low=1385.00,
                Close=1386.40,
                AdjClose=1386.40,
                Volume=55,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,07),
                Open=1441.00,
                High=1460.00,
                Low=1441.00,
                Close=1456.10,
                AdjClose=1456.10,
                Volume=50,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,04),
                Open=1477.40,
                High=1477.40,
                Low=1396.00,
                Close=1441.00,
                AdjClose=1441.00,
                Volume=79,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,03),
                Open=1439.50,
                High=1464.40,
                Low=1438.00,
                Close=1464.40,
                AdjClose=1464.40,
                Volume=138,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,02),
                Open=1395.00,
                High=1433.40,
                Low=1395.00,
                Close=1418.70,
                AdjClose=1418.70,
                Volume=128,
                },
                new Lumber
                {
                Date=new DateTime(2022,03,01),
                Open=1349.00,
                High=1379.50,
                Low=1349.00,
                Close=1373.00,
                AdjClose=1373.00,
                Volume=150,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,28),
                Open=1310.00,
                High=1341.00,
                Low=1309.50,
                Close=1336.70,
                AdjClose=1336.70,
                Volume=136,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,25),
                Open=1319.90,
                High=1331.10,
                Low=1295.00,
                Close=1312.40,
                AdjClose=1312.40,
                Volume=215,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,24),
                Open=1277.70,
                High=1314.50,
                Low=1260.00,
                Close=1312.00,
                AdjClose=1312.00,
                Volume=203,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,23),
                Open=1252.10,
                High=1277.00,
                Low=1242.70,
                Close=1277.00,
                AdjClose=1277.00,
                Volume=201,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,22),
                Open=1265.00,
                High=1293.80,
                Low=1241.60,
                Close=1247.00,
                AdjClose=1247.00,
                Volume=268,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,18),
                Open=1275.00,
                High=1319.90,
                Low=1261.00,
                Close=1270.00,
                AdjClose=1270.00,
                Volume=249,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,17),
                Open=1301.00,
                High=1316.10,
                Low=1290.40,
                Close=1290.40,
                AdjClose=1290.40,
                Volume=285,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,16),
                Open=1313.70,
                High=1336.00,
                Low=1285.00,
                Close=1320.40,
                AdjClose=1320.40,
                Volume=432,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,15),
                Open=1283.50,
                High=1291.00,
                Low=1279.80,
                Close=1291.00,
                AdjClose=1291.00,
                Volume=134,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,14),
                Open=1207.90,
                High=1246.00,
                Low=1202.00,
                Close=1246.00,
                AdjClose=1246.00,
                Volume=221,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,11),
                Open=1294.90,
                High=1294.90,
                Low=1204.90,
                Close=1216.00,
                AdjClose=1216.00,
                Volume=695,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,10),
                Open=1249.90,
                High=1249.90,
                Low=1249.90,
                Close=1249.90,
                AdjClose=1249.90,
                Volume=129,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,09),
                Open=1204.90,
                High=1204.90,
                Low=1204.90,
                Close=1204.90,
                AdjClose=1204.90,
                Volume=143,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,08),
                Open=1159.90,
                High=1159.90,
                Low=1159.90,
                Close=1159.90,
                AdjClose=1159.90,
                Volume=69,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,07),
                Open=1114.90,
                High=1114.90,
                Low=1114.90,
                Close=1114.90,
                AdjClose=1114.90,
                Volume=95,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,04),
                Open=1069.90,
                High=1069.90,
                Low=1069.90,
                Close=1069.90,
                AdjClose=1069.90,
                Volume=57,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,03),
                Open=1019.00,
                High=1024.90,
                Low=1017.50,
                Close=1024.90,
                AdjClose=1024.90,
                Volume=149,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,02),
                Open=911.9,
                High=979.9,
                Low=900.9,
                Close=979.9,
                AdjClose=979.9,
                Volume=281,
                },
                new Lumber
                {
                Date=new DateTime(2022,02,01),
                Open=962.8,
                High=962.9,
                Low=934.9,
                Close=934.9,
                AdjClose=934.9,
                Volume=297,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,31),
                Open=1049.90,
                High=1053.70,
                Low=979.9,
                Close=979.9,
                AdjClose=979.9,
                Volume=244,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,28),
                Open=1001.10,
                High=1024.90,
                Low=984.1,
                Close=1024.90,
                AdjClose=1024.90,
                Volume=301,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,27),
                Open=963.7,
                High=1035.80,
                Low=963.7,
                Close=994.9,
                AdjClose=994.9,
                Volume=999,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,26),
                Open=1008.70,
                High=1008.70,
                Low=1008.70,
                Close=1008.70,
                AdjClose=1008.70,
                Volume=79,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,25),
                Open=1053.70,
                High=1053.70,
                Low=1053.70,
                Close=1053.70,
                AdjClose=1053.70,
                Volume=49,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,24),
                Open=1098.70,
                High=1098.70,
                Low=1098.70,
                Close=1098.70,
                AdjClose=1098.70,
                Volume=85,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,21),
                Open=1179.80,
                High=1179.80,
                Low=1143.70,
                Close=1143.70,
                AdjClose=1143.70,
                Volume=245,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,20),
                Open=1208.20,
                High=1233.70,
                Low=1188.70,
                Close=1188.70,
                AdjClose=1188.70,
                Volume=307,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,19),
                Open=1295.30,
                High=1311.50,
                Low=1233.70,
                Close=1233.70,
                AdjClose=1233.70,
                Volume=364,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,18),
                Open=1279.70,
                High=1286.00,
                Low=1278.70,
                Close=1278.70,
                AdjClose=1278.70,
                Volume=280,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,14),
                Open=1270.00,
                High=1289.00,
                Low=1210.00,
                Close=1237.10,
                AdjClose=1237.10,
                Volume=242,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,13),
                Open=1244.70,
                High=1244.70,
                Low=1217.00,
                Close=1229.10,
                AdjClose=1229.10,
                Volume=84,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,12),
                Open=1219.20,
                High=1230.00,
                Low=1200.00,
                Close=1212.00,
                AdjClose=1212.00,
                Volume=88,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,11),
                Open=1161.00,
                High=1205.00,
                Low=1155.00,
                Close=1204.90,
                AdjClose=1204.90,
                Volume=62,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,10),
                Open=1196.80,
                High=1196.80,
                Low=1158.00,
                Close=1160.00,
                AdjClose=1160.00,
                Volume=39,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,07),
                Open=1199.00,
                High=1199.00,
                Low=1174.00,
                Close=1188.00,
                AdjClose=1188.00,
                Volume=41,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,06),
                Open=1175.00,
                High=1191.40,
                Low=1154.00,
                Close=1191.40,
                AdjClose=1191.40,
                Volume=65,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,05),
                Open=1139.70,
                High=1162.80,
                Low=1139.70,
                Close=1159.50,
                AdjClose=1159.50,
                Volume=77,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,04),
                Open=1107.20,
                High=1141.00,
                Low=1107.10,
                Close=1133.00,
                AdjClose=1133.00,
                Volume=92,
                },
                new Lumber
                {
                Date=new DateTime(2022,01,03),
                Open=1131.00,
                High=1131.00,
                Low=1109.10,
                Close=1112.00,
                AdjClose=1112.00,
                Volume=99,
                }
            };

            foreach (var lumber in lumbers)
            {
                context.Lumbers.Add(lumber);
            }

            context.SaveChanges();
        }
    }
}