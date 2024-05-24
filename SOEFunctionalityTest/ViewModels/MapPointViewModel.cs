using SOEFunctionalityTest.Models;
using SOEFunctionalityTest.Utils;
using SOEFunctionalityTest.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace SOEFunctionalityTest.ViewModels
{
    public class MapPointViewModel:ViewModelBase
    {
        //Map point view variables
        private SOEResponseModel _soeResponse;
        private SOEArgsModel _soeArgs;
        private ICommand _updateSOEResponse;
        private ICommand _updateSOEArgs;
        private ObservableCollection<SOEResponseModel> _soePointResponses;
        private ObservableCollection<string> _testString;
        private ICommand _savePointResultCommand;
        
        public MapPointViewModel()//constructor
        {
            _soeResponse = new SOEResponseModel();
            _soeArgs = new SOEArgsModel(1);
            _soePointResponses = new ObservableCollection<SOEResponseModel>();
            _testString = new ObservableCollection<string>();
        }
        public SOEResponseModel SOEResponse
        {
            get{ return _soeResponse;}
            set{ _soeResponse = value;}
        }
        public SOEArgsModel SOEArgs
        {
            get { return _soeArgs;}
            set { _soeArgs = value;}
        }
        public ObservableCollection<SOEResponseModel> SoePointResponses
        {
            get { return _soePointResponses; }
            set { _soePointResponses = value; OnPropertyChanged("SOEPointResponses"); }
        }
        public ObservableCollection<string> TestString
        {
            get { return _testString; }
            set { _testString = value; }
        }
        public List<SOEResponseModel> SelectedItems { get; set; } = new List<SOEResponseModel>();
        public ICommand SelectedItemsCommand
        {
            get
            {
                return new Commands.RelayCommand(list =>
                {
                    SelectedItems.Clear();
                    System.Collections.IList items = (System.Collections.IList)list;
                    var collection = items.Cast<SOEResponseModel>();
                    SelectedItems = collection.ToList();
                });
            }
        }
        public ICommand DeleteItemsCommand
        {
            get
            {
                return new Commands.RelayCommand(list =>
                {
                    for (int i=SoePointResponses.Count-1; i>=0; i--)
                    {
                        if (SelectedItems.Contains(SoePointResponses[i]))
                        {
                            SoePointResponses.Remove(SoePointResponses[i]);
                        }
                    }
                });
            }
        }
        public ICommand ClearItemsCommand
        {
            get
            {
                return new Commands.RelayCommand(list =>
                {
                    SoePointResponses.Clear();
                });
            }
        }
        public ICommand UpdateSOEResponse
        {
            get
            {
                if (_updateSOEResponse == null)
                    _updateSOEResponse = new Commands.RelayCommand(Submit,
                        null);
                return _updateSOEResponse;
            }
            set
            {
                _updateSOEResponse = value;
            }
        }
        public ICommand SavePointResultCommand
        {
            get
            {
                if (_savePointResultCommand == null)
                    _savePointResultCommand = new Commands.RelayCommand(SavePointResult,
                        null);
                return _savePointResultCommand;
            }
            set
            {
                _savePointResultCommand = value;
            }
        }
        public async void Submit(object state)
        {
            SOEResponseModel response =  await Utils.HTTPRequest.QuerySOE(SOEArgs);
            if(response != null)
            {
                CopyProps.CopyProperties(response, SOEResponse);
            }
        }
        public void SavePointResult(object state)
        {
            //string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            //Random random = new Random();
            //string randomString = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            //TestString.Add(randomString);
            SoePointResponses.Add(SOEResponse);
        }
    }
}
