using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class BrandsAndModelsEntryData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Seat" },
                    { 22, "Audi" },
                    { 23, "Kia" },
                    { 24, "Land Rover" },
                    { 25, "Dodge" },
                    { 26, "Chrysler" },
                    { 27, "Ford" },
                    { 28, "Hummer" },
                    { 21, "Saab" },
                    { 29, "Hyundai" },
                    { 31, "Jaguar" },
                    { 32, "Jeep" },
                    { 33, "Nissan" },
                    { 34, "Volvo" },
                    { 35, "Daewoo" },
                    { 36, "Fiat" },
                    { 37, "Mini" },
                    { 30, "Infiniti" },
                    { 38, "Rover" },
                    { 20, "Mercedes-Benz" },
                    { 18, "Volkswagen" },
                    { 2, "Renault" },
                    { 3, "Peugeot" },
                    { 4, "Dacia" },
                    { 5, "Citroën" },
                    { 6, "Opel" },
                    { 7, "Alfa Romeo" },
                    { 8, "Škoda" },
                    { 19, "Suzuki" },
                    { 9, "Chevrolet" },
                    { 11, "Honda" },
                    { 12, "Subaru" },
                    { 13, "Mazda" },
                    { 14, "Mitsubishi" },
                    { 15, "Lexus" },
                    { 16, "Toyota" },
                    { 17, "BMW" },
                    { 10, "Porsche" },
                    { 39, "Smart" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Models",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Alhambra" },
                    { 560, 22, "S3/S3 Sportback" },
                    { 561, 22, "S4 Cabriolet" },
                    { 562, 22, "S4/S4 Avant" },
                    { 563, 22, "S5/S5 Cabriolet" },
                    { 564, 22, "S6/RS6" },
                    { 565, 22, "S7" },
                    { 566, 22, "S8" },
                    { 567, 22, "SQ5" },
                    { 568, 22, "TT Coupé" },
                    { 569, 22, "TT Roadster" },
                    { 570, 22, "TTS" },
                    { 571, 23, "Avella" },
                    { 572, 23, "Besta" },
                    { 573, 23, "Carens" },
                    { 574, 23, "Carnival" },
                    { 575, 23, "Cee`d" },
                    { 576, 23, "Cee`d SW" },
                    { 577, 23, "Cerato" },
                    { 578, 23, "K 2500" },
                    { 579, 23, "Magentis" },
                    { 580, 23, "Opirus" },
                    { 581, 23, "Optima" },
                    { 582, 23, "Picanto" },
                    { 559, 22, "RS7" },
                    { 558, 22, "RS6 Avant" },
                    { 557, 22, "RS5" },
                    { 556, 22, "RS4/RS4 Avant" },
                    { 532, 22, "A1" },
                    { 533, 22, "A2" },
                    { 534, 22, "A3" },
                    { 535, 22, "A3 Cabriolet" },
                    { 536, 22, "A3 Limuzina" },
                    { 537, 22, "A3 Sportback" },
                    { 538, 22, "A4" },
                    { 539, 22, "A4 Allroad" },
                    { 540, 22, "A4 Avant" },
                    { 541, 22, "A4 Cabriolet" },
                    { 542, 22, "A5" },
                    { 583, 23, "Pregio" },
                    { 543, 22, "A5 Cabriolet" },
                    { 545, 22, "A6" },
                    { 546, 22, "A6 Allroad" },
                    { 547, 22, "A6 Avant" },
                    { 548, 22, "A7" },
                    { 549, 22, "A8" },
                    { 550, 22, "A8 Long" },
                    { 551, 22, "Q3" },
                    { 552, 22, "Q5" },
                    { 553, 22, "Q7" },
                    { 554, 22, "R8" },
                    { 555, 22, "RS4 Cabriolet" },
                    { 544, 22, "A5 Sportback" },
                    { 584, 23, "Pride" },
                    { 585, 23, "Pro Cee`d" },
                    { 586, 23, "Rio" },
                    { 615, 26, "300 C Touring" },
                    { 616, 26, "300 M" },
                    { 617, 26, "Crossfire" },
                    { 618, 26, "Grand Voyager" },
                    { 619, 26, "LHS" },
                    { 620, 26, "Neon" },
                    { 621, 26, "Pacifica" },
                    { 622, 26, "Plymouth" },
                    { 623, 26, "PT Cruiser" },
                    { 624, 26, "Sebring" },
                    { 625, 26, "Sebring Convertible" },
                    { 614, 26, "300 C" },
                    { 626, 26, "Stratus" },
                    { 628, 26, "Town & Country" },
                    { 629, 26, "Voyager" },
                    { 630, 27, "Aerostar" },
                    { 631, 27, "B-Max" },
                    { 632, 27, "C-Max" },
                    { 633, 27, "Cortina" },
                    { 634, 27, "Cougar" },
                    { 635, 27, "Edge" },
                    { 636, 27, "Escort" },
                    { 637, 27, "Escort Cabrio" },
                    { 638, 27, "Escort kombi" },
                    { 627, 26, "Stratus Cabrio" },
                    { 531, 22, "90" },
                    { 613, 25, "Viper" },
                    { 611, 25, "RAM" },
                    { 587, 23, "Rio Combi" },
                    { 588, 23, "Rio sedan" },
                    { 589, 23, "Sephia" },
                    { 590, 23, "Shuma" },
                    { 591, 23, "Sorento" },
                    { 592, 23, "Soul" },
                    { 593, 23, "Sportage" },
                    { 594, 23, "Venga" },
                    { 595, 24, "109" },
                    { 596, 24, "Defender" },
                    { 597, 24, "Discovery" },
                    { 612, 25, "Stealth" },
                    { 598, 24, "Discovery Sport" },
                    { 600, 24, "Range Rover" },
                    { 601, 24, "Range Rover Evoque" },
                    { 602, 24, "Range Rover Sport" },
                    { 603, 25, "Avenger" },
                    { 604, 25, "Caliber" },
                    { 605, 25, "Challenger" },
                    { 606, 25, "Charger" },
                    { 607, 25, "Grand Caravan" },
                    { 608, 25, "Journey" },
                    { 609, 25, "Magnum" },
                    { 610, 25, "Nitro" },
                    { 599, 24, "Freelander" },
                    { 530, 22, "80 Cabrio" },
                    { 529, 22, "80 Avant" },
                    { 528, 22, "80" },
                    { 448, 19, "Jimny" },
                    { 449, 19, "Kizashi" },
                    { 450, 19, "Liana" },
                    { 451, 19, "Samurai" },
                    { 452, 19, "Splash" },
                    { 453, 19, "Swift" },
                    { 454, 19, "SX4" },
                    { 455, 19, "SX4 Sedan" },
                    { 456, 19, "Vitara" },
                    { 457, 19, "Wagon R+" },
                    { 458, 20, "100 D" },
                    { 447, 19, "Ignis" },
                    { 459, 20, "115" },
                    { 461, 20, "126" },
                    { 462, 20, "190" },
                    { 463, 20, "190 D" },
                    { 464, 20, "190 E" },
                    { 465, 20, "200 - 300" },
                    { 466, 20, "200 D" },
                    { 467, 20, "200 E" },
                    { 468, 20, "210 Van" },
                    { 469, 20, "210 kombi" },
                    { 470, 20, "310 Van" },
                    { 471, 20, "310 kombi" },
                    { 460, 20, "124" },
                    { 472, 20, "230 - 300 CE Coupé" },
                    { 446, 19, "Grand Vitara XL-7" },
                    { 444, 19, "Baleno kombi" },
                    { 420, 18, "New Beetle Cabrio" },
                    { 421, 18, "Passat" },
                    { 422, 18, "Passat Alltrack" },
                    { 423, 18, "Passat CC" },
                    { 424, 18, "Passat Variant" },
                    { 425, 18, "Passat Variant Van" },
                    { 426, 18, "Phaeton" },
                    { 427, 18, "Polo" },
                    { 428, 18, "Polo Van" },
                    { 429, 18, "Polo Variant" },
                    { 430, 18, "Scirocco" },
                    { 445, 19, "Grand Vitara" },
                    { 431, 18, "Sharan" },
                    { 433, 18, "T4 Caravelle" },
                    { 434, 18, "T4 Multivan" },
                    { 435, 18, "T5" },
                    { 436, 18, "T5 Caravelle" },
                    { 437, 18, "T5 Multivan" },
                    { 438, 18, "T5 Transporter Shuttle" },
                    { 439, 18, "Tiguan" },
                    { 440, 18, "Touareg" },
                    { 441, 18, "Touran" },
                    { 442, 19, "Alto" },
                    { 443, 19, "Baleno" },
                    { 432, 18, "T4" },
                    { 639, 27, "Explorer" },
                    { 473, 20, "260 - 560 SE" },
                    { 475, 20, "500 - 600 SEC Coupé" },
                    { 504, 20, "GLK" },
                    { 505, 20, "Trieda M" },
                    { 506, 20, "MB 100" },
                    { 507, 20, "Trieda R" },
                    { 508, 20, "Trieda S" },
                    { 509, 20, "S" },
                    { 510, 20, "S Coupé" },
                    { 511, 20, "SL" },
                    { 512, 20, "SLC" },
                    { 513, 20, "SLK" },
                    { 514, 20, "SLR" },
                    { 503, 20, "GLE" },
                    { 515, 20, "Sprinter" },
                    { 517, 21, "9-3 Cabriolet" },
                    { 518, 21, "9-3 Coupé" },
                    { 519, 21, "9-3 SportCombi" },
                    { 520, 21, "9-5" },
                    { 521, 21, "9-5 SportCombi" },
                    { 522, 21, "900" },
                    { 523, 21, "900 C" },
                    { 524, 21, "900 C Turbo" },
                    { 525, 21, "9000" },
                    { 526, 22, "100" },
                    { 527, 22, "100 Avant" },
                    { 516, 21, "9-3" },
                    { 474, 20, "260 - 560 SEL" },
                    { 502, 20, "GLC" },
                    { 500, 20, "GL" },
                    { 476, 20, "Trieda A" },
                    { 477, 20, "A" },
                    { 478, 20, "A L" },
                    { 479, 20, "AMG GT" },
                    { 480, 20, "Trieda B" },
                    { 481, 20, "Trieda C" },
                    { 482, 20, "C" },
                    { 483, 20, "C Sportcoupé" },
                    { 484, 20, "C T" },
                    { 485, 20, "Citan" },
                    { 486, 20, "CL" },
                    { 501, 20, "GLA" },
                    { 487, 20, "CL" },
                    { 489, 20, "CLC" },
                    { 490, 20, "CLK Cabrio" },
                    { 491, 20, "CLK Coupé" },
                    { 492, 20, "CLS" },
                    { 493, 20, "Trieda E" },
                    { 494, 20, "E" },
                    { 495, 20, "E Cabrio" },
                    { 496, 20, "E Coupé" },
                    { 497, 20, "E T" },
                    { 498, 20, "Trieda G" },
                    { 499, 20, "G Cabrio" },
                    { 488, 20, "CLA" },
                    { 640, 27, "F-150" },
                    { 641, 27, "F-250" },
                    { 642, 27, "Fiesta" },
                    { 813, 35, "Matiz" },
                    { 814, 35, "Nexia" },
                    { 815, 35, "Nubira" },
                    { 816, 35, "Nubira kombi" },
                    { 817, 35, "Racer" },
                    { 818, 35, "Tacuma" },
                    { 819, 35, "Tico" },
                    { 820, 36, "1100" },
                    { 821, 36, "126" },
                    { 822, 36, "500" },
                    { 823, 36, "500L" },
                    { 812, 35, "Lublin" },
                    { 824, 36, "500X" },
                    { 826, 36, "Barchetta" },
                    { 827, 36, "Brava" },
                    { 828, 36, "Cinquecento" },
                    { 829, 36, "Coupé" },
                    { 830, 36, "Croma" },
                    { 831, 36, "Doblo" },
                    { 832, 36, "Doblo Cargo" },
                    { 833, 36, "Doblo Cargo Combi" },
                    { 834, 36, "Ducato" },
                    { 835, 36, "Ducato Van" },
                    { 836, 36, "Ducato Kombi" },
                    { 825, 36, "850" },
                    { 837, 36, "Ducato Podvozok" },
                    { 811, 35, "Leganza" },
                    { 809, 35, "Lacetti" },
                    { 762, 33, "Note" },
                    { 763, 33, "NP300 Pickup" },
                    { 764, 33, "NV200" },
                    { 765, 33, "NV400" },
                    { 766, 33, "Pathfinder" },
                    { 767, 33, "Patrol" },
                    { 768, 33, "Patrol GR" },
                    { 769, 33, "Pickup" },
                    { 770, 33, "Pixo" },
                    { 771, 33, "Primastar" },
                    { 772, 33, "Primastar Combi" },
                    { 810, 35, "Lanos" },
                    { 773, 33, "Primera" },
                    { 775, 33, "Pulsar" },
                    { 776, 33, "Qashqai" },
                    { 777, 33, "Serena" },
                    { 778, 33, "Sunny" },
                    { 779, 33, "Terrano" },
                    { 780, 33, "Tiida" },
                    { 781, 33, "Trade" },
                    { 782, 33, "Vanette Cargo" },
                    { 783, 33, "X-Trail" },
                    { 807, 35, "Espero" },
                    { 808, 35, "Kalos" },
                    { 774, 33, "Primera Combi" },
                    { 761, 33, "Navara" },
                    { 838, 36, "Florino" },
                    { 840, 36, "Freemont" },
                    { 869, 37, "Cooper Cabrio" },
                    { 870, 37, "Cooper Clubman" },
                    { 871, 37, "Cooper D" },
                    { 872, 37, "Cooper D Clubman" },
                    { 873, 37, "Cooper S" },
                    { 874, 37, "Cooper S Cabrio" },
                    { 875, 37, "Cooper S Clubman" },
                    { 876, 37, "Countryman" },
                    { 877, 37, "Mini One" },
                    { 878, 37, "One D" },
                    { 879, 38, "200" },
                    { 868, 37, "Cooper" },
                    { 880, 38, "214" },
                    { 882, 38, "25" },
                    { 883, 38, "400" },
                    { 884, 38, "414" },
                    { 885, 38, "416" },
                    { 886, 38, "620" },
                    { 887, 38, "75" },
                    { 888, 39, "Cabrio" },
                    { 889, 39, "City-Coupé" },
                    { 890, 39, "Compact Pulse" },
                    { 891, 39, "Forfour" },
                    { 892, 39, "Fortwo cabrio" },
                    { 881, 38, "218" },
                    { 839, 36, "Florino Combi" },
                    { 867, 36, "X1/9" },
                    { 865, 36, "Ulysse" },
                    { 841, 36, "Grande Punto" },
                    { 842, 36, "Idea" },
                    { 843, 36, "Linea" },
                    { 844, 36, "Marea" },
                    { 845, 36, "Marea Weekend" },
                    { 846, 36, "Multipla" },
                    { 847, 36, "Palio Weekend" },
                    { 848, 36, "Panda" },
                    { 849, 36, "Panda Van" },
                    { 850, 36, "Punto" },
                    { 851, 36, "Punto Cabriolet" },
                    { 866, 36, "Uno" },
                    { 852, 36, "Punto Evo" },
                    { 854, 36, "Qubo" },
                    { 855, 36, "Scudo" },
                    { 856, 36, "Scudo Van" },
                    { 857, 36, "Scudo Kombi" },
                    { 858, 36, "Sedici" },
                    { 859, 36, "Seicento" },
                    { 860, 36, "Stilo" },
                    { 861, 36, "Stilo Multiwagon" },
                    { 862, 36, "Strada" },
                    { 863, 36, "Talento" },
                    { 864, 36, "Tipo" },
                    { 853, 36, "Punto Van" },
                    { 419, 18, "New Beetle" },
                    { 760, 33, "Murano" },
                    { 758, 33, "Maxima QX" },
                    { 671, 27, "Transit Tourneo" },
                    { 672, 27, "Transit Valnik" },
                    { 673, 27, "Transit Van" },
                    { 674, 27, "Transit Van 350" },
                    { 675, 27, "Windstar" },
                    { 676, 28, "H2" },
                    { 677, 28, "H3" },
                    { 678, 29, "Accent" },
                    { 679, 29, "Atos" },
                    { 680, 29, "Atos Prime" },
                    { 681, 29, "Coupé" },
                    { 670, 27, "Transit kombi" },
                    { 682, 29, "Elantra" },
                    { 684, 29, "Genesis" },
                    { 685, 29, "Getz" },
                    { 686, 29, "Grandeur" },
                    { 687, 29, "H 350" },
                    { 688, 29, "H1" },
                    { 689, 29, "H1 Bus" },
                    { 690, 29, "H1 Van" },
                    { 691, 29, "H200" },
                    { 692, 29, "i10" },
                    { 693, 29, "i20" },
                    { 694, 29, "i30" },
                    { 683, 29, "Galloper" },
                    { 695, 29, "i30 CW" },
                    { 669, 27, "Transit Custom" },
                    { 667, 27, "Transit Connect LWB" },
                    { 643, 27, "Focus" },
                    { 644, 27, "Focus C-Max" },
                    { 645, 27, "Focus CC" },
                    { 646, 27, "Focus kombi" },
                    { 647, 27, "Fusion" },
                    { 648, 27, "Galaxy" },
                    { 649, 27, "Grand C-Max" },
                    { 650, 27, "Ka" },
                    { 651, 27, "Kuga" },
                    { 652, 27, "Maverick" },
                    { 653, 27, "Mondeo" },
                    { 668, 27, "Transit Courier" },
                    { 654, 27, "Mondeo Combi" },
                    { 656, 27, "Orion" },
                    { 657, 27, "Puma" },
                    { 658, 27, "Ranger" },
                    { 659, 27, "S-Max" },
                    { 660, 27, "Sierra" },
                    { 661, 27, "Street Ka" },
                    { 662, 27, "Tourneo Connect" },
                    { 663, 27, "Tourneo Custom" },
                    { 664, 27, "Transit" },
                    { 665, 27, "Transit" },
                    { 666, 27, "Transit Bus" },
                    { 655, 27, "Mustang" },
                    { 759, 33, "Micra" },
                    { 696, 29, "i40" },
                    { 698, 29, "ix20" },
                    { 727, 31, "XJ6" },
                    { 728, 31, "XJ8" },
                    { 729, 31, "XJ8" },
                    { 730, 31, "XJR" },
                    { 731, 31, "XK" },
                    { 732, 31, "XK8 Convertible" },
                    { 733, 31, "XKR" },
                    { 734, 31, "XKR Convertible" },
                    { 742, 33, "100 NX" },
                    { 743, 33, "200 SX" },
                    { 744, 33, "350 Z" },
                    { 726, 31, "XJ12" },
                    { 745, 33, "350 Z Roadster" },
                    { 747, 33, "Almera" },
                    { 748, 33, "Almera Tino" },
                    { 749, 33, "Cabstar E - T" },
                    { 750, 33, "Cabstar TL2 Valnik" },
                    { 751, 33, "e-NV200" },
                    { 752, 33, "GT-R" },
                    { 753, 33, "Insterstar" },
                    { 754, 33, "Juke" },
                    { 755, 33, "King Cab" },
                    { 756, 33, "Leaf" },
                    { 757, 33, "Maxima" },
                    { 746, 33, "370 Z" },
                    { 697, 29, "i40 CW" },
                    { 725, 31, "XJ" },
                    { 723, 31, "XE" },
                    { 699, 29, "ix35" },
                    { 700, 29, "ix55" },
                    { 701, 29, "Lantra" },
                    { 702, 29, "Matrix" },
                    { 703, 29, "Santa Fe" },
                    { 704, 29, "Sonata" },
                    { 705, 29, "Terracan" },
                    { 706, 29, "Trajet" },
                    { 707, 29, "Tucson" },
                    { 708, 29, "Veloster" },
                    { 709, 30, "EX" },
                    { 724, 31, "XF" },
                    { 710, 30, "FX" },
                    { 712, 30, "G Coupé" },
                    { 713, 30, "M" },
                    { 714, 30, "Q" },
                    { 715, 30, "QX" },
                    { 716, 31, "Daimler" },
                    { 717, 31, "F-Pace" },
                    { 718, 31, "F-Type" },
                    { 719, 31, "S-Type" },
                    { 720, 31, "Sovereign" },
                    { 721, 31, "X-Type" },
                    { 722, 31, "X-type Estate" },
                    { 711, 30, "G" },
                    { 893, 39, "Fortwo coupé" },
                    { 418, 18, "Multivan" },
                    { 416, 18, "LT" },
                    { 119, 6, "Agila" },
                    { 120, 6, "Ampera" },
                    { 121, 6, "Antara" },
                    { 122, 6, "Astra" },
                    { 123, 6, "Astra cabrio" },
                    { 124, 6, "Astra caravan" },
                    { 125, 6, "Astra coupé" },
                    { 126, 6, "Calibra" },
                    { 127, 6, "Campo" },
                    { 128, 6, "Cascada" },
                    { 129, 6, "Corsa" },
                    { 130, 6, "Frontera" },
                    { 131, 6, "Insignia" },
                    { 132, 6, "Insignia kombi" },
                    { 133, 6, "Kadett" },
                    { 134, 6, "Meriva" },
                    { 135, 6, "Mokka" },
                    { 136, 6, "Movano" },
                    { 137, 6, "Omega" },
                    { 138, 6, "Signum" },
                    { 139, 6, "Vectra" },
                    { 140, 6, "Vectra Caravan" },
                    { 141, 6, "Vivaro" },
                    { 118, 5, "Xsara" },
                    { 117, 5, "Xantia" },
                    { 116, 5, "Nemo" },
                    { 115, 5, "Saxo" },
                    { 91, 5, "C-Crosser" },
                    { 92, 5, "C-Elissée" },
                    { 93, 5, "C-Zero" },
                    { 94, 5, "C1" },
                    { 95, 5, "C2" },
                    { 96, 5, "C3" },
                    { 97, 5, "C3 Picasso" },
                    { 98, 5, "C4" },
                    { 99, 5, "C4 Aircross" },
                    { 100, 5, "C4 Cactus" },
                    { 101, 5, "C4 Coupé" },
                    { 142, 6, "Vivaro Kombi" },
                    { 102, 5, "C4 Grand Picasso" },
                    { 104, 5, "C5" },
                    { 105, 5, "C5 Break" },
                    { 106, 5, "C5 Tourer" },
                    { 107, 5, "C6" },
                    { 108, 5, "C8" },
                    { 109, 5, "DS3" },
                    { 110, 5, "DS4" },
                    { 111, 5, "DS5" },
                    { 112, 5, "Evasion" },
                    { 113, 5, "Jumper" },
                    { 114, 5, "Jumpy" },
                    { 103, 5, "C4 Sedan" },
                    { 143, 6, "Zafira" },
                    { 144, 7, "145" },
                    { 145, 7, "146" },
                    { 174, 8, "Yeti" },
                    { 175, 8, "Rapid" },
                    { 176, 8, "Rapid Spaceback" },
                    { 177, 8, "Superb" },
                    { 178, 8, "Superb Combi" },
                    { 179, 9, "Alero" },
                    { 180, 9, "Aveo" },
                    { 181, 9, "Camaro" },
                    { 182, 9, "Captiva" },
                    { 183, 9, "Corvette" },
                    { 184, 9, "Cruze" },
                    { 173, 8, "Roomster" },
                    { 185, 9, "Cruze SW" },
                    { 187, 9, "Equinox" },
                    { 188, 9, "Evanda" },
                    { 189, 9, "HHR" },
                    { 190, 9, "Kalos" },
                    { 191, 9, "Lacetti" },
                    { 192, 9, "Lacetti SW" },
                    { 193, 9, "Lumina" },
                    { 194, 9, "Malibu" },
                    { 195, 9, "Matiz" },
                    { 196, 9, "Monte Carlo" },
                    { 197, 9, "Nubira" },
                    { 186, 9, "Epica" },
                    { 90, 5, "Berlingo" },
                    { 172, 8, "Octavia Combi" },
                    { 170, 8, "Felicia Combi" },
                    { 146, 7, "146" },
                    { 147, 7, "147" },
                    { 148, 7, "155" },
                    { 149, 7, "156" },
                    { 150, 7, "156 Sportwagon" },
                    { 151, 7, "159" },
                    { 152, 7, "159 Sportwagon" },
                    { 153, 7, "164" },
                    { 154, 7, "166" },
                    { 155, 7, "4C" },
                    { 156, 7, "Brera" },
                    { 171, 8, "Octavia" },
                    { 157, 7, "GTV" },
                    { 159, 7, "Crosswagon" },
                    { 160, 7, "Spider" },
                    { 161, 7, "GT" },
                    { 162, 7, "Giulietta" },
                    { 163, 7, "Giulia" },
                    { 164, 8, "Favorit" },
                    { 165, 8, "Felicia" },
                    { 166, 8, "Citigo" },
                    { 167, 8, "Fabia" },
                    { 168, 8, "Fabia Combi" },
                    { 169, 8, "Fabia Sedan" },
                    { 158, 7, "MiTo" },
                    { 89, 4, "Solenza" },
                    { 88, 4, "Sandero" },
                    { 87, 4, "Logan Van" },
                    { 30, 2, "Laguna Grandtour" },
                    { 31, 2, "Latitude" },
                    { 32, 2, "Mascott" },
                    { 33, 2, "Mégane" },
                    { 34, 2, "Mégane CC" },
                    { 35, 2, "Mégane Combi" },
                    { 36, 2, "Mégane Grandtour" },
                    { 37, 2, "Mégane Coupé" },
                    { 38, 2, "Mégane Scénic" },
                    { 39, 2, "Scénic" },
                    { 40, 2, "Talisman" },
                    { 29, 2, "Laguna" },
                    { 41, 2, "Talisman Grandtour" },
                    { 43, 2, "Twingo" },
                    { 44, 2, "Wind" },
                    { 45, 2, "Zoé" },
                    { 46, 3, "1007" },
                    { 47, 3, "107" },
                    { 48, 3, "106" },
                    { 49, 3, "108" },
                    { 50, 3, "2008" },
                    { 51, 3, "205" },
                    { 52, 3, "205 Cabrio" },
                    { 53, 3, "206" },
                    { 42, 2, "Thalia" },
                    { 54, 3, "206 CC" },
                    { 28, 2, "Koleos" },
                    { 26, 2, "Kangoo" },
                    { 2, 1, "Altea" },
                    { 3, 1, "Altea XL" },
                    { 4, 1, "Arosa" },
                    { 5, 1, "Cordoba" },
                    { 6, 1, "Cordoba Vario " },
                    { 7, 1, "Exeo" },
                    { 8, 1, "Ibiza" },
                    { 9, 1, "Ibiza ST " },
                    { 10, 1, "Exeo ST" },
                    { 11, 1, "Leon" },
                    { 12, 1, "Leon ST" },
                    { 27, 2, "Kangoo Express" },
                    { 13, 1, "Inca" },
                    { 15, 1, "Toledo" },
                    { 16, 2, "Captur" },
                    { 17, 2, "Clio" },
                    { 18, 2, "Clio Grandtour" },
                    { 19, 2, "Espace" },
                    { 20, 2, "Express" },
                    { 21, 2, "Fluence" },
                    { 22, 2, "Grand Espace" },
                    { 23, 2, "Grand Modus" },
                    { 24, 2, "Grand Scenic" },
                    { 25, 2, "Kadjar" },
                    { 14, 1, "Mii" },
                    { 198, 9, "Orlando" },
                    { 55, 3, "206 SW" },
                    { 57, 3, "207 CC" },
                    { 788, 3, "850" },
                    { 789, 3, "850 kombi" },
                    { 790, 3, "C30" },
                    { 791, 3, "C70" },
                    { 792, 3, "C70 Cabrio" },
                    { 793, 3, "C70 Coupé" },
                    { 794, 3, "S40" },
                    { 795, 3, "S60" },
                    { 796, 3, "S70" },
                    { 797, 3, "S80" },
                    { 798, 3, "S90" },
                    { 787, 3, "460" },
                    { 799, 3, "V40" },
                    { 801, 3, "V60" },
                    { 802, 3, "V70" },
                    { 803, 3, "V90" },
                    { 804, 3, "XC60" },
                    { 805, 3, "XC70" },
                    { 806, 3, "XC90" },
                    { 82, 4, "Dokker" },
                    { 83, 4, "Duster" },
                    { 84, 4, "Lodgy" },
                    { 85, 4, "Logan" },
                    { 86, 4, "Logan MCV" },
                    { 800, 3, "V50" },
                    { 56, 3, "207" },
                    { 786, 3, "360" },
                    { 784, 3, "240" },
                    { 58, 3, "207 SW" },
                    { 59, 3, "306" },
                    { 60, 3, "307" },
                    { 61, 3, "307 CC" },
                    { 62, 3, "307 SW" },
                    { 63, 3, "308" },
                    { 64, 3, "308 CC" },
                    { 65, 3, "308 SW" },
                    { 66, 3, "309" },
                    { 67, 3, "4007" },
                    { 68, 3, "4008" },
                    { 785, 3, "340" },
                    { 69, 3, "405" },
                    { 71, 3, "407" },
                    { 72, 3, "407 SW" },
                    { 73, 3, "5008" },
                    { 74, 3, "508" },
                    { 75, 3, "508 SW" },
                    { 76, 3, "605" },
                    { 77, 3, "806" },
                    { 78, 3, "607" },
                    { 79, 3, "807" },
                    { 80, 3, "Bipper" },
                    { 81, 3, "RCZ" },
                    { 70, 3, "406" },
                    { 199, 9, "Spark" },
                    { 200, 9, "Suburban" },
                    { 201, 9, "Tacuma" },
                    { 336, 16, "Hiace Van" },
                    { 337, 16, "Highlander" },
                    { 338, 16, "Hilux" },
                    { 339, 16, "Land Cruiser" },
                    { 340, 16, "MR2" },
                    { 341, 16, "Paseo" },
                    { 342, 16, "Picnic" },
                    { 343, 16, "Prius" },
                    { 344, 16, "RAV4" },
                    { 345, 16, "Sequoia" },
                    { 346, 16, "Starlet" },
                    { 335, 16, "Hiace" },
                    { 347, 16, "Supra" },
                    { 349, 16, "Urban Cruiser" },
                    { 350, 16, "Verso" },
                    { 351, 16, "Yaris" },
                    { 352, 16, "Yaris Verso" },
                    { 353, 17, "i3" },
                    { 354, 17, "i8" },
                    { 355, 17, "M3" },
                    { 356, 17, "M4" },
                    { 357, 17, "M5" },
                    { 358, 17, "M6" },
                    { 359, 17, "Rad 1" },
                    { 348, 16, "Tundra" },
                    { 360, 17, "Rad 1 Cabrio" },
                    { 334, 16, "GT86" },
                    { 332, 16, "Corolla Verso" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Models",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 308, 15, "IS 200" },
                    { 309, 15, "IS 250 C" },
                    { 310, 15, "IS-F" },
                    { 311, 15, "LS" },
                    { 312, 15, "LX" },
                    { 313, 15, "NX" },
                    { 314, 15, "RC F" },
                    { 315, 15, "RX" },
                    { 316, 15, "RX 300" },
                    { 317, 15, "RX 400h" },
                    { 318, 15, "RX 450h" },
                    { 333, 16, "FJ Cruiser" },
                    { 319, 15, "SC 430" },
                    { 321, 16, "Auris" },
                    { 322, 16, "Avensis" },
                    { 323, 16, "Avensis Combi" },
                    { 324, 16, "Avensis Van Verso" },
                    { 325, 16, "Aygo" },
                    { 326, 16, "Camry" },
                    { 327, 16, "Carina" },
                    { 328, 16, "Celica" },
                    { 329, 16, "Corolla" },
                    { 330, 16, "Corolla Combi" },
                    { 331, 16, "Corolla sedan" },
                    { 320, 16, "4-Runner" },
                    { 307, 15, "IS" },
                    { 361, 17, "Rad 1 Coupé" },
                    { 363, 17, "Rad 2 Active Tourer" },
                    { 392, 17, "Z4" },
                    { 393, 17, "Z4 Roadster" },
                    { 394, 18, "Amarok" },
                    { 395, 18, "Beetle" },
                    { 396, 18, "Bora" },
                    { 397, 18, "Bora Variant" },
                    { 398, 18, "Caddy" },
                    { 399, 18, "Caddy Van" },
                    { 400, 18, "Life" },
                    { 401, 18, "California" },
                    { 402, 18, "Caravelle" },
                    { 391, 17, "Z3 Roadster" },
                    { 403, 18, "CC" },
                    { 405, 18, "Crafter Van" },
                    { 406, 18, "Crafter Kombi" },
                    { 407, 18, "CrossTouran" },
                    { 408, 18, "Eos" },
                    { 409, 18, "Fox" },
                    { 410, 18, "Golf" },
                    { 411, 18, "Golf Cabrio" },
                    { 412, 18, "Golf Plus" },
                    { 413, 18, "Golf Sportvan" },
                    { 414, 18, "Golf Variant" },
                    { 415, 18, "Jetta" },
                    { 404, 18, "Crafter" },
                    { 362, 17, "Rad 2" },
                    { 390, 17, "Z3 Coupé" },
                    { 388, 17, "X6" },
                    { 364, 17, "Rad 2 Coupé" },
                    { 365, 17, "Rad 2 Gran Tourer" },
                    { 366, 17, "Rad 3" },
                    { 367, 17, "Rad 3 Cabrio" },
                    { 368, 17, "Rad 3 Compact" },
                    { 369, 17, "Rad 3 Coupé" },
                    { 370, 17, "Rad 3 GT" },
                    { 371, 17, "Rad 3 Touring" },
                    { 372, 17, "Rad 4" },
                    { 373, 17, "Rad 4 Cabrio" },
                    { 374, 17, "Rad 4 Gran Coupé" },
                    { 389, 17, "Z3" },
                    { 375, 17, "Rad 5" },
                    { 377, 17, "Rad 5 Touring" },
                    { 378, 17, "Rad 6" },
                    { 379, 17, "Rad 6 Cabrio" },
                    { 380, 17, "Rad 6 Coupé" },
                    { 381, 17, "Rad 6 Gran Coupé" },
                    { 382, 17, "Rad 7" },
                    { 383, 17, "Rad 8 Coupé" },
                    { 384, 17, "X1" },
                    { 385, 17, "X3" },
                    { 386, 17, "X4" },
                    { 387, 17, "X5" },
                    { 376, 17, "Rad 5 GT" },
                    { 417, 18, "Lupo" },
                    { 306, 15, "GX" },
                    { 304, 15, "GS" },
                    { 224, 11, "Civic Tourer" },
                    { 225, 11, "Civic Type R" },
                    { 226, 11, "CR-V" },
                    { 227, 11, "CR-X" },
                    { 228, 11, "CR-Z" },
                    { 229, 11, "FR-V" },
                    { 230, 11, "HR-V" },
                    { 231, 11, "Insight" },
                    { 232, 11, "Integra" },
                    { 233, 11, "Jazz" },
                    { 234, 11, "Legend" },
                    { 223, 11, "Civic Coupé" },
                    { 235, 11, "Prelude" },
                    { 237, 12, "Forester" },
                    { 238, 12, "Impreza" },
                    { 239, 12, "Impreza Wagon" },
                    { 240, 12, "Justy" },
                    { 241, 12, "Legacy" },
                    { 242, 12, "Legacy Wagon" },
                    { 243, 12, "Legacy Outback" },
                    { 244, 12, "Levorg" },
                    { 245, 12, "Outback" },
                    { 246, 12, "SVX" },
                    { 247, 12, "Tribeca" },
                    { 236, 12, "BRZ" },
                    { 248, 12, "Tribeca B9" },
                    { 222, 11, "Civic Aerodeck" },
                    { 220, 11, "City" },
                    { 202, 9, "Tahoe" },
                    { 203, 9, "Trax" },
                    { 205, 10, "911 Carrera" },
                    { 206, 10, "911 Carrera Cabrio" },
                    { 207, 10, "911 Targa" },
                    { 208, 10, "911 Turbo" },
                    { 209, 10, "924" },
                    { 210, 10, "944" },
                    { 211, 10, "997" },
                    { 212, 10, "Boxster" },
                    { 213, 10, "Cayenne" },
                    { 221, 11, "Civic" },
                    { 214, 10, "Cayman" },
                    { 216, 10, "Panamera" },
                    { 735, 10, "Cherokee" },
                    { 736, 10, "Commander" },
                    { 737, 10, "Compass" },
                    { 738, 10, "Grand Cherokee" },
                    { 739, 10, "Patriot" },
                    { 740, 10, "Renegade" },
                    { 741, 10, "Wrangler" },
                    { 217, 11, "Accord" },
                    { 218, 11, "Accord Coupé" },
                    { 219, 11, "Accord Tourer" },
                    { 215, 10, "Macan" },
                    { 305, 15, "GS 300" },
                    { 249, 12, "XV" },
                    { 251, 13, "2" },
                    { 280, 14, "Carisma" },
                    { 281, 14, "Colt" },
                    { 282, 14, "Colt CC" },
                    { 283, 14, "Eclipse" },
                    { 284, 14, "Fuso canter" },
                    { 285, 14, "Galant" },
                    { 286, 14, "Galant Combi" },
                    { 287, 14, "Grandis" },
                    { 288, 14, "L200" },
                    { 289, 14, "L200 Pick up" },
                    { 290, 14, "L200 Pick up Allrad" },
                    { 279, 14, "ASX" },
                    { 291, 14, "L300" },
                    { 293, 14, "Lancer Combi" },
                    { 294, 14, "Lancer Evo" },
                    { 295, 14, "Lancer Sportback" },
                    { 296, 14, "Outlander" },
                    { 297, 14, "Pajero" },
                    { 298, 14, "Pajeto Pinin" },
                    { 299, 14, "Pajero Pinin Wagon" },
                    { 300, 14, "Pajero Sport" },
                    { 301, 14, "Pajero Wagon" },
                    { 302, 14, "Space Star" },
                    { 303, 15, "CT" },
                    { 292, 14, "Lancer" },
                    { 250, 13, "121" },
                    { 278, 14, "3000 GT" },
                    { 276, 13, "RX-8" },
                    { 252, 13, "3" },
                    { 253, 13, "323" },
                    { 254, 13, "323 Combi" },
                    { 255, 13, "323 Coupé" },
                    { 256, 13, "323 F" },
                    { 257, 13, "5" },
                    { 258, 13, "6" },
                    { 259, 13, "6 Combi" },
                    { 260, 13, "626" },
                    { 261, 13, "626 Combi" },
                    { 262, 13, "B-Fighter" },
                    { 277, 13, "Xedox 6" },
                    { 263, 13, "B2500" },
                    { 265, 13, "CX-3" },
                    { 266, 13, "CX-5" },
                    { 267, 13, "CX-7" },
                    { 268, 13, "CX-9" },
                    { 269, 13, "Demio" },
                    { 270, 13, "MPV" },
                    { 271, 13, "MX-3" },
                    { 272, 13, "MX-5" },
                    { 273, 13, "MX-6" },
                    { 274, 13, "Premacy" },
                    { 275, 13, "RX-7" },
                    { 264, 13, "BT" },
                    { 894, 39, "Roadster" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39);
        }
    }
}
