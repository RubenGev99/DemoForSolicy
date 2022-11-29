import { FetchAccountDetail } from "./components/FetchAccountDetail";
import { FetchAccounts } from "./components/FetchAccounts";

const AppRoutes = [
  {
    path: '/',
    element: <FetchAccounts />
  },
  {
    path: '/accounts',
    element: <FetchAccounts />
  },
  {
      path: '/accounts/:id',
      element: <FetchAccountDetail />
  }
];

export default AppRoutes;
