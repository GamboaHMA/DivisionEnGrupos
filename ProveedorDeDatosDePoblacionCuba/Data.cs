using System.Security.AccessControl;

namespace ProveedorDeDatosDePoblacionCuba
{
    public class Data
    {
        public List<(string, double, string)> EdadPediatrica()    //0 - 19 anios
        {
            //Pinar del Rio
            (string, double, string) Sandino = ("Sandino", 1561 + 1720 + 1948 + 2016, "Pinar del Rio");
            (string, double, string) Mantua = ("Mantua", 1170 + 1143 + 1121 + 1360, "Pinar del Rio");
            (string, double, string) MinasDeMataHambre = ("Minas De Matahambre", 1544 + 1607 + 1593 + 1837, "Pinar del Rio");
            (string, double, string) Viniales = ("Viñales", 1600 + 1668 + 1485 + 1714, "Pinar del Rio");
            (string, double, string) LaPalma = ("La Palma", 1619 + 1701 + 1837 + 2040, "Pinar del Rio");
            (string, double, string) LosPalacios = ("Los Palacios", 1706 + 1923 + 1962 + 2183, "Pinar del Rio");
            (string, double, string) ConsolacionDelSur = ("Consolación del Sur", 4221 + 4610 + 4814 + 4972, "Pinar del Rio");
            (string, double, string) PinarDelRio = ("Pinar del Río", 9989 + 11094 + 9672 + 10628, "Pinar del Rio");
            (string, double, string) SanLuis_PR = ("San Luis_PR", 1582 + 1633 + 1607 + 1938, "Pinar del Rio");
            (string, double, string) SanJuanYMartinez = ("San Juan y Martínez", 2119 + 2145 + 2188 + 2540, "Pinar del Rio");
            (string, double, string) Guane = ("Guane", 1712 + 1888 + 1828 + 2098, "Pinar del Rio");

            //Artemisa
            (string, double, string) BahiaHonda = ("Bahía Honda", 2350 + 2330 + 2357 + 2523, "Artemisa");
            (string, double, string) Mariel = ("Mariel", 2293 + 2521 + 2559 + 2584, "Artemisa");
            (string, double, string) Guanajay = ("Guanajay", 1275 + 1724 + 1392 + 1518, "Artemisa");
            (string, double, string) Caimito = ("Caimito", 2302 + 2595 + 2464 + 2250, "Artemisa");
            (string, double, string) Bauta = ("Bauta", 2687 + 2966 + 2684 + 2807, "Artemisa");
            (string, double, string) SanAntonioDeLosBanios = ("San Antonio de los Baños", 2583 + 2887 + 2647 + 2663, "Artemisa");
            (string, double, string) GuiradeMelena = ("Güira de Melena", 2265 + 2331 + 2182 + 2278, "Artemisa");
            (string, double, string) Alquizar = ("Alquízar", 2154 + 2351 + 1908 + 1924, "Artemisa");
            (string, double, string) Artemisa = ("Artemisa", 4462 + 4905 + 4417 + 4766, "Artemisa");
            (string, double, string) Candelaria = ("Candelaria", 1198 + 1295 + 1191 + 1274, "Artemisa");
            (string, double, string) SanCristobal = ("San Cristóbal", 3646 + 4020 + 3858 + 4271, "Artemisa");

            //La Habana
            (string, double, string) Playa = ("Playa", 6761 + 7428 + 7519 + 8619, "La Habana");
            (string, double, string) PlazadelaRevolución = ("Plaza de la Revolución", 4292 + 4879 + 4995 + 6052, "La Habana");
            (string, double, string) CentroHabana = ("Centro Habana", 5641 + 5936 + 5689 + 6292, "La Habana");
            (string, double, string) HabanaVieja = ("Habana Vieja", 3603 + 3564 + 3806 + 3820, "La Habana");
            (string, double, string) Regla = ("Regla", 2056 + 2402 + 2370 + 2373, "La Habana");
            (string, double, string) HabanadelEste = ("Habana del Este", 7354 + 8367 + 8320 + 8755, "La Habana");
            (string, double, string) Guanabacoa = ("Guanabacoa", 6684 + 7350 + 6942 + 6774, "La Habana");
            (string, double, string) SanMigueldelPadron = ("San Miguel del Padron", 8676 + 9609 + 8665 + 9007, "La Habana");
            (string, double, string) DiezdeOctubre = ("Diez de Octubre", 8545 + 9541 + 9192 + 10098, "La Habana");
            (string, double, string) Cerro = ("Cerro", 5541 + 6171 + 5688 + 5977, "La Habana");
            (string, double, string) Marianao = ("Marianao", 6092 + 6609 + 6677 + 6942, "La Habana");
            (string, double, string) LaLisa = ("La Lisa", 7590 + 8235 + 7595 + 8310, "La Habana");
            (string, double, string) Boyeros = ("Boyeros", 11036 + 11138 + 10024 + 10907, "La Habana");
            (string, double, string) ArroyoNaranjo = ("ArroyoNaranjo", 11531 + 12308 + 10679 + 10915, "La Habana");
            (string, double, string) Cotorro = ("Cotorro", 4328 + 5066 + 4337 + 4372, "La Habana");

            //Mayabeque
            (string, double, string) Bejucal = ("Bejucal", 1398 + 1479 + 1532 + 1513, "Mayabeque");
            (string, double, string) SanJosédelasLajas = ("San José de las Lajas", 4593 + 5149 + 4650 + 4664, "Mayabeque");
            (string, double, string) Jaruco = ("Jaruco", 1074 + 1280 + 1133 + 1220, "Mayabeque");
            (string, double, string) SantaCruzdelNorte = ("Santa Cruz del Norte", 1660 + 1780 + 1678 + 1897, "Mayabeque");
            (string, double, string) Madruga = ("Madruga", 1177 + 1298 + 1318 + 1297, "Mayabeque");
            (string, double, string) NuevaPaz = ("Nueva Paz", 1086 + 1192 + 1211 + 1102, "Mayabeque");
            (string, double, string) SanNicolás = ("San Nicolás", 967 + 1061 + 1081 + 1062, "Mayabeque");
            (string, double, string) Güines = ("Güines", 3120 + 3391 + 3217 + 3453, "Mayabeque");
            (string, double, string) MelenadelSur = ("Melena del Sur", 1077 + 1135 + 1108 + 1117, "Mayabeque");
            (string, double, string) Batabanó = ("Batabanó", 1434 + 1603 + 1753 + 1571, "Mayabeque");
            (string, double, string) Quivicán = ("Quivicán", 1588 + 1621 + 1634 + 1650, "Mayabeque");

            //Matanzas
            (string, double, string) Matanzas = ("Matanzas", 8244 + 7892 + 8426 + 10550, "Matanzas");
            (string, double, string) Cárdenas = ("Cárdenas", 8290 + 9532 + 8505 + 7994, "Matanzas");
            (string, double, string) Martí = ("Martí", 877 + 975 + 1080 + 1070, "Matanzas");
            (string, double, string) Colón = ("Colón", 3134 + 3698 + 3547 + 3578, "Matanzas");
            (string, double, string) Perico = ("Perico", 1255 + 1584 + 1673 + 1612, "Matanzas");
            (string, double, string) Jovellanos = ("Jovellanos", 2981 + 3232 + 3206 + 3028, "Matanzas");
            (string, double, string) PedroBetancourt = ("Pedro Betancourt", 1279 + 1316 + 1425 + 1327, "Matanzas");
            (string, double, string) Limonar = ("Limonar", 1288 + 1461 + 1343 + 1459, "Matanzas");
            (string, double, string) UnióndeReyes = ("Unión de Reyes", 1396 + 1689 + 1559 + 1719, "Matanzas");
            (string, double, string) CiénagadeZapata = ("Ciénaga de Zapata", 661 + 775 + 520 + 579, "Matanzas");
            (string, double, string) JagueyGrande = ("Jaguey Grande", 2596 + 3153 + 2890 + 3141, "Matanzas");
            (string, double, string) Calimete = ("Calimete", 1232 + 1360 + 1420 + 1323, "Matanzas");
            (string, double, string) LosArabos = ("Los Arabos", 1029 + 1214 + 1148 + 1167, "Matanzas");

            //Cienfuegos
            (string, double, string) AguadadePasajeros = ("Aguada de Pasajeros", 777 + 896 + 958 + 981 + 726 + 793 + 883 + 910, "Cienfuegos");
            (string, double, string) Rodas = ("Rodas", 679 + 850 + 900 + 922 + 675 + 790 + 857 + 833, "Cienfuegos");
            (string, double, string) Palmira = ("Palmira", 774 + 859 + 876 + 902 + 759 + 784 + 884 + 907, "Cienfuegos");
            (string, double, string) Lajas = ("Lajas", 505 + 586 + 607 + 624 + 440 + 530 + 553 + 588, "Cienfuegos");
            (string, double, string) Cruces = ("Cruces", 695 + 770 + 768 + 886 + 620 + 606 + 750 + 784, "Cienfuegos");
            (string, double, string) Cumanayagua = ("Cumanayagua", 1095 + 1322 + 1323 + 1359 + 1056 + 1251 + 1187 + 1194, "Cienfuegos");
            (string, double, string) Cienfuegos = ("Cienfuegos", 4377 + 5123 + 4904 + 5068 + 4200 + 4773 + 4666 + 4762, "Cienfuegos");
            (string, double, string) Abreus = ("Abreus", 758 + 930 + 937 + 958 + 768 + 807 + 878 + 913, "Cienfuegos");

            //Villa Clara
            (string, double, string) Corralillo = ("Corralillo", 1006 + 1128 + 1185 + 1359, "Villa Clara");
            (string, double, string) QuemadodeGüines = ("Quemado de Güines", 779 + 859 + 1000 + 1098, "Villa Clara");
            (string, double, string) SagualaGrande = ("Sagua la Grande", 2101 + 2426 + 2430 + 2721, "Villa Clara");
            (string, double, string) Encrucijada = ("Encrucijada", 1244 + 1545 + 1568 + 1529, "Villa Clara");
            (string, double, string) Camajuaní = ("Camajuaní", 2393 + 2663 + 2609 + 2888, "Villa Clara");
            (string, double, string) Caiberién = ("Caiberién", 2115 + 2317 + 2254 + 2090, "Villa Clara");
            (string, double, string) Remedios = ("Remedios", 1621 + 1815 + 1898 + 2058, "Villa Clara");
            (string, double, string) Placetas = ("Placetas", 2824 + 3167 + 3029 + 3504, "Villa Clara");
            (string, double, string) SantaClara = ("Santa Clara", 11919 + 13373 + 12325 + 12278, "Villa Clara");
            (string, double, string) Cifuentes = ("Cifuentes", 1009 + 1169 + 1359 + 1305, "Villa Clara");
            (string, double, string) SantoDomingo = ("Santo Domingo", 1807 + 2244 + 2341 + 2440, "Villa Clara");
            (string, double, string) Ranchuelo = ("Ranchuelo", 2100 + 2525 + 2611 + 2575, "Villa Clara");
            (string, double, string) Manicaragua = ("Manicaragua", 2645 + 3121 + 3133 + 3207, "Villa Clara");

            //Sancti Spiritus
            (string, double, string) Yaguajay = ("Yaguajay", 2029 + 2473 + 2706 + 2652, "Sancti Spiritus");
            (string, double, string) Jatibonico = ("Jatibonico", 1917 + 2382 + 2470 + 2359, "Sancti Spiritus");
            (string, double, string) Taguasco = ("Taguasco", 1452 + 1703 + 1872 + 1787, "Sancti Spiritus");
            (string, double, string) Cabaiguán = ("Cabaiguán", 2568 + 3081 + 3092 + 3392, "Sancti Spiritus");
            (string, double, string) Fomento = ("Fomento", 1244 + 1369 + 1564 + 1613, "Sancti Spiritus");
            (string, double, string) Trinidad = ("Trinidad", 3935 + 4531 + 4184 + 4214, "Sancti Spiritus");
            (string, double, string) SanctiSpíritus = ("Sancti Spíritus", 6686 + 8351 + 7972 + 7823, "Sancti Spiritus");
            (string, double, string) LaSierpe = ("LaSierpe", 935 + 1034 + 907 + 1292, "Sancti Spiritus");

            //Holguín
            (string, double, string) Gibara = ("Gibara", 2973 + 3468 + 3697 + 3909, "Holguín");
            (string, double, string) RafaelFreyre = ("Rafael Freyre", 2486 + 2803 + 3241 + 3287, "Holguín");
            (string, double, string) Banes = ("Banes", 3143 + 3246 + 4169 + 4236, "Holguín");
            (string, double, string) Antilla = ("Antilla", 700 + 720 + 776 + 760, "Holguín");
            (string, double, string) Báguanos = ("Báguanos", 2213 + 2419 + 2991 + 2874, "Holguín");
            (string, double, string) Holguín = ("Holguín", 17465 + 19776 + 19962 + 20234, "Holguín");
            (string, double, string) CalixtoGarcía = ("Calixto García", 2357 + 2672 + 3187 + 3160, "Holguín");
            (string, double, string) Cacocum = ("Cacocum", 1926 + 2016 + 2620 + 2380, "Holguín");
            (string, double, string) UrbanoNoris = ("Urbano Noris", 1786 + 2103 + 2287 + 2214, "Holguín");
            (string, double, string) Cueto = ("Cueto", 1422 + 1669 + 1871 + 1826, "Holguín");
            (string, double, string) Mayarí = ("Mayarí", 3788 + 4546 + 5508 + 5755, "Holguín");
            (string, double, string) FrankPaís = ("Frank País", 939 + 1016 + 1447 + 1437, "Holguín");
            (string, double, string) SaguaTánamo = ("Sagua Tánamo", 2245 + 2294 + 2815 + 3169, "Holguín");
            (string, double, string) Moa = ("Moa", 4327 + 4342 + 4508 + 4451, "Holguín");

            //Camagüey
            (string, double, string) CarlosManueldeCéspedes = ("Carlos Manuel de Céspedes", 953 + 1195 + 1293 + 1357, "Camagüey");
            (string, double, string) Esmeralda = ("Esmeralda", 1440 + 1583 + 1583 + 1723, "Camagüey");
            (string, double, string) SierradeCubitas = ("Sierra de Cubitas", 827 + 990 + 1045 + 1023, "Camagüey");
            (string, double, string) Minas = ("Minas", 1586 + 1895 + 2009 + 1966, "Camagüey");
            (string, double, string) Nuevitas = ("Nuevitas", 2514 + 2962 + 3401 + 3205, "Camagüey");
            (string, double, string) Guáimaro = ("Guáimaro", 1472 + 1594 + 1746 + 1998, "Camagüey");
            (string, double, string) Sibanicú = ("Sibanicú", 1208 + 1459 + 1673 + 1615, "Camagüey");
            (string, double, string) Camagüey = ("Camagüey", 16450 + 19664 + 17441 + 17770, "Camagüey");
            (string, double, string) Florida = ("Florida", 3039 + 3492 + 3887 + 3648, "Camagüey");
            (string, double, string) Vertientes = ("Vertientes", 2158 + 2866 + 2828 + 2869, "Camagüey");
            (string, double, string) Jimaguayú = ("Jimaguayú", 1020 + 1137 + 1165 + 1065, "Camagüey");
            (string, double, string) Najasa = ("Najasa", 639 + 745 + 883 + 795, "Camagüey");
            (string, double, string) SantaCruzdelSur = ("Santa Cruz del Sur", 1788 + 1962 + 2173 + 2327, "Camagüey");

            //Granma
            (string, double, string) RíoCauto = ("Río Cauto", 2541 + 2805 + 2712 + 2884, "Granma");
            (string, double, string) CautoCristo = ("Cauto Cristo", 1205 + 1424 + 1279 + 1185, "Granma");
            (string, double, string) Jiguaní = ("Jiguaní", 3280 + 3345 + 3084 + 3510, "Granma");
            (string, double, string) Bayamo = ("Bayamo", 12320 + 13796 + 13022 + 13821, "Granma");
            (string, double, string) Yara = ("Yara", 2631 + 2941 + 2743 + 3076, "Granma");
            (string, double, string) Manzanillo = ("Manzanillo", 6267 + 7259 + 6760 + 7203, "Granma");
            (string, double, string) Campechuela = ("Campechuela", 1923 + 2358 + 2311 + 2549, "Granma");
            (string, double, string) MediaLuna = ("MediaLuna", 1608 + 1573 + 1679 + 2005, "Granma");
            (string, double, string) Niquero = ("Niquero", 2164 + 2373 + 2564 + 2795, "Granma");
            (string, double, string) Pilón = ("Pilón", 1522 + 1670 + 1843 + 1821, "Granma");
            (string, double, string) BartoloméMasó = ("Bartolomé Masó", 2220 + 2632 + 2485 + 3236, "Granma");
            (string, double, string) BueyArriba = ("Buey Arriba", 1625 + 1935 + 1748 + 1973, "Granma");
            (string, double, string) Guisa = ("Guisa", 2179 + 2550 + 2447 + 2600, "Granma");

            //Guantánamo
            (string, double, string) ElSalvador = ("El Salvador", 2637 + 2869 + 2673 + 2727, "Guantánamo");
            (string, double, string) ManuelTames = ("Manuel Tames", 1990 + 2130 + 2339 + 2371, "Guantánamo");
            (string, double, string) Yateras = ("Yateras", 1209 + 1420 + 1254 + 1127, "Guantánamo");
            (string, double, string) Baracoa = ("Baracoa", 4126 + 4410 + 4364 + 4831, "Guantánamo");
            (string, double, string) Maisí = ("Maisí", 1831 + 2026 + 1993 + 1841, "Guantánamo");
            (string, double, string) Imías = ("Imías", 1281 + 1393 + 1323 + 1382, "Guantánamo");
            (string, double, string) SanAntoniodelSur = ("San Antonio del Sur", 1735 + 1796 + 1743 + 1686, "Guantánamo");
            (string, double, string) Caimanera = ("Caimanera", 755 + 791 + 743 + 761, "Guantánamo");
            (string, double, string) Guantánamo = ("Guantánamo", 11695 + 13413 + 13634 + 13144, "Guantánamo");
            (string, double, string) NicetoPérez = ("Niceto Pérez", 901 + 1054 + 1084 + 1024, "Guantánamo");

            //Santiago de Cuba
            (string, double, string) Contramaestre = ("Contra maestre", 5444 + 6486 + 6179 + 5749, "Santiago de Cuba");
            (string, double, string) Mella = ("Mella", 1861 + 2212 + 2227 + 2030, "Santiago de Cuba");
            (string, double, string) SanLuis_SC = ("San Luis", 4223 + 4859 + 5147 + 4598, "Santiago de Cuba");
            (string, double, string) SegundoFrente = ("Segundo Frente", 2417 + 2627 + 2587 + 2491, "Santiago de Cuba");
            (string, double, string) SongoLaMaya = ("Songo La Maya", 4642 + 5243 + 6061 + 5549, "Santiago de Cuba");
            (string, double, string) SantiagodeCuba = ("Santiago de Cuba", 27426 + 30313 + 28867 + 28786, "Santiago de Cuba");
            (string, double, string) PalmaSoriano = ("Palma Soriano", 6091 + 7396 + 6843 + 6708, "Santiago de Cuba");
            (string, double, string) TercerFrente = ("Tercer Frente", 1673 + 2013 + 1831 + 2003, "Santiago de Cuba");
            (string, double, string) Guamá = ("Guamá", 2018 + 2269 + 2476 + 2130, "Santiago de Cuba");

            //Isla de la Juventud
            (string, double, string) IsladelaJuventud = ("Isla de la Juventud", 4185 + 4766 + 4668 + 4934, "Isla de la Juventud");

            //Las Tunas
            (string, double, string) Manatí = ("Manatí", 756 + 985 + 943 + 805, "Las Tunas");
            (string, double, string) PuertoPadre = ("Puerto Padre", 4005 + 4607 + 4660 + 4706, "Las Tunas");
            (string, double, string) JesúsMenéndez = ("Jesús Menéndez", 1925 + 2208 + 2518 + 2471, "Las Tunas");
            (string, double, string) Majibacoa = ("Majibacoa", 1813 + 2344 + 2512 + 2262, "Las Tunas");
            (string, double, string) LasTunas = ("Las Tunas", 11848 + 13361 + 12408 + 11550, "Las Tunas");
            (string, double, string) Jobabo = ("Jobabo", 1908 + 2265 + 2324 + 1931, "Las Tunas");
            (string, double, string) Colombia = ("Colombia", 1339 + 1725 + 1588 + 1718, "Las Tunas");
            (string, double, string) Amanacio = ("Amanacio", 1550 + 2213 + 1835 + 1816, "Las Tunas");

            //Ciego de Ávila
            (string, double, string) Chambas = ("Chambas", 1523 + 1747 + 1962 + 1942, "Ciego de Ávila");
            (string, double, string) Morón = ("Morón", 3649 + 4068 + 3750 + 3928, "Ciego de Ávila");
            (string, double, string) Bolivia = ("Bolivia", 819 + 919 + 943 + 906, "Ciego de Ávila");
            (string, double, string) PrimerodeEnero = ("Primero de Enero", 1134 + 1402 + 1324 + 1354, "Ciego de Ávila");
            (string, double, string) CiroRedondo = ("Ciro Redondo", 1524 + 1765 + 1671 + 1716, "Ciego de Ávila");
            (string, double, string) Florencia = ("Florencia", 643 + 848 + 896 + 942, "Ciego de Ávila");
            (string, double, string) Majagua = ("Majagua", 1215 + 1339 + 1335 + 1512, "Ciego de Ávila");
            (string, double, string) CiegodeÁvila = ("Ciego de Ávila", 7444 + 8869 + 8457 + 8579, "Ciego de Ávila");
            (string, double, string) Venezuela = ("Venezuela", 1357 + 1643 + 1578 + 1508, "Ciego de Ávila");
            (string, double, string) Baraguá = ("Baraguá", 1654 + 1908 + 1991 + 1927, "Ciego de Ávila");

            List<(string, double, string)> dataEdadPediátrica = new List<(string, double, string)>()
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


        public List<(string, double, string)> EdadAdultoMayor()    // >= 60 anios
        {

            //Pinar del Rio
            (string, double, string) Sandino = ("Sandino", 2265 + 5538, "Pinar del Rio");
            (string, double, string) Mantua = ("Mantua", 1394 + 3756, "Pinar del Rio");
            (string, double, string) MinasDeMataHambre = ("Minas De Matahambre", 1964 + 5142, "Pinar del Rio");
            (string, double, string) Viniales = ("Viñales", 1668 + 4532, "Pinar del Rio");
            (string, double, string) LaPalma = ("La Palma", 2043 + 5413, "Pinar del Rio");
            (string, double, string) LosPalacios = ("Los Palacios", 1979 + 5887, "Pinar del Rio");
            (string, double, string) ConsolacionDelSur = ("Consolación del Sur", 4992 + 14710, "Pinar del Rio");
            (string, double, string) PinarDelRio = ("Pinar del Río", 11593 + 32717, "Pinar del Rio");
            (string, double, string) SanLuis_PR = ("San Luis", 1913 + 4835, "Pinar del Rio");
            (string, double, string) SanJuanYMartinez = ("San Juan y Martínez", 2404 + 7015, "Pinar del Rio");
            (string, double, string) Guane = ("Guane", 1950 + 5400, "Pinar del Rio");

            //Artemisa
            (string, double, string) BahiaHonda = ("Bahía Honda", 2478 + 2141 + 1520 + 1031 + 680 + 501, "Artemisa");
            (string, double, string) Mariel = ("Mariel", 2552 + 1960 + 1544 + 1000 + 670 + 550, "Artemisa");
            (string, double, string) Guanajay = ("Guanajay", 1747 + 1354 + 1130 + 849 + 537 + 451, "Artemisa");
            (string, double, string) Caimito = ("Caimito", 2304 + 1840 + 1548 + 1082 + 651 + 493, "Artemisa");
            (string, double, string) Bauta = ("Bauta", 3018 + 2345 + 1835 + 1430 + 849 + 805, "Artemisa");
            (string, double, string) SanAntonioDeLosBanios = ("San Antonio de los Baños", 3043 + 2248 + 1794 + 1376 + 837 + 588, "Artemisa");
            (string, double, string) GuiradeMelena = ("Güira de Melena", 2174 + 1602 + 1413 + 1096 + 635 + 559, "Artemisa");
            (string, double, string) Alquizar = ("Alquízar", 1893 + 1330 + 956 + 548 + 295 + 315, "Artemisa");
            (string, double, string) Artemisa = ("Artemisa", 4804 + 3747 + 3198 + 2425 + 1547 + 1260, "Artemisa");
            (string, double, string) Candelaria = ("Candelaria", 1078 + 918 + 752 + 546 + 299 + 280, "Artemisa");
            (string, double, string) SanCristobal = ("San Cristóbal", 3929 + 3212 + 2537 + 1996 + 1127 + 854, "Artemisa");

            //La Habana
            (string, double, string) Playa = ("Playa", 11497 + 33562, "La Habana");
            (string, double, string) PlazadelaRevolución = ("Plaza de la Revolución", 9650 + 31227, "La Habana");
            (string, double, string) CentroHabana = ("Centro Habana", 8540 + 21925, "La Habana");
            (string, double, string) HabanaVieja = ("Habana Vieja", 4915 + 12323, "La Habana");
            (string, double, string) Regla = ("Regla", 2602 + 6678, "La Habana");
            (string, double, string) HabanadelEste = ("Habana del Este", 10851 + 32405, "La Habana");
            (string, double, string) Guanabacoa = ("Guanabacoa", 7594 + 18894, "La Habana");
            (string, double, string) SanMigueldelPadron = ("San Miguel del Padron", 9383 + 21400, "La Habana");
            (string, double, string) DiezdeOctubre = ("Diez de Octubre", 13487 + 36593, "La Habana");
            (string, double, string) Cerro = ("Cerro", 7969 + 21318, "La Habana");
            (string, double, string) Marianao = ("Marianao", 8489 + 21131, "La Habana");
            (string, double, string) LaLisa = ("La Lisa", 8781 + 22232, "La Habana");
            (string, double, string) Boyeros = ("Boyeros", 12205 + 30386, "La Habana");
            (string, double, string) ArroyoNaranjo = ("ArroyoNaranjo", 12492 + 29380, "La Habana");
            (string, double, string) Cotorro = ("Cotorro", 5132 + 12106, "La Habana");

            //Mayabeque
            (string, double, string) Bejucal = ("Bejucal", 1617 + 4115, "Mayabeque");
            (string, double, string) SanJosédelasLajas = ("San José de las Lajas", 4295 + 11287, "Mayabeque");
            (string, double, string) Jaruco = ("Jaruco", 1327 + 4299, "Mayabeque");
            (string, double, string) SantaCruzdelNorte = ("Santa Cruz del Norte", 2018 + 5849, "Mayabeque");
            (string, double, string) Madruga = ("Madruga", 1621 + 4685, "Mayabeque");
            (string, double, string) NuevaPaz = ("Nueva Paz", 1412 + 3778, "Mayabeque");
            (string, double, string) SanNicolás = ("San Nicolás", 1203 + 3182, "Mayabeque");
            (string, double, string) Güines = ("Güines", 3890 + 10622, "Mayabeque");
            (string, double, string) MelenadelSur = ("Melena del Sur", 1095 + 2896, "Mayabeque");
            (string, double, string) Batabanó = ("Batabanó", 1428 + 3487, "Mayabeque");
            (string, double, string) Quivicán = ("Quivicán", 1633 + 4457, "Mayabeque");

            //Matanzas                                        //.........................................................
            (string, double, string) Matanzas = ("Matanzas", 10262 + 11904 + 10749, "Matanzas");
            (string, double, string) Cárdenas = ("Cárdenas", 9765 + 10419 + 12613, "Matanzas");
            (string, double, string) Martí = ("Martí", 1331 + 1412 + 1636, "Matanzas");
            (string, double, string) Colón = ("Colón", 4591 + 4592 + 4867, "Matanzas");
            (string, double, string) Perico = ("Perico", 1856 + 2010 + 2196, "Matanzas");
            (string, double, string) Jovellanos = ("Jovellanos", 3577 + 3781 + 4061, "Matanzas");             //no hay datos exactos disponibles, es una burda aproximacion
            (string, double, string) PedroBetancourt = ("Pedro Betancourt", 1838 + 1965 + 2008, "Matanzas");
            (string, double, string) Limonar = ("Limonar", 1677 + 1870 + 1895, "Matanzas");
            (string, double, string) UnióndeReyes = ("Unión de Reyes", 2221 + 2241 + 2275, "Matanzas");
            (string, double, string) CiénagadeZapata = ("Ciénaga de Zapata", 723 + 668 + 799, "Matanzas");
            (string, double, string) JagueyGrande = ("Jaguey Grande", 3933 + 3554 + 4324, "Matanzas");
            (string, double, string) Calimete = ("Calimete", 1945 + 1836 + 2004, "Matanzas");
            (string, double, string) LosArabos = ("Los Arabos", 1414 + 1505 + 1771, "Matanzas"); //.......................................................

            //Cienfuegos
            (string, double, string) AguadadePasajeros = ("Aguada de Pasajeros", 902 + 4578 + 892 + 4384, "Cienfuegos");
            (string, double, string) Rodas = ("Rodas", 1015 + 4921 + 974 + 4687, "Cienfuegos");
            (string, double, string) Palmira = ("Palmira", 909 + 3195 + 902 + 3035, "Cienfuegos");
            (string, double, string) Lajas = ("Lajas", 610 + 2143 + 587 + 2016, "Cienfuegos");
            (string, double, string) Cruces = ("Cruces", 894 + 2920 + 776 + 2648, "Cienfuegos");
            (string, double, string) Cumanayagua = ("Cumanayagua", 1483 + 7084 + 1413 + 6623, "Cienfuegos");
            (string, double, string) Cienfuegos = ("Cienfuegos", 5303 + 17166 + 5584 + 17383, "Cienfuegos");
            (string, double, string) Abreus = ("Abreus", 921 + 3190 + 829 + 2945, "Cienfuegos");

            //Villa Clara
            (string, double, string) Corralillo = ("Corralillo", 1461 + 4768, "Villa Clara");
            (string, double, string) QuemadodeGüines = ("Quemado de Güines", 1324 + 4105, "Villa Clara");
            (string, double, string) SagualaGrande = ("Sagua la Grande", 3036 + 9467, "Villa Clara");
            (string, double, string) Encrucijada = ("Encrucijada", 3036 + 9467, "Villa Clara");
            (string, double, string) Camajuaní = ("Camajuaní", 3462 + 11143, "Villa Clara");
            (string, double, string) Caiberién = ("Caiberién", 2199 + 6256, "Villa Clara");
            (string, double, string) Remedios = ("Remedios", 2457 + 8565, "Villa Clara");
            (string, double, string) Placetas = ("Placetas", 3828 + 13156, "Villa Clara");
            (string, double, string) SantaClara = ("Santa Clara", 14817 + 44375, "Villa Clara");
            (string, double, string) Cifuentes = ("Cifuentes", 1619 + 5249, "Villa Clara");
            (string, double, string) SantoDomingo = ("Santo Domingo", 2857 + 8891, "Villa Clara");
            (string, double, string) Ranchuelo = ("Ranchuelo", 3070 + 9593, "Villa Clara");
            (string, double, string) Manicaragua = ("Manicaragua", 3782 + 10782, "Villa Clara");

            //Sancti Spiritus
            (string, double, string) Yaguajay = ("Yaguajay", 3302 + 10307, "Sancti Spiritus");
            (string, double, string) Jatibonico = ("Jatibonico", 2411 + 6737, "Sancti Spiritus");
            (string, double, string) Taguasco = ("Taguasco", 1936 + 5620, "Sancti Spiritus");
            (string, double, string) Cabaiguán = ("Cabaiguán", 3810 + 12111, "Sancti Spiritus");
            (string, double, string) Fomento = ("Fomento", 1932 + 6170, "Sancti Spiritus");
            (string, double, string) Trinidad = ("Trinidad", 4436 + 11269, "Sancti Spiritus");
            (string, double, string) SanctiSpíritus = ("Sancti Spíritus", 7926 + 22912, "Sancti Spiritus");
            (string, double, string) LaSierpe = ("LaSierpe", 881 + 2088, "Sancti Spiritus");

            //Holguin
            (string, double, string) Gibara = ("Gibara", 4047 + 12886, "Holguín");
            (string, double, string) RafaelFreyre = ("Rafael Freyre", 2897 + 7842, "Holguín");
            (string, double, string) Banes = ("Banes", 4370 + 12897, "Holguín");
            (string, double, string) Antilla = ("Antilla", 700 + 1872, "Holguín");
            (string, double, string) Báguanos = ("Báguanos", 2706 + 8179, "Holguín");
            (string, double, string) Holguín = ("Holguín", 20460 + 56908, "Holguín");
            (string, double, string) CalixtoGarcía = ("Calixto García", 2755 + 8965, "Holguín");
            (string, double, string) Cacocum = ("Cacocum", 2125 + 5668, "Holguín");
            (string, double, string) UrbanoNoris = ("Urbano Noris", 2170 + 5919, "Holguín");
            (string, double, string) Cueto = ("Cueto", 1754 + 4690, "Holguín");
            (string, double, string) Mayarí = ("Mayarí", 5626 + 15519, "Holguín");
            (string, double, string) FrankPaís = ("Frank País", 1296 + 3446, "Holguín");
            (string, double, string) SaguaTánamo = ("Sagua Tánamo", 2628 + 6923, "Holguín");
            (string, double, string) Moa = ("Moa", 4455 + 8351, "Holguín");

            //Camaguey
            (string, double, string) CarlosManueldeCéspedes = ("Carlos Manuel de Céspedes", 1405 + 3290, "Camagüey");
            (string, double, string) Esmeralda = ("Esmeralda", 1681 + 4512, "Camagüey");
            (string, double, string) SierradeCubitas = ("Sierra de Cubitas", 1067 + 2306, "Camagüey");
            (string, double, string) Minas = ("Minas", 2045 + 5553, "Camagüey");
            (string, double, string) Nuevitas = ("Nuevitas", 3662 + 9301, "Camagüey");
            (string, double, string) Guáimaro = ("Guáimaro", 2301 + 6807, "Camagüey");
            (string, double, string) Sibanicú = ("Sibanicú", 1709 + 4584, "Camagüey");
            (string, double, string) Camagüey = ("Camagüey", 20114 + 55270, "Camagüey");
            (string, double, string) Florida = ("Florida", 4196 + 11149, "Camagüey");
            (string, double, string) Vertientes = ("Vertientes", 2712 + 70042, "Camagüey");
            (string, double, string) Jimaguayú = ("Jimaguayú", 1023 + 2588, "Camagüey");
            (string, double, string) Najasa = ("Najasa", 794 + 2089, "Camagüey");
            (string, double, string) SantaCruzdelSur = ("Santa Cruz del Sur", 2343 + 5964, "Camagüey");

            //Granma
            (string, double, string) RíoCauto = ("Río Cauto", 2486 + 5637, "Granma");
            (string, double, string) CautoCristo = ("Cauto Cristo", 1077 + 2750, "Granma");
            (string, double, string) Jiguaní = ("Jiguaní", 3448 + 9271, "Granma");
            (string, double, string) Bayamo = ("Bayamo", 13575 + 35385, "Granma");
            (string, double, string) Yara = ("Yara", 3212 + 8101, "Granma");
            (string, double, string) Manzanillo = ("Manzanillo", 7561 + 19540, "Granma");
            (string, double, string) Campechuela = ("Campechuela", 2473 + 6417, "Granma");
            (string, double, string) MediaLuna = ("MediaLuna", 1857 + 4830, "Granma");
            (string, double, string) Niquero = ("Niquero", 2249 + 5661, "Granma");
            (string, double, string) Pilón = ("Pilón", 1601 + 3966, "Granma");
            (string, double, string) BartoloméMasó = ("Bartolomé Masó", 2712 + 6813, "Granma");
            (string, double, string) BueyArriba = ("Buey Arriba", 1671 + 4340, "Granma");
            (string, double, string) Guisa = ("Guisa", 2756 + 6802, "Granma");

            //Guantánamo
            (string, double, string) ElSalvador = ("El Salvador", 1995 + 4841, "Guantánamo");
            (string, double, string) ManuelTames = ("Manuel Tames", 1870 + 4649, "Guantánamo");
            (string, double, string) Yateras = ("Yateras", 856 + 1960, "Guantánamo");
            (string, double, string) Baracoa = ("Baracoa", 4395 + 12122, "Guantánamo");
            (string, double, string) Maisí = ("Maisí", 1436 + 3801, "Guantánamo");
            (string, double, string) Imías = ("Imías", 1080 + 2643, "Guantánamo");
            (string, double, string) SanAntoniodelSur = ("San Antonio del Sur", 1232 + 3386, "Guantánamo");
            (string, double, string) Caimanera = ("Caimanera", 606 + 1101, "Guantánamo");
            (string, double, string) Guantánamo = ("Guantánamo", 12851 + 33478, "Guantánamo");
            (string, double, string) NicetoPérez = ("Niceto Pérez", 865 + 2057, "Guantánamo");

            //Santiago de Cuba
            (string, double, string) Contramaestre = ("Contra maestre", 5727 + 15685, "Santiago de Cuba");
            (string, double, string) Mella = ("Mella", 1830 + 4340, "Santiago de Cuba");
            (string, double, string) SanLuis_SC = ("San Luis", 4168 + 10857, "Santiago de Cuba");
            (string, double, string) SegundoFrente = ("Segundo Frente", 2194 + 5547, "Santiago de Cuba");
            (string, double, string) SongoLaMaya = ("Songo La Maya", 4922 + 12107, "Santiago de Cuba");
            (string, double, string) SantiagodeCuba = ("Santiago de Cuba", 29285 + 77580, "Santiago de Cuba");
            (string, double, string) PalmaSoriano = ("Palma Soriano", 6971 + 18888, "Santiago de Cuba");
            (string, double, string) TercerFrente = ("Tercer Frente", 1633 + 3766, "Santiago de Cuba");
            (string, double, string) Guamá = ("Guamá", 1923 + 4006, "Santiago de Cuba");

            //Isla de la Juventud
            (string, double, string) IsladelaJuventud = ("Isla de la Juventud", 4881 + 4237 + 3398 + 2271 + 1148 + 911, "Isla de la Juventud");

            //Las Tunas
            (string, double, string) Manatí = ("Manatí", 1665 + 1369, "Las Tunas");
            (string, double, string) PuertoPadre = ("Puerto Padre", 5153 + 4967, "Las Tunas");
            (string, double, string) JesúsMenéndez = ("Jesús Menéndez", 2775 + 2413, "Las Tunas");
            (string, double, string) Majibacoa = ("Majibacoa", 2293 + 1930, "Las Tunas");
            (string, double, string) LasTunas = ("Las Tunas", 12305 + 10394, "Las Tunas");
            (string, double, string) Jobabo = ("Jobabo", 2291 + 2015, "Las Tunas");
            (string, double, string) Colombia = ("Colombia", 1832 + 1650, "Las Tunas");
            (string, double, string) Amanacio = ("Amanacio", 2147 + 1744, "Las Tunas");

            //Ciego de Ávila
            (string, double, string) Chambas = ("Chambas", 2086 + 6037, "Ciego de Ávila");
            (string, double, string) Morón = ("Morón", 3695 + 9990, "Ciego de Ávila");
            (string, double, string) Bolivia = ("Bolivia", 776 + 1872, "Ciego de Ávila");
            (string, double, string) PrimerodeEnero = ("Primero de Enero", 1152 + 3095, "Ciego de Ávila");
            (string, double, string) CiroRedondo = ("Ciro Redondo", 1609 + 4109, "Ciego de Ávila");
            (string, double, string) Florencia = ("Florencia", 1084 + 3572, "Ciego de Ávila");
            (string, double, string) Majagua = ("Majagua", 1410 + 4017, "Ciego de Ávila");
            (string, double, string) CiegodeÁvila = ("Ciego de Ávila", 9118 + 22688, "Ciego de Ávila");
            (string, double, string) Venezuela = ("Venezuela", 1367 + 3302, "Ciego de Ávila");
            (string, double, string) Baraguá = ("Baraguá", 1367 + 3302, "Ciego de Ávila");

            List<(string, double, string)> dataEdadAdultoMayor = new List<(string, double, string)>()
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

            return dataEdadAdultoMayor;
        }


        public List<(string, double, string)> EdadAdultoJoven()    // 20 - 59 anios
        {

            //Pinar del Rio
            (string, double, string) Sandino = ("Sandino", 2372 + 2378 + 2538 + 2024 + 2010 + 2742 + 3187 + 3400, "Pinar del Rio");
            (string, double, string) Mantua = ("Mantua", 1623 + 1622 + 1583 + 1256 + 1277 + 2070 + 2075 + 1972, "Pinar del Rio");
            (string, double, string) MinasDeMataHambre = ("Minas De Matahambre", 1996 + 2029 + 2188 + 1856 + 1654 + 2436 + 2665 + 2718, "Pinar del Rio");
            (string, double, string) Viniales = ("Viñales", 1875 + 1873 + 2068 + 1746 + 1704 + 2169 + 2400 + 2310, "Pinar del Rio");
            (string, double, string) LaPalma = ("La Palma", 2157 + 2205 + 2267 + 1964 + 1947 + 2606 + 2863 + 2887, "Pinar del Rio");
            (string, double, string) LosPalacios = ("Los Palacios", 2517 + 2506 + 2675 + 2310 + 2231 + 3227 + 3345 + 3268, "Pinar del Rio");
            (string, double, string) ConsolacionDelSur = ("Consolación del Sur", 5429 + 5814 + 5872 + 5239 + 5036 + 7119 + 7377 + 7299, "Pinar del Rio");
            (string, double, string) PinarDelRio = ("Pinar del Río", 12167 + 11658 + 13322 + 11501 + 10588 + 13982 + 15617 + 16940, "Pinar del Rio");
            (string, double, string) SanLuis_PR = ("San Luis", 2058 + 2028 + 2219 + 2038 + 1757 + 2422 + 2718 + 2743, "Pinar del Rio");
            (string, double, string) SanJuanYMartinez = ("San Juan y Martínez", 2862 + 2697 + 2964 + 2478 + 2474 + 3295 + 3641 + 3658, "Pinar del Rio");
            (string, double, string) Guane = ("Guane", 2319 + 2305 + 2545 + 2004 + 1924 + 2881 + 3320 + 3062, "Pinar del Rio");

            //Artemisa
            (string, double, string) BahiaHonda = ("Bahía Honda", 2973 + 2857 + 3152 + 2672 + 2650 + 3504 + 3429 + 3498, "Artemisa");
            (string, double, string) Mariel = ("Mariel", 3164 + 3064 + 3414 + 3007 + 2741 + 3580 + 3687 + 3713, "Artemisa");
            (string, double, string) Guanajay = ("Guanajay", 1843 + 1768 + 2023 + 1903 + 1512 + 2073 + 2266 + 2568, "Artemisa");
            (string, double, string) Caimito = ("Caimito", +2852 + 2855 + 3183 + 2822 + 2448 + 3450 + 3580 + 3678, "Artemisa");
            (string, double, string) Bauta = ("Bauta", 3321 + 3470 + 3901 + 3432 + 2768 + 3865 + 4155 + 4757, "Artemisa");
            (string, double, string) SanAntonioDeLosBanios = ("San Antonio de los Baños", 3231 + 3513 + 3972 + 3535 + 2922 + 4140 + 4181 + 4683, "Artemisa");
            (string, double, string) GuiradeMelena = ("Güira de Melena", 2693 + 2839 + 3099 + 2656 + 2303 + 3371 + 3254 + 3436, "Artemisa");
            (string, double, string) Alquizar = ("Alquízar", 2278 + 2404 + 2672 + 2253 + 2009 + 2554 + 2821 + 2747, "Artemisa");
            (string, double, string) Artemisa = ("Artemisa", 5906 + 5974 + 6491 + 5531 + 4828 + 6843 + 7518 + 7559, "Artemisa");
            (string, double, string) Candelaria = ("Candelaria", 1465 + 1485 + 1665 + 1321 + 1250 + 1637 + 1897 + 1721, "Artemisa");
            (string, double, string) SanCristobal = ("San Cristóbal", 5218 + 4696 + 5301 + 4419 + 4183 + 5744 + 6002 + 6192, "Artemisa");

            //La Habana
            (string, double, string) Playa = ("Playa", 10812 + 10981 + 12852 + 11214 + 9373 + 13189 + 15173 + 18823, "La Habana");
            (string, double, string) PlazadelaRevolución = ("Plaza de la Revolución", 7924 + 8240 + 9925 + 8454 + 6857 + 9950 + 11753 + 15341, "La Habana");
            (string, double, string) CentroHabana = ("Centro Habana", 8023 + 8125 + 10191 + 8869 + 7487 + 10304 + 11550 + 13722, "La Habana");
            (string, double, string) HabanaVieja = ("Habana Vieja", 4814 + 5197 + 6130 + 5469 + 4662 + 6417 + 7303 + 7978, "La Habana");
            (string, double, string) Regla = ("Regla", 2698 + 2787 + 3357 + 3042 + 2336 + 3357 + 3647 + 4170, "La Habana");
            (string, double, string) HabanadelEste = ("Habana del Este", 10447 + 10989 + 12372 + 11041 + 9202 + 13464 + 14058 + 16075, "La Habana");
            (string, double, string) Guanabacoa = ("Guanabacoa", 7978 + 8144 + 9554 + 8503 + 6892 + 9640 + 10646 + 11850, "La Habana");
            (string, double, string) SanMigueldelPadron = ("San Miguel del Padron", 9976 + 10456 + 12310 + 10886 + 9459 + 12371 + 13195 + 14288, "La Habana");
            (string, double, string) DiezdeOctubre = ("Diez de Octubre", 11756 + 12204 + 13765 + 12307 + 10144 + 14291 + 16692 + 21069, "La Habana");
            (string, double, string) Cerro = ("Cerro", 7165 + 7811 + 9228 + 8186 + 6744 + 9050 + 10611 + 12661, "La Habana");
            (string, double, string) Marianao = ("Marianao", 8337 + 8606 + 9865 + 9169 + 7247 + 10166 + 11325 + 13451, "La Habana");
            (string, double, string) LaLisa = ("La Lisa", 9482 + 9172 + 10490 + 9772 + 8231 + 11126 + 12132 + 13500, "La Habana");
            (string, double, string) Boyeros = ("Boyeros", 12693 + 12947 + 15083 + 13189 + 11075 + 15067 + 17110 + 19263, "La Habana");
            (string, double, string) ArroyoNaranjo = ("ArroyoNaranjo", 12589 + 13571 + 15561 + 13663 + 11584 + 16011 + 16724 + 19100, "La Habana");
            (string, double, string) Cotorro = ("Cotorro", 5249 + 5496 + 6193 + 5542 + 4413 + 6019 + 6605 + 7576, "La Habana");

            //Mayabeque
            (string, double, string) Bejucal = ("Bejucal", 1807 + 1947 + 2033 + 1889 + 1650 + 2221 + 2444 + 2423, "Mayabeque");
            (string, double, string) SanJosédelasLajas = ("San José de las Lajas", 5051 + 5198 + 6087 + 5506 + 4562 + 6219 + 6854 + 6845, "Mayabeque");
            (string, double, string) Jaruco = ("Jaruco", 1449 + 1673 + 1738 + 1517 + 1329 + 1799 + 2193 + 2250, "Mayabeque");
            (string, double, string) SantaCruzdelNorte = ("Santa Cruz del Norte", 2098 + 2355 + 2448 + 2304 + 1996 + 2781 + 3010 + 3197, "Mayabeque");
            (string, double, string) Madruga = ("Madruga", 1541 + 1919 + 1920 + 1609 + 1458 + 2181 + 2252 + 2407, "Mayabeque");
            (string, double, string) NuevaPaz = ("Nueva Paz", 1502 + 1529 + 1684 + 1630 + 1247 + 1792 + 2004 + 2137, "Mayabeque");
            (string, double, string) SanNicolás = ("San Nicolás", 1321 + 1375 + 1568 + 1413 + 1099 + 1560 + 1676 + 1977, "Mayabeque");
            (string, double, string) Güines = ("Güines", 4019 + 4133 + 4849 + 4420 + 3701 + 5051 + 5352 + 6117, "Mayabeque");
            (string, double, string) MelenadelSur = ("Melena del Sur", 1322 + 1490 + 1559 + 1366 + 1017 + 1597 + 1815 + 1766, "Mayabeque");
            (string, double, string) Batabanó = ("Batabanó", 1813 + 1880 + 2030 + 1843 + 1603 + 2266 + 2348 + 2213, "Mayabeque");
            (string, double, string) Quivicán = ("Quivicán", 1917 + 2051 + 2277 + 2036 + 1635 + 2439 + 2568 + 2513, "Mayabeque");

            //Matanzas
            (string, double, string) Matanzas = ("Matanzas", 162964 - 10262 - 11904 - 10749 - 10262 - 11904 - 10749, "Matanzas");            //...............................
            (string, double, string) Cárdenas = ("Cárdenas", 158080 - 9765 - 10419 - 12613 - 9765 - 10419 - 12613, "Matanzas");
            (string, double, string) Martí = ("Martí", 21652 - 1331 - 1412 - 1636 - 1331 - 1412 - 1636, "Matanzas");
            (string, double, string) Colón = ("Colón", 68403 - 4591 - 4592 - 4867 - 4591 - 4592 - 4867, "Matanzas");
            (string, double, string) Perico = ("Perico", 29907 - 1856 - 2010 - 2196 - 1856 - 2010 - 2196, "Matanzas");
            (string, double, string) Jovellanos = ("Jovellanos", 57381 - 3577 - 3781 - 4061 - 3577 - 3781 - 4061, "Matanzas");
            (string, double, string) PedroBetancourt = ("Pedro Betancourt", 29838 - 1838 - 1965 - 2008 - 1838 - 1965 - 2008, "Matanzas");//es una aproximacion ya que no se cuenta con
            (string, double, string) Limonar = ("Limonar", 26633 - 1677 - 1870 - 1895 - 1677 - 1870 - 1895, "Matanzas");                 //los datos exactos de la cantidad de mayores de 34 años
            (string, double, string) UnióndeReyes = ("Unión de Reyes", 35251 - 2221 - 2241 - 2275 - 2221 - 2241 - 2275, "Matanzas");
            (string, double, string) CiénagadeZapata = ("Ciénaga de Zapata", 10394 - 723 - 668 - 799 - 723 - 668 - 799, "Matanzas");
            (string, double, string) JagueyGrande = ("Jaguey Grande", 59736 - 3933 - 3554 - 4324 - 3933 - 3554 - 4324, "Matanzas");
            (string, double, string) Calimete = ("Calimete", 27493 - 1945 - 1836 - 2004 - 1945 - 1836 - 2004, "Matanzas");
            (string, double, string) LosArabos = ("Los Arabos", 23336 - 1414 - 1505 - 1771 - 1414 - 1505 - 1771, "Matanzas");

            //Cienfuegos
            (string, double, string) AguadadePasajeros = ("Aguada de Pasajeros", 1068 + 970 + 1149 + 983 + 986 + 1011 + 1027 + 966 + 1275 + 1310 + 1304 + 986 + 849 + 1263 + 1286 + 1326, "Cienfuegos");
            (string, double, string) Rodas = ("Rodas", 1004 + 1119 + 1256 + 950 + 998 + 1134 + 1104 + 992 + 1337 + 1488 + 1522 + 971 + 949 + 1295 + 1472 + 1463, "Cienfuegos");
            (string, double, string) Palmira = ("Palmira", 1070 + 1067 + 1226 + 991 + 1027 + 1105 + 1000 + 890 + 1305 + 1475 + 1471 + 902 + 845 + 1288 + 1428 + 1404, "Cienfuegos");
            (string, double, string) Lajas = ("Lajas", 691 + 731 + 757 + 658 + 624 + 665 + 682 + 628 + 833 + 974 + 929 + 659 + 553 + 804 + 930 + 888, "Cienfuegos");
            (string, double, string) Cruces = ("Cruces", 953 + 915 + 992 + 872 + 764 + 943 + 953 + 753 + 1214 + 1382 + 1376 + 864 + 699 + 1085 + 1338 + 1395, "Cienfuegos");
            (string, double, string) Cumanayagua = ("Cumanayagua", 1531 + 1460 + 1742 + 1446 + 1383 + 1569 + 1531 + 1399 + 1991 + 2163 + 2239 + 1416 + 1189 + 1872 + 2146 + 2089, "Cienfuegos");
            (string, double, string) Cienfuegos = ("Cienfuegos", 5671 + 5752 + 6589 + 5405 + 5760 + 6406 + 5876 + 4700 + 6590 + 7543 + 8310 + 5889 + 4631 + 6863 + 8122 + 8980, "Cienfuegos");
            (string, double, string) Abreus = ("Abreus", 991 + 980 + 1187 + 850 + 948 + 1031 + 1024 + 868 + 1298 + 1418 + 1299 + 963 + 821 + 1161 + 1303 + 1298, "Cienfuegos");

            //Villa Clara
            (string, double, string) Corralillo = ("Corralillo", 1636 + 1589 + 1609 + 1327 + 1332 + 2030 + 2359 + 2266, "Villa Clara");
            (string, double, string) QuemadodeGüines = ("Quemado de Güines", 1281 + 1220 + 1329 + 1098 + 1160 + 1692 + 1954 + 1793, "Villa Clara");
            (string, double, string) SagualaGrande = ("Sagua la Grande", 3117 + 3189 + 3210 + 2891 + 2705 + 3909 + 4496 + 4535, "Villa Clara");
            (string, double, string) Encrucijada = ("Encrucijada", 2015 + 1885 + 2083 + 1798 + 1697 + 2507 + 2778 + 2877, "Villa Clara");
            (string, double, string) Camajuaní = ("Camajuaní", 3914 + 3418 + 3825 + 3229 + 3116 + 4596 + 5257 + 5087, "Villa Clara");
            (string, double, string) Caiberién = ("Caiberién", 2715 + 2410 + 2819 + 2511 + 2355 + 3387 + 3752 + 3506, "Villa Clara");
            (string, double, string) Remedios = ("Remedios", 2891 + 2527 + 2788 + 2263 + 2352 + 3503 + 4040 + 3843, "Villa Clara");
            (string, double, string) Placetas = ("Placetas", 4311 + 3908 + 4178 + 3762 + 3356 + 4911 + 6108 + 5744, "Villa Clara");
            (string, double, string) SantaClara = ("Santa Clara", 15332 + 14699 + 17534 + 14921 + 12366 + 17203 + 21221 + 22917, "Villa Clara");
            (string, double, string) Cifuentes = ("Cifuentes", 1666 + 1565 + 1740 + 1455 + 1391 + 2090 + 2334 + 2396, "Villa Clara");
            (string, double, string) SantoDomingo = ("Santo Domingo", 3122 + 2864 + 3218 + 2625 + 2506 + 3789 + 4429 + 4389, "Villa Clara");
            (string, double, string) Ranchuelo = ("Ranchuelo", 3224 + 3152 + 3525 + 3164 + 2702 + 3941 + 4423 + 4736, "Villa Clara");
            (string, double, string) Manicaragua = ("Manicaragua", 3860 + 3857 + 4394 + 3647 + 3343 + 4990 + 5611 + 5618, "Villa Clara");

            //Sancti Spiritus
            (string, double, string) Yaguajay = ("Yaguajay", 2950 + 3219 + 3635 + 3110 + 2883 + 4409 + 5320 + 4851, "Sancti Spiritus");
            (string, double, string) Jatibonico = ("Jatibonico", 2628 + 2598 + 2897 + 2517 + 2384 + 3489 + 3905 + 3529, "Sancti Spiritus");
            (string, double, string) Taguasco = ("Taguasco", 1950 + 2026 + 2251 + 2096 + 1755 + 2728 + 3110 + 2914, "Sancti Spiritus");
            (string, double, string) Cabaiguán = ("Cabaiguán", 3819 + 3693 + 4272 + 3932 + 3428 + 5181 + 6041 + 5731, "Sancti Spiritus");
            (string, double, string) Fomento = ("Fomento", 1723 + 1961 + 2083 + 1855 + 1678 + 2439 + 2865 + 2960, "Sancti Spiritus");
            (string, double, string) Trinidad = ("Trinidad", 4689 + 4776 + 5476 + 4875 + 4273 + 6657 + 7063 + 6306, "Sancti Spiritus");
            (string, double, string) SanctiSpíritus = ("Sancti Spíritus", 8389 + 8626 + 9564 + 8694 + 8012 + 11651 + 13501 + 12585, "Sancti Spiritus");
            (string, double, string) LaSierpe = ("LaSierpe", 1095 + 1081 + 1266 + 1031 + 972 + 1431 + 1640 + 1309, "Sancti Spiritus");

            //Holguin
            (string, double, string) Gibara = ("Gibara", 3970 + 4184 + 4487 + 4216 + 4031 + 6028 + 6403 + 5837, "Holguín");
            (string, double, string) RafaelFreyre = ("Rafael Freyre", 3267 + 3357 + 3792 + 3415 + 2926 + 5074 + 5032 + 4354, "Holguín");
            (string, double, string) Banes = ("Banes", 4682 + 4397 + 5156 + 4750 + 4253 + 6462 + 7570 + 6694, "Holguín");
            (string, double, string) Antilla = ("Antilla", 803 + 719 + 886 + 827 + 738 + 1004 + 1144 + 986, "Holguín");
            (string, double, string) Báguanos = ("Báguanos", 2896 + 2882 + 3268 + 2905 + 2513 + 4085 + 4451 + 3913, "Holguín");
            (string, double, string) Holguín = ("Holguín", 21930 + 20963 + 24248 + 22498 + 19169 + 29063 + 31855 + 30494, "Holguín");
            (string, double, string) CalixtoGarcía = ("Calixto García", 3368 + 3120 + 3594 + 2991 + 3231 + 4891 + 5037 + 4262, "Holguín");
            (string, double, string) Cacocum = ("Cacocum", 2347 + 2273 + 2844 + 2396 + 2275 + 3684 + 3754 + 3144, "Holguín");
            (string, double, string) UrbanoNoris = ("Urbano Noris", 2324 + 2414 + 2744 + 2379 + 2102 + 3289 + 3549 + 3141, "Holguín");
            (string, double, string) Cueto = ("Cueto", 2026 + 1967 + 2094 + 1894 + 1599 + 2762 + 2874 + 2609, "Holguín");
            (string, double, string) Mayarí = ("Mayarí", 5686 + 5450 + 6660 + 5730 + 5081 + 8012 + 8711 + 8025, "Holguín");
            (string, double, string) FrankPaís = ("Frank País", 1385 + 1332 + 1613 + 1276 + 1241 + 2101 + 2198 + 1788, "Holguín");
            (string, double, string) SaguaTánamo = ("Sagua Tánamo", 2496 + 3940 + 4325 + 3534, "Holguín");
            (string, double, string) Moa = ("Moa", 3904 + 5586 + 6312 + 6268, "Holguín");

            //Camaguey
            (string, double, string) CarlosManueldeCéspedes = ("Carlos Manuel de Céspedes", 1485 + 1321 + 1743 + 1567 + 1373 + 1970 + 1985 + 2073, "Camagüey");
            (string, double, string) Esmeralda = ("Esmeralda", 1761 + 2004 + 2072 + 1858 + 1625 + 2423 + 2681 + 2491, "Camagüey");
            (string, double, string) SierradeCubitas = ("Sierra de Cubitas", 1224 + 1041 + 1365 + 1235 + 1166 + 1488 + 1688 + 1544, "Camagüey");
            (string, double, string) Minas = ("Minas", 2108 + 2373 + 2643 + 2455 + 2088 + 2877 + 3426 + 3144, "Camagüey");
            (string, double, string) Nuevitas = ("Nuevitas", 3691 + 3694 + 4121 + 3766 + 3639 + 4957 + 5811 + 5211, "Camagüey");
            (string, double, string) Guáimaro = ("Guáimaro", 1926 + 1990 + 2266 + 2155 + 2105 + 3217 + 3565 + 3244, "Camagüey");
            (string, double, string) Sibanicú = ("Sibanicú", 1789 + 1716 + 2151 + 1855 + 1668 + 2489 + 2804 + 2477, "Camagüey");
            (string, double, string) Camagüey = ("Camagüey", 20000 + 18883 + 23798 + 20986 + 17865 + 25608 + 28451 + 30384, "Camagüey");
            (string, double, string) Florida = ("Florida", 4007 + 4179 + 5006 + 4501 + 4032 + 5876 + 6009 + 6522, "Camagüey");
            (string, double, string) Vertientes = ("Vertientes", 3079 + 3014 + 3662 + 3008 + 2836 + 4328 + 4393 + 4381, "Camagüey");
            (string, double, string) Jimaguayú = ("Jimaguayú", 1345 + 1203 + 1497 + 1288 + 1200 + 1833 + 1844 + 1656, "Camagüey");
            (string, double, string) Najasa = ("Najasa", 1014 + 951 + 1068 + 951 + 949 + 1305 + 1383 + 1306, "Camagüey");
            (string, double, string) SantaCruzdelSur = ("Santa Cruz del Sur", 2664 + 2563 + 2757 + 2520 + 2510 + 3517 + 3737 + 3750, "Camagüey");

            //Granma
            (string, double, string) RíoCauto = ("Río Cauto", 3134 + 2748 + 3423 + 3090 + 2641 + 4077 + 4138 + 3569, "Granma");
            (string, double, string) CautoCristo = ("Cauto Cristo", 1221 + 1309 + 1518 + 1329 + 1124 + 1743 + 1830 + 1579, "Granma");
            (string, double, string) Jiguaní = ("Jiguaní", 3803 + 3808 + 3830 + 3709 + 3194 + 4898 + 5229 + 4927, "Granma");
            (string, double, string) Bayamo = ("Bayamo", 14959 + 14383 + 16996 + 15889 + 13376 + 19496 + 21084 + 19411, "Granma");
            (string, double, string) Yara = ("Yara", 3471 + 3539 + 3883 + 3528 + 3057 + 4704 + 4940 + 4555, "Granma");
            (string, double, string) Manzanillo = ("Manzanillo", 7360 + 7786 + 8928 + 7840 + 6886 + 9668 + 10785 + 11009, "Granma");
            (string, double, string) Campechuela = ("Campechuela", 2583 + 2790 + 3056 + 2450 + 2259 + 3488 + 3995 + 3500, "Granma");
            (string, double, string) MediaLuna = ("MediaLuna", 2120 + 2007 + 2152 + 1960 + 1695 + 2768 + 3079 + 2607, "Granma");
            (string, double, string) Niquero = ("Niquero", 3124 + 2559 + 2987 + 2696 + 2163 + 3327 + 3726 + 3165, "Granma");
            (string, double, string) Pilón = ("Pilón", 2073 + 1659 + 2068 + 1856 + 1688 + 2441 + 2547 + 2213, "Granma");
            (string, double, string) BartoloméMasó = ("Bartolomé Masó", 3027 + 2764 + 3120 + 2912 + 2729 + 4176 + 4470 + 3821, "Granma");
            (string, double, string) BueyArriba = ("Buey Arriba", 2025 + 1745 + 2000 + 2079 + 1927 + 2746 + 2634 + 2356, "Granma");
            (string, double, string) Guisa = ("Guisa", 2749 + 2662 + 3237 + 2986 + 2677 + 3837 + 4056 + 3526, "Granma");

            //Guantánamo
            (string, double, string) ElSalvador = ("El Salvador", 3121 + 3139 + 3016 + 2661 + 2361 + 3416 + 3501 + 2848, "Guantánamo");
            (string, double, string) ManuelTames = ("Manuel Tames", 2733 + 2600 + 2682 + 2445 + 2001 + 2875 + 3130 + 2636, "Guantánamo");
            (string, double, string) Yateras = ("Yateras", 1452 + 1338 + 1468 + 1250 + 1119 + 1452 + 1596 + 1286, "Guantánamo");
            (string, double, string) Baracoa = ("Baracoa", 5536 + 5289 + 5416 + 5140 + 4065 + 5902 + 6861 + 6157, "Guantánamo");
            (string, double, string) Maisí = ("Maisí", 1945 + 1853 + 2068 + 1983 + 1578 + 2021 + 2513 + 2120, "Guantánamo");
            (string, double, string) Imías = ("Imías", 1536 + 1506 + 1585 + 1277 + 1167 + 1530 + 1706 + 1570, "Guantánamo");
            (string, double, string) SanAntoniodelSur = ("San Antonio del Sur", 1806 + 1766 + 1839 + 1546 + 1457 + 1946 + 2072 + 1778, "Guantánamo");
            (string, double, string) Caimanera = ("Caimanera", 826 + 794 + 920 + 743 + 573 + 839 + 913 + 863, "Guantánamo");
            (string, double, string) Guantánamo = ("Guantánamo", 14640 + 14518 + 16284 + 15234 + 12223 + 16352 + 18108 + 17724, "Guantánamo");
            (string, double, string) NicetoPérez = ("Niceto Pérez", 1081 + 1205 + 1161 + 959 + 962 + 1304 + 1396 + 1214, "Guantánamo");

            //Santiago de Cuba
            (string, double, string) Contramaestre = ("Contra maestre", 6272 + 6588 + 7761 + 7039 + 5664 + 8548 + 9511 + 8068, "Santiago de Cuba");
            (string, double, string) Mella = ("Mella", 2074 + 2288 + 2754 + 2330 + 1853 + 2668 + 3090 + 2601, "Santiago de Cuba");
            (string, double, string) SanLuis_SC = ("San Luis", 4860 + 4808 + 5571 + 5269 + 4418 + 6369 + 7004 + 5916, "Santiago de Cuba");
            (string, double, string) SegundoFrente = ("Segundo Frente", 2512 + 2567 + 2910 + 2454 + 2209 + 3374 + 3558 + 2877, "Santiago de Cuba");
            (string, double, string) SongoLaMaya = ("Songo La Maya", 6260 + 6195 + 6469 + 5915 + 5110 + 7295 + 8015 + 6561, "Santiago de Cuba");
            (string, double, string) SantiagodeCuba = ("Santiago de Cuba", 30610 + 30703 + 36665 + 35040 + 27999 + 39678 + 42849 + 42304, "Santiago de Cuba");
            (string, double, string) PalmaSoriano = ("Palma Soriano", 7008 + 7352 + 8435 + 8032 + 6248 + 9756 + 11087 + 9861, "Santiago de Cuba");
            (string, double, string) TercerFrente = ("Tercer Frente", 1921 + 1882 + 2163 + 2074 + 1777 + 2637 + 2792 + 2191, "Santiago de Cuba");
            (string, double, string) Guamá = ("Guamá", 2335 + 2183 + 2415 + 2198 + 1965 + 2804 + 2837 + 2587, "Santiago de Cuba");

            //Isla de la Juventud
            (string, double, string) IsladelaJuventud = ("Isla de la Juventud", 5347 + 5449 + 5857 + 5318 + 4693 + 6590 + 7933 + 6992, "Isla de la Juventud");

            //Las Tunas
            (string, double, string) Manatí = ("Manatí", 1662 + 1860 + 2149 + 1870 + 1626 + 2397 + 2676 + 2392, "Las Tunas");
            (string, double, string) PuertoPadre = ("Puerto Padre", 5214 + 5718 + 6605 + 5992 + 4730 + 7274 + 8592 + 7565, "Las Tunas");
            (string, double, string) JesúsMenéndez = ("Jesús Menéndez", 2501 + 2999 + 3520 + 3006 + 2636 + 4052 + 4577 + 4014, "Las Tunas");
            (string, double, string) Majibacoa = ("Majibacoa", 2549 + 2570 + 2858 + 2666 + 2249 + 3451 + 3906 + 3367, "Las Tunas");
            (string, double, string) LasTunas = ("Las Tunas", 13590 + 12983 + 15285 + 13664 + 11958 + 17171 + 18809 + 17681, "Las Tunas");
            (string, double, string) Jobabo = ("Jobabo", 2494 + 2827 + 3016 + 2531 + 2498 + 3677 + 3719 + 3169, "Las Tunas");
            (string, double, string) Colombia = ("Colombia", 1953 + 2161 + 2212 + 2060 + 1955 + 2532 + 2905 + 2783, "Las Tunas");
            (string, double, string) Amanacio = ("Amanacio", 2176 + 2529 + 2687 + 2480 + 2324 + 3211 + 3276 + 3073, "Las Tunas");

            //Ciego de Ávila
            (string, double, string) Chambas = ("Chambas", 2214 + 2426 + 2703 + 2379 + 2231 + 2990 + 3283 + 3022, "Ciego de Ávila");
            (string, double, string) Morón = ("Morón", 4215 + 4577 + 5497 + 4656 + 4316 + 5771 + 6206 + 5779, "Ciego de Ávila");
            (string, double, string) Bolivia = ("Bolivia", 959 + 1111 + 1276 + 1032 + 876 + 1228 + 1235 + 1154, "Ciego de Ávila");
            (string, double, string) PrimerodeEnero = ("Primero de Enero", 1234 + 1572 + 1768 + 1457 + 1287 + 1806 + 2021 + 1844, "Ciego de Ávila");
            (string, double, string) CiroRedondo = ("Ciro Redondo", 1883 + 2147 + 2612 + 1903 + 1908 + 2409 + 2632 + 2417, "Ciego de Ávila");
            (string, double, string) Florencia = ("Florencia", 986 + 1208 + 1328 + 1096 + 1113 + 1572 + 1705 + 1462, "Ciego de Ávila");
            (string, double, string) Majagua = ("Majagua", 1531 + 1555 + 1845 + 1541 + 1414 + 2070 + 2215 + 2038, "Ciego de Ávila");
            (string, double, string) CiegodeÁvila = ("Ciego de Ávila", 9737 + 9424 + 11742 + 10409 + 9215 + 12809 + 13574 + 13253, "Ciego de Ávila");
            (string, double, string) Venezuela = ("Venezuela", 1567 + 1657 + 2050 + 1707 + 1518 + 2149 + 2279 + 2039, "Ciego de Ávila");
            (string, double, string) Baraguá = ("Baraguá", 2017 + 2101 + 2449 + 2038 + 2028 + 2623 + 2779 + 2440, "Ciego de Ávila");

            List<(string, double, string)> dataEdadAdultoJoven = new List<(string, double, string)>()
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

            return dataEdadAdultoJoven;
        }



        public List<(string, double, string)> EdadMujerFertil()    // Mujeres 15 - 34 anios
        {

            //Pinar del Rio
            (string, double, string) Sandino = ("Sandino", 958 + 1117 + 1126 + 1232, "Pinar del Rio");
            (string, double, string) Mantua = ("Mantua", 640 + 758 + 677 + 737, "Pinar del Rio");
            (string, double, string) MinasDeMataHambre = ("Minas De Matahambre", 882 + 904 + 972 + 983, "Pinar del Rio");
            (string, double, string) Viniales = ("Viñales", 849 + 940 + 865 + 968, "Pinar del Rio");
            (string, double, string) LaPalma = ("La Palma", 953 + 1032 + 1045 + 1116, "Pinar del Rio");
            (string, double, string) LosPalacios = ("Los Palacios", 1031 + 1208 + 1212 + 1275, "Pinar del Rio");
            (string, double, string) ConsolacionDelSur = ("Consolación del Sur", 2337 + 2611 + 2803 + 2787, "Pinar del Rio");
            (string, double, string) PinarDelRio = ("Pinar del Río", 5136 + 6039 + 5709 + 6527, "Pinar del Rio");
            (string, double, string) SanLuis_PR = ("San Luis", 889 + 971 + 983 + 969, "Pinar del Rio");
            (string, double, string) SanJuanYMartinez = ("San Juan y Martínez", 1222 + 1369 + 1290 + 1416, "Pinar del Rio");
            (string, double, string) Guane = ("Guane", 966 + 1097 + 1085 + 1205, "Pinar del Rio");

            //Artemisa
            (string, double, string) BahiaHonda = ("Bahía Honda", 1212 + 1427 + 1302 + 1412, "Artemisa");
            (string, double, string) Mariel = ("Mariel", 1251 + 1586 + 1473 + 1652, "Artemisa");
            (string, double, string) Guanajay = ("Guanajay", 720 + 909 + 876 + 1032, "Artemisa");
            (string, double, string) Caimito = ("Caimito", 1094 + 1391 + 1410 + 1519, "Artemisa");
            (string, double, string) Bauta = ("Bauta", 1369 + 1625 + 1744 + 1879, "Artemisa");
            (string, double, string) SanAntonioDeLosBanios = ("San Antonio de los Baños", 1303 + 1657 + 1681 + 1886, "Artemisa");
            (string, double, string) GuiradeMelena = ("Güira de Melena", 1111 + 1277 + 1374 + 1428, "Artemisa");
            (string, double, string) Alquizar = ("Alquízar", 887 + 1145 + 1116 + 1243, "Artemisa");
            (string, double, string) Artemisa = ("Artemisa", 2334 + 2925 + 2867 + 3151, "Artemisa");
            (string, double, string) Candelaria = ("Candelaria", 624 + 681 + 698 + 802, "Artemisa");
            (string, double, string) SanCristobal = ("San Cristóbal", 2061 + 2514 + 2264 + 2594 + 2103, "Artemisa");

            //La Habana
            (string, double, string) Playa = ("Playa", 4234 + 5304 + 5486 + 6460, "La Habana");
            (string, double, string) PlazadelaRevolución = ("Plaza de la Revolución", 3044 + 3965 + 4105 + 5010, "La Habana");
            (string, double, string) CentroHabana = ("Centro Habana", 3140 + 4061 + 4008 + 4999, "La Habana");
            (string, double, string) HabanaVieja = ("Habana Vieja", 1874 + 2436 + 2493 + 3021, "La Habana");
            (string, double, string) Regla = ("Regla", 1130 + 1354 + 1422 + 1682, "La Habana");
            (string, double, string) HabanadelEste = ("Habana del Este", 4256 + 5159 + 5425 + 6085, "La Habana");
            (string, double, string) Guanabacoa = ("Guanabacoa", 3298 + 3959 + 4076 + 4753, "La Habana");
            (string, double, string) SanMigueldelPadron = ("San Miguel del Padron", 4481 + 4969 + 5192 + 6125, "La Habana");
            (string, double, string) DiezdeOctubre = ("Diez de Octubre", 4905 + 5864 + 6072 + 6873, "La Habana");
            (string, double, string) Cerro = ("Cerro", 2943 + 3545 + 3908 + 4605, "La Habana");
            (string, double, string) Marianao = ("Marianao", 3518 + 4144 + 4187 + 4939, "La Habana");
            (string, double, string) LaLisa = ("La Lisa", 4096 + 4661 + 4444 + 5261, "La Habana");
            (string, double, string) Boyeros = ("Boyeros", 5474 + 6298 + 6259 + 7398, "La Habana");
            (string, double, string) ArroyoNaranjo = ("ArroyoNaranjo", 5336 + 6147 + 6546 + 7705, "La Habana");
            (string, double, string) Cotorro = ("Cotorro", 2155 + 2527 + 2724 + 3002, "La Habana");

            //Mayabeque
            (string, double, string) Bejucal = ("Bejucal", 730 + 824 + 920 + 987, "Mayabeque");
            (string, double, string) SanJosédelasLajas = ("San José de las Lajas", 2200 + 2323 + 2361 + 2853, "Mayabeque");
            (string, double, string) Jaruco = ("Jaruco", 575 + 742 + 780 + 879, "Mayabeque");
            (string, double, string) SantaCruzdelNorte = ("Santa Cruz del Norte", 923 + 1021 + 1157 + 1179, "Mayabeque");
            (string, double, string) Madruga = ("Madruga", 604 + 759 + 921 + 894, "Mayabeque");
            (string, double, string) NuevaPaz = ("Nueva Paz", 553 + 752 + 704 + 806, "Mayabeque");
            (string, double, string) SanNicolás = ("San Nicolás", 526 + 671 + 684 + 721, "Mayabeque");
            (string, double, string) Güines = ("Güines", 1740 + 1944 + 1989 + 2355, "Mayabeque");
            (string, double, string) MelenadelSur = ("Melena del Sur", 515 + 661 + 664 + 740, "Mayabeque");
            (string, double, string) Batabanó = ("Batabanó", 721 + 893 + 878 + 967, "Mayabeque");
            (string, double, string) Quivicán = ("Quivicán", 830 + 903 + 952 + 1104, "Mayabeque");

            //Matanzas
            (string, double, string) Matanzas = ("Matanzas", 5307 + 5069 + 5846 + 5415, "Matanzas");
            (string, double, string) Cárdenas = ("Cárdenas", 3942 + 5018 + 5070 + 6071, "Matanzas");
            (string, double, string) Martí = ("Martí", 502 + 632 + 669 + 776, "Matanzas");
            (string, double, string) Colón = ("Colón", 1730 + 2183 + 2220 + 2343, "Matanzas");
            (string, double, string) Perico = ("Perico", 832 + 851 + 952 + 1047, "Matanzas");
            (string, double, string) Jovellanos = ("Jovellanos", 1414 + 1644 + 1819 + 1931, "Matanzas");
            (string, double, string) PedroBetancourt = ("Pedro Betancourt", 633 + 884 + 984 + 978, "Matanzas");
            (string, double, string) Limonar = ("Limonar", 674 + 816 + 924 + 866, "Matanzas");
            (string, double, string) UnióndeReyes = ("Unión de Reyes", 886 + 1125 + 1152 + 1200, "Matanzas");
            (string, double, string) CiénagadeZapata = ("Ciénaga de Zapata", 275 + 365 + 336 + 393, "Matanzas");
            (string, double, string) JagueyGrande = ("Jaguey Grande", 1528 + 1917 + 1682 + 2110, "Matanzas");
            (string, double, string) Calimete = ("Calimete", 627 + 926 + 878 + 935, "Matanzas");
            (string, double, string) LosArabos = ("Los Arabos", 575 + 687 + 676 + 870, "Matanzas");

            //Cienfuegos
            (string, double, string) AguadadePasajeros = ("Aguada de Pasajeros", 910 + 983 + 986 + 1011, "Cienfuegos");
            (string, double, string) Rodas = ("Rodas", 922 + 1004 + 1119 + 1256, "Cienfuegos");
            (string, double, string) Palmira = ("Palmira", 907 + 991 + 1027 + 1105, "Cienfuegos");
            (string, double, string) Lajas = ("Lajas", 588 + 658 + 624 + 665, "Cienfuegos");
            (string, double, string) Cruces = ("Cruces", 784 + 872 + 764 + 943, "Cienfuegos");
            (string, double, string) Cumanayagua = ("Cumanayagua", 1194 + 1446 + 1383 + 1569, "Cienfuegos");
            (string, double, string) Cienfuegos = ("Cienfuegos", 4762 + 5405 + 5760 + 6406, "Cienfuegos");
            (string, double, string) Abreus = ("Abreus", 913 + 850 + 948 + 1031, "Cienfuegos");

            //Villa Clara
            (string, double, string) Corralillo = ("Corralillo", 638 + 774 + 759 + 778, "Villa Clara");
            (string, double, string) QuemadodeGüines = ("Quemado de Güines", 525 + 577 + 578 + 628, "Villa Clara");
            (string, double, string) SagualaGrande = ("Sagua la Grande", 1332 + 1489 + 1558 + 1546, "Villa Clara");
            (string, double, string) Encrucijada = ("Encrucijada", 742 + 983 + 888 + 965, "Villa Clara");
            (string, double, string) Camajuaní = ("Camajuaní", 1421 + 1833 + 1629 + 1868, "Villa Clara");
            (string, double, string) Caiberién = ("Caiberién", 1016 + 1285 + 1140 + 1375, "Villa Clara");
            (string, double, string) Remedios = ("Remedios", 1020 + 1381 + 1199 + 1346, "Villa Clara");
            (string, double, string) Placetas = ("Placetas", 1700 + 2087 + 1892 + 1990, "Villa Clara");
            (string, double, string) SantaClara = ("Santa Clara", 5973 + 7543 + 7230 + 8534, "Villa Clara");
            (string, double, string) Cifuentes = ("Cifuentes", 625 + 752 + 740 + 844, "Villa Clara");
            (string, double, string) SantoDomingo = ("Santo Domingo", 1184 + 1480 + 1388 + 1542, "Villa Clara");
            (string, double, string) Ranchuelo = ("Ranchuelo", 1241 + 1592 + 1452 + 1650, "Villa Clara");
            (string, double, string) Manicaragua = ("Manicaragua", 1553 + 1762 + 1814 + 2033, "Villa Clara");

            //Sancti Spiritus
            (string, double, string) Yaguajay = ("Yaguajay", 1276 + 1414 + 1557 + 1713, "Sancti Spiritus");
            (string, double, string) Jatibonico = ("Jatibonico", 1162 + 1195 + 1221 + 1350, "Sancti Spiritus");
            (string, double, string) Taguasco = ("Taguasco", 826 + 935 + 976 + 1058, "Sancti Spiritus");
            (string, double, string) Cabaiguán = ("Cabaiguán", 1629 + 1849 + 1802 + 2068, "Sancti Spiritus");
            (string, double, string) Fomento = ("Fomento", 799 + 812 + 940 + 985, "Sancti Spiritus");
            (string, double, string) Trinidad = ("Trinidad", 2063 + 2279 + 2305 + 2598, "Sancti Spiritus");
            (string, double, string) SanctiSpíritus = ("Sancti Spíritus", 3817 + 4054 + 4247 + 4762, "Sancti Spiritus");
            (string, double, string) LaSierpe = ("LaSierpe", 444 + 481 + 508 + 558, "Sancti Spiritus");

            //Holguin
            (string, double, string) Gibara = ("Gibara", 1865 + 1854 + 2013 + 2202, "Holguín");
            (string, double, string) RafaelFreyre = ("Rafael Freyre", 1611 + 1588 + 1577 + 1792, "Holguín");
            (string, double, string) Banes = ("Banes", 2100 + 2175 + 2084 + 2462, "Holguín");
            (string, double, string) Antilla = ("Antilla", 351 + 384 + 333 + 455, "Holguín");
            (string, double, string) Báguanos = ("Báguanos", 1374 + 1316 + 1295 + 1517, "Holguín");
            (string, double, string) Holguín = ("Holguín", 9911 + 10814 + 10496 + 12109, "Holguín");
            (string, double, string) CalixtoGarcía = ("Calixto García", 1522 + 1590 + 1439 + 1663, "Holguín");
            (string, double, string) Cacocum = ("Cacocum", 1104 + 1130 + 1061 + 1282, "Holguín");
            (string, double, string) UrbanoNoris = ("Urbano Noris", 1016 + 1071 + 1148 + 1309, "Holguín");
            (string, double, string) Cueto = ("Cueto", 927 + 909 + 919 + 988, "Holguín");
            (string, double, string) Mayarí = ("Mayarí", 2803 + 2663 + 2596 + 3115, "Holguín");
            (string, double, string) FrankPaís = ("Frank País", 724 + 642 + 619 + 807, "Holguín");
            (string, double, string) SaguaTánamo = ("Sagua Tánamo", 1495 + 1427 + 1211 + 1438, "Holguín");
            (string, double, string) Moa = ("Moa", 2197 + 2551 + 2081 + 2798, "Holguín");

            //Camaguey
            (string, double, string) CarlosManueldeCéspedes = ("Carlos Manuel de Céspedes", 645 + 688 + 622 + 825, "Camagüey");
            (string, double, string) Esmeralda = ("Esmeralda", 837 + 831 + 952 + 975, "Camagüey");
            (string, double, string) SierradeCubitas = ("Sierra de Cubitas", 499 + 585 + 504 + 642, "Camagüey");
            (string, double, string) Minas = ("Minas", 941 + 1045 + 1117 + 1261, "Camagüey");
            (string, double, string) Nuevitas = ("Nuevitas", 1627 + 1784 + 1774 + 2005, "Camagüey");
            (string, double, string) Guáimaro = ("Guáimaro", 937 + 932 + 933 + 1085, "Camagüey");
            (string, double, string) Sibanicú = ("Sibanicú", 752 + 849 + 830 + 1004, "Camagüey");
            (string, double, string) Camagüey = ("Camagüey", 8811 + 9873 + 9424 + 11987, "Camagüey");
            (string, double, string) Florida = ("Florida", 1736 + 1952 + 2037 + 2431, "Camagüey");
            (string, double, string) Vertientes = ("Vertientes", 1408 + 1476 + 1470 + 1761, "Camagüey");
            (string, double, string) Jimaguayú = ("Jimaguayú", 498 + 642 + 550 + 684, "Camagüey");
            (string, double, string) Najasa = ("Najasa", 355 + 467 + 415 + 519, "Camagüey");
            (string, double, string) SantaCruzdelSur = ("Santa Cruz del Sur", 1122 + 1266 + 1169 + 1307, "Camagüey");

            //Granma
            (string, double, string) RíoCauto = ("Río Cauto", 1348 + 1484 + 1283 + 1574, "Granma");
            (string, double, string) CautoCristo = ("Cauto Cristo", 532 + 579 + 626 + 674, "Granma");
            (string, double, string) Jiguaní = ("Jiguaní", 1745 + 1840 + 1804 + 1793, "Granma");
            (string, double, string) Bayamo = ("Bayamo", 6740 + 7348 + 7104 + 8466, "Granma");
            (string, double, string) Yara = ("Yara", 1434 + 1623 + 1648 + 1846, "Granma");
            (string, double, string) Manzanillo = ("Manzanillo", 3460 + 3510 + 3710 + 4332, "Granma");
            (string, double, string) Campechuela = ("Campechuela", 1232 + 1206 + 1292 + 1440, "Granma");
            (string, double, string) MediaLuna = ("MediaLuna", 963 + 998 + 936 + 989, "Granma");
            (string, double, string) Niquero = ("Niquero", 1309 + 1483 + 1169 + 1435, "Granma");
            (string, double, string) Pilón = ("Pilón", 893 + 986 + 788 + 1060, "Granma");
            (string, double, string) BartoloméMasó = ("Bartolomé Masó", 1590 + 1454 + 1247 + 1417, "Granma");
            (string, double, string) BueyArriba = ("Buey Arriba", 956 + 924 + 818 + 950, "Granma");
            (string, double, string) Guisa = ("Guisa", 1210 + 1285 + 1238 + 1487, "Granma");

            //Guantánamo
            (string, double, string) ElSalvador = ("El Salvador", 1338 + 1507 + 1582 + 1438, "Guantánamo");
            (string, double, string) ManuelTames = ("Manuel Tames", 1127 + 1355 + 1244 + 1255, "Guantánamo");
            (string, double, string) Yateras = ("Yateras", 507 + 690 + 655 + 707, "Guantánamo");
            (string, double, string) Baracoa = ("Baracoa", 2351 + 2672 + 2478 + 2635, "Guantánamo");
            (string, double, string) Maisí = ("Maisí", 889 + 926 + 876 + 970, "Guantánamo");
            (string, double, string) Imías = ("Imías", 683 + 766 + 701 + 756, "Guantánamo");
            (string, double, string) SanAntoniodelSur = ("San Antonio del Sur", 831 + 882 + 843 + 894, "Guantánamo");
            (string, double, string) Caimanera = ("Caimanera", 347 + 392 + 378 + 436, "Guantánamo");
            (string, double, string) Guantánamo = ("Guantánamo", 6401 + 7210 + 7112 + 8299, "Guantánamo");
            (string, double, string) NicetoPérez = ("Niceto Pérez", 455 + 520 + 563 + 560, "Guantánamo");

            //Santiago de Cuba
            (string, double, string) Contramaestre = ("Contra maestre", 2756 + 3004 + 3104 + 3740, "Santiago de Cuba");
            (string, double, string) Mella = ("Mella", 1004 + 968 + 1057 + 1321, "Santiago de Cuba");
            (string, double, string) SanLuis_SC = ("San Luis_SC", 2196 + 2229 + 2253 + 2727, "Santiago de Cuba");
            (string, double, string) SegundoFrente = ("Segundo Frente", 1164 + 1248 + 1243 + 1333, "Santiago de Cuba");
            (string, double, string) SongoLaMaya = ("Songo La Maya", 2604 + 2957 + 3014 + 3119, "Santiago de Cuba");
            (string, double, string) SantiagodeCuba = ("Santiago de Cuba", 14000 + 15058 + 15264 + 18123, "Santiago de Cuba");
            (string, double, string) PalmaSoriano = ("Palma Soriano", 3245 + 3465 + 3525 + 4151, "Santiago de Cuba");
            (string, double, string) TercerFrente = ("Tercer Frente", 972 + 952 + 856 + 1070, "Santiago de Cuba");
            (string, double, string) Guamá = ("Guamá", 1027 + 1055 + 1024 + 1158, "Santiago de Cuba");

            //Isla de la Juventud
            (string, double, string) IsladelaJuventud = ("Isla de la Juventud", 4934 + 5347 + 5449 + 5857, "Isla de la Juventud");

            //Las Tunas
            (string, double, string) Manatí = ("Manatí", 744 + 779 + 840 + 1025, "Las Tunas");
            (string, double, string) PuertoPadre = ("Puerto Padre", 2279 + 2450 + 2682 + 3139, "Las Tunas");
            (string, double, string) JesúsMenéndez = ("Jesús Menéndez", 1160 + 1151 + 1399 + 1662, "Las Tunas");
            (string, double, string) Majibacoa = ("Majibacoa", 1085 + 1168 + 1213 + 1335, "Las Tunas");
            (string, double, string) LasTunas = ("Las Tunas", 5671 + 6730 + 6497 + 7699, "Las Tunas");
            (string, double, string) Jobabo = ("Jobabo", 943 + 1165 + 1312 + 1200, "Las Tunas");
            (string, double, string) Colombia = ("Colombia", 885 + 935 + 1033 + 1065, "Las Tunas");
            (string, double, string) Amanacio = ("Amanacio", 900 + 1052 + 1195 + 1317, "Las Tunas");

            //Ciego de Ávila
            (string, double, string) Chambas = ("Chambas", 924 + 1055 + 1141 + 1306, "Ciego de Ávila");
            (string, double, string) Morón = ("Morón", 1981 + 2152 + 2175 + 2631, "Ciego de Ávila");
            (string, double, string) Bolivia = ("Bolivia", 432 + 471 + 534 + 609, "Ciego de Ávila");
            (string, double, string) PrimerodeEnero = ("Primero de Enero", 651 + 570 + 736 + 822, "Ciego de Ávila");
            (string, double, string) CiroRedondo = ("Ciro Redondo", 835 + 898 + 1027 + 12125, "Ciego de Ávila");
            (string, double, string) Florencia = ("Florencia", 448 + 451 + 577 + 644, "Ciego de Ávila");
            (string, double, string) Majagua = ("Majagua", 714 + 734 + 741 + 870, "Ciego de Ávila");
            (string, double, string) CiegodeÁvila = ("Ciego de Ávila", 4312 + 4737 + 4649 + 5726, "Ciego de Ávila");
            (string, double, string) Venezuela = ("Venezuela", 723 + 765 + 780 + 967, "Ciego de Ávila");
            (string, double, string) Baraguá = ("Baraguá", 929 + 945 + 996 + 1156, "Ciego de Ávila");

            List<(string, double, string)> dataEdadMujerFertil = new List<(string, double, string)>()
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

            return dataEdadMujerFertil;
        }

        public List<(string, List<double>, string)> GetParamEP_EAM_EAJ_EMF()
        {
            List<(string, double, string)> edadPediatrica = EdadPediatrica();
            List<(string, double, string)> edadAdultoMayor = EdadAdultoMayor();
            List<(string, double, string)> edadAdultoJoven = EdadAdultoJoven();
            List<(string, double, string)> edadMujerFertil = EdadMujerFertil();

            List<(string, List<double>, string)> result = new List<(string, List<double>, string)>();

            for (int i = 0; i < edadPediatrica.Count; i++)
            {
                (string, List<double>, string) entidad = (edadPediatrica[i].Item1,
                                                  new List<double>() { edadPediatrica[i].Item2,
                                                                       edadAdultoMayor[i].Item2,
                                                                       edadAdultoJoven[i].Item2/*,
                                                                       edadMujerFertil[i].Item2 */}, edadPediatrica[i].Item3);

                result.Add(entidad);
            }

            return result;
        }

    }
}