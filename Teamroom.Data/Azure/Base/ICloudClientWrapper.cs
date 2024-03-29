﻿using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Queue;
using Microsoft.WindowsAzure.Storage.Table;

namespace HobbyClue.Data.Azure.Base
{
    public interface ICloudClientWrapper
    {
        CloudTableClient TableClient { get; }

        CloudQueueClient QueueClient { get; }

        CloudBlobClient BlobClient { get; }

        CloudStorageAccount StorageAccount { get; }

        //void DeleteTable(string tableName);
    }
}