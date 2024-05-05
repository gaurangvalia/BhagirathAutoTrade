﻿using BhagirathAutoTrade.Server.Models;

namespace BhagirathAutoTrade.Server.Services.Interfaces
{
    public interface IEquityService
    {
        Task<IEnumerable<string>> AutoCompleteCompanyForEquityAsync(string exchange, string type, string instrument, string optionType);
        Task<EquityResponseModel> GetCalculateDataForEQAsync(EquityRequestModel request);
        //Task<IEnumerable<string>> GetExpiryDateAsync(string workingDate, string expiryDate, string exchange, string instrument, string optionType, string type, string strickPrice, string symbol);
        Task<string> GetOpenDataAsync(string workingDate, string expiryDate, string exchange, string instrument, string optionType, string type, string strickPrice, string symbol);
    }
}
