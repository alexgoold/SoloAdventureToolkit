using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using SoloAdventureToolkit.Properties;

namespace SoloAdventureToolkit;

public class DataContext
{
    public int Modifier { get; set; }
    public int  Result { get; set; }

    public DataContext()
    {
        QuestProblems();
        ResultantQuests();
        QuestSource();
        RandomRace();
        RandomAlignment();
        RandomProfession();
        RandomDisposition();
        RandomEconomicStatus();
        GetFirstName();
        GetLastName();
        GetVerb();

    }
    public List<string>? Problems { get; set; }
    public List<string>? QuestProblems()
    {
        List<string>? problems = new List<string>();
        var questProbs = Properties.Resources.Quest_Problems;
        var qpArray = questProbs.Split('\n');
        foreach (var VARIABLE in qpArray)
        {
            problems.Add(VARIABLE);
        }
        Problems = problems;
        return problems;
    }

    public List<string>? Results { get; set; }

    public List<string>? ResultantQuests()
    {
        List<string>? results = new List<string>();
        string RQpath = Properties.Resources.ResultantQuest;
        var RQfile = RQpath.Split('\n');
        foreach (var line in RQfile)
        {
            results.Add(line);
        }

        Results = results;
        return results;
    }

    public List<string>? Source { get; set; }

    public List<string>? QuestSource()
    {
        List<string>? questSource = new List<string>();
        string QSpath = Properties.Resources.QuestSource;
        var QSfile = QSpath.Split('\n');
        foreach (var line in QSfile)
        {
         questSource.Add(line);   
        }
        Source = questSource;
        return questSource;
    }
    public List<string>? Race { get; set; }
    public List<string>? RandomRace()
    {
        List<string>? race = new List<string>();
        string RacePath = Properties.Resources.races;
        var RaceFile = RacePath.Split('\n');
        foreach (var line in RaceFile)
        {
            race.Add(line);
        }

        Race = race;
        return race;
    }

    public List<string>? Alignment { get; set; }
    public List<string>? RandomAlignment()
    {
        List<string>? alignment = new List<string>();
        string AlignmentPath = Properties.Resources.Alignment;
        var AlignmentFile = AlignmentPath.Split('\n');
        foreach (var line in AlignmentFile)
        {
            alignment.Add(line);
        }

        Alignment = alignment;
        return alignment;
    }

    public List<string>? Profession { get; set; }
    public List<string>? RandomProfession()
    {
        List<string>? professionList = new List<string>();
        string ProfessionPath = Properties.Resources.Profession;
        var ProfessionFile = ProfessionPath.Split('\n');
        foreach (var line in ProfessionFile)
        {
            professionList.Add(line);
        }

        Profession = professionList;
        return professionList;
    }
    public List<string>? Disposition { get; set; }
    public List<string>? RandomDisposition()
    {
        List<string>? dispositionList = new List<string>();
        string DispositionPath = Properties.Resources.Disposition;
        var DispositionFile = DispositionPath.Split('\n'); ;
        foreach (var line in DispositionFile)
        {
            dispositionList.Add(line);
        }

        Disposition = dispositionList;
        return dispositionList;
    }
    public List<string>? EconomicStatus { get; set; }
    public List<string>? RandomEconomicStatus()
    {
        List<string>? economicsStatusList = new List<string>();
        string EconomicPath = Properties.Resources.EconomicStatus;
        var EconomicFile = EconomicPath.Split('\n'); ;
        foreach (var line in EconomicFile)
        {
            economicsStatusList.Add(line);
        }

        EconomicStatus = economicsStatusList;
        return economicsStatusList;
    }
    public List<string>? FirstName { get; set; }
    public List<string>? GetFirstName()
    {
        List<string>? firstNameList = new List<string>();
        string firstNamePath = Properties.Resources.first_names;
        var FirstNamesFile = firstNamePath.Split('\n');
        foreach (var line in FirstNamesFile)
        {
            firstNameList.Add(line);
        }

        FirstName = firstNameList;
        return firstNameList;
    }
    public List<string>? LastName { get; set; }
    public List<string>? GetLastName()
    {
        List<string>? lastNameList = new List<string>();
        string lastNamePath = Properties.Resources.last_names;
        var LastNamesFile = lastNamePath.Split('\n');
        foreach (var line in LastNamesFile)
        {
            lastNameList.Add(line);
        }

        LastName = lastNameList;
        return lastNameList;
    }
    public List<string>? Verbs { get; set; }
    public List<string>? GetVerb()
    {
        List<string>? verbList = new List<string>();
        string VerbPath = Properties.Resources.Verbs;
        var VerbFile = VerbPath.Split('\n');
        foreach (var line in VerbFile)
        {
            verbList.Add(line);
        }

        Verbs = verbList;
        return verbList;
    }
}