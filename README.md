# Cooking-Recipe-SRE
This is the automation of the deployment and monitoring of the Cooking-Recipe app.

Postgres, Docker, Kubectl, Kind, Helm and Terraform have to be installed.

## App setup script
This script will deploy the app and it's Postgres DB.

First, change the host Database to save the cookingapp.example.com url to the right adress.
```
sudo code /etc/hosts
``` 
At the end of this file, add: 127.0.0.1   cookingapp.example.com



Then, create the kind cluster.

```
kind create cluster
```

Then go to the Receipts directory and use this commands: 

```
chmod +x deploy.sh
./deploy.sh
```

The app will be available at https://cookingapp.example.com/

The latest Docker image of the app will be published on DockerHub https://hub.docker.com/repository/docker/adrianstanete/receipts-image
The image naming and tag will be based on the latest git branch and commit hash.

### Cluster setup script
This script will deploy Prometheus + Grafana for monitoring, and a DNS pod for debugging purposes. 

```
cd kubernetes/helm
chmod +x deploy.sh
./deploy.sh
```
