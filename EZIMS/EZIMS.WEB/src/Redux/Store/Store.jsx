import { configureStore } from '@reduxjs/toolkit'
import { setupListeners } from '@reduxjs/toolkit/query'
import { ApiSlice } from '../ApiSlice/ApiSlice'

export const store = configureStore({
    reducer: {
        [ApiSlice.reducerPath]: ApiSlice.reducer,
    }
})

// configure listeners using the provided defaults
setupListeners(store.dispatch)