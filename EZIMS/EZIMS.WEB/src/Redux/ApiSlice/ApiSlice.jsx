import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react';

const ApiSlice = createApi({
    baseQuery: fetchBaseQuery({ baseUrl: 'https://localhost:7207/' }),
    endpoints: builder => ({

        getItems: builder.query ({
            query: () => 'Item/GetItem'
        })
    })
})

export const {
    useGetItemsQuery,

} = ApiSlice