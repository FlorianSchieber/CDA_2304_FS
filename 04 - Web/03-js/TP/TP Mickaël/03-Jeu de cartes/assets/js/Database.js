class Database {

    static async fetchJson(_url) {

        let result = await fetch(_url);
        let json = await result.json();

        return json;
    }
}

export {Database};