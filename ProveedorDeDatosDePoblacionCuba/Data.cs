namespace ProveedorDeDatosDePoblacionCuba
{
    public class Data
    {
        public List<(string, double)> EdadPediatrica()    //0 - 19 anios
        {
            //Pinar del Rio
            (string, double) Sandino = ("Sandino", 1561 + 1720 + 1948 + 2016);
            (string, double) Mantua = ("Mantua", 1170 + 1143 + 1121 + 1360);
            (string, double) MinasDeMataHambre = ("Minas De Matahambre", 1544 + 1607 + 1593 + 1837);
            (string, double) Viniales = ("Viñales", 1600 + 1668 + 1485 + 1714);
            (string, double) LaPalma = ("La Palma", 1619 + 1701 + 1837 + 2040);
            (string, double) LosPalacios = ("Los Palacios", 1706 + 1923 + 1962 + 2183);
            (string, double) ConsolacionDelSur = ("Consolación del Sur", 4221 + 4610 + 4814 + 4972);
            (string, double) PinarDelRio = ("Pinar del Río", 9989 + 11094 + 9672 + 10628);
            (string, double) SanLuis_PR = ("San Luis", 1582 + 1633 + 1607 + 1938);
            (string, double) SanJuanYMartinez = ("San Juan y Martínez", 2119 + 2145 + 2188 + 2540);
            (string, double) Guane = ("Guane", 1712 + 1888 + 1828 + 2098);

            //Artemisa
            (string, double) BahiaHonda = ("Bahía Honda", 2350 + 2330 + 2357 + 2523);
            (string, double) Mariel = ("Mariel", 2293 + 2521 + 2559 + 2584);
            (string, double) Guanajay = ("Guanajay", 1275 + 1724 + 1392 + 1518);
            (string, double) Caimito = ("Caimito", 2302 + 2595 + 2464 + 2250);
            (string, double) Bauta = ("Bauta", 2687 + 2966 + 2684 + 2807);
            (string, double) SanAntonioDeLosBanios = ("San Antonio de los Baños", 2583 + 2887 + 2647 + 2663);
            (string, double) GuiradeMelena = ("Güira de Melena", 2265 + 2331 + 2182 + 2278);
            (string, double) Alquizar = ("Alquízar", 2154 + 2351 + 1908 + 1924);
            (string, double) Artemisa = ("Artemisa", 4462 + 4905 + 4417 + 4766);
            (string, double) Candelaria = ("Candelaria", 1198 + 1295 + 1191 + 1274);
            (string, double) SanCristobal = ("San Cristóbal", 3646 + 4020 + 3858 + 4271);

            //La Habana
            (string, double) Playa = ("Playa", 6761 + 7428 + 7519 + 8619);
            (string, double) PlazadelaRevolución = ("Plaza de la Revolución", 4292 + 4879 + 4995 + 6052);
            (string, double) CentroHabana = ("Centro Habana", 5641 + 5936 + 5689 + 6292);
            (string, double) HabanaVieja = ("Habana Vieja", 3603 + 3564 + 3806 + 3820);
            (string, double) Regla = ("Regla", 2056 + 2402 + 2370 + 2373);
            (string, double) HabanadelEste = ("Habana del Este", 7354 + 8367 + 8320 + 8755);
            (string, double) Guanabacoa = ("Guanabacoa", 6684 + 7350 + 6942 + 6774);
            (string, double) SanMigueldelPadron = ("San Miguel del Padron", 8676 + 9609 + 8665 + 9007);
            (string, double) DiezdeOctubre = ("Diez de Octubre", 8545 + 9541 + 9192 + 10098);
            (string, double) Cerro = ("Cerro", 5541 + 6171 + 5688 + 5977);
            (string, double) Marianao = ("Marianao", 6092 + 6609 + 6677 + 6942);
            (string, double) LaLisa = ("La Lisa", 7590 + 8235 + 7595 + 8310);
            (string, double) Boyeros = ("Boyeros", 11036 + 11138 + 10024 + 10907);
            (string, double) ArroyoNaranjo = ("ArroyoNaranjo", 11531 + 12308 + 10679 + 10915);
            (string, double) Cotorro = ("Cotorro", 4328 + 5066 + 4337 + 4372);

            //Mayabeque
            (string, double) Bejucal = ("Bejucal", 1398 + 1479 + 1532 + 1513);
            (string, double) SanJosédelasLajas = ("San José de las Lajas", 4593 + 5149 + 4650 + 4664);
            (string, double) Jaruco = ("Jaruco", 1074 + 1280 + 1133 + 1220);
            (string, double) SantaCruzdelNorte = ("Santa Cruz del Norte", 1660 + 1780 + 1678 + 1897);
            (string, double) Madruga = ("Madruga", 1177 + 1298 + 1318 + 1297);
            (string, double) NuevaPaz = ("Nueva Paz", 1086 + 1192 + 1211 + 1102);
            (string, double) SanNicolás = ("San Nicolás", 967 + 1061 + 1081 + 1062);
            (string, double) Güines = ("Güines", 3120 + 3391 + 3217 + 3453);
            (string, double) MelenadelSur = ("Melena del Sur", 1077 + 1135 + 1108 + 1117);
            (string, double) Batabanó = ("Batabanó", 1434 + 1603 + 1753 + 1571);
            (string, double) Quivicán = ("Quivicán", 1588 + 1621 + 1634 + 1650);

            //Matanzas
            (string, double) Matanzas = ("Matanzas", 8244 + 7892 + 8426 + 10550);
            (string, double) Cárdenas = ("Cárdenas", 8290 + 9532 + 8505 + 7994);
            (string, double) Martí = ("Martí", 877 + 975 + 1080 + 1070);
            (string, double) Colón = ("Colón", 3134 + 3698 + 3547 + 3578);
            (string, double) Perico = ("Perico", 1255 + 1584 + 1673 + 1612);
            (string, double) Jovellanos = ("Jovellanos", 2981 + 3232 + 3206 + 3028);
            (string, double) PedroBetancourt = ("Pedro Betancourt", 1279 + 1316 + 1425 + 1327);
            (string, double) Limonar = ("Limonar", 1288 + 1461 + 1343 + 1459);
            (string, double) UnióndeReyes = ("Unión de Reyes", 1396 + 1689 + 1559 + 1719);
            (string, double) CiénagadeZapata = ("Ciénaga de Zapata", 661 + 775 + 520 + 579);
            (string, double) JagueyGrande = ("Jaguey Grande", 2596 + 3153 + 2890 + 3141);
            (string, double) Calimete = ("Calimete", 1232 + 1360 + 1420 + 1323);
            (string, double) LosArabos = ("Los Arabos", 1029 + 1214 + 1148 + 1167);

            //Cienfuegos
            (string, double) AguadadePasajeros = ("Aguada de Pasajeros", 777 + 896 + 958 + 981 + 726 + 793 + 883 + 910);
            (string, double) Rodas = ("Rodas", 679 + 850 + 900 + 922 + 675 + 790 + 857 + 833);
            (string, double) Palmira = ("Palmira", 774 + 859 + 876 + 902 + 759 + 784 + 884 + 907);
            (string, double) Lajas = ("Lajas", 505 + 586 + 607 + 624 + 440 + 530 + 553 + 588);
            (string, double) Cruces = ("Cruces", 695 + 770 + 768 + 886 + 620 + 606 + 750 + 784);
            (string, double) Cumanayagua = ("Cumanayagua", 1095 + 1322 + 1323 + 1359 + 1056 + 1251 + 1187 + 1194);
            (string, double) Cienfuegos = ("Cienfuegos", 4377 + 5123 + 4904 + 5068 + 4200 + 4773 + 4666 + 4762);
            (string, double) Abreus = ("Abreus", 758 + 930 + 937 + 958 + 768 + 807 + 878 + 913);

            //Villa Clara
            (string, double) Corralillo = ("Corralillo", 1006 + 1128 + 1185 + 1359);
            (string, double) QuemadodeGüines = ("Quemado de Güines", 779 + 859 + 1000 + 1098);
            (string, double) SagualaGrande = ("Sagua la Grande", 2101 + 2426 + 2430 + 2721);
            (string, double) Encrucijada = ("Encrucijada", 1244 + 1545 + 1568 + 1529);
            (string, double) Camajuaní = ("Camajuaní", 2393 + 2663 + 2609 + 2888);
            (string, double) Caiberién = ("Caiberién", 2115 + 2317 + 2254 + 2090);
            (string, double) Remedios = ("Remedios", 1621 + 1815 + 1898 + 2058);
            (string, double) Placetas = ("Placetas", 2824 + 3167 + 3029 + 3504);
            (string, double) SantaClara = ("Santa Clara", 11919 + 13373 + 12325 + 12278);
            (string, double) Cifuentes = ("Cifuentes", 1009 + 1169 + 1359 + 1305);
            (string, double) SantoDomingo = ("Santo Domingo", 1807 + 2244 + 2341 + 2440);
            (string, double) Ranchuelo = ("Ranchuelo", 2100 + 2525 + 2611 + 2575);
            (string, double) Manicaragua = ("Manicaragua", 2645 + 3121 + 3133 + 3207);

            //Sancti Spiritus
            (string, double) Yaguajay = ("Yaguajay", 2029 + 2473 + 2706 + 2652);
            (string, double) Jatibonico = ("Jatibonico", 1917 + 2382 + 2470 + 2359);
            (string, double) Taguasco = ("Taguasco", 1452 + 1703 + 1872 + 1787);
            (string, double) Cabaiguán = ("Cabaiguán", 2568 + 3081 + 3092 + 3392);
            (string, double) Fomento = ("Fomento", 1244 + 1369 + 1564 + 1613);
            (string, double) Trinidad = ("Trinidad", 3935 + 4531 + 4184 + 4214);
            (string, double) SanctiSpíritus = ("Sancti Spíritus", 6686 + 8351 + 7972 + 7823);
            (string, double) LaSierpe = ("LaSierpe", 935 + 1034 + 907 + 1292);

            //Holguin
            (string, double) Gibara = ("Gibara", 2973 + 3468 + 3697 + 3909);
            (string, double) RafaelFreyre = ("Rafael Freyre", 2486 + 2803 + 3241 + 3287);
            (string, double) Banes = ("Banes", 3143 + 3246 + 4169 + 4236);
            (string, double) Antilla = ("Antilla", 700 + 720 + 776 + 760);
            (string, double) Báguanos = ("Báguanos", 2213 + 2419 + 2991 + 2874);
            (string, double) Holguín = ("Holguín", 17465 + 19776 + 19962 + 20234);
            (string, double) CalixtoGarcía = ("Calixto García", 2357 + 2672 + 3187 + 3160);
            (string, double) Cacocum = ("Cacocum", 1926 + 2016 + 2620 + 2380);
            (string, double) UrbanoNoris = ("Urbano Noris", 1786 + 2103 + 2287 + 2214);
            (string, double) Cueto = ("Cueto", 1422 + 1669 + 1871 + 1826);
            (string, double) Mayarí = ("Mayarí", 3788 + 4546 + 5508 + 5755);
            (string, double) FrankPaís = ("Frank País", 939 + 1016 + 1447 + 1437);
            (string, double) SaguaTánamo = ("Sagua Tánamo", 2245 + 2294 + 2815 + 3169);
            (string, double) Moa = ("Moa", 4327 + 4342 + 4508 + 4451);

            //Camaguey
            (string, double) CarlosManueldeCéspedes = ("Carlos Manuel de Céspedes", 953 + 1195 + 1293 + 1357);
            (string, double) Esmeralda = ("Esmeralda", 1440 + 1583 + 1583 + 1723);
            (string, double) SierradeCubitas = ("Sierra de Cubitas", 827 + 990 + 1045 + 1023);
            (string, double) Minas = ("Minas", 1586 + 1895 + 2009 + 1966);
            (string, double) Nuevitas = ("Nuevitas", 2514 + 2962 + 3401 + 3205);
            (string, double) Guáimaro = ("Guáimaro", 1472 + 1594 + 1746 + 1998);
            (string, double) Sibanicú = ("Sibanicú", 1208 + 1459 + 1673 + 1615);
            (string, double) Camagüey = ("Camagüey", 16450 + 19664 + 17441 + 17770);
            (string, double) Florida = ("Florida", 3039 + 3492 + 3887 + 3648);
            (string, double) Vertientes = ("Vertientes", 2158 + 2866 + 2828 + 2869);
            (string, double) Jimaguayú = ("Jimaguayú", 1020 + 1137 + 1165 + 1065);
            (string, double) Najasa = ("Najasa", 639 + 745 + 883 + 795);
            (string, double) SantaCruzdelSur = ("Santa Cruz del Sur", 1788 + 1962 + 2173 + 2327);

            //Granma
            (string, double) RíoCauto = ("Río Cauto", 2541 + 2805 + 2712 + 2884);
            (string, double) CautoCristo = ("Cauto Cristo", 1205 + 1424 + 1279 + 1185);
            (string, double) Jiguaní = ("Jiguaní", 3280 + 3345 + 3084 + 3510);
            (string, double) Bayamo = ("Bayamo", 12320 + 13796 + 13022 + 13821);
            (string, double) Yara = ("Yara", 2631 + 2941 + 2743 + 3076);
            (string, double) Manzanillo = ("Manzanillo", 6267 + 7259 + 6760 + 7203);
            (string, double) Campechuela = ("Campechuela", 1923 + 2358 + 2311 + 2549);
            (string, double) MediaLuna = ("MediaLuna", 1608 + 1573 + 1679 + 2005);
            (string, double) Niquero = ("Niquero", 2164 + 2373 + 2564 + 2795);
            (string, double) Pilón = ("Pilón", 1522 + 1670 + 1843 + 1821);
            (string, double) BartoloméMasó = ("Bartolomé Masó", 2220 + 2632 + 2485 + 3236);
            (string, double) BueyArriba = ("Buey Arriba", 1625 + 1935 + 1748 + 1973);
            (string, double) Guisa = ("Guisa", 2179 + 2550 + 2447 + 2600);

            //Guantánamo
            (string, double) ElSalvador = ("El Salvador", 2637 + 2869 + 2673 + 2727);
            (string, double) ManuelTames = ("Manuel Tames", 1990 + 2130 + 2339 + 2371);
            (string, double) Yateras = ("Yateras", 1209 + 1420 + 1254 + 1127);
            (string, double) Baracoa = ("Baracoa", 4126 + 4410 + 4364 + 4831);
            (string, double) Maisí = ("Maisí", 1831 + 2026 + 1993 + 1841);
            (string, double) Imías = ("Imías", 1281 + 1393 + 1323 + 1382);
            (string, double) SanAntoniodelSur = ("San Antonio del Sur", 1735 + 1796 + 1743 + 1686);
            (string, double) Caimanera = ("Caimanera", 755 + 791 + 743 + 761);
            (string, double) Guantánamo = ("Guantánamo", 11695 + 13413 + 13634 + 13144);
            (string, double) NicetoPérez = ("Niceto Pérez", 901 + 1054 + 1084 + 1024);

            //Santiago de Cuba
            (string, double) Contramaestre = ("Contra maestre", 5444 + 6486 + 6179 + 5749);
            (string, double) Mella = ("Mella", 1861 + 2212 + 2227 + 2030);
            (string, double) SanLuis_SC = ("San Luis", 4223 + 4859 + 5147 + 4598);
            (string, double) SegundoFrente = ("Segundo Frente", 2417 + 2627 + 2587 + 2491);
            (string, double) SongoLaMaya = ("Songo La Maya", 4642 + 5243 + 6061 + 5549);
            (string, double) SantiagodeCuba = ("Santiago de Cuba", 27426 + 30313 + 28867 + 28786);
            (string, double) PalmaSoriano = ("Palma Soriano", 6091 + 7396 + 6843 + 6708);
            (string, double) TercerFrente = ("Tercer Frente", 1673 + 2013 + 1831 + 2003);
            (string, double) Guamá = ("Guamá", 2018 + 2269 + 2476 + 2130);

            //Isla de la Juventud
            (string, double) IsladelaJuventud = ("Isla de la Juventud", 4185 + 4766 + 4668 + 4934);

            //Las Tunas
            (string, double) Manatí = ("Manatí", 756 + 985 + 943 + 805);
            (string, double) PuertoPadre = ("Puerto Padre", 4005 + 4607 + 4660 + 4706);
            (string, double) JesúsMenéndez = ("Jesús Menéndez", 1925 + 2208 + 2518 + 2471);
            (string, double) Majibacoa = ("Majibacoa", 1813 + 2344 + 2512 + 2262);
            (string, double) LasTunas = ("Las Tunas", 11848 + 13361 + 12408 + 11550);
            (string, double) Jobabo = ("Jobabo", 1908 + 2265 + 2324 + 1931);
            (string, double) Colombia = ("Colombia", 1339 + 1725 + 1588 + 1718);
            (string, double) Amanacio = ("Amanacio", 1550 + 2213 + 1835 + 1816);

            //Ciego de Ávila
            (string, double) Chambas = ("Chambas", 1523 + 1747 + 1962 + 1942);
            (string, double) Morón = ("Morón", 3649 + 4068 + 3750 + 3928);
            (string, double) Bolivia = ("Bolivia", 819 + 919 + 943 + 906);
            (string, double) PrimerodeEnero = ("Primero de Enero", 1134 + 1402 + 1324 + 1354);
            (string, double) CiroRedondo = ("Ciro Redondo", 1524 + 1765 + 1671 + 1716);
            (string, double) Florencia = ("Florencia", 643 + 848 + 896 + 942);
            (string, double) Majagua = ("Majagua", 1215 + 1339 + 1335 + 1512);
            (string, double) CiegodeÁvila = ("Ciego de Ávila", 7444 + 8869 + 8457 + 8579);
            (string, double) Venezuela = ("Venezuela", 1357 + 1643 + 1578 + 1508);
            (string, double) Baraguá = ("Baraguá", 1654 + 1908 + 1991 + 1927);

            List<(string, double)> dataEdadPediátrica = new List<(string, double)>()
            {
                Sandino, Mantua, MinasDeMataHambre, Viniales, LaPalma, LosPalacios, ConsolacionDelSur, PinarDelRio, SanLuis_PR, SanJuanYMartinez, Guane,
                BahiaHonda, Mariel, Guanajay, Caimito, Bauta, SanAntonioDeLosBanios, GuiradeMelena, Alquizar, Artemisa, Candelaria, SanCristobal,
                Playa, PlazadelaRevolución, CentroHabana, HabanaVieja, Regla, HabanadelEste, Guanabacoa, SanMigueldelPadron, DiezdeOctubre, Cerro, Marianao, LaLisa, Boyeros, ArroyoNaranjo, Cotorro,
                Bejucal, SanJosédelasLajas, Jaruco, SantaCruzdelNorte, Madruga, NuevaPaz, SanNicolás, Güines, MelenadelSur, Batabanó, Quivicán,
                Matanzas, Cárdenas, Martí, Colón, Perico, Jovellanos, PedroBetancourt, Limonar, UnióndeReyes, CiénagadeZapata, JagueyGrande, Calimete, LosArabos,
                AguadadePasajeros, Rodas, Palmira, Lajas, Cruces, Cumanayagua, Cienfuegos, Abreus,
                Corralillo, QuemadodeGüines, SagualaGrande, Encrucijada, Camajuaní, Caiberién, Remedios, Placetas, SantaClara, Cifuentes, SantoDomingo, Ranchuelo, Manicaragua,
                Yaguajay, Jatibonico, Taguasco, Cabaiguán, Fomento, Trinidad, SanctiSpíritus, LaSierpe,
                Gibara, RafaelFreyre, Banes, Antilla, Báguanos, Holguín, CalixtoGarcía, Cacocum, UrbanoNoris, Cueto, Mayarí, FrankPaís, SagualaGrande, Moa,
                CarlosManueldeCéspedes, Esmeralda, SierradeCubitas, Minas, Nuevitas, Guáimaro, Sibanicú, Camagüey, Florencia, Vertientes, Jimaguayú, Najasa, SantaCruzdelSur,
                RíoCauto, CautoCristo, Jiguaní, Bayamo, Yara, Manzanillo, Campechuela, MediaLuna, Niquero, Pilón, BartoloméMasó, BueyArriba, Guisa,
                ElSalvador, ManuelTames, Yateras, Baracoa, Maisí, Imías, SanAntoniodelSur, Caimanera, Guantánamo, NicetoPérez,
                Contramaestre, Mella, SanLuis_SC, SegundoFrente, SongoLaMaya, SantiagodeCuba, PalmaSoriano, TercerFrente, Guamá,
                Manatí, PuertoPadre, JesúsMenéndez, Majibacoa, LasTunas, Jobabo, Colombia, Amanacio,
                Chambas, Morón, Bolivia, PrimerodeEnero, CiroRedondo, Florencia, Majagua, CiegodeÁvila, Venezuela, Baraguá,
                IsladelaJuventud
            };

            return dataEdadPediátrica;
        }

        
        public List<(string, double)> dataEdadAdultoMayor()    // >= 60 anios
        {

            //Pinar del Rio
            (string, double) Sandino = ("Sandino", 2265 + 5538);
            (string, double) Mantua = ("Mantua", 1394 + 3756);
            (string, double) MinasDeMataHambre = ("Minas De Matahambre", 1964 + 5142);
            (string, double) Viniales = ("Viñales", 1668 + 4532);
            (string, double) LaPalma = ("La Palma", 2043 + 5413);
            (string, double) LosPalacios = ("Los Palacios", 1979 + 5887);
            (string, double) ConsolacionDelSur = ("Consolación del Sur", 4992 + 14710);
            (string, double) PinarDelRio = ("Pinar del Río", 11593 + 32717);
            (string, double) SanLuis_PR = ("San Luis", 1913 + 4835);
            (string, double) SanJuanYMartinez = ("San Juan y Martínez", 2404 + 7015);
            (string, double) Guane = ("Guane", 1950 + 5400);

            //Artemisa
            (string, double) BahiaHonda = ("Bahía Honda", 2478 + 2141 + 1520 + 1031 + 680 + 501);
            (string, double) Mariel = ("Mariel", 2552 + 1960 + 1544 + 1000 + 670 + 550);
            (string, double) Guanajay = ("Guanajay", 1747 + 1354 + 1130 + 849 + 537 + 451);
            (string, double) Caimito = ("Caimito", 2304 + 1840 + 1548 + 1082 + 651 + 493);
            (string, double) Bauta = ("Bauta", 3018 + 2345 + 1835 + 1430 + 849 + 805);
            (string, double) SanAntonioDeLosBanios = ("San Antonio de los Baños", 3043 + 2248 + 1794 + 1376 + 837 + 588);
            (string, double) GuiradeMelena = ("Güira de Melena", 2174 + 1602 + 1413 + 1096 + 635 + 559);
            (string, double) Alquizar = ("Alquízar", 1893 + 1330 + 956 + 548 + 295 + 315);
            (string, double) Artemisa = ("Artemisa", 4804 + 3747 + 3198 + 2425 + 1547 + 1260);
            (string, double) Candelaria = ("Candelaria", 1078 + 918 + 752 + 546 + 299 + 280);
            (string, double) SanCristobal = ("San Cristóbal", 3929 + 3212 + 2537 + 1996 + 1127 + 854);

            //La Habana
            (string, double) Playa = ("Playa", 11497 + 33562);
            (string, double) PlazadelaRevolución = ("Plaza de la Revolución", 9650 + 31227);
            (string, double) CentroHabana = ("Centro Habana", 8540 + 21925);
            (string, double) HabanaVieja = ("Habana Vieja", 4915 + 12323);
            (string, double) Regla = ("Regla", 2602 + 6678);
            (string, double) HabanadelEste = ("Habana del Este", 10851 + 32405);
            (string, double) Guanabacoa = ("Guanabacoa", 7594 + 18894);
            (string, double) SanMigueldelPadron = ("San Miguel del Padron", 9383 + 21400);
            (string, double) DiezdeOctubre = ("Diez de Octubre", 13487 + 36593);
            (string, double) Cerro = ("Cerro", 7969 + 21318);
            (string, double) Marianao = ("Marianao", 8489 + 21131);
            (string, double) LaLisa = ("La Lisa", 8781 + 22232);
            (string, double) Boyeros = ("Boyeros", 12205 + 30386);
            (string, double) ArroyoNaranjo = ("ArroyoNaranjo", 12492 + 29380);
            (string, double) Cotorro = ("Cotorro", 5132 + 12106);

            //Mayabeque
            (string, double) Bejucal = ("Bejucal", 1617 + 4115);
            (string, double) SanJosédelasLajas = ("San José de las Lajas", 4295 + 11287);
            (string, double) Jaruco = ("Jaruco", 1327 + 4299);
            (string, double) SantaCruzdelNorte = ("Santa Cruz del Norte", 2018 + 5849);
            (string, double) Madruga = ("Madruga", 1621 + 4685);
            (string, double) NuevaPaz = ("Nueva Paz", 1412 + 3778);
            (string, double) SanNicolás = ("San Nicolás", 1203 + 3182);
            (string, double) Güines = ("Güines", 3890 + 10622);
            (string, double) MelenadelSur = ("Melena del Sur", 1095 + 2896);
            (string, double) Batabanó = ("Batabanó", 1428 + 3487);
            (string, double) Quivicán = ("Quivicán", 1633 + 4457);

            //Matanzas                                        //.........................................................
            (string, double) Matanzas = ("Matanzas", 11722);
            (string, double) Cárdenas = ("Cárdenas", 11722);
            (string, double) Martí = ("Martí", 11722);                
            (string, double) Colón = ("Colón", 11722);
            (string, double) Perico = ("Perico", 11722); 
            (string, double) Jovellanos = ("Jovellanos", 11722);             //no hay datos exactos disponibles, es una burda aproximacion
            (string, double) PedroBetancourt = ("Pedro Betancourt", 11722);
            (string, double) Limonar = ("Limonar", 11722);
            (string, double) UnióndeReyes = ("Unión de Reyes", 11722);
            (string, double) CiénagadeZapata = ("Ciénaga de Zapata", 11722);
            (string, double) JagueyGrande = ("Jaguey Grande", 11722);
            (string, double) Calimete = ("Calimete", 11722);
            (string, double) LosArabos = ("Los Arabos", 11722); //.......................................................

            //Cienfuegos
            (string, double) AguadadePasajeros = ("Aguada de Pasajeros", 902 + 4578 + 892 + 4384 );
            (string, double) Rodas = ("Rodas", 1015 + 4921 + 974 + 4687);
            (string, double) Palmira = ("Palmira", 909 + 3195 + 902 + 3035);
            (string, double) Lajas = ("Lajas", 610 + 2143 + 587 + 2016);
            (string, double) Cruces = ("Cruces", 894 + 2920 + 776 + 2648);
            (string, double) Cumanayagua = ("Cumanayagua", 1483 + 7084 + 1413 + 6623);
            (string, double) Cienfuegos = ("Cienfuegos", 5303 + 17166 + 5584 + 17383);
            (string, double) Abreus = ("Abreus", 921 + 3190 + 829 + 2945);

            //Villa Clara
            (string, double) Corralillo = ("Corralillo", 1461 + 4768);
            (string, double) QuemadodeGüines = ("Quemado de Güines", 1324 + 4105);
            (string, double) SagualaGrande = ("Sagua la Grande", 3036 + 9467);
            (string, double) Encrucijada = ("Encrucijada", 3036 + 9467);
            (string, double) Camajuaní = ("Camajuaní", 3462 + 11143);
            (string, double) Caiberién = ("Caiberién", 2199 + 6256);
            (string, double) Remedios = ("Remedios", 2457 + 8565);
            (string, double) Placetas = ("Placetas", 3828 + 13156);
            (string, double) SantaClara = ("Santa Clara", 14817 + 44375);
            (string, double) Cifuentes = ("Cifuentes", 1619 + 5249);
            (string, double) SantoDomingo = ("Santo Domingo", 2857 + 8891);
            (string, double) Ranchuelo = ("Ranchuelo", 3070 + 9593);
            (string, double) Manicaragua = ("Manicaragua", 3782 + 10782);

            //Sancti Spiritus
            (string, double) Yaguajay = ("Yaguajay", 3302 + 10307);
            (string, double) Jatibonico = ("Jatibonico", 2411 + 6737);
            (string, double) Taguasco = ("Taguasco", 1936 + 5620);
            (string, double) Cabaiguán = ("Cabaiguán", 3810 + 12111);
            (string, double) Fomento = ("Fomento", 1932 + 6170);
            (string, double) Trinidad = ("Trinidad", 4436 + 11269);
            (string, double) SanctiSpíritus = ("Sancti Spíritus", 7926 + 22912);
            (string, double) LaSierpe = ("LaSierpe", 881 + 2088);

            //Holguin
            (string, double) Gibara = ("Gibara", 4047 + 12886);
            (string, double) RafaelFreyre = ("Rafael Freyre", 2897 + 7842);
            (string, double) Banes = ("Banes", 4370 + 12897);
            (string, double) Antilla = ("Antilla", 700 + 1872);
            (string, double) Báguanos = ("Báguanos", 2706 + 8179);
            (string, double) Holguín = ("Holguín", 20460 + 56908);
            (string, double) CalixtoGarcía = ("Calixto García", 2755 + 8965);
            (string, double) Cacocum = ("Cacocum", 2125 + 5668);
            (string, double) UrbanoNoris = ("Urbano Noris", 2170 + 5919);
            (string, double) Cueto = ("Cueto", 1754 + 4690);
            (string, double) Mayarí = ("Mayarí", 5626 + 15519);
            (string, double) FrankPaís = ("Frank País", 1296 + 3446);
            (string, double) SaguaTánamo = ("Sagua Tánamo", 2628 + 6923);
            (string, double) Moa = ("Moa", 4455 + 8351);

            //Camaguey
            (string, double) CarlosManueldeCéspedes = ("Carlos Manuel de Céspedes", 1405 + 3290);
            (string, double) Esmeralda = ("Esmeralda", 1681 + 4512);
            (string, double) SierradeCubitas = ("Sierra de Cubitas", 1067 + 2306);
            (string, double) Minas = ("Minas", 2045 + 5553);
            (string, double) Nuevitas = ("Nuevitas", 3662 + 9301);
            (string, double) Guáimaro = ("Guáimaro", 2301 + 6807);
            (string, double) Sibanicú = ("Sibanicú", 1709 + 4584);
            (string, double) Camagüey = ("Camagüey", 20114 + 55270);
            (string, double) Florida = ("Florida", 4196 + 11149);
            (string, double) Vertientes = ("Vertientes", 2712 + 70042);
            (string, double) Jimaguayú = ("Jimaguayú", 1023 + 2588);
            (string, double) Najasa = ("Najasa", 794 + 2089);
            (string, double) SantaCruzdelSur = ("Santa Cruz del Sur", 2343 + 5964);

            //Granma
            (string, double) RíoCauto = ("Río Cauto", 2486 + 5637);
            (string, double) CautoCristo = ("Cauto Cristo", 1077 + 2750);
            (string, double) Jiguaní = ("Jiguaní", 3448 + 9271);
            (string, double) Bayamo = ("Bayamo", 13575 + 35385);
            (string, double) Yara = ("Yara", 3212 + 8101);
            (string, double) Manzanillo = ("Manzanillo", 7561 + 19540);
            (string, double) Campechuela = ("Campechuela", 2473 + 6417);
            (string, double) MediaLuna = ("MediaLuna", 1857 + 4830);
            (string, double) Niquero = ("Niquero", 2249 + 5661);
            (string, double) Pilón = ("Pilón", 1601 + 3966);
            (string, double) BartoloméMasó = ("Bartolomé Masó", 2712 + 6813);
            (string, double) BueyArriba = ("Buey Arriba", 1671 + 4340);
            (string, double) Guisa = ("Guisa", 2756 + 6802);

            //Guantánamo
            (string, double) ElSalvador = ("El Salvador", 1995 + 4841);
            (string, double) ManuelTames = ("Manuel Tames", 1870 + 4649);
            (string, double) Yateras = ("Yateras", 856 + 1960);
            (string, double) Baracoa = ("Baracoa", 4395 + 12122);
            (string, double) Maisí = ("Maisí", 1436 + 3801);
            (string, double) Imías = ("Imías", 1080 + 2643);
            (string, double) SanAntoniodelSur = ("San Antonio del Sur", 1232 + 3386);
            (string, double) Caimanera = ("Caimanera", 606 + 1101);
            (string, double) Guantánamo = ("Guantánamo", 12851 + 33478);
            (string, double) NicetoPérez = ("Niceto Pérez", 865 + 2057);

            //Santiago de Cuba
            (string, double) Contramaestre = ("Contra maestre", 5727  + 15685);
            (string, double) Mella = ("Mella", 1830  + 4340);
            (string, double) SanLuis_SC = ("San Luis", 4168  + 10857);
            (string, double) SegundoFrente = ("Segundo Frente", 2194 + 5547);
            (string, double) SongoLaMaya = ("Songo La Maya", 4922  + 12107);
            (string, double) SantiagodeCuba = ("Santiago de Cuba", 29285 + 77580);
            (string, double) PalmaSoriano = ("Palma Soriano", 6971 + 18888);
            (string, double) TercerFrente = ("Tercer Frente", 1633 + 3766);
            (string, double) Guamá = ("Guamá", 1923 + 4006);

            //Isla de la Juventud
            (string, double) IsladelaJuventud = ("Isla de la Juventud", 4881 + 4237 + 3398 + 2271 + 1148 + 911);

            //Las Tunas
            (string, double) Manatí = ("Manatí", 1665 + 1369);
            (string, double) PuertoPadre = ("Puerto Padre", 5153 + 4967);
            (string, double) JesúsMenéndez = ("Jesús Menéndez", 2775 + 2413);
            (string, double) Majibacoa = ("Majibacoa", 2293 + 1930);
            (string, double) LasTunas = ("Las Tunas", 12305 + 10394);
            (string, double) Jobabo = ("Jobabo", 2291 + 2015);
            (string, double) Colombia = ("Colombia", 1832 + 1650);
            (string, double) Amanacio = ("Amanacio", 2147 + 1744);

            //Ciego de Ávila
            (string, double) Chambas = ("Chambas", 2086 + 6037);
            (string, double) Morón = ("Morón", 3695 + 9990);
            (string, double) Bolivia = ("Bolivia", 776 + 1872);
            (string, double) PrimerodeEnero = ("Primero de Enero", 1152 + 3095);
            (string, double) CiroRedondo = ("Ciro Redondo", 1609 + 4109);
            (string, double) Florencia = ("Florencia", 1084 + 3572);
            (string, double) Majagua = ("Majagua", 1410 + 4017);
            (string, double) CiegodeÁvila = ("Ciego de Ávila", 9118 + 22688);
            (string, double) Venezuela = ("Venezuela", 1367 + 3302);
            (string, double) Baraguá = ("Baraguá", 1367 + 3302);

            List<(string, double)> dataEdadPediátrica = new List<(string, double)>()
            {
                Sandino, Mantua, MinasDeMataHambre, Viniales, LaPalma, LosPalacios, ConsolacionDelSur, PinarDelRio, SanLuis_PR, SanJuanYMartinez, Guane,
                BahiaHonda, Mariel, Guanajay, Caimito, Bauta, SanAntonioDeLosBanios, GuiradeMelena, Alquizar, Artemisa, Candelaria, SanCristobal,
                Playa, PlazadelaRevolución, CentroHabana, HabanaVieja, Regla, HabanadelEste, Guanabacoa, SanMigueldelPadron, DiezdeOctubre, Cerro, Marianao, LaLisa, Boyeros, ArroyoNaranjo, Cotorro,
                Bejucal, SanJosédelasLajas, Jaruco, SantaCruzdelNorte, Madruga, NuevaPaz, SanNicolás, Güines, MelenadelSur, Batabanó, Quivicán,
                Matanzas, Cárdenas, Martí, Colón, Perico, Jovellanos, PedroBetancourt, Limonar, UnióndeReyes, CiénagadeZapata, JagueyGrande, Calimete, LosArabos,
                AguadadePasajeros, Rodas, Palmira, Lajas, Cruces, Cumanayagua, Cienfuegos, Abreus,
                Corralillo, QuemadodeGüines, SagualaGrande, Encrucijada, Camajuaní, Caiberién, Remedios, Placetas, SantaClara, Cifuentes, SantoDomingo, Ranchuelo, Manicaragua,
                Yaguajay, Jatibonico, Taguasco, Cabaiguán, Fomento, Trinidad, SanctiSpíritus, LaSierpe,
                Gibara, RafaelFreyre, Banes, Antilla, Báguanos, Holguín, CalixtoGarcía, Cacocum, UrbanoNoris, Cueto, Mayarí, FrankPaís, SagualaGrande, Moa,
                CarlosManueldeCéspedes, Esmeralda, SierradeCubitas, Minas, Nuevitas, Guáimaro, Sibanicú, Camagüey, Florencia, Vertientes, Jimaguayú, Najasa, SantaCruzdelSur,
                RíoCauto, CautoCristo, Jiguaní, Bayamo, Yara, Manzanillo, Campechuela, MediaLuna, Niquero, Pilón, BartoloméMasó, BueyArriba, Guisa,
                ElSalvador, ManuelTames, Yateras, Baracoa, Maisí, Imías, SanAntoniodelSur, Caimanera, Guantánamo, NicetoPérez,
                Contramaestre, Mella, SanLuis_SC, SegundoFrente, SongoLaMaya, SantiagodeCuba, PalmaSoriano, TercerFrente, Guamá,
                Manatí, PuertoPadre, JesúsMenéndez, Majibacoa, LasTunas, Jobabo, Colombia, Amanacio,
                Chambas, Morón, Bolivia, PrimerodeEnero, CiroRedondo, Florencia, Majagua, CiegodeÁvila, Venezuela, Baraguá,
                IsladelaJuventud
            };

            return dataEdadPediátrica;
        }
        
        /*
    public List<(string, double)> dataEdadAdultoJoven()    // 20 - 59 anios
    {

        //Pinar del Rio
        (string, double) Sandino = ("Sandino", );
        (string, double) Mantua = ("Mantua", );
        (string, double) MinasDeMataHambre = ("Minas De Matahambre", );
        (string, double) Viniales = ("Viñales", );
        (string, double) LaPalma = ("La Palma", );
        (string, double) LosPalacios = ("Los Palacios", );
        (string, double) ConsolacionDelSur = ("Consolación del Sur", );
        (string, double) PinarDelRio = ("Pinar del Río", );
        (string, double) SanLuis_PR = ("San Luis", );
        (string, double) SanJuanYMartinez = ("San Juan y Martínez", );
        (string, double) Guane = ("Guane", );

        //Artemisa
        (string, double) BahiaHonda = ("Bahía Honda", );
        (string, double) Mariel = ("Mariel", );
        (string, double) Guanajay = ("Guanajay", );
        (string, double) Caimito = ("Caimito", );
        (string, double) Bauta = ("Bauta", );
        (string, double) SanAntonioDeLosBanios = ("San Antonio de los Baños", );
        (string, double) GuiradeMelena = ("Güira de Melena", );
        (string, double) Alquizar = ("Alquízar", );
        (string, double) Artemisa = ("Artemisa", );
        (string, double) Candelaria = ("Candelaria", );
        (string, double) SanCristobal = ("San Cristóbal", );

        //La Habana
        (string, double) Playa = ("Playa", );
        (string, double) PlazadelaRevolución = ("Plaza de la Revolución", );
        (string, double) CentroHabana = ("Centro Habana", );
        (string, double) HabanaVieja = ("Habana Vieja", );
        (string, double) Regla = ("Regla", );
        (string, double) HabanadelEste = ("Habana del Este", );
        (string, double) Guanabacoa = ("Guanabacoa", );
        (string, double) SanMigueldelPadron = ("San Miguel del Padron", );
        (string, double) DiezdeOctubre = ("Diez de Octubre", );
        (string, double) Cerro = ("Cerro", );
        (string, double) Marianao = ("Marianao", );
        (string, double) LaLisa = ("La Lisa", );
        (string, double) Boyeros = ("Boyeros", );
        (string, double) ArroyoNaranjo = ("ArroyoNaranjo", );
        (string, double) Cotorro = ("Cotorro", );

        //Mayabeque
        (string, double) Bejucal = ("Bejucal", );
        (string, double) SanJosédelasLajas = ("San José de las Lajas", );
        (string, double) Jaruco = ("Jaruco", );
        (string, double) SantaCruzdelNorte = ("Santa Cruz del Norte", );
        (string, double) Madruga = ("Madruga", );
        (string, double) NuevaPaz = ("Nueva Paz", );
        (string, double) SanNicolás = ("San Nicolás", );
        (string, double) Güines = ("Güines", );
        (string, double) MelenadelSur = ("Melena del Sur", );
        (string, double) Batabanó = ("Batabanó", );
        (string, double) Quivicán = ("Quivicán", );

        //Matanzas
        (string, double) Matanzas = ("Matanzas", );
        (string, double) Cárdenas = ("Cárdenas", );
        (string, double) Martí = ("Martí", );
        (string, double) Colón = ("Colón", );
        (string, double) Perico = ("Perico", );
        (string, double) Jovellanos = ("Jovellanos", );
        (string, double) PedroBetancourt = ("Pedro Betancourt", );
        (string, double) Limonar = ("Limonar", );
        (string, double) UnióndeReyes = ("Unión de Reyes", );
        (string, double) CiénagadeZapata = ("Ciénaga de Zapata", );
        (string, double) JagueyGrande = ("Jaguey Grande", );
        (string, double) Calimete = ("Calimete", );
        (string, double) LosArabos = ("Los Arabos", );

        //Cienfuegos
        (string, double) AguadadePasajeros = ("Aguada de Pasajeros", );
        (string, double) Rodas = ("Rodas", );
        (string, double) Palmira = ("Palmira", );
        (string, double) Lajas = ("Lajas", );
        (string, double) Cruces = ("Cruces", );
        (string, double) Cumanayagua = ("Cumanayagua", );
        (string, double) Cienfuegos = ("Cienfuegos", );
        (string, double) Abreus = ("Abreus", );

        //Villa Clara
        (string, double) Corralillo = ("Corralillo", );
        (string, double) QuemadodeGüines = ("Quemado de Güines", );
        (string, double) SagualaGrande = ("Sagua la Grande", );
        (string, double) Encrucijada = ("Encrucijada", );
        (string, double) Camajuaní = ("Camajuaní", );
        (string, double) Caiberién = ("Caiberién", );
        (string, double) Remedios = ("Remedios", );
        (string, double) Placetas = ("Placetas", );
        (string, double) SantaClara = ("Santa Clara", );
        (string, double) Cifuentes = ("Cifuentes", );
        (string, double) SantoDomingo = ("Santo Domingo", );
        (string, double) Ranchuelo = ("Ranchuelo", );
        (string, double) Manicaragua = ("Manicaragua", );

        //Sancti Spiritus
        (string, double) Yaguajay = ("Yaguajay", );
        (string, double) Jatibonico = ("Jatibonico", );
        (string, double) Taguasco = ("Taguasco", );
        (string, double) Cabaiguán = ("Cabaiguán", );
        (string, double) Fomento = ("Fomento", );
        (string, double) Trinidad = ("Trinidad", );
        (string, double) SanctiSpíritus = ("Sancti Spíritus", );
        (string, double) LaSierpe = ("LaSierpe", );

        //Holguin
        (string, double) Gibara = ("Gibara", );
        (string, double) RafaelFreyre = ("Rafael Freyre", );
        (string, double) Banes = ("Banes", );
        (string, double) Antilla = ("Antilla", );
        (string, double) Báguanos = ("Báguanos", );
        (string, double) Holguín = ("Holguín", );
        (string, double) CalixtoGarcía = ("Calixto García", );
        (string, double) Cacocum = ("Cacocum", );
        (string, double) UrbanoNoris = ("Urbano Noris", );
        (string, double) Cueto = ("Cueto", );
        (string, double) Mayarí = ("Mayarí", );
        (string, double) FrankPaís = ("Frank País", );
        (string, double) SaguaTánamo = ("Sagua Tánamo", );
        (string, double) Moa = ("Moa", );

        //Camaguey
        (string, double) CarlosManueldeCéspedes = ("Carlos Manuel de Céspedes", );
        (string, double) Esmeralda = ("Esmeralda", );
        (string, double) SierradeCubitas = ("Sierra de Cubitas", );
        (string, double) Minas = ("Minas", );
        (string, double) Nuevitas = ("Nuevitas", );
        (string, double) Guáimaro = ("Guáimaro", );
        (string, double) Sibanicú = ("Sibanicú", );
        (string, double) Camagüey = ("Camagüey", );
        (string, double) Florida = ("Florida", );
        (string, double) Vertientes = ("Vertientes", );
        (string, double) Jimaguayú = ("Jimaguayú", );
        (string, double) Najasa = ("Najasa", );
        (string, double) SantaCruzdelSur = ("Santa Cruz del Sur", );

        //Granma
        (string, double) RíoCauto = ("Río Cauto", );
        (string, double) CautoCristo = ("Cauto Cristo", );
        (string, double) Jiguaní = ("Jiguaní", );
        (string, double) Bayamo = ("Bayamo", );
        (string, double) Yara = ("Yara", );
        (string, double) Manzanillo = ("Manzanillo", );
        (string, double) Campechuela = ("Campechuela", );
        (string, double) MediaLuna = ("MediaLuna", );
        (string, double) Niquero = ("Niquero", );
        (string, double) Pilón = ("Pilón", );
        (string, double) BartoloméMasó = ("Bartolomé Masó", );
        (string, double) BueyArriba = ("Buey Arriba", );
        (string, double) Guisa = ("Guisa", );

        //Guantánamo
        (string, double) ElSalvador = ("El Salvador", );
        (string, double) ManuelTames = ("Manuel Tames", );
        (string, double) Yateras = ("Yateras", );
        (string, double) Baracoa = ("Baracoa", );
        (string, double) Maisí = ("Maisí", );
        (string, double) Imías = ("Imías", );
        (string, double) SanAntoniodelSur = ("San Antonio del Sur", );
        (string, double) Caimanera = ("Caimanera", );
        (string, double) Guantánamo = ("Guantánamo", );
        (string, double) NicetoPérez = ("Niceto Pérez", );

        //Santiago de Cuba
        (string, double) Contramaestre = ("Contra maestre", );
        (string, double) Mella = ("Mella", );
        (string, double) SanLuis_SC = ("San Luis", );
        (string, double) SegundoFrente = ("Segundo Frente", );
        (string, double) SongoLaMaya = ("Songo La Maya", );
        (string, double) SantiagodeCuba = ("Santiago de Cuba", );
        (string, double) PalmaSoriano = ("Palma Soriano", );
        (string, double) TercerFrente = ("Tercer Frente", );
        (string, double) Guamá = ("Guamá", );

        //Isla de la Juventud
        (string, double) IsladelaJuventud = ("Isla de la Juventud", );

        //Las Tunas
        (string, double) Manatí = ("Manatí", );
        (string, double) PuertoPadre = ("Puerto Padre", );
        (string, double) JesúsMenéndez = ("Jesús Menéndez", );
        (string, double) Majibacoa = ("Majibacoa", );
        (string, double) LasTunas = ("Las Tunas", );
        (string, double) Jobabo = ("Jobabo", );
        (string, double) Colombia = ("Colombia", );
        (string, double) Amanacio = ("Amanacio", );

        //Ciego de Ávila
        (string, double) Chambas = ("Chambas", );
        (string, double) Morón = ("Morón", );
        (string, double) Bolivia = ("Bolivia", );
        (string, double) PrimerodeEnero = ("Primero de Enero", );
        (string, double) CiroRedondo = ("Ciro Redondo", );
        (string, double) Florencia = ("Florencia", );
        (string, double) Majagua = ("Majagua", );
        (string, double) CiegodeÁvila = ("Ciego de Ávila", );
        (string, double) Venezuela = ("Venezuela", );
        (string, double) Baraguá = ("Baraguá", );

        List<(string, double)> dataEdadPediátrica = new List<(string, double)>()
        {
            Sandino, Mantua, MinasDeMataHambre, Viniales, LaPalma, LosPalacios, ConsolacionDelSur, PinarDelRio, SanLuis_PR, SanJuanYMartinez, Guane,
            BahiaHonda, Mariel, Guanajay, Caimito, Bauta, SanAntonioDeLosBanios, GuiradeMelena, Alquizar, Artemisa, Candelaria, SanCristobal,
            Playa, PlazadelaRevolución, CentroHabana, HabanaVieja, Regla, HabanadelEste, Guanabacoa, SanMigueldelPadron, DiezdeOctubre, Cerro, Marianao, LaLisa, Boyeros, ArroyoNaranjo, Cotorro,
            Bejucal, SanJosédelasLajas, Jaruco, SantaCruzdelNorte, Madruga, NuevaPaz, SanNicolás, Güines, MelenadelSur, Batabanó, Quivicán,
            Matanzas, Cárdenas, Martí, Colón, Perico, Jovellanos, PedroBetancourt, Limonar, UnióndeReyes, CiénagadeZapata, JagueyGrande, Calimete, LosArabos,
            AguadadePasajeros, Rodas, Palmira, Lajas, Cruces, Cumanayagua, Cienfuegos, Abreus,
            Corralillo, QuemadodeGüines, SagualaGrande, Encrucijada, Camajuaní, Caiberién, Remedios, Placetas, SantaClara, Cifuentes, SantoDomingo, Ranchuelo, Manicaragua,
            Yaguajay, Jatibonico, Taguasco, Cabaiguán, Fomento, Trinidad, SanctiSpíritus, LaSierpe,
            Gibara, RafaelFreyre, Banes, Antilla, Báguanos, Holguín, CalixtoGarcía, Cacocum, UrbanoNoris, Cueto, Mayarí, FrankPaís, SagualaGrande, Moa,
            CarlosManueldeCéspedes, Esmeralda, SierradeCubitas, Minas, Nuevitas, Guáimaro, Sibanicú, Camagüey, Florencia, Vertientes, Jimaguayú, Najasa, SantaCruzdelSur,
            RíoCauto, CautoCristo, Jiguaní, Bayamo, Yara, Manzanillo, Campechuela, MediaLuna, Niquero, Pilón, BartoloméMasó, BueyArriba, Guisa,
            ElSalvador, ManuelTames, Yateras, Baracoa, Maisí, Imías, SanAntoniodelSur, Caimanera, Guantánamo, NicetoPérez,
            Contramaestre, Mella, SanLuis_SC, SegundoFrente, SongoLaMaya, SantiagodeCuba, PalmaSoriano, TercerFrente, Guamá,
            Manatí, PuertoPadre, JesúsMenéndez, Majibacoa, LasTunas, Jobabo, Colombia, Amanacio,
            Chambas, Morón, Bolivia, PrimerodeEnero, CiroRedondo, Florencia, Majagua, CiegodeÁvila, Venezuela, Baraguá,
            IsladelaJuventud
        };

        return dataEdadPediátrica;
    }
    */

        /*
    public List<(string, double)> dataEdadMujerFertil()    // 15 - 34 anios
    {

        //Pinar del Rio
        (string, double) Sandino = ("Sandino", );
        (string, double) Mantua = ("Mantua", );
        (string, double) MinasDeMataHambre = ("Minas De Matahambre", );
        (string, double) Viniales = ("Viñales", );
        (string, double) LaPalma = ("La Palma", );
        (string, double) LosPalacios = ("Los Palacios", );
        (string, double) ConsolacionDelSur = ("Consolación del Sur", );
        (string, double) PinarDelRio = ("Pinar del Río", );
        (string, double) SanLuis_PR = ("San Luis", );
        (string, double) SanJuanYMartinez = ("San Juan y Martínez", );
        (string, double) Guane = ("Guane", );

        //Artemisa
        (string, double) BahiaHonda = ("Bahía Honda", );
        (string, double) Mariel = ("Mariel", );
        (string, double) Guanajay = ("Guanajay", );
        (string, double) Caimito = ("Caimito", );
        (string, double) Bauta = ("Bauta", );
        (string, double) SanAntonioDeLosBanios = ("San Antonio de los Baños", );
        (string, double) GuiradeMelena = ("Güira de Melena", );
        (string, double) Alquizar = ("Alquízar", );
        (string, double) Artemisa = ("Artemisa", );
        (string, double) Candelaria = ("Candelaria", );
        (string, double) SanCristobal = ("San Cristóbal", );

        //La Habana
        (string, double) Playa = ("Playa", );
        (string, double) PlazadelaRevolución = ("Plaza de la Revolución", );
        (string, double) CentroHabana = ("Centro Habana", );
        (string, double) HabanaVieja = ("Habana Vieja", );
        (string, double) Regla = ("Regla", );
        (string, double) HabanadelEste = ("Habana del Este", );
        (string, double) Guanabacoa = ("Guanabacoa", );
        (string, double) SanMigueldelPadron = ("San Miguel del Padron", );
        (string, double) DiezdeOctubre = ("Diez de Octubre", );
        (string, double) Cerro = ("Cerro", );
        (string, double) Marianao = ("Marianao", );
        (string, double) LaLisa = ("La Lisa", );
        (string, double) Boyeros = ("Boyeros", );
        (string, double) ArroyoNaranjo = ("ArroyoNaranjo", );
        (string, double) Cotorro = ("Cotorro", );

        //Mayabeque
        (string, double) Bejucal = ("Bejucal", );
        (string, double) SanJosédelasLajas = ("San José de las Lajas", );
        (string, double) Jaruco = ("Jaruco", );
        (string, double) SantaCruzdelNorte = ("Santa Cruz del Norte", );
        (string, double) Madruga = ("Madruga", );
        (string, double) NuevaPaz = ("Nueva Paz", );
        (string, double) SanNicolás = ("San Nicolás", );
        (string, double) Güines = ("Güines", );
        (string, double) MelenadelSur = ("Melena del Sur", );
        (string, double) Batabanó = ("Batabanó", );
        (string, double) Quivicán = ("Quivicán", );

        //Matanzas
        (string, double) Matanzas = ("Matanzas", );
        (string, double) Cárdenas = ("Cárdenas", );
        (string, double) Martí = ("Martí", );
        (string, double) Colón = ("Colón", );
        (string, double) Perico = ("Perico", );
        (string, double) Jovellanos = ("Jovellanos", );
        (string, double) PedroBetancourt = ("Pedro Betancourt", );
        (string, double) Limonar = ("Limonar", );
        (string, double) UnióndeReyes = ("Unión de Reyes", );
        (string, double) CiénagadeZapata = ("Ciénaga de Zapata", );
        (string, double) JagueyGrande = ("Jaguey Grande", );
        (string, double) Calimete = ("Calimete", );
        (string, double) LosArabos = ("Los Arabos", );

        //Cienfuegos
        (string, double) AguadadePasajeros = ("Aguada de Pasajeros", );
        (string, double) Rodas = ("Rodas", );
        (string, double) Palmira = ("Palmira", );
        (string, double) Lajas = ("Lajas", );
        (string, double) Cruces = ("Cruces", );
        (string, double) Cumanayagua = ("Cumanayagua", );
        (string, double) Cienfuegos = ("Cienfuegos", );
        (string, double) Abreus = ("Abreus", );

        //Villa Clara
        (string, double) Corralillo = ("Corralillo", );
        (string, double) QuemadodeGüines = ("Quemado de Güines", );
        (string, double) SagualaGrande = ("Sagua la Grande", );
        (string, double) Encrucijada = ("Encrucijada", );
        (string, double) Camajuaní = ("Camajuaní", );
        (string, double) Caiberién = ("Caiberién", );
        (string, double) Remedios = ("Remedios", );
        (string, double) Placetas = ("Placetas", );
        (string, double) SantaClara = ("Santa Clara", );
        (string, double) Cifuentes = ("Cifuentes", );
        (string, double) SantoDomingo = ("Santo Domingo", );
        (string, double) Ranchuelo = ("Ranchuelo", );
        (string, double) Manicaragua = ("Manicaragua", );

        //Sancti Spiritus
        (string, double) Yaguajay = ("Yaguajay", );
        (string, double) Jatibonico = ("Jatibonico", );
        (string, double) Taguasco = ("Taguasco", );
        (string, double) Cabaiguán = ("Cabaiguán", );
        (string, double) Fomento = ("Fomento", );
        (string, double) Trinidad = ("Trinidad", );
        (string, double) SanctiSpíritus = ("Sancti Spíritus", );
        (string, double) LaSierpe = ("LaSierpe", );

        //Holguin
        (string, double) Gibara = ("Gibara", );
        (string, double) RafaelFreyre = ("Rafael Freyre", );
        (string, double) Banes = ("Banes", );
        (string, double) Antilla = ("Antilla", );
        (string, double) Báguanos = ("Báguanos", );
        (string, double) Holguín = ("Holguín", );
        (string, double) CalixtoGarcía = ("Calixto García", );
        (string, double) Cacocum = ("Cacocum", );
        (string, double) UrbanoNoris = ("Urbano Noris", );
        (string, double) Cueto = ("Cueto", );
        (string, double) Mayarí = ("Mayarí", );
        (string, double) FrankPaís = ("Frank País", );
        (string, double) SaguaTánamo = ("Sagua Tánamo", );
        (string, double) Moa = ("Moa", );

        //Camaguey
        (string, double) CarlosManueldeCéspedes = ("Carlos Manuel de Céspedes", );
        (string, double) Esmeralda = ("Esmeralda", );
        (string, double) SierradeCubitas = ("Sierra de Cubitas", );
        (string, double) Minas = ("Minas", );
        (string, double) Nuevitas = ("Nuevitas", );
        (string, double) Guáimaro = ("Guáimaro", );
        (string, double) Sibanicú = ("Sibanicú", );
        (string, double) Camagüey = ("Camagüey", );
        (string, double) Florida = ("Florida", );
        (string, double) Vertientes = ("Vertientes", );
        (string, double) Jimaguayú = ("Jimaguayú", );
        (string, double) Najasa = ("Najasa", );
        (string, double) SantaCruzdelSur = ("Santa Cruz del Sur", );

        //Granma
        (string, double) RíoCauto = ("Río Cauto", );
        (string, double) CautoCristo = ("Cauto Cristo", );
        (string, double) Jiguaní = ("Jiguaní", );
        (string, double) Bayamo = ("Bayamo", );
        (string, double) Yara = ("Yara", );
        (string, double) Manzanillo = ("Manzanillo", );
        (string, double) Campechuela = ("Campechuela", );
        (string, double) MediaLuna = ("MediaLuna", );
        (string, double) Niquero = ("Niquero", );
        (string, double) Pilón = ("Pilón", );
        (string, double) BartoloméMasó = ("Bartolomé Masó", );
        (string, double) BueyArriba = ("Buey Arriba", );
        (string, double) Guisa = ("Guisa", );

        //Guantánamo
        (string, double) ElSalvador = ("El Salvador", );
        (string, double) ManuelTames = ("Manuel Tames", );
        (string, double) Yateras = ("Yateras", );
        (string, double) Baracoa = ("Baracoa", );
        (string, double) Maisí = ("Maisí", );
        (string, double) Imías = ("Imías", );
        (string, double) SanAntoniodelSur = ("San Antonio del Sur", );
        (string, double) Caimanera = ("Caimanera", );
        (string, double) Guantánamo = ("Guantánamo", );
        (string, double) NicetoPérez = ("Niceto Pérez", );

        //Santiago de Cuba
        (string, double) Contramaestre = ("Contra maestre", );
        (string, double) Mella = ("Mella", );
        (string, double) SanLuis_SC = ("San Luis", );
        (string, double) SegundoFrente = ("Segundo Frente", );
        (string, double) SongoLaMaya = ("Songo La Maya", );
        (string, double) SantiagodeCuba = ("Santiago de Cuba", );
        (string, double) PalmaSoriano = ("Palma Soriano", );
        (string, double) TercerFrente = ("Tercer Frente", );
        (string, double) Guamá = ("Guamá", );

        //Isla de la Juventud
        (string, double) IsladelaJuventud = ("Isla de la Juventud", );

        //Las Tunas
        (string, double) Manatí = ("Manatí", );
        (string, double) PuertoPadre = ("Puerto Padre", );
        (string, double) JesúsMenéndez = ("Jesús Menéndez", );
        (string, double) Majibacoa = ("Majibacoa", );
        (string, double) LasTunas = ("Las Tunas", );
        (string, double) Jobabo = ("Jobabo", );
        (string, double) Colombia = ("Colombia", );
        (string, double) Amanacio = ("Amanacio", );

        //Ciego de Ávila
        (string, double) Chambas = ("Chambas", );
        (string, double) Morón = ("Morón", );
        (string, double) Bolivia = ("Bolivia", );
        (string, double) PrimerodeEnero = ("Primero de Enero", );
        (string, double) CiroRedondo = ("Ciro Redondo", );
        (string, double) Florencia = ("Florencia", );
        (string, double) Majagua = ("Majagua", );
        (string, double) CiegodeÁvila = ("Ciego de Ávila", );
        (string, double) Venezuela = ("Venezuela", );
        (string, double) Baraguá = ("Baraguá", );

        List<(string, double)> dataEdadPediátrica = new List<(string, double)>()
        {
            Sandino, Mantua, MinasDeMataHambre, Viniales, LaPalma, LosPalacios, ConsolacionDelSur, PinarDelRio, SanLuis_PR, SanJuanYMartinez, Guane,
            BahiaHonda, Mariel, Guanajay, Caimito, Bauta, SanAntonioDeLosBanios, GuiradeMelena, Alquizar, Artemisa, Candelaria, SanCristobal,
            Playa, PlazadelaRevolución, CentroHabana, HabanaVieja, Regla, HabanadelEste, Guanabacoa, SanMigueldelPadron, DiezdeOctubre, Cerro, Marianao, LaLisa, Boyeros, ArroyoNaranjo, Cotorro,
            Bejucal, SanJosédelasLajas, Jaruco, SantaCruzdelNorte, Madruga, NuevaPaz, SanNicolás, Güines, MelenadelSur, Batabanó, Quivicán,
            Matanzas, Cárdenas, Martí, Colón, Perico, Jovellanos, PedroBetancourt, Limonar, UnióndeReyes, CiénagadeZapata, JagueyGrande, Calimete, LosArabos,
            AguadadePasajeros, Rodas, Palmira, Lajas, Cruces, Cumanayagua, Cienfuegos, Abreus,
            Corralillo, QuemadodeGüines, SagualaGrande, Encrucijada, Camajuaní, Caiberién, Remedios, Placetas, SantaClara, Cifuentes, SantoDomingo, Ranchuelo, Manicaragua,
            Yaguajay, Jatibonico, Taguasco, Cabaiguán, Fomento, Trinidad, SanctiSpíritus, LaSierpe,
            Gibara, RafaelFreyre, Banes, Antilla, Báguanos, Holguín, CalixtoGarcía, Cacocum, UrbanoNoris, Cueto, Mayarí, FrankPaís, SagualaGrande, Moa,
            CarlosManueldeCéspedes, Esmeralda, SierradeCubitas, Minas, Nuevitas, Guáimaro, Sibanicú, Camagüey, Florencia, Vertientes, Jimaguayú, Najasa, SantaCruzdelSur,
            RíoCauto, CautoCristo, Jiguaní, Bayamo, Yara, Manzanillo, Campechuela, MediaLuna, Niquero, Pilón, BartoloméMasó, BueyArriba, Guisa,
            ElSalvador, ManuelTames, Yateras, Baracoa, Maisí, Imías, SanAntoniodelSur, Caimanera, Guantánamo, NicetoPérez,
            Contramaestre, Mella, SanLuis_SC, SegundoFrente, SongoLaMaya, SantiagodeCuba, PalmaSoriano, TercerFrente, Guamá,
            Manatí, PuertoPadre, JesúsMenéndez, Majibacoa, LasTunas, Jobabo, Colombia, Amanacio,
            Chambas, Morón, Bolivia, PrimerodeEnero, CiroRedondo, Florencia, Majagua, CiegodeÁvila, Venezuela, Baraguá,
            IsladelaJuventud
        };

        return dataEdadPediátrica;
    }
    */


    }
}