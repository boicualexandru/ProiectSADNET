using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddRecordsEntryData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ABS" },
                    { 31, "DVD" },
                    { 32, "Head-up display" },
                    { 33, "Lumini de zi (LED)" },
                    { 34, "Oglinzi retrovizoare ajustabile electric" },
                    { 35, "Parbriz incalzit" },
                    { 36, "Scaune fata incalzite" },
                    { 37, "Stergatoare parbriz automate" },
                    { 38, "Carlig remorca" },
                    { 39, "Incalzire auxiliara" },
                    { 40, "Bluetooth" },
                    { 41, "Comenzi volan" },
                    { 30, "Airbag-uri laterale spate" },
                    { 42, "CD" },
                    { 44, "Geamuri laterale spate fumurii" },
                    { 45, "Alarma" },
                    { 46, "Geamuri cu tenta" },
                    { 48, "Interior din velur" },
                    { 49, "Geamuri spate electrice" },
                    { 50, "Intrare auxiliara" },
                    { 51, "Suspensie reglabila" },
                    { 52, "Aer conditionat patru zone" },
                    { 53, "Scaune spate incalzite" },
                    { 54, "Interior din piele" },
                    { 55, "TV" },
                    { 43, "Camera parcare spate" },
                    { 29, "Aer conditionat doua zone" },
                    { 47, "Imobilizator electronic" },
                    { 27, "Geamuri fata electrice" },
                    { 28, "Servodirectie" },
                    { 2, "Computer de bord" },
                    { 3, "Inchidere centralizata" },
                    { 4, "Acoperis panoramic" },
                    { 5, "Airbag genunchi sofer" },
                    { 7, "Faruri automate" },
                    { 8, "Jante din aliaj usor" },
                    { 9, "Navigatie GPS" },
                    { 10, "Oglinzi retrovizoare exterioare electrocromatice" },
                    { 11, "Pilot automat" },
                    { 12, "Senzori parcare fata-spate" },
                    { 13, "Trapa" },
                    { 6, "Bare longitudinale acoperis" },
                    { 15, "Controlul stabilitatii (ESP)" },
                    { 26, "Airbag-uri laterale fata" },
                    { 14, "Airbag-uri frontale" },
                    { 25, "Senzori parcare spate" },
                    { 24, "Proiectoare ceata" },
                    { 22, "Oglinda retrovizoare interioara electrocromatica" },
                    { 21, "Limitator de viteza" },
                    { 23, "Oglinzi retrovizoare incalzite" },
                    { 19, "Controlul tractiunii (ASR)" },
                    { 18, "Airbag-uri cortina" },
                    { 17, "Aer conditionat" },
                    { 16, "Radio" },
                    { 20, "Faruri Xenon" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 1703, 2, "Argint", 1, "Germania", 179000, 4, 5, 1600, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 5999, null, 1, "Fata", null },
                    { 1708, 6, "Gri", 1, "Germania", 201975, 5, 5, 1968, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 185, 12950, true, 1, "4x4 (automat)", null },
                    { 1702, 4, "Gri", 1, "Germania", 156000, 5, 5, 1590, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 5390, null, 1, "Fata", null },
                    { 1704, 4, "Alb", 1, "Germania", 180000, 4, 6, 2998, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 546, 272, 22100, null, 0, "Fata", null },
                    { 1705, 3, "Negru", 1, null, 217000, null, 5, 1995, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 6150, true, 0, null, null },
                    { 1706, 1, "Argint", 1, null, 220000, 4, 4, 1896, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, 101, 2999, null, 0, "Fata", null },
                    { 1707, 5, "Rosu", 1, null, 62100, 5, null, null, 1, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 485, null, 12500, null, 1, null, "WDF4516051u193117" },
                    { 1709, 6, "Alb", 1, "Germania", 167250, 5, 5, 2200, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, 150, 10200, true, 1, "4x4 (automat)", "SALFA2BC5BH274494" },
                    { 1714, 4, "Negru", 1, "Ungaria", 229800, null, 6, 3000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 258, 15900, null, 1, "Spate", null },
                    { 1711, 4, "Maro", 1, "Germania", 198600, 5, 6, 1968, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 150, 10990, null, 1, "4x4 (automat)", null },
                    { 1712, 6, "Negru", 1, "Romania", 190000, 5, 4, 6000, 2, 1, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 676, null, 18900, true, 1, "4x4 (automat)", null },
                    { 1713, 3, "Gri", 1, "Germania", 236000, 5, null, 2998, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, null, 14959, true, 1, "4x4 (automat)", null },
                    { 1715, 3, "Gri", 1, null, 47253, 4, null, 1968, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 15300, null, 0, null, null },
                    { 1716, 3, "Gri", 1, "Franta", 156200, 4, 6, 1600, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 120, 12590, null, 1, "Fata", "WVWZZZ3CZGE039418" },
                    { 1701, 3, "Negru", 1, "Romania", 111521, 5, 5, 998, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 101, 6250, true, 1, "Fata", null },
                    { 1717, 3, "Maro", 1, "Germania", 221754, null, 4, 1968, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 5190, true, 0, "Fata", null },
                    { 1710, 6, "Gri", 1, null, 126000, null, null, null, 1, null, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, null, 13990, null, 1, null, null },
                    { 1700, 2, "Albastru", 1, null, 191000, null, null, null, 0, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, null, 3250, null, 0, null, null },
                    { 1687, 3, "Negru", 1, "Germania", 183000, 5, 5, 1986, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 403, 143, 12400, null, 1, "Fata", null },
                    { 1698, 5, "Rosu", 1, null, 232000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 432, null, 7200, null, 0, null, null },
                    { 1718, 4, "Verde", 1, null, 180000, 5, 4, 1390, 0, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 65, 1490, true, 0, "Fata", "TMBHC26Y423309155" },
                    { 1682, 6, "Negru", 1, "Germania", 8900, 5, 6, 1999, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, 241, 78154, null, 0, "4x4 (automat)", null },
                    { 1683, 3, "Alb", 1, "Germania", 175000, 4, 6, 1995, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 14900, null, 1, "Spate", null },
                    { 1684, 5, "Gri", 1, null, 300000, null, null, 2193, 1, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 515, null, 4490, null, 1, "Spate", null },
                    { 1685, 0, "Maro", 1, "Germania", 92490, 4, null, 995, 0, null, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 195, null, 999, null, 0, null, null },
                    { 1686, 3, "Albastru", 1, "Germania", 158000, 4, 5, 1598, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 10200, null, 1, "Fata", "TMBAG9NE9E0110724" },
                    { 1688, 6, "Gri", 1, null, 170000, null, 5, 1998, 0, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 150, 8200, null, 1, "Fata", null },
                    { 1699, 5, "Alb", 1, "Olanda", 197800, 4, 5, 2200, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 136, 9600, null, 1, "Spate", null },
                    { 1689, 4, "Negru", 1, "Germania", 370343, null, 5, 3000, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 204, 12700, null, 1, "4x4 (automat)", null },
                    { 1691, 1, "Rosu", 1, null, 96897, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, null, 3000, null, 1, null, "WF0JXXGAJJAY10909" },
                    { 1692, 2, "Argint", 1, "Germania", 166000, 4, 4, 1598, 0, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 252, 105, 1290, null, 0, "Fata", null },
                    { 1693, 4, "Rosu", 1, "Franta", 160000, null, 5, 1500, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 90, 6900, null, 1, "Fata", null },
                    { 1694, 2, "Albastru", 1, "Romania", 8500, 5, 6, 898, 0, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 90, 9000, true, 1, "Fata", "UU15SDL1C58662041" },
                    { 1695, 2, "Albastru", 1, "Germania", 124600, 5, 5, 1598, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 10950, true, 1, "Fata", null },
                    { 1696, 4, "Argint", 1, "Germania", 182000, 4, 5, 1995, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 6190, null, 1, "Spate", null },
                    { 1697, 4, "Negru", 1, null, 3000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 5700, null, 1, null, null },
                    { 1690, 4, "Negru", 1, "Germania", 258000, null, 6, 1968, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 150, 9999, null, 1, "4x4 (automat)", null },
                    { 1719, 6, "Gri", 1, "Belgia", 219500, 5, 5, 1986, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 163, 12799, null, 1, "4x4 (automat)", null },
                    { 1746, 6, "Negru", 1, "Germania", 123000, 5, 6, 2987, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 258, 29300, null, 1, "4x4 (automat)", "WDC1660241A042668" },
                    { 1721, 3, "Albastru", 1, "Romania", 50000, 4, 4, 5462, 0, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 382, 29500, null, 1, "4x4 (automat)", null },
                    { 1742, 6, "Albastru", 1, "Germania", 228000, 5, null, 2400, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 806, 185, 8400, null, 0, "4x4 (automat)", "YV1CM714671383367" },
                    { 1743, 1, "Gri", 1, "Germania", 178253, 5, 4, 1896, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 4790, null, 0, "Fata", null },
                    { 1744, 6, "Alb", 1, null, 231000, null, 5, 3000, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 306, 19600, null, 1, "4x4 (automat)", null },
                    { 1745, 3, "Gri", 1, null, 244000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, null, 6500, null, 1, null, null },
                    { 1681, 5, "Alb", 1, null, 240000, null, null, null, 1, null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 432, null, 2800, null, 1, null, null },
                    { 1747, 3, "Negru", 1, "Germania", 149000, null, 5, 2998, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 216, 250, 32800, null, 1, "Spate", null },
                    { 1748, 3, "Gri", 1, null, 43049, 4, 4, 1968, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 141, 9950, null, 1, "Fata", "WAUZZZ8K38A011195" },
                    { 1741, 6, "Albastru", 1, null, 280000, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, null, 2500, null, 1, null, null },
                    { 1749, 8, "Negru", 1, null, 143000, 3, 4, 1800, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 116, 3750, null, 1, "Fata", null },
                    { 1751, 6, "Negru", 1, null, 121500, 5, 6, 2997, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 258, 39900, true, 1, "4x4 (automat)", null },
                    { 1752, 3, "Negru", 1, "Germania", 187772, 4, 5, 3498, 0, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 272, 19500, true, 0, "Spate", "WDD2211561A289986" },
                    { 1753, 3, "Alb", 1, "Romania", 72300, null, 5, 1500, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 90, 6200, true, 1, "Fata", null },
                    { 1754, 6, "Gri", 1, null, 37011, 5, null, 1984, 0, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 225, 20900, null, 0, null, null },
                    { 1755, 3, "Rosu", 1, null, 20000, null, null, 2143, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 37628, null, 0, "4x4 (automat)", "WDD2050051R380493" },
                    { 1756, 5, "Argint", 1, "Germania", 212000, 5, 3, 1995, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 216, 90, 1590, null, 0, "Fata", null },
                    { 1757, 3, "Gri", 1, null, 22355, null, null, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 25756, null, 0, "Spate", "WDD2050041R310374" },
                    { 1750, 3, "Negru", 1, "Germania", 149000, 5, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 9300, null, 1, "Fata", "TMBAG9NEXE0122011" },
                    { 1720, 5, "Albastru", 1, "Romania", 184278, 5, 4, 1968, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 69, 3300, true, 1, "Fata", null },
                    { 1740, 2, "Argint", 1, "Germania", 370000, null, 3, 1998, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 150, 2699, null, 1, "Spate", null },
                    { 1738, 2, "Negru", 1, "Germania", 178000, 5, 6, 1600, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 10300, null, 1, "Fata", "WVWZZZAUZGW166507" },
                    { 1722, 4, "Gri", 1, "Germania", 93240, null, 4, 1598, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 105, 3190, null, 0, "Fata", null },
                    { 1723, 3, "Alte culori", 1, "Germania", 240578, 4, 5, 1986, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 170, 8290, null, 0, "Fata", "WVWZZZ3CZBE722641" },
                    { 1724, 3, "Negru", 1, "Germania", 245358, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, null, 15999, null, 1, null, null },
                    { 1725, 3, "Alb", 1, "Romania", 12500, 5, 6, 1685, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, 141, 18000, true, 0, "Fata", "KMHLC41UGJU102718" },
                    { 1726, 6, "Gri", 1, null, 180000, null, null, null, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, null, 31000, null, 1, null, null },
                    { 1727, 3, "Negru", 1, null, 88163, 4, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 240, 20580, null, 0, "4x4 (automat)", "WVWZZZ3CZGE119556" },
                    { 1728, 4, "Maro", 1, "Germania", 237251, null, 4, 1968, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 4790, null, 0, "Fata", null },
                    { 1739, 2, "Negru", 1, "Germania", 171000, null, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 110, 8600, null, 1, "Fata", null },
                    { 1729, 3, "Gri", 1, "Romania", 140000, null, 5, 1995, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 10700, true, 1, "Fata", null },
                    { 1731, 3, "Alb", 1, "Germania", 305000, 4, 5, 1995, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 143, 8500, true, 1, "Spate", null },
                    { 1732, 5, "Gri", 1, "Olanda", 178000, 4, 4, 1900, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, null, 3899, null, 1, "Fata", null },
                    { 1733, 8, "Alb", 1, "Germania", 260182, null, 5, 1968, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 170, 12890, null, 0, "Fata", null },
                    { 1734, 3, "Gri", 1, "Austria", 149000, 4, 4, 1991, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 186, 150, 3990, null, 0, "Fata", null },
                    { 1735, 6, "Alb", 1, "Germania", 184500, 5, 5, 2200, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 296, 150, 13300, null, 1, "4x4 (automat)", null },
                    { 1736, 3, "Gri", 1, "Romania", 49970, 4, 6, 1798, 0, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 180, 19900, true, 0, "Fata", "WVWZZZ3CZGE125952" },
                    { 1737, 6, "Negru", 1, null, 185250, 4, 5, 2179, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 190, 17700, null, 1, "4x4 (automat)", null },
                    { 1730, 4, "Maro", 1, null, 167000, null, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 116, 6200, null, 1, "Fata", null },
                    { 1680, 2, "Albastru", 1, "Romania", 65000, 4, 5, 1598, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 7500, true, 1, "Fata", "WVWZZZ1KZCW281971" },
                    { 1653, 3, "Alb", 1, null, 64384, 4, null, 1560, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 95, 6800, null, 0, null, null },
                    { 1678, 4, "Gri", 1, null, 180000, 5, 5, 1995, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 175, 8300, null, 1, "Fata", "VF1KT1SGE53076509" },
                    { 1622, 6, "Rosu", 1, null, 277458, 3, null, 2498, 1, 0, new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 297, null, 3200, true, 1, "4x4-manual", null },
                    { 1623, 3, "Argint", 1, "Italia", 203000, 5, 4, 1998, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 4680, null, 1, "Spate", null },
                    { 1624, 3, "Gri", 1, "Belgia", 200000, 4, 5, 1461, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 110, 4990, true, 0, "Fata", null },
                    { 1625, 3, "Gri", 1, "Franta", 188000, 4, 5, 2200, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 170, 17500, true, 1, "Spate", null },
                    { 1626, 2, "Albastru", 1, "Austria", 262100, 5, 4, 1686, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 100, 2490, null, 0, "Fata", "W0L0AHL4855055101" },
                    { 1627, 3, "Gri", 1, "Germania", 192727, null, 5, 1956, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 151, 170, 5900, null, 0, "Fata", null },
                    { 1628, 6, "Maro", 1, "Germania", 180000, null, 5, 2400, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 205, 12900, true, 1, "4x4 (automat)", "YV1DZ8056B2216851" },
                    { 1621, 0, "Albastru", 1, null, 265500, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 3198, null, 1, null, null },
                    { 1629, 3, "Gri", 1, null, 190000, null, null, null, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, null, 21999, null, 1, null, null },
                    { 1631, 4, "Negru", 1, "Germania", 236000, 5, 5, 1960, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 143, 6190, null, 1, "Fata", null },
                    { 1632, 3, "Gri", 1, null, 247800, null, 5, 2978, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 245, 16660, true, 1, "4x4 (automat)", null },
                    { 1633, 8, "Gri", 1, null, 134000, 4, 5, 2993, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 492, 265, 19000, null, 1, "Spate", null },
                    { 1634, 1, "Negru", 1, "Germania", 147000, 4, 5, 1995, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 122, 4790, null, 1, "Spate", null },
                    { 1635, 4, "Gri", 1, "Belgia", 165000, 4, 5, 1996, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 20000, true, 1, "Spate", null },
                    { 1636, 4, "Argint", 1, "Germania", 191000, 4, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 150, 16900, null, 1, "Fata", null },
                    { 1637, 2, "Alb", 1, null, 54000, null, null, null, 0, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, null, 7200, null, 1, null, null },
                    { 1630, 2, "Albastru", 1, "Romania", 69000, 4, 6, null, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 10500, true, 1, "Fata", null },
                    { 1638, 3, "Negru", 1, "Germania", 165000, 4, 5, 1995, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 18999, true, 1, "4x4 (automat)", "WBA3D51010F703324" },
                    { 1620, 5, "Albastru", 1, "Belgia", 16000, 5, 6, 1197, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 110, 9200, null, 0, "Fata", null },
                    { 1618, 3, "Negru", 1, "Belgia", 229000, 4, 5, 1995, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 136, 6990, true, 1, "Spate", "WBAPN11040VJ92365" },
                    { 1602, 4, "Alte culori", 1, "Austria", 275263, 5, 4, 1997, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 130, 4850, null, 1, "Fata", null },
                    { 1603, 1, "Albastru", 1, "Belgia", 268000, 5, 5, 1199, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, 75, 4850, true, 1, "Fata", null },
                    { 1604, 4, "Negru", 1, "Germania", 262800, 5, 5, 2000, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 5690, null, 1, null, null },
                    { 1605, 6, "Negru", 1, "Germania", 165000, 4, 5, 2997, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 245, 30900, true, 1, "4x4 (automat)", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 1606, 2, "Gri", 1, "Germania", 198200, 4, 4, 1986, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 140, 3990, null, 1, "Fata", null },
                    { 1607, 6, "Alb", 1, "Germania", 194780, null, 4, 1997, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 136, 7150, null, 1, "Fata", null },
                    { 1608, 6, "Argint", 1, null, 170000, null, null, null, 1, null, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, null, 3300, null, 1, null, null },
                    { 1619, 4, "Argint", 1, "Germania", 180000, 5, 5, 1890, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 6300, true, 1, "Fata", "TMBGS61Z6A2016489" },
                    { 1609, 4, "Gri", 1, "Germania", 168450, 4, 4, 1600, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 90, 3490, true, 1, "Fata", null },
                    { 1611, 4, "Gri", 1, "Germania", 216866, null, 5, 1995, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 177, 6500, null, 0, "Spate", null },
                    { 1612, 6, "Albastru", 1, null, 330000, 5, null, 2400, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, null, 14000, true, 1, "4x4 (automat)", null },
                    { 1613, 6, "Alb", 1, null, 23000, null, 5, 2149, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, null, 16500, null, 1, null, null },
                    { 1614, 6, "Gri", 1, "Germania", 181000, 5, 4, 2200, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 296, 156, 6990, true, 1, "4x4-manual", null },
                    { 1615, 6, "Negru", 1, "Germania", 178000, 5, 5, 2968, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 245, 17800, null, 0, "4x4 (automat)", "WVGZZZ7PZBD046195" },
                    { 1616, 6, "Negru", 1, "Romania", 126000, 5, 5, 1590, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 279, 117, 9900, true, 1, "Fata", "JMBXNGA1WBZ035195" },
                    { 1617, 3, "Gri", 1, null, 227000, 5, 5, 2993, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 313, 18700, null, 1, "4x4 (automat)", null },
                    { 1610, 3, "Gri", 1, "Romania", 200000, null, 4, 2490, 1, 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 177, 5790, true, 0, "Spate", null },
                    { 1679, 4, "Alb", 1, "Olanda", 218000, 5, 5, 1560, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 116, 6100, null, 0, "Fata", null },
                    { 1639, 4, "Gri", 1, "Germania", 165000, 4, 6, 1997, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 11750, null, 1, "Fata", null },
                    { 1641, 3, "Gri", 1, "Romania", 190000, 4, 3, 1461, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 80, 2290, true, 1, "Fata", "VF1LMRFC534283248" },
                    { 1662, 6, "Albastru", 1, null, 74972, 5, null, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 109, 8100, null, 0, null, null },
                    { 1663, 5, "Alb", 1, null, 58861, 4, null, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 75, 5350, null, 0, null, null },
                    { 1664, 6, "Albastru", 1, null, 56840, 5, null, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 109, 8300, null, 0, null, null },
                    { 1665, 4, "Alte culori", 1, "Germania", 169569, 4, 5, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 10336, null, 0, "Fata", "TMBJG9NE0F0102223" },
                    { 1666, 3, "Gri", 1, null, 78000, 5, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 18500, true, 1, "Fata", "WVWZZZ3CZFE414444" },
                    { 1667, 3, "Gri", 1, null, 180000, null, null, 1999, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, null, 11699, true, 1, null, null },
                    { 1668, 2, "Argint", 1, "Romania", 1, null, null, 999, 0, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, null, 8950, null, 1, null, null },
                    { 1661, 1, "Alb", 1, null, 79392, 5, null, 1498, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 5700, null, 0, null, null },
                    { 1669, 1, "Alb", 1, null, 228000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, null, 7800, null, 1, null, null },
                    { 1671, 6, "Negru", 1, "Germania", 306000, 4, 5, 2997, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 306, 12990, true, 0, "4x4 (automat)", "WBAZW61090L564829" },
                    { 1672, 1, "Albastru", 1, "Romania", 50000, null, 4, 1298, 0, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, 86, 4950, true, 1, "Fata", null },
                    { 1673, 6, "Albastru", 1, "Germania", 122530, null, 4, 1996, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 177, 7950, null, 1, "4x4 (automat)", null },
                    { 1674, 6, "Gri", 1, "Olanda", 178525, null, 5, 1500, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 110, 11950, null, 1, "Fata", null },
                    { 1675, 6, "Maro", 1, "Germania", 108400, 4, 6, 1500, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 265, 105, 13300, null, 1, "Fata", null },
                    { 1676, 5, "Maro", 1, "Germania", 185000, 4, 6, 1968, 1, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 402, 150, 23490, true, 0, "Fata", "WV2ZZZ7H2GH131008" },
                    { 1677, 6, "Alb", 1, null, 219621, null, 5, 1968, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 11690, null, 0, "4x4 (automat)", "WVGZZZ5NZBW043328" },
                    { 1670, 3, "Gri", 1, null, 131000, null, null, null, 0, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 4200, null, 1, null, "wvwzzz3cz6p226107" },
                    { 1640, 8, "Rosu", 1, "Romania", 58981, 4, null, 1368, 0, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 162, 170, 11000, null, 0, "Fata", "ZAR94000007102049" },
                    { 1660, 1, "Alb", 1, null, 76577, 5, null, 1498, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 5700, null, 0, null, null },
                    { 1658, 1, "Alb", 1, null, 80205, 5, null, 1498, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 5600, null, 0, null, null },
                    { 1642, 2, "Alb", 1, "Romania", 28000, 5, 6, 1598, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 12750, true, 0, "Fata", "WVWZZZAUZGP001052" },
                    { 1643, 3, "Gri", 1, "Germania", 250000, null, 4, 2000, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 260, 140, 2590, null, 1, "Fata", null },
                    { 1644, 3, "Gri", 1, "Germania", 154000, 4, 5, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 115, 11400, null, 1, "Fata", null },
                    { 1645, 1, "Gri", 1, null, 168000, null, null, null, 1, null, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, null, 2980, null, 1, null, null },
                    { 1646, 2, "Albastru", 1, null, 272317, null, 3, 1896, 1, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 110, 2190, true, 0, "Fata", null },
                    { 1647, 8, "Alb", 1, null, 220000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, null, 10800, null, 1, null, null },
                    { 1648, 5, "Alb", 1, "Olanda", 260000, null, null, 2000, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 115, 4900, null, 1, null, null },
                    { 1659, 3, "Alb", 1, null, 77343, 5, null, 1461, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 6100, null, 0, null, null },
                    { 1649, 5, "Gri", 1, "Germania", 227000, 5, 4, 1900, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 125, 3490, null, 1, "Fata", null },
                    { 1651, 3, "Albastru", 1, null, 230000, 5, 4, 1998, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 130, 1990, true, 1, "Fata", null },
                    { 1652, 1, "Alte culori", 1, null, 104019, 5, null, 1364, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, 90, 5600, null, 0, null, null },
                    { 1758, 8, "Negru", 1, null, 178500, null, 6, 2993, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491, 258, 42500, true, 1, "4x4 (automat)", null },
                    { 1654, 4, "Alte culori", 1, "Germania", 187153, 4, 5, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 9453, null, 0, "Fata", "TMBJG9NE4F0016235" },
                    { 1655, 3, "Negru", 1, null, 73461, 5, null, 1968, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 140, 11100, null, 0, null, null },
                    { 1656, 1, "Alb", 1, null, 68331, 5, null, 1498, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 6000, null, 0, null, null },
                    { 1657, 6, "Maro", 1, null, 79112, 5, null, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 109, 8000, null, 0, null, null },
                    { 1650, 6, "Alte culori", 1, "Germania", 178000, 5, 5, 2993, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 286, 16400, true, 1, "4x4 (automat)", null },
                    { 1759, 6, "Negru", 1, "Romania", 198000, 5, null, 2874, 1, 1, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 150, 2550, true, 1, "4x4 (automat)", null },
                    { 1786, 6, "Negru", 1, "Germania", 50870, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 136, 23390, null, 0, "Fata", null },
                    { 1761, 6, "Gri", 1, "Germania", 5000, 4, 6, 2298, 1, 0, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 249, 191, 31350, null, 0, "4x4 (automat)", null },
                    { 1862, 6, "Negru", 1, null, 73094, 5, null, 2993, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 258, 26600, null, 0, null, null },
                    { 1863, 5, "Gri", 1, "Romania", 241444, 5, 3, 1896, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 105, 4800, true, 0, "Fata", "WV2ZZZ2KZ7X084966" },
                    { 1864, 3, "Alb", 1, "Germania", 3500, 4, 6, 1991, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 184, 36990, null, 0, "4x4 (automat)", null },
                    { 1865, 3, "Negru", 1, "Germania", 83574, 5, 5, 1997, 4, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 200, 11390, true, 0, "4x4 (automat)", "VF38DRHC8DL012531" },
                    { 1866, 6, "Argint", 1, "Romania", 224000, null, 4, 1600, 0, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 454, 107, 4800, true, 1, null, null },
                    { 1867, 2, "Rosu", 1, "Germania", 141610, 4, 5, 1390, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 80, 7590, true, 0, "Fata", null },
                    { 1868, 4, "Maro", 1, "Belgia", 188000, null, 5, 1600, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 105, 10990, true, 1, "Fata", null },
                    { 1861, 1, "Alte culori", 1, "Romania", 4200, 4, 6, 898, 0, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 759, 90, 12490, true, 0, "Fata", null },
                    { 1869, 5, "Alte culori", 1, "Germania", 15058, 4, 6, 1461, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 485, 111, 13100, null, 0, "Fata", "WDF4157031U193546" },
                    { 1871, 1, "Albastru", 1, "Romania", 66000, 4, 4, 1461, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 70, 3490, true, 0, "Fata", null },
                    { 1872, 6, "Negru", 1, "Romania", 208345, 4, 5, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 204, 22950, true, 0, "4x4 (automat)", "WDC1660041A608105" },
                    { 1873, 3, "Gri", 1, "Romania", 69194, 5, 5, 1390, 0, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 161, 12490, true, 0, "Fata", "WVWZZZ3CZDE121740" },
                    { 1874, 6, "Alb", 1, "Romania", 900, 5, 6, 1798, 4, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 122, 25470, true, 0, "Fata", null },
                    { 1875, 6, "Negru", 1, "Germania", 23200, 5, 6, 2993, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 300, 64218, null, 0, "4x4 (automat)", null },
                    { 1876, 6, "Maro", 1, "Germania", 210000, 5, 5, 1200, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 174, 105, 6490, null, 0, "Fata", null },
                    { 1877, 6, "Gri", 1, "Romania", 82727, 4, 6, 2967, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 262, 35500, true, 0, "4x4 (automat)", "WVGZZZ7PZHD015251" },
                    { 1870, 6, "Negru", 1, null, 67000, 5, 5, 4367, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 600, 339, 48000, true, 0, "4x4 (automat)", null },
                    { 1878, 1, "Negru", 1, "Germania", 183000, null, 5, 1995, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 143, 4950, null, 1, "Spate", null },
                    { 1860, 8, "Alb", 1, "Romania", 157000, 3, 5, 1800, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, null, 10850, true, 1, "Fata", null },
                    { 1858, 2, "Gri", 1, "Germania", 154443, 4, 5, 1598, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 7690, null, 0, "Fata", null },
                    { 1842, 6, "Alb", 1, "Germania", 124987, 4, 5, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 266, 25750, null, 0, "4x4 (automat)", null },
                    { 1843, 2, "Alb", 1, "Romania", 84585, 4, 6, 1568, 0, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 115, 8000, true, 0, "Fata", "W0LPC5ED7FG095069" },
                    { 1844, 6, "Gri", 1, "Germania", 128875, 4, 5, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 266, 23000, null, 0, "4x4 (automat)", null },
                    { 1845, 3, "Gri", 1, "Olanda", 248253, null, 5, 1560, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 8190, null, 0, "Fata", null },
                    { 1846, 6, "Gri", 1, "Germania", 128875, 4, 5, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 266, 23600, null, 0, "4x4 (automat)", null },
                    { 1847, 4, "Albastru", 1, "Germania", 140234, 5, null, 1600, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 116, 4390, null, 1, "Fata", null },
                    { 1848, 2, "Negru", 1, "Germania", 211850, 5, 5, 1968, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 140, 6100, null, 1, "Fata", "wvwzzz1kzbw059047" },
                    { 1859, 1, "Albastru", 1, "Romania", 1300, 5, 6, 1497, 4, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, 100, 15700, true, 0, "Fata", null },
                    { 1849, 6, "Gri", 1, "Germania", 90500, 4, 5, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 266, 24650, null, 0, "4x4 (automat)", null },
                    { 1851, 6, "Negru", 1, "Germania", 130000, 5, 5, 1998, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 177, 17499, null, 1, "4x4 (automat)", null },
                    { 1852, 2, "Alb", 1, "Romania", 23716, 4, 6, 1197, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 110, 14300, true, 0, "Fata", "VSSZZZ5FZJR134804" },
                    { 1853, 3, "Negru", 1, null, 88253, 4, null, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 16500, null, 0, null, null },
                    { 1854, 3, "Negru", 1, null, 59236, 4, null, 1995, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 218, 26100, null, 0, null, null },
                    { 1855, 5, "Alb", 1, "Romania", 140432, 5, 5, 1598, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 102, 7590, true, 0, "Fata", "WV2ZZZ2KZEX135102" },
                    { 1856, 6, "Alb", 1, "Romania", 239000, 4, 4, 2494, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 338, 88, 12300, true, 1, "4x4-manual", null },
                    { 1857, 3, "Gri", 1, null, 217000, null, 5, 1998, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 322, 126, 7190, null, 1, "Fata", null },
                    { 1850, 6, "Alb", 1, "Italia", 180000, 5, 6, 2000, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 551, 150, 17490, null, 1, "4x4 (automat)", "WAUZZZ8U4FR042620" },
                    { 1841, 1, "Alb", 1, "Romania", 98712, 5, 5, 1499, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 5699, true, 0, "Fata", "WF0DXXGAKDFK38577" },
                    { 1879, 2, "Gri", 1, "Romania", 100431, 5, 6, 999, 0, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 125, 8390, true, 0, "Fata", "WF04XXGCC4FJ10687" },
                    { 1881, 4, "Gri", 1, "Germania", 185000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, null, 3500, null, 1, null, null },
                    { 1902, 3, "Verde", 1, "Franta", 213000, 5, 4, 2497, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 177, 4900, null, 0, "Spate", "WBANC510X0CR26152" },
                    { 1903, 3, "Gri", 1, "Romania", 104124, 5, 5, 1968, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 140, 14490, true, 0, "Fata", "TMBAE73T5E9039982" },
                    { 1904, 6, "Albastru", 1, "Romania", 5500, 4, 6, 2198, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, 160, 24500, true, 0, "4x4 (automat)", null },
                    { 1905, 6, "Gri", 1, null, 158800, null, 6, 2398, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 190, 19900, null, 0, "4x4 (automat)", "YV1DZA5C6G2856520" },
                    { 1906, 3, "Gri", 1, null, 185804, 4, null, 1968, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 118, 11500, null, 0, null, "WAUZZZ8K5DN011282" },
                    { 1907, 3, "Albastru", 1, "Spania", 182000, 4, null, 5600, 0, 1, new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 786, 240, 15000, true, 0, null, null },
                    { 1908, 6, "Rosu", 1, "Franta", 122927, 5, 6, 1461, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 110, 13490, null, 0, "Fata", "VF1RFE00355306458" },
                    { 1901, 3, "Negru", 1, "Romania", 54675, 4, 6, 2150, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 204, 25000, true, 0, "4x4 (automat)", "WDD2050091R075643" },
                    { 1909, 1, "Alte culori", 1, "Belgia", 142000, null, 5, 1400, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, null, 4500, null, 1, "Fata", null },
                    { 1911, 4, "Negru", 1, "Germania", 240000, 5, 4, 1998, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 170, 5900, null, 1, "4x4 (automat)", "WAUZZZ8E57A216882" },
                    { 1912, 2, "Gri", 1, null, 93000, 3, 4, 1390, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 90, 1990, true, 1, "Spate", null },
                    { 1913, 4, "Maro", 1, "Germania", 198500, 5, 5, 1582, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 575, 128, 8450, null, 0, "Fata", null },
                    { 1914, 3, "Argint", 1, "Romania", 92043, 4, 6, 2000, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 184, 17500, true, 0, "4x4 (automat)", "TMBCK7NE1G0182287" },
                    { 1915, 6, "Maro", 1, "Germania", 198450, null, 5, 1968, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 14290, null, 1, "4x4 (automat)", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 1916, 6, "Alb", 0, null, 1, 4, 6, 1598, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 116, 30233, null, 0, "Fata", null },
                    { 1917, 5, "Negru", 1, "Franta", 193000, null, 4, 1968, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 604, 140, 3650, null, 0, "Fata", null },
                    { 1910, 0, "Negru", 1, "Germania", 140000, null, null, 998, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 307, 68, 4350, true, 0, "Fata", "JTNML11090J019838" },
                    { 1880, 2, "Albastru", 1, null, 100000, null, null, null, 0, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 876, null, 8550, null, 1, null, null },
                    { 1900, 6, "Negru", 1, "Romania", 9000, 4, 6, 2198, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, 160, 24500, true, 0, "4x4 (automat)", null },
                    { 1898, 5, "Albastru", 1, "Germania", 133000, null, 5, 1500, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 90, 9600, null, 1, "Fata", null },
                    { 1882, 2, "Negru", 1, "Romania", 5325, 5, 6, 1461, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 110, 14890, true, 0, "Fata", "VF1RFB00157599117" },
                    { 1883, 3, "Auriu", 1, null, 116000, 4, null, 2800, 0, 1, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 528, 185, 5400, null, 0, null, null },
                    { 1884, 4, "Negru", 1, "Germania", 268000, 5, 5, 1968, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 170, 4800, null, 0, "Fata", "WVWZZZ3CZ9E107589" },
                    { 1885, 6, "Gri", 1, "Romania", 1, 5, 6, 2487, 4, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, 187, 36640, null, 0, "Fata", null },
                    { 1886, 6, "Gri", 1, "Romania", 105, 5, 6, 1332, 0, 0, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 150, 18250, true, 0, "Fata", "VF1HJD20562349607" },
                    { 1887, 2, "Gri", 1, "Romania", 147216, 5, 6, 1560, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 100, 7190, true, 0, "Fata", "VF3LBBHYBFS193992" },
                    { 1888, 3, "Rosu", 1, "Germania", 65000, 4, 6, 1995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 372, 190, 20990, null, 0, "4x4 (automat)", null },
                    { 1899, 6, "Negru", 1, "Germania", 69000, 5, 5, 1590, 0, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 105, 8650, null, 0, "4x4 (automat)", "uu1hsdarn49301963" },
                    { 1889, 5, "Alte culori", 1, null, 206000, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 432, null, 5200, null, 1, null, "WV2ZZZ7HZ5H030270" },
                    { 1891, 3, "Negru", 1, "Romania", 115000, 4, 5, 2000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 14500, true, 0, "Fata", "WVWZZZ3CZEP009127" },
                    { 1892, 2, "Negru", 1, null, 166000, null, null, null, 0, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, null, 4200, null, 1, null, null },
                    { 1893, 3, "Negru", 1, "Romania", 74897, 4, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 17950, true, 0, "Fata", "WAUZZZ8K9FA178416" },
                    { 1894, 5, "Negru", 1, "Belgia", 199681, 5, 5, 1995, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 130, 7950, null, 0, "Fata", null },
                    { 1895, 2, "Albastru", 1, "Romania", 74114, 5, 5, 1995, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 143, 11290, true, 0, "Spate", "WBA1C11030E943175" },
                    { 1896, 6, "Gri", 1, "Romania", 1000, 5, 6, 2755, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 339, 177, 61100, null, 0, "4x4 (automat)", null },
                    { 1897, 6, "Gri", 0, null, 1, 4, 6, 1598, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 116, 30629, null, 0, "Fata", null },
                    { 1890, 3, "Negru", 1, "Olanda", 200000, null, 4, 2700, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 204, 3800, null, 0, "Fata", null },
                    { 1760, 6, "Maro", 1, "Germania", 10579, 4, 6, 2298, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 249, 191, 32420, null, 0, "4x4 (automat)", null },
                    { 1840, 6, "Negru", 1, "Romania", 103000, null, null, 3000, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 240, 18500, true, 1, "4x4 (automat)", null },
                    { 1838, 3, "Albastru", 1, null, 210000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 5300, null, 1, null, null },
                    { 1782, 3, "Albastru", 1, "Romania", 14732, 5, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 163, 210, 13436, true, 0, "4x4 (automat)", "ZAREAEGU1H7530219" },
                    { 1783, 6, "Verde", 1, "Germania", 15600, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 136, 24350, null, 0, "Fata", null },
                    { 1784, 5, "Albastru", 1, null, 170000, null, 6, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 130, 8200, null, 1, "Fata", null },
                    { 1785, 6, "Negru", 1, "Romania", 318000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, null, 8900, null, 1, null, null },
                    { 1601, 3, "Auriu", 1, "Germania", 190000, null, 5, 2200, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 177, 9400, true, 1, "Spate", null },
                    { 1787, 4, "Albastru", 1, "Germania", 183000, null, 6, 1600, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 7380, null, 1, null, null },
                    { 1788, 6, "Rosu", 1, "Germania", 32431, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 136, 22900, null, 0, "4x4 (automat)", null },
                    { 1781, 6, "Negru", 1, "Germania", 13171, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 136, 23550, null, 0, "Fata", null },
                    { 1789, 4, "Gri", 1, null, 209583, 5, 5, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 150, 9500, true, 0, "Fata", null },
                    { 1791, 4, "Argint", 1, "Franta", 233000, null, 5, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 6999, true, 1, "Fata", null },
                    { 1792, 6, "Argint", 1, "Germania", 4843, 4, 6, 1461, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 109, 23000, null, 0, "Fata", null },
                    { 1793, 6, "Alb", 1, "Germania", 37147, 4, 6, 1461, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 109, 20060, null, 0, "Fata", null },
                    { 1794, 4, "Alb", 1, "Olanda", 206246, null, 6, 1560, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 110, 12300, null, 0, "Fata", null },
                    { 1795, 5, "Albastru", 1, "Germania", 186000, null, 4, 1698, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, 105, 1700, null, 1, "Fata", null },
                    { 1796, 6, "Negru", 1, "Germania", 17215, 4, 6, 1461, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 109, 23800, null, 0, "Fata", null },
                    { 1797, 6, "Negru", 1, "Franta", 126531, 5, 6, 1560, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 120, 10950, null, 0, "Fata", "VF30UBHZTGS114916" },
                    { 1790, 6, "Maro", 1, "Germania", 9008, 4, 6, 1461, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 109, 23450, null, 0, "Fata", null },
                    { 1798, 4, "Gri", 1, null, 188700, 5, 6, 1600, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 10400, true, 1, "Fata", "WVWZZZAUZGP531365" },
                    { 1780, 6, "Gri", 1, "Germania", 10891, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 136, 23850, null, 0, "Fata", null },
                    { 1778, 6, "Negru", 1, "Germania", 21162, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 177, 24290, null, 0, "4x4 (automat)", null },
                    { 1762, 3, "Gri", 1, null, 193799, 5, 3, 1998, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 142, 3200, true, 0, "Fata", null },
                    { 1763, 6, "Albastru", 1, "Germania", 99000, 5, 6, 2989, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, 260, 31850, null, 1, "4x4 (automat)", null },
                    { 1764, 3, "Alb", 1, "Romania", 73500, 4, 6, 1968, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, 110, 10800, true, 0, "Fata", null },
                    { 1765, 1, "Albastru", 1, "Olanda", 198000, null, 4, 1596, 0, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 101, 2350, null, 0, null, null },
                    { 1766, 3, "Negru", 1, "Germania", 168000, 5, 5, 1990, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 177, 17800, true, 1, "Fata", null },
                    { 1767, 6, "Alb", 1, "Germania", 42750, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 177, 24260, null, 0, "Fata", null },
                    { 1768, 6, "Maro", 1, "Germania", 20542, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 177, 25450, null, 0, "4x4 (automat)", null },
                    { 1779, 6, "Negru", 1, "Romania", 71400, 5, 6, 1995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 190, 25980, null, 0, "4x4 (automat)", null },
                    { 1769, 3, "Negru", 1, "Germania", 228000, 5, 4, 1998, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 120, 2499, null, 0, "Fata", null },
                    { 1771, 2, "Gri", 1, null, 110500, 4, null, 1368, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 852, 75, 3700, true, 1, null, "ZFA19900001702242" },
                    { 1772, 6, "Gri", 1, "Germania", 15738, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 177, 25100, null, 0, "4x4 (automat)", null },
                    { 1773, 4, "Gri", 1, null, 199821, null, 5, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 150, 9500, true, 0, "Fata", null },
                    { 1774, 6, "Negru", 1, "Germania", 20942, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 177, 25100, null, 0, "4x4 (automat)", null },
                    { 1775, 6, "Albastru", 1, "Germania", 4800, null, null, 2995, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 340, 78500, null, 0, "4x4 (automat)", null },
                    { 1776, 6, "Negru", 1, "Germania", 18134, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 177, 25450, null, 0, "4x4 (automat)", null },
                    { 1777, 6, "Negru", 1, "Germania", 21161, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 177, 24690, null, 0, "4x4 (automat)", null },
                    { 1770, 6, "Negru", 1, "Germania", 21215, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 177, 24690, null, 0, "4x4 (automat)", null },
                    { 1839, 6, "Gri", 1, "Germania", 122800, 4, 5, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 266, 24690, null, 0, "4x4 (automat)", null },
                    { 1799, 6, "Negru", 1, "Germania", 20000, 4, 6, 1461, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 109, 24600, null, 0, "Fata", null },
                    { 1801, 5, "Negru", 1, "Germania", 70000, 5, 5, 1398, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, 101, 6850, null, 0, "Fata", "W0LSC9223C4054589" },
                    { 1822, 6, "Negru", 1, "Germania", 111000, 5, 6, 2000, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 598, 190, 28500, null, 1, "4x4 (automat)", null },
                    { 1823, 6, "Negru", 1, "Germania", 113661, 4, 5, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 21750, null, 0, "4x4 (automat)", null },
                    { 1824, 6, "Alb", 1, "Germania", 50900, 4, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 23450, null, 0, "4x4 (automat)", null },
                    { 1825, 6, "Gri", 1, "Germania", 116500, 4, 5, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 21250, null, 0, "4x4 (automat)", null },
                    { 1826, 1, "Alb", 1, "Romania", 143502, 4, null, 1200, 0, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 60, 4950, true, 1, "Fata", null },
                    { 1827, 6, "Argint", 1, "Germania", 145799, 4, 5, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 20390, null, 0, "4x4 (automat)", null },
                    { 1828, 6, "Negru", 1, "Germania", 67650, 4, 5, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 23387, null, 0, "4x4 (automat)", null },
                    { 1821, 5, "Alb", 1, "Germania", 178000, 4, 4, 2500, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 432, 136, 6800, true, 0, "Fata", null },
                    { 1829, 6, "Negru", 1, "Germania", 67650, 4, 5, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 23387, null, 0, "4x4 (automat)", null },
                    { 1831, 5, "Gri", 1, null, 159000, null, 5, 1600, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 649, 116, 6600, true, 1, "Fata", null },
                    { 1832, 6, "Negru", 1, "Germania", 98700, 4, 5, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 23450, null, 0, "4x4 (automat)", null },
                    { 1833, 3, "Albastru", 1, "Romania", 220000, null, null, 1956, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 131, 5200, true, 1, "Fata", null },
                    { 1834, 6, "Negru", 1, "Olanda", 162543, 5, null, 1568, 2, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 105, 6150, null, 1, "Fata", null },
                    { 1835, 6, "Negru", 1, "Germania", 69000, 4, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 24600, null, 0, "4x4 (automat)", null },
                    { 1836, 0, "Rosu", 1, "Romania", 2900, 5, 6, 998, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 325, 69, 10700, true, 0, "Fata", null },
                    { 1837, 6, "Negru", 1, "Germania", 47000, 4, 5, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 25050, null, 0, "4x4 (automat)", null },
                    { 1830, 6, "Negru", 1, "Germania", 135100, 4, 5, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 22650, null, 0, "4x4 (automat)", null },
                    { 1800, 2, "Alb", 1, "Franta", 169000, 5, 5, 1461, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 110, 6950, null, 1, "Fata", "VF1BZS00E52321784" },
                    { 1820, 8, "Gri", 1, "Romania", 70650, 3, 6, 2261, 0, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 655, 317, 21500, true, 0, "Spate", null },
                    { 1818, 3, "Negru", 1, null, 51932, 4, 5, 1995, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 17690, null, 0, "Fata", "WBA3D31030J300611" },
                    { 1802, 5, "Gri", 1, "Franta", 160000, 5, 6, 1600, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, 120, 7999, null, 1, "Fata", "VF73DBHZTFJ907350" },
                    { 1803, 4, "Gri", 1, null, 196457, null, 5, 1968, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 150, 9500, true, 0, "Fata", null },
                    { 1804, 1, "Argint", 1, null, 190000, null, null, 1495, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 75, 5750, null, 0, null, null },
                    { 1805, 3, "Argint", 1, null, 12500, null, null, null, 0, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 8500, null, 1, null, "WVWZZZ3CZJE175801" },
                    { 1806, 1, "Gri", 1, null, 228000, null, null, null, 0, null, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 1200, null, 1, null, null },
                    { 1807, 4, "Alb", 1, "Germania", 170000, 5, 5, 1968, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 177, 12400, true, 1, "Fata", "wvwzzz3czde144101" },
                    { 1808, 6, "Alte culori", 1, "Germania", 159000, 5, 5, 2179, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 190, 23950, null, 0, "4x4 (automat)", null },
                    { 1819, 3, "Alb", 1, null, 292000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 6400, null, 1, null, null },
                    { 1809, 6, "Argint", 1, "Germania", 79983, 4, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 24250, null, 0, "4x4 (automat)", null },
                    { 1811, 3, "Negru", 1, null, 23000, null, 5, 3000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 313, 28990, true, 1, "4x4 (automat)", "WAUZZZ4G3EN189680" },
                    { 1812, 3, "Negru", 1, null, 106912, 4, null, 2993, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 258, 16900, null, 0, null, null },
                    { 1813, 3, "Gri", 1, null, 193112, null, null, 1968, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 8650, null, 1, null, null },
                    { 1814, 5, "Maro", 1, "Romania", 121368, 5, null, 1982, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 102, 12999, true, 0, "Fata", "WV2ZZZ2KZHX003397" },
                    { 1815, 6, "Alte culori", 1, "Germania", 219000, null, null, 3000, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 338, null, 11990, null, 1, null, null },
                    { 1816, 6, "Negru", 1, "Germania", 39000, 5, 6, 1995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 386, 140, 34500, true, 0, "4x4 (automat)", null },
                    { 1817, 4, "Negru", 1, null, 164000, null, null, null, 1, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 8190, null, 1, null, null },
                    { 1810, 3, "Alb", 1, "Romania", 51826, 4, 6, 1997, 0, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 20990, true, 0, "4x4 (automat)", "WBA3C31000F797591" },
                    { 1600, 6, "Maro", 1, "Germania", 257000, 5, 5, 2993, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 245, 15990, true, 1, "4x4 (automat)", null },
                    { 1573, 3, "Gri", 1, "Romania", 219000, 5, null, 2000, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 200, 5000, null, 1, "Spate", null },
                    { 1598, 4, "Albastru", 1, null, 288000, 5, null, 1998, 0, 0, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 137, 140, 499, null, 1, "Spate", null },
                    { 1382, 6, "Negru", 1, "Germania", 100400, 5, 5, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 185, 14800, null, 1, "4x4 (automat)", "TMAJU81VDEJ606321" },
                    { 1383, 3, "Alte culori", 1, null, 425000, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, null, 5800, null, 1, null, null },
                    { 1384, 6, "Argint", 1, null, 199999, null, null, null, 0, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 707, null, 3900, null, 1, null, null },
                    { 1385, 4, "Negru", 1, "Germania", 257000, 5, 5, 1998, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 801, 163, 8250, null, 0, "Fata", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 1386, 8, "Alb", 1, "Germania", 9601, 4, 6, 2926, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 489, 245, 51500, null, 0, "Spate", null },
                    { 1387, 3, "Negru", 1, null, 83000, 4, 5, 2143, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 136, 18490, true, 0, null, null },
                    { 1388, 5, "Alb", 1, "Italia", 223000, 5, 4, 2402, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 140, 8199, null, 0, "Spate", null },
                    { 1381, 6, "Gri", 1, "Romania", 44014, 5, 5, 1461, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 8499, true, 0, "Fata", "UU1HSDADF52686148" },
                    { 1389, 5, "Albastru", 1, "Germania", 247000, 5, 4, 1896, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 105, 3100, true, 1, "Fata", null },
                    { 1391, 4, "Gri", 1, "Germania", 184288, 5, 5, 1968, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 7550, null, 0, "Fata", "WVWZZZ3CZCE144181" },
                    { 1392, 3, "Negru", 1, null, 311384, null, 5, 1968, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 6700, null, 0, null, "WVWZZZ3CZAP031697" },
                    { 1393, 6, "Negru", 1, "Polonia", 226524, 5, 4, 1900, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, 180, 4900, null, 0, "4x4-manual", null },
                    { 1394, 4, "Negru", 1, "Franta", 299000, 5, null, 1560, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 110, 2890, true, 1, null, null },
                    { 1395, 3, "Maro", 1, "Romania", 49500, 4, null, 1998, 0, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 252, 120, 14500, true, 1, "Fata", null },
                    { 1396, 0, "Argint", 1, "Romania", 37319, 5, 6, 999, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 417, 60, 6999, true, 0, "Fata", "WVWZZZAAZGD047224" },
                    { 1397, 4, "Alte culori", 1, "Germania", 236482, 5, 5, 2000, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 166, 7350, true, 1, "Fata", null },
                    { 1390, 3, "Negru", 1, "Germania", 18500, 4, 6, 2143, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 30500, null, 0, "Spate", null },
                    { 1398, 4, "Gri", 1, "Germania", 204000, 5, 4, 1896, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 105, 5490, true, 0, "Fata", null },
                    { 1380, 3, "Alb", 1, null, 204000, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, null, 7800, null, 0, null, null },
                    { 1378, 6, "Maro", 1, "Germania", 7912, 5, 6, 2967, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 239, 44033, null, 0, null, null },
                    { 1362, 6, "Maro", 1, "Franta", 120086, 5, 5, 1997, 4, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 200, 9990, null, 0, "Fata", "VF3HURHC8ES244104" },
                    { 1363, 4, "Alb", 1, "Germania", 225700, 4, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 14118, null, 0, "Fata", "WVWZZZ3CZGE033078" },
                    { 1364, 5, "Argint", 1, null, 119700, 5, 5, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 140, 14600, true, 0, "Fata", null },
                    { 1365, 6, "Negru", 1, null, 149000, null, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, null, 4000, null, 1, null, null },
                    { 1366, 6, "Negru", 1, "Romania", 185000, null, 5, 6199, 0, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 403, 35000, true, 1, "4x4 (automat)", null },
                    { 1367, 2, "Gri", 1, null, 141300, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, null, 6100, null, 1, null, "WF0KXXGCBKBT00890" },
                    { 1368, 6, "Albastru", 1, null, 239000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, null, 10450, null, 1, null, null },
                    { 1379, 6, "Argint", 1, "Germania", 75000, 4, 4, 4500, 0, 1, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 340, 6500, true, 1, "4x4 (automat)", "WP1AB29P14LA74812" },
                    { 1369, 4, "Maro", 1, null, 220000, 5, 5, 1968, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 7790, null, 1, "Fata", null },
                    { 1371, 6, "Negru", 1, "Olanda", 188645, null, null, 1998, 4, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 204, 9400, null, 1, "4x4 (automat)", "vf3hurhc8es021381" },
                    { 1372, 5, "Argint", 1, "Germania", 135500, 5, 5, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 105, 10990, true, 0, "Fata", null },
                    { 1373, 6, "Gri", 1, "Germania", 189900, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 737, null, 7299, null, 0, null, null },
                    { 1374, 6, "Alb", 1, "Romania", 17603, 5, 6, 1598, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 130, 22690, true, 0, "4x4 (automat)", "SJNFDNJ11U2239714" },
                    { 1375, 3, "Negru", 1, null, 218000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 4150, null, 1, null, null },
                    { 1376, 1, "Gri", 1, null, 144248, 2, 4, 1389, 0, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 129, 90, 1750, null, 0, "Fata", null },
                    { 1377, 4, "Argint", 1, "Germania", 202300, 5, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 10084, null, 0, "Fata", null },
                    { 1370, 4, "Gri", 1, "Olanda", 168000, 5, 4, 1560, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 109, 3490, null, 1, "Fata", null },
                    { 1361, 3, "Negru", 1, "Spania", 220011, 5, 4, 1900, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 2800, null, 0, "Fata", null },
                    { 1399, 3, "Gri", 1, "Romania", 76235, 4, 5, 1968, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 13400, true, 0, "Fata", "WVWZZZ3CZEE113394" },
                    { 1401, 6, "Alb", 1, "Germania", 150000, 4, 5, 2200, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 150, 21900, true, 0, "4x4 (automat)", null },
                    { 1422, 6, "Negru", 1, null, 161000, null, 4, 2185, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, 177, 5599, null, 0, "4x4 (automat)", null },
                    { 1423, 3, "Maro", 1, "Germania", 174000, 4, 4, 1795, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 160, 6200, true, 0, null, null },
                    { 1424, 3, "Albastru", 1, "Germania", 6000, 4, 6, 4395, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 625, 85822, true, 0, "4x4 (automat)", null },
                    { 1425, 3, "Negru", 1, null, 177456, 5, 6, 1995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 372, 190, 19790, null, 1, "Spate", "WBA4E91040G286798" },
                    { 1426, 4, "Albastru", 1, "Germania", 216000, 5, 4, 1900, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 130, 3799, null, 0, "Fata", null },
                    { 1427, 6, "Negru", 1, null, 260000, null, null, 2400, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 806, 185, 7900, true, 1, "4x4 (automat)", null },
                    { 1428, 6, "Auriu", 1, "Germania", 129000, 4, 5, 2179, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 14500, true, 0, "4x4 (automat)", null },
                    { 1421, 3, "Gri", 1, "Germania", 198858, null, 5, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 177, 15900, null, 0, "4x4 (automat)", "WAUZZZ8K8FN020433" },
                    { 1429, 3, "Maro", 1, null, 150000, 5, 5, 1998, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 163, 8950, null, 1, "Fata", null },
                    { 1431, 6, "Alb", 1, "Romania", 12500, 4, 6, 1995, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 150, 34958, true, 0, "4x4 (automat)", null },
                    { 1432, 6, "Maro", 0, null, 10, 4, 6, 898, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 90, 12400, null, 0, "Fata", null },
                    { 1433, 5, "Alb", 1, "Belgia", 125680, null, 5, 1248, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 127, 90, 6400, null, 1, "Fata", null },
                    { 1434, 2, "Gri", 1, null, 196000, null, null, 1598, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, null, 3499, null, 0, null, null },
                    { 1435, 4, "Argint", 1, "Germania", 266500, 5, 4, 1968, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 4199, null, 1, "Fata", "WAUZZZ8E47A019539" },
                    { 1436, 6, "Negru", 1, "Germania", 187000, 5, null, 2500, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 177, 8250, true, 0, "4x4 (automat)", null },
                    { 1437, 5, "Alb", 1, "Romania", 26761, 3, 6, 1461, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 90, 9600, true, 0, "Fata", "UU18SDPJ557271708" },
                    { 1430, 3, "Argint", 1, "Germania", 273000, 4, 4, 2142, 1, 1, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 150, 3950, true, 0, "Spate", "wdb2110061a028536" },
                    { 1400, 3, "Negru", 1, null, 184000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 10900, null, 1, null, null },
                    { 1420, 6, "Gri", 1, "Italia", 204000, 5, 4, 2188, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 155, 6390, null, 0, "4x4 (automat)", null },
                    { 1418, 3, "Rosu", 1, null, 248000, 5, 4, 2998, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 232, 6390, true, 0, "Spate", null },
                    { 1402, 3, "Negru", 1, "Germania", 9500, null, null, 2925, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 492, 286, 51000, null, 0, "4x4 (automat)", null },
                    { 1403, 5, "Alb", 1, "Italia", 173000, 5, 4, 2198, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 110, 4250, null, 0, "Fata", null },
                    { 1404, 4, "Negru", 1, null, 202000, null, 4, 1986, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 3590, null, 0, "Fata", null },
                    { 1405, 6, "Gri", 0, "Romania", 1, 5, 6, 1498, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 120, 17980, null, 0, "Fata", null },
                    { 1406, 6, "Negru", 1, "Romania", 156058, 5, 5, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 184, 12490, true, 0, "4x4 (automat)", null },
                    { 1407, 6, "Negru", 1, "Romania", 84735, 5, 6, 2987, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 45000, true, 0, "4x4 (automat)", "WDC1660241A699484" },
                    { 1408, 6, "Negru", 1, "Italia", 218000, 4, 4, 2000, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 707, 140, 4850, null, 1, "4x4-manual", null },
                    { 1419, 6, "Alb", 1, "Germania", 161886, 5, 6, 1560, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 100, 9990, true, 0, "Fata", "VF70BBHYBFE506970" },
                    { 1409, 3, "Gri", 1, "Germania", 187403, 5, 4, 1995, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 150, 5850, true, 1, "Spate", "WBAVA71030KR37839" },
                    { 1411, 6, "Alb", 1, "Romania", 147615, 2, 5, 2198, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, 150, 10900, true, 0, "4x4-manual", null },
                    { 1412, 6, "Albastru", 1, "Romania", 127500, null, 5, 2967, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 240, 17000, true, 1, "4x4 (automat)", null },
                    { 1413, 4, "Gri", 1, "Germania", 150000, 4, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 115, 8150, null, 1, "Fata", null },
                    { 1414, 1, "Albastru", 1, "Germania", 259000, 5, 4, 1700, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 127, 101, 2100, null, 0, "Fata", null },
                    { 1415, 5, "Gri", 1, null, 195000, 5, null, 1900, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 105, 3599, null, 0, "Fata", null },
                    { 1416, 4, "Rosu", 1, null, 234000, null, null, 1998, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 7900, null, 0, null, null },
                    { 1417, 6, "Alb", 1, null, 108000, 5, 5, 1995, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 184, 13850, true, 1, "4x4 (automat)", "TMAJU81VDCJ314886" },
                    { 1410, 4, "Alb", 1, "Romania", 67000, 5, null, 1500, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 90, 6199, true, 0, "Fata", null },
                    { 1438, 6, "Alb", 1, null, 148000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, null, 10300, null, 1, null, "Jtmbb31v90d057627" },
                    { 1360, 6, "Verde", 1, null, 275000, null, null, null, 1, null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 339, null, 5500, null, 1, null, null },
                    { 1358, 5, "Gri", 1, "Germania", 190000, 5, 4, 1796, 2, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 140, 4300, true, 1, "Fata", null },
                    { 1302, 4, "Albastru", 1, null, 240000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, null, 5300, null, 1, null, null },
                    { 1303, 3, "Alb", 1, "Germania", 18450, 4, 6, 1998, 0, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 252, 41400, null, 0, "4x4 (automat)", null },
                    { 1304, 3, "Alb", 1, "Germania", 136174, 4, 5, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 17174, null, 1, "Spate", "WBA3D3107FK276607" },
                    { 1305, 1, "Alb", 1, "Romania", 174621, 5, 5, 1400, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, 90, 3400, true, 0, "Fata", "VNKKC98350A284424" },
                    { 1306, 6, "Gri", 1, "Germania", 149000, 5, 5, 1995, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 163, 13990, null, 0, "4x4 (automat)", null },
                    { 1307, 3, "Gri", 1, "Romania", 155000, 5, null, 2987, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 291, null, 15500, true, 1, "4x4 (automat)", "WDC1641201A565612" },
                    { 1308, 4, "Maro", 1, "Germania", 92100, 5, 5, 1798, 0, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 160, 12353, null, 0, "Fata", null },
                    { 1301, 2, "Gri", 1, "Romania", 163000, null, 5, 1398, 1, null, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 321, 90, 7150, true, 1, "Fata", null },
                    { 1309, 7, "Negru", 1, null, 218000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 408, null, 5500, null, 1, null, null },
                    { 1311, 3, "Alb", 1, "Germania", 24775, 4, 6, 1998, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 252, 40300, null, 0, "4x4 (automat)", null },
                    { 1312, 8, "Alb", 1, "Germania", 40000, null, null, 3824, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 355, 54000, true, 1, null, null },
                    { 1313, 3, "Auriu", 1, null, 178000, 5, 5, 1400, 0, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 122, 6490, null, 1, "Fata", null },
                    { 1314, 4, "Gri", 1, "Franta", 147000, 5, 6, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 110, 6500, null, 0, "Fata", "W0LPE8E6XF8010183" },
                    { 1315, 3, "Rosu", 1, "Romania", 49000, 5, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 488, 170, 21850, true, 0, "Spate", "WDD1179031N225614" },
                    { 1316, 3, "Gri", 1, null, 175000, 4, 6, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 151, 15990, null, 1, "Spate", null },
                    { 1317, 2, "Argint", 1, "Germania", 51660, 4, 6, 1598, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 12350, true, 1, "Fata", "WVWZZZAUZGP004456" },
                    { 1310, 4, "Gri", 1, "Romania", 2000000, 5, null, 2000, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 150, 11500, true, 1, null, null },
                    { 1318, 5, "Gri", 1, "Germania", 196500, null, 5, 2149, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 659, 175, 6700, null, 1, "Fata", null },
                    { 1300, 4, "Negru", 1, "Romania", 172000, 5, 6, 2967, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 546, 272, 27500, true, 1, "4x4 (automat)", "WAUZZZ4G9FN023875" },
                    { 1298, 3, "Gri", 1, "Belgia", 211000, 4, 6, 1995, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 163, 14900, true, 1, "Spate", "WBA5C31000D046558" },
                    { 1282, 8, "Gri", 0, null, 10, null, null, 2999, 0, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 325, 367, 110534, null, 0, "4x4 (automat)", "0987654321" },
                    { 1283, 3, "Auriu", 1, "Germania", 211500, 5, 5, 1968, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 170, 8100, null, 1, "Fata", null },
                    { 1284, 6, "Albastru", 1, "Romania", 188718, 5, 5, 1500, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 5800, true, 0, "4x4-manual", "UU1HSDACN49680818" },
                    { 1285, 3, "Negru", 1, "Romania", 42000, 5, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 177, 20950, true, 0, "4x4 (automat)", "WDD2050051F256745" },
                    { 1286, 6, "Negru", 1, "Germania", 97000, null, 6, 4400, 0, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 630, 66900, null, 1, "4x4 (automat)", null },
                    { 1287, 6, "Maro", 1, "Germania", 82300, 4, 6, 1995, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 231, 26400, null, 0, "4x4 (automat)", null },
                    { 1288, 2, "Alb", 1, "Romania", 152000, null, 5, 1197, 0, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 105, 5400, true, 0, "Fata", "VSSZZZ1PZBR045604" },
                    { 1299, 3, "Alb", 1, "Romania", 29436, 4, 6, 1586, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 136, 17450, true, 0, "Fata", "W0LGM5E35H1044213" },
                    { 1289, 3, "Argint", 1, "Franta", 134000, 5, 5, 2000, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 163, 6700, null, 1, "Fata", null },
                    { 1291, 6, "Gri", 1, "Germania", 120100, 4, 6, 2987, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 37059, null, 0, "4x4 (automat)", null },
                    { 1292, 5, "Gri", 1, null, 220000, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, null, 14000, null, 1, null, null },
                    { 1293, 3, "Albastru", 1, "Romania", 32500, 5, 5, 1560, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 92, 5500, true, 0, "Fata", "VF3DD9HP0CJ732946" },
                    { 1294, 5, "Gri", 1, "Franta", 71821, 5, 4, 1560, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 644, 109, 4500, null, 0, "Fata", null },
                    { 1295, 1, "Alte culori", 1, null, 176000, null, null, 1298, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, null, 3700, null, 0, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 1296, 6, "Negru", 1, "Germania", 79500, 4, 6, 1995, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 190, 24200, null, 0, "4x4 (automat)", null },
                    { 1297, 6, "Negru", 1, "Germania", 380000, null, 4, 3000, 1, 1, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 215, 4400, true, 1, "4x4-manual", null },
                    { 1290, 5, "Verde", 1, null, 216000, 5, 4, 2148, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 141, 110, 7300, null, 1, null, null },
                    { 1359, 3, "Gri", 1, "Germania", 27000, 4, 6, 2999, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 492, 367, 53000, null, 0, "4x4 (automat)", null },
                    { 1319, 3, "Gri", 1, "Romania", 157055, 4, 4, 1461, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 70, 2990, true, 0, "Fata", "UU1LSDJKH38462696" },
                    { 1321, 3, "Gri", 1, "Germania", 22030, 4, 6, 1995, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 191, 31400, null, 0, "Fata", null },
                    { 1342, 3, "Negru", 1, "Germania", 226000, null, 5, 1968, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 150, 11250, null, 0, "Fata", null },
                    { 1343, 1, "Negru", 1, "Germania", 230000, 5, 4, 2997, 1, 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 426, 245, 5499, true, 1, "4x4 (automat)", null },
                    { 1344, 4, "Negru", 1, null, 245270, null, null, null, 1, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 288, null, 2500, null, 1, null, null },
                    { 1345, 6, "Negru", 1, null, 86970, 5, null, 2967, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 262, 23350, null, 0, null, null },
                    { 1346, 3, "Alte culori", 1, "Germania", 168700, 4, 6, 2996, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 320, 46700, null, 0, "4x4 (automat)", null },
                    { 1347, 2, "Gri", 1, "Romania", 26000, 4, 6, 1598, 2, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 115, 11550, true, 1, "Fata", "W0LPD5EDXGG136213" },
                    { 1348, 4, "Argint", 1, null, 300000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, null, 2200, null, 1, null, null },
                    { 1341, 3, "Albastru", 1, "Romania", 65000, 5, 6, 2000, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 372, 190, 27000, true, 1, "4x4 (automat)", null },
                    { 1349, 8, "Negru", 1, null, 98000, 3, null, 2143, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 170, 13500, true, 1, "Spate", null },
                    { 1351, 3, "Negru", 1, "Germania", 5750, null, 6, 2999, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 492, 367, 53000, true, 0, "4x4 (automat)", null },
                    { 1352, 6, "Gri", 1, null, 248000, 5, 4, 2143, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 155, 5950, null, 1, "4x4 (automat)", "KMHSH81WP8U325021" },
                    { 1353, 6, "Alb", 1, "Romania", 18500, 5, 6, 1969, 4, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 806, 408, 60000, true, 1, "4x4 (automat)", null },
                    { 1354, 3, "Alb", 1, "Germania", 144440, 5, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 18590, null, 0, "Fata", null },
                    { 1355, 1, "Negru", 1, "Germania", 154000, 5, 4, 1200, 0, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 129, 75, 2299, null, 0, "Fata", null },
                    { 1356, 6, "Negru", 1, null, 296000, 4, 5, 1968, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 170, 12900, true, 0, "4x4 (automat)", null },
                    { 1357, 2, "Albastru", 1, "Germania", 240000, null, 6, 1399, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 6650, true, 1, "Fata", null },
                    { 1350, 3, "Verde", 1, null, 242739, null, null, null, 0, null, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 2990, null, 1, null, "WVWZZZ3BZ3P285773" },
                    { 1320, 4, "Gri", 1, null, 309000, null, 4, 1968, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 170, 3750, true, 1, "Fata", null },
                    { 1340, 5, "Alb", 0, null, 1, 2, 6, 2300, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, 130, 17800, null, 0, "Fata", "W0VVSY604JB153255" },
                    { 1338, 5, "Alb", 1, "Germania", 71000, 2, 5, 1596, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 105, 9700, null, 0, "Fata", null },
                    { 1322, 6, "Negru", 0, null, 1, 4, 6, 1968, 1, 0, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 551, 150, 41900, null, 0, "4x4 (automat)", null },
                    { 1323, 8, "Negru", 1, null, 230000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, null, 11000, null, 1, null, null },
                    { 1324, 3, "Gri", 1, "Germania", 218851, 5, null, 1560, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 116, 7850, null, 1, null, null },
                    { 1325, 5, "Gri", 1, null, 198000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, null, 3990, null, 0, null, null },
                    { 1326, 3, "Argint", 1, "Romania", 164000, 4, 4, 1997, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, 163, 6490, true, 1, "Fata", null },
                    { 1327, 3, "Albastru", 1, "Germania", 94000, 5, 4, 1580, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 110, 9490, true, 1, "Fata", null },
                    { 1328, 6, "Alb", 1, null, 170000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, null, 8000, null, 1, null, null },
                    { 1339, 2, "Albastru", 1, "Statele Unite ale Americii", 28550, 5, null, 2000, 0, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 157, 220, 23300, null, 1, "Fata", "3VW547AU1HM009655" },
                    { 1329, 3, "Alb", 1, "Romania", 38800, null, 6, 900, 0, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 90, 6799, true, 1, "Fata", null },
                    { 1331, 1, "Gri", 1, "Romania", 265000, null, 4, 1500, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 139, 75, 2450, true, 1, "Fata", null },
                    { 1332, 2, "Argint", 1, "Germania", 185000, 5, 4, 1600, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 115, 3799, null, 0, "Fata", null },
                    { 1333, 1, "Gri", 1, null, 210000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, null, 6450, null, 1, null, null },
                    { 1334, 3, "Gri", 1, "Romania", 24685, 4, 6, 1968, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 190, 36300, true, 0, "4x4 (automat)", "WAUZZZ4G7HN019939" },
                    { 1335, 1, "Argint", 1, null, 237000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, null, 13400, null, 1, null, null },
                    { 1336, 2, "Bej", 1, null, 170000, null, null, null, 1, null, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, null, 8490, null, 1, null, null },
                    { 1337, 6, "Argint", 1, "Romania", 266900, null, null, 2685, 1, 1, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 738, 163, 4500, null, 1, "4x4 (automat)", null },
                    { 1330, 6, "Alb", 1, "Romania", 59900, null, 6, 2000, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 296, 150, 17800, true, 0, "4x4 (automat)", null },
                    { 1599, 6, "Negru", 1, "Romania", 87000, null, 6, 2989, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491, 258, 45800, true, 0, "4x4 (automat)", null },
                    { 1439, 3, "Negru", 1, "Belgia", 116000, 5, 4, 1980, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 177, 8900, null, 1, "Spate", "WBANX31060CW76398" },
                    { 1441, 6, "Negru", 1, "Austria", 236000, 4, 4, 2500, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, 143, 7150, null, 1, "4x4-manual", null },
                    { 1542, 6, "Alb", 1, "Germania", 203600, 4, 5, 2143, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 11950, null, 1, "4x4 (automat)", null },
                    { 1543, 4, "Alb", 1, "Germania", 238000, 5, 4, 1900, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 101, 3600, true, 1, "Fata", "TMBJS21U498833505" },
                    { 1544, 5, "Albastru", 1, "Germania", 203000, 4, 4, 1898, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 125, 3300, true, 1, "Fata", null },
                    { 1545, 5, "Albastru", 1, "Germania", 175000, 5, 5, 2000, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 659, 140, 11600, true, 1, "Fata", "WF0SXXGBWSAA22083" },
                    { 1546, 4, "Negru", 1, null, 160000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 5900, null, 1, null, null },
                    { 1547, 2, "Verde", 1, null, 222000, 2, null, 1600, 0, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 868, 115, 1999, true, 0, "Fata", null },
                    { 1548, 6, "Gri", 1, null, 202000, 4, null, 1870, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, 130, 5200, true, 0, "4x4-manual", null },
                    { 1541, 6, "Gri", 1, null, 240000, null, null, 2998, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 235, 11700, true, 1, "4x4 (automat)", null },
                    { 1549, 3, "Negru", 1, null, 199000, null, 6, 1995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 190, 19950, null, 1, "4x4 (automat)", "WBA8C91020K650981" },
                    { 1551, 6, "Negru", 1, "Germania", 167000, null, null, 1997, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 163, 15850, null, 1, "4x4 (automat)", "WF0AXXWPMAEU72743" },
                    { 1552, 1, "Gri", 1, null, 206000, null, 5, 2995, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 548, 245, 18900, null, 1, "4x4 (automat)", null },
                    { 1553, 3, "Negru", 1, null, 170000, null, 5, 1995, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 143, 10950, null, 1, "Spate", "WBA3D11010F330343" },
                    { 1554, 3, "Negru", 1, "Germania", 194000, 4, 6, 2200, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 488, 170, 15400, true, 0, "Spate", null },
                    { 1555, 0, "Argint", 1, null, 159000, null, 5, null, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 114, 8250, null, 1, "Fata", "YV1MV8481E2123389" },
                    { 1556, 3, "Negru", 1, "Germania", 293000, 4, 5, 2993, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 245, 15990, true, 0, "Spate", null },
                    { 1557, 3, "Negru", 1, "Germania", 267000, 4, 5, 2993, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 548, 245, 16800, true, 0, "4x4 (automat)", null },
                    { 1550, 6, "Negru", 1, null, 205000, 4, null, 1998, 2, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226, 150, 4500, true, 0, "4x4-manual", null },
                    { 1558, 3, "Negru", 1, "Germania", 168000, 4, 6, 2993, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 272, 25900, null, 0, "4x4 (automat)", null },
                    { 1540, 4, "Gri", 1, "Germania", 210000, null, 5, 1600, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 109, 3550, true, 1, "Fata", null },
                    { 1538, 2, "Albastru", 1, null, 41500, null, null, null, 1, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, null, 13900, null, 1, null, null },
                    { 1522, 3, "Negru", 1, "Romania", 68000, 4, 6, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 11000, true, 1, "Fata", "TMBAG7NE2G0185014" },
                    { 1523, 3, "Negru", 1, "Romania", 187816, 4, 6, 1986, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 190, 18499, true, 0, "Fata", "WAUZZZ4G6FN047860" },
                    { 1524, 3, "Gri", 1, "Romania", 1700, 4, 6, 1968, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 150, 24000, true, 0, "Fata", "TMBAH7NP1K7024958" },
                    { 1525, 4, "Albastru", 1, "Germania", 187500, 4, 4, 1800, 0, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 140, 3490, true, 1, "Fata", null },
                    { 1526, 2, "Verde", 1, "Olanda", 229000, null, 6, 1986, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 150, 10000, true, 1, "Fata", null },
                    { 1527, 3, "Gri", 1, null, 231290, 5, 4, 1968, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 4200, true, 0, "Fata", null },
                    { 1528, 3, "Negru", 1, "Germania", 190000, null, null, 2000, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 190, 21600, null, 0, "4x4 (automat)", null },
                    { 1539, 3, "Gri", 1, null, 280000, null, null, null, 1, null, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, null, 2300, null, 1, null, null },
                    { 1529, 8, "Gri", 1, null, 241000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 4150, null, 1, null, null },
                    { 1531, 4, "Gri", 1, "Franta", 290000, 5, 4, 1968, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 4450, null, 0, "Fata", null },
                    { 1532, 1, "Albastru", 1, null, 159230, null, null, null, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, null, 9250, null, 1, null, null },
                    { 1533, 4, "Negru", 1, null, 222000, 4, 4, 2000, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 170, 3950, null, 1, "Fata", null },
                    { 1534, 4, "Alb", 1, "Germania", 201000, null, 5, 1598, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 5500, null, 1, "Fata", null },
                    { 1535, 3, "Albastru", 1, null, 164567, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 329, null, 4750, null, 1, null, null },
                    { 1536, 3, "Negru", 1, null, 212876, 5, 5, 2000, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 140, 9450, null, 0, "Fata", null },
                    { 1537, 4, "Argint", 1, null, 99000, null, 5, 1956, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 120, 9950, true, 1, "Fata", "W0LGM8GR9E1057531" },
                    { 1530, 1, "Gri", 1, null, 219000, 4, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, null, 4790, null, 1, null, null },
                    { 1521, 4, "Alb", 1, null, 153523, null, null, null, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 7490, null, 0, null, null },
                    { 1559, 6, "Maro", 1, "Germania", 223000, null, 5, 1998, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 184, 15990, null, 0, "4x4 (automat)", null },
                    { 1561, 4, "Negru", 1, "Germania", 198000, null, 5, 1956, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 160, 5900, null, 1, "Fata", null },
                    { 1582, 6, "Alb", 1, null, 84000, null, 6, 2993, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 245, 36900, true, 1, null, null },
                    { 1583, 2, "Albastru", 1, "Germania", 181000, 5, null, 1595, 0, 1, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 100, 1500, null, 0, "Fata", "WVWZZZ1JZWW171449" },
                    { 1584, 4, "Bej", 1, "Olanda", 197502, 5, 5, 1589, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 8990, null, 1, "Fata", null },
                    { 1585, 5, "Gri", 1, "Franta", 237197, 4, 5, 1598, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 105, 7450, null, 1, "Fata", "WVGZZZ1TZBW015565" },
                    { 1586, 6, "Albastru", 1, "Germania", 160000, 6, 6, 1998, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 190, 18890, null, 1, "Fata", null },
                    { 1587, 3, "Negru", 1, "Germania", 248500, 5, 4, 1968, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 143, 2650, null, 1, "Fata", null },
                    { 1588, 6, "Alte culori", 1, "Romania", 49500, 5, 5, 2179, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 190, 27480, true, 0, "4x4 (automat)", "SALVA2BE2FH981877" },
                    { 1581, 8, "Albastru", 1, null, 106000, null, 5, 1800, 0, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 180, 11500, true, 0, "Spate", null },
                    { 1589, 3, "Rosu", 1, null, 135000, null, null, null, 0, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, null, 11000, null, 1, null, null },
                    { 1591, 6, "Negru", 1, "Germania", 70000, 4, 6, 2987, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 39900, null, 1, "4x4 (automat)", null },
                    { 1592, 6, "Albastru", 1, "Romania", 209000, 5, 4, 3200, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 297, 200, 10650, true, 1, "4x4-manual", null },
                    { 1593, 3, "Negru", 1, "Germania", 165000, 4, 6, 1998, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 797, 181, 12890, null, 1, "Fata", null },
                    { 1594, 2, "Negru", 1, null, 137500, 4, 6, 2191, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 252, 150, 11500, null, 1, "Fata", null },
                    { 1595, 4, "Negru", 1, "Germania", 173669, null, 5, 1560, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 105, 6999, null, 1, "Fata", null },
                    { 1596, 3, "Gri", 1, "Germania", 69000, 4, 5, 1595, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, 105, 6900, true, 1, "Fata", "WVWZZZ16ZBM069612" },
                    { 1597, 3, "Argint", 1, null, 245000, null, 4, 1896, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 105, 5300, null, 1, "Fata", null },
                    { 1590, 6, "Alb", 1, "Germania", 212000, 5, 5, 2993, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 245, 23990, null, 1, "4x4 (automat)", null },
                    { 1560, 1, "Rosu", 1, null, 152000, 2, null, 1199, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, 75, 5000, null, 1, "Fata", null },
                    { 1580, 4, "Gri", 1, "Germania", 243782, 5, 4, 1686, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 125, 3950, null, 1, "Fata", "W0L0AHL3592102078" },
                    { 1578, 6, "Alb", 1, "Germania", 152790, 4, 5, 2993, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 381, 27900, true, 1, "4x4 (automat)", null },
                    { 1562, 4, "Negru", 1, "Danemarca", 212321, null, 5, 1600, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 4999, null, 0, "Fata", null },
                    { 1563, 6, "Gri", 1, "Germania", 5000, 5, 6, 2995, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 340, 86334, null, 0, "4x4 (automat)", null },
                    { 1564, 4, "Albastru", 1, "Italia", 137000, 5, 5, 1560, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 109, 4600, true, 1, "Fata", "WF0SXXGCDSAU04811" },
                    { 1565, 5, "Maro", 1, "Franta", 187000, 5, 4, 1997, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, 135, 3680, null, 0, "Fata", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 1566, 6, "Maro", 1, "Germania", 149000, null, 5, 1995, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 593, 136, 12950, null, 0, "4x4 (automat)", null },
                    { 1567, 5, "Gri", 1, "Romania", 133120, 5, 6, 2000, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 431, 150, 15650, null, 1, "Fata", null },
                    { 1568, 5, "Alb", 1, "Romania", 158609, 4, 5, 1600, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 102, 7650, true, 1, "Fata", null },
                    { 1579, 3, "Gri", 1, "Germania", 169000, 4, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 190, 23750, null, 1, "Fata", null },
                    { 1569, 8, "Negru", 1, "Romania", 143000, 2, 5, 1995, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 170, 7900, true, 1, null, null },
                    { 1571, 6, "Negru", 1, "Germania", 218000, 5, 4, 3000, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 738, 218, 6000, null, 1, "4x4 (automat)", null },
                    { 1572, 6, "Gri", 0, "Germania", 10, 5, 6, 2487, 4, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, 218, 31330, null, 0, "4x4 (automat)", null },
                    { 1918, 4, "Negru", 1, "Romania", 232500, 5, 3, 1895, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 131, 2250, true, 1, null, null },
                    { 1574, 3, "Gri", 1, "Germania", 212500, 5, 5, 2000, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 188, 13000, true, 1, "Fata", null },
                    { 1575, 4, "Gri", 1, "Germania", 66000, null, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 204, 22499, true, 1, "Spate", null },
                    { 1576, 5, "Rosu", 1, "Germania", 140095, 6, 6, 1968, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 102, 17500, null, 0, null, "WV2ZZZ2KZHX014825" },
                    { 1577, 4, "Rosu", 1, "Germania", 183000, 5, 5, 2000, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 150, 12500, true, 1, "Fata", "YV1MV5150F2203406" },
                    { 1570, 1, "Rosu", 1, "Romania", 93000, 5, 6, 1400, 4, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, 100, 8490, true, 1, null, null },
                    { 1440, 3, "Rosu", 1, "Romania", 92000, null, 4, 4600, 0, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 380, 14900, true, 1, "Spate", null },
                    { 1520, 4, "Alb", 1, null, 147665, null, null, null, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 8290, null, 0, null, null },
                    { 1518, 6, "Argint", 1, "Franta", 45000, 5, 6, 1500, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 110, 14800, null, 1, "Fata", "VF1RFE00058313091" },
                    { 1462, 1, "Gri", 1, "Belgia", 104281, null, 5, 1199, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 75, 4500, null, 0, "Fata", "TMBEK25J8C3116661" },
                    { 1463, 2, "Gri", 1, "Germania", 159000, 5, 5, 1598, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 110, 8400, null, 1, "Fata", null },
                    { 1464, 4, "Albastru", 1, "Romania", 6700, 4, 6, 900, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 90, 10750, true, 0, "Fata", null },
                    { 1465, 6, "Alb", 1, "Ungaria", 1, 5, 6, 1373, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 456, 140, 18260, null, 0, "Fata", null },
                    { 1466, 6, "Negru", 1, "Statele Unite ale Americii", 9416, 4, 6, 2999, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 717, 350, 45500, true, 0, "4x4 (automat)", null },
                    { 1467, 6, "Gri", 1, "Germania", 234500, null, 4, 2500, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 288, null, 9900, true, 1, "4x4-manual", null },
                    { 1468, 1, "Alte culori", 1, "Belgia", 168722, null, 5, 1199, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 75, 4400, null, 0, "Fata", "TMBEK25J8B3071719" },
                    { 1461, 6, "Alb", 1, "Germania", 179000, 5, 5, 1997, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 163, 12990, null, 1, "4x4 (automat)", null },
                    { 1469, 6, "Argint", 0, null, 7, null, 6, 1991, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 211, 49632, null, 0, null, null },
                    { 1471, 6, "Gri", 1, "Romania", 42000, 4, 6, 1590, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 279, 115, 12000, true, 1, "Fata", null },
                    { 1472, 0, "Negru", 1, "Germania", 82000, 3, 5, 999, 0, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 838, 71, 3350, null, 1, "Spate", null },
                    { 1473, 5, "Alb", 1, null, 202442, 5, 4, 1686, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, 101, 2000, null, 0, "Fata", "W0L0XCE7564004713" },
                    { 1474, 6, "Alb", 1, "Franta", 186000, 5, 5, 1461, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 754, 110, 8290, null, 0, "Fata", "SJNFCAF15U6259384" },
                    { 1475, 4, "Albastru", 1, "Romania", 233000, 5, 5, 1995, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 218, 14500, true, 1, "4x4 (automat)", null },
                    { 1476, 1, "Negru", 1, "Germania", 220000, 4, null, 1422, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 80, 3480, true, 1, "Fata", null },
                    { 1477, 6, "Negru", 1, "Germania", 198000, 4, 5, 2400, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 163, 12400, null, 1, "4x4 (automat)", null },
                    { 1470, 6, "Gri", 1, "Romania", 7659, 5, 6, 1598, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 130, 21500, true, 0, "Fata", "SJNFDAJ11U2235001" },
                    { 1478, 6, "Negru", 1, null, 1, null, null, 2498, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, null, 3950, null, 0, null, null },
                    { 1460, 3, "Alte culori", 1, null, 233000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, null, 4500, null, 1, null, null },
                    { 1458, 3, "Negru", 1, null, 248000, null, null, null, 0, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 322, null, 3000, null, 1, null, null },
                    { 1442, 3, "Verde", 1, null, 1, null, null, 1998, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 721, null, 2300, null, 0, null, null },
                    { 1443, 3, "Alb", 1, "Germania", 225000, null, 3, 1686, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 75, 1490, true, 0, "Fata", null },
                    { 1444, 6, "Alb", 1, "Franta", 129440, 5, 6, 1461, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 110, 12200, null, 1, "Fata", "VF1RFE00656147154" },
                    { 1445, 3, "Maro", 1, "Germania", 191000, 4, 5, 2967, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 204, 13900, true, 0, "Fata", null },
                    { 1446, 6, "Alb", 1, "Germania", 125900, 5, 5, 1997, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 184, 12000, true, 1, "4x4-manual", null },
                    { 1447, 6, "Maro", 1, "Japonia", 46205, 5, 6, 2755, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 339, 177, 50250, true, 0, "4x4 (automat)", "JTEBR3FJ70K052788" },
                    { 1448, 2, "Alb", 1, "Romania", 7396, 5, 6, 1798, 4, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 321, 122, 19402, true, 0, "Fata", "SB1MS3JE80E370224" },
                    { 1459, 6, "Negru", 1, null, 83963, 5, 5, 1461, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 110, 12990, null, 0, "Fata", "SJNFAAJ11U1026457" },
                    { 1449, 3, "Negru", 1, "Germania", 46000, 5, 6, 2993, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 320, 49990, null, 0, "4x4 (automat)", "WBA7C610X0G582538" },
                    { 1451, 3, "Argint", 1, "Romania", 117625, 4, 5, 1598, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 9199, true, 0, "Fata", "TMBAG7NE0E0153675" },
                    { 1452, 2, "Negru", 1, null, 221000, 4, null, 1900, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 3700, true, 1, null, null },
                    { 1453, 5, "Alb", 1, "Romania", 187000, null, null, null, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 515, null, 10500, null, 1, null, null },
                    { 1454, 3, "Gri", 1, "Olanda", 183244, 5, 6, 1598, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 120, 12950, null, 1, "Fata", null },
                    { 1455, 6, "Alb", 1, "Germania", 230475, null, 5, 2967, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 240, 14350, true, 0, "4x4 (automat)", "WVGZZZ7PZBD014680" },
                    { 1456, 6, "Negru", 1, null, 72000, null, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 170, 27100, null, 0, "4x4 (automat)", null },
                    { 1457, 4, "Gri", 1, null, 248000, 5, 4, 2967, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 546, 232, 7490, null, 0, "4x4 (automat)", "WAUZZZ4F87N021575" },
                    { 1450, 1, "Gri", 1, "Germania", 270000, 4, 5, 2993, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 205, 11299, true, 1, "Spate", "WBAFW31070C282755" },
                    { 1519, 3, "Gri", 1, "Germania", 173000, 4, 4, 1998, 0, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 462, 95, 3100, true, 1, "Spate", null },
                    { 1479, 3, "Alb", 1, "Germania", 148000, 4, 6, 2993, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 258, 19900, true, 0, "4x4 (automat)", "wba5d31080d575642" },
                    { 1481, 6, "Gri", 1, "Germania", 140574, 5, 4, 2696, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 160, 4300, null, 1, "4x4-manual", "KPTS0C1FS7P062002" },
                    { 1502, 4, "Negru", 1, "Olanda", 230000, 5, 5, 1560, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, 112, 5650, true, 1, "Fata", null },
                    { 1503, 3, "Alb", 1, "Olanda", 148000, 5, 5, 2000, 4, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 200, 10250, null, 1, "4x4 (automat)", "VF38DRHC8DL046770" },
                    { 1504, 3, "Negru", 1, null, 250000, null, 5, 2000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 163, 7700, null, 1, "Fata", null },
                    { 1505, 3, "Gri", 1, "Germania", 177000, null, 4, 1800, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 160, 7399, null, 0, "Fata", null },
                    { 1506, 0, "Argint", 1, null, 94000, null, null, 1000, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, 69, 4400, true, 1, "Fata", null },
                    { 1507, 4, "Alb", 1, null, 198000, 5, 5, 1968, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 422, 177, 11110, null, 1, "4x4 (automat)", null },
                    { 1508, 1, "Alb", 1, null, 116000, null, null, null, 2, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 5600, null, 1, null, null },
                    { 1501, 0, "Negru", 1, null, 228000, null, 4, 3000, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 553, 233, 9900, null, 1, null, null },
                    { 1509, 5, "Gri", 1, "Austria", 198000, 1, 6, 1998, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 431, 150, 13390, null, 1, null, "WVWZZZ7NZGV220641" },
                    { 1511, 1, "Rosu", 1, "Japonia", 1, 5, 6, 1373, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 453, 140, 19050, null, 0, "Fata", null },
                    { 1512, 3, "Negru", 1, null, 281000, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, null, 4500, null, 1, null, "WDB2030071A866271" },
                    { 1513, 6, "Alb", 1, null, 127000, null, null, 2500, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, null, 2600, null, 0, null, null },
                    { 1514, 6, "Gri", 1, null, 212500, null, 4, 2997, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 235, 10850, null, 1, "4x4 (automat)", null },
                    { 1515, 6, "Gri", 1, null, 215000, 5, 5, 2488, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 170, 8150, null, 0, "4x4-manual", null },
                    { 1516, 3, "Alb", 1, null, 194200, null, 5, 1997, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, 150, 6900, null, 1, "Fata", null },
                    { 1517, 2, "Negru", 1, "Belgia", 187000, 5, 6, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 143, 14850, null, 1, null, "WBA3Y11050D900909" },
                    { 1510, 5, "Gri", 1, "Germania", 198000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 412, null, 3650, null, 0, null, null },
                    { 1480, 3, "Alb", 1, null, 175000, null, null, 2998, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, null, 18990, null, 0, null, null },
                    { 1500, 4, "Negru", 1, "Romania", 350548, null, null, 1896, 1, null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 116, 1000, true, 1, "Fata", null },
                    { 1498, 6, "Alb", 1, "Germania", 196000, 5, 5, 1986, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 170, 11590, null, 1, "4x4 (automat)", null },
                    { 1482, 1, "Albastru", 1, "Japonia", 1, null, 6, 1272, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 447, 90, 12980, null, 0, "4x4 (automat)", null },
                    { 1483, 0, "Rosu", 1, null, 2000, null, null, null, 0, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 325, null, 9900, null, 0, null, "JTDKGNEC40N381858" },
                    { 1484, 3, "Verde", 1, null, 262000, null, null, 1998, 1, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, null, 1990, null, 0, null, null },
                    { 1485, 3, "Argint", 1, "Germania", 201000, 5, 4, 1997, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, 144, 4700, null, 1, "Fata", "VF7RDRHRH54012825" },
                    { 1486, 3, "Gri", 1, null, 233000, null, null, 1998, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, null, 5390, null, 0, null, null },
                    { 1487, 3, "Alb", 1, "Romania", 119000, 4, 5, 1596, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 95, 5800, true, 0, "Fata", "WF0MXXGCBMET57812" },
                    { 1488, 4, "Rosu", 1, "Germania", 110000, null, 4, 1200, 0, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 80, 1690, null, 1, "Fata", null },
                    { 1499, 3, "Negru", 0, null, 1, 4, 6, 2925, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 340, 126600, null, 0, "4x4 (automat)", null },
                    { 1489, 6, "Alb", 1, null, 205000, null, null, null, 4, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, null, 22350, null, 1, null, null },
                    { 1491, 2, "Gri", 1, "Ungaria", 1, 5, 6, 1242, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 443, 90, 13970, null, 0, "Fata", null },
                    { 1492, 3, "Gri", 1, "Germania", 220000, 4, 4, 2995, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 235, 8950, null, 0, null, null },
                    { 1493, 6, "Negru", 1, "Germania", 22000, null, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491, 170, 38620, null, 0, "4x4 (automat)", null },
                    { 1494, 4, "Albastru", 1, "Germania", 186000, 5, 6, 1499, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 120, 8350, null, 1, "Fata", "WF06XXGCC6FU35065" },
                    { 1495, 1, "Alb", 1, "Romania", 3349, 5, 6, 898, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 90, 13050, true, 0, "Fata", "VF15RB20A60799918" },
                    { 1496, 6, "Albastru", 1, null, 168000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, null, 11600, null, 1, null, "WBAVP31060VN08474" },
                    { 1497, 0, "Rosu", 1, "Romania", 26173, 5, 6, 998, 0, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 325, 70, 7790, true, 0, "Fata", null },
                    { 1490, 0, "Albastru", 1, "Romania", 164000, 2, null, 1595, 0, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 868, 115, 2900, true, 1, "Fata", null },
                    { 1919, 6, "Auriu", 1, "Romania", 157, 5, 6, 1332, 0, 0, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 130, 17750, true, 0, "Fata", "VF1HJD20X62349621" },
                    { 1947, 6, "Alb", 1, "Germania", 119400, 4, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 170, 27200, null, 0, "4x4 (automat)", null },
                    { 1921, 4, "Alb", 1, "Romania", 146000, 5, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 150, 17350, true, 0, "Fata", null },
                    { 2343, 3, "Alb", 1, "Germania", 208000, 5, 4, 1900, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 105, 4990, null, 0, "Fata", null },
                    { 2344, 1, "Alb", 1, "Romania", 126000, null, 6, 900, 0, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 90, 4670, true, 1, "Fata", null },
                    { 2345, 4, "Gri", 1, "Germania", 187000, 5, 5, 2000, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 190, 11250, null, 0, "Fata", null },
                    { 2346, 6, "Alb", 1, "Franta", 135000, 5, null, 4391, 0, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 555, 35000, null, 1, "4x4 (automat)", null },
                    { 2347, 1, "Alb", 1, "Romania", 132000, null, 5, 1200, 2, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 3700, true, 1, "Fata", null },
                    { 2348, 3, "Maro", 1, "Romania", 139990, 4, 6, 1998, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 15900, null, 1, "Fata", null },
                    { 2349, 6, "Alte culori", 1, "Germania", 172000, 5, 5, 1560, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 90, 8600, null, 1, "Fata", "VF70B9HPGEE519743" },
                    { 2342, 6, "Alte culori", 1, null, 162121, 4, 5, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 131, 12499, null, 0, "4x4 (automat)", null },
                    { 2350, 6, "Negru", 1, "Italia", 318000, null, 5, 1995, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 184, 11500, true, 1, "4x4 (automat)", null },
                    { 2352, 2, "Alte culori", 1, "Germania", 151450, 5, 5, 1600, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 120, 6990, null, 0, "Fata", null },
                    { 2353, 6, "Maro", 1, "Germania", 167500, null, 5, null, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 245, 19850, null, 1, "4x4 (automat)", null },
                    { 2354, 4, "Maro", 1, "Germania", 176500, null, 5, 2993, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 546, 245, 18999, null, 0, "4x4 (automat)", null },
                    { 2355, 0, "Negru", 1, null, 222000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 412, null, 10700, null, 1, null, null },
                    { 2356, 1, "Negru", 1, null, 161000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, null, 4000, null, 1, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 2357, 5, "Argint", 1, "Romania", 39000, 5, 6, 1995, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 669, 131, 18900, true, 1, "Fata", null },
                    { 2358, 3, "Gri", 1, null, 195000, null, 4, 1995, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 5500, true, 1, "Fata", null },
                    { 2351, 6, "Alb", 1, "Franta", 150000, 5, 6, 1600, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 130, 13199, null, 1, "Fata", "SJNFDAJ11U1802280" },
                    { 2359, 1, "Alb", 1, "Romania", 86000, null, 5, 1200, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 3790, true, 1, "Fata", null },
                    { 2341, 5, "Gri", 1, "Belgia", 145500, 5, 5, 1958, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 136, 6990, true, 1, "Fata", null },
                    { 2339, 6, "Negru", 1, "Franta", 165000, 5, 6, 1600, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 120, 8900, null, 1, "Fata", "VF30UBHZTFS239516" },
                    { 2323, 6, "Alb", 1, "Germania", 48400, 5, 5, 2198, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 197, 19950, null, 0, "4x4 (automat)", "KMHSW81XDFU505039" },
                    { 2324, 4, "Auriu", 1, "Germania", 228400, null, 5, 1986, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 140, 5800, true, 1, "Fata", null },
                    { 2325, 5, "Gri", 1, "Germania", 194000, null, 4, 1400, 2, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 173, 90, 3199, null, 0, "Fata", null },
                    { 2326, 4, "Maro", 1, "Belgia", 169000, 5, 5, 1968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 143, 11500, null, 1, "Fata", "WAUZZZ8K0DA061305" },
                    { 2327, 3, "Gri", 1, null, 169000, null, null, null, 0, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, null, 3900, null, 1, null, null },
                    { 2328, 6, "Gri", 1, null, 208000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 783, null, 10990, null, 1, null, null },
                    { 2329, 3, "Negru", 1, "Germania", 158900, 5, 6, 2194, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 16350, null, 1, "Spate", null },
                    { 2340, 3, "Alte culori", 1, null, 215000, null, null, null, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, null, 10800, null, 1, null, null },
                    { 2330, 6, "Alb", 1, "Germania", 85863, 5, 5, 2198, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 197, 17500, null, 0, "4x4 (automat)", "KMHSU81XDEU332385" },
                    { 2332, 4, "Gri", 1, null, 245000, 5, 4, 2000, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 4400, null, 1, "Fata", null },
                    { 2333, 5, "Alb", 1, null, 210000, null, null, null, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 216, null, 2800, null, 1, null, null },
                    { 2334, 3, "Negru", 1, "Germania", 193000, null, 6, 2000, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 190, 18960, null, 1, null, "WAUZZZ8TXFA055930" },
                    { 2335, 4, "Alte culori", 1, "Belgia", 199999, 5, 5, 1968, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 143, 8600, null, 1, "Fata", "WAUZZZ4F89N010773" },
                    { 2336, 6, "Gri", 1, null, 251555, 5, 4, 2993, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 235, 13500, true, 0, "4x4 (automat)", null },
                    { 2337, 4, "Gri", 1, "Germania", 193000, 5, 5, 1600, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 5250, null, 1, "Fata", null },
                    { 2338, 4, "Alb", 1, "Germania", 142000, 5, 6, 2000, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 150, 11750, null, 1, "Fata", "WF0FXXWPCFFY49026" },
                    { 2331, 4, "Gri", 1, null, 157000, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, null, 6600, null, 1, null, null },
                    { 2322, 3, "Gri", 1, null, 117400, 4, 6, 1968, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 150, 19970, null, 1, "Fata", "WAUZZZF4XHN022711" },
                    { 2360, 3, "Alb", 1, "Germania", 218000, 5, 4, 1968, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 143, 8500, true, 0, "Fata", null },
                    { 2362, 5, "Auriu", 1, "Germania", 178128, 4, 4, 1992, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 462, 109, 3150, null, 1, "Fata", "WDD1690071J479898" },
                    { 2383, 2, "Albastru", 1, "Belgia", 170461, 5, 5, 1995, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, null, 10490, true, 1, "Spate", null },
                    { 2384, 1, "Gri", 1, "Germania", 52000, 5, 4, 1200, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 60, 2990, null, 1, "Fata", null },
                    { 2385, 4, "Albastru", 1, null, 229000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 5190, null, 1, null, null },
                    { 2386, 1, "Alb", 1, null, 200000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, null, 3400, null, 1, null, null },
                    { 2387, 4, "Alb", 1, "Germania", 196000, 5, 5, 2000, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 160, 8700, null, 1, "Fata", null },
                    { 2388, 3, "Negru", 1, null, 240000, null, null, null, 0, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 3900, null, 1, null, null },
                    { 2389, 6, "Negru", 1, null, 205742, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, null, 17390, null, 1, null, "SALLSAAG4BA296184" },
                    { 2382, 4, "Gri", 1, "Germania", 235150, null, 5, 1686, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 125, 5200, null, 1, "Fata", null },
                    { 2390, 6, "Alb", 1, "Germania", 184000, 5, 5, 2500, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, null, 11900, null, 1, "4x4-manual", null },
                    { 2392, 3, "Maro", 1, null, 166000, null, 5, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 177, 14200, null, 1, "Fata", "WVEZZZ3CZGE506156" },
                    { 2393, 5, "Alb", 1, "Olanda", 298000, null, 4, 2148, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 95, 5200, null, 1, "Spate", null },
                    { 2394, 4, "Gri", 1, "Germania", 192000, 5, 6, 1995, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 190, 16999, null, 1, "Spate", null },
                    { 2395, 3, "Alb", 1, "Germania", 140000, 4, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 190, 20990, true, 1, "4x4 (automat)", null },
                    { 2396, 6, "Gri", 0, "Germania", 13, 5, 6, 1984, 0, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 215, 245, 62000, null, 0, "4x4 (automat)", null },
                    { 2397, 2, "Albastru", 1, "Romania", 116000, 4, 5, 1197, 0, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 175, 86, 6250, true, 1, "Fata", "TMBAM6NH2D4009016" },
                    { 2398, 6, "Alb", 1, "Germania", 147500, null, 5, 2000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 177, 13999, null, 0, "4x4 (automat)", null },
                    { 2391, 5, "Albastru", 1, null, 323178, null, 4, null, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, null, 1700, true, 1, "Fata", null },
                    { 2361, 5, "Argint", 1, "Romania", 233000, null, 4, 2143, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 130, 4250, true, 1, null, "WDF63960313318446" },
                    { 2381, 2, "Maro", 1, "Germania", 175000, 3, 4, 1798, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 221, 140, 5500, null, 1, "Fata", "SHHFN13607U005268" },
                    { 2379, 5, "Gri", 1, "Germania", 275000, 4, 4, 2498, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 432, 130, 6200, null, 1, "Fata", null },
                    { 2363, 3, "Maro", 1, null, 160000, 5, 5, 2967, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 245, 16500, null, 1, "4x4 (automat)", "WAUZZZ4G4BN016357" },
                    { 2364, 3, "Alb", 1, "Germania", 114000, null, 5, 2998, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 216, 300, 43900, true, 1, "Spate", null },
                    { 2365, 3, "Albastru", 1, "Germania", 200, 5, 5, 2150, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 136, 9395, true, 0, null, null },
                    { 2366, 3, "Albastru", 1, null, 181000, 5, 5, 1995, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 116, 11800, null, 1, "Spate", "WBA3D91070J415327" },
                    { 2367, 3, "Negru", 1, "Germania", 234000, 4, 4, 1968, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 5990, null, 1, "Fata", null },
                    { 2368, 3, "Negru", 1, null, 171000, 4, 5, 1995, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 14990, null, 1, "Spate", "WBA3E11040P658279" },
                    { 2369, 6, "Rosu", 0, null, 5, null, null, 1991, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 184, 41534, null, 0, "4x4 (automat)", "WDC1569471J605021" },
                    { 2380, 3, "Gri", 1, "Germania", 198000, 4, 5, 2967, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 426, 234, 13900, null, 1, "4x4 (automat)", "WVWZZZ3DZC8001741" },
                    { 2370, 3, "Negru", 1, "Statele Unite ale Americii", 2500, null, 6, 6417, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 606, 550, 47000, null, 1, "Spate", null },
                    { 2372, 4, "Negru", 1, "Olanda", 190000, null, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 116, 7900, null, 1, "Fata", null },
                    { 2373, 5, "Maro", 1, "Franta", 160701, 5, 5, 1598, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 130, 7000, null, 1, "Fata", "VF1JZNAB649640167" },
                    { 2374, 2, "Gri", 1, "Belgia", 153500, 5, 4, 1595, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 102, 3490, true, 0, "Fata", null },
                    { 2375, 1, "Rosu", 1, "Germania", 146000, 5, 5, 1242, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 60, 4899, null, 1, "Fata", null },
                    { 2376, 0, "Albastru", 1, "Germania", 85421, 4, 5, 1390, 0, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 120, 10900, true, 1, null, null },
                    { 2377, 2, "Gri", 1, "Austria", 162000, 4, 4, 1996, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 140, 4600, true, 1, "Fata", null },
                    { 2378, 8, "Negru", 1, null, 160000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 492, null, 19500, null, 1, null, null },
                    { 2371, 6, "Albastru", 1, "Romania", 70000, 2, 5, 2200, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 190, 21000, true, 1, "4x4 (automat)", null },
                    { 2399, 4, "Negru", 1, null, 193600, 4, 5, 1870, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 130, 5000, true, 1, "Fata", "VF1KZ1S0643708053" },
                    { 2321, 1, "Albastru", 1, "Germania", 169000, 4, 4, 1200, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 75, 3499, null, 0, "Fata", null },
                    { 2319, 8, "Negru", 1, "Romania", 199400, 2, 5, 2143, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 204, 13400, true, 1, "Spate", null },
                    { 2263, 4, "Negru", 1, "Germania", 230000, 4, 4, 1600, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, null, 2850, null, 1, "Fata", null },
                    { 2264, 1, "Albastru", 1, null, 78539, null, 5, 1498, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 6900, true, 0, "Fata", "WF0DXXGAKDFD03578" },
                    { 2265, 4, "Gri", 1, "Germania", 119000, 5, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 190, 18490, null, 0, null, "wvwzzz3czfp409826" },
                    { 2266, 3, "Negru", 1, null, 295000, 4, 5, 2143, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 170, 12800, true, 1, "Spate", "WDD2120021A569967" },
                    { 2267, 8, "Albastru", 1, null, 240000, null, null, 1798, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 570, null, 2900, null, 0, null, null },
                    { 2268, 2, "Bej", 1, "Germania", 176000, null, 5, 3000, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 549, null, 19990, true, 0, "4x4 (automat)", null },
                    { 2269, 1, "Albastru", 1, null, 59197, null, 5, 1498, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 7000, true, 0, "Fata", "WF0DXXGAKDFD03636" },
                    { 2262, 3, "Negru", 1, "Germania", 113000, 5, 4, 2148, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 136, 9490, true, 0, "Spate", null },
                    { 2270, 6, "Gri", 1, null, 42500, 5, 6, 1461, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 109, 11450, null, 0, "4x4 (automat)", null },
                    { 2272, 3, "Verde", 1, null, 35724, 5, 6, 1956, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 170, 15890, null, 0, "Fata", "W0LGT5E16G1119923" },
                    { 2273, 1, "Albastru", 1, null, 37000, null, 5, 1498, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 7200, true, 0, "Fata", "WF0DXXGAKDER09485" },
                    { 2274, 6, "Maro", 1, "Germania", 140000, 5, 6, 1998, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 184, 23999, null, 1, "4x4 (automat)", null },
                    { 2275, 1, "Albastru", 1, null, 33140, null, 5, 1498, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 6900, true, 0, "Fata", "WF0DXXGAKDER09495" },
                    { 2276, 6, "Auriu", 1, "Romania", 133450, null, null, 2967, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 553, 240, 13500, true, 0, "4x4 (automat)", null },
                    { 2277, 3, "Auriu", 1, null, 139000, null, 5, 2000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 14988, null, 1, null, "WBA3E11080J726070" },
                    { 2278, 3, "Gri", 1, null, 1, null, null, 1898, 1, 0, new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, null, 800, null, 0, null, null },
                    { 2271, 3, "Argint", 1, null, 175000, 4, 5, 1598, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 8590, null, 1, "Fata", null },
                    { 2279, 4, "Negru", 1, null, 185000, 4, 5, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 110, 6990, null, 1, "Fata", null },
                    { 2261, 3, "Albastru", 1, "Germania", 98100, 4, 5, 2135, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 21490, true, 1, "Spate", null },
                    { 2259, 4, "Argint", 1, "Romania", 88000, 5, 5, 1686, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 110, 8350, true, 1, "Fata", null },
                    { 2243, 2, "Alb", 1, null, 163000, null, 5, 1400, 2, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 68, 2450, null, 1, "Fata", null },
                    { 2244, 6, "Alb", 1, null, 260000, null, null, 2198, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, null, 8650, null, 0, null, null },
                    { 2245, 3, "Gri", 1, "Romania", 115075, 4, 6, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 5400, true, 0, "Fata", "UU14SDA4451051253" },
                    { 2246, 5, "Alb", 1, "Romania", 79339, 2, 6, 2299, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, 130, 17990, true, 0, "Fata", null },
                    { 2247, 0, "Alb", 1, "Romania", 99502, 5, null, 999, 0, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 166, 75, 4450, true, 0, "Fata", null },
                    { 2248, 2, "Albastru", 1, "Germania", 96500, 4, 4, 1800, 0, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 860, 133, 1250, true, 1, "Fata", null },
                    { 2249, 3, "Gri", 1, null, 308000, null, null, null, 1, null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 2500, null, 1, null, null },
                    { 2260, 1, "Negru", 1, null, 239000, 5, 4, 1896, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 105, 3990, null, 0, "Fata", "VSSZZZ1PZ8R059089" },
                    { 2250, 6, "Gri", 1, null, 89750, null, 4, 2179, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, 160, 6950, null, 0, "4x4 (automat)", "SALFA24B57H057779" },
                    { 2252, 3, "Negru", 1, null, 187000, null, 5, 1987, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 177, 7990, null, 1, "Spate", null },
                    { 2253, 6, "Negru", 1, null, 165000, null, 4, 2500, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 288, 115, 6350, null, 0, null, null },
                    { 2254, 2, "Gri", 1, null, 83596, 5, 5, 1598, 0, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 115, 6990, null, 0, "Fata", "W0LPD6ED1C1103832" },
                    { 2255, 6, "Gri", 1, null, 154828, 5, 6, 2143, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 204, 31990, null, 0, "4x4 (automat)", null },
                    { 2256, 2, "Gri", 1, null, 101194, 4, 5, 1560, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 116, 7400, null, 0, "Fata", "WF0KXXGCBKEY07791" },
                    { 2257, 2, "Gri", 1, "Olanda", 184000, 5, 6, 1800, 4, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 303, 136, 13360, true, 0, "Fata", null },
                    { 2258, 6, "Gri", 1, "Romania", 176000, 5, null, 2231, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, 136, 7500, true, 1, "4x4 (automat)", null },
                    { 2251, 1, "Albastru", 1, null, 52000, null, null, 1500, 1, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 90, 8950, null, 1, null, null },
                    { 2320, 3, "Albastru", 1, "Olanda", 178956, null, 6, 1950, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 194, 27800, null, 1, null, null },
                    { 2280, 6, "Rosu", 1, "Romania", 49000, 4, 6, 1591, 0, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 707, 180, 17880, true, 1, "4x4-manual", "TMAJ3812CHJ216803" },
                    { 2282, 6, "Albastru", 1, null, 38900, 5, 6, 1461, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 109, 11490, null, 0, "4x4 (automat)", null },
                    { 2303, 3, "Gri", 1, "Romania", 56000, null, 5, 2000, 0, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 217, 156, 15999, true, 1, "Fata", null },
                    { 2304, 4, "Negru", 1, null, 158838, 5, 4, 1596, 0, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 101, 1899, null, 0, "Fata", "WF0NXXWPDN4L17399" },
                    { 2305, 3, "Negru", 1, "Luxemburg", 160000, null, 5, 2143, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 143, 11850, true, 1, "Spate", null },
                    { 2306, 3, "Argint", 1, "Germania", 150000, 4, 4, null, 0, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 135, 4200, null, 1, "Spate", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 2307, 3, "Negru", 1, "Franta", 240000, null, 5, 1998, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 177, 13300, null, 0, "Fata", null },
                    { 2308, 5, "Gri", 1, "Romania", 65000, null, 6, 2150, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 669, 155, 12990, true, 0, "Fata", null },
                    { 2309, 2, "Negru", 1, "Romania", 22500, 5, 6, 1591, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 575, 205, 16000, true, 1, "Fata", null },
                    { 2302, 3, "Rosu", 1, "Romania", 108000, 5, 4, 1242, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 80, 1750, true, 1, "Fata", null },
                    { 2310, 6, "Negru", 1, "Germania", 119000, null, 5, null, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 170, 10750, null, 1, "4x4 (automat)", null },
                    { 2312, 8, "Gri", 1, null, 20000, null, null, null, 1, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, null, 49900, null, 1, null, null },
                    { 2313, 3, "Argint", 1, null, 145000, null, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, null, 6200, null, 1, null, "Wf0exxgbbe7p02203" },
                    { 2314, 6, "Negru", 1, "Germania", 25000, null, 6, 3956, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 553, 450, 81900, null, 1, "4x4 (automat)", null },
                    { 2315, 3, "Negru", 1, null, 265315, 4, 3, 1951, 1, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 136, 2600, true, 1, "Spate", null },
                    { 2316, 6, "Negru", 1, "Romania", 140000, 5, 6, 2000, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226, 150, 14000, true, 1, "4x4 (automat)", "SHSRE5780AU011057" },
                    { 2317, 6, "Argint", 1, "Romania", 34000, 4, 6, 1400, 0, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 174, 150, 9900, true, 1, "4x4 (automat)", null },
                    { 2318, 6, "Gri", 1, "Germania", 162000, 4, 6, 1996, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 386, 190, 24900, null, 1, "4x4 (automat)", null },
                    { 2311, 6, "Alb", 1, "Germania", 189200, 4, null, 1895, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, 130, 7550, null, 1, "4x4-manual", null },
                    { 2281, 2, "Gri", 1, null, 223000, null, null, 1600, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, null, 3200, true, 0, null, null },
                    { 2301, 0, "Gri", 1, "Romania", 49628, 4, 6, 999, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 417, 60, 6500, true, 0, "Fata", "WVWZZZAAZGD042803" },
                    { 2299, 6, "Negru", 1, null, 200000, null, 5, 1968, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 12550, null, 1, "4x4 (automat)", "WVGZZZ5NZCW002059" },
                    { 2283, 5, "Alb", 1, "Romania", 170000, 6, 4, 1461, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 50, 2690, true, 0, null, null },
                    { 2284, 2, "Albastru", 1, null, 82000, 4, 6, 1395, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 125, 10800, true, 1, "Fata", null },
                    { 2285, 3, "Alb", 1, null, 140800, null, 5, 1461, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, null, 5499, true, 1, null, null },
                    { 2286, 3, "Negru", 1, null, 35000, 4, null, null, 0, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 11000, null, 1, null, null },
                    { 2287, 6, "Alb", 1, "Germania", 199000, 4, 4, 1995, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 177, 7999, null, 1, "4x4-manual", null },
                    { 2288, 3, "Negru", 1, null, 35000, 4, null, null, 0, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 11000, null, 1, null, null },
                    { 2289, 3, "Albastru", 1, "Franta", 138650, 5, null, 1598, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 110, 3000, null, 1, null, null },
                    { 2300, 0, "Gri", 1, "Romania", 68626, 4, null, 999, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 417, 60, 6300, true, 0, "Fata", "WVWZZZAAZGD048228" },
                    { 2290, 3, "Gri", 0, null, 1, null, 6, 1364, 0, 0, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 140, 11294, null, 0, null, null },
                    { 2292, 6, "Gri", 1, null, 90000, null, null, null, 0, null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 298, null, 2350, null, 1, null, null },
                    { 2293, 4, "Gri", 1, "Germania", 209000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 4990, null, 1, null, null },
                    { 2294, 3, "Albastru", 1, "Romania", 65000, 4, 4, 1390, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 55, 2990, true, 0, null, null },
                    { 2295, 1, "Alb", 1, "Romania", 18633, 5, 6, 1461, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 90, 11350, true, 0, "Fata", "VF15RKJ0A59435620" },
                    { 2296, 4, "Negru", 1, "Germania", 143000, 4, 6, 1598, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 12900, null, 1, "Fata", null },
                    { 2297, 4, "Gri", 1, null, 219000, null, 4, 2000, 1, 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 3850, null, 1, "Fata", "WAUZZZ8E06A091644" },
                    { 2298, 6, "Alte culori", 1, null, 147400, null, 6, 2000, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 190, 23620, null, 1, "4x4 (automat)", "WBAWZ510500M03206" },
                    { 2291, 4, "Gri", 1, null, 189000, 4, 5, 1968, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 150, 10790, null, 1, "Fata", null },
                    { 2242, 3, "Gri", 1, "Germania", 188650, 4, 4, 1798, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 158, 7700, true, 0, "Fata", null },
                    { 2400, 3, "Gri", 1, "Germania", 240000, null, 4, 2697, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 224, 5650, null, 0, "Fata", null },
                    { 2402, 2, "Albastru", 1, null, 197000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, null, 3100, null, 1, null, null },
                    { 2503, 4, "Rosu", 1, "Germania", 270000, 5, 4, 1998, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 4590, null, 1, "Fata", null },
                    { 2504, 4, "Negru", 1, "Germania", 219250, 5, 6, 1987, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 239, 15990, null, 1, "4x4 (automat)", null },
                    { 2505, 6, "Negru", 1, "Germania", 245000, null, null, null, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 150, 4999, null, 1, "4x4 (automat)", null },
                    { 2506, 3, "Alb", 1, null, 170000, 4, null, 1600, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 7250, null, 1, null, null },
                    { 2507, 3, "Negru", 1, "Germania", 210000, null, null, 2998, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 360, 8900, true, 1, "Spate", null },
                    { 2508, 6, "Alb", 1, null, 197000, 5, 5, 1984, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 163, 9999, null, 1, null, null },
                    { 2509, 2, "Gri", 1, "Austria", 164000, 5, 4, 1900, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 105, 3650, null, 0, "Fata", null },
                    { 2502, 2, "Gri", 1, null, 92000, null, null, null, 1, null, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 575, null, 6000, null, 1, null, "U5YHN516AFL181213" },
                    { 2510, 6, "Alb", 1, "Romania", 169874, 5, 5, 2967, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 300, 24900, true, 1, "4x4 (automat)", "WP1ZZZ92ZBLA20706" },
                    { 2512, 8, "Gri", 1, "Germania", 53000, 2, 4, 4200, 0, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 554, 420, 47000, true, 1, "4x4 (automat)", null },
                    { 2513, 3, "Alb", 1, "Germania", 198000, null, 5, 2998, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 378, 313, 32500, true, 1, "Spate", null },
                    { 2514, 3, "Negru", 1, "Germania", 115000, null, 6, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 218, 19500, true, 1, "Spate", null },
                    { 2515, 4, "Negru", 1, "Germania", 134500, 5, 5, 1870, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 131, 5950, null, 1, "Fata", "VF1KZ1S0644636033" },
                    { 2516, 2, "Albastru", 1, "Germania", 169000, null, null, 2000, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 140, 4199, null, 1, "Fata", null },
                    { 2517, 3, "Negru", 1, "Germania", 192000, null, 5, 1968, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 177, 15100, null, 1, "Fata", null },
                    { 2518, 4, "Gri", 1, null, 170000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, null, 3500, null, 1, null, null },
                    { 2511, 6, "Alb", 1, null, 175000, null, 6, 1995, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 190, 19350, true, 1, "4x4 (automat)", null },
                    { 2519, 3, "Rosu", 1, "Romania", 109286, 5, 5, 1997, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 150, 15900, true, 0, "Fata", "WF0EXXWPCEFL35232" },
                    { 2501, 6, "Maro", 1, null, 170000, null, 6, null, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 150, 15999, null, 1, "Fata", null },
                    { 2499, 3, "Albastru", 1, null, 190000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 4550, null, 1, null, null },
                    { 2483, 2, "Gri", 1, null, 153000, 4, 4, 1600, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 105, 3150, null, 1, "Fata", null },
                    { 2484, 5, "Argint", 1, null, 210000, null, 5, 2148, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 163, 10990, true, 0, "Spate", null },
                    { 2485, 3, "Gri", 1, "Belgia", 171821, 5, 5, 1968, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 403, 140, 12200, null, 1, "Fata", "WVWZZZ3CZFE815231" },
                    { 2486, 6, "Gri", 1, "Franta", 159000, 5, 6, 1560, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 120, 9299, null, 1, "Fata", null },
                    { 2487, 6, "Negru", 1, "Germania", 21155, 5, 6, 2993, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 258, 52846, null, 0, "4x4 (automat)", null },
                    { 2488, 3, "Gri", 1, "Belgia", 125000, 5, null, 1968, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, 140, 5200, null, 0, "Fata", "WVWZZZ1KZ6M643263" },
                    { 2489, 3, "Rosu", 1, "Germania", 3500, 4, 6, 4395, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 600, 129500, null, 0, "Spate", "WBSJF01020G966819" },
                    { 2500, 6, "Negru", 1, "Romania", 150000, 4, null, 2998, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 224, 11900, true, 1, "4x4 (automat)", null },
                    { 2490, 6, "Negru", 1, null, 245000, null, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, null, 12500, null, 1, null, null },
                    { 2492, 2, "Argint", 1, "Germania", 148000, 4, 4, 1600, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 3950, null, 1, "Fata", null },
                    { 2493, 2, "Rosu", 1, "Germania", 156000, 5, 5, 1400, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 122, 5900, null, 1, null, "WVWZZZ1KZAW133201" },
                    { 2494, 4, "Auriu", 1, "Belgia", 143000, 5, 4, 1700, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 101, 3499, null, 0, "Fata", null },
                    { 2495, 3, "Negru", 1, "Germania", 33900, 4, 6, 1950, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 194, 34990, null, 0, "4x4 (automat)", null },
                    { 2496, 2, "Rosu", 1, "Germania", 184000, 4, 4, 2000, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 140, 4550, null, 1, "Fata", null },
                    { 2497, 3, "Gri", 1, "Germania", 253000, 5, 4, 1896, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 116, 4650, null, 0, "Fata", null },
                    { 2498, 6, "Gri", 1, "Germania", 235000, 4, 4, 2497, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 174, 6800, true, 1, "4x4-manual", null },
                    { 2491, 6, "Negru", 1, "Germania", 186800, null, 4, 2500, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 175, 8700, null, 1, "4x4 (automat)", "wvgzzz7lz8d035875" },
                    { 2482, 3, "Argint", 1, "Germania", 182000, 4, 4, 1998, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 6990, null, 1, "Spate", "WBAVC31000VC63136" },
                    { 2520, 6, "Negru", 1, "Romania", 55000, 5, 6, 1997, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 180, 21900, true, 1, "4x4 (automat)", null },
                    { 2522, 2, "Albastru", 1, "Regatul Unit", 115000, 4, 4, 1590, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 114, 1200, null, 1, "Fata", null },
                    { 2543, 6, "Negru", 1, null, 210000, 4, null, 2200, 1, null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 130, null, 1300, null, 1, null, null },
                    { 2544, 2, "Gri", 1, "Germania", 238000, 4, 4, 2000, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 140, 3400, true, 1, "Fata", null },
                    { 2545, 3, "Alte culori", 1, null, 178000, null, 5, 1968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 177, 18800, null, 1, "Fata", "WAUZZZ4G1DN007165" },
                    { 2546, 6, "Albastru", 1, "Romania", 101792, 4, null, 1968, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 13900, true, 0, "4x4 (automat)", "WVGZZZ5NZEW558295" },
                    { 2547, 5, "Gri", 1, null, 225000, 5, 4, 1900, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 130, 2250, null, 0, "Fata", null },
                    { 2548, 3, "Albastru", 1, "Germania", 169000, 5, 4, 1800, 0, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 120, 1990, null, 0, null, null },
                    { 2549, 6, "Maro", 1, "Germania", 162000, 5, 5, 1500, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 754, 110, 7690, true, 1, "Fata", null },
                    { 2542, 6, "Gri", 1, "Germania", 146000, 4, 4, 2998, 0, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 272, 6550, true, 1, "4x4 (automat)", null },
                    { 2550, 1, "Albastru", 1, "Germania", 198000, null, 5, 1598, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 6650, true, 1, "Fata", null },
                    { 2552, 3, "Negru", 1, "Germania", 198000, null, 6, null, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 177, 17999, null, 1, "Spate", null },
                    { 2553, 5, "Albastru", 1, "Germania", 210000, null, 5, 1600, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 105, 6999, null, 1, "Fata", null },
                    { 2554, 3, "Negru", 1, "Romania", 111874, 5, 5, 1968, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 140, 12750, true, 0, "Fata", "TMBAE73T6E9040056" },
                    { 2555, 4, "Negru", 1, null, 138000, null, 5, 1595, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 6900, null, 1, "Fata", null },
                    { 2556, 2, "Bej", 1, "Germania", 180000, null, 4, 1600, 0, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 105, 3000, null, 1, "Fata", null },
                    { 2557, 4, "Argint", 1, "Germania", 202800, 4, 5, 1995, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 177, 7149, null, 1, "Spate", "WBAUX31010A668216" },
                    { 2558, 6, "Albastru", 1, null, 21000, null, 6, 1500, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 10799, null, 0, "4x4 (automat)", null },
                    { 2551, 6, "Gri", 1, null, 189980, 5, 6, 1986, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 551, null, 16799, null, 1, "4x4 (automat)", "WAUZZZ8U5GR101398" },
                    { 2521, 6, "Argint", 1, null, 270000, 5, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, null, 17800, null, 1, null, null },
                    { 2541, 1, "Rosu", 1, null, 157000, 5, 5, 1600, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, null, 3570, null, 1, null, null },
                    { 2539, 4, "Alb", 1, "Germania", 189500, 5, 4, 1900, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 3790, null, 0, "Fata", null },
                    { 2523, 6, "Gri", 1, null, 153000, 5, 4, 1995, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, 116, 4480, true, 1, "4x4-manual", null },
                    { 2524, 6, "Alte culori", 1, null, 68000, null, null, null, 1, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 611, null, 39900, null, 1, null, null },
                    { 2525, 8, "Argint", 1, "Spania", 117000, 2, 5, 1200, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, null, 4150, true, 1, "Fata", null },
                    { 2526, 1, "Alb", 1, null, 151400, null, 5, 1200, 2, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 3900, null, 1, "Fata", null },
                    { 2527, 6, "Gri", 1, null, 166000, null, null, 1980, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 551, null, 14500, null, 1, "4x4 (automat)", null },
                    { 2528, 5, "Gri", 1, null, 273000, null, null, 1900, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 150, 3100, true, 1, "Fata", null },
                    { 2529, 2, "Alb", 1, "Romania", 51000, 5, 5, 1248, 0, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 693, 85, 5350, true, 0, "Fata", "NLHBA51BAFZ292665" },
                    { 2540, 2, "Negru", 1, "Germania", 102000, null, 5, 1200, 0, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 90, 7390, true, 1, "Fata", null },
                    { 2530, 6, "Verde", 1, null, 57175, 5, 6, 1996, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 150, 18300, null, 1, "4x4 (automat)", "WF0AXXWPMAFS26351" },
                    { 2532, 3, "Negru", 1, null, 18515, null, null, 1991, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 184, 29031, null, 0, "4x4 (automat)", "WDD2050431F721834" },
                    { 2533, 3, "Argint", 0, null, 4, null, null, 1991, 0, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 258, 47883, null, 0, "Spate", "WDD2053831F863561" },
                    { 2534, 6, "Rosu", 1, null, 243, null, null, 1993, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226, 184, 33866, null, 0, "4x4 (automat)", "JHMRT6860KX200175" },
                    { 2535, 3, "Negru", 1, null, 12000, 4, 6, 2925, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 240, 82973, true, 0, "4x4 (automat)", "WDD2221351A350614" },
                    { 2536, 4, "Gri", 1, "Germania", 143000, null, 5, 2200, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 322, 150, 8350, null, 1, "Fata", "SB1EA76LX0E040316" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 2537, 3, "Gri", 1, null, 198000, null, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 329, null, 4300, null, 1, null, "JTNBD56E80J000850" },
                    { 2538, 1, "Rosu", 1, "Germania", 156000, 5, 4, 1199, 0, 1, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 129, 74, 1990, null, 0, null, null },
                    { 2531, 8, "Negru", 1, null, 86000, 3, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 372, null, 34500, true, 1, null, "WBA3S91030F800070" },
                    { 2401, 6, "Maro", 1, null, 203000, 5, null, 3000, 1, 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 339, 170, 11000, null, 1, "4x4 (automat)", null },
                    { 2481, 3, "Negru", 1, null, 220000, 5, 6, 1995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 372, 190, 19150, true, 1, "4x4 (automat)", null },
                    { 2479, 6, "Albastru", 1, "Germania", 115000, null, 5, 1995, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 143, 12300, null, 1, "4x4 (automat)", "WBAVP11060VR66391" },
                    { 2423, 3, "Albastru", 1, "Germania", 24500, 4, 6, 1995, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 150, 23900, null, 1, "Spate", null },
                    { 2424, 2, "Rosu", 1, "Germania", 225000, null, null, 1595, 0, 0, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 99, 1199, null, 1, "Fata", null },
                    { 2425, 1, "Gri", 1, "Belgia", 147000, null, 3, 1399, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 50, 1700, true, 1, "Fata", null },
                    { 2426, 4, "Alb", 1, "Germania", 272733, 4, 5, 2698, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 190, 7000, true, 1, "Fata", "WAUZZZ8K6AA038395" },
                    { 2427, 5, "Negru", 1, "Germania", 178500, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, null, 6590, true, 1, null, null },
                    { 2428, 1, "Alb", 1, null, 103000, null, 6, 1500, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 90, 6100, null, 1, "Fata", null },
                    { 2429, 6, "Gri", 1, null, 260000, 5, 4, 2987, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 224, 9480, true, 0, "4x4 (automat)", "4JGBB22E97A201323" },
                    { 2422, 6, "Negru", 0, "Germania", 13, 5, 6, 2967, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 441, 101000, null, 0, "4x4 (automat)", null },
                    { 2430, 2, "Alte culori", 1, "Austria", 160000, 4, 4, 1400, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, 80, 3750, null, 1, "Fata", null },
                    { 2432, 4, "Alb", 1, "Germania", 203000, 5, 5, 1995, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 7490, null, 0, null, null },
                    { 2433, 4, "Argint", 1, "Germania", 228500, 5, 4, 1968, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 4900, true, 1, "Fata", "WVWZZZ3CZ6E073617" },
                    { 2434, 2, "Gri", 1, "Germania", 135943, 5, 4, 1700, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 101, 3190, null, 0, "Fata", null },
                    { 2435, 6, "Negru", 1, "Germania", 285000, 5, 4, 2993, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 245, 13850, true, 0, "4x4 (automat)", null },
                    { 2436, 6, "Negru", 1, null, 224000, null, null, null, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, null, 6799, null, 0, null, null },
                    { 2437, 6, "Alb", 1, "Germania", 23000, 5, 6, 2967, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 215, 258, 55050, true, 0, "4x4 (automat)", null },
                    { 2438, 3, "Negru", 1, "Germania", 184000, null, 5, 1968, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 170, 9999, null, 1, "Fata", null },
                    { 2431, 1, "Rosu", 1, null, 119000, null, 5, 1200, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, 75, 6790, null, 1, "Fata", null },
                    { 2439, 5, "Argint", 1, null, 295000, 5, 4, 2500, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 418, 174, 10500, true, 1, null, null },
                    { 2421, 2, "Argint", 1, null, 142081, 5, null, 1595, 0, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 102, 2199, true, 1, "Fata", "WAUZZZ8L92A045657" },
                    { 2419, 0, "Argint", 1, "Germania", 220000, null, 4, 1368, 2, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 70, 1750, true, 0, "Fata", null },
                    { 2403, 2, "Alb", 1, "Romania", 43000, 5, 6, 999, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 86, 12650, true, 0, "Fata", "WVWZZZAUZJP024470" },
                    { 2404, 6, "Gri", 1, "Germania", 183000, 5, 4, 2000, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 182, 150, 4690, null, 1, "Fata", "KL1CF26RJ8B256155" },
                    { 2405, 1, "Maro", 1, "Germania", 201000, null, 4, 1910, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 147, 120, 2500, true, 0, "Fata", null },
                    { 2406, 3, "Gri", 1, "Germania", 184000, 5, 4, 1991, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 4999, true, 1, "Spate", null },
                    { 2407, 6, "Alb", 1, "Germania", 219000, 4, 4, 3000, 0, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 306, 21800, true, 1, "4x4 (automat)", null },
                    { 2408, 6, "Gri", 1, "Germania", 211000, 5, 5, 2000, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 9999, true, 1, "4x4 (automat)", null },
                    { 2409, 2, "Gri", 1, "Franta", 172168, null, 6, 1461, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 110, 7300, null, 1, "Fata", "VF1BZ0C0H54013971" },
                    { 2420, 3, "Alb", 1, "Spania", 296000, 5, 4, 1896, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 105, 4350, true, 1, "Fata", "WVWZZZ3CZ6P190789" },
                    { 2410, 4, "Auriu", 1, "Austria", 188300, 5, 5, 2000, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 140, 7590, null, 1, "4x4 (automat)", null },
                    { 2412, 2, "Gri", 1, null, 176490, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, null, 4350, null, 1, null, null },
                    { 2413, 3, "Negru", 1, null, 240000, null, 5, 1995, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 163, 8990, true, 1, "Spate", null },
                    { 2414, 4, "Gri", 1, "Germania", 155486, 5, 5, 1968, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 150, 12500, null, 0, "Fata", "WVWZZZAUZEP543280" },
                    { 2415, 6, "Negru", 1, "Germania", 1900, 5, 6, 2995, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 340, 72000, true, 0, "4x4 (automat)", null },
                    { 2416, 2, "Albastru", 1, null, 75000, null, null, 1461, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 110, 11750, null, 0, null, null },
                    { 2417, 4, "Alb", 1, null, 201250, null, null, null, 1, null, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 7900, null, 1, null, "TMBJG7NEXG0036897" },
                    { 2418, 3, "Negru", 1, null, 99000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 548, null, 20900, null, 1, null, "WAUZZZ4G2CN072914" },
                    { 2411, 4, "Negru", 1, "Belgia", 165000, 5, 5, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 150, 11650, null, 0, "Fata", null },
                    { 2480, 6, "Gri", 1, "Germania", 184000, 5, 5, 1995, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 783, 150, 9950, null, 1, "4x4-manual", null },
                    { 2440, 6, "Rosu", 1, "Belgia", 178200, 5, 5, 1461, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 754, 110, 8190, true, 1, "Fata", null },
                    { 2442, 4, "Alte culori", 1, "Germania", 262000, 5, 5, 2000, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 143, 8490, true, 1, "Fata", null },
                    { 2463, 4, "Negru", 1, null, 182000, 4, 6, 1598, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 9250, null, 1, "Fata", "WVWZZZAUZFP527612" },
                    { 2464, 5, "Argint", 1, "Danemarca", 248000, 5, 4, 1900, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, null, 4750, null, 1, "Fata", null },
                    { 2465, 2, "Gri", 1, "Germania", 224700, null, null, 1998, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 264, 108, 4100, true, 1, "Fata", null },
                    { 2466, 6, "Albastru", 1, null, 29620, null, 6, 1968, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 184, 26400, null, 0, "4x4 (automat)", null },
                    { 2467, 3, "Argint", 1, null, 215000, 5, null, 1793, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 123, 2200, true, 1, "Fata", null },
                    { 2468, 5, "Alte culori", 1, "Romania", 8400, 5, 6, 1995, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 669, 130, 21200, true, 1, "Fata", "WF01XXTTG1JY10105" },
                    { 2469, 1, "Argint", 1, null, 286500, 4, 3, 1686, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 127, 65, 1600, null, 1, "Fata", "W0L0XCF0633028392" },
                    { 2462, 6, "Bej", 1, "Belgia", 172400, 5, 6, 1995, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 185, 15980, null, 1, "Fata", null },
                    { 2470, 6, "Albastru", 1, "Romania", 119312, null, null, 1486, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 6890, true, 1, "4x4 (automat)", null },
                    { 2472, 1, "Negru", 1, "Germania", 109000, null, 5, 1200, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 105, 5199, null, 1, "Fata", null },
                    { 2473, 6, "Negru", 1, "Germania", 98500, null, 5, 2198, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 200, 11500, true, 1, "Spate", "KMHSH81XDBU753700" },
                    { 2474, 6, "Negru", 1, "Germania", 186190, 4, 5, 1498, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 7990, null, 0, "4x4 (automat)", "UU1HSDACN45585982" },
                    { 2475, 6, "Negru", 1, "Japonia", 132500, 5, null, 1998, 0, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 266, 165, 15400, true, 1, "4x4 (automat)", null },
                    { 2476, 7, "Negru", 1, null, 158000, null, 4, 1598, 0, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, 109, 2100, null, 0, "Fata", null },
                    { 2477, 3, "Alb", 1, null, 243000, null, 5, 1600, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 6199, null, 1, "Fata", "TMBCT61Z7C2109388" },
                    { 2478, 5, "Negru", 1, "Belgia", 225000, 5, 6, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 215, 18500, true, 1, "Spate", "WBA3Y31060D350230" },
                    { 2471, 6, "Rosu", 1, "Germania", 6000, null, null, 2993, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, 258, 53300, null, 0, "4x4-manual", null },
                    { 2441, 4, "Argint", 1, "Germania", 216000, 4, 5, 1968, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 5499, true, 1, "Fata", null },
                    { 2461, 3, "Albastru", 1, "Romania", 44000, 5, 6, 2993, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 265, 58905, true, 1, "4x4 (automat)", "WBAJD11080G472979" },
                    { 2459, 3, "Rosu", 1, null, 208408, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 6200, null, 1, null, null },
                    { 2443, 6, "Negru", 1, "Romania", 168000, 4, 5, 1968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 12999, true, 1, "4x4 (automat)", null },
                    { 2444, 3, "Negru", 1, null, 194500, null, 5, 2996, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 204, 13990, null, 1, "4x4 (automat)", null },
                    { 2445, 6, "Argint", 1, "Germania", 96000, 4, 6, 2150, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 150, 17798, null, 1, "Fata", "SALVA2DC3FH989854" },
                    { 2446, 5, "Negru", 1, "Germania", 50990, 5, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 784, 190, 42399, null, 0, null, null },
                    { 2447, 3, "Gri", 1, "Germania", 256000, 5, 4, 3000, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 233, 8300, true, 0, "4x4 (automat)", "WAUZZZ4F98N053422" },
                    { 2448, 1, "Albastru", 1, "Germania", 180000, 5, 5, 1600, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 95, 6100, true, 1, "Fata", null },
                    { 2449, 3, "Negru", 1, "Germania", 65000, 4, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 190, 28699, true, 1, "Fata", null },
                    { 2460, 6, "Maro", 1, "Germania", 50000, null, null, 2993, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, 258, 41300, null, 0, "4x4-manual", null },
                    { 2450, 6, "Negru", 1, "Germania", 126000, 5, 5, 2967, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 245, 24980, null, 1, "4x4 (automat)", null },
                    { 2452, 3, "Alb", 1, null, 182000, null, 5, 1600, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 5799, null, 1, null, null },
                    { 2453, 3, "Alb", 1, "Romania", 120887, 4, 5, 1149, 0, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 4950, true, 0, "Fata", "UU14SDAG450645965" },
                    { 2454, 4, "Gri", 1, "Romania", 130000, 5, 5, 1600, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 9290, true, 1, "Fata", "WVWZZZAUZEP565644" },
                    { 2455, 6, "Negru", 1, "Germania", 165000, 4, 5, 2193, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 16900, true, 1, "4x4 (automat)", null },
                    { 2456, 4, "Alb", 1, null, 189200, null, 5, 2000, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 140, 5999, null, 1, "Fata", null },
                    { 2457, 2, "Gri", 1, "Germania", 216465, 5, 5, 2000, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 6500, true, 1, "Fata", "wvwzzz1kzaw145184" },
                    { 2458, 6, "Negru", 1, null, 240000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, null, 8800, null, 1, null, null },
                    { 2451, 6, "Gri", 1, "Germania", 50000, null, null, 2993, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, 258, 41300, null, 0, "4x4-manual", null },
                    { 2241, 2, "Alb", 1, "Romania", 110000, 5, 5, 1600, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 115, 7650, true, 1, "Fata", null },
                    { 2240, 6, "Gri", 1, "Romania", 39000, null, 6, 1996, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 240, 29900, true, 1, "4x4 (automat)", null },
                    { 2239, 5, "Negru", 1, null, 220000, null, null, 1968, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 264, null, 4750, null, 0, null, null },
                    { 2022, 1, "Albastru", 1, "Germania", 103000, 5, 4, 1598, 0, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 252, 104, 2790, null, 0, null, null },
                    { 2023, 3, "Negru", 1, null, 27872, null, 6, 1997, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 184, 33500, null, 0, "4x4 (automat)", "WDD2050431R382323" },
                    { 2024, 6, "Albastru", 1, "Romania", 134, 5, 6, 1332, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 140, 23900, true, 0, "Fata", null },
                    { 2025, 6, "Rosu", 1, null, 7000, 4, null, null, 0, null, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, null, 14200, null, 1, null, null },
                    { 2026, 3, "Negru", 1, "Franta", 170000, 4, 4, 1500, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 110, 5150, null, 0, "Fata", "VF1BT0A0643309332" },
                    { 2027, 3, "Gri", 1, "Franta", 107000, null, null, null, 1, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, null, 12600, null, 1, null, null },
                    { 2028, 6, "Albastru", 0, null, 8, 5, 6, 1600, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 396, 177, 20955, null, 0, "4x4 (automat)", null },
                    { 2021, 2, "Rosu", 1, null, 55380, 5, 4, 1388, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 80, 3300, true, 0, "Fata", null },
                    { 2029, 5, "Albastru", 1, null, 12600, null, null, 1598, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 114, 19916, null, 0, "Fata", "WDF44760513356231" },
                    { 2031, 6, "Negru", 1, null, 115, null, null, 2143, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 204, 44236, null, 0, "4x4 (automat)", "WDC2539091F600294" },
                    { 2032, 6, "Gri", 0, null, 10, null, null, 2143, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 204, 47439, null, 0, "4x4 (automat)", "WDC2539091F600073" },
                    { 2033, 3, "Argint", 0, null, 5, null, null, 1950, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 194, 60782, null, 0, "4x4 (automat)", "WDD2130051A621017" },
                    { 2034, 8, "Gri", 0, null, 5, null, null, 3982, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 325, 585, 155390, null, 0, "Spate", "WMX1903791A024857" },
                    { 2035, 3, "Gri", 1, "Germania", 9900, null, null, 2967, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 286, 50200, null, 0, "4x4 (automat)", null },
                    { 2036, 1, "Negru", 1, null, 168000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, null, 5500, null, 1, null, null },
                    { 2037, 6, "Alte culori", 1, "Romania", 11167, 5, 6, 1461, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 109, 16000, null, 0, "Fata", null },
                    { 2030, 3, "Maro", 1, null, 169000, null, null, null, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, null, 14550, true, 1, null, null },
                    { 2038, 6, "Albastru", 0, null, 5, null, null, 2987, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491, 258, 75400, null, 0, "4x4 (automat)", "WDC2923241A127469" },
                    { 2020, 6, "Negru", 1, "Germania", 80000, 4, 6, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 259, 41900, null, 0, "4x4 (automat)", null },
                    { 2018, 6, "Gri", 1, "Germania", 129850, 4, 6, 4663, 0, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 435, 43420, null, 0, "4x4 (automat)", null },
                    { 2002, 4, "Gri", 1, "Germania", 194600, 5, 6, 1998, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 11750, null, 1, "Fata", null },
                    { 2003, 3, "Gri", 1, null, 192500, 5, null, 2148, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 120, 6800, true, 0, "Spate", "WDB2030071A953640" },
                    { 2004, 6, "Rosu", 0, "Romania", 1, 5, 6, 1591, 0, 0, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 593, 132, 20000, null, 0, "Fata", null },
                    { 2005, 3, "Albastru", 1, "Italia", 185000, null, 4, 2996, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 235, 5990, null, 1, "4x4 (automat)", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 2006, 6, "Rosu", 0, null, 11, 5, 6, 1000, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 396, 120, 17929, null, 0, "Fata", null },
                    { 2007, 1, "Negru", 1, "Romania", 48000, 5, null, 1461, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 90, 7300, true, 1, "Fata", null },
                    { 2008, 3, "Verde", 1, "Romania", 290000, 5, 4, 1461, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 68, 2300, true, 1, "Fata", null },
                    { 2019, 1, "Negru", 1, "Romania", 48000, null, 5, 1600, 0, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 106, 109, 3750, true, 0, null, null },
                    { 2009, 6, "Negru", 1, "Germania", 99000, 4, 6, 4663, 0, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 435, 45790, null, 0, "4x4 (automat)", null },
                    { 2011, 6, "Negru", 1, "Germania", 98514, 4, 6, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 259, 43350, null, 0, "4x4 (automat)", null },
                    { 2012, 6, "Negru", 1, "Germania", 71921, 4, 6, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 259, 44250, null, 0, "4x4 (automat)", null },
                    { 2013, 5, "Gri", 0, null, 1, 3, 6, 1995, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 663, 130, 24900, null, 0, "Fata", null },
                    { 2014, 3, "Negru", 1, "Germania", 4500, null, null, 2967, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 286, 50500, null, 0, "Fata", null },
                    { 2015, 6, "Maro", 1, null, 46500, 5, 5, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 170, 35020, null, 0, "4x4 (automat)", "WDC2539051F027436" },
                    { 2016, 6, "Gri", 1, "Germania", 144300, 4, 6, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 259, 38950, null, 0, "4x4 (automat)", null },
                    { 2017, 6, "Negru", 1, "Germania", 88320, 4, 5, 4700, 0, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 476, 43420, null, 0, "4x4 (automat)", null },
                    { 2010, 3, "Argint", 1, "Germania", 211000, 5, 5, 2143, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 5900, true, 1, "Spate", null },
                    { 2001, 6, "Negru", 0, null, 12, 5, 6, 2000, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 707, 185, 29950, null, 0, "4x4 (automat)", null },
                    { 2039, 6, "Negru", 1, "Romania", 70300, 4, 5, 1997, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 140, 15350, true, 0, "4x4 (automat)", "WF0RXXGCDRBP18434" },
                    { 2041, 6, "Gri", 1, "Germania", 45600, 4, 6, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 37900, true, 0, "4x4 (automat)", null },
                    { 2062, 2, "Rosu", 1, null, 222000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, null, 1900, null, 1, null, "W0L0XCE7574049756" },
                    { 2063, 3, "Negru", 1, null, 200000, null, 5, 1999, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 8100, true, 1, "Fata", null },
                    { 2064, 3, "Gri", 1, "Germania", 88000, null, null, 1991, 0, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 184, 18100, true, 0, "Spate", null },
                    { 2065, 6, "Gri", 1, "Japonia", 144000, 5, 5, 1798, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 279, 115, 9600, null, 1, "4x4-manual", "JMBXJGA6WDZ401876" },
                    { 2066, 6, "Gri", 1, "Germania", 47440, 4, 6, 2996, 0, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 333, 44260, null, 0, "4x4 (automat)", null },
                    { 2067, 6, "Negru", 1, "Germania", 110000, 4, 6, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 259, 40500, null, 0, "4x4 (automat)", null },
                    { 2068, 6, "Negru", 1, null, 261000, null, null, 2000, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 170, 12350, null, 1, "4x4 (automat)", null },
                    { 2061, 6, "Argint", 1, null, 197000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, null, 12300, null, 1, null, null },
                    { 2069, 6, "Negru", 1, "Germania", 92879, 4, 6, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 259, 37700, null, 0, "4x4 (automat)", null },
                    { 2071, 6, "Gri", 1, "Germania", 112450, 4, 6, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 259, 43400, null, 0, "4x4 (automat)", null },
                    { 2072, 6, "Argint", 1, "Germania", 40700, 4, 6, 2987, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 259, 51790, null, 0, "4x4 (automat)", null },
                    { 2073, 5, "Negru", 1, "Germania", 221000, 5, 4, 1968, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 140, 3490, null, 1, "Fata", null },
                    { 2074, 6, "Albastru", 1, "Romania", 123000, 4, 5, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 7650, true, 0, "4x4-manual", null },
                    { 2075, 3, "Negru", 1, "Germania", 228452, null, null, 3000, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, null, 13999, true, 1, null, null },
                    { 2076, 0, "Negru", 1, null, 300000, null, null, null, 1, null, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 2700, null, 1, null, "WBAAP71000JL38853" },
                    { 2077, 6, "Negru", 1, "Germania", 55000, 5, 6, 2986, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 258, 43500, null, 0, "4x4 (automat)", null },
                    { 2070, 6, "Negru", 1, "Germania", 84200, 4, 6, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 259, 45100, null, 0, "4x4 (automat)", null },
                    { 2040, 6, "Argint", 0, null, 8, 5, 6, 1600, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 396, 177, 20955, null, 0, "4x4 (automat)", null },
                    { 2060, 6, "Albastru", 1, "Romania", 282000, 5, 5, 3000, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 339, 190, 20500, true, 1, "4x4 (automat)", null },
                    { 2058, 5, "Alb", 1, "Romania", 25, 2, 6, 1968, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 75, 17000, null, 0, "Fata", "WV1ZZZ2KZJX140501" },
                    { 2042, 1, "Alte culori", 0, null, 4, 4, 6, 999, 0, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 115, 21269, null, 0, "Fata", null },
                    { 2043, 5, "Gri", 1, null, 206440, null, 5, 1400, 2, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, null, 2700, null, 1, "Fata", null },
                    { 2044, 3, "Gri", 1, "Romania", 49700, 4, 6, 1591, 0, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 682, 128, 12650, true, 0, "Fata", null },
                    { 2045, 6, "Argint", 1, null, 20000, null, null, 2987, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 55203, null, 0, "4x4 (automat)", "WDC1660241B192868" },
                    { 2046, 3, "Rosu", 1, null, 20000, null, null, 1991, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 211, 34639, null, 0, "Spate", "WDD2050451R403277" },
                    { 2047, 6, "Albastru", 1, null, 20000, null, null, 2987, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 50960, null, 0, "4x4 (automat)", "WDC1660241B150504" },
                    { 2048, 6, "Negru", 1, null, 20000, null, null, 2987, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 53792, null, 0, "4x4 (automat)", "WDC1660241B149411" },
                    { 2059, 2, "Rosu", 1, "Germania", 80000, 4, null, 1149, 2, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 55, 6290, null, 0, null, null },
                    { 2049, 3, "Argint", 1, null, 20000, null, null, 2143, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 204, 38135, null, 0, "4x4 (automat)", "WDD2050091R402410" },
                    { 2051, 6, "Albastru", 0, null, 10, 5, 6, 1000, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 396, 120, 18477, null, 0, "Fata", null },
                    { 2052, 6, "Negru", 1, null, 20000, null, null, 2987, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 54500, null, 0, "4x4 (automat)", "WDC1660241B111091" },
                    { 2053, 6, "Negru", 1, null, 20000, null, null, 2987, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 50000, null, 0, "4x4 (automat)", "WDC1660241B091234" },
                    { 2054, 6, "Gri", 1, null, 20000, null, null, 2987, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 53448, null, 0, "4x4 (automat)", "WDC1660241B091163" },
                    { 2055, 4, "Gri", 1, null, 132369, 5, 6, 1395, 0, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 150, 13017, null, 0, "Fata", null },
                    { 2056, 4, "Alb", 1, "Germania", 181236, 4, 6, 1968, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 150, 15950, null, 0, "Fata", "WAUZZZF45GA045433" },
                    { 2057, 3, "Alb", 1, "Danemarca", 210422, null, 5, 1600, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 5499, null, 0, "Fata", null },
                    { 2050, 6, "Negru", 1, null, 20000, null, null, 2987, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 55203, null, 0, "4x4 (automat)", "WDC1660241B115645" },
                    { 2078, 3, "Gri", 1, "Germania", 203000, 5, 5, 2996, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 245, 19800, true, 1, "Spate", null },
                    { 2000, 2, "Negru", 1, "Romania", 120442, 5, null, 1248, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 850, 75, 2600, true, 0, "Fata", "ZFA19900000459902" },
                    { 1998, 4, "Negru", 1, "Germania", 147234, 5, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 116, 7490, null, 1, "Fata", "WF0GXXGBBGDG58553" },
                    { 1942, 3, "Negru", 1, "Germania", 15999, null, null, 2967, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 549, 286, 67000, null, 0, "4x4 (automat)", null },
                    { 1943, 5, "Negru", 1, "Romania", 215000, 5, 4, 1998, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, 138, 3500, true, 1, "Fata", "VF7UDRHJH45193235" },
                    { 1944, 6, "Negru", 1, "Germania", 159000, 5, 6, 2143, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 204, 26990, null, 0, "4x4 (automat)", null },
                    { 1945, 4, "Gri", 1, "Germania", 207000, 5, 4, 2000, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 4299, null, 0, "Fata", null },
                    { 1946, 4, "Gri", 1, "Romania", 10, 5, 6, 1598, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 130, 15990, true, 0, "Fata", "VF1RFB00959579234" },
                    { 1281, 3, "Alb", 1, null, 43000, null, null, 1598, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 13866, null, 0, null, "TMBAG7NE6H0138084" },
                    { 1948, 4, "Argint", 1, "Romania", 200000, 5, 4, 1998, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 4000, true, 1, "Fata", "WVWZZZ3CZ6E227065" },
                    { 1941, 6, "Negru", 1, null, 300147, 4, null, 2143, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 201, 14500, null, 0, null, "WDC2049821F616929" },
                    { 1949, 6, "Negru", 1, "Romania", 5, 4, 6, 2987, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 738, 250, 62107, true, 0, "4x4 (automat)", null },
                    { 1951, 6, "Negru", 1, "Germania", 89552, 4, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 170, 28890, null, 0, "4x4 (automat)", null },
                    { 1952, 6, "Argint", 1, "Germania", 95500, 4, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 204, 27150, null, 0, "4x4 (automat)", null },
                    { 1953, 6, "Alb", 1, "Germania", 146052, 4, 6, 2143, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 204, 30490, null, 0, "4x4 (automat)", null },
                    { 1954, 6, "Alb", 1, "Germania", 99896, 4, 6, 2143, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 204, 26950, null, 0, "4x4 (automat)", null },
                    { 1955, 6, "Negru", 1, "Germania", 139013, 4, 6, 2143, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 170, 26350, null, 0, "4x4 (automat)", null },
                    { 1956, 1, "Negru", 1, null, 175000, 5, null, null, 0, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 5990, null, 1, null, "WVWZZZ1KZ9W401843" },
                    { 1957, 6, "Gri", 1, null, 2700, 5, 6, 2967, 4, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 108, 286, 69900, true, 0, "4x4 (automat)", "WAUZZZF18KD005697" },
                    { 1950, 6, "Negru", 1, "Germania", 133000, 4, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 170, 27200, null, 0, "4x4 (automat)", null },
                    { 1958, 6, "Albastru", 1, "Germania", 115673, 4, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 204, 27100, null, 0, "4x4 (automat)", null },
                    { 1940, 2, "Rosu", 1, "Romania", 10492, 5, null, 1498, 0, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 150, 13990, true, 0, "Fata", null },
                    { 1938, 3, "Negru", 1, "Germania", 146000, 5, null, 2000, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, null, 7000, true, 1, null, null },
                    { 1922, 4, "Negru", 1, null, 176000, 5, 5, 1986, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 143, 9300, null, 1, "Fata", null },
                    { 1923, 6, "Maro", 1, "Germania", 181000, null, 5, 2000, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, null, 11500, true, 1, "4x4-manual", "WBAVP110X0VR67270" },
                    { 1924, 3, "Argint", 1, null, 240000, 4, null, 2700, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 190, 7800, null, 1, null, null },
                    { 1925, 6, "Argint", 0, null, 1, 4, 6, 1598, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 116, 28786, null, 0, "Fata", null },
                    { 1926, 4, "Negru", 1, "Germania", 345000, null, 5, 2143, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 143, 8700, true, 1, "Spate", null },
                    { 1927, 6, "Negru", 1, "Romania", 5, 4, 6, 1956, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 737, 170, 31269, true, 0, "4x4 (automat)", null },
                    { 1928, 3, "Gri", 1, null, 207000, 5, null, 2000, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 14100, true, 1, "Spate", null },
                    { 1939, 3, "Negru", 1, "Romania", 9000, 5, 6, 1995, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 231, 49850, true, 0, "Spate", "WBA7C01020G493575" },
                    { 1929, 3, "Negru", 1, "Germania", 74000, 4, 6, 2998, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 265, 51900, true, 1, "4x4 (automat)", null },
                    { 1931, 5, "Negru", 1, "Germania", 251000, null, 4, 1989, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 170, 5250, null, 1, "Fata", null },
                    { 1932, 0, "Alb", 1, null, 85904, null, null, null, 0, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 838, null, 3700, null, 1, null, null },
                    { 1933, 6, "Gri", 0, null, 1, 4, 6, 1598, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 116, 28786, null, 0, "Fata", null },
                    { 1934, 2, "Gri", 1, "Italia", 151200, 5, 5, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 110, 6200, null, 0, "Fata", null },
                    { 1935, 5, "Alb", 1, "Romania", 338000, 3, null, 2148, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 85, 4490, true, 0, null, null },
                    { 1936, 1, "Gri", 1, "Germania", 60, 4, 6, 2987, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300, 275, 62000, null, 0, null, null },
                    { 1937, 6, "Negru", 1, "Germania", 145000, null, 4, 1900, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, 131, 5990, null, 1, "4x4 (automat)", null },
                    { 1930, 3, "Negru", 1, "Germania", 103000, 4, 6, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 190, 25300, true, 1, "Spate", "WBA5E51040G060483" },
                    { 1999, 3, "Argint", 1, "Germania", 124000, 5, 4, 2000, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 120, 2799, null, 0, "Fata", null },
                    { 1959, 4, "Negru", 1, "Austria", 158800, 4, 5, 1999, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 140, 4350, null, 1, "Fata", "VF36ERHF89L009863" },
                    { 1961, 4, "Gri", 1, null, 186000, null, null, 1968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 6750, null, 0, null, null },
                    { 1982, 6, "Albastru", 1, null, 63000, 5, 5, 2200, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, 160, 18900, true, 0, "4x4-manual", null },
                    { 1983, 3, "Maro", 1, null, 49000, 4, 6, 1994, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 170, 16500, null, 1, null, null },
                    { 1984, 3, "Alb", 1, null, 16783, null, null, null, 0, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, null, 21800, null, 0, null, null },
                    { 1985, 3, "Gri", 1, "Germania", 220000, 4, 5, 2998, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 313, 19390, true, 1, "4x4 (automat)", null },
                    { 1986, 1, "Albastru", 1, "Romania", 103000, 5, 5, 1499, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 5450, true, 0, "Fata", null },
                    { 1987, 5, "Alb", 1, "Romania", 262465, 5, 5, 2143, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 515, 163, 17000, true, 1, "Spate", null },
                    { 1988, 3, "Negru", 1, null, 249000, null, 5, 2143, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 204, 7700, true, 1, null, null },
                    { 1981, 4, "Alb", 1, "Romania", 85620, 5, 6, 1596, 0, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 125, 9150, true, 0, "Fata", "WF06XXGCC6GR64183" },
                    { 1989, 6, "Argint", 1, null, 188016, 5, null, null, 1, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, null, 4999, null, 1, null, "WDC1631131X723658" },
                    { 1991, 6, "Negru", 1, "Germania", 164000, 5, 6, 2967, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 262, 26999, null, 1, "4x4 (automat)", "WVGZZZ7PZGD014417" },
                    { 1992, 3, "Gri", 1, "Belgia", 215300, 5, 4, 1995, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 163, 6690, null, 1, "Spate", null },
                    { 1993, 5, "Albastru", 1, "Romania", 94100, 5, 5, 1598, 0, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, 156, 8850, true, 0, "Fata", null },
                    { 1994, 6, "Argint", 1, "Romania", 213000, 5, 6, 3000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 267, 20500, true, 1, "4x4 (automat)", null },
                    { 1995, 5, "Alb", 1, "Germania", 215870, null, 4, 1461, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 87, 3790, null, 1, null, "VF1KW0BB539779150" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 1996, 3, "Negru", 1, "Germania", 18500, 5, 6, 2967, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 286, 51300, null, 0, "Fata", null },
                    { 1997, 6, "Negru", 1, null, 240000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, null, 12500, null, 0, null, null },
                    { 1990, 2, "Negru", 1, "Germania", 173000, 4, 5, 1586, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 5990, null, 0, "Fata", null },
                    { 1960, 3, "Albastru", 1, "Romania", 184000, 5, 5, 2143, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 8990, true, 0, "Spate", "WDD2040021A718089" },
                    { 1980, 6, "Negru", 1, "Germania", 53700, 5, 5, 1995, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 593, 185, 16650, null, 0, "4x4 (automat)", "U5YPC813DEL631958" },
                    { 1978, 6, "Negru", 1, "Germania", 221300, 5, 5, 1995, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 170, 12990, null, 1, "4x4 (automat)", null },
                    { 1962, 6, "Gri", 1, null, 173000, null, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, null, 6600, null, 0, null, null },
                    { 1963, 3, "Negru", 1, "Germania", 178000, 4, 6, 2143, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 17990, null, 1, "Spate", "WDD2050041F067088" },
                    { 1964, 2, "Albastru", 1, "Germania", 207300, 4, 4, 1390, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 122, 4450, null, 0, "Fata", "WVWZZZ1KZ8W192548" },
                    { 1965, 3, "Argint", 1, "Germania", 34003, null, null, 2967, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 549, 286, 66500, null, 0, "4x4 (automat)", null },
                    { 1966, 6, "Alb", 1, "Belgia", 145000, 5, 5, 1461, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 5790, null, 1, "Fata", null },
                    { 1967, 6, "Negru", 1, "Germania", 126941, 5, null, 2179, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, 152, 15700, true, 1, null, "SALFA2DC8DH376856" },
                    { 1968, 6, "Negru", 1, null, 27000, null, null, 1500, 1, null, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, null, 10500, null, 1, null, "UU1HSDJ9F57669845" },
                    { 1979, 3, "Gri", 1, null, 293383, 4, null, 2000, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 170, 7800, null, 1, "Fata", "WAUZZZ8K1AN070101" },
                    { 1969, 2, "Albastru", 1, null, 180000, null, null, 1398, 0, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 900, null, 0, null, null },
                    { 1971, 5, "Argint", 1, "Germania", 230000, 5, null, 1900, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 120, 2999, null, 0, "Fata", null },
                    { 1972, 1, "Negru", 1, null, 236000, 5, 4, 1968, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 140, 5190, null, 1, "Fata", null },
                    { 1973, 4, "Negru", 1, "Germania", 173300, 5, 5, 2184, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 130, 5800, null, 1, "Fata", "JMZGHA9C601478442" },
                    { 1974, 5, "Albastru", 1, "Belgia", 122000, 5, 5, 1560, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 632, 116, 9450, null, 0, "Fata", null },
                    { 1975, 2, "Gri", 1, "Germania", 98000, 5, 6, 1586, 0, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 136, 6450, true, 1, "Fata", "WF0KXXGCBKDU84698" },
                    { 1976, 4, "Maro", 1, "Germania", 197600, null, null, 1980, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 160, 7900, true, 1, "Fata", null },
                    { 1977, 6, "Gri", 1, null, 270000, null, null, 3000, 1, 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 217, 5200, null, 1, null, null },
                    { 1970, 6, "Auriu", 1, "Romania", 210000, 5, null, 2395, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 806, 200, 8350, true, 0, "4x4 (automat)", null },
                    { 2079, 5, "Gri", 1, "Belgia", 105900, 5, 5, 1461, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 110, 6750, null, 0, "Fata", null },
                    { 2080, 3, "Albastru", 1, "Romania", 65000, 4, null, 1390, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 2200, true, 1, "Fata", null },
                    { 2081, 5, "Alb", 1, "Romania", 107000, 5, 4, 1785, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 264, 108, 6000, true, 1, "Fata", "WDD2452071J371188" },
                    { 2183, 5, "Maro", 1, "Romania", 101492, 5, 5, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 418, 180, 31900, true, 1, "4x4 (automat)", "WV2ZZZ7HZFH091284" },
                    { 2184, 3, "Gri", 1, null, 240000, null, 4, 1996, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 3999, null, 0, "Spate", null },
                    { 2185, 1, "Gri", 1, null, 174000, null, 4, 1996, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 163, 3999, null, 0, "Spate", null },
                    { 2186, 3, "Gri", 1, null, 182181, null, 5, 1995, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 11900, null, 0, "Spate", "WBA3E11020J709667" },
                    { 2187, 2, "Gri", 1, "Romania", 72000, 5, 6, 1500, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 90, 11200, true, 0, "Fata", "VF1RFB00455586003" },
                    { 2188, 5, "Alte culori", 1, null, 547500, null, null, 2148, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 515, 110, 4700, null, 1, "Fata", null },
                    { 2189, 6, "Negru", 1, null, 246000, 4, 5, 2200, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 591, 197, 7500, null, 0, "4x4-manual", null },
                    { 2182, 1, "Gri", 1, "Germania", 22000, 5, null, null, 3, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 353, 170, 22990, null, 0, "Fata", "WBY1Z61030V883265" },
                    { 2190, 1, "Albastru", 1, null, 150615, 5, 5, 1248, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 129, 90, 4250, null, 0, "Fata", "W0L0SDL68E4141881" },
                    { 2192, 6, "Negru", 1, null, 32700, 5, 6, 1461, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 109, 11300, null, 0, "4x4 (automat)", null },
                    { 2193, 8, "Negru", 1, null, 38101, null, 6, 2981, 0, null, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 420, 89900, null, 0, null, null },
                    { 2194, 6, "Gri", 1, "Germania", 146000, 4, 5, 4400, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 360, 48500, true, 0, "4x4 (automat)", null },
                    { 2195, 5, "Alb", 1, "Franta", 159182, 5, 5, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 350, 112, 9990, null, 1, "Fata", "NMTDM26R90R013848" },
                    { 2196, 3, "Negru", 1, "Germania", 220000, 5, 5, 2000, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 177, 12350, null, 1, "Fata", null },
                    { 2197, 5, "Alb", 1, null, 1, null, null, 1998, 1, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, null, 2250, null, 0, null, null },
                    { 2198, 6, "Argint", 1, "Austria", 293000, null, 4, 2993, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 235, 9800, true, 1, "4x4 (automat)", "WBAFF41030L053446" },
                    { 2191, 2, "Gri", 1, "Germania", 208350, 4, 4, 1400, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 75, 3500, true, 0, "Fata", null },
                    { 2199, 3, "Gri", 1, "Franta", 166000, null, 4, 1800, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 125, 4650, null, 0, "Fata", null },
                    { 2181, 3, "Alb", 1, null, 17500, null, 6, 2143, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 204, 33000, true, 0, "Spate", "WDD2050121F715825" },
                    { 2179, 6, "Negru", 1, "Romania", 10300, 5, 6, 2967, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 286, 62990, true, 0, "4x4 (automat)", null },
                    { 2163, 6, "Gri", 1, null, 192202, 5, 5, 1998, 4, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 296, 202, 12990, null, 0, "4x4 (automat)", "JMBXDGG2WEZ005845" },
                    { 2164, 0, "Alb", 1, "Romania", 178500, null, 4, 898, 2, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 195, 51, 1290, true, 1, "Fata", null },
                    { 2165, 3, "Gri", 1, "Olanda", 187000, null, 6, 2000, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 150, 9500, null, 1, "Fata", null },
                    { 2166, 6, "Negru", 1, "Romania", 2900, 5, 6, 2986, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 108, 286, 77800, null, 0, "4x4 (automat)", null },
                    { 2167, 6, "Albastru", 1, null, 326000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, null, 9999, null, 1, null, "SALLSAA147A999796" },
                    { 2168, 8, "Alb", 1, "Germania", 145488, 3, 5, 1995, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 180, 6990, null, 1, "Fata", null },
                    { 2169, 6, "Alb", 1, null, 131072, 5, 5, 1997, 4, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 296, 202, 14990, null, 0, "4x4 (automat)", "JMBXDGG2WEZ003891" },
                    { 2180, 1, "Negru", 1, null, 176000, null, 4, 1996, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 163, 3999, null, 0, "Spate", null },
                    { 2170, 3, "Negru", 1, "Luxemburg", 220000, 4, 6, 2200, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 175, 11500, true, 1, "Fata", "JMZGJ692821129806" },
                    { 2172, 3, "Negru", 1, "Germania", 115000, 4, 6, null, 0, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 492, null, 39900, null, 0, "4x4 (automat)", null },
                    { 2173, 6, "Negru", 1, null, 158500, 5, 5, 1995, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 177, 10790, true, 1, "4x4 (automat)", null },
                    { 2174, 8, "Negru", 1, "Germania", 182000, 3, 4, 1698, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 101, 2800, true, 0, "Fata", null },
                    { 2175, 2, "Albastru", 1, "Germania", 2850, 4, 6, 1500, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 120, 24500, true, 0, "Fata", null },
                    { 2176, 3, "Argint", 1, "Romania", 211751, 4, 4, 1896, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 5500, true, 0, "Fata", "TMBCS21Z39C001610" },
                    { 2177, 3, "Maro", 1, null, 135956, 4, 6, 2000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 19500, null, 1, "4x4 (automat)", "WBA5B91050D568785" },
                    { 2178, 6, "Alb", 1, "Germania", 194680, null, 5, 2993, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 306, 21999, null, 1, "4x4 (automat)", null },
                    { 2171, 5, "Maro", 1, "Germania", 176000, 5, 5, 1968, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 140, 9900, null, 0, "Fata", "WVGZZZ1TZEW082920" },
                    { 2162, 3, "Negru", 1, "Germania", 101000, 4, 6, 2993, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 492, 265, 30900, null, 0, "4x4 (automat)", null },
                    { 2200, 3, "Maro", 1, "Germania", 225000, 4, 5, 2993, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 548, 245, 20350, true, 0, "4x4 (automat)", null },
                    { 2202, 6, "Auriu", 1, null, 2200, 4, 6, 1999, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 150, 32900, null, 0, "4x4 (automat)", null },
                    { 2223, 3, "Auriu", 1, null, 110000, null, 5, 2000, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 143, 13290, null, 1, null, "WAUZZZ8K2EN017378" },
                    { 2224, 1, "Negru", 1, null, 190000, null, null, 1299, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 453, null, 1650, null, 0, null, null },
                    { 2225, 3, "Negru", 1, "Romania", 49024, null, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 488, 136, 27500, true, 0, "Fata", "WDD1173081N606203" },
                    { 2226, 6, "Negru", 1, null, 188000, null, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, null, 6990, null, 0, null, null },
                    { 2227, 6, "Argint", 0, "Romania", 10, 4, 6, 2143, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 204, 48599, null, 0, "4x4 (automat)", null },
                    { 2228, 6, "Negru", 1, "Germania", 14900, 5, 6, 2987, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491, 258, 59900, null, 0, "4x4 (automat)", null },
                    { 2229, 1, "Gri", 1, "Romania", 111963, null, null, 1242, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 60, 5950, true, 0, null, null },
                    { 2222, 3, "Negru", 1, null, 147573, null, 6, 2191, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 175, 16900, null, 0, "Fata", "JMZGJ622871337998" },
                    { 2230, 2, "Alb", 1, "Romania", 126200, 5, null, 1686, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 131, 7950, true, 0, "Fata", null },
                    { 2232, 3, "Negru", 1, "Germania", 126000, null, null, null, 0, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, null, 6700, true, 1, null, "WVWZZZ16ZBM093927" },
                    { 2233, 6, "Negru", 1, null, 255000, null, null, 2698, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, null, 8990, null, 0, null, null },
                    { 2234, 4, "Gri", 1, null, 244000, null, null, 1798, 0, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, null, 2190, null, 0, null, null },
                    { 2235, 4, "Alb", 1, "Romania", 82925, 5, 5, 1499, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 120, 8900, true, 1, "Fata", "WF06XXGCC6FS37955" },
                    { 2236, 1, "Alb", 1, "Romania", 64775, null, null, 1248, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 129, 75, 6200, true, 0, null, null },
                    { 2237, 2, "Maro", 1, "Germania", 169000, null, 5, 1600, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110, 110, 8600, true, 1, "Fata", null },
                    { 2238, 1, "Alb", 1, "Romania", 87553, 5, null, 1248, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 129, 75, 5700, true, 0, "Fata", null },
                    { 2231, 5, "Alb", 1, null, 321522, null, 5, 1300, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 831, 90, 6700, true, 1, "Fata", null },
                    { 2201, 6, "Auriu", 0, "Romania", 1, 4, 6, 1498, 0, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 150, 32717, null, 0, "Fata", "WVGZZZ5NZKW324374" },
                    { 2221, 6, "Negru", 0, "Romania", 10, 4, 6, 2143, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491, 204, 50088, null, 0, "4x4 (automat)", null },
                    { 2219, 2, "Gri", 1, "Romania", 11167, null, 6, 1332, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 462, 163, 33900, true, 0, "Fata", "WDD1770871J003771" },
                    { 2203, 1, "Gri", 1, null, 130000, 4, 5, 1500, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 90, 5900, true, 1, "Fata", null },
                    { 2204, 6, "Maro", 1, "Romania", 168400, 4, 6, 2987, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, 258, 32900, true, 0, "4x4 (automat)", null },
                    { 2205, 5, "Alb", 1, "Romania", 78200, 3, 5, 1995, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 125, 8500, true, 1, "Fata", "VF1JLJ7A6BY411601" },
                    { 2206, 7, "Alte culori", 1, null, 9850, null, null, 2891, 0, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 450, 124900, null, 0, null, null },
                    { 2207, 5, "Gri", 1, "Franta", 162784, 4, 5, 1995, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 114, 10990, null, 0, "Fata", "VF1JLB7BADY514802" },
                    { 2208, 5, "Alb", 1, null, 36226, null, null, 2143, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 136, 24900, null, 0, "Spate", "WDF44770513133459" },
                    { 2209, 3, "Alb", 1, "Germania", 81738, 5, 6, 2191, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 175, 17990, null, 0, "Fata", "JMZGJ622871343754" },
                    { 2220, 3, "Alb", 1, "Romania", 22400, 4, 6, 1598, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 136, 22500, true, 0, "Spate", "WDD2050361R348361" },
                    { 2210, 3, "Negru", 1, null, 148592, null, 5, 1995, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 12700, null, 0, "Spate", "WBA3E11090P588990" },
                    { 2212, 5, "Albastru", 1, null, 1, null, null, 1898, 1, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 431, null, 1200, null, 0, null, null },
                    { 2213, 6, "Maro", 1, "Romania", 34011, 4, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 136, 22900, true, 0, "4x4 (automat)", null },
                    { 2214, 5, "Gri", 1, "Germania", 98871, 4, 5, 1700, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 125, 8990, null, 0, "Fata", "W0L0AHM75E2100720" },
                    { 2215, 3, "Gri", 1, "Germania", 305000, 4, 4, 2967, 1, 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 245, 3500, true, 1, "4x4 (automat)", null },
                    { 2216, 6, "Gri", 1, "Germania", 200000, null, 4, 1996, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, 116, 3700, true, 1, "4x4 (automat)", null },
                    { 2217, 6, "Negru", 1, "Franta", 128263, 4, 5, 1598, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 130, 10990, null, 0, "Fata", "SJNJENJ10U7149318" },
                    { 2218, 1, "Negru", 1, null, 239000, null, null, 1398, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, null, 2150, null, 0, null, null },
                    { 2211, 4, "Alb", 1, "Suedia", 116000, null, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 190, 18990, null, 0, null, "wvwzzz3czge086252" },
                    { 2161, 4, "Argint", 1, "Romania", 202000, null, 4, 1900, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 3500, true, 1, "Fata", "Wvwzzz1kz8m273597" },
                    { 2160, 1, "Albastru", 1, "Romania", 74000, 4, 4, 1086, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 692, 485, 2490, true, 0, null, null },
                    { 2159, 3, "Alb", 1, "Romania", 72334, 5, 6, 1461, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 5900, true, 0, "Fata", "UU14SDCH453726136" },
                    { 2102, 5, "Alb", 1, "Romania", 224000, 4, 5, 2000, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 120, 3950, null, 1, "Fata", null },
                    { 2103, 2, "Albastru", 1, "Germania", 82000, 5, 5, 1197, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 86, 7500, null, 1, "Fata", "WVWZZZ1KZDP035025" },
                    { 2104, 6, "Negru", 1, "Romania", 91850, 5, 6, 1461, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 11200, true, 0, "4x4 (automat)", "UU1HSDJ9G56802363" },
                    { 2105, 6, "Negru", 1, "Polonia", 218000, 5, 3, 2000, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, 110, 4175, null, 0, "4x4-manual", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 2106, 6, "Argint", 1, null, 230000, null, null, 2500, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 288, null, 7500, null, 1, "4x4 (automat)", null },
                    { 2107, 4, "Negru", 1, "Austria", 250670, 4, 5, 1560, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 800, 115, 4990, null, 0, "Fata", "YV1MW84E1B2626619" },
                    { 2108, 5, "Maro", 0, null, 1, 5, 6, 1598, 1, 0, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 141, 120, 19922, null, 0, "Fata", null },
                    { 2101, 5, "Rosu", 1, "Romania", 5000, 5, 6, 1968, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 399, 102, 18447, true, 0, "Fata", null },
                    { 2109, 4, "Albastru", 1, "Germania", 208000, null, null, 1968, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, null, 4900, null, 1, "Fata", null },
                    { 2111, 5, "Gri", 1, "Germania", 187000, 6, null, 1598, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 102, 8700, null, 0, "Fata", "WV2ZZZ2KZBX287460" },
                    { 2112, 6, "Alte culori", 1, null, 144200, null, 6, 2000, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 190, 23970, null, 1, "4x4 (automat)", "WBAWZ510900M04956" },
                    { 2113, 6, "Albastru", 1, null, 111500, 3, 4, 1328, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 448, 82, 19000, true, 1, "4x4-manual", "VSEFJB43C00100618" },
                    { 2114, 3, "Negru", 1, null, 184000, null, 5, 1995, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 14550, true, 0, "Spate", null },
                    { 2115, 3, "Negru", 1, "Germania", 283000, 4, null, 1984, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 795, 163, 9800, true, 1, "Fata", null },
                    { 2116, 1, "Auriu", 1, "Romania", 9890, 4, 6, 1498, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 120, 14999, true, 0, "Fata", null },
                    { 2117, 4, "Alb", 1, "Belgia", 145000, 4, 6, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 110, 7290, null, 1, "Fata", "W0LPD8E64F8047441" },
                    { 2110, 3, "Alb", 1, "Belgia", 125000, 5, 5, 1598, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 12699, true, 1, "Fata", null },
                    { 2118, 2, "Negru", 1, "Romania", 18, 5, 6, 988, 0, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 221, 129, 15550, null, 0, "Fata", null },
                    { 2100, 6, "Bej", 1, "Germania", 137000, 4, 5, 1968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 170, 13800, null, 1, "4x4 (automat)", null },
                    { 2098, 4, "Gri", 1, null, 153000, 4, 6, 1582, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 575, null, 8599, null, 0, "Fata", null },
                    { 2082, 4, "Negru", 1, "Germania", 113000, 5, 5, 1400, 0, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 122, 7500, null, 1, "Fata", "WVWZZZ1KZAP049825" },
                    { 2083, 6, "Negru", 1, "Belgia", 143805, 4, 5, 2199, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 197, 15000, null, 0, "4x4-manual", "KMHSU81XDDU169132" },
                    { 2084, 2, "Negru", 1, null, 41226, 5, 6, 1395, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 122, 12597, null, 0, "Fata", "WVWZZZAUZEW346075" },
                    { 2085, 6, "Gri", 0, "Romania", 1, 5, 6, 1498, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 150, 17311, null, 0, "Fata", null },
                    { 2086, 3, "Gri", 1, "Germania", 9998, null, null, 2967, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 286, 53200, null, 0, "4x4 (automat)", null },
                    { 2087, 5, "Auriu", 1, "Belgia", 217000, 5, 4, 1600, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 632, null, 3600, null, 1, null, null },
                    { 2088, 4, "Argint", 1, null, 178000, 5, 6, 1600, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 10299, true, 1, "Fata", null },
                    { 2099, 6, "Alb", 1, null, 39000, null, null, null, 0, null, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 265, null, 16000, null, 1, null, "JMZDK6W7610188752" },
                    { 2089, 2, "Negru", 1, null, 162600, null, 4, 2000, 1, 1, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 140, 3990, null, 1, "Fata", null },
                    { 2091, 4, "Gri", 1, "Italia", 199260, null, 5, 1598, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 9500, null, 0, "Fata", null },
                    { 2092, 5, "Alb", 1, null, 150079, null, 5, 1560, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 75, 5350, true, 0, "Fata", "VF77C9HN0EJ559074" },
                    { 2093, 7, "Alb", 1, "Germania", 21000, null, 6, 3982, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 612, 135000, true, 0, "4x4 (automat)", null },
                    { 2094, 4, "Negru", 1, null, 184000, null, null, 1998, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, null, 3590, null, 0, null, null },
                    { 2095, 6, "Maro", 1, null, 221000, null, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 593, null, 4650, null, 0, null, null },
                    { 2096, 3, "Gri", 1, "Germania", 240000, 5, 4, 2993, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 272, 7850, null, 0, "Spate", null },
                    { 2097, 5, "Negru", 1, "Germania", 182361, 5, 4, 1910, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 150, 4599, null, 1, "Fata", null },
                    { 2090, 3, "Alb", 1, null, 194919, 5, null, 1400, 2, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, null, 2750, null, 1, "Fata", null },
                    { 2119, 3, "Negru", 1, "Germania", 232000, null, null, 1995, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 13100, true, 0, null, "WBAFW11010DU30879" },
                    { 2120, 3, "Maro", 1, "Romania", 71990, 5, 5, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 15000, true, 0, null, "WBA3D31010J560988" },
                    { 2121, 3, "Negru", 1, "Romania", 40000, 4, 6, 1989, 0, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 211, 21900, true, 1, "Spate", null },
                    { 2143, 0, "Alb", 1, null, 230000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, null, 5300, null, 1, null, null },
                    { 2144, 4, "Maro", 1, null, 152000, null, null, 1600, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 7000, true, 1, null, null },
                    { 2145, 6, "Negru", 1, "Germania", 85200, 5, 5, 1995, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 143, 17600, null, 0, "4x4 (automat)", "WBAVP71090VW35310" },
                    { 2146, 4, "Negru", 1, "Germania", 218000, 4, 6, 1600, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 9400, null, 0, "Fata", null },
                    { 2147, 6, "Negru", 1, "Romania", 16250, 4, 6, 2000, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 190, 29500, true, 1, "4x4 (automat)", "WBAWZ510200S22614" },
                    { 2148, 6, "Alb", 1, "Romania", 6100, 5, 6, 1995, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 231, 39449, true, 0, "4x4 (automat)", "WBAYL31060EJ62922" },
                    { 2149, 1, "Maro", 1, "Olanda", 182000, null, 5, 1600, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 105, 7250, null, 1, "Fata", null },
                    { 2142, 6, "Rosu", 1, null, 215000, 4, null, 3000, 0, 1, new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 711, 170, 18500, null, 1, "4x4 (automat)", null },
                    { 2150, 4, "Gri", 1, null, 130000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 151, null, 3850, null, 1, null, "ZAR93900007021247" },
                    { 2152, 6, "Negru", 1, "Romania", 52875, 4, null, 2993, 4, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 600, 250, 65000, true, 1, "4x4 (automat)", null },
                    { 2153, 3, "Alte culori", 1, null, 162000, null, null, 1598, 0, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, null, 1490, null, 0, null, null },
                    { 2154, 6, "Alb", 1, "Romania", 9000, 5, 6, 1995, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 190, 55874, true, 0, "4x4 (automat)", "WBATX31070LB98065" },
                    { 2155, 3, "Argint", 1, "Franta", 228124, 4, null, 2000, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 3949, null, 0, null, null },
                    { 2156, 0, "Albastru", 1, null, 123000, null, null, null, 0, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, null, 1999, null, 1, null, null },
                    { 2157, 4, "Gri", 1, "Germania", 150000, null, 5, 1600, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 6550, true, 1, "Fata", null },
                    { 2158, 1, "Negru", 1, "Romania", 214000, null, 3, 998, 0, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, 68, 1500, true, 1, "Fata", null },
                    { 2151, 4, "Alb", 1, "Germania", 209000, 4, 5, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 7990, null, 0, "Fata", null },
                    { 2141, 1, "Negru", 1, "Belgia", 138000, 4, 5, 1500, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 754, 110, 7250, null, 1, "Fata", "SJNFCAf15U6219530" },
                    { 2140, 6, "Negru", 1, "Germania", 141000, 5, 6, 2987, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 785, 160, 28900, true, 1, "4x4 (automat)", null },
                    { 2139, 6, "Negru", 1, "Belgia", 172700, 5, 5, 1461, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 90, 5800, null, 0, "Fata", "UU1HSDAG544543308" },
                    { 2122, 3, "Negru", 1, "Germania", 229852, 5, 5, 1997, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 140, 8777, null, 0, "Fata", "WVWZZZ3CZ9E548178" },
                    { 2123, 4, "Argint", 1, "Germania", 170000, 5, 5, 1560, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 800, 116, 5949, null, 1, "Fata", "YV1MW84E1B2635579" },
                    { 2124, 4, "Maro", 1, null, 208000, 5, null, 1968, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 170, 10690, true, 1, null, null },
                    { 2125, 6, "Negru", 1, "Danemarca", 117664, 5, 5, 1461, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 110, 10000, null, 0, "Fata", null },
                    { 2126, 2, "Alb", 0, "Romania", 2, 5, 6, 999, 0, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 115, 17553, null, 0, "Fata", null },
                    { 2127, 6, "Negru", 1, null, 162000, null, null, null, 1, null, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 215, null, 37900, null, 1, null, null },
                    { 2128, 3, "Albastru", 1, null, 164933, null, 6, 2993, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 272, 25990, null, 1, "4x4 (automat)", "WAUZZZ4G2GN110471" },
                    { 2129, 6, "Negru", 1, null, 175147, 5, 5, 1998, 4, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 296, 202, 13490, null, 0, "4x4 (automat)", "JMBXDGG2WEZ007263" },
                    { 2130, 5, "Albastru", 1, "Germania", 222222, 4, 5, 1686, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 125, 4450, null, 0, "Fata", "W0L0AHM75AG026442" },
                    { 2131, 6, "Alb", 1, null, 180000, 4, 4, 3198, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 297, 160, 8350, true, 1, "4x4 (automat)", null },
                    { 2132, 3, "Negru", 1, "Romania", 93100, 4, 5, 1968, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 170, 11400, true, 0, "Fata", "TMBAF93T1F9023823" },
                    { 2133, 2, "Gri", 1, "Germania", 202256, 5, 5, 1600, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 5899, null, 1, "Fata", "WVWZZZ1KZAW312659" },
                    { 2134, 6, "Negru", 1, null, 179000, null, null, null, 0, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 737, null, 8300, null, 1, null, "1J4NF5FB6BD153417" },
                    { 2135, 1, "Argint", 1, null, 142500, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, null, 2200, null, 1, null, null },
                    { 2136, 3, "Negru", 1, "Germania", 224000, 5, 5, 2143, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 136, 8700, true, 1, null, "WDD2040011A445674" },
                    { 2137, 2, "Gri", 1, "Germania", 148000, 5, 5, 1400, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 122, 6750, null, 1, "Fata", "WVWZZZ1KZCW065415" },
                    { 2138, 6, "Negru", 1, null, 150058, 5, 5, 1995, 4, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 296, 202, 15990, null, 0, "4x4 (automat)", "JMBXDGG2WEZ004966" },
                    { 1920, 1, "Albastru", 1, null, 932, null, 6, null, 3, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 353, 170, 28480, null, 0, "Spate", null },
                    { 1280, 6, "Alb", 1, "Germania", 157000, 5, 6, 2000, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 190, 23500, true, 1, "4x4 (automat)", "WAUZZZ8R8FA098649" },
                    { 1253, 6, "Negru", 1, null, 130000, null, 6, null, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 262, 25500, true, 1, "4x4 (automat)", null },
                    { 1278, 3, "Albastru", 1, "Germania", 209000, 5, 6, 1968, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 18487, true, 0, "Spate", null },
                    { 421, 4, "Alb", 1, "Germania", 107250, 5, 6, 1598, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 136, 10990, null, 0, "Fata", "W0LBF8EG2H8022444" },
                    { 422, 3, "Gri", 1, null, 71800, 5, null, null, 3, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 329, 52490, null, 0, "4x4 (automat)", null },
                    { 423, 5, "Rosu", 1, "Germania", 190000, 5, 3, 1998, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 90, 4850, null, 1, null, null },
                    { 424, 1, "Alb", 1, "Romania", 116058, 4, 5, 998, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 68, 3000, true, 1, "Fata", "vf7pncfb489612156" },
                    { 425, 6, "Negru", 1, "Germania", 120000, null, 6, 2996, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 265, 42999, true, 1, "4x4 (automat)", null },
                    { 426, 6, "Alte culori", 1, null, 39800, 4, 6, 1995, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, 143, 18970, null, 1, "Fata", "JTMWPREVX0D019307" },
                    { 427, 6, "Rosu", 1, "Germania", 77277, 5, 6, 2143, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 204, 32990, null, 0, "4x4 (automat)", "WDC1660041A679337" },
                    { 420, 4, "Gri", 1, null, 84000, null, 5, 2000, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 140, 9700, null, 0, "Fata", null },
                    { 428, 3, "Negru", 1, null, 192000, null, null, null, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, null, 19950, null, 1, null, null },
                    { 430, 2, "Albastru", 1, null, 173000, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 252, null, 2550, null, 0, null, null },
                    { 431, 6, "Gri", 1, "Romania", 405870, null, null, 2500, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, null, 4000, true, 1, "4x4 (automat)", null },
                    { 432, 5, "Alb", 1, null, 227000, 4, 5, 2000, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 140, 7500, true, 1, "Fata", null },
                    { 433, 4, "Negru", 1, null, 242500, 5, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 4490, null, 1, null, null },
                    { 434, 3, "Alb", 1, "Germania", 30900, 5, 6, 2143, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 23900, true, 1, "Spate", null },
                    { 435, 4, "Alb", 1, "Germania", 165000, 5, 6, 2000, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 190, 18800, null, 0, "Fata", "WVWZZZ3CZGE107463" },
                    { 436, 6, "Negru", 1, "Germania", 80651, 5, 6, 2199, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 197, 16990, null, 0, "4x4 (automat)", "KMHSU81XDEU325087" },
                    { 429, 3, "Argint", 1, null, 110000, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 488, null, 9999, null, 1, null, null },
                    { 437, 6, "Negru", 1, "Germania", 165000, 5, 5, 1998, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 143, 13450, null, 0, "4x4 (automat)", null },
                    { 419, 3, "Albastru", 1, null, 182000, 4, null, null, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 240, 4490, null, 1, "4x4 (automat)", null },
                    { 417, 7, "Rosu", 1, "Romania", 11800, 3, 4, 3198, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 160, 260, 15800, true, 1, "4x4-manual", null },
                    { 401, 4, "Negru", 1, null, 172000, null, null, null, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 5700, null, 1, null, null },
                    { 402, 0, "Argint", 1, "Germania", 148670, 2, 4, 1390, 0, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 395, 75, 2100, true, 1, "Fata", null },
                    { 403, 2, "Alb", 1, "Belgia", 208000, 5, 4, 1566, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 90, 4799, null, 1, "Fata", "WF0PXXGCDP9P17253" },
                    { 404, 5, "Gri", 1, "Germania", 167000, 5, 6, 1500, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 110, 10400, null, 0, "Fata", "VF1JZ49AJ53576165" },
                    { 405, 3, "Negru", 1, "Germania", 189780, 5, 5, 1598, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 10980, null, 1, "Fata", "TMBAG9NE7E0126288" },
                    { 406, 3, "Negru", 1, "Olanda", 151000, 5, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 9600, null, 1, "Fata", "TMBAG9NE4E0216904" },
                    { 407, 6, "Negru", 1, "Ungaria", 187500, 4, null, 2488, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 174, 7350, null, 1, "4x4-manual", null },
                    { 418, 2, "Negru", 1, "Franta", 141000, 2, 4, 1600, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 790, null, 4980, null, 1, "Fata", null },
                    { 408, 6, "Gri", 1, "Germania", 125000, null, 6, 2000, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 180, 24499, null, 1, "4x4 (automat)", null },
                    { 410, 4, "Negru", 1, "Germania", 205000, 5, 6, 2200, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 170, 15500, null, 1, "Spate", null },
                    { 411, 5, "Negru", 1, "Franta", 153000, 5, 6, 1600, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 130, 9300, null, 0, "Fata", "VF1JZ03BH53932935" },
                    { 412, 4, "Argint", 1, null, 347000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 5299, null, 1, null, null },
                    { 413, 6, "Alb", 1, null, 108000, 5, 5, 2000, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 155, 15000, true, 1, "4x4-manual", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 414, 3, "Negru", 1, "Germania", 123023, 5, 4, 3564, 0, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226, 311, 13500, null, 1, "4x4 (automat)", null },
                    { 415, 1, "Gri", 1, "Germania", 178000, 5, 4, 1200, 0, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, null, 1950, null, 1, null, "TMBPW26Y764460747" },
                    { 416, 0, "Maro", 1, "Romania", 140000, null, null, 1598, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 395, 105, 6300, null, 0, null, null },
                    { 409, 3, "Gri", 1, "Romania", 158000, 4, 5, 2000, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 241, 150, 6700, true, 1, "4x4 (automat)", "JF1BMDLZ1AG005916" },
                    { 400, 4, "Gri", 1, "Olanda", 255000, 5, 4, 1798, 0, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 120, 2490, null, 0, "Fata", null },
                    { 438, 4, "Rosu", 1, null, 27450, null, 6, 1968, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 422, 190, 27300, true, 0, "4x4 (automat)", null },
                    { 440, 3, "Alb", 1, "Luxemburg", 257000, 4, 5, 1995, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 10500, true, 1, "Spate", "WBA3E11050J724728" },
                    { 461, 1, "Alb", 1, "Germania", 231000, null, 5, 1596, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, null, 4790, null, 1, "Fata", null },
                    { 462, 3, "Alb", 1, "Romania", 377, null, 6, 899, 2, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 90, 8950, true, 1, "Fata", null },
                    { 463, 2, "Gri", 1, "Germania", 202000, 4, 4, 1600, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 115, 4650, true, 1, "Fata", null },
                    { 464, 4, "Gri", 1, null, 200900, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, null, 15350, null, 1, null, null },
                    { 465, 6, "Gri", 1, null, 24983, 5, 6, 1461, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 109, 13990, true, 0, "Fata", null },
                    { 466, 1, "Negru", 1, null, 127500, null, null, null, 1, null, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, null, 19900, null, 1, null, "WBA5E51030G063214" },
                    { 467, 4, "Argint", 1, null, 270000, null, 4, 1996, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 3400, true, 1, "Fata", null },
                    { 460, 4, "Negru", 1, null, 146000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, null, 5950, null, 0, null, null },
                    { 468, 3, "Argint", 1, "Romania", 115115, 4, 5, 1968, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 177, 13900, true, 0, "Fata", "WAUZZZ4G3EN173639" },
                    { 470, 5, "Gri", 1, "Germania", 225000, 5, 4, 1995, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 150, 3200, null, 0, "Fata", null },
                    { 471, 3, "Negru", 1, "Germania", 218000, null, 5, 1968, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 143, 8990, null, 1, "Fata", null },
                    { 472, 3, "Alte culori", 1, "Germania", 148000, null, 6, 1600, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 12650, null, 1, "Fata", null },
                    { 473, 2, "Gri", 1, "Romania", 57000, 5, 6, 2143, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 477, 136, 14350, true, 0, "Fata", "WDD1760081J278256" },
                    { 474, 1, "Gri", 1, null, 190500, null, null, 1200, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, null, 5200, true, 1, "Fata", null },
                    { 475, 4, "Negru", 1, "Germania", 171500, 5, 4, 1598, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 109, 3950, null, 1, "Fata", null },
                    { 476, 1, "Rosu", 1, "Romania", 14300, null, 6, 998, 0, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 120, 12490, true, 0, "Fata", null },
                    { 469, 4, "Negru", 1, "Germania", 200000, null, 5, 2000, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 5990, null, 1, "Fata", "WVWZZZ3CZ9E070454" },
                    { 439, 5, "Alte culori", 1, "Germania", 300, 4, 5, 1968, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 432, 105, 8150, null, 1, "Fata", null },
                    { 459, 4, "Argint", 1, "Romania", 114045, 5, 6, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 10200, true, 0, "Fata", "TMBJG7NE4G0059897" },
                    { 457, 1, "Gri", 1, "Romania", 69960, 5, 5, 1499, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 6299, true, 1, "Fata", "WF0DXXGAKDDU44271" },
                    { 441, 1, "Gri", 1, "Belgia", 61000, null, 6, 1400, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, 90, 8750, null, 1, "Fata", "WVWZZZ6RZGY044721" },
                    { 442, 5, "Negru", 1, null, 196000, null, 5, 2986, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 141, 224, 14690, true, 1, null, null },
                    { 443, 6, "Rosu", 1, "Germania", 58504, 5, 6, 2199, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 197, 20490, null, 0, "4x4 (automat)", "KMHSW81XDFU485133" },
                    { 444, 3, "Negru", 1, "Germania", 178000, null, 6, 3000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 549, 258, 32000, true, 1, "4x4 (automat)", "WAUZZZ4H8EN008355" },
                    { 445, 3, "Negru", 1, "Franta", 227000, 4, 5, 2158, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 170, 15200, null, 0, "Spate", null },
                    { 446, 4, "Argint", 1, null, 171000, null, null, null, 0, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 3150, null, 0, null, null },
                    { 447, 4, "Albastru", 1, "Germania", 245000, 4, 4, 1896, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 101, 3000, true, 1, null, "WVWZZZ1JZ5W073284" },
                    { 458, 6, "Negru", 1, null, 108000, 5, 6, 2000, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 190, 22800, null, 0, "4x4 (automat)", "WAUZZZ8R6GA078059" },
                    { 448, 6, "Albastru", 1, "Romania", 187000, 4, null, 2967, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 553, 245, 10300, null, 1, null, "WAUZZZ4L87D046438" },
                    { 450, 4, "Gri", 1, null, 152000, 5, 6, 1595, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 136, 9800, null, 1, "Fata", null },
                    { 451, 3, "Negru", 1, "Franta", 195000, 4, 5, 2158, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, null, 12200, null, 0, "Spate", null },
                    { 452, 6, "Negru", 1, "Germania", 9532, 5, 6, 1999, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 241, 56554, null, 0, "4x4 (automat)", null },
                    { 453, 4, "Albastru", 1, "Regatul Unit", 425000, 4, 3, 1896, 1, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 110, 1500, true, 1, "Fata", null },
                    { 454, 4, "Negru", 1, "Germania", 167800, null, 5, 1968, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 5750, null, 1, "Fata", null },
                    { 455, 2, "Albastru", 1, "Germania", 179000, 5, 5, 2000, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 140, 6990, null, 1, "Fata", null },
                    { 456, 4, "Alb", 1, "Germania", 120000, 5, 5, 1598, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 80, 4700, null, 1, "Fata", null },
                    { 449, 0, "Rosu", 1, "Germania", 101500, 3, 4, 1249, 0, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 822, 69, 5900, true, 1, "Fata", null },
                    { 477, 6, "Negru", 1, "Olanda", 148750, 5, 5, 2143, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 737, 163, 8950, true, 1, "4x4 (automat)", null },
                    { 399, 3, "Argint", 1, "Germania", 170000, null, 4, 2993, 2, 1, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 549, 220, 7300, true, 1, null, null },
                    { 397, 4, "Alb", 1, "Germania", 190000, 5, 6, 1967, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 12800, null, 1, "Fata", null },
                    { 341, 2, "Gri", 1, "Romania", 118000, 5, null, 1400, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, null, 4000, true, 1, "Fata", "tmadb51caaj052454" },
                    { 342, 6, "Negru", 1, "Germania", 179022, 5, 4, 1968, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 8850, null, 0, "4x4 (automat)", "WVGZZZ5NZ8W045507" },
                    { 343, 5, "Argint", 1, "Germania", 131000, 5, 4, 1422, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 173, 80, 3990, null, 1, "Fata", null },
                    { 344, 8, "Gri", 1, null, 225000, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 486, null, 4499, null, 1, null, null },
                    { 345, 4, "Alb", 1, "Germania", 142231, 4, 6, 1598, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 120, 13980, null, 1, "Fata", null },
                    { 346, 3, "Verde", 1, null, 117000, null, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 724, null, 10500, null, 1, null, null },
                    { 347, 8, "Argint", 1, null, 109900, 2, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, null, 13900, null, 0, null, null },
                    { 340, 6, "Alb", 1, "Germania", 186000, 5, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 190, 22800, null, 1, "4x4 (automat)", null },
                    { 348, 4, "Gri", 1, "Belgia", 168093, 5, 4, 1686, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 125, 4950, null, 1, "Fata", "W0L0AHL35A2120790" },
                    { 350, 1, "Albastru", 1, "Germania", 122000, null, 6, 2000, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 150, 16350, true, 1, "Fata", null },
                    { 351, 3, "Alb", 1, "Germania", 53500, null, 6, 2996, 0, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 333, 31900, null, 1, "4x4 (automat)", null },
                    { 352, 3, "Gri", 1, "Germania", 220000, 4, 5, 1998, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 143, 11999, null, 0, "Fata", null },
                    { 353, 4, "Albastru", 1, "Germania", 146275, 4, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 190, 19390, null, 1, "Fata", null },
                    { 354, 6, "Alb", 1, "Romania", 1, 5, 6, 2000, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 180, 37000, true, 0, "4x4 (automat)", null },
                    { 355, 6, "Negru", 1, "Germania", 199000, null, 6, 2993, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 258, 26990, null, 1, "4x4 (automat)", "wbaks410500h56898" },
                    { 356, 6, "Alb", 1, "Germania", 168000, 5, 6, 1998, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 181, 17990, null, 1, null, null },
                    { 349, 6, "Negru", 1, "Germania", 210000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, null, 16499, null, 1, null, null },
                    { 357, 3, "Albastru", 1, "Elvetia", 180000, null, null, 3123, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 256, 7400, null, 1, "4x4 (automat)", null },
                    { 339, 6, "Argint", 1, "Romania", 133200, 5, 5, 2000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 14990, true, 1, "4x4 (automat)", "WVGZZZ5NZEW122799" },
                    { 337, 3, "Albastru", 1, "Germania", 160000, null, 6, 1995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 190, 21000, null, 1, "4x4 (automat)", null },
                    { 321, 5, "Negru", 1, "Germania", 203000, null, 5, 1995, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 150, 6000, true, 1, "Fata", "VF1JZ0YAE43201209" },
                    { 322, 3, "Negru", 1, "Germania", 97500, 4, 6, 2987, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 272, 29990, null, 1, "4x4 (automat)", null },
                    { 323, 6, "Negru", 1, null, 152970, null, 6, 2986, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 313, 38390, null, 1, "4x4 (automat)", null },
                    { 324, 4, "Gri", 1, "Germania", 210000, 4, 4, 1920, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 120, 3290, null, 1, "Fata", null },
                    { 325, 6, "Negru", 1, "Germania", 127000, 4, 6, 2995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 381, 44900, true, 1, "4x4 (automat)", null },
                    { 326, 4, "Albastru", 1, "Germania", 154178, 4, 6, 1995, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 11890, null, 1, "Spate", null },
                    { 327, 2, "Negru", 1, null, 287153, 4, null, null, 1, null, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 2800, null, 1, null, null },
                    { 338, 6, "Negru", 1, null, 310120, 5, 3, 2800, 1, 1, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 735, 150, 5800, true, 1, "4x4 (automat)", null },
                    { 328, 6, "Negru", 1, null, 226000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, null, 5000, null, 1, null, null },
                    { 330, 6, "Gri", 1, null, 146000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, null, 16499, null, 1, null, null },
                    { 331, 6, "Argint", 1, "Germania", 147232, 4, 6, 2191, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 266, 150, 13980, null, 1, "Fata", null },
                    { 332, 6, "Gri", 1, null, 189000, 5, 6, 1969, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 181, 14990, null, 1, "Fata", null },
                    { 333, 8, "Negru", 1, null, 190, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, null, 6499, null, 1, null, null },
                    { 334, 6, "Alb", 0, "Romania", 3, 5, 6, 1597, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 819, 128, 17185, null, 0, "4x4 (automat)", null },
                    { 335, 6, "Negru", 1, "Belgia", 158000, 5, 5, 1969, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 136, 16590, null, 0, "Fata", null },
                    { 336, 4, "Negru", 1, "Germania", 179000, 5, 6, 1968, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 11990, null, 1, "Fata", "WVWZZZ3CZGE084157" },
                    { 329, 2, "Rosu", 1, "Olanda", 170000, 5, 5, 1560, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 116, 10540, null, 1, "Fata", "YV1MZ845BE2051389" },
                    { 398, 2, "Argint", 1, "Germania", 85000, 4, 6, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 110, 7899, null, 1, "Fata", "W0LPD6E69FG036013" },
                    { 358, 3, "Gri", 1, "Germania", 109000, 5, 6, 2174, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 20900, true, 1, null, null },
                    { 360, 6, "Maro", 1, "Germania", 88000, null, null, 1995, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 184, 19500, true, 1, "4x4 (automat)", null },
                    { 381, 3, "Gri", 1, "Olanda", 157000, null, 5, 1996, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 140, 11390, null, 1, "Fata", null },
                    { 382, 4, "Negru", 1, "Germania", 163837, 5, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 190, 16500, null, 0, "Fata", "WAUZZZ8K0FA168776" },
                    { 383, 5, "Alb", 1, "Romania", 185000, 5, 4, 1987, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 264, 140, 4600, true, 0, "Fata", null },
                    { 384, 3, "Alb", 1, "Germania", 159600, 4, 6, 2143, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, null, 13200, null, 1, null, null },
                    { 385, 2, "Gri", 1, "Romania", 15000, null, 6, 2000, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 150, 16800, true, 1, "Fata", "WF05XXGCC5FM48342" },
                    { 386, 5, "Verde", 1, "Germania", 160000, 5, 6, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 136, 9700, null, 0, "Fata", "W0LPE9E33F1053218" },
                    { 387, 3, "Gri", 1, "Romania", 155000, 4, 4, 1798, 2, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 126, 4300, true, 1, "Fata", null },
                    { 380, 2, "Negru", 1, "Italia", 173570, 4, 4, 1968, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 200, 4900, null, 1, "Fata", null },
                    { 388, 6, "Alb", 1, "Romania", 36680, 4, 6, 1600, 4, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 296, 200, 7000, true, 1, "4x4 (automat)", null },
                    { 390, 6, "Verde", 1, "Germania", 300000, 5, 4, 2989, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 220, 2999, true, 1, "4x4 (automat)", null },
                    { 391, 4, "Negru", 1, "Germania", 176000, 4, 5, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 7599, null, 1, "Fata", "TMBJF7NE5F0047632" },
                    { 392, 5, "Argint", 1, "Germania", 180000, 5, null, 1500, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 485, null, 7190, null, 0, null, null },
                    { 393, 3, "Alb", 1, "Romania", 247353, 4, 4, 1686, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 80, 1800, true, 1, "Fata", null },
                    { 394, 4, "Alb", 1, "Germania", 181000, 5, 5, 2000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 9100, null, 0, "Fata", "WVWZZZ3CZEE008840" },
                    { 395, 3, "Gri", 1, "Franta", 130000, null, 5, 1995, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 177, 7999, null, 1, null, null },
                    { 396, 6, "Negru", 1, "Germania", 262000, 5, 5, 3000, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 240, 18500, true, 1, "4x4 (automat)", "WVGZZZ7PZBD001883" },
                    { 389, 6, "Gri", 1, "Germania", 187000, null, 4, 2967, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 553, 238, 15300, null, 1, "4x4 (automat)", null },
                    { 359, 4, "Gri", 1, "Olanda", 119092, 4, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 150, 17380, null, 1, "Fata", null },
                    { 379, 4, "Argint", 1, "Germania", 247650, 5, 3, 1900, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 116, 2150, null, 0, "Fata", null },
                    { 377, 3, "Negru", 1, "Franta", 168000, null, 6, 1997, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 194, 28300, null, 1, "Spate", null },
                    { 361, 6, "Negru", 1, "Germania", 189201, 4, 4, 1998, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 140, 2950, null, 0, "4x4-manual", null },
                    { 362, 6, "Albastru", 1, "Germania", 220000, null, 5, 1986, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 170, 12299, null, 0, "4x4-manual", null },
                    { 363, 3, "Gri", 1, "Germania", 187200, 4, 5, 3000, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 225, 9200, true, 1, "4x4 (automat)", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 364, 1, "Alb", 1, null, 130568, null, null, null, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, null, 9800, null, 1, null, null },
                    { 365, 3, "Negru", 1, null, 35000, null, null, null, 0, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 372, null, 35000, null, 1, null, "WBA4A71060GK17725" },
                    { 366, 1, "Gri", 1, "Germania", 220500, null, 5, 1390, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 120, 5590, null, 0, "Fata", null },
                    { 367, 4, "Negru", 1, "Germania", 163000, null, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 90, 6490, null, 1, "Fata", "TMBJJ65JXE3138933" },
                    { 378, 6, "Maro", 1, "Germania", 224000, null, 4, 2989, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 240, 8900, null, 0, "4x4 (automat)", null },
                    { 368, 2, "Gri", 1, "Romania", 113300, null, 5, null, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 5797, true, 1, "Fata", "WVWZZZ1KZBP159268" },
                    { 370, 4, "Maro", 1, "Germania", 197000, null, null, 1968, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 9990, null, 1, null, null },
                    { 371, 5, "Albastru", 1, "Romania", 200000, null, null, null, 1, null, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, null, 2100, null, 1, null, null },
                    { 372, 3, "Negru", 1, null, 160000, 5, 5, 1995, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 136, 10290, null, 1, null, "WBA3D91010F405184" },
                    { 373, 4, "Argint", 1, null, 225000, 4, null, 1896, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 131, 1950, null, 0, null, null },
                    { 374, 3, "Gri", 1, "Romania", 129000, 5, 4, 1600, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, 109, 5500, true, 0, "Fata", null },
                    { 375, 3, "Gri", 1, "Germania", 230000, 5, 4, 1997, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 136, 2100, true, 1, "Fata", null },
                    { 376, 6, "Maro", 1, "Germania", 117000, null, 6, 2000, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 170, 16000, true, 1, "4x4 (automat)", "WAUZZZ8R8CA083645" },
                    { 369, 1, "Argint", 1, "Germania", 81000, null, 4, 1000, 0, 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 582, 65, 1800, true, 1, "Fata", null },
                    { 320, 3, "Argint", 1, null, 151000, null, 5, 1968, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 143, 12500, null, 1, "Fata", "WAUZZZ8T3AA061836" },
                    { 478, 5, "Gri", 1, "Germania", 275000, null, 4, 1900, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, null, 2750, null, 1, "Fata", null },
                    { 480, 3, "Verde", 1, "Romania", 73000, 4, 5, 1956, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 163, 11400, true, 0, "4x4 (automat)", "W0LGT6GM7E1182393" },
                    { 581, 3, "Negru", 1, "Germania", 225000, 4, 5, 1968, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 5650, null, 1, "Fata", null },
                    { 582, 6, "Alb", 1, null, 150000, 4, 5, 1996, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 150, 9190, null, 0, "4x4 (automat)", null },
                    { 583, 1, "Alte culori", 1, "Olanda", 181000, 5, 4, 2953, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 160, 6950, null, 0, "Spate", null },
                    { 584, 3, "Auriu", 1, "Romania", 108683, 4, null, 2993, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 306, 16900, true, 0, "Spate", "WBAKM81000C490753" },
                    { 585, 4, "Albastru", 1, "Belgia", 178000, 5, 5, 2993, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 546, 239, 9450, null, 1, "4x4 (automat)", null },
                    { 586, 6, "Gri", 1, "Germania", 142000, 4, 5, 1968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 14190, null, 0, "4x4 (automat)", "WVGZZZ5NZDW038843" },
                    { 587, 4, "Negru", 1, "Germania", 217123, 4, 5, 2000, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 422, 170, 11400, null, 1, "4x4 (automat)", null },
                    { 580, 1, "Rosu", 1, null, 78000, null, null, null, 0, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, null, 2200, null, 1, null, null },
                    { 588, 6, "Alb", 1, "Germania", 88353, 5, 6, 2967, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 205, 29500, null, 0, "4x4 (automat)", null },
                    { 590, 3, "Albastru", 1, "Germania", 210000, 4, 5, 1968, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 170, 8900, true, 1, "Fata", "WAUZZZ4F99N051025" },
                    { 591, 5, "Gri", 1, "Olanda", 285000, 4, 5, 1560, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 216, 90, 4150, null, 0, "Fata", null },
                    { 592, 3, "Maro", 1, "Germania", 245000, null, 4, 2200, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 170, 7150, null, 1, "Spate", null },
                    { 593, 6, "Gri", 1, null, 162000, null, null, 1998, 0, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, null, 2850, null, 0, null, null },
                    { 594, 3, "Argint", 1, "Germania", 215000, 5, 4, 1968, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 170, 5500, true, 1, "Fata", "TMBUH61Z172073676" },
                    { 595, 2, "Negru", 1, "Franta", 171441, 3, 4, 1560, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 790, 110, 5590, null, 0, "Fata", "YV1MK76E2A2207007" },
                    { 596, 6, "Negru", 1, "Germania", 146500, 4, 5, 3000, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 235, 12690, true, 1, "4x4 (automat)", null },
                    { 589, 4, "Rosu", 1, null, 172000, null, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 7690, null, 1, "Fata", null },
                    { 597, 2, "Maro", 1, "Germania", 179639, 4, 6, 1598, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 110, 11490, null, 0, "Fata", "WAUZZZ8V7GA047173" },
                    { 579, 2, "Negru", 1, "Germania", 85000, 5, 4, 1669, 0, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 477, 115, 4390, null, 0, "Spate", null },
                    { 577, 4, "Gri", 1, "Germania", 165300, 5, 4, 1686, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 110, 3990, null, 0, "Fata", "W0L0AHL35B2000673" },
                    { 561, 1, "Alb", 1, "Franta", 155000, 5, 5, 1400, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 70, 4380, null, 1, "Fata", "VF3CC8HR0ET073980" },
                    { 562, 5, "Gri", 1, "Germania", 270000, 4, 5, 2143, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 136, 10500, true, 1, "Spate", "WDF63970313672036" },
                    { 563, 5, "Bej", 1, "Romania", 400000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 264, null, 4300, null, 1, null, null },
                    { 564, 4, "Gri", 1, "Suedia", 250000, 5, 5, 1989, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 163, 5900, true, 1, "Fata", null },
                    { 565, 5, "Argint", 1, "Belgia", 183000, 5, 5, 2148, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 141, 136, 12950, null, 1, "Spate", null },
                    { 566, 1, "Gri", 1, "Germania", 216345, 5, 4, 1600, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 90, 2399, null, 0, "Fata", null },
                    { 567, 6, "Albastru", 1, null, 262171, 5, 5, 1968, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 7200, true, 1, "4x4 (automat)", "WVGZZZ5NZAW039195" },
                    { 578, 1, "Alb", 1, "Romania", 150000, null, 4, 1198, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 848, 60, 1100, true, 1, "Fata", "ZFA16900001711176" },
                    { 568, 2, "Negru", 1, "Germania", 234072, 5, 5, 1390, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 80, 6000, null, 0, "Fata", null },
                    { 570, 3, "Alb", 1, null, 199500, null, 5, 1968, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 177, 14400, true, 0, null, null },
                    { 571, 3, "Gri", 1, "Romania", 81000, 4, 5, 1968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 14900, true, 1, "Fata", "WVWZZZ3CZDP047283" },
                    { 572, 1, "Negru", 1, "Germania", 194000, null, 4, 1968, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 140, 3890, null, 0, "Fata", null },
                    { 573, 4, "Alb", 1, "Olanda", 174226, null, 5, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 9490, null, 1, "Fata", null },
                    { 574, 3, "Argint", 1, "Franta", 253688, 4, 4, 1995, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 143, 6590, null, 0, "Spate", "WBAPN11020A255373" },
                    { 575, 1, "Argint", 1, null, 200000, 4, null, 1400, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, null, 1890, true, 0, null, null },
                    { 576, 3, "Gri", 1, null, 89903, 4, 6, 2967, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 549, 258, 28900, true, 0, "4x4 (automat)", "WAUZZZ4H2FN028294" },
                    { 569, 4, "Negru", 1, "Austria", 199000, 5, 5, 1968, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 110, 4790, null, 0, "Fata", null },
                    { 560, 3, "Argint", 1, "Germania", 55974, 5, 6, 1968, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 190, 20227, null, 0, null, null },
                    { 598, 3, "Negru", 1, "Romania", 310000, null, 3, 1900, 1, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 105, 2500, true, 0, "Fata", "WAUZZZ8E83A003676" },
                    { 600, 5, "Gri", 1, "Franta", 172358, null, 5, 1986, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 140, 10500, true, 1, "Fata", null },
                    { 621, 3, "Gri", 1, "Romania", 96000, 4, null, 1461, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, 82, 1600, true, 1, "Fata", "VF1LBTE0F33187550" },
                    { 622, 6, "Alte culori", 1, "Germania", 195438, null, 5, 2184, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 267, 173, 9690, null, 1, null, null },
                    { 623, 6, "Negru", 1, null, 94000, 5, 6, 2993, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 258, 31900, true, 0, "4x4 (automat)", "WBAKS410900H62638" },
                    { 624, 3, "Negru", 1, "Germania", 180000, 4, 5, 1968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 177, 13999, null, 1, "4x4 (automat)", "WAUZZZ8K6DN034036" },
                    { 625, 6, "Negru", 1, "Germania", 115060, 5, null, 2993, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 306, 22000, true, 0, "4x4 (automat)", "WBAZW61060L560768" },
                    { 626, 5, "Gri", 1, "Germania", 241500, 5, null, 1968, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 399, 140, 7600, null, 1, null, null },
                    { 627, 3, "Rosu", 1, null, 58000, null, 5, 1149, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, 75, 2850, true, 0, "Fata", null },
                    { 620, 4, "Gri", 1, "Romania", 303000, null, 5, 1968, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 140, 5600, true, 0, "Fata", null },
                    { 628, 3, "Negru", 1, "Germania", 13000, 4, 6, 2925, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 286, 77990, null, 0, "4x4 (automat)", null },
                    { 630, 3, "Negru", 1, "Germania", 93554, 4, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 190, 24500, null, 0, "Fata", "WAUZZZ8T0GA036689" },
                    { 631, 4, "Gri", 1, "Italia", 227833, 5, null, 2000, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 150, 3800, true, 1, null, null },
                    { 632, 3, "Maro", 1, null, 241948, 4, 5, 2993, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 258, 12000, true, 0, "4x4 (automat)", "WBAFV31060C695625" },
                    { 633, 6, "Alb", 1, "Romania", 141000, 5, null, 2200, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, 158, 7200, true, 1, "4x4 (automat)", "salfa28b87h008361" },
                    { 634, 3, "Gri", 1, "Germania", 115000, 4, 5, 2968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 492, 258, 18500, null, 0, "4x4 (automat)", null },
                    { 635, 5, "Albastru", 1, "Romania", 217, 5, 4, 2198, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 662, 85, 6500, true, 1, "Fata", "WF0SXXBDFS8R70243" },
                    { 636, 3, "Negru", 1, null, 300, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, null, 2350, null, 1, null, null },
                    { 629, 3, "Negru", 1, "Belgia", 165000, 4, 5, 1995, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 143, 8500, null, 0, "Spate", "WBAPN11070VJ87600" },
                    { 599, 3, "Negru", 1, "Germania", 187000, 5, 5, 1968, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 403, 140, 9900, true, 0, "Fata", null },
                    { 619, 3, "Alb", 1, "Romania", 58000, null, 6, 1500, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 90, 10800, true, 0, "Fata", null },
                    { 617, 5, "Alb", 1, "Romania", 180912, 6, 4, 1461, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 70, 1390, true, 0, "Fata", "UU1FSD1K539353031" },
                    { 601, 5, "Alb", 1, "Romania", 2, 5, 6, 1499, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 362, 140, 18800, null, 0, "Fata", "WBA6S11050VF84150" },
                    { 602, 2, "Gri", 1, "Germania", 205000, 5, null, 1461, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 86, 2390, true, 1, "Fata", null },
                    { 603, 3, "Alb", 1, null, 17300, null, null, null, 0, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, null, 8650, null, 1, null, null },
                    { 604, 6, "Albastru", 1, "Romania", 115000, 5, 4, 2400, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 806, null, 10800, null, 1, "4x4 (automat)", null },
                    { 605, 6, "Gri", 1, "Germania", 168000, null, 6, 3000, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 313, 27900, true, 1, "4x4 (automat)", null },
                    { 606, 3, "Gri", 1, "Germania", 199000, 5, null, 1995, 1, 1, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 136, 2700, true, 1, null, null },
                    { 607, 6, "Auriu", 1, "Romania", 12102, 4, 6, 2993, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 600, 259, 78920, true, 0, "4x4 (automat)", null },
                    { 618, 4, "Alb", 1, "Germania", 157796, 5, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 150, 13500, null, 0, "Fata", "WVWZZZAUZFP589409" },
                    { 608, 6, "Negru", 1, "Austria", 188350, 5, 4, 2000, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 150, 6390, null, 1, "Fata", null },
                    { 610, 6, "Alb", 1, "Romania", 27756, 5, null, 2494, 4, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, 155, 32950, true, 0, "4x4 (automat)", "JTMDJREV40D012295" },
                    { 611, 3, "Argint", 1, null, 260000, 4, null, 2499, 0, 1, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 719, 200, 1150, null, 1, "Spate", null },
                    { 612, 5, "Alb", 1, "Romania", 186000, null, null, 1900, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 216, null, 1290, true, 0, null, null },
                    { 613, 2, "Gri", 1, "Germania", 244187, 4, 4, 1896, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 3990, null, 0, "Fata", null },
                    { 614, 1, "Gri", 1, "Germania", 172500, null, 5, 1700, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 110, 6800, true, 1, "Fata", "W0LPD6EWXDG021968" },
                    { 615, 4, "Alb", 1, "Germania", 171000, 5, 5, 1560, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 111, 4290, true, 0, "Fata", null },
                    { 616, 1, "Albastru", 1, "Germania", 234000, null, null, 1997, 1, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 143, 1650, null, 0, null, null },
                    { 609, 3, "Gri", 1, "Olanda", 189000, 4, 6, 2191, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 252, 150, 10390, null, 1, "Fata", "JMZBM622611165297" },
                    { 479, 3, "Negru", 1, "Germania", 155000, 4, 5, 2143, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, null, 13200, null, 1, "Spate", null },
                    { 559, 4, "Gri", 1, null, 213000, null, null, null, 1, null, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, null, 2350, null, 1, null, null },
                    { 557, 4, "Negru", 1, "Italia", 188722, 4, 5, 1969, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 110, 7190, null, 0, "Fata", "YV1MV5151E2111095" },
                    { 501, 6, "Alb", 1, "Germania", 185000, 4, 5, 1998, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 10990, null, 1, "4x4 (automat)", null },
                    { 502, 3, "Alb", 1, "Romania", 192000, 4, 5, 1996, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 14990, true, 1, "Spate", null },
                    { 503, 4, "Gri", 1, "Belgia", 186000, null, 5, 2198, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 204, 9490, null, 1, "Spate", null },
                    { 504, 3, "Gri", 1, "Germania", 169000, null, 5, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 184, 14800, null, 1, "Fata", "TMBAK7NE6F0196756" },
                    { 505, 4, "Gri", 1, "Romania", 195000, 5, 4, 1800, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 120, 12000, true, 1, null, "WF0WXXGCDW7L12462" },
                    { 506, 4, "Gri", 1, "Germania", 168000, 5, 4, 1968, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 170, 5650, true, 1, "Fata", null },
                    { 507, 8, "Alb", 1, "Romania", 61000, 2, null, 5461, 0, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 486, 387, 28000, true, 1, "4x4 (automat)", null },
                    { 500, 6, "Negru", 1, "Germania", 197000, null, 5, 3000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 245, 16850, null, 1, "4x4 (automat)", null },
                    { 508, 6, "Argint", 1, "Germania", 230000, 5, null, 2400, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 805, 185, 8900, true, 1, "4x4 (automat)", null },
                    { 510, 6, "Alb", 1, "Romania", 278180, 5, 5, 2993, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 286, 18450, true, 0, "4x4 (automat)", null },
                    { 511, 5, "Alb", 1, "Germania", 151369, 1, 5, 1596, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 125, 12999, true, 1, null, null },
                    { 512, 6, "Negru", 1, "Romania", 7850, 5, 6, 2755, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 339, 177, 31900, true, 0, "4x4 (automat)", null },
                    { 513, 3, "Negru", 1, "Germania", 189989, null, 5, 2995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 378, 313, 29990, null, 1, "Spate", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 514, 6, "Negru", 1, "Germania", 11000, null, 6, 3000, 4, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 340, 105000, true, 0, "4x4 (automat)", null },
                    { 515, 3, "Negru", 1, null, 223000, null, 5, 3000, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 245, 17900, null, 1, "4x4 (automat)", null },
                    { 516, 8, "Argint", 1, "Germania", 265000, 2, 4, 1600, 0, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 75, 1150, null, 1, "Fata", null },
                    { 509, 4, "Negru", 1, "Germania", 253000, 5, 4, 1997, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 115, 4990, null, 0, "Fata", null },
                    { 517, 5, "Alb", 1, null, 500000, 1, null, 3000, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 515, 190, 14999, true, 1, "Spate", null },
                    { 499, 3, "Albastru", 1, "Germania", 199000, 4, 5, 2997, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 245, 16200, true, 1, "4x4 (automat)", null },
                    { 497, 3, "Gri", 1, "Romania", 182000, null, null, 1996, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 160, 6900, true, 1, "Fata", null },
                    { 481, 2, "Gri", 1, null, 195000, null, 4, 1900, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 131, 3800, true, 1, "Fata", null },
                    { 482, 4, "Negru", 1, null, 147000, 5, 5, 1582, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 575, 125, 6190, null, 1, "Fata", null },
                    { 483, 4, "Gri", 1, "Germania", 192000, 5, 5, 1600, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 9350, null, 1, "Fata", null },
                    { 484, 0, "Negru", 1, "Germania", 208000, null, 4, 1196, 0, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, null, 2250, null, 1, "Fata", null },
                    { 485, 3, "Alte culori", 1, "Germania", 143000, 5, 5, 1400, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 122, 6190, null, 0, "Fata", null },
                    { 486, 4, "Gri", 1, null, 161000, null, 6, 2000, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 150, 13150, null, 1, "4x4 (automat)", null },
                    { 487, 8, "Negru", 1, "Italia", 81000, null, null, 1798, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 150, 5400, null, 1, "Fata", null },
                    { 498, 3, "Alb", 1, "Germania", 210000, 4, 5, 1995, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 8999, null, 1, "Spate", "WBAPP11020E554235" },
                    { 488, 7, "Gri", 1, "Germania", 132900, 2, 4, 1600, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 105, 2900, true, 0, "Fata", null },
                    { 490, 2, "Albastru", 1, null, 320, null, null, null, 1, null, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 515, null, 10000, null, 1, null, null },
                    { 491, 6, "Negru", 1, "Germania", 195000, null, 5, 1968, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 170, 15290, null, 1, "4x4 (automat)", null },
                    { 492, 6, "Alb", 1, "Austria", 39000, 5, 5, 1686, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, 131, 10980, null, 1, "4x4 (automat)", "W0LJC7EL6EB627416" },
                    { 493, 6, "Gri", 1, null, 150000, null, null, 2498, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, null, 6999, null, 0, null, null },
                    { 494, 2, "Rosu", 1, null, 251000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 5550, null, 1, null, null },
                    { 495, 6, "Alb", 1, null, 82000, null, null, 1598, 0, 0, new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 456, null, 2150, null, 0, null, null },
                    { 496, 6, "Gri", 1, "Germania", 168000, 5, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 170, 17990, null, 1, "4x4 (automat)", "WDC1569051J089919" },
                    { 489, 6, "Negru", 1, null, 168000, null, null, 2198, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, null, 6450, null, 0, null, null },
                    { 558, 6, "Gri", 1, "Franta", 250000, 5, 4, 2200, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, 160, 6700, null, 1, "4x4 (automat)", null },
                    { 518, 6, "Argint", 1, "Polonia", 165545, 5, 4, 1900, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, 130, 4999, null, 0, "4x4-manual", null },
                    { 520, 3, "Gri", 0, null, 4, null, null, 2925, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 492, 340, 86522, null, 0, "4x4 (automat)", "WDD2573231A035180" },
                    { 541, 4, "Gri", 1, "Germania", 241000, 4, 4, 1896, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 4199, null, 1, "Fata", null },
                    { 542, 8, "Alte culori", 1, "Germania", 190000, 2, 5, 2000, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 165, 8590, null, 1, "Fata", null },
                    { 543, 1, "Gri", 1, "Germania", 1900000, null, 4, 1600, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, null, 3390, null, 1, "Fata", null },
                    { 544, 8, "Negru", 1, "Belgia", 179200, null, 4, 2700, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 240, 8950, null, 1, "Fata", null },
                    { 545, 4, "Negru", 1, "Romania", 92085, null, null, null, 0, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, null, 6950, null, 1, null, null },
                    { 546, 3, "Gri", 1, "Belgia", 168000, 5, 5, 1598, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 10990, null, 1, "Fata", "TMBAG9NE7E0161834" },
                    { 547, 6, "Negru", 1, null, 161000, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, null, 15800, null, 0, null, null },
                    { 540, 2, "Alb", 1, null, 165000, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, null, 8200, null, 1, null, null },
                    { 548, 3, "Negru", 1, "Germania", 80500, 4, 6, 2993, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 317, 52500, true, 1, "4x4 (automat)", null },
                    { 550, 3, "Alb", 1, "Romania", 167881, 4, 5, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 175, 115, 7499, true, 0, "Fata", "TMBAE6NH0G4011994" },
                    { 551, 0, "Alb", 1, "Romania", 72120, 3, 4, 998, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 307, 70, 4790, true, 0, "Fata", null },
                    { 552, 2, "Alb", 1, "Romania", 112500, 5, 5, 1958, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 90, 8950, true, 1, "Fata", "WVWZZZAUZEW328738" },
                    { 553, 4, "Bej", 1, "Belgia", 190970, null, 5, 1596, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 110, 7890, null, 1, "Fata", "wvwzzz3czee024231" },
                    { 554, 3, "Gri", 1, "Romania", 39393, 4, 6, 2925, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 285, 62185, true, 0, "4x4 (automat)", "WDD2220211A368834" },
                    { 555, 1, "Verde", 1, null, 140000, null, null, null, 0, null, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 119, null, 980, null, 1, null, null },
                    { 556, 3, "Gri", 1, "Germania", 211000, null, 4, 2490, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 177, 5590, null, 1, "Spate", "Wbanc51000cr26791" },
                    { 549, 7, "Negru", 1, "Germania", 183000, 2, 4, 1900, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 131, 3190, null, 1, "Fata", null },
                    { 519, 3, "Negru", 1, "Germania", 189000, 5, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 190, 16999, null, 1, "Fata", null },
                    { 539, 3, "Gri", 1, "Spania", 188000, 5, 4, 1785, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 125, 5200, true, 1, "Fata", null },
                    { 537, 3, "Negru", 1, "Olanda", 199950, 4, 4, 2179, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 136, 7800, true, 1, "Spate", null },
                    { 521, 5, "Argint", 1, "Germania", 218000, null, 4, 2200, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 116, 6200, null, 1, "Spate", null },
                    { 522, 3, "Negru", 1, "Germania", 270362, 5, 5, 2993, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 258, 25200, true, 0, "4x4 (automat)", null },
                    { 523, 3, "Alb", 1, null, 67200, null, null, 2987, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 492, 258, 46050, null, 0, null, "WDD2183941A186501" },
                    { 524, 4, "Negru", 1, "Germania", 278000, 4, 4, 1980, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 4650, null, 1, "Fata", null },
                    { 525, 4, "Albastru", 1, "Olanda", 212077, 5, 4, 1598, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 112, 3490, null, 0, "Fata", "VF1KM1R0H39372932" },
                    { 526, 1, "Gri", 1, "Germania", 160000, null, null, null, 0, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 3390, null, 1, null, null },
                    { 527, 4, "Gri", 1, null, 174000, null, 5, 1600, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 5500, null, 1, "Fata", "WVWZZZ1KZBM607109" },
                    { 538, 8, "Gri", 1, null, 230000, 3, 5, 2986, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 231, 11200, null, 1, "Spate", null },
                    { 528, 3, "Negru", 1, "Germania", 179000, 5, 6, 1995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 372, 190, 18990, true, 0, "Spate", null },
                    { 530, 4, "Negru", 1, "Germania", 175000, null, 5, 1590, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 109, 3950, null, 1, "Fata", null },
                    { 531, 2, "Maro", 1, "Romania", 74000, 5, 5, 1396, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 100, 7500, true, 1, "Fata", "TMAD351AADJ007006" },
                    { 532, 4, "Gri", 1, "Germania", 193000, null, 6, 1968, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 190, 11990, null, 1, "Fata", null },
                    { 533, 5, "Argint", 1, "Germania", 183011, 5, 4, 1798, 0, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 632, 120, 2999, null, 0, "Fata", "WF0MXXGCDM3T18699" },
                    { 534, 1, "Gri", 1, "Germania", 140000, null, null, null, 0, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, null, 3990, null, 1, null, null },
                    { 535, 4, "Negru", 1, "Germania", 20513, 5, 6, 2967, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 546, 218, 32725, null, 0, "4x4 (automat)", null },
                    { 536, 3, "Negru", 1, null, 240000, null, null, 2000, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 5500, null, 1, null, null },
                    { 529, 2, "Gri", 1, "Belgia", 240000, null, 4, 1700, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 1850, null, 0, null, null },
                    { 637, 6, "Gri", 1, "Romania", 250500, 5, 4, 2461, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 174, 7500, true, 1, "4x4 (automat)", "WVGZZZ7LZ9D020575" },
                    { 319, 2, "Negru", 1, "Germania", 71100, 5, null, 1686, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 110, 6800, true, 1, null, "W0LPD6EG1C1121810" },
                    { 317, 6, "Negru", 1, "Germania", 230000, null, 4, 2400, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 806, 185, 5500, true, 1, "4x4 (automat)", null },
                    { 101, 6, "Albastru", 1, "Germania", 227531, 5, 3, 2685, 1, 1, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 738, 163, 3990, null, 0, "4x4 (automat)", null },
                    { 102, 1, "Negru", 1, "Germania", 187000, 4, 4, 1300, 0, 1, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 891, 95, 2800, null, 1, "Fata", null },
                    { 103, 4, "Negru", 1, "Germania", 207000, null, null, 2967, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 204, 12500, null, 1, "Fata", "WAUZZZ8K0FA052963" },
                    { 104, 4, "Gri", 1, "Franta", 148000, 5, 6, 1500, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 110, 6450, null, 1, "Fata", null },
                    { 105, 1, "Gri", 1, null, 134000, null, null, null, 2, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, null, 3200, null, 1, null, null },
                    { 106, 2, "Negru", 1, null, 186500, null, 5, 1986, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 140, 8300, null, 1, "Fata", null },
                    { 107, 3, "Argint", 1, "Franta", 232000, 5, 4, 1900, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 5999, null, 1, "Fata", null },
                    { 100, 0, "Albastru", 1, "Germania", 124520, 2, 4, 1242, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 822, 70, 3690, null, 1, "Fata", null },
                    { 108, 3, "Negru", 1, "Germania", 158000, 5, 6, 2995, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 548, 272, 28700, null, 0, "4x4 (automat)", null },
                    { 110, 1, "Alte culori", 1, null, 313000, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, null, 5700, null, 1, null, null },
                    { 111, 3, "Negru", 1, "Germania", 189000, 4, 5, 1998, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 140, 14600, true, 1, "Fata", "WVWZZZ3CZFE808855" },
                    { 112, 8, "Rosu", 1, "Belgia", 190000, 5, 4, 1461, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 110, 4990, true, 0, "Fata", null },
                    { 113, 4, "Alb", 1, "Franta", 162000, 5, 6, 1500, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 110, 6500, null, 1, "Fata", null },
                    { 114, 1, "Gri", 1, null, 191626, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, null, 13600, null, 1, null, null },
                    { 115, 6, "Gri", 1, "Germania", 234780, null, 5, 1995, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 184, 12350, null, 1, "4x4 (automat)", null },
                    { 116, 2, "Negru", 1, "Germania", 168500, 5, 5, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 184, 11850, null, 1, "Spate", "WBA1C31070J535474" },
                    { 109, 6, "Alb", 1, "Germania", 97202, 5, 5, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, null, 6390, null, 0, null, "UU1HSDAG549270508" },
                    { 117, 3, "Maro", 1, "Germania", 173000, 5, 6, 2968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 218, 22750, null, 0, "4x4 (automat)", null },
                    { 99, 3, "Gri", 1, null, 172226, null, null, null, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, null, 8200, null, 1, null, "WDD2040031A314671" },
                    { 97, 4, "Negru", 1, "Germania", 107000, null, null, 1560, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 111, 4990, null, 1, "Fata", null },
                    { 81, 6, "Gri", 1, "Belgia", 295000, 5, null, 2497, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 175, 5500, null, 0, "4x4 (automat)", "WVGZZZ7LZ4D075213" },
                    { 82, 3, "Negru", 1, "Germania", 200000, 4, 4, 1600, 0, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 105, 2990, true, 1, "Fata", null },
                    { 83, 0, "Alb", 1, null, 270000, null, null, null, 2, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, null, 1390, null, 1, null, null },
                    { 84, 4, "Negru", 1, "Germania", 190900, 5, 5, 1968, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 8200, null, 0, "Fata", "WVWZZZ3CZBE371546" },
                    { 85, 6, "Alb", 1, "Belgia", 175000, 5, 5, 1995, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 185, 13990, null, 0, "4x4 (automat)", "WBAWY31050L538904" },
                    { 86, 4, "Gri", 1, null, 219000, 5, 5, 1598, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 105, 9200, null, 0, "Fata", "WVWZZZ3CZDE003859" },
                    { 87, 3, "Gri", 1, "Germania", 189000, null, 4, 1560, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 794, 110, 4500, true, 1, "Fata", null },
                    { 98, 6, "Negru", 1, null, 1850000, null, null, 1999, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 598, 180, 20900, null, 1, null, "salca2bn4gh568867" },
                    { 88, 2, "Negru", 1, null, 139000, null, null, null, 0, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, null, 5990, null, 1, null, null },
                    { 90, 1, "Negru", 1, null, 70000, null, null, null, 0, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, null, 5350, null, 1, null, "VF7SCKFT0AA690491" },
                    { 91, 3, "Gri", 1, null, 261814, null, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 6200, null, 1, null, "WBAVG91090A347449" },
                    { 92, 6, "Negru", 1, "Germania", 153480, null, 5, 2993, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 306, 28000, null, 1, "4x4 (automat)", "WBAFH01070L860006" },
                    { 93, 3, "Alb", 1, "Germania", 123000, 4, 6, 2993, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 320, 54999, true, 1, "4x4 (automat)", null },
                    { 94, 3, "Negru", 1, "Germania", 217000, null, 5, 2968, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 306, 16900, null, 0, "4x4 (automat)", null },
                    { 95, 3, "Negru", 1, null, 229000, null, 5, 3000, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 245, 13999, true, 1, "Spate", null },
                    { 96, 6, "Alb", 1, null, 136000, null, 6, 1598, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226, 160, 15999, null, 0, "4x4 (automat)", "SHSRE6890FU513547" },
                    { 89, 0, "Maro", 1, "Germania", 168000, null, null, null, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 216, null, 41900, true, 1, null, null },
                    { 80, 4, "Negru", 1, "Germania", 193000, 4, 6, 1600, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 120, 7800, null, 1, "Fata", null },
                    { 118, 2, "Rosu", 1, "Romania", 155271, 4, 4, 1595, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 3400, true, 1, "Fata", "WVWZZZ1KZ7P030198" },
                    { 120, 4, "Gri", 1, "Germania", 185000, 5, 5, 1986, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 8299, null, 1, "Fata", "WVWZZZ3CZCE117745" },
                    { 141, 4, "Negru", 1, "Olanda", 192000, 5, 6, 1800, 4, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 598, 136, 13500, null, 1, "Fata", "SB1ZS3JE30E053568" },
                    { 142, 3, "Negru", 1, null, 185326, null, null, 2200, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 107, 170, 4700, null, 0, "Fata", null },
                    { 143, 4, "Alb", 1, "Germania", 248000, null, 6, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 8499, null, 1, "Fata", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 144, 6, "Gri", 1, null, 89600, 5, 5, 1598, 2, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 105, 7300, null, 1, "Fata", "UU1HSDCM544918364" },
                    { 145, 4, "Albastru", 1, "Germania", 198000, null, 5, 1989, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 5800, true, 1, "Fata", null },
                    { 146, 3, "Rosu", 1, "Olanda", 156600, 4, 6, 2198, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 150, 15000, true, 1, "Fata", "JMZGJ621691311558" },
                    { 147, 0, "Argint", 1, "Franta", 172120, 5, 5, 1586, 0, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 120, 5350, null, 1, "Fata", null },
                    { 140, 3, "Negru", 1, "Romania", 182000, 4, 5, 1995, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 160, 5550, true, 0, "Fata", "W0LGT6EM7A1113684" },
                    { 148, 3, "Negru", 1, null, 227000, null, 4, 2993, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 235, 8500, null, 1, "4x4 (automat)", null },
                    { 150, 6, "Gri", 1, "Romania", 60900, 4, 6, 2755, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 339, 177, 40000, true, 1, "4x4 (automat)", "JTEBR3FJ90K065381" },
                    { 151, 4, "Negru", 1, null, 240000, 5, 5, 2995, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 240, 8180, null, 1, "4x4 (automat)", null },
                    { 152, 2, "Alb", 1, "Italia", 173000, 4, 6, 1987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 150, 13899, null, 1, "Fata", "WAUZZZ8VXEA117522" },
                    { 153, 6, "Gri", 1, "Romania", 180000, 4, 4, 2967, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 240, 6500, true, 1, "4x4 (automat)", null },
                    { 154, 1, "Albastru", 1, "Germania", 240000, null, 3, 1896, 1, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 395, 90, 1999, true, 1, "Fata", null },
                    { 155, 6, "Gri", 1, null, 203000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, null, 16800, null, 1, null, null },
                    { 156, 3, "Argint", 1, null, 232000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, null, 5990, true, 1, null, null },
                    { 149, 3, "Negru", 1, null, 212000, null, 5, 2000, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 140, 7990, null, 1, null, "WVWZZZ3CZ9E563698" },
                    { 119, 4, "Alte culori", 1, "Franta", 240000, 5, 5, 1995, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 7999, null, 1, "4x4 (automat)", null },
                    { 139, 3, "Negru", 1, "Germania", 146000, 5, 6, 1958, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 140, 14600, null, 1, "Fata", null },
                    { 137, 4, "Negru", 1, "Germania", 206400, 5, 5, 1968, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 110, 4690, null, 1, "Fata", null },
                    { 121, 4, "Rosu", 1, null, 199000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 6450, null, 0, null, null },
                    { 122, 2, "Negru", 1, "Germania", 225419, 5, 4, 1686, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 2650, null, 0, "Fata", null },
                    { 123, 6, "Negru", 1, "Germania", 169000, null, 6, 2143, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 502, 204, 29290, null, 1, "4x4 (automat)", "WDC2539091F026802" },
                    { 124, 6, "Albastru", 1, "Germania", 220000, null, 5, 2989, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 306, 18500, true, 1, "4x4 (automat)", null },
                    { 125, 6, "Negru", 1, null, 147000, null, 4, 1500, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, null, 4950, null, 0, null, null },
                    { 126, 1, "Albastru", 1, "Romania", 105000, 5, 4, 1398, 2, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 762, 88, 4650, true, 1, "Fata", null },
                    { 127, 0, "Albastru", 1, null, 270000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 5500, null, 1, null, null },
                    { 138, 4, "Gri", 1, null, 201900, null, 5, 1968, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 6000, true, 1, "Fata", null },
                    { 128, 2, "Gri", 1, "Romania", 127000, 4, 4, 1995, 0, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 150, 4700, true, 1, "Spate", "WBAUF51020PW37665" },
                    { 130, 0, "Rosu", 1, "Germania", 142758, 4, null, null, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, null, 4599, true, 1, null, null },
                    { 131, 4, "Gri", 1, "Germania", 210563, 5, 4, 1968, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 170, 4390, null, 0, "Fata", null },
                    { 132, 3, "Albastru", 1, "Olanda", 57560, 5, 6, 1197, 0, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 175, 90, 11000, null, 1, "Fata", "TMBAA6NHXG4012811" },
                    { 133, 3, "Auriu", 1, "Germania", 198120, null, 5, 1995, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 12750, true, 1, "Spate", null },
                    { 134, 1, "Albastru", 1, "Romania", 4747, null, 6, 1498, 4, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, 100, 14999, true, 1, "Fata", null },
                    { 135, 6, "Maro", 1, "Germania", 84000, 5, 6, 2987, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 46880, null, 1, "4x4 (automat)", "WDC2923241A028703" },
                    { 136, 4, "Negru", 1, "Germania", 211000, null, 5, 1968, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 170, 8698, null, 0, null, null },
                    { 129, 1, "Gri", 1, "Germania", 235000, null, null, 1422, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 533, 75, 3000, true, 1, "Fata", null },
                    { 157, 3, "Negru", 1, "Germania", 165000, 4, 5, 1600, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 110, 10500, null, 1, "Fata", null },
                    { 79, 3, "Gri", 1, "Franta", 218000, 4, null, 1968, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 6700, true, 1, "Fata", "WVWZZZ3CZ9P051189" },
                    { 77, 5, "Gri", 1, null, 193710, null, 4, 1896, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 105, 5599, null, 1, "Fata", null },
                    { 21, 4, "Gri", 1, null, 221000, null, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, null, 2900, null, 1, null, null },
                    { 22, 3, "Negru", 1, "Olanda", 183500, null, 5, 1997, 4, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 200, 8900, null, 1, "4x4 (automat)", "vf38drhc8cl065298" },
                    { 23, 5, "Alb", 1, "Germania", 158043, null, 6, 2000, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 150, 12800, null, 1, null, null },
                    { 24, 4, "Verde", 1, null, 168500, null, null, null, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 7700, null, 1, null, null },
                    { 25, 1, "Alb", 1, null, 230000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 515, null, 7300, null, 1, null, null },
                    { 26, 6, "Argint", 1, "Romania", 119000, null, 5, 2468, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 338, 150, 17800, true, 0, null, null },
                    { 27, 0, "Gri", 1, "Germania", 232900, null, 4, 2000, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 122, 3590, true, 0, "Spate", null },
                    { 20, 4, "Albastru", 1, "Belgia", 190000, 4, 5, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 8390, null, 1, "Fata", "WVWZZZAUZEP530616" },
                    { 28, 0, "Negru", 1, "Romania", 12000, null, 6, 1593, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 156, 29900, true, 1, "Spate", "WDD2050401R394869" },
                    { 30, 3, "Maro", 1, "Germania", 125000, 5, 6, 2967, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 548, 320, 30000, null, 0, "4x4 (automat)", null },
                    { 31, 6, "Albastru", 1, "Germania", 39000, 5, 6, 1995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 190, 34900, true, 1, "4x4 (automat)", "WBAHU310205E32695" },
                    { 32, 3, "Negru", 1, "Romania", 243881, 4, null, 1968, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, 140, 5500, true, 1, "Fata", null },
                    { 33, 1, "Rosu", 1, null, 162000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 1500, null, 1, null, null },
                    { 34, 6, "Gri", 1, null, 120000, null, 5, 1598, 2, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 107, 6950, null, 1, "Fata", "UU1HSDCM545585426" },
                    { 35, 5, "Argint", 1, "Germania", 170000, null, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 3100, true, 1, null, null },
                    { 36, 6, "Argint", 1, "Belgia", 210000, 5, 5, 1996, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 184, 15500, true, 1, "4x4 (automat)", null },
                    { 29, 3, "Negru", 1, null, 189600, 5, 5, 1968, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 8500, null, 1, "Fata", null },
                    { 37, 3, "Albastru", 1, "Franta", 189500, 4, 5, 1998, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 140, 9600, true, 1, "Fata", null },
                    { 19, 6, "Negru", 1, null, 55000, null, 6, 1600, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226, 160, 22800, true, 1, "4x4 (automat)", null },
                    { 17, 6, "Maro", 1, "Romania", 29200, 5, 6, 1390, 0, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 456, 140, 7790, true, 1, "4x4 (automat)", null },
                    { 1, 4, "Gri", 1, "Olanda", 311000, null, 4, 1995, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 4999, null, 0, "Fata", null },
                    { 2, 3, "Gri", 1, null, 181000, 4, null, 1998, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 292, 140, 5300, true, 0, "Fata", null },
                    { 3, 5, "Alb", 1, "Germania", 270234, 5, 4, 2461, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 404, 136, 7999, null, 1, "Spate", "WV1ZZZ2EZ96022047" },
                    { 4, 4, "Negru", 1, null, 199000, 5, 5, 1461, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 110, 6350, null, 0, "Fata", "VF1KZX40648593489" },
                    { 5, 4, "Negru", 1, "Germania", 192377, 5, 5, 2000, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 9900, true, 1, "Fata", "WVWZZZ3CZDE008613" },
                    { 6, 3, "Albastru", 1, null, 227000, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, null, 16200, null, 1, null, null },
                    { 7, 4, "Negru", 1, "Germania", 240000, null, 4, 1995, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 129, 3700, true, 1, "Spate", null },
                    { 18, 3, "Albastru", 1, null, 232586, null, 5, 1995, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 11999, null, 1, "Spate", null },
                    { 8, 3, "Alb", 1, "Germania", 105000, 4, null, 2143, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 200, 26000, true, 1, "4x4 (automat)", "WDD2120821B022895" },
                    { 10, 2, "Gri", 1, "Suedia", 206000, 4, 4, 1600, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 102, 4670, null, 0, "Fata", null },
                    { 11, 3, "Alb", 1, "Germania", 172000, 5, 5, 1995, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 12000, null, 0, "Spate", "WBA3D31030J308742" },
                    { 12, 1, "Argint", 1, "Germania", 204000, null, 3, 1896, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 131, 2900, true, 0, "Fata", null },
                    { 13, 3, "Argint", 1, "Belgia", 274000, 4, null, 2000, 0, 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 200, 4700, true, 1, "4x4 (automat)", null },
                    { 14, 4, "Gri", 1, "Franta", 172000, 4, 5, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 7750, null, 1, "Fata", "WVWZZZAUZFP622325" },
                    { 15, 4, "Gri", 1, "Franta", 183000, 5, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 12950, null, 1, "Fata", "WVWZZZ3CZFE409182" },
                    { 16, 4, "Alb", 1, null, 97390, null, 5, 1495, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 90, 5990, null, 1, "Fata", null },
                    { 9, 3, "Negru", 1, "Belgia", 141608, 4, 4, 1995, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 163, 8490, null, 0, "Spate", "WBANX11000CX85847" },
                    { 78, 1, "Gri", 1, null, 158000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 3400, null, 1, null, null },
                    { 38, 3, "Gri", 1, null, 270000, null, 4, 2000, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, null, 7000, true, 1, "Fata", null },
                    { 40, 4, "Gri", 1, "Germania", 2009, null, null, null, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, null, 8300, null, 1, null, null },
                    { 61, 1, "Rosu", 1, null, 22500, null, null, null, 0, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, null, 6500, null, 1, null, null },
                    { 62, 6, "Negru", 1, "Olanda", 189000, 4, 5, 2200, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 591, 197, 10800, true, 1, null, null },
                    { 63, 4, "Albastru", 1, "Germania", 328000, 5, 4, 1998, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 131, 2899, true, 1, "Fata", "WF0WXXGBBW4G74978" },
                    { 64, 3, "Gri", 1, "Germania", 179716, 5, 5, 2000, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 403, 140, 12000, true, 1, "Fata", null },
                    { 65, 5, "Albastru", 1, "Romania", 50000, 5, 6, 1500, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 110, 9300, null, 1, "Fata", null },
                    { 66, 6, "Auriu", 1, "Germania", 214000, null, 3, 1995, 1, 1, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, 116, 2999, true, 1, "4x4 (automat)", null },
                    { 67, 6, "Argint", 1, "Republica Ceha", 227850, 4, 4, 2000, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 136, 7690, null, 1, "4x4 (automat)", null },
                    { 60, 4, "Gri", 1, "Franta", 211000, 5, 4, 2698, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 546, 180, 7780, null, 0, "4x4 (automat)", null },
                    { 68, 4, "Negru", 1, "Germania", 223000, 4, 4, 2000, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 143, 2600, null, 1, "Fata", null },
                    { 70, 3, "Negru", 1, null, 182574, 4, 5, 1956, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 131, 6999, null, 1, "Fata", null },
                    { 71, 6, "Gri", 1, "Belgia", 70495, 5, 6, 1461, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 10800, null, 1, "4x4-manual", "UU1HSDJ9G54145676" },
                    { 72, 3, "Maro", 1, null, 173000, null, null, null, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, null, 4750, null, 1, null, "UU14SDCL452249285" },
                    { 73, 2, "Negru", 1, "Franta", 237628, 5, 4, 2204, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 221, 140, 5000, true, 1, "Fata", null },
                    { 74, 8, "Alb", 1, null, 49900, null, null, null, 0, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, null, 83299, null, 1, null, "WDD2173641A016132" },
                    { 75, 1, "Albastru", 1, null, 191526, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 2990, null, 1, null, null },
                    { 76, 5, "Albastru", 1, "Germania", 227000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, null, 6100, true, 1, null, "WF0XXXTTFX6B70905" },
                    { 69, 3, "Alb", 1, "Romania", 29000, 4, null, 1600, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 175, 115, 10999, true, 1, "Fata", null },
                    { 39, 4, "Negru", 1, "Germania", 192000, null, 5, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 9150, null, 1, "Fata", null },
                    { 59, 4, "Alte culori", 1, null, 183100, null, null, 1956, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 131, 7500, null, 1, null, null },
                    { 57, 6, "Auriu", 1, "Germania", 141500, null, 5, 1500, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 7750, null, 1, "4x4-manual", null },
                    { 41, 4, "Gri", 1, "Germania", 144000, null, 5, 1560, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 90, 4990, true, 1, "Fata", "WF0SXXGCDS9J30704" },
                    { 42, 3, "Gri", 1, "Germania", 216900, 4, 4, 1896, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 116, 4999, null, 1, "Fata", null },
                    { 43, 6, "Verde", 1, "Romania", 283000, 5, 4, 2996, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 225, 6800, true, 1, "4x4 (automat)", "WVGZZZ7LZ6D039191" },
                    { 44, 4, "Negru", 1, "Germania", 200000, 5, 5, 1986, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 170, 7590, null, 1, "Fata", null },
                    { 45, 5, "Rosu", 1, "Germania", 189000, null, null, 1460, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 90, 4499, null, 1, "Fata", null },
                    { 46, 5, "Rosu", 1, "Germania", 198000, null, 4, 1600, null, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 97, 1599, null, 0, "Fata", null },
                    { 47, 6, "Alb", 1, "Germania", 171000, 5, 6, 2400, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 220, 22700, null, 1, "4x4 (automat)", null },
                    { 58, 3, "Alb", 1, "Germania", 90500, 4, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 190, 30998, null, 1, "Fata", "WAUZZZ4G3GN099223" },
                    { 48, 8, "Albastru", 1, null, 171000, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, null, 16700, null, 1, null, null },
                    { 50, 4, "Gri", 1, "Italia", 185000, null, 5, 2000, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 140, 6299, null, 1, "Fata", null },
                    { 51, 6, "Negru", 1, "Germania", 187000, null, 4, 1900, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, 131, 5890, null, 1, "4x4 (automat)", null },
                    { 52, 4, "Gri", 1, "Olanda", 216250, null, 5, 1560, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 800, 116, 5290, null, 1, null, null },
                    { 53, 4, "Negru", 1, "Germania", 206000, 5, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 11990, null, 1, "Fata", "WVWZZZ3CZGE099923" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 54, 2, "Alb", 1, "Germania", 186000, 4, 5, 1986, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 143, 8600, null, 1, "Fata", null },
                    { 55, 2, "Rosu", 1, null, 201203, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 412, null, 3600, null, 1, null, "WVWZZZ1KZ5W511087" },
                    { 56, 2, "Gri", 1, "Germania", 151000, null, 4, 1600, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 116, 3600, null, 1, "Fata", null },
                    { 49, 3, "Albastru", 1, null, 82000, null, null, null, 0, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, null, 6800, null, 1, null, null },
                    { 318, 4, "Gri", 1, "Romania", 145482, 5, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 184, 16300, true, 0, "4x4 (automat)", "TMBLK7NE4G0183966" },
                    { 158, 3, "Auriu", 1, "Germania", 220000, 4, 4, 1995, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 177, 7290, true, 1, "Spate", null },
                    { 160, 6, "Alb", 1, "Germania", 183000, 5, 5, 1998, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 551, 177, 18500, true, 1, "4x4 (automat)", "wauzzz8u3er014726" },
                    { 261, 5, "Alb", 1, "Romania", 315000, 5, null, 2463, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 115, 4990, null, 0, "Fata", "VF1FDCUH633025878" },
                    { 262, 3, "Maro", 1, null, 182000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 3990, true, 1, null, null },
                    { 263, 6, "Negru", 1, null, 243000, null, null, 2498, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, null, 4800, null, 0, null, null },
                    { 264, 6, "Argint", 1, null, 189000, 5, 4, 1300, 0, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 454, null, 3850, true, 1, null, null },
                    { 265, 3, "Alb", 1, "Romania", 188489, null, 6, 1968, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 14200, true, 0, "Fata", null },
                    { 266, 4, "Gri", 1, "Belgia", 214000, null, 4, 1560, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, null, 1950, null, 0, null, null },
                    { 267, 6, "Albastru", 1, "Germania", 110172, 5, 5, 1461, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 5850, null, 1, "Fata", null },
                    { 260, 3, "Argint", 1, "Franta", 260000, 5, null, 1898, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 131, 2750, true, 1, "Fata", null },
                    { 268, 6, "Negru", 1, null, 210853, null, null, 3000, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 245, 11900, null, 0, "4x4 (automat)", null },
                    { 270, 6, "Negru", 1, null, 190000, null, null, 1998, 1, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, null, 3650, null, 0, null, null },
                    { 271, 6, "Verde", 1, null, 75000, null, null, 1298, 0, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 448, null, 2900, null, 0, null, null },
                    { 272, 5, "Gri", 1, "Germania", 229000, 4, 4, 1900, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 116, 5099, null, 0, "Fata", null },
                    { 273, 3, "Gri", 1, "Germania", 175000, 5, 5, 2998, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 548, 313, 24900, null, 1, "4x4 (automat)", null },
                    { 274, 4, "Maro", 1, null, 86422, 4, null, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 190, 18900, null, 0, "Fata", "WVWZZZ3CZGP007951" },
                    { 275, 3, "Alb", 1, "Romania", 105000, null, 6, 2143, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 25900, true, 1, "4x4 (automat)", null },
                    { 276, 4, "Gri", 1, null, 290000, null, 4, 1560, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 110, 1900, null, 1, "Fata", null },
                    { 269, 5, "Alb", 1, "Romania", 132000, 4, 5, 1560, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 216, 75, 4850, true, 0, "Fata", "VF37A9HN0DN545527" },
                    { 277, 3, "Albastru", 1, "Germania", 189000, 4, 5, 3000, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 724, 240, 9900, true, 0, "Spate", "SAJAA0546ANR64766" },
                    { 259, 3, "Gri", 1, "Romania", 200000, null, null, 1900, 1, 1, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 131, 2999, true, 0, null, null },
                    { 257, 4, "Negru", 1, "Germania", 153000, 4, 5, 1560, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 109, 3800, true, 1, "Fata", "WF0SXXGCDS9P22335" },
                    { 241, 6, "Argint", 1, null, 210000, 5, null, 2000, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 296, null, 6490, null, 0, "4x4-manual", null },
                    { 242, 5, "Alte culori", 1, null, 300000, null, null, 1898, 1, 0, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 432, null, 1600, null, 0, null, null },
                    { 243, 3, "Albastru", 1, "Germania", 196000, null, 4, 1600, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 101, 2290, null, 0, "Fata", null },
                    { 244, 4, "Gri", 1, "Germania", 262000, null, 4, 1700, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 2290, null, 0, null, null },
                    { 245, 4, "Gri", 1, "Germania", 320000, 5, 4, 1900, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 4000, true, 1, "Fata", null },
                    { 246, 6, "Bej", 1, null, 1, 5, 6, 2157, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 181, 35142, null, 0, "4x4 (automat)", null },
                    { 247, 5, "Gri", 1, null, 209000, null, null, 1898, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, null, 3400, null, 0, null, null },
                    { 258, 3, "Gri", 1, null, 172000, 5, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, null, 2499, null, 1, null, null },
                    { 248, 6, "Gri", 1, null, 254000, 3, 4, 3200, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 297, 160, 8200, true, 1, "4x4-manual", "JMBMYV68W6J000473" },
                    { 250, 6, "Alb", 1, "Germania", 126000, 4, 6, 2993, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 258, 45700, true, 1, "4x4 (automat)", "WBAKV210900R23501" },
                    { 251, 3, "Gri", 1, "Germania", 44700, 5, 6, 2143, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 23900, true, 0, "Spate", "WDD0050041R188556" },
                    { 252, 3, "Albastru", 1, "Germania", 216000, 5, 4, 2000, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 140, 4799, null, 0, "Fata", null },
                    { 253, 3, "Negru", 1, null, 93638, 5, null, 1968, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 150, 19900, null, 0, "Fata", "TMBAH7NP7H7026822" },
                    { 254, 6, "Maro", 1, "Romania", 201600, null, 5, 4387, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 313, 18200, true, 1, "4x4 (automat)", null },
                    { 255, 7, "Albastru", 1, "Romania", 171000, null, null, 1798, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 160, 7690, true, 0, "Fata", null },
                    { 256, 0, "Negru", 1, "Germania", 206000, null, 5, 1998, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 184, 12199, true, 1, "Spate", null },
                    { 249, 6, "Gri", 1, null, 210000, 5, null, 2189, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, null, 7490, null, 0, null, null },
                    { 240, 3, "Alb", 1, "Olanda", 39000, null, null, null, 1, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, null, 34900, null, 0, null, null },
                    { 278, 2, "Gri", 1, null, 256000, null, null, 1898, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, null, 3650, null, 0, null, null },
                    { 280, 5, "Negru", 1, null, 202000, null, null, 1898, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, null, 1650, null, 0, null, null },
                    { 301, 3, "Alb", 1, "Romania", 148415, 5, 6, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 175, 115, 6950, true, 0, "Fata", "TMBAE6NH1G4011986" },
                    { 302, 2, "Negru", 1, "Belgia", 140000, 4, 5, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 90, 9900, true, 1, "Fata", "WVWZZZAUZEW283975" },
                    { 303, 3, "Negru", 1, null, 210000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 8750, null, 1, null, null },
                    { 304, 1, "Rosu", 1, "Romania", 77500, 5, 5, 1995, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 143, 6500, true, 1, "Spate", null },
                    { 305, 2, "Verde", 1, null, 223000, null, null, 1798, 0, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 118, null, 1500, null, 0, null, null },
                    { 306, 4, "Maro", 1, "Belgia", 199873, 4, 5, 1986, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 120, 8800, true, 0, "Fata", "WAUZZZ8K5EA122651" },
                    { 307, 1, "Maro", 1, null, 171000, 4, 5, 1200, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 74, 4250, true, 1, "Fata", "VSSZZZ6JZBR173220" },
                    { 300, 6, "Maro", 1, null, 188000, 5, 5, 2198, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226, null, 10500, null, 0, "4x4 (automat)", null },
                    { 308, 3, "Negru", 1, "Germania", 208000, null, 5, 2000, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 170, 10750, null, 1, "Fata", null },
                    { 310, 4, "Argint", 1, null, 125612, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, null, 5627, null, 0, null, null },
                    { 311, 6, "Gri", 1, "Italia", 175000, 5, 6, 2000, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 190, 20750, null, 1, "4x4 (automat)", "WAUZZZ8R5FA028512" },
                    { 312, 4, "Gri", 1, null, 240000, null, null, 1898, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, null, 2550, null, 0, null, null },
                    { 313, 4, "Albastru", 1, "Romania", 235000, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, null, 1500, null, 1, null, null },
                    { 314, 3, "Alb", 1, "Romania", 116502, 5, 6, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 175, 115, 7950, true, 0, "Fata", "TMBAE6NH9G4011993" },
                    { 315, 6, "Gri", 1, "Germania", 155000, 5, 6, 2986, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 258, 31850, null, 1, "4x4 (automat)", "WBAKS410100H61337" },
                    { 316, 8, "Maro", 1, "Germania", 68000, 4, 6, 2993, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 378, 313, 29700, true, 0, "Spate", "WBA6A61000DY88733" },
                    { 309, 0, "Maro", 1, null, 110000, null, null, null, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 685, null, 1765, null, 0, null, null },
                    { 279, 3, "Argint", 1, "Germania", 202000, 4, 5, 2000, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 143, 10200, true, 1, null, null },
                    { 299, 6, "Negru", 1, "Germania", 228700, 4, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, null, 7790, null, 0, null, null },
                    { 297, 3, "Negru", 1, null, 89000, null, null, 1598, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, null, 22000, null, 0, null, null },
                    { 281, 6, "Gri", 1, "Belgia", 207000, null, 5, 2986, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 240, 14700, null, 1, "4x4 (automat)", null },
                    { 282, 5, "Gri", 1, null, 190000, null, null, 1922, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, null, 2900, null, 0, null, null },
                    { 283, 6, "Negru", 1, null, 96000, null, null, 1498, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, null, 4999, null, 0, null, null },
                    { 284, 6, "Verde", 1, "Germania", 216000, null, 4, 2998, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 285, 11950, true, 0, "4x4 (automat)", null },
                    { 285, 6, "Gri", 1, "Romania", 77500, 5, 5, 2993, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, 292, 32000, true, 0, "4x4 (automat)", "SALWA2KFXEA338035" },
                    { 286, 5, "Alb", 1, "Germania", 280000, null, 4, 2299, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, 125, 5700, null, 1, "Fata", null },
                    { 287, 3, "Albastru", 1, "Germania", 200000, 4, 5, 1798, 0, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 180, 13390, true, 1, "Fata", null },
                    { 298, 3, "Albastru", 1, "Italia", 239000, null, null, 1968, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 170, 8400, null, 0, "Fata", null },
                    { 288, 5, "Gri", 1, null, 182000, null, null, 1798, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 632, null, 2999, null, 0, null, null },
                    { 290, 5, "Gri", 1, null, 6000, 5, 6, 1461, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 109, 10350, null, 0, "Fata", null },
                    { 291, 6, "Alte culori", 1, "Belgia", 185000, 5, null, 1995, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, 115, 4590, null, 0, "4x4 (automat)", null },
                    { 292, 5, "Argint", 1, "Germania", 185000, 5, 5, 1686, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 125, 4550, null, 0, "Fata", null },
                    { 293, 3, "Negru", 1, "Germania", 200000, null, null, 2967, 1, 1, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 225, 4200, null, 0, "4x4 (automat)", null },
                    { 294, 3, "Gri", 1, "Germania", 214000, 4, 5, 2143, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 170, 16990, true, 1, "Spate", null },
                    { 295, 2, "Albastru", 1, "Germania", 234000, 3, 4, 1968, 1, 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 140, 3600, true, 0, "Fata", "wauzzz9p94a008453" },
                    { 296, 4, "Negru", 1, "Germania", 205578, 5, 4, 1968, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 4500, null, 0, "Fata", "WVWZZZ3CZ6E123277" },
                    { 289, 1, "Gri", 1, "Germania", 218000, 4, 4, 1600, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 110, 3000, true, 1, null, null },
                    { 159, 6, "Albastru", 1, "Romania", 222000, 4, null, 3000, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 338, 171, 13500, true, 1, "4x4-manual", "AHTFZ29G609032445" },
                    { 239, 5, "Maro", 1, "Germania", 188000, null, 5, 2000, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 431, 177, 18350, true, 1, "Fata", null },
                    { 237, 3, "Argint", 1, null, 146000, 5, 4, 1798, 0, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 139, 122, 2990, null, 1, "Fata", null },
                    { 181, 6, "Negru", 1, null, 127000, 5, null, 1997, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, null, 11400, null, 1, null, null },
                    { 182, 1, "Argint", 1, "Germania", 158400, null, 4, 1390, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 75, 3250, null, 1, "Fata", null },
                    { 183, 4, "Negru", 1, null, 180000, 4, 5, 1968, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 177, 13000, true, 1, "Fata", null },
                    { 184, 6, "Argint", 1, "Germania", 187500, 5, 5, 1995, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 177, 10500, null, 1, "4x4 (automat)", null },
                    { 185, 4, "Maro", 1, "Olanda", 184775, 4, 5, 1600, 0, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 160, 6899, null, 0, "Fata", null },
                    { 186, 6, "Gri", 1, "Romania", 210000, null, 4, 3200, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 297, 170, 10650, true, 0, "4x4-manual", null },
                    { 187, 6, "Gri", 1, null, 185000, null, null, null, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, null, 22900, null, 1, null, null },
                    { 180, 0, "Albastru", 1, null, 170000, null, null, 1596, 2, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, 105, 5700, true, 1, null, null },
                    { 188, 3, "Albastru", 1, "Romania", 152000, null, 5, 3000, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 306, 17500, true, 1, "4x4 (automat)", "WBAKC01080C898518" },
                    { 190, 0, "Gri", 1, "Germania", 266000, 4, 4, 1422, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 533, 90, 2990, null, 0, "Fata", null },
                    { 191, 1, "Gri", 1, "Italia", 224688, null, 4, 1968, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 103, 3480, null, 1, "Fata", "WVWZZZ1KZ4B036924" },
                    { 192, 5, "Alb", 1, "Romania", 17000, 5, 6, 1600, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 126, 8500, true, 1, "Fata", null },
                    { 193, 3, "Albastru", 1, null, 188837, null, 4, 2148, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 200, 4500, null, 1, "Spate", null },
                    { 194, 3, "Argint", 1, "Italia", 272000, 4, 3, 1896, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 131, 2999, null, 1, "Fata", null },
                    { 195, 4, "Alb", 1, "Romania", 17000, 5, 6, 1600, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 126, 8500, true, 1, "Fata", null },
                    { 196, 1, "Auriu", 1, "Germania", 207000, 4, 4, 2034, 0, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 264, 193, 4950, null, 0, "Fata", "WDD2452341J155349" },
                    { 189, 6, "Negru", 1, "Germania", 159000, 4, 5, 1498, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 7790, null, 1, "4x4-manual", null },
                    { 197, 3, "Gri", 1, "Germania", 197000, 4, 4, 1984, 0, 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 130, 2980, null, 0, "Fata", null },
                    { 179, 2, "Negru", 1, "Germania", 224000, null, 4, 1968, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 170, 5600, true, 1, "Fata", null },
                    { 177, 4, "Argint", 1, "Germania", 236000, null, 4, 2000, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 3550, null, 1, "Fata", null },
                    { 161, 5, "Alb", 1, null, 242644, null, 5, 1968, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 432, 140, 15000, true, 1, null, "wv2zzz7hzch067138" },
                    { 162, 3, "Negru", 1, null, 176200, null, null, null, 1, null, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, null, 15800, null, 1, null, null },
                    { 163, 3, "Gri", 1, null, 158000, null, 6, 1993, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 190, 22500, null, 1, "4x4 (automat)", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 164, 6, "Gri", 1, "Italia", 186000, 5, null, 1900, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, 130, 5900, null, 0, "4x4 (automat)", null },
                    { 165, 4, "Argint", 1, null, 241000, 5, 4, 1995, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 163, 5800, true, 1, "Spate", null },
                    { 166, 6, "Negru", 1, "Romania", 136000, null, 5, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 9999, null, 0, "4x4 (automat)", null },
                    { 167, 1, "Negru", 1, null, 180000, null, null, null, 0, null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, null, 800, null, 1, null, null },
                    { 178, 1, "Negru", 1, null, 201000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, null, 20450, null, 1, null, null },
                    { 168, 6, "Albastru", 1, "Spania", 210000, 3, null, 2500, 1, 0, new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 339, 103, 5999, true, 1, "4x4-manual", null },
                    { 170, 6, "Gri", 1, "Olanda", 185000, 4, 5, 2000, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 184, 9690, null, 0, "4x4 (automat)", null },
                    { 171, 4, "Negru", 1, "Germania", 50000, 4, 6, 1499, 0, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 109, 11990, null, 1, "Spate", "wba2r110105d59735" },
                    { 172, 3, "Rosu", 1, "Germania", 118500, 4, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 9450, null, 1, "Fata", "TMBAG9NE7E0113976" },
                    { 173, 6, "Negru", 1, null, 95000, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, null, 23900, true, 1, null, null },
                    { 174, 3, "Gri", 1, "Belgia", 280000, null, 4, 1998, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 122, 4500, true, 1, "Spate", null },
                    { 175, 3, "Gri", 1, "Italia", 217000, null, null, 1996, 1, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 136, 2100, null, 1, "Spate", null },
                    { 176, 4, "Negru", 1, null, 230000, null, null, 1890, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 3950, null, 0, null, null },
                    { 169, 3, "Gri", 1, "Germania", 160000, 4, 6, 2993, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 548, 320, 39499, null, 0, "4x4 (automat)", null },
                    { 238, 1, "Negru", 1, "Germania", 195754, null, 4, 1600, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 90, 2850, null, 0, "Fata", null },
                    { 198, 6, "Auriu", 1, null, 190000, 4, 6, 2987, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 258, 24500, true, 1, null, null },
                    { 200, 1, "Gri", 1, "Romania", 95600, 4, 5, 1200, 0, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 85, 4500, true, 1, "Fata", "TMBEM25J7B3027267" },
                    { 221, 3, "Alb", 1, "Germania", 171300, null, 5, 2000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 150, 8750, null, 1, "Fata", null },
                    { 222, 2, "Alb", 1, "Romania", 68200, 5, 5, 1364, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 321, 90, 7900, true, 0, "Fata", "SB1KN3JE10E046630" },
                    { 223, 4, "Alte culori", 1, "Romania", 125994, 4, 5, 1968, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 170, 10500, true, 0, "Fata", "TMBJF93T9B9037155" },
                    { 224, 4, "Negru", 1, "Romania", 330000, null, null, 1968, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 3000, true, 1, "Fata", null },
                    { 225, 2, "Rosu", 1, "Romania", 56000, 5, null, 1589, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 12450, true, 1, null, null },
                    { 226, 1, "Alb", 1, "Romania", 180000, null, 4, 1400, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, null, 2450, true, 0, "Fata", null },
                    { 227, 3, "Gri", 1, null, 190000, 4, 5, 1500, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 110, 5200, null, 1, "Fata", null },
                    { 220, 3, "Gri", 1, "Romania", 186000, 3, 5, 2967, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 245, 12900, true, 0, "4x4 (automat)", "WAUZZZ8T38A041970" },
                    { 228, 3, "Gri", 1, "Germania", 152000, null, 5, 1798, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 167, 8990, true, 1, "Fata", null },
                    { 230, 4, "Argint", 1, "Belgia", 167550, 5, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 116, 6650, null, 1, null, null },
                    { 231, 3, "Negru", 1, "Olanda", 179000, 4, 5, 2000, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 136, 8750, true, 1, "Fata", "WAUZZZ8K4AN045273" },
                    { 232, 8, "Albastru", 1, "Romania", 31000, 2, 6, 1991, 0, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 184, 26880, true, 0, "Spate", "WDD2053421F333088" },
                    { 233, 2, "Gri", 1, null, 209000, null, null, null, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, null, 5990, true, 1, null, null },
                    { 234, 6, "Albastru", 1, null, 112882, 5, 6, 2993, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 258, 29497, null, 0, "4x4 (automat)", "WBAKS410800H54336" },
                    { 235, 6, "Negru", 1, null, 195000, 5, 4, 2700, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, 190, 17500, true, 1, "4x4 (automat)", null },
                    { 236, 2, "Gri", 1, "Belgia", 150000, 4, null, 1700, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 110, 3450, null, 1, null, null },
                    { 229, 4, "Negru", 1, "Germania", 265000, 5, 5, 1998, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 7750, null, 1, "Fata", null },
                    { 199, 6, "Argint", 1, "Romania", 170000, 5, 4, 1991, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 707, 140, 4250, true, 1, "4x4-manual", null },
                    { 219, 3, "Albastru", 1, "Germania", 191303, 4, 6, 1998, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 218, 19900, true, 1, "Spate", "WBA5C71060D054820" },
                    { 217, 4, "Gri", 1, "Romania", 237000, null, 4, 1900, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 101, 3200, true, 1, "Fata", null },
                    { 201, 5, "Negru", 1, null, 228000, 5, 4, 1910, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 120, 2899, true, 1, "Fata", "W0L0AHM7552234455" },
                    { 202, 2, "Gri", 1, "Germania", 115000, 5, 5, 1582, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 575, 115, 6790, null, 0, "Fata", null },
                    { 203, 3, "Alb", 1, null, 140000, null, null, null, 1, null, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 378, null, 41000, null, 1, null, null },
                    { 204, 3, "Gri", 1, "Italia", 180000, 4, 4, 1988, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 143, 2450, null, 1, "Fata", "JMZGY19R671466525" },
                    { 205, 6, "Rosu", 1, "Germania", 223000, 5, 4, 1900, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 858, 120, 3999, null, 0, "4x4 (automat)", null },
                    { 206, 3, "Albastru", 1, "Belgia", 90000, 4, 5, 1149, 0, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 4000, null, 0, "Fata", "UU14SDAG349846347" },
                    { 207, 6, "Negru", 1, "Statele Unite ale Americii", 5800, 4, 6, 1999, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 717, 250, 45500, true, 0, "4x4 (automat)", null },
                    { 218, 3, "Negru", 1, "Germania", 209000, 5, 4, 2000, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 6199, null, 0, "Spate", null },
                    { 208, 4, "Negru", 1, "Olanda", 165000, null, 5, 1242, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 75, 4599, null, 0, "Fata", null },
                    { 210, 3, "Gri", 1, "Franta", 220000, null, 5, 1995, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 218, 18290, true, 1, "4x4 (automat)", null },
                    { 211, 6, "Negru", 1, "Germania", 138246, null, 5, 1968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 177, 17990, null, 1, "4x4 (automat)", null },
                    { 212, 3, "Gri", 1, "Romania", 34939, 4, 6, 1968, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 13900, true, 0, "Fata", "WVWZZZ3CZFE418075" },
                    { 213, 3, "Gri", 1, "Germania", 211207, 3, 4, 2698, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 190, 9690, true, 0, "Spate", "WAUZZZ8T48A022358" },
                    { 214, 4, "Gri", 1, "Germania", 290087, 5, null, 1968, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 140, 4290, true, 0, null, "wauzzz8e28a110293" },
                    { 215, 6, "Gri", 0, null, 1, 5, 6, 1364, 0, 0, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, 120, 15219, null, 0, "Fata", null },
                    { 216, 6, "Negru", 1, "Olanda", 191000, 4, 5, 1600, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 117, 8399, null, 0, "Fata", null },
                    { 209, 3, "Albastru", 1, null, 209000, 5, null, 2499, 0, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 218, 5900, true, 1, "Fata", null },
                    { 638, 3, "Maro", 1, "Germania", 177000, 5, 5, 1995, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 181, 11800, true, 0, "Spate", "WBAFW11020C659562" },
                    { 639, 2, "Alb", 1, "Romania", 84832, 5, 6, 1396, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 90, 7800, true, 0, "Fata", null },
                    { 640, 2, "Negru", 1, "Romania", 22100, 5, 6, 1598, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 200, 18500, true, 1, "Fata", null },
                    { 1062, 1, "Gri", 1, "Romania", 76797, 5, 6, 998, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 100, 6950, true, 1, "Fata", null },
                    { 1063, 3, "Negru", 1, "Polonia", 235000, 4, 4, 2000, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 163, 5150, null, 0, "Spate", null },
                    { 1064, 6, "Auriu", 1, "Italia", 143500, 5, 6, 1987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 177, 19760, true, 1, "4x4 (automat)", "WAUZZZ8R9FA031817" },
                    { 1065, 2, "Albastru", 1, "Germania", 183232, 5, 4, 1984, 0, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 150, 3650, true, 1, "Fata", "wvwzzz1kz6p000041" },
                    { 1066, 3, "Gri", 1, "Romania", 200000, null, 4, 2000, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 170, 2150, true, 0, null, null },
                    { 1067, 3, "Negru", 1, "Germania", 235574, 4, 4, 1995, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 177, 6450, null, 1, "Spate", "WBAVG91010VG47059" },
                    { 1068, 4, "Gri", 1, "Franta", 156315, null, 6, 1491, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 110, 7700, null, 1, "Fata", "VF1KZ890H53628000" },
                    { 1061, 5, "Argint", 1, "Germania", 195000, 5, 4, 1890, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 105, 5980, null, 0, "Fata", null },
                    { 1069, 4, "Negru", 1, "Germania", 201000, null, null, 1998, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 90, 1850, null, 0, "Fata", null },
                    { 1071, 6, "Negru", 1, null, 267000, 5, 5, 1995, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 143, 8490, null, 1, "4x4 (automat)", null },
                    { 1072, 6, "Argint", 1, "Germania", 204318, 5, 6, 2987, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 258, 22000, true, 0, "4x4 (automat)", "WDC1660241A126011" },
                    { 1073, 2, "Negru", 1, "Olanda", 199000, 4, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 115, 8500, null, 1, "Fata", null },
                    { 1074, 3, "Gri", 1, "Belgia", 164000, 5, 5, 2993, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 258, 19900, null, 1, "Spate", "WBAYC21020D283642" },
                    { 1075, 2, "Gri", 1, null, 18224, null, null, 1332, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 477, 163, 28529, null, 0, "Fata", "WDD1770871J019178" },
                    { 1076, 6, "Albastru", 1, "Spania", 176000, 4, 4, 2188, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 155, 5800, null, 0, "4x4 (automat)", null },
                    { 1077, 2, "Alb", 1, null, 21800, null, null, 1461, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 477, 109, 19328, null, 0, "Fata", "WDD1760121J690887" },
                    { 1070, 4, "Gri", 1, "Belgia", 174990, 5, 6, 1998, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 150, 13950, null, 1, "Spate", null },
                    { 1078, 3, "Negru", 1, "Germania", 220000, 5, null, 2698, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 190, 8000, true, 1, "Fata", null },
                    { 1060, 7, "Albastru", 1, "Germania", 215000, null, 4, 1995, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 135, 4450, null, 1, "Fata", null },
                    { 1058, 6, "Negru", 1, null, 35910, 4, 5, 2477, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 288, 136, 17500, true, 0, "4x4-manual", "MMCJNKB40FD003847" },
                    { 1042, 5, "Gri", 1, null, 200000, null, 6, null, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 431, 140, 11690, null, 1, "Fata", null },
                    { 1043, 5, "Albastru", 1, "Polonia", 245000, 5, 3, 1900, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 431, 131, 1950, null, 0, "Fata", null },
                    { 1044, 6, "Rosu", 1, "Germania", 120000, 5, 6, 2993, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 386, 258, 27996, null, 0, "4x4 (automat)", null },
                    { 1045, 6, "Argint", 1, "Germania", 189000, null, 4, 1995, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, 116, 4390, null, 1, "4x4-manual", null },
                    { 1046, 4, "Auriu", 1, "Germania", 221555, null, 4, 1898, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 150, 3490, null, 0, "Fata", null },
                    { 1047, 4, "Argint", 1, "Germania", 495000, null, 5, 2967, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 546, 241, 8000, true, 1, "4x4 (automat)", "WAUZZZ4F49N032107" },
                    { 1048, 3, "Alb", 1, "Romania", 47800, 4, 6, 900, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 90, 6700, true, 1, "Fata", null },
                    { 1059, 0, "Alte culori", 1, "Germania", 190000, 2, null, 599, 0, 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 838, 61, 999, true, 1, "Spate", null },
                    { 1049, 3, "Negru", 1, "Germania", 168000, 4, null, null, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, null, 25000, true, 1, null, null },
                    { 1051, 3, "Negru", 1, "Germania", 195000, null, 5, null, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 143, 9900, true, 1, "Fata", null },
                    { 1052, 4, "Gri", 1, null, 95971, 5, 6, 1968, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 15337, null, 0, "Fata", "WVWZZZ3CZFE417812" },
                    { 1053, 4, "Negru", 1, "Italia", 166000, 4, 4, 1364, 2, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 90, 4800, null, 0, "Fata", null },
                    { 1054, 3, "Negru", 1, "Germania", 195000, 4, 5, 1998, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 177, 15950, true, 1, "Fata", null },
                    { 1055, 4, "Argint", 1, "Germania", 265000, 5, 4, 1900, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 3650, null, 0, "Fata", null },
                    { 1056, 4, "Argint", 1, "Olanda", 228000, null, 5, 1598, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 5450, null, 1, "Fata", "WVWZZZ1KZAM653703" },
                    { 1057, 4, "Negru", 1, null, 171245, 5, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 11589, null, 0, "Fata", "WVWZZZ3CZFP410824" },
                    { 1050, 6, "Albastru", 1, "Belgia", 235000, null, null, 1986, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 163, 11900, true, 1, "4x4 (automat)", null },
                    { 1041, 6, "Alte culori", 1, null, 190000, null, null, 2000, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, 140, 4000, null, 1, "4x4-manual", null },
                    { 1079, 5, "Alb", 1, "Romania", 2, 4, 6, 1560, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 274, 95, 15400, null, 0, "Fata", null },
                    { 1081, 3, "Negru", 1, "Germania", 220000, 4, 4, 1995, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 143, 4500, true, 0, "Spate", null },
                    { 1102, 8, "Negru", 1, "Germania", 20000, 4, 4, 1995, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 150, 2999, null, 1, null, null },
                    { 1103, 6, "Bej", 1, "Romania", 1500, 5, 6, 999, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 636, 125, 15500, true, 0, "Fata", null },
                    { 1104, 4, "Gri", 1, "Belgia", 154000, 5, 6, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 130, 6990, null, 1, "Fata", "W0LPE8E67E8059744" },
                    { 1105, 3, "Albastru", 1, "Romania", 6172, 4, 6, 1968, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, 110, 15990, true, 0, "Fata", "WVWZZZ16ZJM000730" },
                    { 1106, 2, "Gri", 1, "Belgia", 206500, 5, 5, 2000, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 136, 5650, null, 0, "Spate", null },
                    { 1107, 6, "Albastru", 1, "Franta", 73000, null, 5, 1500, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 8500, null, 0, "Fata", "UU1HSDADF52134571" },
                    { 1108, 4, "Argint", 1, "Franta", 202028, 4, 4, 2140, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 322, 150, 3650, null, 0, "Fata", null },
                    { 1101, 6, "Albastru", 1, null, 1, null, null, null, 1, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 339, null, 51352, null, 0, null, null },
                    { 1109, 5, "Rosu", 1, "Germania", 455000, 4, 3, 2461, 1, 0, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 402, 102, 3990, true, 0, "Fata", null },
                    { 1111, 3, "Alb", 1, null, 155496, 5, 5, 2993, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 378, 313, 31990, null, 0, "4x4 (automat)", "WBA6A810X0D865276" },
                    { 1112, 3, "Alb", 1, null, 152800, null, 6, 2200, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 194, 31900, null, 1, null, null },
                    { 1113, 6, "Alb", 1, "Romania", 103000, null, 6, 2000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 136, 15000, true, 1, "4x4 (automat)", "WBAVP71000VW29606" },
                    { 1114, 2, "Rosu", 1, "Romania", 34843, 5, 6, 999, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 125, 11490, true, 0, "Fata", "WF05XXGCC5FU38574" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 1115, 2, "Negru", 1, "Romania", 59130, 5, 6, 1598, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 110, 11900, true, 0, "Fata", "WAUZZZ8V3FA062056" },
                    { 1116, 3, "Negru", 1, "Germania", 29200, 4, 6, 1595, 0, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 156, 24750, true, 1, "Spate", "WDD2050401R206676" },
                    { 1117, 3, "Albastru", 1, "Romania", 156000, 5, null, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 3910, true, 0, "Fata", null },
                    { 1110, 3, "Albastru", 1, "Spania", 300000, 5, 3, 1951, 1, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 136, 2500, null, 0, "Spate", null },
                    { 1080, 3, "Negru", 1, "Germania", 230273, 4, 5, 1986, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 170, 10490, null, 0, "Fata", "WAUZZZ8KXBN029225" },
                    { 1100, 3, "Gri", 1, "Romania", 95166, 5, 5, 1968, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 150, 12700, true, 0, "Fata", "TMBAJ7NE9F0068904" },
                    { 1098, 5, "Alb", 1, "Germania", 362000, 5, 4, 2200, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 515, 150, 7200, true, 0, "Spate", null },
                    { 1082, 4, "Verde", 1, "Germania", 249000, null, null, 1997, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 107, 1690, null, 0, "Fata", "VF33HRHSB83376472" },
                    { 1083, 8, "Alb", 1, "Germania", 76120, null, 5, 1400, 0, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 11980, true, 1, "Fata", null },
                    { 1084, 6, "Negru", 1, "Germania", 160500, null, 5, 1500, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 7599, null, 1, "4x4 (automat)", null },
                    { 1085, 1, "Alte culori", 1, "Belgia", 120000, 5, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 94, 5690, null, 1, "Fata", null },
                    { 1086, 3, "Negru", 1, "Germania", 238558, 4, 5, 1984, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 11650, null, 0, "Spate", null },
                    { 1087, 1, "Argint", 1, "Germania", 193000, null, 5, 1600, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 105, 6750, true, 1, "Fata", null },
                    { 1088, 4, "Argint", 1, null, 208000, null, null, 1968, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 5890, null, 1, "4x4 (automat)", null },
                    { 1099, 6, "Negru", 1, null, 178000, 4, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 296, null, 6800, null, 1, null, null },
                    { 1089, 2, "Albastru", 1, "Romania", 27845, 5, 5, 898, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 90, 9490, true, 0, "Fata", null },
                    { 1091, 6, "Negru", 1, "Romania", 148000, 4, 5, 1596, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 131, 12600, true, 0, "4x4 (automat)", "SJNFDNJ11U1612399" },
                    { 1092, 6, "Negru", 1, "Germania", 56270, 5, 5, 1997, 0, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226, 150, 11756, null, 0, "4x4 (automat)", null },
                    { 1093, 4, "Albastru", 1, "Germania", 179000, 4, 5, 2000, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 140, 8999, null, 1, "Fata", null },
                    { 1094, 3, "Gri", 1, "Germania", 191000, null, 5, 1995, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 177, 8900, true, 1, "Spate", null },
                    { 1095, 1, "Gri", 1, null, 187000, null, null, 1398, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, null, 2800, null, 0, null, null },
                    { 1096, 4, "Gri", 1, "Germania", 170877, 5, 5, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 183, 14990, null, 0, "Fata", "TMBJK7NE7F0049524" },
                    { 1097, 4, "Negru", 1, "Germania", 180000, null, 6, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 14400, true, 1, "4x4 (automat)", null },
                    { 1090, 3, "Negru", 1, null, 106360, null, 4, 1995, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 143, 6400, true, 1, "Spate", "WBAVF51070A091081" },
                    { 1118, 2, "Alb", 1, "Romania", 112210, 5, 5, 1560, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 95, 6800, true, 0, "Fata", null },
                    { 1040, 6, "Albastru", 1, "Romania", 87000, 5, null, 1995, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 186, 14500, true, 1, null, "WBAVP91010VR40912" },
                    { 1038, 4, "Gri", 1, "Germania", 185000, null, 3, 1900, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 131, 4750, true, 1, "4x4-manual", null },
                    { 982, 5, "Gri", 1, null, 245123, 5, 4, 1989, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 120, 2750, null, 1, "Fata", null },
                    { 983, 4, "Gri", 1, "Germania", 248000, 5, 5, 1689, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 110, 5290, true, 1, "Fata", null },
                    { 984, 4, "Gri", 1, null, 251000, 5, 5, 1986, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 170, 5500, null, 1, "Fata", "WVWZZZ3CZ9E098128" },
                    { 985, 4, "Gri", 1, null, 220000, 5, null, 1600, 0, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 1680, true, 0, "Fata", null },
                    { 986, 3, "Negru", 1, "Romania", 175000, null, null, null, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 381, 27950, true, 1, "4x4 (automat)", null },
                    { 987, 3, "Maro", 1, "Germania", 165000, null, null, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 190, 24490, null, 1, "4x4 (automat)", null },
                    { 988, 6, "Alb", 1, "Germania", 220000, 4, 5, 1968, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 170, 12599, null, 1, "4x4 (automat)", null },
                    { 981, 6, "Negru", 1, "Germania", 179000, null, 5, 2984, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 306, 20000, true, 1, "4x4 (automat)", null },
                    { 989, 6, "Alb", 1, "Romania", 148500, 4, 4, 1968, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 9300, true, 1, "4x4 (automat)", "WVGZZZ5NZ8W024310" },
                    { 991, 4, "Gri", 1, "Belgia", 187000, 5, 5, 1560, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 115, 7600, true, 1, "Fata", "VF38E9HL0CL036030" },
                    { 992, 3, "Negru", 1, "Germania", 181000, 4, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 190, 19999, true, 1, "Fata", "WAUZZZ4G4FN078251" },
                    { 993, 3, "Albastru", 1, null, 282700, 5, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 4250, null, 1, null, null },
                    { 994, 5, "Gri", 1, null, 250000, null, null, null, 1, null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 648, null, 3990, true, 1, null, null },
                    { 995, 2, "Gri", 1, "Germania", 238000, 5, 4, 1900, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 3350, null, 0, "Fata", null },
                    { 996, 3, "Negru", 1, null, 232000, null, 5, 1968, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 143, 8999, null, 1, "Fata", null },
                    { 997, 4, "Negru", 1, "Germania", 225000, 5, 5, 1968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 143, 10900, true, 1, "Fata", null },
                    { 990, 6, "Negru", 1, "Germania", 143000, null, 6, 2200, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 204, 27850, true, 1, "4x4 (automat)", null },
                    { 998, 3, "Rosu", 1, null, 170000, null, null, null, 0, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, null, 11500, null, 1, null, null },
                    { 980, 1, "Alte culori", 1, null, 135600, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 647, null, 2100, null, 1, null, null },
                    { 978, 0, "Rosu", 1, "Germania", 15, 2, 4, 1300, 0, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 650, null, 550, null, 1, "Fata", null },
                    { 962, 6, "Maro", 1, "Romania", 60000, 5, 5, 2400, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 163, 19500, true, 0, "4x4 (automat)", "YV1DZ8756E2528089" },
                    { 963, 4, "Negru", 1, "Austria", 199000, 5, null, 1896, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 5399, null, 1, "4x4 (automat)", null },
                    { 964, 3, "Albastru", 1, null, 275000, null, null, 2998, 1, 1, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 2550, null, 0, null, null },
                    { 965, 6, "Negru", 1, "Germania", 216000, 4, 5, 1995, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 177, 10490, null, 1, "4x4 (automat)", null },
                    { 966, 3, "Gri", 1, null, 247000, null, null, 1898, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 2799, null, 0, null, null },
                    { 967, 3, "Negru", 1, null, 187000, 4, 5, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 14999, true, 1, "Spate", null },
                    { 968, 0, "Albastru", 1, "Germania", 91800, 5, 5, 1500, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 70, 4600, null, 1, "Fata", null },
                    { 979, 1, "Negru", 1, null, 203000, null, null, 1598, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, null, 3600, null, 0, null, null },
                    { 969, 3, "Gri", 1, null, 300000, null, null, 4198, 0, 1, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 549, null, 3950, null, 0, null, null },
                    { 971, 6, "Negru", 1, "Germania", 107000, 5, 5, 1686, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, 131, 11750, null, 1, "4x4 (automat)", "W0LJD7ELXEB554385" },
                    { 972, 4, "Negru", 1, "Germania", 187500, null, 6, 1986, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 14250, null, 1, "Fata", null },
                    { 973, 6, "Gri", 1, "Romania", 99000, null, null, null, 1, null, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 279, null, 9999, true, 1, null, "JMBXJGA6WFZ404325" },
                    { 974, 3, "Negru", 1, "Germania", 212000, null, 4, 2000, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 4999, true, 1, "Spate", null },
                    { 975, 3, "Negru", 1, "Belgia", 164000, 4, 6, 1995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 190, 17480, null, 1, "Spate", null },
                    { 976, 4, "Albastru", 1, null, 307000, null, null, null, 1, null, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, null, 4500, null, 1, null, null },
                    { 977, 2, "Argint", 1, "Franta", 143300, null, 5, 1461, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 90, 5800, true, 0, "Fata", "VF1KZ1A0748343546" },
                    { 970, 6, "Negru", 1, "Germania", 221369, null, 4, 2990, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 245, 18900, true, 1, "4x4 (automat)", null },
                    { 1039, 4, "Albastru", 1, "Olanda", 168790, 5, 6, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 7999, null, 1, "Fata", null },
                    { 999, 6, "Gri", 1, null, 220000, null, null, null, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, null, 11500, null, 1, null, null },
                    { 1001, 6, "Alb", 1, null, 86900, null, null, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 8650, true, 1, "4x4 (automat)", null },
                    { 1022, 3, "Alte culori", 1, "Germania", 125000, null, 6, 2967, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 272, 27399, null, 1, "4x4 (automat)", "WAUZZZ4G1FN085643" },
                    { 1023, 0, "Negru", 1, "Germania", 160000, null, null, 1600, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 105, 8700, true, 1, "Fata", null },
                    { 1024, 1, "Albastru", 1, "Olanda", 184000, 5, 5, 1600, 1, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 116, 9450, null, 1, "Fata", null },
                    { 1025, 3, "Negru", 1, "Germania", 129000, 4, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 150, 17590, null, 1, "Fata", null },
                    { 1026, 3, "Albastru", 1, "Olanda", 187000, 5, 4, 1995, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 5700, null, 0, "Spate", null },
                    { 1027, 5, "Gri", 1, "Germania", 214203, null, 5, null, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, null, 6999, null, 0, "Fata", "WV2ZZZ2KZCX025422" },
                    { 1028, 4, "Negru", 1, "Germania", 191000, 5, 6, 1967, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 150, 10550, null, 1, "Fata", null },
                    { 1021, 2, "Albastru", 1, "Germania", 225000, 5, 4, 1995, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 122, 3490, null, 0, "Spate", null },
                    { 1029, 1, "Negru", 1, null, 240000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 4700, null, 1, null, null },
                    { 1031, 3, "Argint", 1, "Romania", 1100000, 4, null, 1499, 2, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 292, 110, 6500, true, 1, "Fata", null },
                    { 1032, 5, "Gri", 1, "Elvetia", 166400, null, 4, 2500, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 404, null, 7999, null, 0, null, "WV1ZZZ2EZ76010967" },
                    { 1033, 3, "Gri", 1, null, 234100, 4, 5, 2143, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 204, 10000, true, 1, "Spate", null },
                    { 1034, 3, "Albastru", 1, "Germania", 270000, 4, 3, 1896, 1, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 131, 2600, null, 1, "Fata", "WAUZZZ8EZ1A046809" },
                    { 1035, 6, "Negru", 1, "Germania", 185000, null, 5, 2143, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 737, 163, 10500, true, 1, "4x4-manual", null },
                    { 1036, 1, "Negru", 1, "Germania", 9800, null, 6, 1998, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 190, 33850, null, 1, "4x4 (automat)", null },
                    { 1037, 4, "Alb", 1, "Austria", 14660, 4, 6, 1500, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 90, 9800, null, 1, "Fata", null },
                    { 1030, 2, "Negru", 1, "Germania", 279000, 4, 5, 2000, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, null, 6350, null, 1, null, null },
                    { 1000, 3, "Albastru", 1, "Belgia", 74000, 4, 6, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 19300, true, 1, "Spate", "WBA5C31020D767206" },
                    { 1020, 2, "Gri", 1, null, 195000, 5, 5, 1968, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 140, 6550, null, 1, "Fata", "VSSZZZ1PZCR021916" },
                    { 1018, 5, "Gri", 1, "Germania", 202000, null, 4, 1700, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, 125, 2650, null, 0, null, null },
                    { 1002, 6, "Verde", 1, "Danemarca", 230000, 5, 5, 1968, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 10500, null, 1, "4x4 (automat)", null },
                    { 1003, 3, "Gri", 1, "Olanda", 235000, 4, 5, 1995, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 163, 13499, true, 1, "Spate", "WBA3E11050F296338" },
                    { 1004, 2, "Gri", 1, "Germania", 102358, 5, 4, 1898, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 140, 4600, null, 1, "Fata", null },
                    { 1005, 1, "Rosu", 1, null, 219000, null, null, null, 0, null, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 878, null, 2799, null, 1, null, "WMWRA31080TA44220" },
                    { 1006, 3, "Gri", 1, "Germania", 223000, 5, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 190, 12000, null, 0, "Fata", null },
                    { 1007, 3, "Maro", 1, "Germania", 196800, 5, 5, 1968, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 170, 9290, null, 1, "Fata", null },
                    { 1008, 3, "Gri", 1, "Belgia", 178451, null, 5, 2998, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 245, 13490, true, 1, "Fata", null },
                    { 1019, 3, "Alb", 1, "Germania", 187000, 4, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 190, 19890, null, 1, "Fata", null },
                    { 1009, 6, "Negru", 1, "Germania", 15400, 5, 6, 2000, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 190, 22990, null, 1, "4x4 (automat)", null },
                    { 1011, 2, "Negru", 1, null, 220000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 3500, null, 1, null, null },
                    { 1012, 4, "Negru", 1, "Germania", 288000, 5, 4, 1910, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 150, 3500, true, 1, "Fata", "W0L0AHL3525554956" },
                    { 1013, 1, "Gri", 1, "Germania", 140000, 5, 4, 1400, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 80, 2950, true, 1, "Fata", null },
                    { 1014, 4, "Albastru", 1, "Belgia", 139871, 4, 5, 1968, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 177, 14999, null, 0, "Fata", "WAUZZZ4G2EN165340" },
                    { 1015, 6, "Negru", 1, "Germania", 9350, 5, 6, 2993, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 381, 59900, null, 0, "4x4 (automat)", null },
                    { 1016, 3, "Negru", 1, "Olanda", 121300, 5, 5, 1598, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 156, 7990, true, 1, "Fata", "VF38D5FV8BL107162" },
                    { 1017, 1, "Negru", 1, "Germania", 151000, null, 4, 1968, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 138, 150, 3599, null, 1, "Fata", null },
                    { 1010, 3, "Negru", 1, "Germania", 182000, 5, 6, 1968, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 12000, null, 0, "Fata", null },
                    { 961, 5, "Alb", 1, "Olanda", 289000, 2, null, 1461, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 65, 1900, null, 1, "Fata", null },
                    { 1119, 2, "Albastru", 1, "Romania", 62000, 3, 6, 1984, 0, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 109, 300, 33500, true, 0, "4x4 (automat)", null },
                    { 1121, 6, "Negru", 1, null, 165000, null, 6, 1998, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 190, 22400, null, 1, "4x4 (automat)", null },
                    { 1222, 3, "Gri", 1, "Germania", 150000, 4, 5, 2143, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 204, 18000, true, 1, "4x4 (automat)", "WDD2120821A545206" },
                    { 1223, 1, "Negru", 1, "Romania", 14480, 5, 6, 1461, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 90, 14150, true, 0, "Fata", "VF17RKJ0A59679443" },
                    { 1224, 6, "Gri", 1, "Franta", 194000, null, null, 1350, 1, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 647, null, 1350, null, 0, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 1225, 2, "Argint", 1, "Romania", 120000, 4, 4, 1596, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 101, 3900, true, 1, null, null },
                    { 1226, 3, "Negru", 1, "Franta", 159000, 4, 5, 2198, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 724, 163, 12990, null, 1, "Spate", null },
                    { 1227, 3, "Gri", 1, "Republica Ceha", 180000, 4, 5, 2143, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 177, 9500, null, 1, "Spate", null },
                    { 1228, 2, "Albastru", 1, "Germania", 230000, 5, null, 1600, 0, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 105, 2299, null, 0, "Fata", null },
                    { 1221, 6, "Alb", 1, "Germania", 79500, 4, 5, 2993, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 258, 37900, null, 0, "4x4 (automat)", null },
                    { 1229, 5, "Gri", 1, "Germania", 237000, 5, 4, 1900, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 105, 4500, true, 0, "Fata", null },
                    { 1231, 3, "Alte culori", 1, "Romania", 109220, null, 5, 1500, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 88, 4900, true, 1, "Fata", null },
                    { 1232, 3, "Negru", 1, "Romania", 139000, 5, null, 1149, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, 75, 3900, true, 1, "Fata", "VF1LBN00547322267" },
                    { 1233, 6, "Alb", 1, "Romania", 59000, 5, 6, 2000, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 237, 150, 22000, true, 1, "4x4 (automat)", "JF1SJDLY5GG261062" },
                    { 1234, 6, "Negru", 1, "Romania", 273000, null, 4, 2968, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 240, 10299, true, 1, "4x4 (automat)", null },
                    { 1235, 8, "Alb", 1, "Romania", 88200, 3, 4, 1995, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 177, 11900, true, 1, "4x4 (automat)", "WBAWC11080E210545" },
                    { 1236, 4, "Negru", 1, "Romania", 105812, 4, 6, 1997, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 150, 13850, true, 0, "Fata", null },
                    { 1237, 6, "Negru", 1, null, 184500, null, null, null, 4, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, null, 9300, null, 1, null, "vf3hurhc8ds249999" },
                    { 1230, 5, "Alb", 1, "Romania", 259750, 6, 5, 1461, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 75, 3190, true, 0, "Fata", null },
                    { 1238, 3, "Alb", 1, "Germania", 197000, null, 6, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 190, 16600, true, 1, "4x4 (automat)", null },
                    { 1220, 6, "Alb", 1, "Germania", 180900, null, 5, 1998, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 184, 14600, true, 1, "4x4 (automat)", "WBAWY31010L526538" },
                    { 1218, 3, "Alb", 1, null, 41000, null, null, null, 1, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, null, 13000, null, 1, null, "KMHLC41UGGU090474" },
                    { 1202, 6, "Negru", 1, null, 225588, null, 5, 2179, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, 150, 9990, true, 0, "4x4 (automat)", null },
                    { 1203, 4, "Alb", 1, "Germania", 195000, 5, 6, 2000, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 14900, null, 1, "Fata", null },
                    { 1204, 4, "Gri", 1, null, 238000, null, null, 1998, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, null, 4250, null, 0, null, null },
                    { 1205, 3, "Gri", 1, "Olanda", 183000, null, 5, 1700, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 131, 8290, null, 1, "Fata", null },
                    { 1206, 6, "Negru", 1, "Romania", 10, 5, 6, 1995, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 783, 177, 29500, true, 0, null, null },
                    { 1207, 1, "Alb", 1, null, 113000, null, 5, 1364, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, 90, 5900, true, 0, "Fata", "VNKKC3D300A073876" },
                    { 1208, 1, "Rosu", 1, "Romania", 109000, 5, null, 1299, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, null, 2100, null, 1, "Fata", null },
                    { 1219, 4, "Gri", 1, "Germania", 250000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, null, 2790, null, 1, null, null },
                    { 1209, 8, "Gri", 1, "Romania", 124000, 2, 5, 1998, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 163, 11700, true, 0, "Fata", null },
                    { 1211, 4, "Argint", 1, "Romania", 157825, 4, 5, 1598, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 9700, true, 0, "Fata", "WVWZZZAUZFP553117" },
                    { 1212, 6, "Gri", 1, "Romania", 127000, 5, 5, 2993, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, 258, 29900, true, 0, "4x4 (automat)", null },
                    { 1213, 7, "Negru", 1, "Germania", 167000, 2, null, 1900, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, null, 3890, null, 1, null, null },
                    { 1214, 6, "Gri", 1, "Germania", 73100, 4, 5, 2993, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 258, 38700, null, 0, "4x4 (automat)", null },
                    { 1215, 4, "Gri", 1, "Romania", 56000, 5, 6, 1399, 0, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 125, 11092, true, 0, "Fata", "W0LBF8EB4G8076296" },
                    { 1216, 6, "Albastru", 1, null, 199950, 5, null, 1995, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 143, 11515, true, 0, null, null },
                    { 1217, 7, "Negru", 1, "Germania", 56000, null, 5, 4200, 0, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 554, 420, 69989, null, 1, "4x4 (automat)", null },
                    { 1210, 4, "Maro", 1, "Franta", 190000, 5, 5, 2000, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 5199, null, 0, "Fata", null },
                    { 1201, 3, "Negru", 1, "Romania", 97000, 5, 6, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 10000, true, 1, "Fata", "TMBAG7NE4G0104269" },
                    { 1239, 4, "Gri", 1, "Belgia", 275600, 5, 4, 1998, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 136, 4950, null, 1, "Spate", "WBAVW11020A270542" },
                    { 1241, 0, "Alte culori", 1, "Germania", 205000, null, 4, 1600, 0, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 1690, null, 1, null, null },
                    { 1262, 3, "Albastru", 1, "Romania", 199969, 4, 5, 1500, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 65, 2850, true, 0, "Fata", "UU1LSDJKF43135951" },
                    { 1263, 6, "Auriu", 1, "Germania", 145000, 4, 5, 1996, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 551, 150, 13680, null, 1, "4x4 (automat)", "WAUZZZ8U0ER138209" },
                    { 1264, 2, "Negru", 1, "Germania", 237000, 4, 4, 1995, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 163, 5400, true, 1, "Fata", null },
                    { 1265, 6, "Negru", 1, "Romania", 57000, 5, 6, 1995, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 114, 15980, true, 1, null, null },
                    { 1266, 5, "Negru", 1, null, 210000, null, 4, 1596, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 116, 3785, null, 1, "Fata", "wvgzzz1tz6w085511" },
                    { 1267, 1, "Auriu", 1, "Germania", 168000, null, 6, 1989, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 150, 12490, null, 1, null, null },
                    { 1268, 6, "Gri", 1, "Danemarca", 267552, null, 4, 2998, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 225, 5999, true, 0, "4x4 (automat)", null },
                    { 1261, 6, "Negru", 1, "Romania", 37500, 4, 6, 2998, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 258, 33950, true, 0, "4x4 (automat)", "WBAWY510X00E30424" },
                    { 1269, 6, "Gri", 1, null, 145500, 5, 5, 1498, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 7550, null, 1, "4x4-manual", null },
                    { 1271, 4, "Negru", 1, "Germania", 195000, 1, 5, 1988, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 150, 12699, null, 1, "Fata", null },
                    { 1272, 3, "Argint", 1, null, 141400, 5, null, 1968, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 143, 5200, true, 1, "Fata", null },
                    { 1273, 6, "Negru", 1, "Germania", 70000, 4, 5, 1995, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 218, 19200, null, 0, "4x4 (automat)", null },
                    { 1274, 4, "Argint", 1, "Germania", 195200, 5, 5, 1968, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 110, 5199, null, 1, "Fata", null },
                    { 1275, 6, "Maro", 1, null, 4, null, 6, 1798, 4, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 122, 21990, null, 0, "Fata", null },
                    { 1276, 5, "Gri", 1, "Germania", 222000, 5, 4, 1896, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 399, 105, 5150, null, 1, "Fata", null },
                    { 1277, 2, "Negru", 1, "Germania", 14960, 5, 6, 1998, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 252, 120, 18550, null, 0, "Fata", null },
                    { 1270, 6, "Gri", 1, "Germania", 167000, null, 6, 2968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 258, 21990, null, 1, "4x4 (automat)", "WDC1660241A220576" },
                    { 1240, 6, "Alb", 1, "Germania", 166999, 5, 5, 2993, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 316, 240, 11999, true, 1, "4x4 (automat)", "JN1TCNJ50U0670187" },
                    { 1260, 3, "Alb", 1, "Germania", 158000, null, 6, 1995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 190, 17800, null, 1, "Spate", null },
                    { 1258, 2, "Alb", 1, null, 155000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 184, null, 4800, null, 1, null, null },
                    { 1242, 6, "Alb", 1, null, 157000, 5, 5, 1500, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 115, 7950, null, 1, null, null },
                    { 1243, 4, "Negru", 1, "Germania", 194000, null, null, 1986, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 13250, true, 1, null, "WVWZZZ3CZFE479820" },
                    { 1244, 2, "Maro", 0, null, 10, 5, 6, 898, 0, 0, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 90, 10400, null, 0, "Fata", null },
                    { 1245, 3, "Alb", 1, "Germania", 58000, null, 6, 1995, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 190, 41600, true, 1, "4x4 (automat)", null },
                    { 1246, 4, "Alb", 1, null, 230000, null, null, null, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, null, 8199, null, 1, null, "WAUZZZ8K49A060603" },
                    { 1247, 3, "Gri", 1, null, 119000, null, null, 2993, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 258, 26900, null, 1, "4x4 (automat)", null },
                    { 1248, 3, "Negru", 1, "Germania", 224000, 4, 4, 1998, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 143, 2650, true, 1, "Fata", "JMZGY19R671433488" },
                    { 1259, 6, "Albastru", 0, null, 20, 5, 6, 1332, 0, 0, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 150, 15165, null, 0, "Fata", null },
                    { 1249, 1, "Alb", 1, null, 75000, null, null, 1364, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, 90, 6900, true, 0, "Fata", "VNKKC3D370A072286" },
                    { 1251, 6, "Argint", 1, null, 29400, null, 5, 1999, 0, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 166, 14200, true, 1, "4x4-manual", null },
                    { 1252, 6, "Negru", 1, null, 208000, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, null, 10700, null, 1, null, null },
                    { 2559, 0, "Alb", 1, "Romania", 98299, null, null, 999, 0, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 166, 75, 4750, true, 0, null, null },
                    { 1254, 3, "Gri", 1, null, 235200, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 5750, null, 1, null, "WVWZZZ3CZ7P161659" },
                    { 1255, 3, "Alb", 1, "Romania", 385000, 5, 4, 2698, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 180, 4500, true, 1, "4x4 (automat)", "WAUZZZ8E08A052491" },
                    { 1256, 6, "Negru", 1, null, 154999, 5, 4, null, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, null, 9400, null, 1, "4x4 (automat)", null },
                    { 1257, 2, "Rosu", 1, "Romania", 1400, 5, 6, 1798, 4, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 321, 136, 18400, null, 0, "Fata", null },
                    { 1250, 6, "Alb", 1, "Romania", 1, 5, 6, 1998, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 150, 25629, null, 0, "4x4 (automat)", null },
                    { 1120, 3, "Maro", 1, "Germania", 188300, null, 5, 1968, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 170, 11990, null, 1, "Fata", null },
                    { 1200, 1, "Gri", 1, null, 152000, 5, 5, 1956, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 160, 6490, null, 0, "Fata", "W0LGT6EM7B1023971" },
                    { 1198, 6, "Alb", 1, "Romania", 180000, 5, 6, 3000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 313, 30500, true, 1, "4x4 (automat)", null },
                    { 1142, 1, "Albastru", 1, null, 1, null, null, null, 4, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, null, 15183, null, 0, null, null },
                    { 1143, 3, "Maro", 1, "Romania", 23130, 5, 6, 999, 0, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 74, 7100, true, 0, "Fata", "UU14SDMC457459188" },
                    { 1144, 1, "Bej", 1, "Elvetia", 200000, null, 5, 1598, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 878, 122, 6950, null, 1, "Fata", null },
                    { 1145, 6, "Maro", 1, null, 197000, 4, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, null, 15500, null, 1, null, null },
                    { 1146, 8, "Negru", 1, null, 258000, null, null, null, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 140, 9300, null, 1, null, null },
                    { 1147, 3, "Maro", 1, "Germania", 215737, 4, 5, 1968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 140, 11999, true, 0, "Fata", null },
                    { 1148, 3, "Gri", 1, null, 148500, null, 5, 2000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 136, 14700, null, 1, "Fata", "WAUZZZ4G1EN027496" },
                    { 1141, 6, "Gri", 1, "Olanda", 220800, 5, 5, 2000, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 552, 170, 13690, null, 1, "4x4 (automat)", "WAUZZZ8R5BA067160" },
                    { 1149, 3, "Argint", 1, null, 200000, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 693, null, 4750, null, 1, null, null },
                    { 1151, 4, "Maro", 1, "Olanda", 162000, null, 6, 1595, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 110, 8750, null, 1, "Fata", null },
                    { 1152, 3, "Negru", 1, null, 250000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, null, 16500, null, 1, null, null },
                    { 1153, 4, "Negru", 1, "Germania", 182600, 5, 6, 1598, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 8990, null, 1, "Fata", "WVWZZZAUZFP572974" },
                    { 1154, 3, "Alb", 1, "Romania", 66750, 4, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 15900, true, 0, "Fata", "WVWZZZ3CZFE456829" },
                    { 1155, 6, "Negru", 1, "Germania", 240000, 5, 5, 3500, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 283, 21900, true, 0, "4x4 (automat)", null },
                    { 1156, 6, "Gri", 1, "Romania", 26000, 5, 6, 1999, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 717, 180, 39990, true, 0, "4x4 (automat)", null },
                    { 1157, 3, "Negru", 1, null, 200000, null, 5, 2000, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 160, 8800, true, 1, "Fata", null },
                    { 1150, 3, "Negru", 1, "Romania", 113485, 5, null, 1197, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 6590, true, 0, "Fata", "TMBBM61Z8B8020997" },
                    { 1158, 6, "Gri", 1, null, 54732, 4, null, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 140, 18900, null, 0, "4x4 (automat)", "WVGZZZ5NZFW038924" },
                    { 1140, 1, "Rosu", 1, "Romania", 81275, 4, null, 1600, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 90, 6900, true, 0, "Fata", "VSSZZZ6JZBR166039" },
                    { 1138, 6, "Albastru", 1, "Belgia", 199994, null, 5, 2995, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 306, 18900, null, 1, "4x4 (automat)", "WBAZW610X0LL44227" },
                    { 1122, 6, "Negru", 1, "Germania", 116200, 4, 5, 1998, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 163, 12890, null, 0, "4x4 (automat)", null },
                    { 1123, 6, "Argint", 1, "Germania", 162000, null, 5, 1968, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 110, 10450, true, 1, "Fata", "wvgzzz5nzcw568532" },
                    { 1124, 3, "Negru", 1, "Germania", 17900, 4, 6, 1995, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 190, 35900, null, 0, "Spate", null },
                    { 1125, 3, "Alb", 1, "Romania", 56000, 5, 5, 1200, 0, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 10749, true, 1, "Fata", "tmbab7ne0e0045670" },
                    { 1126, 2, "Negru", 1, null, 320000, null, null, null, 1, null, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 7000, null, 1, null, "WVWZZZ1JZ3W134741" },
                    { 1127, 4, "Negru", 1, null, 217000, 5, 5, 1560, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 800, 114, 5400, null, 1, "Fata", null },
                    { 1128, 3, "Negru", 1, null, 105951, 4, null, 1598, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 120, 18700, null, 0, "Fata", "WVWZZZ3CZHE055376" },
                    { 1139, 8, "Negru", 1, "Germania", 220, 3, 5, 2700, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 190, 12999, null, 1, "Fata", null },
                    { 1129, 1, "Gri", 1, "Italia", 260000, null, null, 1900, 1, 0, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 1299, null, 0, "Fata", null },
                    { 1131, 3, "Gri", 1, "Germania", 228000, null, 4, 2000, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 150, 6690, null, 1, null, null },
                    { 1132, 6, "Argint", 1, null, 190000, 5, 5, 1968, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 174, 140, 7400, null, 1, "4x4 (automat)", null },
                    { 1133, 6, "Negru", 1, "Germania", 65840, null, 6, 1500, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 636, 112, 10900, true, 1, "Fata", null },
                    { 1134, 3, "Gri", 1, "Romania", 204000, 4, 4, 1394, 2, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 100, 2699, true, 1, "Fata", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 1135, 4, "Negru", 1, null, 88000, 5, 6, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 13900, null, 1, "Fata", "WVWZZZ3CZFE515596" },
                    { 1136, 3, "Albastru", 1, "Romania", 23700, 4, 6, 1364, 0, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 140, 12200, true, 1, "Fata", null },
                    { 1137, 6, "Negru", 1, "Romania", 44600, 4, null, 2995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 258, 41000, true, 1, "4x4 (automat)", "WBAKS410400R88745" },
                    { 1130, 2, "Albastru", 1, "Germania", 64000, 5, 5, 1197, 0, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 6900, null, 0, "Fata", null },
                    { 1199, 3, "Auriu", 1, "Germania", 198700, null, 5, 2700, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 190, 9890, true, 1, "4x4 (automat)", null },
                    { 1159, 6, "Maro", 1, null, 1, null, null, null, 4, null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, null, 24800, null, 0, null, null },
                    { 1161, 1, "Albastru", 1, "Romania", 38540, 4, 6, 998, 0, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 100, 9550, true, 0, "Fata", "WF0DXXGAKDHM70988" },
                    { 1182, 3, "Maro", 1, null, 89500, 4, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 14000, null, 1, null, "TMBAJ7NE6D0008124" },
                    { 1183, 6, "Alb", 1, "Romania", 39800, 4, 6, 2393, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 338, 150, 29411, true, 0, "4x4-manual", "AHTBB3CD601740300" },
                    { 1184, 3, "Maro", 0, null, 10, 5, 6, 1461, 1, 0, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 95, 10400, null, 0, "Fata", null },
                    { 1185, 3, "Gri", 1, "Franta", 193000, 5, null, 2000, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 140, 6999, null, 0, "Fata", null },
                    { 1186, 5, "Albastru", 1, "Romania", 62245, 5, null, 1997, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 659, 140, 13990, true, 0, null, null },
                    { 1187, 3, "Albastru", 1, "Germania", 206200, 4, 4, 1998, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 143, 6900, true, 1, null, null },
                    { 1188, 3, "Albastru", 1, "Germania", 15200, 4, 6, 1998, 0, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 252, 42800, null, 0, "4x4 (automat)", null },
                    { 1181, 1, "Argint", 1, null, 197903, null, null, 1481, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 110, 3799, null, 0, "Fata", "VF1BT1A0638590235" },
                    { 1189, 6, "Negru", 1, "Germania", 179000, null, 6, 1998, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 218, 26350, null, 1, "4x4 (automat)", null },
                    { 1191, 3, "Gri", 1, "Belgia", 69000, null, 5, 1400, 0, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 122, 10900, true, 1, "Fata", "WVWZZZ3CZBP335286" },
                    { 1192, 1, "Rosu", 1, "Franta", 128000, 5, null, 1600, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, null, 2300, true, 1, null, null },
                    { 1193, 3, "Albastru", 1, "Romania", 11, 5, 6, 999, 0, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 8650, null, 0, "Fata", "UU14SDMC458273867" },
                    { 1194, 2, "Negru", 1, "Germania", 151000, 4, 6, 1998, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 150, 12699, null, 1, "Fata", null },
                    { 1195, 5, "Negru", 1, "Germania", 148100, null, 5, 1968, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 143, 11490, null, 1, "Fata", null },
                    { 1196, 6, "Maro", 1, "Germania", 28000, 4, 6, 2993, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 258, 43900, null, 0, "4x4 (automat)", null },
                    { 1197, 6, "Rosu", 1, null, 80000, null, null, 1618, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 754, 190, 12000, true, 1, "4x4 (automat)", null },
                    { 1190, 6, "Gri", 0, null, 1, 5, 6, 1993, 4, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226, 184, 31974, null, 0, "4x4 (automat)", null },
                    { 1160, 5, "Rosu", 1, null, 290000, null, null, 1898, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 648, null, 2000, null, 0, null, null },
                    { 1180, 5, "Negru", 1, "Germania", 235000, null, null, null, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, null, 2800, true, 1, null, null },
                    { 1178, 1, "Alb", 1, "Romania", 119842, 5, 5, 1398, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 68, 4800, true, 1, "Fata", "VF3CC8HR0DT153048" },
                    { 1162, 4, "Albastru", 1, null, 185000, null, 5, 1600, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 9490, null, 1, "Fata", null },
                    { 1163, 6, "Negru", 1, "Olanda", 247967, 5, 5, 1995, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 177, 10989, null, 0, "4x4 (automat)", "WBAVP31040VK13390" },
                    { 1164, 6, "Gri", 1, "Germania", 13900, 4, 6, 2894, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 441, 87980, null, 0, "4x4 (automat)", null },
                    { 1165, 3, "Negru", 1, "Romania", 115000, null, 6, 1995, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 218, 17500, true, 0, "Spate", "WBA5C71060D054557" },
                    { 1166, 2, "Argint", 1, "Germania", 240000, 5, 3, 1896, 1, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 101, 2350, null, 0, "Fata", null },
                    { 1167, 3, "Negru", 1, "Romania", 227000, 4, 4, 1991, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 191, 120, 2900, true, 0, "Fata", null },
                    { 1168, 5, "Gri", 1, "Belgia", 182500, 4, 5, 1598, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 173, 90, 5990, null, 0, "Fata", "TMBNJ25J4B7018947" },
                    { 1179, 6, "Gri", 1, "Romania", 5022, 5, 6, 2492, 4, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 313, 197, 45900, true, 0, "4x4 (automat)", null },
                    { 1169, 3, "Maro", 1, "Franta", 215000, 5, 5, 2000, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 6199, null, 0, "Fata", null },
                    { 1171, 6, "Negru", 1, "Romania", 5005, 5, 6, 1461, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 109, 19950, true, 0, "4x4-manual", "VF1HJD40760966578" },
                    { 1172, 6, "Negru", 1, "Germania", 34, 4, 6, 2143, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491, 170, 42700, null, 0, "4x4 (automat)", null },
                    { 1173, 4, "Negru", 1, "Germania", 221300, 5, 5, null, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, null, 7350, null, 1, "Fata", null },
                    { 1174, 3, "Gri", 1, "Romania", 149000, null, null, 1991, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 184, 125, 4700, true, 0, "Fata", null },
                    { 1175, 2, "Argint", 1, "Germania", 190000, 5, 5, 1560, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 110, 4700, null, 0, "Fata", null },
                    { 1176, 3, "Negru", 1, null, 106000, null, 6, 2000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 184, 18650, null, 1, "4x4 (automat)", "WBA5B91090D566229" },
                    { 1177, 3, "Alb", 1, "Olanda", 138400, 5, 6, 1969, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 795, 120, 11699, null, 1, "Fata", "YV1FS7880G2401847" },
                    { 1170, 3, "Negru", 1, "Germania", 165000, null, 6, 2998, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 250, 20750, null, 1, "Spate", null },
                    { 960, 2, "Negru", 1, null, 265000, 2, null, 1896, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 116, 2450, null, 0, "Fata", null },
                    { 959, 4, "Negru", 1, "Germania", 207000, 4, 5, 1995, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 143, 6490, null, 1, "Spate", null },
                    { 958, 6, "Albastru", 1, "Germania", 202000, 4, 3, 2488, 1, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 133, 4700, null, 1, "4x4-manual", null },
                    { 741, 1, "Alb", 1, null, 127400, null, 5, 1997, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 177, 8950, null, 1, "Fata", null },
                    { 742, 4, "Gri", 1, "Olanda", 147899, 4, 4, 1600, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 105, 2999, null, 1, "Fata", null },
                    { 743, 4, "Gri", 1, "Romania", 142032, 5, 3, 1461, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 101, 3500, true, 0, "Fata", null },
                    { 744, 6, "Negru", 1, "Germania", 54000, 4, 5, 2993, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, 292, 46900, true, 0, "4x4 (automat)", null },
                    { 745, 6, "Argint", 1, "Romania", 151000, null, 4, 2000, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, 150, 4500, true, 1, "4x4 (automat)", null },
                    { 746, 3, "Gri", 1, null, 170000, 4, null, 1461, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 105, 5580, null, 0, "Fata", "VF1LZBB0642386980" },
                    { 747, 3, "Maro", 1, "Germania", 179000, null, 6, 2995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 258, 19400, true, 0, "4x4 (automat)", null },
                    { 740, 1, "Rosu", 1, "Romania", 131325, 5, 4, 1149, 0, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 75, 3300, true, 0, "Fata", null },
                    { 748, 4, "Argint", 1, "Germania", 114980, 5, 5, 1560, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 96, 7600, null, 0, "Fata", null },
                    { 750, 1, "Rosu", 1, "Romania", 4500, 5, 6, 999, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 140, 13850, true, 0, "Fata", "WF0JXXGAHJJL72000" },
                    { 751, 1, "Albastru", 1, null, 240000, null, null, null, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, null, 4990, null, 1, null, null },
                    { 752, 2, "Negru", 1, "Germania", 232000, 4, 4, 1895, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 4000, null, 1, "Fata", null },
                    { 753, 6, "Alte culori", 1, "Germania", 15000, null, 6, 1560, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 159, 120, 15900, null, 1, "Fata", null },
                    { 754, 6, "Negru", 1, "Germania", 145000, 4, 6, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491, 258, 43800, null, 0, "4x4 (automat)", null },
                    { 755, 1, "Negru", 1, "Franta", 188508, 5, 5, 1560, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 95, 4450, null, 1, "Fata", "WF0JXXGAJJAP36137" },
                    { 756, 3, "Alb", 1, null, 170000, null, 6, 1998, 0, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 13900, null, 1, "Spate", null },
                    { 749, 6, "Negru", 1, "Germania", 93900, 4, 6, 2987, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491, 258, 46800, null, 0, "4x4 (automat)", null },
                    { 757, 8, "Negru", 1, "Germania", 287000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 6900, true, 1, null, "WBAWD11070PW02773" },
                    { 739, 2, "Negru", 1, "Germania", 103350, null, 5, 1799, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 221, 140, 7690, null, 0, "Fata", null },
                    { 737, 2, "Albastru", 1, "Olanda", 225000, 5, 4, 1560, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 109, 3999, null, 0, "Fata", null },
                    { 721, 8, "Negru", 1, "Romania", 9900, 4, 6, 1451, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 488, 109, 22500, true, 0, "Fata", "WDD1173121N613922" },
                    { 722, 5, "Gri", 1, "Germania", 235500, null, 6, 1986, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 431, 150, 11990, null, 1, "Fata", null },
                    { 723, 3, "Maro", 1, "Germania", 122000, 5, 6, 1998, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 191, 19900, null, 0, "Spate", null },
                    { 724, 6, "Alb", 1, null, 111000, 5, 6, 2887, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, 292, 48500, null, 0, "4x4 (automat)", null },
                    { 725, 3, "Negru", 1, "Belgia", 189000, 4, 5, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 231, 19800, null, 1, "Spate", "WDD2120981B167725" },
                    { 726, 2, "Negru", 1, "Germania", 187000, 5, 4, 1560, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 109, 2700, null, 1, "Fata", null },
                    { 727, 6, "Negru", 1, "Germania", 29850, 4, 6, 2987, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 37500, null, 0, "4x4 (automat)", null },
                    { 738, 6, "Negru", 1, "Germania", 74900, 4, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 204, 35400, null, 0, "4x4 (automat)", null },
                    { 728, 5, "Gri", 1, "Germania", 305000, 5, 4, 1986, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 103, 4590, true, 1, "Fata", null },
                    { 730, 6, "Albastru", 0, null, 4, null, null, 1991, 0, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 184, 36580, null, 0, "4x4 (automat)", "WDC1569471J603508" },
                    { 731, 6, "Negru", 0, null, 5, null, null, 2143, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491, 204, 51548, null, 0, "4x4 (automat)", "WDC2533091F591715" },
                    { 732, 6, "Negru", 0, null, 8, null, null, 2987, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491, 258, 79709, null, 0, "4x4 (automat)", "WDC2923241A138409" },
                    { 733, 5, "Alb", 1, null, 119110, 4, 5, 1753, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 667, 90, 5500, null, 1, "Fata", "WF0UXXTTPUDJ51975" },
                    { 734, 4, "Gri", 1, null, 180000, null, null, null, 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, null, 2990, null, 1, null, null },
                    { 735, 2, "Rosu", 1, null, 151000, 4, null, null, 0, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 5890, null, 1, null, null },
                    { 736, 6, "Negru", 1, "Germania", 223456, 4, 4, 2968, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 245, 7850, null, 1, "4x4 (automat)", null },
                    { 729, 3, "Negru", 1, "Germania", 170000, 4, 6, 2993, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 258, 21990, true, 0, "4x4 (automat)", null },
                    { 720, 6, "Alb", 1, "Romania", 26766, 5, 6, 1798, 4, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 122, 24490, true, 0, "Fata", "NMTKZ3BX10R003057" },
                    { 758, 6, "Maro", 1, "Germania", 166000, 5, 5, 1995, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, null, 9800, null, 1, "4x4-manual", null },
                    { 760, 1, "Alb", 1, "Germania", 146000, null, 5, 2996, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 216, 245, 34499, true, 1, "Spate", null },
                    { 781, 1, "Gri", 0, null, 1, 5, 6, 998, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 85, 13025, null, 0, "Fata", null },
                    { 782, 3, "Verde", 1, null, 280000, null, null, null, 0, null, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 757, null, 2500, null, 0, null, null },
                    { 783, 1, "Gri", 1, "Romania", 84661, 4, 4, 1398, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 74, 4890, true, 1, "Fata", "VF3WC8HR0BT055701" },
                    { 784, 1, "Negru", 1, "Belgia", 167000, null, 5, 1500, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 264, 110, 12750, true, 1, "Fata", null },
                    { 785, 4, "Negru", 1, null, 307000, null, null, null, 1, null, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 2000, null, 1, null, null },
                    { 786, 6, "Maro", 1, "Germania", 230219, null, 4, 2993, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 218, 5449, true, 1, "4x4 (automat)", null },
                    { 787, 2, "Albastru", 1, "Romania", 76736, 5, null, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 9990, true, 0, "Fata", "WVWZZZAUZFP052042" },
                    { 780, 4, "Negru", 1, "Germania", 212968, 5, 5, 2143, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 170, 11200, true, 1, "Spate", null },
                    { 788, 6, "Maro", 1, "Romania", 66258, 5, 5, 1999, 0, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 166, 12900, true, 0, "4x4-manual", "TMAJU81FCEJ561612" },
                    { 790, 0, "Alb", 1, "Olanda", 91000, 2, 5, 999, 0, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 838, 70, 3750, true, 1, "Spate", null },
                    { 791, 4, "Rosu", 1, "Germania", 171000, 5, 4, 1598, 0, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 101, 1590, null, 0, null, null },
                    { 792, 2, "Maro", 1, "Statele Unite ale Americii", 38500, 5, 6, 1598, 0, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 876, 184, 16500, true, 1, "4x4 (automat)", null },
                    { 793, 4, "Negru", 1, "Germania", 270000, null, 5, 1998, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 170, 5700, null, 0, "Fata", null },
                    { 794, 1, "Alb", 1, "Romania", 174621, 5, 5, 1500, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 4600, true, 0, "Fata", "WF0DXXGAKDDM78471" },
                    { 795, 5, "Gri", 1, null, 180000, null, null, null, 1, null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 515, null, 18000, null, 1, null, null },
                    { 796, 4, "Negru", 1, "Belgia", 212000, 5, 5, 2000, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, null, 7600, true, 1, "Fata", "W0LGM8ER7E1146663" },
                    { 789, 2, "Gri", 1, "Germania", 220000, 4, null, 1998, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 140, 4090, true, 1, null, null },
                    { 759, 3, "Albastru", 1, "Romania", 159000, 4, 4, 1149, 2, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, 75, 3200, true, 1, "Fata", "VF1LBVU0541399406" },
                    { 779, 1, "Gri", 1, null, 94000, null, null, 1461, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 85, 1999, true, 1, "Fata", null },
                    { 777, 5, "Argint", 1, "Germania", 326000, 4, 4, 1796, 0, 1, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 125, 8000, true, 1, "Fata", "W0L0TGF7512225337" },
                    { 761, 4, "Albastru", 1, "Germania", 298000, null, null, 1795, 1, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 116, 999, null, 1, "Fata", null },
                    { 762, 6, "Alb", 1, null, 73000, null, null, null, 0, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, null, 10500, null, 1, null, null },
                    { 763, 4, "Alte culori", 1, "Franta", 195678, 1, 5, 1998, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 7890, null, 1, "Fata", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 764, 6, "Negru", 1, "Germania", 53000, null, 6, 2996, 0, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491, 367, 51100, null, 0, "4x4 (automat)", null },
                    { 765, 3, "Gri", 1, "Romania", 60407, 5, null, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 16900, true, 0, "Fata", "WVWZZZ3CZFE418553" },
                    { 766, 6, "Maro", 1, "Germania", 90717, 4, 5, 1995, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 135, 11010, null, 0, "4x4-manual", "TMAJT81VCDJ463249" },
                    { 767, 3, "Albastru", 1, "Germania", 58300, null, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 190, 22880, true, 0, "4x4 (automat)", null },
                    { 778, 6, "Negru", 1, "Germania", 223000, 4, 5, 2143, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 739, 163, 9000, null, 1, "4x4-manual", null },
                    { 768, 5, "Negru", 1, "Franta", 115600, 5, 6, 1499, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 632, 120, 11450, null, 0, "Fata", null },
                    { 770, 6, "Gri", 1, "Romania", 28500, 4, 6, 3200, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 288, 190, 29300, true, 0, "4x4-manual", null },
                    { 771, 1, "Negru", 1, null, 193000, null, null, null, 1, null, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, null, 13950, null, 1, null, null },
                    { 772, 6, "Negru", 1, "Germania", 88068, 4, 5, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 185, 15900, null, 0, "4x4 (automat)", "TMAJU81VDFJ678783" },
                    { 773, 4, "Negru", 1, "Romania", 220000, 5, 4, 1798, 1, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 90, 999, true, 1, "Fata", null },
                    { 774, 2, "Albastru", 1, null, 205000, null, null, 1600, 1, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 110, 3650, true, 1, null, null },
                    { 775, 3, "Gri", 1, null, 97400, null, 5, 2000, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 150, 10999, null, 0, "Fata", null },
                    { 776, 4, "Alb", 1, null, 190000, 5, 5, 1600, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 9800, true, 1, "Fata", null },
                    { 769, 3, "Albastru", 1, "Germania", 33304, null, 6, 2996, 0, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 401, 54455, null, 0, "4x4 (automat)", null },
                    { 797, 4, "Argint", 1, "Germania", 198000, null, 5, 1998, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 538, 170, 8999, null, 0, "4x4-manual", null },
                    { 719, 3, "Alb", 1, "Belgia", 167000, 5, 5, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 110, 8749, null, 1, "Fata", null },
                    { 717, 6, "Albastru", 1, "Germania", 14000, 4, 6, 2298, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 249, 190, 32800, null, 0, "4x4 (automat)", null },
                    { 661, 4, "Negru", 1, "Germania", 260000, null, 4, 1968, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 140, 4650, true, 0, "Fata", null },
                    { 662, 5, "Alb", 1, "Germania", 74628, null, 5, 2143, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 95, 13990, null, 0, "Spate", "WDF63970313837509" },
                    { 663, 2, "Rosu", 1, "Romania", 123074, 5, 5, 1598, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 87, 4990, true, 0, "Fata", "UU1BSDAFK41763175" },
                    { 664, 6, "Gri", 1, "Polonia", 180000, 5, 4, 1900, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, 130, 5390, null, 0, "4x4-manual", null },
                    { 665, 5, "Alb", 1, "Romania", 96576, 2, 6, 2299, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, 130, 17990, true, 0, "Fata", null },
                    { 666, 6, "Alb", 1, "Germania", 9500, null, 6, 2298, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 249, 190, 32900, null, 0, "4x4 (automat)", null },
                    { 667, 3, "Alb", 1, null, 14596, 4, null, 1461, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 90, 7350, null, 0, null, null },
                    { 660, 1, "Alb", 1, "Romania", 103700, 5, 5, 1499, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 75, 4349, true, 0, "Fata", "WF0DXXGAKDFK37990" },
                    { 668, 5, "Alb", 1, "Romania", 60285, 2, 6, 2299, 1, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, 130, 18990, true, 0, "Spate", null },
                    { 670, 6, "Alb", 1, null, 135508, 5, 6, 1997, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 160, 12900, null, 0, "4x4 (automat)", "WF0AXXWPMADK54054" },
                    { 671, 5, "Alb", 1, "Romania", 66487, 2, 6, 2299, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, 130, 17990, true, 0, "Fata", null },
                    { 672, 6, "Rosu", 1, null, 207000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, null, 5500, null, 1, null, null },
                    { 673, 5, "Alb", 1, "Romania", 63982, 2, 6, 2299, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, 130, 17990, true, 0, "Fata", null },
                    { 674, 4, "Negru", 1, null, 212570, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 322, null, 6490, null, 0, null, null },
                    { 675, 2, "Gri", 1, "Italia", 203245, null, 4, 2000, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 140, 4990, null, 0, null, null },
                    { 676, 3, "Albastru", 1, null, 170000, 5, 4, 1753, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 125, 5450, null, 0, "Fata", "WF0EXXGBBE7U36441" },
                    { 669, 0, "Argint", 1, null, 242560, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, null, 4890, null, 1, null, null },
                    { 677, 6, "Negru", 1, "Germania", 145000, null, 4, 1900, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, 131, 5990, null, 1, "4x4 (automat)", null },
                    { 659, 3, "Negru", 1, null, 155400, 5, 4, 1995, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 177, 8650, null, 0, "Spate", "WBANX31060C048017" },
                    { 657, 1, "Alte culori", 1, "Romania", 85733, 5, 4, 1289, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, 87, 4250, true, 1, "Fata", null },
                    { 641, 2, "Albastru", 1, "Romania", 91543, 5, 5, 1560, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 95, 7450, true, 1, "Fata", null },
                    { 642, 5, "Negru", 1, null, 109380, 7, 5, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 418, 180, 24370, true, 0, "4x4 (automat)", null },
                    { 643, 1, "Albastru", 1, "Germania", 100000, 5, 5, 1600, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 10250, null, 0, "Fata", "WVWZZZAUZDW029253" },
                    { 644, 3, "Gri", 1, null, 153000, 5, 5, 1600, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 105, 8900, true, 0, "Fata", null },
                    { 645, 4, "Gri", 1, "Germania", 183000, null, 4, 1700, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 2490, null, 0, null, null },
                    { 646, 3, "Negru", 1, null, 89000, 4, 6, 2987, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 258, 59500, true, 0, "4x4 (automat)", null },
                    { 647, 5, "Alb", 1, "Austria", 155300, 5, 5, 2000, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 431, 140, 9390, true, 1, "Fata", null },
                    { 658, 3, "Negru", 1, "Germania", 143000, null, 4, 1900, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 396, null, 2790, null, 0, "Fata", null },
                    { 648, 6, "Negru", 1, "Germania", 205000, null, 4, 2198, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, 152, 7790, null, 0, "4x4 (automat)", "SALFA28C67H013275" },
                    { 650, 4, "Argint", 1, "Franta", 186000, null, 5, 1685, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, 115, 7990, null, 1, "Fata", "KMHLC81UADU055131" },
                    { 651, 6, "Alb", 1, null, 149000, null, null, 2993, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, 306, 42900, null, 1, "4x4 (automat)", null },
                    { 652, 4, "Negru", 1, "Olanda", 190000, 5, 6, 2000, 1, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 120, 9900, null, 1, "Fata", null },
                    { 653, 4, "Negru", 1, null, 270000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 6400, null, 1, null, null },
                    { 654, 6, "Negru", 1, "Belgia", 101850, 5, 5, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 8999, null, 1, "4x4-manual", null },
                    { 655, 6, "Negru", 1, "Germania", 171000, null, 5, 2000, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 163, 10670, null, 1, "4x4 (automat)", null },
                    { 656, 6, "Alb", 1, "Romania", 161000, 4, 5, 1997, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 140, 10850, true, 1, "4x4 (automat)", "WF0RXXGCDRBJ22617" },
                    { 649, 6, "Negru", 1, "Romania", 178000, null, 5, 2993, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 602, 245, 17800, true, 1, "4x4 (automat)", null },
                    { 718, 3, "Negru", 1, "Germania", 7000, 4, 6, 3956, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 216, 420, 106500, true, 0, "4x4 (automat)", null },
                    { 678, 2, "Alb", 1, null, 94029, 4, 5, 1560, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 109, 8450, null, 0, "Fata", "WF0KXXGCBKEB67661" },
                    { 680, 6, "Gri", 1, "Statele Unite ale Americii", 51000, 4, 5, 2694, 0, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 640, 331, 26000, true, 0, "Spate", null },
                    { 701, 6, "Alb", 1, null, 139900, 5, 6, 1969, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 190, 16990, null, 1, "Fata", null },
                    { 702, 3, "Gri", 1, "Olanda", 229000, 4, 4, 1896, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, 105, 3990, null, 1, "Fata", null },
                    { 703, 6, "Negru", 1, "Romania", 150500, null, null, null, 0, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 279, null, 9300, null, 1, null, null },
                    { 704, 4, "Negru", 1, "Italia", 176000, 5, 5, 1598, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 8400, true, 1, "Fata", "TMBJG7NE9F0111961" },
                    { 705, 2, "Albastru", 1, "Romania", 126048, 5, 5, 1598, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 10699, true, 0, "Fata", "WVWZZZAUZFP028697" },
                    { 706, 1, "Gri", 1, null, 70000, null, null, null, 0, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, null, 3250, null, 1, null, null },
                    { 707, 3, "Negru", 1, null, 260000, 4, 5, 1968, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 170, 13600, true, 1, "Fata", null },
                    { 700, 6, "Albastru", 1, null, 50000, null, null, null, 4, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, null, 50000, null, 1, null, null },
                    { 708, 3, "Gri", 1, "Romania", 207484, 4, null, 1968, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 11800, true, 1, "4x4 (automat)", null },
                    { 710, 4, "Albastru", 1, null, 120000, 5, null, null, 0, null, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 1100, null, 1, null, null },
                    { 711, 6, "Rosu", 1, "Romania", 25805, 5, 6, 1968, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 190, 32000, true, 0, "4x4 (automat)", "TMBLK9NS9H8014045" },
                    { 712, 3, "Maro", 1, null, 180000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 7900, null, 1, null, null },
                    { 713, 8, "Negru", 1, null, 68400, 3, null, 4961, 0, 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 179, 500, 69000, true, 0, "4x4 (automat)", "ZHWGE11S65LA02499" },
                    { 714, 6, "Gri", 1, "Germania", 168500, null, 4, 1958, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 121, 150, 6950, null, 1, "4x4-manual", null },
                    { 715, 3, "Rosu", 1, "Olanda", 189564, 4, null, 1998, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 143, 7800, null, 1, null, null },
                    { 716, 3, "Alb", 1, "Romania", 71723, 4, 6, 1197, 0, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 90, 8390, true, 0, "Fata", "VSSZZZNHZH1014222" },
                    { 709, 2, "Rosu", 1, "Germania", 92160, 4, 4, 1799, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 221, 140, 7690, null, 0, "Fata", null },
                    { 679, 7, "Albastru", 1, "Germania", 198000, 5, 5, 1968, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 408, 140, 6200, true, 0, "Fata", null },
                    { 699, 4, "Alb", 1, "Romania", 45356, 5, 6, 1461, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 7450, true, 0, "Fata", "UU17SDCH455157339" },
                    { 697, 4, "Albastru", 1, "Germania", 244221, 5, 5, 1598, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 5900, true, 0, "Fata", null },
                    { 681, 3, "Gri", 1, "Romania", 146500, null, 4, 1998, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 322, 126, 5850, true, 1, "Fata", null },
                    { 682, 3, "Albastru", 1, "Romania", 119000, 4, 5, 1596, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 7100, true, 0, "Fata", "TMBAG7NE8E0069751" },
                    { 683, 6, "Rosu", 1, null, 27000, null, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 170, 24500, null, 0, "4x4 (automat)", "WDC1569051J224795" },
                    { 684, 3, "Alb", 1, null, 147077, null, null, 2993, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 308, 29000, null, 0, null, "WBA5D71070GB53192" },
                    { 685, 4, "Negru", 1, null, 270000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 6400, null, 1, null, "TMBHE61Z9C2095865" },
                    { 686, 4, "Gri", 1, null, 210000, null, null, null, 1, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 10700, null, 1, null, null },
                    { 687, 1, "Gri", 1, "Germania", 240000, null, 5, 1785, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 264, 136, 10500, true, 1, "Fata", "WDD2462011J084167" },
                    { 698, 5, "Negru", 1, "Olanda", 210000, null, 4, 1596, 0, null, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 101, 2100, null, 0, null, null },
                    { 688, 3, "Negru", 0, null, 10, 4, 6, 2925, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 340, 125475, null, 0, "4x4 (automat)", null },
                    { 690, 3, "Gri", 1, null, 212835, 4, null, 1422, 1, null, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 70, 2950, null, 0, null, null },
                    { 691, 0, "Argint", 1, "Olanda", 177500, null, 4, 1595, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 102, 4590, null, 1, "Fata", null },
                    { 692, 3, "Gri", 1, "Germania", 141000, null, null, 1600, 0, null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 75, 850, null, 0, null, null },
                    { 693, 5, "Negru", 1, "Germania", 99900, null, 6, 1997, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 659, 180, 22496, null, 0, "4x4 (automat)", null },
                    { 694, 3, "Maro", 1, "Germania", 188000, null, 5, 1968, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 177, 15150, true, 0, "Fata", null },
                    { 695, 6, "Negru", 1, "Belgia", 160000, 5, 4, 1995, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 150, 8480, true, 1, "4x4 (automat)", null },
                    { 696, 1, "Gri", 1, "Olanda", 242471, 5, 5, 1199, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 75, 4450, null, 0, "Fata", "VSSZZZ6JZBR037506" },
                    { 689, 5, "Gri", 1, "Germania", 122300, 5, 5, 1598, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 831, 90, 8300, true, 0, "Fata", null },
                    { 798, 6, "Negru", 1, "Romania", 146000, 5, null, 1975, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 707, 140, 5500, true, 0, "Fata", null },
                    { 799, 0, "Rosu", 1, "Germania", 230000, 4, 6, 1990, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 174, 11900, true, 1, "Spate", null },
                    { 800, 6, "Maro", 1, "Romania", 79000, 5, 6, 3000, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 258, 33000, true, 1, "4x4 (automat)", null },
                    { 902, 3, "Albastru", 1, "Belgia", 220000, 4, null, 1995, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 177, 8653, null, 0, "4x4 (automat)", "WBAPP71030A618003" },
                    { 903, 3, "Negru", 1, null, 180500, null, null, 1998, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, null, 7650, null, 0, null, null },
                    { 904, 4, "Gri", 1, null, 142000, null, null, 1698, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 5450, null, 0, null, null },
                    { 905, 4, "Maro", 1, null, 217000, null, 6, 3000, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 539, 245, 14950, true, 1, "4x4 (automat)", "WAUZZZ8K6FA025489" },
                    { 906, 2, "Negru", 1, null, 176000, null, null, 1498, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 477, null, 3300, null, 0, null, null },
                    { 907, 2, "Negru", 1, null, 212000, null, 4, 1600, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, 3299, null, 0, "Fata", null },
                    { 908, 3, "Alte culori", 1, null, 182000, null, null, 5993, 0, 1, new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 726, null, 3990, null, 0, null, null },
                    { 901, 6, "Gri", 1, null, 96400, null, 6, 2400, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 190, 19999, null, 0, "4x4 (automat)", null },
                    { 909, 4, "Negru", 1, "Germania", 233000, null, 4, 1900, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 139, 150, 2999, null, 0, "Fata", null },
                    { 911, 1, "Negru", 1, "Germania", 250000, null, 4, 1200, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, null, 3390, null, 0, "Fata", null },
                    { 912, 1, "Negru", 1, "Germania", 250000, null, 4, 1200, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, null, 3390, null, 0, "Fata", null },
                    { 913, 6, "Alb", 1, "Romania", 618, 5, 6, 1332, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 159, 21500, true, 0, "Fata", "SJNFFAJ11U2422114" },
                    { 914, 2, "Negru", 1, "Germania", 270000, 5, 3, 1599, 0, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 506, 100, 1450, null, 0, "Fata", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 915, 6, "Gri", 1, "Germania", 200000, 4, 5, 1969, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 184, 12999, null, 1, "4x4 (automat)", null },
                    { 916, 4, "Albastru", 1, "Germania", 187000, 4, 4, 1800, 0, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 140, 3450, true, 1, "Fata", null },
                    { 917, 3, "Alb", 1, "Romania", 236080, 4, 5, 1500, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 2950, true, 0, "Fata", "UU1LSDJ4P44965846" },
                    { 910, 3, "Gri", 1, null, 210000, null, null, 1798, 0, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, null, 1300, null, 0, null, null },
                    { 918, 3, "Alb", 1, "Romania", 231325, 4, 5, 1500, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 2950, true, 0, "Fata", "UU1LSDJ4P44966077" },
                    { 900, 2, "Alte culori", 1, null, 215000, null, null, 1998, 0, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 1099, null, 0, null, null },
                    { 898, 2, "Albastru", 1, null, 217000, null, null, 1898, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 3550, null, 0, null, null },
                    { 882, 3, "Albastru", 1, "Germania", 161497, 5, 4, 1600, 0, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 105, 3300, null, 1, "Fata", null },
                    { 883, 6, "Argint", 1, "Polonia", 125010, 5, 4, 2000, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, 110, 3950, null, 0, "4x4-manual", null },
                    { 884, 8, "Negru", 1, "Germania", 10600, 2, 6, 2996, 0, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, 367, 99990, true, 1, "4x4 (automat)", null },
                    { 885, 2, "Alb", 0, "Romania", 3, 5, 6, 999, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 125, 13628, null, 0, "Fata", null },
                    { 886, 2, "Alb", 1, "Romania", 99000, 5, 5, 1120, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 693, 85, 5550, true, 1, "Fata", null },
                    { 887, 4, "Negru", 1, null, 230000, 4, 5, 1995, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 177, 7250, null, 0, "Spate", "WBAPX31060C019352" },
                    { 888, 3, "Negru", 1, "Austria", 181333, 4, 5, 1956, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 160, 7300, true, 0, "Fata", "W0LGS6EM6B1139214" },
                    { 899, 2, "Gri", 1, null, 173000, null, null, 1398, 0, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 3650, null, 0, null, null },
                    { 889, 3, "Argint", 1, null, 250000, 2, null, 3000, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 311, 9500, true, 1, null, null },
                    { 891, 4, "Negru", 1, null, 192000, 4, 6, 2000, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 15900, null, 1, null, null },
                    { 892, 3, "Gri", 1, null, 148826, 4, 6, 1989, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415, 110, 11990, true, 0, "Fata", "WVWZZZ16ZFM028577" },
                    { 893, 5, "Gri", 1, null, 171000, null, null, 1898, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, null, 3650, null, 0, null, null },
                    { 894, 1, "Alb", 1, "Romania", 78000, 5, 4, 1149, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 75, 3200, true, 0, "Fata", "VF1BR1JBH41604479" },
                    { 895, 1, "Negru", 1, "Belgia", 70906, 5, 6, 1422, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 427, 90, 7400, null, 1, "Fata", "WVWZZZ6RZGY119093" },
                    { 896, 1, "Verde", 1, "Romania", 1442, 5, 6, 898, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 759, 90, 12400, true, 0, "Fata", "VNVK1400160236270" },
                    { 897, 6, "Negru", 1, null, 215000, null, null, 2498, 1, 1, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, null, 4350, null, 0, null, null },
                    { 890, 6, "Negru", 1, null, 87000, null, 5, 2190, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, 150, 9500, true, 0, "4x4 (automat)", "JTMBC31VX0D010247" },
                    { 881, 3, "Negru", 1, "Austria", 235000, 5, 4, 2000, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 140, 8250, null, 1, "Fata", null },
                    { 919, 2, "Negru", 1, "Germania", 234567, 5, 4, 1700, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 101, 2650, null, 1, "Fata", null },
                    { 921, 3, "Albastru", 1, "Romania", 4500, null, 6, 999, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 8500, true, 1, "Fata", "UU1L5220461828514" },
                    { 942, 3, "Negru", 1, "Romania", 182000, null, 5, 1798, 2, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 160, 8700, true, 1, "Fata", null },
                    { 943, 0, "Albastru", 1, "Germania", 250000, null, 5, 1600, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 6700, true, 1, "Fata", null },
                    { 944, 1, "Alte culori", 1, "Germania", 128300, 5, null, 1586, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, 90, 4490, null, 1, "Fata", null },
                    { 945, 6, "Verde", 1, "Germania", 240000, null, null, 2800, 1, 0, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 767, null, 6550, null, 1, "4x4-manual", null },
                    { 946, 4, "Negru", 1, "Germania", 200000, 5, 5, 1986, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 170, 8950, null, 1, "Fata", null },
                    { 947, 6, "Alb", 1, "Romania", 42569, null, 6, 1996, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 180, 22000, true, 1, "4x4 (automat)", null },
                    { 948, 6, "Albastru", 1, "Germania", 226000, 3, 3, 2477, 1, 0, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 297, 116, 3800, null, 1, "4x4-manual", null },
                    { 941, 3, "Negru", 1, "Olanda", 188952, null, 5, 1600, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 120, 7490, null, 1, "Fata", null },
                    { 949, 0, "Alb", 1, null, 193379, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, null, 6699, null, 1, null, "WVWZZZ1KZBP080086" },
                    { 951, 4, "Gri", 1, "Germania", 295000, 5, 4, 2148, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 170, 5500, null, 1, "Spate", null },
                    { 952, 2, "Albastru", 1, "Germania", 184834, null, 5, 1598, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 110, 10750, null, 1, "Fata", "WVWZZZAUZFW090681" },
                    { 953, 5, "Alb", 1, "Germania", 210000, 5, null, 1986, 1, 1, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 441, 170, 5950, null, 0, "Fata", null },
                    { 954, 6, "Maro", 1, null, 175000, null, null, null, 1, null, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, null, 17390, null, 1, null, "WBAWZ510000M10466" },
                    { 955, 6, "Alte culori", 1, null, 91000, null, 5, 1600, 0, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, null, 6790, null, 0, null, null },
                    { 956, 6, "Negru", 1, null, 22900, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 445, null, 4950, null, 0, null, "JSAJTA44V00252575" },
                    { 957, 4, "Negru", 1, null, 272000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, null, 7450, null, 1, null, null },
                    { 950, 3, "Alb", 1, "Romania", 129800, 5, 6, 2143, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482, 136, 10500, true, 1, null, "WDD2040011A422945" },
                    { 920, 3, "Negru", 1, "Germania", 290700, null, 4, 2997, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 286, 8500, null, 1, "Spate", "WBANX91030CU47650" },
                    { 940, 5, "Alb", 1, "Germania", 197000, 2, 5, 2200, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 515, 130, 10900, true, 1, "Spate", null },
                    { 938, 3, "Gri", 1, null, 187000, null, null, 1400, 0, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, null, 3450, null, 1, "Fata", null },
                    { 922, 5, "Alb", 1, "Germania", 161000, null, 5, 2143, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 136, 10670, true, 0, "Spate", "WDF63960313869026" },
                    { 923, 2, "Negru", 1, "Romania", 75000, 5, 4, 1910, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 827, 120, 3750, true, 0, "Fata", "ZFA19800004167632" },
                    { 924, 6, "Gri", 1, null, 212500, null, null, null, 1, null, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, null, 16500, null, 1, null, null },
                    { 925, 6, "Argint", 1, "Belgia", 188300, 4, null, 2143, 1, 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 150, 6750, null, 1, "4x4 (automat)", null },
                    { 926, 6, "Maro", 1, "Germania", 176200, 4, 5, 1995, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 136, 11450, null, 1, "4x4 (automat)", null },
                    { 927, 1, "Argint", 1, "Germania", 189000, null, 6, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 160, 17000, true, 1, null, "WBA5E310X0D786239" },
                    { 928, 3, "Gri", 1, "Romania", 116000, 5, 4, 2998, 1, 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 245, 5850, true, 1, "4x4 (automat)", null },
                    { 939, 1, "Rosu", 1, "Romania", 83000, 5, 4, 1198, 0, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 60, 3900, true, 1, "Fata", "TMBAA25J4A3127316" },
                    { 929, 2, "Negru", 1, "Germania", 210000, 4, 4, 1995, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 122, 4790, true, 1, "Spate", "WBAUG31090PU02049" },
                    { 931, 6, "Rosu", 1, "Germania", 11900, 5, 6, 2993, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 300, 58318, null, 0, "4x4 (automat)", null },
                    { 932, 2, "Gri", 1, "Germania", 186000, 5, 6, 1995, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 218, 17200, true, 1, "Spate", null },
                    { 933, 3, "Alb", 1, "Romania", 305000, 4, 3, 2200, 0, 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 170, 4300, true, 1, "Spate", null },
                    { 934, 6, "Gri", 1, null, 237000, 5, 5, 1998, 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 177, 11650, null, 1, "4x4 (automat)", null },
                    { 935, 5, "Negru", 1, "Olanda", 168952, null, 5, 1600, 1, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 662, 105, 9490, null, 1, "Fata", null },
                    { 936, 6, "Alb", 1, "Romania", 65000, 5, null, 2179, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 601, 190, 26180, true, 1, "4x4 (automat)", "SALVA2BE8FH035573" },
                    { 937, 4, "Maro", 1, null, 239000, null, null, 2000, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 11900, true, 1, null, null },
                    { 930, 3, "Negru", 1, null, 18500, null, null, 2979, 0, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 450, 46000, null, 1, "Spate", null },
                    { 880, 3, "Negru", 1, "Germania", 200000, 4, null, 2993, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 245, 8900, true, 0, "4x4 (automat)", null },
                    { 879, 3, "Negru", 1, null, 178000, null, null, null, 1, null, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, null, 5900, null, 1, null, null },
                    { 878, 2, "Alb", 1, "Spania", 93000, 5, null, 1686, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 110, 4600, true, 1, "Fata", null },
                    { 821, 6, "Alb", 1, null, 180270, 5, 5, 1560, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 115, 8690, null, 0, "Fata", null },
                    { 822, 5, "Negru", 1, "Franta", 147000, 5, 5, 1561, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 632, 95, 6490, null, 0, "Fata", "WF0JXXWPBJAA33328" },
                    { 823, 3, "Negru", 1, "Germania", 30200, 4, 6, 2996, 0, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 401, 53800, null, 0, "4x4 (automat)", null },
                    { 824, 3, "Alb", 1, null, 37503, null, 6, 1950, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494, 194, 59800, true, 0, "4x4 (automat)", "WDD2383151F049713" },
                    { 825, 2, "Gri", 1, "Romania", 322400, 5, 3, 1997, 1, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 107, 1950, true, 0, "Fata", null },
                    { 826, 2, "Negru", 1, "Germania", 187000, 5, 6, 1968, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 412, 184, 13650, null, 1, "Fata", "WVWZZZAUZEW045368" },
                    { 827, 3, "Negru", 1, "Germania", 200000, null, 6, 2000, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 17400, true, 1, "Spate", null },
                    { 820, 4, "Verde", 1, "Olanda", 196000, 5, 4, 1596, 0, 0, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 101, 1690, null, 0, "Fata", null },
                    { 828, 3, "Negru", 1, "Germania", 33500, null, 6, 2925, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 286, 67150, null, 0, "4x4 (automat)", null },
                    { 830, 4, "Gri", 1, "Germania", 250000, 4, 4, 1300, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 90, 3500, true, 0, "Fata", null },
                    { 831, 5, "Rosu", 1, null, 5000, null, 6, 998, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 396, 120, 17500, null, 0, "Fata", null },
                    { 832, 3, "Negru", 1, "Germania", 41000, 4, 6, 2987, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 258, 59900, null, 0, "4x4 (automat)", null },
                    { 833, 6, "Bej", 1, "Romania", 28900, 5, 6, 2143, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 136, 26950, true, 0, "4x4 (automat)", null },
                    { 834, 3, "Alb", 1, "Germania", 194800, 4, 6, 1998, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 372, 190, 22350, true, 1, "4x4 (automat)", null },
                    { 835, 3, "Negru", 1, "Franta", 125809, 4, 5, 1995, 1, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 173, 9990, null, 0, "Fata", "VF1LTF00EUC251825" },
                    { 836, 6, "Alb", 1, "Romania", 75548, 5, 6, 1461, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 110, 11000, true, 0, "4x4-manual", null },
                    { 829, 3, "Gri", 1, "Germania", 147243, null, 4, 1598, 0, 0, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 396, 105, 2690, null, 0, "Fata", null },
                    { 837, 2, "Negru", 1, "Franta", 62616, 4, 6, 1598, 1, 0, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 110, 10990, null, 0, "Fata", "W0LBD6EK6HG005831" },
                    { 819, 4, "Gri", 1, "Romania", 233000, null, 5, 1600, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 105, 5500, true, 0, "Fata", null },
                    { 817, 1, "Alb", 1, "Germania", 125500, 3, 5, 1995, 0, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 122, 6150, true, 1, "Spate", null },
                    { 801, 2, "Alb", 1, "Romania", 185311, 4, 5, 1560, 1, 0, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 95, 5500, true, 0, "Fata", "WF0MXXGCBMDM08268" },
                    { 802, 2, "Albastru", 1, "Romania", 79200, 5, 5, 1461, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 90, 6850, true, 0, "Fata", null },
                    { 803, 6, "Alb", 1, "Germania", 26602, 5, 6, 1560, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 120, 21590, null, 0, "Fata", null },
                    { 804, 4, "Negru", 1, "Germania", 240000, 4, 4, 1900, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 139, 150, 2799, null, 0, "Fata", null },
                    { 805, 3, "Maro", 1, null, 117000, 5, 6, 1995, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 150, 16800, null, 0, "Spate", null },
                    { 806, 3, "Maro", 1, "Romania", 11139, 5, 6, 898, 0, 0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 90, 10150, true, 0, "Fata", "UU14SDL1460138874" },
                    { 807, 2, "Albastru", 1, "Romania", 86200, 5, 6, 999, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 643, 100, 8250, true, 1, "Fata", "WF05XXGCC5ER19119" },
                    { 818, 6, "Gri", 1, null, 33900, 4, 6, 2998, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, 262, 41900, true, 0, "4x4 (automat)", null },
                    { 808, 4, "Negru", 1, null, 202000, null, 5, 2000, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 184, 7800, null, 1, "Spate", null },
                    { 810, 1, "Albastru", 1, "Romania", 63000, 5, 6, 1229, 0, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 129, 69, 7400, true, 0, "Fata", null },
                    { 811, 3, "Gri", 1, "Romania", 187000, 4, 4, 1896, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 105, 5100, true, 1, "Fata", "TMBBS21ZX8C002750" },
                    { 812, 6, "Gri", 1, null, 160980, 5, 5, 1560, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 115, 7990, null, 0, "Fata", null },
                    { 813, 6, "Alb", 1, "Romania", 124460, 4, 5, 2231, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 121, 164, 12000, true, 0, "4x4 (automat)", "W0LLH6EH7FB061428" },
                    { 814, 0, "Albastru", 1, "Romania", 228, null, 5, 1394, 0, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 430, 160, 7299, true, 1, "Fata", null },
                    { 815, 6, "Gri", 1, "Germania", 239000, null, 3, 1951, 1, 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 599, null, 4250, null, 1, "4x4 (automat)", null },
                    { 816, 5, "Alb", 1, "Germania", 36663, 2, 6, 1968, 1, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 404, 140, 19999, true, 0, "Spate", "WV1ZZZ2EZG6060305" },
                    { 809, 4, "Negru", 1, null, 187000, 4, 4, 1986, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 140, 6450, null, 0, "Fata", null },
                    { 838, 4, "Gri", 1, null, 170000, null, null, null, 1, null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, null, 7300, null, 1, null, "VF1KZ0C0H54955909" },
                    { 839, 6, "Albastru", 1, "Germania", 168000, 5, 4, 2000, 1, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 136, 7999, null, 0, "4x4 (automat)", null },
                    { 840, 6, "Gri", 1, "Germania", 186767, 4, 6, 2143, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 504, 170, 19990, null, 0, "4x4 (automat)", "WDC2049971G414179" },
                    { 862, 2, "Alb", 1, null, 155000, null, null, 1582, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 110, 9500, null, 0, "Fata", null },
                    { 863, 3, "Negru", 1, null, 295000, null, null, 1997, 1, 0, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, 136, 2050, true, 1, "Fata", null },
                    { 864, 5, "Negru", 1, "Germania", 190000, 5, 5, 2179, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 648, 147, 11900, true, 1, "Fata", "WF0MXXGBWMDU02299" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Records",
                columns: new[] { "Id", "Body", "Color", "Condition", "CountryOfOrigin", "Distance", "DoorsNo", "EmissionStandard", "EngineSize", "Fuel", "GearBox", "ManufactureDate", "ModelId", "Power", "Price", "Registered", "Seller", "Transmission", "VIN" },
                values: new object[,]
                {
                    { 865, 6, "Negru", 1, "Germania", 179000, null, 6, 1968, 1, 1, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 181, 16190, null, 1, "Fata", null },
                    { 866, 4, "Gri", 1, null, 174386, 4, null, 1968, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 16900, null, 0, "Fata", "WVWZZZ3CZGP016798" },
                    { 867, 6, "Maro", 1, "Germania", 223000, null, 5, 2967, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 322, 29800, null, 0, "4x4 (automat)", "WP1ZZZ92ZDLA31939" },
                    { 868, 2, "Negru", 1, null, 189300, 4, 5, 1598, 1, 0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 115, 8250, null, 1, "Fata", "YV1MV8481E2120658" },
                    { 861, 4, "Alb", 1, "Germania", 190000, null, 6, 2967, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 545, 272, 22500, true, 1, "4x4 (automat)", "WAUZZZ4G3FN095042" },
                    { 869, 5, "Auriu", 1, "Franta", 200000, 5, 4, 1461, 1, 0, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 105, 2800, null, 0, "Fata", "VF1JMSE0639874590" },
                    { 871, 3, "Maro", 1, "Germania", 59000, null, 6, 1995, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 190, 39500, null, 1, null, null },
                    { 872, 0, "Alte culori", 1, "Germania", 176000, null, 5, 1997, 1, 0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 534, 140, 6499, true, 1, "Fata", "Wauzzzbp7ba073573" },
                    { 873, 3, "Gri", 1, null, 2200, 4, 6, 1998, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 421, 150, 31900, null, 0, "Fata", null },
                    { 874, 4, "Auriu", 1, "Romania", 88400, 5, null, 1570, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 110, 6300, true, 0, "Fata", null },
                    { 875, 5, "Gri", 1, "Italia", 34980, 4, 6, 2143, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 136, 25400, true, 0, "Spate", "WDF44770313196400" },
                    { 876, 3, "Rosu", 1, "Franta", 160000, 4, 4, 1390, 2, 0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 75, 3490, null, 0, "Fata", "UU1LSDAER42858643" },
                    { 877, 6, "Alb", 1, "Germania", 200000, 4, 5, 2987, 1, 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 258, 25900, true, 0, "4x4 (automat)", null },
                    { 870, 4, "Albastru", 1, "Belgia", 203753, 5, 4, 1698, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 110, 3599, null, 0, "Fata", "W0L0AHL3592074059" },
                    { 860, 6, "Alb", 1, "Franta", 173500, 5, 5, 1560, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 112, 6990, null, 0, "Fata", "VF30U9HR8CS144205" },
                    { 859, 6, "Argint", 1, null, 233000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, null, 19500, null, 1, null, null },
                    { 858, 1, "Gri", 1, null, 255000, null, null, null, 0, null, new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, null, 5999, null, 1, null, null },
                    { 841, 3, "Negru", 1, "Germania", 29968, 4, 6, 2987, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 286, 65500, null, 0, "4x4 (automat)", null },
                    { 842, 2, "Albastru", 1, null, 14000, 5, null, 1248, 0, 0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 693, 85, 8300, null, 0, "Fata", null },
                    { 843, 1, "Negru", 1, null, 192000, 5, 5, 1968, 1, 0, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 143, 5990, null, 0, "Fata", "VSSZZZ3RZ9R002939" },
                    { 844, 6, "Maro", 1, "Germania", 125314, 5, 6, 1968, 1, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 439, 177, 18900, true, 0, "4x4 (automat)", "WVGZZZ5NZFW063158" },
                    { 845, 4, "Gri", 1, null, 140000, null, null, null, 1, null, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, null, 8700, null, 0, null, null },
                    { 846, 3, "Alte culori", 1, "Germania", 168000, 4, 5, 2993, 1, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 245, 15470, true, 0, "4x4 (automat)", null },
                    { 847, 6, "Gri", 1, "Romania", 56693, 5, 6, 2143, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 501, 136, 24500, true, 0, "4x4 (automat)", null },
                    { 848, 3, "Alb", 1, "Germania", 180000, 4, 5, 1984, 0, 1, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 542, 180, 11700, true, 0, "Fata", null },
                    { 849, 3, "Negru", 1, "Germania", 26775, 4, 6, 2925, 1, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 509, 286, 63700, null, 0, "4x4 (automat)", null },
                    { 850, 1, "Albastru", 1, null, 33000, null, null, null, 0, null, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 693, null, 5500, null, 0, null, null },
                    { 851, 6, "Negru", 1, "Romania", 40906, 5, 6, 2987, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 42990, true, 0, "4x4 (automat)", null },
                    { 852, 2, "Rosu", 1, null, 30000, 5, 6, 1248, 0, 0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 693, 85, 9000, null, 0, "Fata", null },
                    { 853, 3, "Gri", 1, "Germania", 103640, 5, 6, 1995, 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 150, 17290, null, 0, "Fata", "TMBAH7NP6G7010187" },
                    { 854, 3, "Auriu", 1, "Germania", 259000, 4, 5, 2993, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 245, 13400, true, 0, "Spate", null },
                    { 855, 1, "Argint", 1, null, 168000, null, 5, 1968, 1, 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, 170, 9480, null, 1, "Fata", null },
                    { 856, 6, "Albastru", 1, "Romania", 38500, 5, 6, 2987, 1, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 503, 258, 42990, true, 0, "4x4 (automat)", null },
                    { 857, 4, "Alb", 1, "Germania", 207000, 4, 5, 1600, 1, 0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410, 105, 5900, true, 0, "Fata", null },
                    { 1279, 3, "Alb", 1, null, 206345, null, null, null, 1, null, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, null, 6300, null, 1, null, null },
                    { 2560, 2, "Argint", 1, "Austria", 198300, 5, 4, 1560, 1, 0, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 90, 2490, null, 0, "Fata", "VF7LC9HXC74406807" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Features",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1513);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1515);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1532);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1593);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1646);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1647);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1648);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1649);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1655);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1656);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1658);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1660);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1665);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1666);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1667);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1668);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1669);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1670);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1673);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1674);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1675);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1676);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1677);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1678);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1679);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1681);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1682);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1685);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1686);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1688);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1690);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1691);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1712);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1713);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1715);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1716);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1717);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1718);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1724);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1725);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1727);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1728);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1729);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1731);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1733);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1736);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1738);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1739);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1741);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1742);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1743);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1744);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1745);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1746);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1748);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1749);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1751);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1754);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1755);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1756);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1757);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1758);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1759);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1761);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1762);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1765);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1766);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1767);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1768);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1770);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1771);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1772);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1773);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1774);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1775);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1776);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1777);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1780);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1785);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1787);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1788);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1790);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1792);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1793);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1798);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1799);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1808);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1814);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1816);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1818);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1819);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1824);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1825);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1826);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1827);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1829);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1832);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1833);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1834);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1837);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1838);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1841);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1842);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1843);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1844);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1845);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1847);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1848);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1849);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1850);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1851);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1853);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1854);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1855);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1864);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1870);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1875);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1896);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1897);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1898);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1899);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1911);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1912);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1913);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1914);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1915);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1916);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1917);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1918);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1919);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1920);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1921);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1922);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1923);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1924);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1926);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1927);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1928);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1929);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1930);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1931);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1932);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1933);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1934);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1935);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1936);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1937);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1938);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1939);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1940);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1941);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1942);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1943);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1944);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1945);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1946);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1947);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1948);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1949);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1950);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1951);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1952);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1953);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1955);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1956);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1957);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1958);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1959);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1960);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1961);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1962);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1963);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1964);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1965);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1967);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1968);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1969);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1970);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1971);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1972);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1973);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1974);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1975);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1976);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1977);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1978);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1979);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1980);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1981);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1982);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1983);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1984);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1985);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1986);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1987);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1988);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1989);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1990);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1991);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1994);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1995);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1996);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1997);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1998);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 1999);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2062);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2063);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2064);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2065);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2066);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2067);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2068);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2069);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2070);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2072);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2075);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2078);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2080);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2081);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2082);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2083);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2084);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2086);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2087);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2088);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2089);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2093);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2096);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2098);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2099);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2104);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2108);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2109);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2113);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2114);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2115);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2116);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2117);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2119);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2121);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2122);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2123);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2124);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2125);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2126);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2127);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2128);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2129);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2130);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2131);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2132);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2133);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2134);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2136);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2137);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2138);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2139);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2140);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2141);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2142);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2143);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2144);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2145);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2146);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2147);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2148);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2149);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2150);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2151);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2152);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2153);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2154);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2155);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2156);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2157);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2158);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2159);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2160);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2161);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2162);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2163);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2164);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2165);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2166);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2167);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2168);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2169);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2170);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2171);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2172);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2173);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2174);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2175);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2176);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2177);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2178);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2179);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2180);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2181);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2182);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2183);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2184);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2185);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2186);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2187);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2188);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2189);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2190);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2191);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2192);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2193);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2194);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2195);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2196);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2197);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2198);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2199);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2200);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2201);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2202);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2203);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2204);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2205);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2206);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2207);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2208);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2209);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2210);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2211);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2212);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2213);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2214);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2215);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2216);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2217);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2218);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2219);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2220);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2221);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2222);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2223);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2224);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2225);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2226);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2227);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2228);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2229);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2230);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2231);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2232);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2233);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2234);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2235);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2236);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2237);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2238);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2239);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2240);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2241);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2242);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2243);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2244);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2245);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2246);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2247);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2248);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2249);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2250);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2251);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2252);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2253);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2254);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2255);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2256);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2257);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2258);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2259);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2260);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2261);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2262);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2263);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2264);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2265);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2266);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2267);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2268);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2269);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2270);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2271);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2272);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2273);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2274);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2275);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2276);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2277);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2278);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2279);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2280);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2281);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2282);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2283);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2284);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2285);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2286);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2287);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2288);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2289);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2290);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2291);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2292);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2293);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2294);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2295);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2296);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2297);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2298);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2299);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2300);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2301);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2302);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2303);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2304);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2305);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2306);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2307);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2308);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2309);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2310);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2311);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2312);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2313);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2314);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2315);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2316);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2317);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2318);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2319);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2320);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2321);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2322);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2323);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2324);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2325);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2326);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2327);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2328);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2329);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2330);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2331);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2332);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2333);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2334);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2335);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2336);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2337);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2338);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2339);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2340);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2341);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2342);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2343);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2344);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2345);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2346);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2347);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2348);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2349);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2350);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2351);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2352);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2353);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2354);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2355);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2356);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2357);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2358);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2359);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2360);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2361);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2362);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2363);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2364);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2365);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2366);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2367);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2368);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2369);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2370);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2371);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2372);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2373);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2374);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2375);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2376);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2377);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2378);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2379);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2380);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2381);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2382);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2383);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2384);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2385);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2386);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2387);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2388);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2389);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2390);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2391);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2392);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2393);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2394);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2395);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2396);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2397);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2398);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2399);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2400);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2401);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2402);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2403);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2404);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2405);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2406);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2407);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2408);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2409);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2410);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2411);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2412);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2413);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2414);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2415);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2416);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2417);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2418);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2419);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2420);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2421);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2422);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2423);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2424);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2425);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2426);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2427);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2428);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2429);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2430);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2431);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2432);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2433);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2434);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2435);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2436);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2437);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2438);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2439);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2440);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2441);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2442);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2443);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2444);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2445);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2446);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2447);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2448);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2449);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2450);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2451);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2452);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2453);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2454);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2455);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2456);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2457);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2458);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2459);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2460);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2461);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2462);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2463);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2464);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2465);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2466);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2467);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2468);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2469);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2470);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2471);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2472);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2473);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2474);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2475);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2476);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2477);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2478);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2479);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2480);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2481);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2482);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2483);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2484);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2485);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2486);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2487);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2488);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2489);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2490);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2491);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2492);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2493);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2494);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2495);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2496);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2497);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2498);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2499);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2500);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2501);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2502);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2503);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2504);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2505);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2506);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2507);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2508);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2509);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2510);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2511);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2512);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2513);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2514);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2515);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2516);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2517);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2518);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2519);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2520);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2521);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2522);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2523);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2524);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2525);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2526);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2527);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2528);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2529);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2530);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2531);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2532);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2533);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2534);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2535);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2536);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2537);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2538);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2539);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2540);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2541);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2542);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2543);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2544);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2545);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2546);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2547);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2548);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2549);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2550);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2551);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2552);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2553);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2554);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2555);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2556);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2557);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2558);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2559);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Records",
                keyColumn: "Id",
                keyValue: 2560);
        }
    }
}
