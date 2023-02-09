kubectl apply -f cookingapp-namespace.yml
kubectl -n cookingapp apply -f secret.yaml
helm -n cookingapp upgrade --install -f values.yaml postgres bitnami/postgresql
kubectl -n cookingapp apply -f receipts-deployment.yml