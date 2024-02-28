import http from 'k6/http'
import { sleep } from 'k6'

export let options = {
    insecureSkipTLSVerify: true,
    noConnectionReuse: false,
    vus: 1,
    duration: '10s'
};

export default () => {
    let response = http.get('https://petstore.swagger.io/v2/store/order/10');
    console.log(response.body);

    sleep(1);
};