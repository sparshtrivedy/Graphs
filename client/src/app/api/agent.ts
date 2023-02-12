import axios, { AxiosResponse } from "axios";

axios.defaults.baseURL = 'http://localhost:5000/api/';

const responseBody = (response: AxiosResponse) => response.data;

const requests = {
    get: (url: string) => axios.get(url).then(responseBody),
}

const Lumber = {
    list: () => requests.get('Lumbers'),
    open: () => requests.get('Lumbers/Open'),
    close: () => requests.get('Lumbers/Close'),
    date: () => requests.get('Lumbers/Date'),
    adjclose: () => requests.get('Lumbers/AdjClose'),
    high: () => requests.get('Lumbers/High'),
    low: () => requests.get('Lumbers/Low'),
    volume: () => requests.get('Lumbers/Volume'),
}

const agent = {
    Lumber
}

export default agent;