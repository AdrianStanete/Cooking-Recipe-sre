# Cooking-Recipe-SRE
This is the automation of the deployment and monitoring of the Cooking-Recipe app.

## App setup script
This script will deploy the app and it's DB.

Create the kind cluster.
```
kind create cluster
```

Go to the Receipts directory and use this commands: 

```
chmod +x deploy.sh
./deploy.sh
```

The app will be availabl at https://cookingapp.example.com/

The latest Docker image of the app will be published on DockerHub https://hub.docker.com/repository/docker/adrianstanete/receipts-image
The image naming and tag is based on the latest git branch and commit hash.

### Cluster setup script
This script will deploy Prometheus + Grafana, and a pod for DNS debugging purposes. 

```
cd kubernetes/helm
chmod +x deploy.sh
./deploy.sh
```
