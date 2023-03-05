kubectl apply -f cookingapp-namespace.yml
kubectl -n cookingapp apply -f ./postgres/secret.yaml
helm -n cookingapp upgrade --install -f ./postgres/values.yaml postgres bitnami/postgresql
kubectl -n cookingapp apply -f ./receipts-chart/secret.yaml
kubectl -n cookingapp apply -f ./receipts-chart/receipts-configmap.yaml
helm -n cookingapp upgrade --install -f ./receipts-chart/values.yaml receipts-chart receipts-chart