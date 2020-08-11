using App1.Models;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModels
{
    public class MainViewModel :ViewModelBase
    {
        public MainViewModel()
        {
            BuildTestDatum();
        }


        public ObservableCollection<AlbumGroup> Groups 
        {
            get;set;
        
        }

        private AlbumGroup _selectedGroup;
        public AlbumGroup SelectedGroup
        {
            get
            {
                return _selectedGroup;
            }
            set
            {
                Set(ref _selectedGroup, value);
            }
        }

        public ObservableCollection<string> Initials
        {
            get;set;
        }

        private bool _showPopup;
        public bool ShowPopup
        {
            get
            {
                return _showPopup;
            }
            set
            {
                Set(ref _showPopup, value);
            }

        }

        private string _filteringLetter;
        public string FilteringLetter 
        {
            get
            {
                return _filteringLetter;
            }
            set
            {
                Set(ref _filteringLetter, value);
            }
        }


        private void BuildTestDatum()
        {

            AlbumGroup group1 = new AlbumGroup() { Name = "A" };
            Album al1 = new Album() { AlbumName = "Feed Your Soul", Artist = "Christa Wells" };
            Album al2 = new Album() { AlbumName = "The Female Boss", Artist = "Tulisa" };
            Album al3 = new Album() { AlbumName = "Only Human", Artist = "Delta Goodrem" };
            group1.Albums.AddRange(new[] { al1, al2, al3 });

            AlbumGroup group2 = new AlbumGroup() { Name = "B" };
            Album al4 = new Album() { AlbumName = "GreatestHits II (2011 remaster)", Artist = "" };
            group2.Albums.AddRange(new[] { al4 });


            AlbumGroup groupC = new AlbumGroup() { Name = "C" };
            Album alC1 = new Album() { AlbumName = "Music for Tourist", Artist = "Chris Garneau" };
            Album alC2 = new Album() { AlbumName = "Nick Johnas", Artist = "" };
            groupC.Albums.AddRange(new[] { alC1, alC2 });


            AlbumGroup groupD = new AlbumGroup() { Name = "D" };
            Album alD1 = new Album() { AlbumName = "Feed Your Soul", Artist = "Christa Wells" };
            Album alD2 = new Album() { AlbumName = "The Female Boss", Artist = "Tulisa" };
            Album alD3 = new Album() { AlbumName = "Only Human", Artist = "Delta Goodrem" };
            groupD.Albums.AddRange(new[] { alD1, alD2, alD3 });


            AlbumGroup groupE = new AlbumGroup() { Name = "E" };
            Album alE1 = new Album() { AlbumName = "Feed Your Soul", Artist = "Christa Wells" };
            Album alE2 = new Album() { AlbumName = "The Female Boss", Artist = "Tulisa" };
            Album alE3 = new Album() { AlbumName = "Only Human", Artist = "Delta Goodrem" };
            groupE.Albums.AddRange(new[] { alE1, alE2, alE3 });


            AlbumGroup groupF = new AlbumGroup() { Name = "F" };
            Album alF1 = new Album() { AlbumName = "Feed Your Soul", Artist = "Christa Wells" };
            Album alF2 = new Album() { AlbumName = "The Female Boss", Artist = "Tulisa" };
            Album alF3 = new Album() { AlbumName = "Only Human", Artist = "Delta Goodrem" };
            groupF.Albums.AddRange(new[] { alF1, alF2, alF3 });

            AlbumGroup groupG = new AlbumGroup() { Name = "G" };
            Album alG1 = new Album() { AlbumName = "Feed Your Soul", Artist = "Christa Wells" };
            Album alG2 = new Album() { AlbumName = "The Female Boss", Artist = "Tulisa" };
            Album alG3 = new Album() { AlbumName = "Only Human", Artist = "Delta Goodrem" };
            groupG.Albums.AddRange(new[] { alG1, alG2, alG3 });

            AlbumGroup groupH = new AlbumGroup() { Name = "H" };
            Album alH1 = new Album() { AlbumName = "Feed Your Soul", Artist = "Christa Wells" };
            Album alH2 = new Album() { AlbumName = "The Female Boss", Artist = "Tulisa" };
            Album alH3 = new Album() { AlbumName = "Only Human", Artist = "Delta Goodrem" };
            groupH.Albums.AddRange(new[] { alH1, alH2, alH3 });

            AlbumGroup groupI = new AlbumGroup() { Name = "I" };
            Album alI1 = new Album() { AlbumName = "Feed Your Soul", Artist = "Christa Wells" };
            Album alI2 = new Album() { AlbumName = "The Female Boss", Artist = "Tulisa" };
            Album alI3 = new Album() { AlbumName = "Only Human", Artist = "Delta Goodrem" };
            groupI.Albums.AddRange(new[] { alI1, alI2, alI3 });

            Groups = new ObservableCollection<AlbumGroup>();
            Groups.Add(group1);
            Groups.Add(group2);
            Groups.Add(groupC);
            Groups.Add(groupD);
            Groups.Add(groupE);
            Groups.Add(groupF);
            Groups.Add(groupG);
            Groups.Add(groupH);
            Groups.Add(groupI);

            Initials = new ObservableCollection<string>();
            Initials.Add("A");
            Initials.Add("B");
            Initials.Add("C");
            Initials.Add("D");
            Initials.Add("E");
            Initials.Add("F");
            Initials.Add("G");
            Initials.Add("H");
            Initials.Add("I");
            Initials.Add("J");

        }
    }
}
