﻿
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using ProyectoFotoCore3.ServiceAgents.AzureBlobStorage.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore3.ServiceAgents.AzureBlobStorage
{
    public class AzureBlobStorage
    {
        CloudBlobClient client;
        public AzureBlobStorage()
        {
            String keys = "UseDevelopmentStorage=true";
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            this.client = account.CreateCloudBlobClient();
        }

        public async Task CrearContenedor(String idSession)
        {
            CloudBlobContainer container = this.client.GetContainerReference(idSession);
            await container.CreateIfNotExistsAsync();
            await container.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
        }

        public async Task<bool> SubirBlob(String containerName, String blockName, string tempPath)
        {
            CloudBlobContainer container = this.client.GetContainerReference(containerName);
            CloudBlockBlob blobBlock = container.GetBlockBlobReference(blockName);

            using (var stream = new FileStream(tempPath, FileMode.Open))
            {
                await blobBlock.UploadFromStreamAsync(stream);
            }

            return true;
        }


        public async Task<bool> EliminarBlob(String nombreContenedor, String nombreblob)
        {
            CloudBlobContainer container = this.client.GetContainerReference(nombreContenedor);
            CloudBlockBlob blob = container.GetBlockBlobReference(nombreblob);
            var flag = await blob.DeleteIfExistsAsync();

            return flag;
        }

        public async Task<List<AzureBlobItem>> GetBlobItems( String nombreContenedor)
        {
            bool useFlatListing = true;

            //Container  
            CloudBlobContainer blobContainer = this.client.GetContainerReference(nombreContenedor);

            //List  
            var list = new List<AzureBlobItem>();
            BlobContinuationToken token = null;
            do
            {
                BlobResultSegment resultSegment = await blobContainer.ListBlobsSegmentedAsync("", useFlatListing, new BlobListingDetails(), null, token, null, null);
                token = resultSegment.ContinuationToken;

                foreach (IListBlobItem item in resultSegment.Results)
                {
                    //list.Add(new AzureBlobItem(item));
                }

            } while (token != null);

            return list.OrderBy(i => i.Folder).ThenBy(i => i.Name).ToList();
        }

        public async Task<String> GetUriBlob(String nombreContenedor, String nombreblob)
        {
            CloudBlobContainer container = this.client.GetContainerReference(nombreContenedor);
            CloudBlockBlob blob = container.GetBlockBlobReference(nombreblob);

            return blob.StorageUri.PrimaryUri.ToString();
        }

        public async Task<CloudBlockBlob> GetBlob(String nombreContenedor, String nombreblob)
        {
            CloudBlobContainer container = this.client.GetContainerReference(nombreContenedor);
            CloudBlockBlob blob = container.GetBlockBlobReference(nombreblob);

            return blob;
        }

        public async Task<bool> MoverBlob(String nombreContenedor, String nombreBlob, String destinoContenedor)
        {
            CloudBlobContainer containerOrigen = this.client.GetContainerReference(nombreContenedor);
            CloudBlobContainer containerDestino = this.client.GetContainerReference(destinoContenedor);
            CloudBlockBlob BlockblobOrigen = containerOrigen.GetBlockBlobReference(nombreBlob);
            CloudBlockBlob BlockblobDestino = containerDestino.GetBlockBlobReference(BlockblobOrigen.Name);
            await BlockblobDestino.StartCopyAsync(BlockblobOrigen);
            await BlockblobOrigen.DeleteIfExistsAsync();

            return true;
        }

        public async Task<bool> EliminarContenedor(String nombreContenedor)
        {
            CloudBlobContainer container = this.client.GetContainerReference(nombreContenedor);
            await container.DeleteIfExistsAsync();

            return true;
        }

    }
}
