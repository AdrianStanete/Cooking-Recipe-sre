kubectl apply -f cookingapp-namespace.yml
kubectl apply -f postgres-secret.yml
helm -n cookingapp upgrade --install -f values.yaml postgres bitnami/postgresql