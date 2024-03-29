﻿using XWay_CSharp_API.DataTransferObject;

namespace XWay_CSharp_API.Services.HistoryImageColorized
{
    public interface IHistoryImageColorizedService
    {
        public Task<PaginatedListModel<Models.HistoryImageColorized>> Get(int pageNumber, int pageSize, int uid);
        public Task<bool> Delete(List<int> ids);
        public Task<bool> Add(Models.HistoryImageColorized historyImage);
        public Task<bool> AddRange(List<Models.HistoryImageColorized> historyImage);

    }
}
