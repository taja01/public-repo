import http from 'k6/http'
import { sleep } from 'k6'

export let options = {
    insecureSkipTLSVerify: true,
    noConnectionReuse: false,
    stages: [
        { duration: '2m', target: 400 }, // ramp up to 400 users
        { duration: '3h56m', target: 400 }, // stay at 400 for ~4 hours
        { duration: '2m', target: 0 }, // scale down. (optional)
    ]
};

export default () => {

    http.batch([
        ['GET', 'https://petstore.swagger.io/v2/store/order/10']
        ['GET', 'https://petstore.swagger.io/v2/store/order/9']
    ]);

    sleep(1);
};