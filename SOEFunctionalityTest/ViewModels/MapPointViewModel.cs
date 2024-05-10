using SOEFunctionalityTest.Models;
using SOEFunctionalityTest.Utils;
using System.Windows.Input;

namespace SOEFunctionalityTest.ViewModels
{
    public class MapPointViewModel
    {
        private SOEResponseModel _soeResponse;
        private SOEArgsModel _soeArgs;
        private ICommand _updateSOEResponse;
        private ICommand _updateSOEArgs;
        public MapPointViewModel()//constructor
        {
            _soeResponse = new SOEResponseModel();
            _soeArgs = new SOEArgsModel(1);
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

        public ICommand UpdateSOEResponse
        {
            get
            {
                if (_updateSOEResponse == null)
                    _updateSOEResponse = new Commands.RelayCommand(param => this.Submit(),
                        null);
                return _updateSOEResponse;
            }
            set
            {
                _updateSOEResponse = value;
            }
        }
        public async void Submit()
        {
            SOEResponseModel response =  await Utils.HTTPRequest.QuerySOE(SOEArgs);
            if(response != null)
            {
                CopyProps.CopyProperties(response, SOEResponse);
            }
        }
    }
}
