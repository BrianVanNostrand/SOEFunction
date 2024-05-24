using SOEFunctionalityTest.Models;
using SOEFunctionalityTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SOEFunctionalityTest.ViewModels
{
    public class MapLineViewModel
    {
        private SOEResponseModel _soeStartResponse;
        private SOEResponseModel _soeEndResponse;
        private SOEArgsModel _soeStartArgs;
        private SOEArgsModel _soeEndArgs;
        private ICommand _updateSOEStartEndResponse;
        private ICommand _updateSOEStartEndArgs;
        private List<List<SOEResponseModel>> _soeLineResponses;
        public MapLineViewModel()//constructor
        {
            _soeStartResponse = new SOEResponseModel();
            _soeEndResponse = new SOEResponseModel();
            _soeStartArgs = new SOEArgsModel(1);
            _soeEndArgs = new SOEArgsModel(2);
            _soeLineResponses = new List<List<SOEResponseModel>>();
        }
        public List<List<SOEResponseModel>> SoeLineResponses
        {
            get { return _soeLineResponses; }
            set { _soeLineResponses = value; }
        }
        public SOEResponseModel SOEStartResponse
        {
            get { return _soeStartResponse; }
            set { _soeStartResponse = value; }
        }
        public SOEResponseModel SOEEndResponse
        {
            get { return _soeEndResponse; }
            set { _soeEndResponse = value; }
        }
        public SOEArgsModel SOEStartArgs
        {
            get { return _soeStartArgs; }
            set { _soeStartArgs = value; }
        }
        public SOEArgsModel SOEEndArgs
        {
            get { return _soeEndArgs; }
            set { _soeEndArgs = value; }
        }
        public ICommand UpdateSOEStartEndResponse
        {
            get
            {
                if (_updateSOEStartEndResponse == null)
                    _updateSOEStartEndResponse = new Commands.RelayCommand(param => this.SubmitStartEnd(param),
                        null);
                return _updateSOEStartEndResponse;
            }
            set
            {
                _updateSOEStartEndResponse = value;
            }
        }
        public async void SubmitStartEnd(object param)
        {
            if (param.ToString() == "start")
            {
                SOEResponseModel response = await Utils.HTTPRequest.QuerySOE(SOEStartArgs);
                if (response != null)
                {
                    CopyProps.CopyProperties(response, SOEStartResponse);
                }
            }
            else if (param.ToString() == "end")
            {
                SOEResponseModel response = await Utils.HTTPRequest.QuerySOE(SOEEndArgs);
                if (response != null)
                {
                    CopyProps.CopyProperties(response, SOEEndResponse);
                }
            }
        }
    }
}
