using System;
using System.ComponentModel;

namespace NGRE_Save_Editor.MiscMods
{
    //Properties that need to interact with the UI are placed here
    partial class Weapons : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        string currentWepSelected;
        public string CurrentWepSelected
        {
            get { return currentWepSelected; }
            set
            {
                currentWepSelected = value;
                OnPropertyChanged("CurrentWepSelected");
            }
        }

        Uri imgSource;
        public Uri ImgSource
        {
            get { return imgSource; }
            set
            {
                imgSource = value;
                OnPropertyChanged("ImgSource");

            }
        }

        //TODO: Delete Before Release
        string testHex;
        public string TestHex
        {
            get { return testHex; }
            set
            {
                testHex = value;
                OnPropertyChanged("TestHex");
            }
        }

        //TODO: Delete Before Release
        string testOffset;
        public string TestOffset
        {
            get { return testOffset; }
            set
            {
                testOffset = value;
                OnPropertyChanged("TestOffset");
            }
        }
    }
}


