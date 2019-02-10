using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Datas
    {
        public static void createDatas(Generator generator)
        {
            Dozent Waldowski = new Dozent("Michael", "Waldowski", new int[2] { 4, 5 });
            generator.allDozenten.Add(Waldowski); //0
            Dozent DellOro = new Dozent("Fridl", "Dell'Oro", new int[2] { 1, 2 });
            generator.allDozenten.Add(DellOro); //1
            Dozent Eisenbigler = new Dozent("Dirk", "Eisenbigler", new int[2] { 3, 4 });
            generator.allDozenten.Add(Eisenbigler);  //2
            Dozent Reusch = new Dozent("Matthias", "Reusch", new int[2] { 2, 3 });
            generator.allDozenten.Add(Reusch); //3
            Dozent Herbstreit = new Dozent("Achim", "Herbstreit", new int[2] { 4, 5 });
            generator.allDozenten.Add(Herbstreit); //4
            Dozent Schneider = new Dozent("Thomas", "Schneider", new int[2] { 3, 5 });
            generator.allDozenten.Add(Schneider); //5
            Dozent Hottong = new Dozent("Nikolaus", "Hottong", new int[2] { 1, 2 });
            generator.allDozenten.Add(Hottong); //6
            Dozent Dittler = new Dozent("Ullrich", "Dittler", new int[2] { 1, 5 });
            generator.allDozenten.Add(Dittler); //7
            Dozent Fries = new Dozent("Christian", "Fries", new int[2] { 2, 5 });
            generator.allDozenten.Add(Fries); //8
            Dozent Eberle = new Dozent("Christoph", "Eberle", new int[2] { 1, 2 });
            generator.allDozenten.Add(Eberle); //9
            Dozent Müller = new Dozent("Christoph", "Müller", new int[2] { 4, 5 });
            generator.allDozenten.Add(Müller);
            Dozent Dufner = new Dozent("Timo", "Dufner", new int[2] { 4, 5 });
            generator.allDozenten.Add(Dufner);
            Dozent Lasowski = new Dozent("Ruxandra", "Lasowski", new int[2] { 1, 5 });
            generator.allDozenten.Add(Lasowski);
            Dozent Krach = new Dozent("Thomas", "Krach", new int[2] { 2, 1 });
            generator.allDozenten.Add(Krach);
            Dozent Zydorek = new Dozent("Christoph", "Zydorek", new int[2] { 1, 3 });
            generator.allDozenten.Add(Zydorek);
            Dozent Anders = new Dozent("Jürgen", "Anders", new int[2] { 1, 5 });
            generator.allDozenten.Add(Anders);
            Dozent Unbekannt = new Dozent("Un", "Bekannt", new int[2] { 1, 5 });
            generator.allDozenten.Add(Unbekannt);




            //MIB
            //************************************************************************************* */

            Studium MIB1 = new Studium("MIB1", 35);
            generator.allStudys.Add(MIB1);
            Studium MIB2 = new Studium("MIB2", 30);
            generator.allStudys.Add(MIB2);
            Studium MIB4 = new Studium("MIB4", 12);
            generator.allStudys.Add(MIB4);
            Studium MIB5 = new Studium("MIB5", 12);
            generator.allStudys.Add(MIB5);
            Studium MIB6 = new Studium("MIB6", 10);
            generator.allStudys.Add(MIB6);

            //MIB1
            generator.allCourses.Add(new Course("PGR", "Programmieren", Eisenbigler, MIB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("AT", "Audiotechnik", Reusch, MIB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("BWL", "Grundlagen der Betriebswirtschaftslehre", Herbstreit, MIB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("PGR PR", "Programmieren Praktikum", Eisenbigler, MIB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("BWL PR", "Grundlagen der Betriebswirtschaftslehre Praktikum", Herbstreit, generator.allStudys[0], new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("MatMedInf1", "Mathematik in Medien und Informatik 1", Schneider, MIB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("VideoTech", "Videotechnik", Hottong, MIB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("MedTechPra", "Medientechnik Praktikum", Hottong, MIB1, new List<Conditions>() { Conditions.Fernsehstudio }));
            generator.allCourses.Add(new Course("MedPsych", "Medienpsychologie", Dittler, MIB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("PhysMedInf", "Physik in Medien und Informatik", Schneider, MIB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("MINT-Pra", "MINT-Praktikum", Schneider, MIB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("GrMedGest", "Grundlagen Mediengestaltung", Fries, MIB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("GrMedGestPra", "Grundlagen Mediengestaltung Praktikum", Eberle, MIB1, new List<Conditions>() { Conditions.Normal }));

            //MIB2
            generator.allCourses.Add(new Course("MathSimSem", "Mathematik und Simulation Seminar", Schneider, MIB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("ComGra", "Computergrafik Vorlesung", Müller, MIB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("GIS", "Grundlagen Interaktiver Systeme", Dufner, MIB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("MathSim", "Mathematik und Simulation", Lasowski, MIB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("MathSimPra", "Mathematik und Simulation Praktikum", Lasowski, MIB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("GIS Pra", "Grundlagen Interaktiver Systeme Praktikum", Dufner, MIB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("UsExDe", "User Experience Design Vorlesung", Krach, MIB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("ComGraPra", "Computergrafik Praktikum", Müller, MIB2, new List<Conditions>() { Conditions.Computer }));
            generator.allCourses.Add(new Course("MedÖko", "Medienökonomie", Zydorek, MIB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("Mark", "Marketing", Zydorek, MIB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("UsExDeSe", "User Experience Design Seminar", Krach, MIB2, new List<Conditions>() { Conditions.Normal }));

            //MIB4
            generator.allCourses.Add(new Course("GDV", "Grafische Datenverarbeitung 1", Waldowski, MIB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("SWD Se", "Softwaredesign Seminar", DellOro, MIB4, new List<Conditions> { Conditions.Computer }));
            generator.allCourses.Add(new Course("GrafDV", "Grafische Datenverarbeitung 2", Waldowski, MIB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("GrafDV Üb", "Grafische Datenverarbeitung Übung", Waldowski, MIB4, new List<Conditions> { Conditions.Computer }));
            generator.allCourses.Add(new Course("KoSy", "Kommunikationssysteme", Waldowski, MIB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("PrStu", "Projektstudium", Krach, MIB4, new List<Conditions> { Conditions.Normal })); //Dozent? Eig variabel
            generator.allCourses.Add(new Course("SWD Pra", "Softwaredesign Praktikum", DellOro, MIB4, new List<Conditions> { Conditions.Computer }));
            generator.allCourses.Add(new Course("KoSy Pra", "Kommunikationssysteme Praktikum", Anders, MIB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("PrStud Vor", "Projektstudium Vorlesung", Zydorek, MIB4, new List<Conditions> { Conditions.Vorlesungssaal }));

            //MIB5
            generator.allCourses.Add(new Course("DaVerMePro", "Datenverarbeitung in der Medienproduktion", Müller, MIB5, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("VerAnw", "Verteilte Anwendungen", Eisenbigler, MIB5, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("VerAnw Pra", "Verteilte Anwendungen Praktikum", Eisenbigler, MIB5, new List<Conditions> { Conditions.Computer }));
            generator.allCourses.Add(new Course("DigAvTec", "Digitale AV-Technik", Hottong, MIB5, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("PrStud", "Projektstudium", Krach, MIB5, new List<Conditions> { Conditions.Normal })); //Dozent? Variabel

            //MIB6
            generator.allCourses.Add(new Course("ITuMedpro", "IT und Medienproduktion", Zydorek, MIB6, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("FreSpr", "Fremdsprachenmodul", Unbekannt, MIB6, new List<Conditions> { Conditions.Vorlesungssaal }));


            //OMB
            //************************************************************************************* */

            //MKB
            //************************************************************************************* */







            //ROOMS
            generator.allRooms.Add(new Room("I0.01", 30, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("L1.01", 30, new List<Conditions> { Conditions.Computer }));
            generator.allRooms.Add(new Room("L1.06a", 40, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("I0.15", 90, new List<Conditions> { Conditions.Vorlesungssaal }));
            generator.allRooms.Add(new Room("I0.16", 90, new List<Conditions> { Conditions.Vorlesungssaal }));
            generator.allRooms.Add(new Room("L2.07a", 40, new List<Conditions> { Conditions.Computer }));
            generator.allRooms.Add(new Room("I0.14", 40, new List<Conditions> { Conditions.Vorlesungssaal }));
            generator.allRooms.Add(new Room("I1.20", 40, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("I2.21", 40, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("L2.07a", 40, new List<Conditions> { Conditions.Computer }));
            generator.allRooms.Add(new Room("I0.17", 90, new List<Conditions> { Conditions.Vorlesungssaal }));
            generator.allRooms.Add(new Room("I0.13", 40, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("L1.05a", 40, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("C0.02", 50, new List<Conditions> { Conditions.Vorlesungssaal }));
            generator.allRooms.Add(new Room("L2.08", 40, new List<Conditions> { Conditions.Computer }));
            generator.allRooms.Add(new Room("A3.11", 40, new List<Conditions> { Conditions.Normal }));


        }
    }
}