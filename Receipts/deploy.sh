#1- build the aplication
    ## here you build the cooking app aplication to release e new version (you can mix steps1 and 2 usign the -t flag with the build)
#2- tag the image
    #use docker tag  (cooking image is haissamfawaz/cooking-recipe-image:latest)
BRANCH_NAME="$(git rev-parse --abbrev-ref HEAD)"
COMMIT_HASH="$(git rev-parse --short HEAD)"
IMAGE_NAME="adrianstanete/receipts-image"
TAG_NAME="$BRANCH_NAME-$COMMIT_HASH"
echo image name is $IMAGE_NAME
echo the tag name is $TAG_NAME
docker tag adrianstanete/receipts-image:arm $IMAGE_NAME:$TAG_NAME
docker push $IMAGE_NAME:$TAG_NAME
docker pull $IMAGE_NAME:$TAG_NAME
kind load docker-image $IMAGE_NAME:$TAG_NAME
docker build -t "$IMAGE_NAME:$TAG_NAME" .


#3- change the image on values.yaml
export IMAGE_NAME="adrianstanete/receipts-image"
export TAG_NAME="$BRANCH_NAME-$COMMIT_HASH"
    cd kubernetes/helm/receipts-chart
    yq e '.image.repository = env(IMAGE_NAME)' values.yaml -i
    yq e '.image.tag = env(TAG_NAME)' values.yaml -i
    #use sed or yq
    
#4- apply the kubernetes files
    #Cookingapp + db
cd ../../..
pwd
kubectl apply -f kubernetes/helm/cookingapp-namespace.yml
kubectl -n cookingapp apply -f kubernetes/helm/postgres/secret.yaml
helm -n cookingapp upgrade --install -f kubernetes/helm/postgres/values.yaml postgres bitnami/postgresql
kubectl -n cookingapp apply -f kubernetes/helm/receipts-chart/secret.yaml
kubectl -n cookingapp apply -f kubernetes/helm/receipts-chart/receipts-configmap.yaml

#6- Migrate DB
chmod +x apply-tables.sh
PGPASSWORD=supermegapassword ./apply-tables.sh

#5- upgrade helm
helm -n cookingapp upgrade --install -f kubernetes/helm/receipts-chart/values.yaml receipts-chart kubernetes/helm/receipts-chart/
