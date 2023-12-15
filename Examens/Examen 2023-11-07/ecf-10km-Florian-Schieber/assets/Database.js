class Database {

    static async fetchJson(_url) {

        let response = await fetch(_url);
        let responseJson = await response.json();
        return responseJson;

    }

}

export { Database };