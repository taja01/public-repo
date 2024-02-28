import http from 'k6/http'
import { sleep } from 'k6'

export let options = {
    insecureSkipTLSVerify: true,
    noConnectionReuse: false,
    stages: [
        { duration: '10s', target: 100 }, // belowe normal load
        { duration: '1m', target: 100 },
        { duration: '10s', target: 1400 }, //spike to 1400
        { duration: '3m', target: 1400 }, //stay at 1400 for 3 minutes
        { duration: '10s', target: 100 }, //scale down. Recovery stage
        { duration: '3m', target: 100 },
        { duration: '10s', target: 0 },
    ]
};

export default () => {
    let response = http.get('https://petstore.swagger.io/v2/store/order/10');
    console.log(response.body);

    sleep(1);
};