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
