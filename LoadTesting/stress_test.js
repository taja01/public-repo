import http from 'k6/http'
import { sleep } from 'k6'

export let options = {
    insecureSkipTLSVerify: true,
    noConnectionReuse: false,
    stages: [
        // { duration: '2m', target: 100 }, // belowe normal load
        // { duration: '5m', target: 100 }, 
        // { duration: '2m', target: 200 }, //normal load
        // { duration: '5m', target: 200 }, 
        // { duration: '2m', target: 300 }, //around the breaking point
        // { duration: '5m', target: 300 },
        // { duration: '2m', target: 400 }, //beyond the breaking point
        // { duration: '5m', target: 400 },
        // { duration: '10m', target: 0 }, // scale down. Recovery stage.
        { duration: '10s', target: 10 }, // belowe normal load
        { duration: '20s', target: 20 },
        { duration: '10s', target: 30 }, // belowe normal load
        { duration: '20s', target: 50 },
        { duration: '10s', target: 0 }, // scale down. Recovery stage.
    ]
};

export default () => {

    http.batch([
        ['GET', 'https://petstore.swagger.io/v2/store/order/10']
        // ['GET', 'https://petstore.swagger.io/v2/store/order/9']
    ]);

    sleep(1);
};