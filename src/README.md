## Before Biulding on Cloud Build

Register docker-compose image to your GCR.
https://github.com/GoogleCloudPlatform/cloud-builders-community

## Build on Local

```
$ gcloud builds submit --config cloudbuild.yaml --substitutions=_LOG_STORAGE_BUCKET_NAME="my-bucket-name-storage-log" --gcs-source-staging-dir gs://my-bucket-for-source-staging/source .
```
