#Cookingapp + db
kubectl apply -f cookingapp-namespace.yml
kubectl -n cookingapp apply -f ./postgres/secret.yaml
helm -n cookingapp upgrade --install -f ./postgres/values.yaml postgres bitnami/postgresql
kubectl -n cookingapp apply -f ./receipts-chart/secret.yaml
kubectl -n cookingapp apply -f ./receipts-chart/receipts-configmap.yaml
helm -n cookingapp upgrade --install -f ./receipts-chart/values.yaml receipts-chart receipts-chart
#Prometheus
kubectl apply --server-side -f ../prometheus/kube-prometheus/manifests/setup
kubectl wait \
	--for condition=Established \
	--all CustomResourceDefinition \
	--namespace=monitoring
kubectl apply -f ../prometheus/kube-prometheus/manifests/
#Debugging DNS
	#https://kubernetes.io/docs/tasks/administer-cluster/dns-debugging-resolution/
kubectl apply -f ../dnsutils/dnsutils-namespace.yml
kubectl -n dnsutils apply -f ../dnsutils/dnsutils.yml
#Nginx-ingress
kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/main/deploy/static/provider/kind/deploy.yaml
